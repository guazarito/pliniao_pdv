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
    public partial class FrmFilaImpressao : Form
    {
        private DataSet ds = null;

        public FrmFilaImpressao()
        {
            InitializeComponent();

            

            //preenche grd fila impr
            String sFilaImpr = "select id_pedido as 'Pedido', nome as 'Nome', obs as 'Obs', convert(varchar,data,108) as 'Hora', status as 'Status' from fila_impressao fl left outer join vendas v on v.id=fl.id_pedido order by status desc";

            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
            conn.Open();

            OdbcDataAdapter dataAdapter3 = new OdbcDataAdapter(sFilaImpr, conn);

            OdbcCommandBuilder commandBuilder3 = new OdbcCommandBuilder(dataAdapter3);
            ds = new DataSet();
            dataAdapter3.Fill(ds);
            grdFilaImpressao.ReadOnly = true;
            grdFilaImpressao.DataSource = ds.Tables[0];



            grdFilaImpressao.ClearSelection();

            //fim preenche fila impr

        }
    }
}
