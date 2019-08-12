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
    public partial class ConsultaPedidosCancelados : Form
    {
        public ConsultaPedidosCancelados()
        {
            InitializeComponent();

            grdConsultaVendasCanceladas.DoubleClick += new EventHandler(abreProduto);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //vendas canc:..................................................
            string select = "select right('000000' + cast(id as nvarchar),6) as 'Núm. Pedido', CONCAT(nome, '  ' ,obs) as 'Nome', convert(varchar, cast(preco_total - (preco_total*desconto) as money),1) as 'Preço Total', convert(varchar(5),data, 114) as 'Hora do Pedido', concat(datediff(mi,data, GETDATE()), ' min') as 'Tempo de Espera'  from vendas where convert(varchar(11),data,103)=convert(varchar(11),'" + dtConsulta.Text.ToString() + "',103) and isCancelado=1";

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
            grdConsultaVendasCanceladas.ReadOnly = true;
            grdConsultaVendasCanceladas.DataSource = ds.Tables[0];

            grdConsultaVendasCanceladas.Columns[0].Width = 100;
            grdConsultaVendasCanceladas.Columns[1].Width = 300;
            grdConsultaVendasCanceladas.Columns[2].Width = 100;
            grdConsultaVendasCanceladas.Columns[3].Width = 100;
            grdConsultaVendasCanceladas.Columns[4].Width = 0;
            grdConsultaVendasCanceladas.Columns[4].Visible = false;

            grdConsultaVendasCanceladas.ClearSelection();


            //...................................................................
        }

        public void abreProduto(Object sender, EventArgs e)
        {
            // MDIParent1 parent = new MDIParent1();           

            int idp = Convert.ToInt32(grdConsultaVendasCanceladas[0, grdConsultaVendasCanceladas.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);
            frm.Show();
        }
    }
}
