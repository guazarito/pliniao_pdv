using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{
    public partial class ExtratoCreditoCli : Form
    {
        conexao c = new conexao();

        public ExtratoCreditoCli()
        {
            InitializeComponent();
            c.fillCombo(this.txtNomeCli, "select * from clientes order by nome", "id", "nome");
            txtNomeCli.SelectedValue = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.SelectedIndex == 0 || txtNomeCli.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um cliente", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
                String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

                String id_cli = txtNomeCli.SelectedValue.ToString();

                String query = "select convert(varchar, cast(valor_credito as money),1) as 'valor_credito' , convert(varchar, data, 103) as 'data'  from historico_credito_dado where id_cliente = " + id_cli + " and isnull(obs, '') = '' and convert(date, data,103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "' order by id";

                var conn = new OdbcConnection();
                conn.ConnectionString =
                              "Dsn=odbc_pliniao;" +
                              "Uid=sa;" +
                              "Pwd=chico110388;";

                try
                {
                    conn.Open();
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados.\n" + e);
                }

                try
                {
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {

                        int i = 0;
                        TreeNode tnDtCredito = new TreeNode(dr["data"].ToString());
                        while (dr.Read())
                        {

                            if (i == 0)
                            {
                                //TreeNode tnDtCredito = new TreeNode(dr["data"].ToString());
                                tvCredito.Nodes.Add(tnDtCredito);
                                
                                tnDtCredito.Nodes.Add("+ R$ " + dr["valor_credito"].ToString());
                         
                            }
                            else if (i > 0)
                            {
                                if (tnDtCredito.Text == dr["data"].ToString())
                                {
                                    tnDtCredito.Nodes.Add("+ R$ " + dr["valor_credito"].ToString());

                                }
                                else
                                {
                                    tvCredito.SelectedNode = tvCredito.Nodes.Add(dr["data"].ToString());
                                    
                                    tvCredito.SelectedNode.Nodes.Add("+ R$ " + dr["valor_credito"].ToString());

                                    i = 0;
                                    continue;
                                }
                            }
                            i++;

                        }
                    }

                }
                catch (Exception eex)
                {

                }
            }
        }
    }
}
