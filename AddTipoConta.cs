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
    public partial class AddTipoConta : Form
    {
        ComboBox cboTp;

        public AddTipoConta(ComboBox cbo)
        {
            InitializeComponent();
            PreencheGrid();
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows[0].Selected = false;
            }
            dataGridView1.ClearSelection();

            this.dataGridView1.CellClick +=new DataGridViewCellEventHandler(dataGridView1_CellClick);

            cboTp = cbo;
           
        }

       
        conexao c = new conexao();
        private bool clicouEditar = false;


      

        public void dataGridView1_CellClick(Object sender, EventArgs e)
        {

            btnDeletar.Enabled = true;
            btnEditar.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (!clicouEditar)
            {
                c.ExecutaQuery("insert into tipo_contas_pagar values('" + txtTipoConta.Text.ToString() + "')");
                PreencheGrid();
            }
            else
            {
                c.ExecutaQuery("update tipo_contas_pagar set descricao='" + txtTipoConta.Text.ToString() + "' where id="+dataGridView1[0,dataGridView1.CurrentRow.Index].Value.ToString());
                PreencheGrid();
            }

            if (cboTp != null)
            {
                c.fillCombo(cboTp, "select id, descricao from tipo_contas_pagar", "id", "descricao");
                cboTp.SelectedIndex = -1;
            }
            //...
            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
            clicouEditar = false;
            txtTipoConta.Text = "";
        }


        public void PreencheGrid()
        {
            String sQuery;

            sQuery = "select id,ROW_NUMBER() over(order by id) as 'Item', descricao as 'Descrição' from tipo_contas_pagar";
            
            sQuery = sQuery + " order by descricao";


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

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];

           

            dataGridView1.Columns[0].Visible = false; //ID

            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.ClearSelection();

           

            conn.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clicouEditar = true;

            txtTipoConta.Text = c.RetornaQuery("select descricao from tipo_contas_pagar where id=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(), "descricao");
       
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            c.ExecutaQuery("delete from tipo_contas_pagar where id=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            PreencheGrid();

            if (cboTp != null)
            {
                c.fillCombo(cboTp, "select id, descricao from tipo_contas_pagar", "id", "descricao");
                cboTp.SelectedIndex = -1;
            }

            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
        }

      

        private void AddTipoConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cboTp != null)
            {
                c.fillCombo(cboTp, "select id, descricao from tipo_contas_pagar", "id", "descricao");
                cboTp.SelectedIndex = -1;
            }
        }
    }
}
