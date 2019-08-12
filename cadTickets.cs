using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Odbc;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class cadTickets : Form
    {
        public cadTickets()
        {
            InitializeComponent();
            preencheGrid();
        }

        Boolean is_editing = false;
        conexao c = new conexao();

        public void preencheGrid()
        {
            String sQuery;




            sQuery = "select id as 'Id', ticket as 'Ticket' from tp_tickets order by id";




            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            ds = new DataSet();

            dataAdapter.Fill(ds);

            grdTickets.ReadOnly = true;

            grdTickets.DataSource = ds.Tables[0];

            grdTickets.CurrentCell = null;



            //grdTickets.Columns[0].Visible = false;
            grdTickets.ClearSelection();

            conn.Close();
        }


        private void btnSalvarCliAg_Click(object sender, EventArgs e)
        {

            if (txtNomeTicket.Text == "")
            {
                MessageBox.Show("O campo Nome do ticket é obrigatório", "Preencha nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nome_ticket = txtNomeTicket.Text;
               
                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into tp_tickets values('" + nome_ticket + "')");
                        preencheGrid();
                        txtNomeTicket.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update tp_tickets set ticket='" + nome_ticket + "' where id =" + grdTickets[0, grdTickets.CurrentRow.Index].Value.ToString());
                    preencheGrid();
                }
            }

            is_editing = false;
        }

        private void grdTickets_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdTickets.RowCount > 0)
            {
                is_editing = true;
                btnDeletarTicket.Enabled = true;

                txtNomeTicket.Text = c.RetornaQuery("select ticket from tp_tickets where id=" + grdTickets[0, grdTickets.CurrentRow.Index].Value.ToString(), "ticket");
  
            }
        }

        private void btnDeletarTicket_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deletar?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                c.ExecutaQuery("delete from tp_tickets where id=" + grdTickets[0, grdTickets.CurrentRow.Index].Value.ToString());
                preencheGrid();
                
                is_editing = false;
            }
        }
    }
}
