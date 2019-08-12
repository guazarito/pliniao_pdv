using System;

using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data.Odbc;
using Excel = Microsoft.Office.Interop.Excel;
using ImprimeTicketNE;

namespace WindowsFormsApplication2
{
    public partial class QuitarPagtosPendentes : Form
    {
        conexao c = new conexao();
        String sQuery;
        String sQuery2;
        int id_cli;
        DataGridView grdPagtosPendentes_formAnterior;
        TextBox txtValorTotalPagtosPendentes_formAnterior;

        public QuitarPagtosPendentes(int id_cliente, DataGridView grdPagtosPendentes_form_anterior_param, TextBox txtValorTotalPagtosPendentes_param)
        {
            InitializeComponent();

            id_cli = id_cliente;

                   sQuery = "select right('000000' + cast(v.id as nvarchar),6) as 'Núm. Pedido',";
                   sQuery += " convert(varchar,v.data,103) as 'Data', concat('R$ ',convert(varchar, cast((v.preco_total - (v.preco_total*v.desconto)) as money),1)) as 'Valor'";
                   sQuery += " from vendas v left outer join clientes c on c.id=v.id_cliente";
                   sQuery += " where v.is_pagto_pendente=1 and v.isCancelado<>1 and c.id=" + id_cliente.ToString();

            preencheGrid(grdQuitarPagtosPendentes, sQuery);

            //sQuery2 = "select sum(vi.qtt) as 'Qtde', p.descr as 'Descrição', concat('R$ ', convert(varchar, cast(sum((vi.qtt * vi.preco_item)) - sum((vi.qtt * vi.preco_item)) * v.desconto as money), 1)) as 'Preço Total Item' from vendas v left outer join vendas_itens vi on v.id = vi.id_venda left outer join clientes c on c.id = v.id_cliente left outer join produto p on p.id = vi.id_prod where isnull(is2Formaspagto_PagtoPend_Credito,0)<>1 and v.is_pagto_pendente = 1 and v.isCancelado <> 1 and v.id_cliente = " + id_cliente.ToString() + " group by p.descr, v.desconto order by p.descr ";

            sQuery2 = "select sum(vi.qtt) as 'Qtde', p.descr as 'Descrição', concat('R$ ', convert(varchar, cast(sum((vi.qtt * vi.preco_item)) - sum((vi.qtt * vi.preco_item)) * v.desconto as money), 1)) as 'Preço Total Item' from vendas v left outer join vendas_itens vi on v.id = vi.id_venda left outer join clientes c on c.id = v.id_cliente left outer join produto p on p.id = vi.id_prod ";
            sQuery2 += "where v.is_pagto_pendente = 1 and v.isCancelado <> 1  and isnull(is2Formaspagto_PagtoPend_Credito,0)<> 1 and v.id_cliente =" + id_cliente.ToString() + " group by p.descr, v.desconto ";
            sQuery2 += "UNION ALL select vi.qtt,p.descr, concat('R$ ', convert(varchar, cast(v.preco_total as money), 1)) from vendas v left outer join vendas_itens vi on vi.id_venda = v.id ";
            sQuery2 += "left outer join produto p on p.id = vi.id_prod where is_pagto_pendente = 1 and is2Formaspagto_PagtoPend_Credito = 1 and v.isCancelado <> 1 and id_cliente= " + id_cliente.ToString() + " order by p.descr ";


           // String sQuery_2formas = "select vi.qtt,p.descr, v.preco_total from vendas v left outer join vendas_itens vi on vi.id_venda = v.id left outer join produto p on p.id = vi.id_prod where is_pagto_pendente = 1 and is2Formaspagto_PagtoPend_Credito = 1 and id_cliente = " + id_cliente.ToString();


            preencheGrid(grdResumoQuitar, sQuery2);

            label1.Text = c.RetornaQuery("select nome from clientes where id=" + id_cliente.ToString(),"nome");
            CalculaValorTotal();
            grdPagtosPendentes_formAnterior = grdPagtosPendentes_form_anterior_param;
            txtValorTotalPagtosPendentes_formAnterior = txtValorTotalPagtosPendentes_param;

            grdResumoQuitar.ClearSelection();
        }

        public void CalculaValorTotal()
        {
            int rowscount = grdQuitarPagtosPendentes.Rows.Count;
            double preco_total;

            preco_total = 0;

            for (int i = 0; i < rowscount; i++)
            {
                preco_total = preco_total + double.Parse(grdQuitarPagtosPendentes.Rows[i].Cells[2].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
            }

            txtPrecoTotalQuitarPendente.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");
        }

        public void preencheGrid(DataGridView grd, String query)
        {
            DataSet ds = null;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
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
            grdQuitarPagtosPendentes.ClearSelection();
        }

        private void abreProduto(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idp = Convert.ToInt32(grdQuitarPagtosPendentes[0, grdQuitarPagtosPendentes.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);
            frm.Show();    
        }

        private void CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnQuitarSel.Enabled = true;

            txtTotalSelecionado.Enabled = true;
            lblRSsel.Enabled = true;
            lblTotalSelecionado.Enabled = true;

            double aux_preco_sel;
            aux_preco_sel = 0;

            int rowscount = grdQuitarPagtosPendentes.Rows.Count;


            for (int i = 0; i < rowscount; i++)
            {
                if (grdQuitarPagtosPendentes[1, i].Selected)
                {
                    aux_preco_sel = aux_preco_sel + double.Parse(grdQuitarPagtosPendentes[2, i].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
                }
            }


            txtTotalSelecionado.Text = String.Format("{0:n2}", aux_preco_sel).Replace(",", ".");


        }

        private void btnQuitarSel_Click(object sender, EventArgs e)
        {
            string szTextoCli_itens = "";

            if (chkDin.Checked == true || chkDebito.Checked == true || chkCredito.Checked == true)
            {
                if (MessageBox.Show("Quitar Selecionados ?", "Ctz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {

                        foreach (DataGridViewRow r in grdQuitarPagtosPendentes.SelectedRows)
                        {
                            String data_do_ped = c.RetornaQuery("select data from vendas where id=" + grdQuitarPagtosPendentes[0, r.Index].Value.ToString(), "data").Replace("-", "/");
                            String data_pedido_impressao;
                            data_do_ped = data_do_ped.Remove(10);
                            DateTime dt_pedo = DateTime.Parse(data_do_ped);
                            data_pedido_impressao = dt_pedo.ToString("dd/MM/yyyy");
                            data_do_ped = dt_pedo.ToString("MM-dd-yyyy");
                            data_do_ped = data_do_ped + " 00:00:00";

                            String d_hoje;
                            DateTime dt_hoje = DateTime.Now;
                            d_hoje = dt_hoje.ToString("MM-dd-yyyy");

                            String dinheiroRecebido = "0";
                            
                            if (txtDin.Text != "")
                            {
                                dinheiroRecebido = txtDin.Text;
                            }

                            //============================FORMA PAGTO CODIGOS===============================
                            int formaPagto = 0;
                            //1 ->Dinheiro
                            //6 ->Cartao Débito
                            //7 ->Cartao Crédito
                            //============================FORMA PAGTO CODIGOS===============================

                            if (chkDin.Checked == true)
                            {
                                formaPagto = 1;
                            }
                            else if (chkDebito.Checked == true)
                            {
                                formaPagto = 6;
                            }
                            else if (chkCredito.Checked == true)
                            {
                                formaPagto = 7;
                            }


                            c.ExecutaQuery("begin transaction declare @id int set @id=" + grdQuitarPagtosPendentes[0, r.Index].Value.ToString() + " update vendas set is_pagto_pendente=0, forma_pagto=" + formaPagto.ToString() + ", dinheiro_recebido=" + dinheiroRecebido + " where id=@id insert into pedidos_pendentes_quitados values(@id, '" + d_hoje + "') commit");


                            if (chkImprimeRecibo.Checked)
                            {

                                szTextoCli_itens += "<c>    " + grdQuitarPagtosPendentes[0, r.Index].Value.ToString() + "           " + data_pedido_impressao + "        " + grdQuitarPagtosPendentes[2, r.Index].Value.ToString() + "</c>\n";

                            }


                        }

                        if (chkImprimeRecibo.Checked)
                        {
                            ImprimeTicket imprime = new ImprimeTicket();






                            String szTextoCli = "";


                            szTextoCli = "<ce>------------------------------------------\n</ce>";
                            szTextoCli += "<ce><c><e><b>MARMITARIA PLINIÃO</b></e>\n";
                            szTextoCli += "CNPJ: 22.095.906/0001-70   Inscrição Estadual: 181.233.395.114\n";
                            szTextoCli += "Rua: Mario Ybarra de Almeida, 295   Bairro: Centro\n";
                            szTextoCli += "<b>Tel: (16) 3472-0905</b>   Cidade: Araraquara/SP\n";
                            szTextoCli += "--------------------------------------------------------\n\n";
                            szTextoCli += "<e><b><s>RECIBO</s></b></e>\n\n";
                            szTextoCli += "</c></ce><c>----------------------------------------------------------------\n";
                            szTextoCli += "Num. Pedido       Data Pedido       Total Pedido\n";
                            szTextoCli += "----------------------------------------------------------------\n</c>";

                            szTextoCli += szTextoCli_itens;

                            szTextoCli += "<c>----------------------------------------------------------------</c>\n";
                            szTextoCli += "<b><ad>VALOR TOTAL: " + txtTotalSelecionado.Text.ToString() + "</ad></b>\n";

                            szTextoCli += "<c>----------------------------------------------------------------</c>\n";
                            szTextoCli += "<c><ce>";
                            szTextoCli += "Emissão " + DateTime.Now.ToString("g") + "</c></ce>\n\n";
                            szTextoCli += "<ce><b></c><c><b>Cliente:</c></b>\n";
                            szTextoCli += "<c><e><s>" + label1.Text + "</s></e></c>\n\n";
                            szTextoCli += "</b></ce><c><ce>Cardápio diário em:</c>\n";
                            szTextoCli += "<c>www.facebook.com/marmitariapliniao \n";
                            szTextoCli += "";
                            szTextoCli += "</ce></c>";
                            szTextoCli += "<c><ce>--------------------------------------------------------</ce></c>\n";
                            szTextoCli += "<c><ce><b>OBRIGADO PELA PREFERÊNCIA, VOLTE SEMPRE</b></ce></c>\n";
                            szTextoCli += "<c><ce>--------------------------------------------------------</ce></c>\n";
                            szTextoCli += "<gui></gui>";

                            imprime.ImprimeTkt(szTextoCli, "");

                            if (MessageBox.Show("Imprimir 2a via?", "Outra via?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                imprime.ImprimeTkt(szTextoCli, "");
                            }
                        }


                        preencheGrid(grdQuitarPagtosPendentes, sQuery);
                        CalculaValorTotal();
                        btnQuitarSel.Enabled = false;

                        txtTotalSelecionado.Enabled = false;
                        txtTotalSelecionado.Text = "";
                        lblRSsel.Enabled = false;
                        lblTotalSelecionado.Enabled = false;
                        preencheGrid(grdResumoQuitar, sQuery2);
                        lblTroco.Visible = false;
                        txtDin.Visible = false;
                        txtDin.Text = "";

                        chkDebito.Checked = false;
                        chkDin.Checked = false;
                        chkCredito.Checked = false;



                        grdQuitarPagtosPendentes.ClearSelection();

                        //atualiza grid do form PagtosPendentes.. (tela anterior)

                        if (grdPagtosPendentes_formAnterior != null)
                        {
                            String sPP = "select c.nome as 'Cliente', concat('R$ ',convert(varchar, cast(sum(v.preco_total - (v.preco_total*v.desconto)) as money),1)) as 'Valor Total', c.id from vendas v left outer join clientes c on c.id=v.id_cliente where v.is_pagto_pendente=1 and v.isCancelado<>1 group by c.id, c.nome";
                            preencheGrid(grdPagtosPendentes_formAnterior, sPP);

                            int rowscount = grdPagtosPendentes_formAnterior.Rows.Count;
                            double preco_total;

                            preco_total = 0;

                            for (int i = 0; i < rowscount; i++)
                            {
                                preco_total = preco_total + double.Parse(grdPagtosPendentes_formAnterior.Rows[i].Cells[1].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
                            }

                            txtValorTotalPagtosPendentes_formAnterior.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");

                            //fim atualiza grid do form PagtosPendentes.. (tela anterior)
                        }

                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.ToString());
                    }
                }
            }
            else {
                MessageBox.Show("Selecione a forma de pagamento !");
            }
        }


        public void btnExcelPgtosPendentes_Click(object sender, EventArgs e)
        {
           
            int i;
            int k = 2;
           
            //id_pedido = int.Parse(grdQuitarPagtosPendentes[0, i].Value.ToString());

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            
            object misValue = System.Reflection.Missing.Value;

            int j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
          //  xlWorkSheet2 = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

            if (System.IO.File.Exists("C:\\pliniao\\logo.png"))
            {
                xlWorkSheet.Shapes.AddPicture("C:\\pliniao\\logo.png", Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 10, 10, 65, 79);
            }

            xlWorkSheet.Cells[3, 3] = "Pagamentos Pendentes";
            xlWorkSheet.Cells[4, 3] = "Cliente: " + label1.Text;
            xlWorkSheet.get_Range("C3", "J6").Font.Size = 15;

            xlWorkSheet.get_Range("A1", "J6").BorderAround(Type.Missing, Excel.XlBorderWeight.xlThick, Excel.XlColorIndex.xlColorIndexAutomatic, Type.Missing);
            xlWorkSheet.get_Range("a6", "iv6").RowHeight = 11;

            xlWorkSheet.Columns.NumberFormat = "@";


            for (i = 0; i < grdQuitarPagtosPendentes.RowCount ; i++)
            {
                for (j = 0; j < grdQuitarPagtosPendentes.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[8, j + 1] = grdQuitarPagtosPendentes.Columns[j].HeaderText.ToString();


                    
                    xlWorkSheet.Cells[i + 9, j + 1] = grdQuitarPagtosPendentes[j, i].Value.ToString();

                    k++;
                }
            }

            //xlWorkSheet.Cells[i + 2, 1] = "Total de pedidos: " + numero_de_pedidos.ToString();

            //inicio resumo

            xlWorkSheet.Cells[k + 1, 1] = "RESUMO ITENS:";
            xlWorkSheet.Cells[k + 2, 1] = "Qtde.";
            xlWorkSheet.Cells[k + 2, 2] = "Descrição";
            xlWorkSheet.Cells[k + 2, 3] = "Preço Total Item";

            k++;
            String query = "select sum(vi.qtt) as 'Qtde', p.descr as 'Descrição', concat('R$ ', convert(varchar, cast(sum((vi.qtt * vi.preco_item)) - sum((vi.qtt * vi.preco_item)) * v.desconto as money), 1)) as 'Preço Total Item' from vendas v left outer join vendas_itens vi on v.id = vi.id_venda left outer join clientes c on c.id = v.id_cliente left outer join produto p on p.id = vi.id_prod where v.is_pagto_pendente = 1 and v.isCancelado <> 1 and v.id_cliente = " + id_cli + " group by p.descr, v.desconto order by p.descr " ;
            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388@@;";

            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }

            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                xlWorkSheet.Cells[k + 2, 1] = dr["Qtde"].ToString();
                xlWorkSheet.Cells[k + 2, 2] = dr["Descrição"].ToString();
                xlWorkSheet.Cells[k + 2, 3] = dr["Preço Total Item"].ToString();

                k++;
            }

            dr.Close();
            conn.Close();



            //fim resumo
            
            xlWorkSheet.Cells[k + 3, 1] = "Itens detalhados:";
            xlWorkSheet.Cells[k + 4, 1] = "Item";
            xlWorkSheet.Cells[k + 4, 2] = "Núm. Ped.";
            xlWorkSheet.Cells[k + 4, 3] = "Qtde.";
            xlWorkSheet.Cells[k + 4, 4] = "Preço";
            xlWorkSheet.Cells[k + 4, 5] = "Descrição";
            xlWorkSheet.Cells[k + 4, 6] = "Preço total item";
            //xlWorkSheet2.Cells[k + 3, 6] = "Preço total item";
            k++;
            query = "select ROW_NUMBER() over(order by vi.id_venda) as 'Item',right('000000' + cast(vi.id_venda as nvarchar),6) as 'Núm. Pedido',convert(varchar(11), v.data,103) as Data, right('00' + cast(vi.qtt as nvarchar),2) as 'Qtde', concat('R$ ',convert(varchar, cast(vi.preco_item as money),1)) as 'Preço', p.descr as 'Descrição',concat(isnull(v.desconto,0)*100,'%') as 'Desconto',concat('R$ ',convert(varchar, cast((vi.qtt * vi.preco_item)-(vi.qtt * vi.preco_item*v.desconto) as money),1)) as 'Preço Total Item' from vendas v left outer join vendas_itens vi on v.id=vi.id_venda left outer join clientes c on c.id=v.id_cliente left outer join produto p on p.id=vi.id_prod where v.is_pagto_pendente=1 and v.isCancelado<>1 and v.id_cliente="+id_cli;
            conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388@@;";

            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }
            
            OdbcCommand cmd2 = new OdbcCommand(query, conn);
            OdbcDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                xlWorkSheet.Cells[k + 4, 1] = dr2["Item"].ToString();
                xlWorkSheet.Cells[k + 4, 2] = dr2["Núm. Pedido"].ToString();
                xlWorkSheet.Cells[k + 4, 3] = dr2["Qtde"].ToString();
                xlWorkSheet.Cells[k + 4, 4] = dr2["Preço"].ToString();
                xlWorkSheet.Cells[k + 4, 5] = dr2["Descrição"].ToString();
                xlWorkSheet.Cells[k + 4, 6] = dr2["Preço Total Item"].ToString();
                k++;
            }

            dr2.Close();
            conn.Close();


            xlWorkSheet.Cells[k + 5, 5] = "Total:";
            xlWorkSheet.Cells[k + 5, 6] = "R$ " + txtPrecoTotalQuitarPendente.Text.ToString();

            DialogResult result = folderBrowserDialog1.ShowDialog();


            if (result == DialogResult.OK)
            {
                String sData;
                sData = DateTime.Now.ToString("g").Replace("/", "");
                sData = sData.Replace(" ", "_");
                sData = sData.Replace(":", "");

                // MessageBox.Show(folderBrowserDialog1.SelectedPath);
                xlWorkBook.SaveAs(folderBrowserDialog1.SelectedPath + "/relatorio_pliniao" + sData + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
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

        private void txtDin_TextChanged(object sender, EventArgs e)
        {


            double dinheiroRecebido;
            double aux;
            double preco;

            if (txtDin.Text != "")
            {
                txtDin.Text = txtDin.Text.Replace(",", ".");
                txtDin.Select(txtDin.Text.Length, 0);

                if (Regex.IsMatch(txtDin.Text, @"^\d+$") || txtDin.Text.IndexOf(".") > 0)
                {
                    if (txtTotalSelecionado.Text=="")
                    {
                        preco = 0;
                    }
                    else
                    {
                        preco = double.Parse(txtTotalSelecionado.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }

                    try
                    {
                        dinheiroRecebido = double.Parse(txtDin.Text, System.Globalization.CultureInfo.InvariantCulture);
                        aux = dinheiroRecebido - preco;
                        lblTroco.Visible = true;
                        lblTroco.Text = "Troco: R$ " + aux.ToString("#.00");
                    }
                    catch
                    {
                        MessageBox.Show("Digite um número válido!");
                    }



                }
                else
                {
                    // se nao for numero ..
                    txtDin.Text = "";
                }
            }
            else
            {
                lblTroco.Text = "Troco: R$";
            }

        }

        private void chkDin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDin.Checked)
            {
                txtDin.Visible = true;
                txtDin.Focus();
            }
            else
            {
                txtDin.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



        }
}

       
}


