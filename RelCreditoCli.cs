using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using ImprimeTicketNE;

namespace WindowsFormsApplication2
{
    public partial class RelCreditoCli : Form
    {
        public RelCreditoCli()
        {
            InitializeComponent();
           

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                string filtro;
                filtro = "convert(date, data, 103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "'";
                preenche_grid(grdHistoricoCreditoDado,  filtro);

                grdHistoricoCreditoDado.Columns[0].Visible = false;
                grdHistoricoCreditoDado.Columns[6].Visible = false;

                tabControl1_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL que a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public void preenche_grid(DataGridView grd, string filtro = "")
        {
            String sQuery;
            String tabela;
            String tipo_credito;
            String sinal_operacao;

            conexao c = new conexao();

            if (grd.Name == "grdHistoricoCreditoDado")
            {
                tabela = "historico_credito_dado";
                tipo_credito = "Dado";
                sinal_operacao = "+";

                sQuery = "select hcd.id, cli.nome, concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', obs as 'Obs', convert(varchar, formaPagto) as 'Forma Pagamento', id_tp_ticket from " + tabela;
                sQuery += " hcd left outer join clientes cli on cli.id = hcd.id_cliente";
                sQuery += " where " + filtro + " order by data desc";

            }
            else
            {
                tabela = "historico_credito_utilizado";
                tipo_credito = "Utilizado";
                sinal_operacao = "-";
                sQuery = "select hcd.id, cli.nome, concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', id_venda as Pedido, obs as 'Obs' from " + tabela;
                sQuery += " hcd left outer join clientes cli on cli.id = hcd.id_cliente";
                sQuery += " where " + filtro + " order by data desc";

            }


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

            grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grd.ReadOnly = true;

            grd.DataSource = ds.Tables[0];

            grd.CurrentCell = null;

            //grd.Columns[0].Visible = false;
            grd.ClearSelection();

            if (grd.Name == "grdHistoricoCreditosUsados")
            {
                foreach (DataGridViewRow row in grd.Rows)
                {
                    if (row.Cells["Obs"].Value.ToString() == "Estornado")
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Salmon;
                    }
                }

            }

            if (grd.Name == "grdHistoricoCreditoDado")
            {
  

                foreach (DataGridViewRow row in grd.Rows)
                {
                    if (row.Cells["Obs"].Value.ToString() != "")
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.Yellow;
                    }

                    if (row.Cells["Forma Pagamento"].Value.ToString() == "0")
                    {
                        row.Cells["Forma Pagamento"].Value = "";
                    }
                    else if (row.Cells["Forma Pagamento"].Value.ToString() == "1")
                    {
                        row.Cells["Forma Pagamento"].Value = "Dinheiro";
                    }
                    else if (row.Cells["Forma Pagamento"].Value.ToString() == "6")
                    {
                        row.Cells["Forma Pagamento"].Value = "Cartao Débito";
                    }
                    else if (row.Cells["Forma Pagamento"].Value.ToString() == "7")
                    {
                        row.Cells["Forma Pagamento"].Value = "Cartao Crédito";
                    }
                    else if (row.Cells["Forma Pagamento"].Value.ToString() == "8")
                    {
                        String tp_ticket = c.RetornaQuery("select ticket from tp_tickets where id = " + row.Cells["id_tp_ticket"].Value.ToString(), "ticket");
                        row.Cells["Forma Pagamento"].Value = "Voucher (" + tp_ticket + ")";
                    }


                }


            }
            conn.Close();


            calculaTotalPeriodo(grd, filtro);
            grd.ClearSelection();
            tabControl1.Visible = true;

         //   grd.Columns[0].Visible = false;
          //  grd.Columns[5].Visible = false;
        }


        public void calculaTotalPeriodo(DataGridView grd, string filtro = "")
        {
            conexao c = new conexao();
            string tabela;
            TextBox txt;

            if (grd.Name == "grdHistoricoCreditoDado")
            {
                tabela = "historico_credito_dado";
                txt = txtTotalPeriodoDado;
            }
            else
            {
                tabela = "historico_credito_utilizado";
                txt = txtTotalPeriodoUsado;
            }

            string query = "select convert(varchar, cast(isnull(sum(valor_credito),0) as money),1) as 'totalPeriodo' from " + tabela + " where (obs='' or isnull(obs,'')='') and " + filtro;
            txt.Text = c.RetornaQuery(query, "totalPeriodo");
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");


                string filtro;
                filtro = "convert(date, data, 103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "'";
            
            string tab_titulo = tabControl1.SelectedTab.ToString();
            // DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                
            }
            else
            {
               
                preenche_grid(grdHistoricoCreditosUsados, filtro);
                grdHistoricoCreditosUsados.ClearSelection();
                grdHistoricoCreditoDado.Columns[0].Visible = false;
            }
        }
    }
}
