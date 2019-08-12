using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication2
{
    public partial class PagtosPendentes : Form
    {
        public PagtosPendentes()
        {
            InitializeComponent();

            String sQueryPendentes = "select c.nome as 'Cliente', concat('R$ ',convert(varchar, cast(sum(v.preco_total - (v.preco_total*v.desconto)) as money),1)) as 'Valor Total', c.id from vendas v left outer join clientes c on c.id=v.id_cliente where v.is_pagto_pendente=1 and v.isCancelado<>1 group by c.id, c.nome";

            preencheGrid(grdPagtosPendentes, sQueryPendentes);
            grdPagtosPendentes.Columns[2].Visible = false; //coluna do ID do cliente

            CalculaValorTotal();

            tabPagtosQuitados.SelectedIndexChanged +=new EventHandler(tabPagtosQuitados_SelectedIndexChanged);
        }

        public void tabPagtosQuitados_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabPagtosQuitados.SelectedIndex == 1) //pagamentos quitados 
            {
                String query_quitados = "select c.nome as 'Cliente', concat('R$ ',convert(varchar, cast(sum(v.preco_total - (v.preco_total*v.desconto)) as money),1)) as 'Valor Total', convert(varchar, ppq.data_quitacao, 103) as 'Data pagamento' from pedidos_pendentes_quitados ppq left outer join vendas v on v.id=ppq.id_pedido left outer join clientes c on c.id=v.id_cliente where v.isCancelado<>1 group by c.id, c.nome, ppq.data_quitacao order by data_quitacao";
                preencheGrid(grdPagamentosQuitados, query_quitados);
                grdPagamentosQuitados.ClearSelection();

                int rowscount = grdPagamentosQuitados.Rows.Count;
                double preco_total;

                preco_total = 0;

                for (int i = 0; i < rowscount; i++)
                {
                    preco_total = preco_total + double.Parse(grdPagamentosQuitados.Rows[i].Cells[1].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
                }

                txtPrecoTotalPagamentosQuitados.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");
            

            }
        }

        public void CalculaValorTotal()
        {
            int rowscount = grdPagtosPendentes.Rows.Count;
            double preco_total;

            preco_total = 0;

            for (int i = 0; i < rowscount; i++)
            {
                preco_total = preco_total + double.Parse(grdPagtosPendentes.Rows[i].Cells[1].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
            }

            txtPrecoTotalPendente.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");
            

        }

        public void preencheGrid(DataGridView grd, String query)
        {
            DataSet ds = null;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" + 
            "Pwd=chico110388;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(query, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            ds = new DataSet();
            dataAdapter.Fill(ds);
            grd.ReadOnly = true;
            grd.DataSource = ds.Tables[0];
            grd.ClearSelection();

            conn.Close();
        }

        private void load(object sender, EventArgs e)
        {
            grdPagtosPendentes.ClearSelection();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcelPgtosPendentes_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            int i, j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i < grdPagtosPendentes.RowCount; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    xlWorkSheet.Cells[1, j + 1] = grdPagtosPendentes.Columns[j].HeaderText.ToString();


                    xlWorkSheet.Cells[i + 2, j + 1] = grdPagtosPendentes[j, i].Value.ToString();


                }
            }

            xlWorkSheet.Cells[i + 2, 1] = "Total:";
            xlWorkSheet.Cells[i + 2, 2] = txtPrecoTotalPendente.Text.ToString();

            DialogResult result = folderBrowserDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                String sData;
                sData = DateTime.Now.ToString("g").Replace("/", "");
                sData = sData.Replace(" ", "_");
                sData = sData.Replace(":", "");

                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/pagamentos_pendentes_pliniao_" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();

                releaseObject(xlWorkSheet);
                releaseObject(xlWorkBook);
                releaseObject(xlApp);

                MessageBox.Show("Concluído");
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void abrePedidoPagtoPendente(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = int.Parse(grdPagtosPendentes[2, grdPagtosPendentes.CurrentRow.Index].Value.ToString());
            QuitarPagtosPendentes frm = new QuitarPagtosPendentes(id, grdPagtosPendentes, txtPrecoTotalPendente);
            frm.Show();

        }

        private void buscaCli(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdPagtosPendentes.Rows)
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
