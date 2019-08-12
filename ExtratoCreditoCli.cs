using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using ImprimeTicketNE;

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

                String query = "select convert(varchar, cast(valor as money),1) as 'valor' , convert(varchar, data, 103) as 'data', isnull(obs, '') as 'obs'  from extratoCreditoCli where id_cliente = " + id_cli + " and convert(date, data,103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "' order by id";

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
                    String sinal = "";

                    if (dr.HasRows)
                    {
                        tvCredito.Nodes.Clear(); 
                        int i = 0;
                        TreeNode tnDtCredito = new TreeNode(dr["data"].ToString());
                        while (dr.Read())
                        {

                            if (i == 0)
                            {
                                //TreeNode tnDtCredito = new TreeNode(dr["data"].ToString());
                                tvCredito.Nodes.Add(tnDtCredito);

                                if (float.Parse(dr["valor"].ToString()) < 0)
                                {
                                    sinal = " -";
                                }
                                else
                                {
                                    sinal = "+";
                                }

                                if (dr["obs"].ToString() != "")
                                {
                                    tnDtCredito.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", "") + " (" + dr["obs"].ToString() + ")");
                                }
                                else
                                {
                                    tnDtCredito.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", ""));
                                }

                                if (sinal == "+")
                                {
                                    tnDtCredito.Nodes[i.ToString()].ForeColor = Color.DarkGreen;
                                }
                                else
                                {
                                    tnDtCredito.Nodes[i.ToString()].ForeColor = Color.DarkRed;
                                }

                                
                                tvCredito.Select();


                            }
                            else if (i > 0)
                            {
                                if (tvCredito.SelectedNode.Text.ToString() == dr["data"].ToString())
                                {
                                    if (float.Parse(dr["valor"].ToString()) < 0)
                                    {
                                        sinal = " -";
                                    }
                                    else
                                    {
                                        sinal = "+";
                                    }

                                    if (dr["obs"].ToString() != "")
                                    {
                                        tvCredito.SelectedNode.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", "") + " (" + dr["obs"].ToString() + ")");
                                        if (sinal == "+")
                                        {
                                            tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkGreen;
                                        }
                                        else
                                        {
                                            tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkRed;
                                        }

                                    }
                                    else
                                    {
                                        tvCredito.SelectedNode.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", ""));
                                        if (sinal == "+")
                                        {
                                            tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkGreen;
                                        }
                                        else
                                        {
                                            tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkRed;
                                        }

                                    }
                                }
                                else
                                {
                                    if (float.Parse(dr["valor"].ToString()) < 0)
                                    {
                                        sinal = " -";
                                    }
                                    else
                                    {
                                        sinal = "+";
                                    }
                                    tvCredito.SelectedNode = tvCredito.Nodes.Add(dr["data"].ToString());

                                    if (dr["obs"].ToString() != "")
                                    {
                                        tvCredito.SelectedNode.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", "") + " (" + dr["obs"].ToString() + ")");
                                    }
                                    else
                                    {
                                        tvCredito.SelectedNode.Nodes.Add(i.ToString(), sinal + " R$ " + dr["valor"].ToString().Replace("-", ""));
                                    }

                                    if (sinal == "+")
                                    {
                                        tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkGreen;
                                    }
                                    else
                                    {
                                        tvCredito.SelectedNode.Nodes[i.ToString()].ForeColor = Color.DarkRed;
                                    }

                                    //   continue;
                                }
                            }
                            i++;

                        }
                        tvCredito.ExpandAll();
                        tvCredito.SelectedNode = null;

                        btnImprimir.Enabled = true;
                    }else
                    {
                        btnImprimir.Enabled = true;
                    }

                }
                catch (Exception eex)
                {

                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            ImprimeTicket i = new ImprimeTicket();
            String saldo_atual = c.getSaldoCreditoCliente(txtNomeCli.SelectedValue.ToString());

            i.ImprimeExtratoCreditos(txtNomeCli.SelectedValue.ToString(), txtNomeCli.Text,  tvCredito, saldo_atual, dtIni.Value.ToString("yyyy-MM-dd"));
        }
    }
}
