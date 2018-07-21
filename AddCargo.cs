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
    public partial class AddCargo : Form
    {
        ComboBox cboCargo;

        public AddCargo(ComboBox cbo)
        {
            
            InitializeComponent();
            PreencheGrid();
            dataGridView1.ClearSelection();

            this.dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellClick);

            cboCargo = cbo;
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
                c.ExecutaQuery("insert into cargos_func values('" + txtCargo.Text.ToString() + "')");
                PreencheGrid();
            }
            else
            {
                c.ExecutaQuery("update cargos_func set descricao='" + txtCargo.Text.ToString() + "' where id=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
                PreencheGrid();
            }

            if (cboCargo != null)
            {
                c.fillCombo(cboCargo, "select id, descricao from cargos_func", "id", "descricao");
                cboCargo.SelectedIndex = -1;
            }
            //...
            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
            clicouEditar = false;
            txtCargo.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            c.ExecutaQuery("delete from cargos_func where id=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString());
            PreencheGrid();

            if (cboCargo != null)
            {
                c.fillCombo(cboCargo, "select id, descricao from cargos_func", "id", "descricao");
                cboCargo.SelectedIndex = -1;
            }

            btnDeletar.Enabled = false;
            btnEditar.Enabled = false;
        }

        public void PreencheGrid()
        {
            String sQuery;

            sQuery = "select id,ROW_NUMBER() over(order by id) as 'Item', descricao as 'Descrição' from cargos_func";

            sQuery = sQuery + " order by descricao";


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

            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];



            dataGridView1.Columns[0].Visible = false; //ID

            dataGridView1.Columns[1].Width = 30;
            dataGridView1.Columns[2].Width = 150;

            dataGridView1.ClearSelection();



            conn.Close();
        }

        private void AddCargo_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cboCargo != null)
            {
                c.fillCombo(cboCargo, "select id, descricao from cargos_func", "id", "descricao");
                cboCargo.SelectedIndex = -1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clicouEditar = true;

            txtCargo.Text = c.RetornaQuery("select descricao from cargos_func where id=" + dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString(), "descricao");
       
        }




    }
}
