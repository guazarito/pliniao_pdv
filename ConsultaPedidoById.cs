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
    public partial class ConsultaPedidoById : Form
    {
        public ConsultaPedidoById()
        {
            InitializeComponent();
            grdConsultaPedido.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(txtNumPed.Text == "")
            {
                MessageBox.Show("Preencha o número do Pedido");
            }else
            {

                String select = "select id as 'Num Ped', nome as 'Nome', convert(varchar, data, 103) as 'Data', concat('R$ ',convert(varchar, cast(preco_total as money),1)) as 'Valor total', convert(varchar(1),isCancelado) as 'OBS' from vendas where id = " + txtNumPed.Text;
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
                grdConsultaPedido.ReadOnly = true;
                grdConsultaPedido.DataSource = ds.Tables[0];

                grdConsultaPedido.ClearSelection();

                conn.Close();

                if (grdConsultaPedido[4, grdConsultaPedido.CurrentRow.Index].Value.ToString() == "1")
                {
                    grdConsultaPedido[4, grdConsultaPedido.CurrentRow.Index].Value = "CANCELADO";
                    grdConsultaPedido.Rows[0].DefaultCellStyle.BackColor = Color.LightSalmon;
                }else
                {
                    grdConsultaPedido[4, grdConsultaPedido.CurrentRow.Index].Value = "";
                }
            }
        }

        private void txtNumPed_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            }
        }

        private void grdConsultaPedido_DoubleClick(object sender, EventArgs e)
        {
            int idp = Convert.ToInt32(grdConsultaPedido[0, grdConsultaPedido.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);
            // frm.MdiParent = c;
            frm.Show();
        }
    }
}
