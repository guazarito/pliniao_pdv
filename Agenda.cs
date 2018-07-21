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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();

            grdClientesAg.CellMouseClick += new DataGridViewCellMouseEventHandler(grdClientesAg_CellMouseClick);

            preencheGrid();
        }

        Boolean is_editing = false;
        conexao c = new conexao();

        public void grdClientesAg_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdClientesAg.RowCount > 0)
            {
                is_editing = true;
                btnDeletarCliAg.Visible = true;

                txtNomeCliAg.Text = c.RetornaQuery("select nome from agenda where id=" + grdClientesAg[0, grdClientesAg.CurrentRow.Index].Value.ToString(), "nome");
                txtEndCliAg.Text = c.RetornaQuery("select endereco from agenda where id=" + grdClientesAg[0, grdClientesAg.CurrentRow.Index].Value.ToString(), "endereco");
                txtTelCliAg.Text = c.RetornaQuery("select telefone from agenda where id=" + grdClientesAg[0, grdClientesAg.CurrentRow.Index].Value.ToString(), "telefone");

            }
        }

        private void btnSalvarCliAg_Click(object sender, EventArgs e)
        {

            if (txtNomeCliAg.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório", "Preencha nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nome = txtNomeCliAg.Text;
                String endereco = txtEndCliAg.Text;
                String telefone = txtTelCliAg.Text;
               
                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into agenda values('" + nome + "', '" + endereco + "', '" + telefone +"')");
                        preencheGrid();
                        btnLimparCliAg_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update agenda set nome='" + nome + "', endereco= '" + endereco + "', telefone= '" + telefone + "' where id =" + grdClientesAg[0, grdClientesAg.CurrentRow.Index].Value.ToString());
                    preencheGrid();
                    btnLimparCliAg_Click(new Object(), new EventArgs());
                }
            }

            is_editing = false;
        }

        private void btnLimparCliAg_Click(object sender, EventArgs e)
        {
            txtEndCliAg.Text = "";
            txtNomeCliAg.Text = "";
            txtTelCliAg.Text = "";
            grdClientesAg.ClearSelection();
            btnDeletarCliAg.Visible = false;
        }

        private void btnDeletarCliAg_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deletar?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("delete from agenda where id=" + grdClientesAg[0, grdClientesAg.CurrentRow.Index].Value.ToString());
                preencheGrid();
                btnLimparCliAg_Click(new Object(), new EventArgs());
                is_editing = false;
            }
        }


        public void preencheGrid()
        {
            String sQuery;




            sQuery = "select id, nome as 'Nome', endereco as 'Endereço', telefone as 'Telefone' from agenda order by nome";




            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            ds = new DataSet();

            dataAdapter.Fill(ds);

            grdClientesAg.ReadOnly = true;

            grdClientesAg.DataSource = ds.Tables[0];

            grdClientesAg.CurrentCell = null;



            grdClientesAg.Columns[0].Visible = false;
            grdClientesAg.ClearSelection();

            conn.Close();
        }

        private void load(object sender, EventArgs e)
        {
            grdClientesAg.ClearSelection();
        }
    }
}
