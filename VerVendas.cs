using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;
using ImprimeTicketNE;

namespace WindowsFormsApplication2
{
    public partial class frmVerVendas : Form
    {
        conexao c = new conexao();
        ImprimeTicket imprime = new ImprimeTicket();
        String id_cli;
        double credito_usado;

        public frmVerVendas(int id_pedido)
        {
            InitializeComponent();

            int id = id_pedido;

            txtIdPed.Text = id.ToString().PadLeft(4, '0');

            txtNome.Text = c.RetornaQuery("select nome from vendas where id=" + id, "nome");
            txtObs.Text = c.RetornaQuery("select obs from vendas where id=" + id, "obs");
            txtTelCli.Text = c.RetornaQuery("select telefone from clientes c left outer join vendas v on c.id = v.id_cliente where v.id=" + id, "telefone");
            txtHrEntrega.Text = c.RetornaQuery("select hora_entrega from clientes c left outer join vendas v on c.id = v.id_cliente where v.id=" + id, "hora_entrega");

            id_cli = c.RetornaQuery("select id_cliente from vendas where id=" + id, "id_cliente");

 

            if (c.RetornaQuery("select isnull(isCancelado,0) as 'isCancelado' from vendas where id=" + id, "isCancelado") == "1")
            {
                lblCancelado.Visible = true;
            }
            else
            {
                lblCancelado.Visible = false;
            }

            if (txtTelCli.Text == "0")
            {
                txtTelCli.Text = "";
            }

            if (txtHrEntrega.Text == "0")
            {
                txtHrEntrega.Text = "";
            }


            groupDetalhesEntrega.Visible = false;

            int isEntrega = int.Parse(c.RetornaQuery("select isnull(isEntrega,0) as 'isEntrega'from vendas where id=" + id, "isEntrega"));

            if (isEntrega == 1)
            {
                rdoEntrega.Checked = true;
                groupDetalhesEntrega.Visible = true;
                txtDetalhesEntrega.Text = c.RetornaQuery("select isnull(detalhes_entrega,'') as 'detalhes_entrega' from vendas where id=" + id, "detalhes_entrega");
            } else
            {
                rdoBalcao.Checked = true;
            }

            //preenche grid ... 

            string select = "select ROW_NUMBER() over(order by vi.id_venda) as 'Item', vi.qtt as 'Qtdade', concat('R$ ',convert(varchar, cast(vi.preco_item as money),1)) as 'Preço Ítem',  p.descr as 'Descrição', concat('R$ ',convert(varchar, cast(vi.preco_item*vi.qtt-(vi.preco_item*vi.qtt*v.desconto) as money),1)) as 'Preço Total' from vendas_itens vi left outer join produto p on p.id=vi.id_prod left outer join vendas v on v.id=vi.id_venda where vi.id_venda=" + id_pedido;

            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdItens.ReadOnly = true;
            grdItens.DataSource = ds.Tables[0];





            this.grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdItens.MultiSelect = false;

            grdItens.ClearSelection();

            CalculaPrecoTotal();

            String sDesconto = c.RetornaQuery("select desconto from vendas where id=" + id.ToString(), "desconto");

            if (sDesconto != "0")
            {
                chkDesconto.Checked = true;
                chkDesconto.Visible = true;
                chkDesconto.Enabled = false;
            }

            int iTpPagto = int.Parse(c.RetornaQuery("select isnull(forma_pagto,0) as forma_pagto from vendas where id=" + id, "forma_pagto"));

            int PagtoPendente = int.Parse(c.RetornaQuery("select isnull(is_pagto_pendente,0) as is_pagto_pendente from vendas where id=" + id, "is_pagto_pendente"));

            switch (iTpPagto)
            {
                case 1:
                    chkDin.Checked = true;
                    break;
                case 2:
                    chkCielo.Checked = true;
                    break;
                case 3:
                    chkPagseguro.Checked = true;
                    break;
                case 5:
                    chkCreditoCli.Checked = true;
                    break;
                case 6:
                    chkDebito.Checked = true;
                    break;
                case 7:
                    chkCredito.Checked = true;
                    break;
                case 8:
                    chkTicket.Checked = true;
                    lblTpTicket.Text = c.RetornaQuery("select tt.ticket from tp_tickets tt left outer join vendas v on tt.id = v.id_ticket where v.id=" + id, "ticket");
                    lblTpTicket.Visible = true;
                    break;
            }

            if (PagtoPendente == 1)
            {
                chkPagtoPendente.Checked = true;
            }

            if (c.RetornaQuery("select isnull(is2Formaspagto_PagtoPend_Credito,0) as 'is2Formaspagto_PagtoPend_Credito' from vendas where id=" + id, "is2Formaspagto_PagtoPend_Credito") == "1")
            {
                //MessageBox.Show("eh 2 formas");
                lblCreditoUtz.Text = "Utilizou R$ " + c.RetornaQuery("select valor_credito_utilizado from auxCreditosUtilizados where id_venda=" + id, "valor_credito_utilizado") + " dos créditos";
                lblCreditoUtz.Visible = true;
                lbl2formas_pend.Visible = true;

                if (PagtoPendente == 1)
                {
                    lbl2formas_pend.Text = "R$ " + c.RetornaQuery("select valor_pendente from auxCreditosUtilizados where id_venda=" + id, "valor_pendente") + " como pagamento pendente";
                }else
                {
                    lbl2formas_pend.Text = "e R$ " + c.RetornaQuery("select valor_total_venda-valor_credito_utilizado as 'restante' from auxCreditosUtilizados where id_venda=" + id, "restante") + " o restante";
                }
            }

            btnClose.Focus();

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            

            //if (MessageBox.Show("Deseja cancelar o pedido?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtIdPed.Text != "")
                {
                    conexao c = new conexao();
                    int idvenda = Convert.ToInt32(txtIdPed.Text);

                    String forma_pagto = c.RetornaQuery("SELECT FORMA_PAGTO FROM VENDAS WHERE ID = " + idvenda.ToString(), "FORMA_PAGTO");
                    String is2formasPagto = c.RetornaQuery("SELECT is2Formaspagto_PagtoPend_Credito FROM VENDAS WHERE ID = " + idvenda.ToString(), "is2Formaspagto_PagtoPend_Credito");

                    if (forma_pagto == "5" || is2formasPagto == "1")
                    {
                        if (MessageBox.Show("Essa venda debitou creditos do cliente e eles serão ESTORNADOS automaticamente. Continuar?", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (is2formasPagto == "1")
                            {
                                credito_usado = double.Parse(c.RetornaQuery("SELECT valor_credito_utilizado FROM auxCreditosUtilizados WHERE id_venda=" + idvenda.ToString(), "valor_credito_utilizado"));
                            }else
                            {
                                credito_usado = double.Parse(c.RetornaQuery("SELECT preco_total FROM vendas WHERE id=" + idvenda.ToString(), "preco_total"));
                            }
                           // c.ExecutaQuery("update vendas set isCancelado=1 where id=" + idvenda.ToString());
                           // MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK);
                        }

                        String data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
                        c.ExecutaQuery("insert into historico_credito_dado values(" + id_cli + "," + credito_usado.ToString().Replace(",",".") + ",'" + data + "', 'Estorno pedido " + idvenda.ToString() + "', 0, null)");
                        c.ExecutaQuery("update historico_credito_utilizado set obs='Estornado' where id_venda=" + idvenda.ToString());
                        c.ExecutaQuery("insert into extratoCreditoCli values(" + id_cli + "," + credito_usado.ToString().Replace(",", ".") + ",'" + data + "', 'Estorno pedido " + idvenda.ToString() + "')");
                        MessageBox.Show("R$ " + credito_usado.ToString("#.00") + " foram estornados para " + txtNome.Text);
                        c.ExecutaQuery("update vendas set isCancelado=1 where id=" + idvenda.ToString());
                        MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK);
                        lblCancelado.Visible = true;
                    }
                    else
                    {
                        c.ExecutaQuery("update vendas set isCancelado=1 where id=" + idvenda.ToString());
                        MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK);
                        lblCancelado.Visible = true;
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        conexao co = new conexao();

  
        private void button1_Click(object sender, EventArgs e)
        {

            ImprimeTicket imprime = new ImprimeTicket();

            imprime.GeraLayoutTicket(grdItens, co, Convert.ToInt32(txtIdPed.Text), chkDesconto, "");

            imprime.ImprimeTkt(imprime.getTicketCliente(), "");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImprimeTicket imprime = new ImprimeTicket();

            imprime.GeraLayoutTicket(grdItens, co, Convert.ToInt32(txtIdPed.Text), chkDesconto, "");

            imprime.ImprimeTkt("", imprime.getTicketEmpresa());
        }




        public void CalculaPrecoTotal()
        {
            int rowscount = grdItens.Rows.Count;
            double preco_total;
            
            preco_total = 0;

            for (int i = 0; i < rowscount; i++)
            {
                preco_total = preco_total + double.Parse(grdItens.Rows[i].Cells[4].Value.ToString().Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
                //grdItens[0, i].Value = i + 1;
            }

            txtPrecoTotal.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");
            grdItens.ClearSelection();


        }

        private void load(object sender, EventArgs e)
        {
            grdItens.ClearSelection();
        }


        
    }
}
