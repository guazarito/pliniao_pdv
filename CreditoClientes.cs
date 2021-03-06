﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using ImprimeTicketNE;

namespace WindowsFormsApplication2
{
    public partial class frmCreditoCli : Form
    {
        conexao c = new conexao();
        string id_cli;

        public frmCreditoCli()
        {
            InitializeComponent();
            c.fillCombo(this.txtNomeCli, "select * from clientes order by nome", "id", "nome");
            txtNomeCli.SelectedValue = 0;

            chkDebito.Visible = false; //nao esta sendo usado.. criei e o perdi na tela.. to usando o chkDebito_
            c.fillCboTicket(cboTickets);

            btnDelItem.Enabled = false;
            btnDelItem.Visible = false;
        }


        public void preenche_grid(DataGridView grd, string id_cli, string filtro = "")
        {

            String sQuery;
            String tabela;
            String tipo_credito;
            String sinal_operacao;

            if (grd.Name == "grdHistoricoCreditoDado")
            {
                tabela = "historico_credito_dado";
                tipo_credito = "Dado";
                sinal_operacao = "+";
                sQuery = "select id, concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', obs as 'Obs', convert(varchar, formaPagto) as 'Forma Pagamento', id_tp_ticket from " + tabela + " where id_cliente=" + id_cli + filtro + " order by data desc";

            }
            else
            {
                tabela = "historico_credito_utilizado";
                tipo_credito = "Utilizado";
                sinal_operacao = "-";
                sQuery = "select concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', id_venda as Pedido, obs as 'Obs' from " + tabela + " where id_cliente=" + id_cli + filtro + " order by data desc";

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
                grd.Columns[0].Visible = false;
                grd.Columns[5].Visible = false;

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
        }

        private void txtNomeCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNomeCli.SelectedIndex != 0 && txtNomeCli.SelectedIndex != -1)
            {

                //para dar efeitinho que mudou.. da uma piscadela
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                tabControl1.Visible = false;
                btnDelItem.Visible = false;
                //---

                chkDin.Visible = true;
                chkDebito_.Visible = true;
                chkCredito.Visible = true;
                chkTickets.Visible = true;
                cboTickets.Visible = true;
                btnDelItem.Visible = true;

                id_cli = txtNomeCli.SelectedValue.ToString();
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                tabControl1.Visible = true;

                preenche_grid(grdHistoricoCreditoDado, id_cli);
                //preenche_grid(grdHistoricoCreditosUsados, id_cli);


                if (grdHistoricoCreditoDado.RowCount > 0)
                {
                    groupBox2.Visible = true;
                }

                groupBox3.Visible = true;

                getSaldoCli();

            }
        }

        public void calculaTotalPeriodo(DataGridView grd, string filtro = "")
        {
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

            string query = "select convert(varchar, cast(isnull(sum(valor_credito),0) as money),1) as 'totalPeriodo' from " + tabela + " where id_cliente = " + id_cli + " and (obs='' or isnull(obs,'')='') " + filtro;
            txt.Text = c.RetornaQuery(query, "totalPeriodo");
        }

        public void getSaldoCli()
        {
            string saldo;

            saldo = c.RetornaQuery("select convert(varchar, cast(isnull(saldo,0) as money),1) as 'saldo' from saldo_credito_cli where id_cliente=" + id_cli, "saldo");

            txtSaldo.Text = saldo;
        }

        private void btnAddCredito_Click(object sender, EventArgs e)
        {
            //double valor_credito_dado;
            string sValor;
            string data;
            int formaPagto = 0;
            int id_tp_ticket = 0;

            if (chkDin.Checked || chkCredito.Checked || chkDebito_.Checked || chkTickets.Checked)
            {

                if (txtValorDado.Text == "")
                {
                    MessageBox.Show("Valor não pode ser branco");
                }
                else
                {
                    data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
                    sValor = txtValorDado.Text.Replace(",", ".");

                    if (chkDin.Checked == true)
                    {
                        formaPagto = 1;
                    }
                    else if (chkDebito_.Checked == true)
                    {
                        formaPagto = 6;
                    }
                    else if (chkCredito.Checked == true)
                    {
                        formaPagto = 7;
                    }
                    else if (chkTickets.Checked == true)
                    {
                        formaPagto = 8;  //voucher / ticket - olhar coluna id_tp_ticket para saber qual

                        if (cboTickets.SelectedIndex.ToString() == "0")
                        {
                            MessageBox.Show("Atenção: Nenhum voucher selecionado !!", "Pode näo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto DEUERRO;
                        }
                        else
                        {
                            id_tp_ticket = cboTickets.SelectedIndex;
                        }

                    }


                    c.ExecutaQuery("insert into historico_credito_dado values(" + id_cli + "," + sValor + ",'" + data + "', ''," + formaPagto.ToString() + "," + id_tp_ticket + ")" +
                        " insert into extratoCreditoCli values(" + id_cli + "," + sValor + ",'" + data + "', '')");


                    preenche_grid(grdHistoricoCreditoDado, id_cli);
                    txtValorDado.Text = "";
                    groupBox2.Visible = true;
                    getSaldoCli();


                    if (chkImprimir.Checked)
                    {
                        ImprimeTicket imprimir = new ImprimeTicket();

                        imprimir.ImprimeReciboCreditoCli(c.RetornaQuery("select nome from clientes where id=" + id_cli, "nome"), "R$ "+ sValor, c.getSaldoCreditoCliente(id_cli.ToString()), int.Parse(qttVias.Value.ToString()));

                    }
                        
                }
            }
            else
            {
                MessageBox.Show("Selecione a forma de pagamento !", "Oooppps", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            DEUERRO: int a = 1;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eu viajei.. pq eh possivel adicionar valor ao grid "utilizados"
            //fiquei com preguica de arrumar.. vou desabilitar o botao e boa!

            string tab_titulo = tabControl1.SelectedTab.ToString();
            // DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                btnAddCredito.Enabled = true;
            }
            else
            {
                btnAddCredito.Enabled = false;
                preenche_grid(grdHistoricoCreditosUsados, id_cli);
                grdHistoricoCreditosUsados.ClearSelection();
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            string tab_titulo = tabControl1.SelectedTab.ToString();
            DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                grid = grdHistoricoCreditoDado;
            }
            else
            {
                grid = grdHistoricoCreditosUsados;
            }

            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                string filtro;
                filtro = "and convert(date, data, 103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "'";
                preenche_grid(grid, id_cli, filtro);
            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL que a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorDado.Text = "";
        }

        private void btnLimpaFiltro_Click(object sender, EventArgs e)
        {
            string tab_titulo = tabControl1.SelectedTab.ToString();
            DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                grid = grdHistoricoCreditoDado;
            }
            else
            {
                grid = grdHistoricoCreditosUsados;
            }

            preenche_grid(grid, id_cli);
        }

        private void abrePedido(object sender, DataGridViewCellEventArgs e)
        {
            int idp = Convert.ToInt32(grdHistoricoCreditosUsados[2, grdHistoricoCreditosUsados.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);

            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtNomeCli_SelectedIndexChanged(sender, e);
        }

        private void chkTickets_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTickets.Checked)
            {
                cboTickets.Enabled = true;
            }
            else
            {
                cboTickets.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");


        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            if (grdHistoricoCreditoDado.Rows.Count > 0)
            {

                if (MessageBox.Show("Tem certeza que deseja remover ?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    String id = grdHistoricoCreditoDado[0, grdHistoricoCreditoDado.CurrentRow.Index].Value.ToString();

                    double valor_a_ser_deletado = double.Parse(c.RetornaQuery("select valor_credito from historico_credito_dado where id = " + id, "valor_credito"));

                    c.ExecutaQuery("delete from historico_credito_dado where id = " + id);

                    double saldoAtual = double.Parse(c.RetornaQuery("select saldo from saldo_credito_cli where id_cliente = " + id_cli, "saldo"));

                    if(saldoAtual > 0 && ((saldoAtual - valor_a_ser_deletado >=0 )))
                    {
                        c.ExecutaQuery("update saldo_credito_cli set saldo = " + (saldoAtual - valor_a_ser_deletado).ToString() + " where id_cliente=" + id_cli);
                    }else
                    {
                        c.ExecutaQuery("update saldo_credito_cli set saldo = 0sc where id_cliente=" + id_cli);
                    }

                    //grdHistoricoCreditoDado.Rows.RemoveAt(grdHistoricoCreditoDado.CurrentRow.Index);
                    btnDelItem.Enabled = false;

                    getSaldoCli();
                    txtNomeCli_SelectedIndexChanged(sender, e);

                }
            }
        }

        private void grdHistoricoCreditoDado_MouseClick(object sender, MouseEventArgs e)
        {
            btnDelItem.Enabled = true;
        }
    }
}
