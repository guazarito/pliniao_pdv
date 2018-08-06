using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using Excel = Microsoft.Office.Interop.Excel;

using System.IO;


namespace WindowsFormsApplication2
{
    public partial class frmRel : Form
    {
        private DataSet ds = null;

        public frmRel()
        {
            InitializeComponent();

            conexao c = new conexao();

            rdoHoje.CheckedChanged += new EventHandler(rdoHoje_CheckedChanged);
            rdoSemana.CheckedChanged += new EventHandler(rdoSemana_CheckedChanged);
            rdoMes.CheckedChanged += new EventHandler(rdoMes_CheckedChanged);

            grdResumoPgtos.Columns[0].Width = 170;
            grdResumoPgtos.Columns[1].Width = 170;

            toolStripStatusLabel1.Text = "";

        }


        private void rdoHoje_CheckedChanged(Object sender, EventArgs e)
        {
            if (rdoHoje.Checked == true)
            {

                dtIni.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFim.Value = DateTime.Parse(DateTime.Today.ToString("d"));

            }
        }

        private void rdoSemana_CheckedChanged(Object sender, EventArgs e)
        {
            DateTime dt_ini;

            int i = 7;

            dt_ini = DateTime.Parse(DateTime.Today.ToString("d"));

            if (rdoSemana.Checked == true)
            {
                dtIni.Value = DateTime.Parse(DateTime.Today.ToString("d"));
                dtFim.Value = DateTime.Parse(DateTime.Today.ToString("d"));

                while (i > 0)
                {

                    i--;

                    dt_ini = dt_ini.AddDays(-1);
                }
                dtIni.Value = dt_ini;
            }
        }

        private void rdoMes_CheckedChanged(Object sender, EventArgs e)
        {
            // DateTime dt_ini;

            // dt_ini = DateTime.Parse(DateTime.Today.ToString("d"));

            if (rdoMes.Checked == true)
            {
                dtIni.Value = DateTime.Parse(DateTime.Today.Year + "-" + DateTime.Today.Month + "-01");
                //dt_ini = dt_ini.AddMonths(-1);
                // dtIni.Value = dt_ini;
            }
        }


        int numero_de_pedidos;


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtPrecoTotalDEsc.Visible = false;
            lblPrecoDesc.Visible = false;
            lblPrecoDesc2.Visible = false;
            toolStripStatusLabel1.Text = "";
            txtPrecoTotal.Text = "";
            conexao c = new conexao();

            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                String sQuery;
                //String queryTotalPreco;
                String sResumo;


                sQuery = "select ROW_NUMBER() over(order by vi.id_venda) as 'Item', right('00000' + cast(vi.id_venda as nvarchar),5) as 'Núm. Pedido', convert(varchar(11), v.data,103) as Data, right('00' + cast(vi.qtt as nvarchar),2) as 'Qtde', concat('R$ ',convert(varchar, cast(vi.preco_item as money),1)) as 'Preço', p.descr as 'Descrição',concat(isnull(v.desconto,0)*100,'%') as 'Desconto',concat('R$ ',convert(varchar, cast((vi.qtt * vi.preco_item)-(vi.qtt * vi.preco_item*v.desconto) as money),1)) as 'Preço Total Item' from vendas_itens vi left outer join vendas v on vi.id_venda=v.id left outer join produto p on p.id=vi.id_prod where v.isCancelado<>1 and convert(date,v.data,103) >= '" + dtInic + "' and convert(date,v.data,103) <= '" + dtFinal + "'";
                //queryTotalPreco = "select convert(varchar, cast(sum(vi.qtt * p.preco) as money),1) as 'precototalpedido' from vendas_itens vi left outer join vendas v on vi.id_venda=v.id left outer join produto p on p.id=vi.id_prod where v.isCancelado<>1 and convert(date,v.data,103) >= '" + dtInic + "' and convert(date,v.data,103) <= '" + dtFinal + "'";


                sQuery = sQuery + " order by v.data";

                //PREENCHE O GRID..
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
                grdRel.ReadOnly = true;
                grdRel.DataSource = ds.Tables[0];

                grdRel.Columns[0].Width = 40;
                grdRel.Columns[1].Width = 50;
                grdRel.Columns[2].Width = 90;
                grdRel.Columns[3].Width = 40;
                grdRel.Columns[4].Width = 80;
                grdRel.Columns[5].Width = 100;
                grdRel.Columns[6].Width = 60;
                grdRel.Columns[7].Width = 100;

                grdRel.ClearSelection();

                conn.Close();





                //..grd resumo..
                //PREENCHE O GRID..

                sResumo = "select sum(qtt) as 'Qtdade total', p.descr as 'Descrição', concat('R$ ',convert(varchar, cast(vi.preco_item as money),1)) as 'Preço item', concat(isnull(v.desconto,0)*100,'%') as 'Desconto', concat('R$ ',convert(varchar, cast(sum(qtt)*(vi.preco_item-(vi.preco_item*v.desconto)) as money),1)) as 'Preço Total' from vendas_itens vi left outer join produto p on p.id=vi.id_prod left outer join vendas v on v.id = vi.id_venda";
                sResumo += " where  v.isCancelado<>1 and convert(date,v.data,103) >= '" + dtInic + "' and convert(date,v.data,103) <= '" + dtFinal + "'";
                sResumo += " group by id_prod, p.descr, v.desconto, vi.preco_item order by p.descr ";

                OdbcDataAdapter dataAdapter2 = new OdbcDataAdapter(sResumo, conn);

                OdbcCommandBuilder commandBuilder2 = new OdbcCommandBuilder(dataAdapter2);
                ds = new DataSet();
                dataAdapter2.Fill(ds);
                grdRelResumo.ReadOnly = true;
                grdRelResumo.DataSource = ds.Tables[0];

                int j;

                numero_de_pedidos = 0;
                for (j = 0; j < grdRel.RowCount; j++)
                {

                    //    preco_total_peds = preco_total_peds + Convert.ToInt32(grdRel[3, j].Value.ToString()) * double.Parse(grdRel[4, j].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);


                    //     txtPrecoTotal.Text = String.Format("{0:n2}", preco_total_peds).Replace(",", ".");

                    // conexao C = new conexao();
                    //  label11.Text = C.RetornaQuery("select concat('R$ ',convert(varchar, cast(sum(preco_total) as money),1)) as 'Preço' from vendas where isCancelado<>1 and is_pagto_pendente<>1 and convert(date,v.data,103) >= '" + dtInic + "' and convert(date,v.data,103) <= '" + dtFinal + "'", "Preço");                

                    if (grdRel.RowCount > 0 && j == 1)
                    {
                        numero_de_pedidos = 1;
                    }
                    if (j > 0)
                    {
                        Console.Write(Convert.ToInt32(grdRel[1, j].Value) + " - " + Convert.ToInt32(grdRel[1, j - 1].Value));
                        if (Convert.ToInt32(grdRel[1, j].Value) != Convert.ToInt32(grdRel[1, j - 1].Value))
                        {
                            numero_de_pedidos++;
                        }
                    }
                }

                //           string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qtt.ToString(), price.ToString(), c.RetornaQuery("select descr from produto where descr like '%marmita pequena%'", "descr"), (qtt * price).ToString(), id_prod.ToString() };
                //           grdVenda.Rows.Add(row1);

                grdRelResumo.Columns[0].Width = 50;
                grdRelResumo.Columns[1].Width = 130;
                grdRelResumo.Columns[2].Width = 60;
                grdRelResumo.Columns[3].Width = 60;
                grdRelResumo.Columns[3].Width = 60;


                grdRelResumo.ClearSelection();

                //int j;

                /*preenche grd resumo pagto
                String sResumoPagto = " select convert(varchar,forma_pagto) as 'Forma Pagamento' , concat('R$ ',convert(varchar, cast(sum(preco_total) as money),1)) as 'Valor' from vendas where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and isCancelado<>1 and forma_pagto <> 0 and forma_pagto <> 5 group by forma_pagto ";

                OdbcDataAdapter dataAdapter3 = new OdbcDataAdapter(sResumoPagto, conn);

                OdbcCommandBuilder commandBuilder3 = new OdbcCommandBuilder(dataAdapter3);
                ds = new DataSet();
                dataAdapter3.Fill(ds);
                grdResumoPgtos.ReadOnly = true;
                grdResumoPgtos.DataSource = ds.Tables[0];


                for (j = 0; j < grdResumoPgtos.RowCount; j++)
                {
                    if (grdResumoPgtos[0, j].Value.ToString() == "1")
                    {
                        grdResumoPgtos[0, j].Value = "Dinheiro";
                    }else if(grdResumoPgtos[0, j].Value.ToString() == "2")
                    {
                        grdResumoPgtos[0, j].Value = "Cartão Cielo";
                    }
                    else if (grdResumoPgtos[0, j].Value.ToString() == "3")
                    {
                        grdResumoPgtos[0, j].Value = "Cartão PagSeguro";
                    }
          //          else if (grdResumoPgtos[0, j].Value.ToString() == "5")
          //          {
          //              grdResumoPgtos[0, j].Value = "Crédito Cliente";
          //          }
                }

                    grdResumoPgtos.DataSource = null;
                */

                grdResumoPgtos.Rows.Clear();
                //grdResumoPgtos.DataSource = null; //limpa o grid

                String auxValor = "";

                String sPegaValorDinheiro = "";
                String sFormaPgto = "1";

                sPegaValorDinheiro += "begin transaction";
                sPegaValorDinheiro += " declare @val1 decimal(10, 2)";
                sPegaValorDinheiro += " declare @val2 decimal(10, 2)";

                sPegaValorDinheiro += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorDinheiro += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorDinheiro += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorDinheiro += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorDinheiro += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorDinheiro += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorDinheiro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorDinheiro += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";

                // String sPegaValorDinheiro = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorDinheiro += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorDinheiro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 1 group by v.forma_pagto";

                auxValor = c.RetornaQuery(sPegaValorDinheiro, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Dinheiro", auxValor);
                }


                String sPegaValorCartaoCielo = "";
                sFormaPgto = "2";

                sPegaValorCartaoCielo += "begin transaction";
                sPegaValorCartaoCielo += " declare @val1 decimal(10, 2)";
                sPegaValorCartaoCielo += " declare @val2 decimal(10, 2)";

                sPegaValorCartaoCielo += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorCartaoCielo += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorCartaoCielo += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorCartaoCielo += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorCartaoCielo += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorCartaoCielo += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorCartaoCielo += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorCartaoCielo += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";


                // String sPegaValorCartaoCielo = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorCartaoCielo += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorCartaoCielo += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 2 group by v.forma_pagto";


                auxValor = c.RetornaQuery(sPegaValorCartaoCielo, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Cartao Cielo", auxValor);
                }

                String sPegaValorCartaoPagSeguro = "";
                sFormaPgto = "3";

                sPegaValorCartaoPagSeguro += "begin transaction";
                sPegaValorCartaoPagSeguro += " declare @val1 decimal(10, 2)";
                sPegaValorCartaoPagSeguro += " declare @val2 decimal(10, 2)";

                sPegaValorCartaoPagSeguro += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorCartaoPagSeguro += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorCartaoPagSeguro += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorCartaoPagSeguro += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorCartaoPagSeguro += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorCartaoPagSeguro += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorCartaoPagSeguro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorCartaoPagSeguro += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";

                // String sPegaValorCartaoPagSeguro = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorCartaoPagSeguro += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorCartaoPagSeguro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 3 group by v.forma_pagto";

                auxValor = c.RetornaQuery(sPegaValorCartaoPagSeguro, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Cartão PagSeguro", auxValor);
                }

                auxValor = c.RetornaQuery(sPegaValorCartaoCielo, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Cartao Cielo", auxValor);
                }

                String sPegaValorDebito = "";
                sFormaPgto = "6";

                sPegaValorDebito += "begin transaction";
                sPegaValorDebito += " declare @val1 decimal(10, 2)";
                sPegaValorDebito += " declare @val2 decimal(10, 2)";

                sPegaValorDebito += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorDebito += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorDebito += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorDebito += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorDebito += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorDebito += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorDebito += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorDebito += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";

                // String sPegaValorCartaoPagSeguro = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorCartaoPagSeguro += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorCartaoPagSeguro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 3 group by v.forma_pagto";

                auxValor = c.RetornaQuery(sPegaValorDebito, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Cartão Débito", auxValor);
                }


                String sPegaValorCredito = "";
                sFormaPgto = "7";

                sPegaValorCredito += "begin transaction";
                sPegaValorCredito += " declare @val1 decimal(10, 2)";
                sPegaValorCredito += " declare @val2 decimal(10, 2)";

                sPegaValorCredito += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorCredito += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorCredito += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorCredito += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorCredito += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorCredito += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorCredito += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorCredito += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";

                // String sPegaValorCartaoPagSeguro = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorCartaoPagSeguro += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorCartaoPagSeguro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 3 group by v.forma_pagto";

                auxValor = c.RetornaQuery(sPegaValorCredito, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Cartão Crédito", auxValor);
                }



                String sPegaValorTicket = "";
                sFormaPgto = "8";

                sPegaValorTicket += "begin transaction";
                sPegaValorTicket += " declare @val1 decimal(10, 2)";
                sPegaValorTicket += " declare @val2 decimal(10, 2)";

                sPegaValorTicket += " select @val1 = sum(isnull(acu.valor_total_venda, 0) - isnull(acu.valor_credito_utilizado, 0)) from vendas v left outer join auxCreditosUtilizados acu on v.id = acu.id_venda";
                sPegaValorTicket += " where isnull(v.is2Formaspagto_PagtoPend_Credito,0) = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1";
                sPegaValorTicket += " and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.forma_pagto = " + sFormaPgto;

                sPegaValorTicket += " select @val2 = sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt * v.desconto))";
                sPegaValorTicket += " from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id left outer join auxCreditosUtilizados acu on acu.id_venda = v.id";
                sPegaValorTicket += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                sPegaValorTicket += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = " + sFormaPgto + " and isnull(v.is2Formaspagto_PagtoPend_Credito,0) <> 1 group by v.forma_pagto";

                sPegaValorTicket += " select concat('R$ ', convert(varchar, cast((isnull(@val1, 0) + isnull(@val2, 0)) as money), 1)) as 'Valor'";

                // String sPegaValorCartaoPagSeguro = "select concat('R$ ',convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1)) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda = v.id ";
                // sPegaValorCartaoPagSeguro += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                // sPegaValorCartaoPagSeguro += "' and v.isCancelado <> 1 and is_pagto_pendente<> 1 and v.forma_pagto = 3 group by v.forma_pagto";

                auxValor = c.RetornaQuery(sPegaValorTicket, "Valor");

                if (auxValor != "R$ 0.00")
                {
                    grdResumoPgtos.Rows.Add("Voucher/Ticket", auxValor);
                }

                if (sFormaPgto == "8") //desmembra os tipos dos tickets
                {

                    conn.ConnectionString =
                                  "Dsn=odbc_pliniao;" +
                                  "Uid=sa;" +
                                  "Pwd=chico110388;";

                    var query = "select id_ticket, tt.ticket, concat('R$ ', convert(varchar, cast((isnull(sum(v.preco_total), 0)) as money), 1)) as 'preco_total_ticket' from vendas v left outer join tp_tickets tt on tt.id = v.id_ticket ";
                    query += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal;
                    query += "' and isCancelado <> 1 and is_pagto_pendente<> 1 and forma_pagto = " + sFormaPgto + " and isnull(is2Formaspagto_PagtoPend_Credito,0) <> 1";
                    query += " group by v.id_ticket, tt.ticket";

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar no banco de dados.\n" + ex);
                    }

                    try
                    {


                        OdbcCommand cmd = new OdbcCommand(query, conn);
                        OdbcDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {

                                grdResumoPgtos.Rows.Add("          - " + dr[1].ToString(), dr[2].ToString());
                                int index = grdResumoPgtos.Rows.Count - 1;
                                grdResumoPgtos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                            }

                        }

                    }
                    catch (Exception exc)
                    {
                        System.Windows.Forms.MessageBox.Show(query + "\n\n" + exc.ToString());
                        FileStream fs = File.Create(@"c:\pliniao\query.txt");
                        StreamWriter sw = new StreamWriter(fs);
                        String sTpMaq;

                        sTpMaq = query;

                        sw.Write(sTpMaq);
                        sw.Close();
                    }
                    conn.Close();
                }

                //FIM desmembra tickets --------------------

                String sPegaValorPagtoPendentes = "select  concat('R$ ',convert(varchar, cast(sum(v.preco_total) as money),1)) as 'Valor' from vendas v ";
                sPegaValorPagtoPendentes += "where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.isCancelado<>1 and is_pagto_pendente=1";

                String sAuxValPendente = c.RetornaQuery(sPegaValorPagtoPendentes, "Valor");
                // grdResumoPgtos[0, grdResumoPgtos.RowCount + 1].Value = "Pagamento Pendente";
                // grdResumoPgtos[1, grdResumoPgtos.RowCount + 1].Value = c.RetornaQuery(sPegaValorPagtoPendentes, "Valor");

                if (sAuxValPendente != "R$ ")
                {
                    grdResumoPgtos.Rows.Add("Pagamento Pendente", sAuxValPendente);
                }



                String sPegaValorCreditoEntrouNoPeriodo = "select isnull(sum(valor_credito),0) as 'Valor' from historico_credito_dado ";
                sPegaValorCreditoEntrouNoPeriodo += "where formaPagto<>0 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                double auxValorCreditoEntrouNoPeriodo = double.Parse(c.RetornaQuery(sPegaValorCreditoEntrouNoPeriodo, "Valor").Replace(".", ","));

                if (auxValorCreditoEntrouNoPeriodo != 0)
                {
                    grdResumoPgtos.Rows.Add("Créditos entrou no caixa no periodo", "R$ " + (auxValorCreditoEntrouNoPeriodo).ToString("#.#0"));
                }


                var conn2 = new OdbcConnection();
                conn2.ConnectionString =
                "Dsn=odbc_pliniao;" +
                "Uid=sa;" +
                "Pwd=chico110388;";


                var squery = "select concat('R$ ',convert(varchar, cast(sum(hcd.valor_credito) as money),1)) as 'Valor', tt.ticket, hcd.formaPagto  from historico_credito_dado hcd";
                squery += " left outer join tp_tickets tt on tt.id = hcd.id_tp_ticket where hcd.FormaPagto <> 0 and convert(date, hcd.data,103) >= '" + dtInic + "' and convert(date, hcd.data,103) <= '" + dtFinal + "'";
                squery += " group by hcd.id_tp_ticket, tt.ticket, hcd.formaPagto";

                try
                {
                    conn2.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados.\n" + ex);
                }

                try
                {


                    OdbcCommand cmd = new OdbcCommand(squery, conn2);
                    OdbcDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            if (dr[2].ToString() == "1")
                            {
                                grdResumoPgtos.Rows.Add("          - " + "Dinheiro", dr[0].ToString());
                                int index = grdResumoPgtos.Rows.Count - 1;
                                grdResumoPgtos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                            else if (dr[2].ToString() == "6")
                            {
                                grdResumoPgtos.Rows.Add("          - " + "Cartão Débito", dr[0].ToString());
                                int index = grdResumoPgtos.Rows.Count - 1;
                                grdResumoPgtos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                            else if (dr[2].ToString() == "7")
                            {
                                grdResumoPgtos.Rows.Add("          - " + "Cartão Crédito", dr[0].ToString());
                                int index = grdResumoPgtos.Rows.Count - 1;
                                grdResumoPgtos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                            else
                            {
                                grdResumoPgtos.Rows.Add("          - " + dr[1].ToString(), dr[0].ToString());
                                int index = grdResumoPgtos.Rows.Count - 1;
                                grdResumoPgtos.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
                            }
                        }

                    }

                }
                catch (Exception exc)
                {
                    System.Windows.Forms.MessageBox.Show(squery + "\n\n" + exc.ToString());
                    FileStream fs = File.Create(@"c:\pliniao\query.txt");
                    StreamWriter sw = new StreamWriter(fs);
                    String sTpMaq;

                    sTpMaq = squery;

                    sw.Write(sTpMaq);
                    sw.Close();
                }
                conn2.Close();

                String sPegaValorCreditoUtilizado = "SELECT isnull(sum(valor_credito_utilizado),0) as 'Valor' FROM AUXCREDITOSUTILIZADOS acu left outer join vendas v on v.id = acu.id_venda where acu.valor_pendente <> 0 and ";
                sPegaValorCreditoUtilizado += "convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.isCancelado<>1";

                String sPegaValorCreditoUtilizado2 = "select convert(varchar, cast(sum(vi.preco_item * vi.qtt - (vi.preco_item * vi.qtt *v.desconto)) as money),1) as 'Valor' from vendas_itens vi left outer join vendas v  on vi.id_venda=v.id ";
                sPegaValorCreditoUtilizado2 += " where convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "' and v.isCancelado<>1 and is_pagto_pendente<>1 and v.forma_pagto=5 group by v.forma_pagto";

                String sPegaValorCreditoUtilizado3 = "select isnull(sum(isnull(acu.valor_credito_utilizado, 0)),0) as 'Valor' from auxCreditosUtilizados acu left outer join vendas v on v.id = acu.id_venda ";
                sPegaValorCreditoUtilizado3 += " where v.is2Formaspagto_PagtoPend_Credito = 1 and v.is_pagto_pendente = 0 and v.isCancelado <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                double auxCreditoUtilizado, auxCreditoUtilizado2, auxCreditoUtilizado3, auxTotalCreditoUtilizado;

                auxCreditoUtilizado = double.Parse(c.RetornaQuery(sPegaValorCreditoUtilizado, "Valor").Replace(".", ","));
                auxCreditoUtilizado2 = double.Parse(c.RetornaQuery(sPegaValorCreditoUtilizado2, "Valor").Replace(".", ","));
                auxCreditoUtilizado3 = double.Parse(c.RetornaQuery(sPegaValorCreditoUtilizado3, "Valor").Replace(".", ","));

                auxTotalCreditoUtilizado = auxCreditoUtilizado + auxCreditoUtilizado2 + auxCreditoUtilizado3;

                if (auxTotalCreditoUtilizado != 0)
                {
                    grdResumoPgtos.Rows.Add("Créditos utilizados pelos clientes", "R$ " + (auxTotalCreditoUtilizado).ToString("#.#0"));
                }



                grdResumoPgtos.ClearSelection();
                //fim preenche resumo pagto






                bool temDesc = false;
                for (j = 0; j < grdRelResumo.RowCount; j++)
                {
                    //total_preco_desconto = total_preco_desconto + double.Parse(grdRelResumo[4, j].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
                    if (grdRelResumo[3, j].Value.ToString() != "0%")
                    {
                        temDesc = true;
                        break;
                    }
                }

                if (temDesc)
                {
                    txtPrecoTotalDEsc.Visible = true;
                    lblPrecoDesc.Visible = true;
                    lblPrecoDesc2.Visible = true;
                    String sQueryDesc = "select isnull(cast(sum(vi.qtt * vi.preco_item - (vi.qtt * vi.preco_item * v.desconto)) as money), 0) as 'valor' from vendas_itens vi left outer join vendas v on v.id = vi.id_venda ";
                    sQueryDesc += "where v.isCancelado <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                    String sAuxDesc = c.RetornaQuery(sQueryDesc, "valor");
                    txtPrecoTotalDEsc.Text = sAuxDesc.Replace(",", ".").Substring(0, sAuxDesc.Length - 2);
                }

                String sQueryTotal = "select isnull(cast(sum(vi.qtt*vi.preco_item) as money),0) as 'valor' from vendas_itens vi left outer join vendas v on v.id = vi.id_venda ";
                sQueryTotal += "where v.isCancelado <> 1 and convert(date,data,103) >= '" + dtInic + "' and convert(date,data,103) <= '" + dtFinal + "'";

                String sAuxTot = c.RetornaQuery(sQueryTotal, "valor");
                txtPrecoTotal.Text = sAuxTot.Replace(",", ".").Substring(0, sAuxTot.Length - 2);

                txtTotalPendentePagto.Text = sAuxValPendente.Replace("R$ ", "");

                toolStripStatusLabel1.Text = "Total de pedidos: " + numero_de_pedidos.ToString();




                String sTotPeriodo = "";

                if (temDesc)
                {
                    sTotPeriodo = txtPrecoTotalDEsc.Text;
                }
                else
                {
                    sTotPeriodo = txtPrecoTotal.Text;
                }

                txtTotalPeriodo.Text = sTotPeriodo;



                double auxtotalCaixa;
                double auxTotalPendentePagto;

                if (txtTotalPendentePagto.Text == "")
                {
                    auxTotalPendentePagto = 0;
                }
                else
                {
                    auxTotalPendentePagto = double.Parse(txtTotalPendentePagto.Text.Replace(".", ","));
                }


                auxtotalCaixa = double.Parse(sTotPeriodo.Replace(".", ",")) - auxTotalCreditoUtilizado - auxTotalPendentePagto + auxValorCreditoEntrouNoPeriodo;

                txtTotalCaixa.Text = auxtotalCaixa.ToString("#0.00").Replace(",", ".");


                //fim total do período

            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL que a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            int i, j;

            xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i < grdRel.RowCount; i++)
            {
                for (j = 0; j < grdRel.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[1, j + 1] = grdRel.Columns[j].HeaderText.ToString();


                    xlWorkSheet.Cells[i + 2, j + 1] = grdRel[j, i].Value.ToString();


                }
            }

            xlWorkSheet.Cells[i + 2, 1] = "Total de pedidos: " + numero_de_pedidos.ToString();



            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(2);

            for (i = 0; i < grdRelResumo.RowCount; i++)
            {
                for (j = 0; j < grdRelResumo.ColumnCount; j++)
                {
                    xlWorkSheet.Cells[1, j + 1] = grdRelResumo.Columns[j].HeaderText.ToString();


                    xlWorkSheet.Cells[i + 2, j + 1] = grdRelResumo[j, i].Value.ToString();


                }
            }

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

        private void button4_Click(object sender, EventArgs e)
        {
            DataView dv;
            dv = new DataView(ds.Tables[0], "Descrição like '%coca%' or Descrição like '%prato%'", "Descrição Desc", DataViewRowState.CurrentRows);
            grdRel.DataSource = dv;

        }

        private void tabRels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
