using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;


namespace WindowsFormsApplication2
{
    public partial class frmConsulta : Form
    {
        
        public frmConsulta()
        {

            InitializeComponent();


            conexao c = new conexao();
            c.fillCombo(this.cboConsulta, "select id, descr from produto", "id", "descr");
            this.cboConsulta.SelectedIndex = -1;
            this.grdConsulta.DoubleClick += new EventHandler(edita_produto_from_consultaForm);
            this.cboConsulta.KeyDown += new KeyEventHandler(cboConsulta_KeyDown);

            this.grdConsultaVendas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdConsultaVendas.MultiSelect = false;


            //this.grdConsultaVendas.DoubleClick += new EventHandler(abreProduto);

            grdConsultaVendas.DoubleClick += new EventHandler(abreProduto);


        }

        public void abreProduto(Object sender, EventArgs e)
        {
           // MDIParent1 parent = new MDIParent1();           

            int idp = Convert.ToInt32(grdConsultaVendas[0, grdConsultaVendas.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);
           // frm.MdiParent = c;
            frm.Show();            
        }

        public void cboConsulta_KeyDown(Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(null, null);
            }
        }

        public void edita_produto_from_consultaForm(Object sender, EventArgs e)
        {
            int idprod = Convert.ToInt32(grdConsulta[0, grdConsulta.CurrentRow.Index].Value);
            frmCadastro newMDIChild3 = new frmCadastro(idprod);
            
            newMDIChild3.Show();
        }

        private void btnBuscar_Click1(object sender, EventArgs e)
        {
            frmPedido newMDIChild = new frmPedido(Convert.ToInt32(grdConsultaVendas[0,grdConsultaVendas.CurrentRow.Index]));

            newMDIChild.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String sQuery = "1=1";

            if (cboConsulta.Text != "")
            {
                sQuery = " descr like '%" + cboConsulta.Text + "%'";
            }

            string select = "SELECT id as Código, descr as Descrição, convert(varchar, cast(preco as money),1) as Preço FROM produto where " + sQuery;
            conexao c = new conexao();
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdConsulta.ReadOnly = true;
            grdConsulta.DataSource = ds.Tables[0];

            grdConsulta.Columns[0].Width = 100;
            grdConsulta.Columns[1].Width = 300;
            grdConsulta.Columns[2].Width = 100;


        }

        public void toolStripButton1_Click(object sender, EventArgs e)
        {
            //vendas abertas:..................................................
//            string select = "select right('00000' + cast(id as nvarchar),5) as 'Núm. Pedido', CONCAT(nome, '  ' ,obs) as 'Nome', convert(varchar, cast(preco_total-(preco_total*desconto) as money),1) as 'Preço Total', convert(varchar(5),data, 114) as 'Hora do Pedido', concat(datediff(mi,data, GETDATE()), ' min') as 'Tempo de Espera'  from vendas where convert(varchar(11),data,103)=convert(varchar(11),'" + dtConsulta.Text.ToString() + "',103) and isCancelado<>1";
            string select = "select right('00000' + cast(id as nvarchar),5) as 'Núm. Pedido', CONCAT(nome, '  ' ,obs) as 'Nome', convert(varchar, cast(preco_total - (preco_total*desconto) as money),1) as 'Preço Total', convert(varchar(5),data, 114) as 'Hora do Pedido', concat(datediff(mi,data, GETDATE()), ' min') as 'Tempo de Espera'  from vendas where convert(varchar(11),data,103)=convert(varchar(11),'" + dtConsulta.Text.ToString() + "',103) and isCancelado<>1";

            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdConsultaVendas.ReadOnly = true;
            grdConsultaVendas.DataSource = ds.Tables[0];

            grdConsultaVendas.Columns[0].Width = 100;
            grdConsultaVendas.Columns[1].Width = 300;
            grdConsultaVendas.Columns[2].Width = 100;
            grdConsultaVendas.Columns[3].Width = 100;
            grdConsultaVendas.Columns[4].Width = 0;
            grdConsultaVendas.Columns[4].Visible = false;

            grdConsultaVendas.ClearSelection();



            //int i;
            //decimal preco_total;

            //for (i = 0; i < grdConsultaVendas.RowCount; i++)
            //{
            //    preco_total = Convert.ToDecimal(grdConsultaVendas[2, i].Value);
            //    grdConsultaVendas[2, i].Value = "R$ " + String.Format("{0:n2}", preco_total).Replace(",", ".");
            //}

            //...................................................................
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripButton1_Click(new object(), new EventArgs());
        }

        private void buscaProduto(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdConsultaVendas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    if (txtBusca.Text != "")
                    {
                        if (cell.Value.ToString().Trim().ToUpper().Contains(txtBusca.Text.Trim().ToUpper()))
                        {
                            //MessageBox.Show(row.Index.ToString());
                            cell.Style.BackColor = Color.Salmon;
                        }
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }


    }

}

