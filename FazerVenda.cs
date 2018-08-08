using System;
using System.Windows.Forms;
using ImprimeTicketNE;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class frmFazerVenda : Form
    {

        //variaveis globais utilizados no credito dos clientes.. 
        bool creditosInsuficientes = false;
        bool salvouAcertoDiferencaNoFrame = false;
        double valorSalvoFrameCreditoClientes_creditoUtilizado = 0;
        double valorSalvoFrameCreditoClientes_valDiferenca = 0;
        int id_credito_utilizado;
        //--

        public frmFazerVenda()
        {
            InitializeComponent();

            conexao c = new conexao();
            int id = c.RetornaIdVendaAtual();
            txtNumPed.Text = id.ToString().PadLeft(5, '0');
            c.fillCombo(this.cboBebidas, "select * from produto where tipo<>1 order by descr", "id", "descr");
            c.fillCboTicket(cboTickets);

            this.grdVenda.KeyDown += new KeyEventHandler(grdVenda_KeyDown);
            this.grdVenda.CellMouseClick += new DataGridViewCellMouseEventHandler(grdVenda_CellMouseClick);

            cboBebidas.SelectedIndex = -1;

            this.grdVenda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdVenda.MultiSelect = false;

            this.chkEstudante.CheckedChanged += new EventHandler(chkEstudante_CheckedChanged);

            KeyDown += new KeyEventHandler(form_KeyDown);

            groupDetalhesEntrega.Visible = false;

            c.fillCombo(txtNome, "select * from clientes order by nome", "id", "nome");
            txtNome.SelectedValue = 0;

            qttRef.Focus();
            

            txtNome.SelectedIndexChanged +=new EventHandler(txtNome_SelectedIndexChanged);
            txtNome.LostFocus += new EventHandler(txtNome_LostFocus);


            

        }

        public void txtNome_LostFocus(Object sender, EventArgs e)
        {
            if (txtNome.SelectedValue == null)
            {
                chkPagtoPendente.Enabled = false;
                chkPagtoPendente.Checked = false;
                txtHrEntrega.Text = "";

                chkCreditosClientes.Enabled = false;
                chkCreditosClientes.Checked = false;
            }
        }

        conexao c = new conexao();
        public void txtNome_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (txtNome.SelectedValue != null)
            {
                if (txtNome.SelectedValue.ToString() != "0" && txtNome.SelectedValue.ToString() != "System.Data.DataRowView")
                {
                    chkPagtoPendente.Enabled = true;
                    txtHrEntrega.Text = c.RetornaQuery("select hora_entrega from clientes where id=" + txtNome.SelectedValue.ToString(), "hora_entrega");
                    txtTelCli.Text = c.RetornaQuery("select telefone from clientes where id=" + txtNome.SelectedValue.ToString(), "telefone");

                    String saldo_cli = c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString());
                    lblSaldoCreditoCli.Visible = true;
                    lblSaldoCreditoCli.Text = "(Saldo de Crédito: R$ " + saldo_cli + ")";

                    if (saldo_cli != "0" && saldo_cli != "0.00")
                    {
                        chkCreditosClientes.Enabled = true;
                    }
                    chkCreditosClientes_Click(sender, e);
                }

            }

        }

        public void form_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                rdoPqna.Checked = true;
               
            }
            if (e.KeyCode == Keys.F2)
            {
                rdoMedia.Checked = true;

            }
            if (e.KeyCode == Keys.F3)
            {
                rdoGde.Checked = true;

            }
            if (e.KeyCode == Keys.F4)
            {
                rdoPf.Checked = true;

            }
            if (e.KeyCode == Keys.F5)
            {
                rdoEntrega.Checked = true;
                txtDetalhesEntrega.Focus();

            }
             if (e.KeyCode==Keys.F6)
              {
                  chkDin.Checked = true;
                  
              }

              else if (e.KeyCode == Keys.F7)
              {
                chkDebito.Checked = true;  
              }
              else if (e.KeyCode == Keys.F8)
              {
                chkCredito.Checked = true;
              }
              else if (e.KeyCode == Keys.F11)
              {

                  if (chkPagtoPendente.Enabled == true)
                  {
                      chkPagtoPendente.Checked = true;
                  }
              }

              else if (e.KeyCode == Keys.F10)
              {
                  chkDin.Checked = false;
                  chkCielo.Checked = false;
                  chkPagseguro.Checked = false;
                  chkPagtoPendente.Checked = false;

                  if (chkCreditosClientes.Enabled == true)
                  {
                      chkCreditosClientes.Checked = true;
                  }
              }
            else if (e.KeyCode == Keys.F9)
            {
                chkTickets.Checked = true;
            }

            else if (e.Alt && (e.KeyCode == Keys.G))
            {
                if (chkGarfo.Checked == true)
                {
                    chkGarfo.Checked = false;
                }
                else
                {
                    chkGarfo.Checked = true;
                }
            }

        }

        public void chkEstudante_CheckedChanged(Object sender, EventArgs e)
        {
            CalculaPrecoTotal();
        }

        public void grdVenda_KeyDown(Object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (grdVenda.Rows.Count > 0)
                {
                    if (MessageBox.Show("Tem certeza que deseja remover o item " + grdVenda[0, grdVenda.CurrentRow.Index].Value + " ?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        grdVenda.Rows.RemoveAt(grdVenda.CurrentRow.Index);
                        CalculaPrecoTotal();
                    }
                }
            }
        }


        public void grdVenda_CellMouseClick(Object sender, EventArgs e)
        {
            btnDelItem.Visible = true;
            btnDelItem.Enabled = true;
            // MessageBox.Show(grdVenda.CurrentRow.Index.ToString());
        }


        public void CalculaPrecoTotal()
        {
            int rowscount = grdVenda.Rows.Count;
            decimal preco_total;
            decimal preco_total_desconto;
            preco_total = 0;

            for (int i = 0; i < rowscount; i++)
            {
                preco_total = preco_total + Convert.ToDecimal(grdVenda.Rows[i].Cells[4].Value);
                grdVenda[0, i].Value = i + 1;
            }

            if (chkEstudante.Checked == true)
            {
                preco_total_desconto = preco_total - (preco_total * Convert.ToDecimal(0.10));
                lblTotalDesc.Visible = true;
                txtPrecoTotDesconto.Visible = true;
                txtPrecoTotDesconto.Text = String.Format("{0:n2}", preco_total_desconto).Replace(",", ".");
            }
            else
            {
                lblTotalDesc.Visible = false;
                txtPrecoTotDesconto.Visible = false;
            }


            txtPrecoTotal.Text = String.Format("{0:n2}", preco_total).Replace(",", ".");
            grdVenda.ClearSelection();


        }



        private void btnAddRef_Click(object sender, EventArgs e)
        {
            if (rdoGde.Checked == true || rdoMedia.Checked == true || rdoPqna.Checked == true || rdoPf.Checked == true)
            {
                if (qttRef.Value == 0)
                {
                    MessageBox.Show("Insira a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conexao c = new conexao();
                    int qtt;
                    qtt = Convert.ToInt32(qttRef.Value);


                    if (rdoPqna.Checked == true)
                    {
                        int id_prod = Convert.ToInt32(c.RetornaQuery("select id from produto where descr like '%marmitex pequeno%'", "id"));
                        double price = double.Parse(c.RetornaQuery("select convert(varchar, cast(preco as money),1) as preco from produto where descr like '%marmitex pequeno%'", "preco"), System.Globalization.CultureInfo.InvariantCulture);
                        string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qtt.ToString(), price.ToString("#.#0"), c.RetornaQuery("select descr from produto where descr like '%marmitex pequeno%'", "descr"), (qtt * price).ToString("#.#0"), id_prod.ToString() };
                        grdVenda.Rows.Add(row1);
                    }
                    else if (rdoMedia.Checked == true)
                    {
                        int id_prod = Convert.ToInt32(c.RetornaQuery("select id from produto where descr like '%marmitex m%dio%'", "id"));
                        double price = double.Parse(c.RetornaQuery("select convert(varchar, cast(preco as money),1) as preco from produto where descr like '%marmitex m%dio%'", "preco"), System.Globalization.CultureInfo.InvariantCulture);
                        string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qtt.ToString(), price.ToString("#.#0"), c.RetornaQuery("select descr from produto where descr like '%marmitex m%dio%'", "descr"), (qtt * price).ToString("#.#0"), id_prod.ToString() };
                        grdVenda.Rows.Add(row1);
                    }
                    else if (rdoGde.Checked == true)
                    {
                        int id_prod = Convert.ToInt32(c.RetornaQuery("select id from produto where descr like '%marmitex grande%'", "id"));
                        double price = double.Parse(c.RetornaQuery("select convert(varchar, cast(preco as money),1) as preco from produto where descr like '%marmitex grande%'", "preco"), System.Globalization.CultureInfo.InvariantCulture);
                        string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qtt.ToString(), price.ToString("#.#0"), c.RetornaQuery("select descr from produto where descr like '%marmitex grande%'", "descr"), (qtt * price).ToString("#.#0"), id_prod.ToString() };
                        grdVenda.Rows.Add(row1);
                    }
                    else if (rdoPf.Checked == true)
                    {
                        int id_prod = Convert.ToInt32(c.RetornaQuery("select id from produto where descr like '%prato feito%'", "id"));
                        double price = double.Parse(c.RetornaQuery("select convert(varchar, cast(preco as money),1) as preco from produto where descr like '%prato feito%'", "preco"), System.Globalization.CultureInfo.InvariantCulture);
                        string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qttRef.Value.ToString(), price.ToString("#.#0"), c.RetornaQuery("select descr from produto where descr like '%prato feito%'", "descr"), (qtt * price).ToString("#.#0"), id_prod.ToString() };
                        grdVenda.Rows.Add(row1);
                    }

                    CalculaPrecoTotal();

                    if (chkCreditosClientes.Checked)
                    {
                        chkCreditosClientes_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um tipo de refeição", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddBebida_Click(object sender, EventArgs e)
        {
            if (cboBebidas.SelectedIndex != -1)
            {
                if (qttBebidas.Value == 0)
                {
                    MessageBox.Show("Insira a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int qtt;
                    qtt = Convert.ToInt32(qttBebidas.Value);
                    conexao c = new conexao();
                    int id_prod = Convert.ToInt32(cboBebidas.SelectedValue.ToString());
                    double price = double.Parse(c.RetornaQuery("select convert(varchar, cast(preco as money),1) as preco from produto where id=" + cboBebidas.SelectedValue.ToString(), "preco"), System.Globalization.CultureInfo.InvariantCulture);
                    string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), qtt.ToString(), price.ToString("#.#0"), c.RetornaQuery("select descr from produto where id=" + cboBebidas.SelectedValue.ToString(), "descr").ToString(), (qtt * price).ToString("#.#0"), id_prod.ToString() };
                    grdVenda.Rows.Add(row1);
                    CalculaPrecoTotal();

                    if (chkCreditosClientes.Checked)
                    {
                        chkCreditosClientes_Click(sender, e);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um ítem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDelItem_Click(object sender, EventArgs e)
        {

            if (grdVenda.Rows.Count > 0)
            {
                if (MessageBox.Show("Tem certeza que deseja remover o item " + grdVenda[0, grdVenda.CurrentRow.Index].Value + " ?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    grdVenda.Rows.RemoveAt(grdVenda.CurrentRow.Index);
                    btnDelItem.Enabled = false;
                    CalculaPrecoTotal();


                    if (chkCreditosClientes.Checked)
                    {
                        chkCreditosClientes_Click(sender, e);
                    }
                }
            }
        }

        double preco_total;
        double preco_total_desconto;
        int iGarfo = 0;

        public void btnConcluirPedido_Click(object sender, EventArgs e)
        {
            int num_rows;
            num_rows = grdVenda.Rows.Count;

            //int id_credito_utilizado;

            int tem_outra_forma_pagto = 0;
            //variavel que indica se utilizou de creditos e outra forma de pgto


            if (num_rows > 0)
            {
                if (chkDebito.Checked || chkCredito.Checked || chkDin.Checked == true || chkCielo.Checked == true || chkPagseguro.Checked == true || chkPagtoPendente.Checked == true || chkCreditosClientes.Checked == true || chkTickets.Checked == true )
                {
                    if (MessageBox.Show("Concluir pedido " + txtNumPed.Text.ToString() + "?", "Concluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        if (chkGarfo.Checked)
                        {
                            iGarfo = 1;
                        }

                        if (chkEstudante.Checked)
                        {

                            //gambi pra poder fazer venda mais de mil reais
                            String preco_tod = txtPrecoTotDesconto.Text;
                            preco_tod = preco_tod.Replace(".", "");
                            preco_tod = preco_tod.Insert(preco_tod.Length - 2, ".");
                            //fim gambi

                            preco_total_desconto = double.Parse(preco_tod, System.Globalization.CultureInfo.InvariantCulture);
                            // preco_total_desconto = double.Parse(txtPrecoTotDesconto.Text, System.Globalization.CultureInfo.InvariantCulture);
                            //     }



                            //codigo colado:



                            //                        if (chkEstudante.Checked == true)
                            //                        {
                            string[] row1 = new string[] { (grdVenda.Rows.Count + 1).ToString(), "", "", "Desconto Estudante 10%", "" };
                            grdVenda.Rows.Add(row1);
                        }

                        int pagto_pendente = 0;

                        if (chkPagtoPendente.Checked == true)
                        {
                            pagto_pendente = 1;
                        }

                        conexao c = new conexao();

                        //gambi pra poder fazer venda mais de mil reais
                        String preco_to = txtPrecoTotal.Text;
                        preco_to = preco_to.Replace(".", "");
                        preco_to = preco_to.Insert(preco_to.Length - 2, ".");
                        //fim gambi

                        preco_total = double.Parse(preco_to, System.Globalization.CultureInfo.InvariantCulture);
                        int num_ped;
                        //  num_ped = Convert.ToInt32(txtNumPed.Text);
                        int i;
                        String obs = txtObs.Text.ToString();
                        String nome = txtNome.Text.ToString();

                        String sDetalhesEntrega = "";

                        int isEntrega = 0;

                        if (rdoEntrega.Checked)
                        {
                            sDetalhesEntrega = txtDetalhesEntrega.Text;
                            isEntrega = 1;
                        }

                        String sQuery;

                        //============================FORMA PAGTO CODIGOS===============================
                        int formaPagto = 0;
                        int id_ticket = 0;
                        //1 ->Dinheiro
                        //2 ->Cartao Cielo
                        //3 ->Cartao PagSeguro
                        //5 ->Usando credito do cliente
                        //6 ->Cartao Debito
                        //7 ->Cartao Credito
                        //8 -> voucher/ticket - olhar coluna id_ticket para saber qual

                        //pagamento pendente vai com 0. o flag que determina é is_pagto_pendente=1 na tabela vendas
                        //============================FORMA PAGTO CODIGOS===============================

                        if (chkDin.Checked == true)
                        {
                            formaPagto = 1;
                        }
                        else if (chkCielo.Checked == true)
                        {
                            formaPagto = 2;
                        }
                        else if (chkPagseguro.Checked == true)
                        {
                            formaPagto = 3;
                        }
                        else if (chkCreditosClientes.Checked == true)
                        {
                            formaPagto = 5;
                        }
                        else if (chkDebito.Checked == true)
                        {
                            formaPagto = 6;
                        }
                        else if (chkCredito.Checked == true)
                        {
                            formaPagto = 7;
                        }
                        else if (chkTickets.Checked)
                        {
                            if (cboTickets.SelectedIndex.ToString() == "0")
                            {
                                MessageBox.Show("Atenção: Nenhum voucher selecionado !!", "Pode näo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto DEUERRO;
                            }
                            else
                            {
                                formaPagto = 8;
                                id_ticket = cboTickets.SelectedIndex;
                            }

                        }

                        int id_cliente = 0;
                        if (txtNome.SelectedValue != null)
                        {
                            id_cliente = int.Parse(txtNome.SelectedValue.ToString());
                        }

                        String dinheiro_Recebido;
                        if (txtDin.Text != "")
                        {
                            dinheiro_Recebido = String.Format("{0:n2}", txtDin.Text).Replace(",", ".");
                        }
                        else
                        {
                            dinheiro_Recebido = "0";
                        }



                        if (chkCreditosClientes.Checked)
                        {
                            double saldoCli = double.Parse(c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString()), System.Globalization.CultureInfo.InvariantCulture);
                            //double preco_total;

                            string preco_total_aux = "0";

                            if (!chkEstudante.Checked)
                            {
                                preco_total_aux = txtPrecoTotal.Text.Replace(".", "");
                            }
                            else
                            {
                                preco_total_aux = txtPrecoTotDesconto.Text.Replace(".", "");
                            }

                            preco_total_aux = preco_total_aux.Insert(preco_total_aux.Length - 2, ",");
                            preco_total = double.Parse(preco_total_aux);


                            if (saldoCli < preco_total && !salvouAcertoDiferencaNoFrame)
                                {
                                    creditosInsuficientes = true;
                                    MessageBox.Show("Saldo de créditos insuficientes. Utilize o botao (+) vermelho para acertar !");
                                    goto DEUERRO;
                                }
                                else
                                {
                                    lblSaldoCreditoCli.ForeColor = System.Drawing.Color.ForestGreen;
                                    btnAcertarCreditosInsuf.Visible = false;

                                }
                            
                                if (formaPagto == 5 && !creditosInsuficientes) // utilizar credito do cliente
                                {
                                    String data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                                    //c.ExecutaQuery("insert into historico_credito_utilizado values(" + id_cliente + "," + String.Format("{0:n2}", preco_total).Replace(",", ".") + ",'" + data + "')");
                                    String query;
                                    query = "insert into historico_credito_utilizado values(" + id_cliente + "," + String.Format("{0:n2}", preco_total).Replace(",", ".") + ",'" + data + "', null, null)";
                                // int id_credito_utilizado = int.Parse(c.RetornaQuery(query, "idCredito"));
                                c.ExecutaQuery(query);

                                String extratoquery = "insert into extratoCreditoCli values(" + id_cliente + "," + String.Format("{0:n2}", preco_total *-1).Replace(",", ".") + ",'" + data + "', '')";
                                c.ExecutaQuery(extratoquery);

                                id_credito_utilizado = int.Parse(c.RetornaQuery("select isnull(max(id),0) as idCredito from historico_credito_utilizado", "idCredito"));
                                //existe um trigger "usaCreditoCli", que atualiza o saldo do cliente 
                                //no banco de dados após a insercao na tabela historico_credito_utilizado

                                lblSaldoCreditoCli.Text = c.getSaldoCreditoCliente(id_cliente.ToString());
                                }
                                else if (formaPagto == 5 && creditosInsuficientes)
                                {
                                    String data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");

                                    double dValorCreditoUtilizado = 0;

                                    try
                                    {
                                        dValorCreditoUtilizado = double.Parse(txtFrameUtilizar.Text.Replace(".", ","));
                                    }
                                    catch (Exception ex)
                                    {
                                        if (salvouAcertoDiferencaNoFrame)
                                        {
                                            MessageBox.Show("Valor de credito utilizado INVALIDO!\n\n" + ex);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ajuste o valor do crédito no botao vermelhro (+)!\n\n");
                                        }
                                    }

                                    if (dValorCreditoUtilizado != 0) //se for !=0 o valor digitado foi validado
                                    {

                                        //TODO
                                        //verificar vendas todas.. testar com desconto e sem desconto.. REVISAR tudo.
                                        //good luck

                                        //============================FORMA PAGTO VALOR EXCEDENTE DOS CREDITOS===============================
                                       
                                        //1 ->Dinheiro
                                        //2 -> Cartao


                                        //pagamento pendente vai com 0. o flag que determina é is_pagto_pendente=1 na tabela vendas
                                        //============================FORMA PAGTO CODIGOS===============================


                                        tem_outra_forma_pagto = 1; //entrou aqui quer dizer que usou 2 formas de pagto..

                                        if (rdoFrameCartao.Checked)
                                        {
                                            formaPagto = 2;
                                        }
                                        else if (rdoFrameDinheiro.Checked)
                                        {
                                            formaPagto = 1;
                                        }
                                        else if (rdoFramePgtoPendente.Checked)
                                        {
                                            formaPagto = 5;
                                        }

                                        double valCredito = double.Parse(txtFrameUtilizar.Text.Replace(".", ","));

                                        data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");

                                        //aqui estou debitando do credito...
                                        c.ExecutaQuery("insert into historico_credito_utilizado values(" + id_cliente + ","
                                            + String.Format("{0:n2}", valCredito).Replace(",", ".") + ",'" + data + "', null, null)");

                                        id_credito_utilizado = int.Parse(c.RetornaQuery("select isnull(max(id),0) as idCredito from historico_credito_utilizado", "idCredito"));


                                        String extratoquery = "insert into extratoCreditoCli values(" + id_cliente + "," + String.Format("{0:n2}", valCredito * -1).Replace(",", ".") + ",'" + data + "', '')";
                                        c.ExecutaQuery(extratoquery);

                                    //esse insert dispara uma trigger que ja calcula o saldo do cliente..
                                    //....


                                    //somente se a diferenca for do tipo pagamento pendente é que utilizaremos
                                    //a tabela de apoio auxCreditosUtilizados.
                                    //ex: a compra deu 100 reais, o cliente apenas tem 80 de credito.
                                    //    o cliente decidiu colocar 20 como "pagamento pendente"
                                    //neste caso adicionamos 20 na tabela vendas com flag is_pagto_pendente=1
                                    //e adicionamos 80 na tabela auxiliar..

                                    //isto é feito pq os pagamentos pendentes sao controlados atraves da tabela vendas
                                    //nao poderiamos adicionar os 100 flegados como pendente uma vez que 80 ja foram creditados do cliente
                                    //em suma: conta deu 100, cliente 80 credito, 20 pendente
                                    //table vendas=> 20 com is_pagto_pendente=1, 80 na auxCreditosUtilizados

                                    //no relatório verifica se ta flegado is2Formaspagto_PagtoPend_Credito=1 e da um
                                    //jeito de somar com o valor que esta na tabela auxCreditosUtilizados.
                                    // \!/ 


                                    double valorVaiPagtoPendente;
                                            double valorCreditoUsado = double.Parse(txtFrameUtilizar.Text.Replace(".", ","));
                                            valorVaiPagtoPendente = double.Parse(txtFrameDiferenca.Text.Replace(".", ","));

                                            double valorTotalVenda = valorCreditoUsado + valorVaiPagtoPendente;

                                            if (!rdoFramePgtoPendente.Checked) //se optou a diferenca como pagto pendente..
                                            {
                                                valorVaiPagtoPendente = 0;
                                            }
                                            else
                                            {
                                                pagto_pendente = 1;
                                            }



                                            //insere na auxiliar o valor do credito, valor que vai pra pendente e total da venda...
                                            c.ExecutaQuery("begin transaction venda declare @id as integer select @id = max(id) from vendas set @id = @id + 1 IF EXISTS (SELECT 1 FROM dbo.vendas WHERE id = @id) BEGIN  set @id = @id + 1 END insert into auxCreditosUtilizados values(@id," + valorCreditoUsado.ToString().Replace(",", ".") + "," + valorTotalVenda.ToString().Replace(",", ".") + "," + valorVaiPagtoPendente.ToString().Replace(",", ".") + ") commit");

        
                                             //muda o valor da variavel que sera inserido em VENDAS
                                             //para o valor pendente pagto..(explicacao disso ta ai em cima :X )


                                            if (rdoFramePgtoPendente.Checked)
                                            {
                                                if (chkEstudante.Checked)
                                                {
                                                    preco_total_desconto = valorVaiPagtoPendente;
                                                }
                                                else
                                                {
                                                    preco_total = valorVaiPagtoPendente;
                                                }
                                            }
                                    }

                                }
                            }
                            //   / fim do bloco que faz os tramites dos creditos dos clientes... segue o jogo ->


                            if (chkEstudante.Checked == true)
                            {
                                sQuery = "begin transaction venda declare @id as integer select @id = ISNULL(max(id),0) from vendas set @id = @id + 1 IF EXISTS (SELECT 1 FROM dbo.vendas WHERE id = @id) BEGIN  set @id = @id + 1 END insert into vendas values(@id,'" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff") + "', " + String.Format("{0:n2}", preco_total).Replace(",", ".") + ", '" + obs + "', '" + nome + "',0,'0.1'," + formaPagto.ToString() + "," + pagto_pendente.ToString() + ", " + id_cliente + ", " + dinheiro_Recebido + ", '" + sDetalhesEntrega + "', " + isEntrega.ToString() + "," + tem_outra_forma_pagto + "," + id_ticket + "," + iGarfo + ") select @id as idPed commit";
                            }
                            else
                            {
                                sQuery = "begin transaction venda declare @id as integer select @id = ISNULL(max(id),0) from vendas set @id = @id + 1 IF EXISTS (SELECT 1 FROM dbo.vendas WHERE id = @id) BEGIN  set @id = @id + 1 END insert into vendas values(@id,'" + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff") + "', " + String.Format("{0:n2}", preco_total).Replace(",", ".") + ", '" + obs + "', '" + nome + "',0,''," + formaPagto.ToString() + "," + pagto_pendente.ToString() + ", " + id_cliente + ", " + dinheiro_Recebido + ", '" + sDetalhesEntrega + "', " + isEntrega.ToString() + "," + tem_outra_forma_pagto + "," + id_ticket + "," + iGarfo + ") select @id as idPed commit";
                            }


                            // numero retornado pela query acima  (begin transaction venda...) .. garante valor unico no bd independentemente de varios pcs usando o sistema..
                            num_ped = int.Parse(c.RetornaQuery(sQuery, "idPed"));
                           // int s_id_credito_utilizado = id_credito_utilizado;

                            if ((formaPagto == 5 && !creditosInsuficientes) || tem_outra_forma_pagto==1)  // utilizar credito do cliente
                            {
                                c.ExecutaQuery("update historico_credito_utilizado set id_venda=" + num_ped.ToString() + " where id=" + id_credito_utilizado.ToString());
                                c.ExecutaQuery("update extratoCreditoCli set obs='Pedido " + num_ped.ToString() + "' where id=" + c.RetornaQuery("select max(id) as 'id' from extratoCreditoCli","id"));
                            }


                            for (i = 0; i < num_rows; i++)
                            {
                                sQuery = "begin transaction venda_item declare @id as integer set @id=" + grdVenda.Rows[i].Cells["ColItem"].Value.ToString() + " insert into vendas_itens values(@id," + num_ped.ToString() + ", " + grdVenda.Rows[i].Cells["id_produto"].Value.ToString() + ", " + grdVenda.Rows[i].Cells["ColQtt"].Value.ToString() + ", " + grdVenda.Rows[i].Cells["ColPrecoItem"].Value.ToString().Replace(",", ".") + ") commit";
                                //MessageBox.Show(sQuery);
                                c.ExecutaQuery(sQuery);
                            }


                            if (rdoSimTkt.Checked == true)
                            {

                            //imprime recibo ? ? ----------------------------------------------
                            ImprimeTicket imprime = new ImprimeTicket();

                            imprime.GeraLayoutTicket(grdVenda, c, num_ped, chkEstudante);
                            //-------------------------------------------------------------------

                            

                                if (File.Exists(@"c:\pliniao\prefmaq.dat"))
                                {

                                    String tpMaq = File.ReadAllText(@"c:\pliniao\prefmaq.dat");

                                    if (tpMaq == "SER")
                                    {
                                      //  imprime.ImprimeTkt(szTextoCli, szTextoEmp);
                                        imprime.ImprimeTkt(imprime.getTicketCliente(), imprime.getTicketEmpresa());

                                    }
                                    else if (tpMaq == "EST")
                                    {
                                        if (c.InsereFilaImpressa(num_ped, imprime.getTicketCliente(), imprime.getTicketEmpresa()))                                         {
                                            MessageBox.Show("Pedido inserido na fila de impressão!\n\nAguarde alguns segundos para o início da impressão..", "Fila");
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("ERRO!\nArquivo 'pliniao/prefmaq.dat' corrompido ou inexistente. ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto DEUERRO;
                                }
                            }

                            MessageBox.Show("Concluído!", "Done");




                            //limpa o form após concluir .....................
                            txtNumPed.Text = "";
                            qttRef.Value = 0;
                            qttBebidas.Value = 0;
                            txtObs.Text = "";
                            txtPrecoTotal.Text = "0.00";
                            rdoGde.Checked = false;
                            rdoMedia.Checked = false;
                            rdoPqna.Checked = false;
                            rdoPf.Checked = false;
                            btnDelItem.Visible = false;
                            cboBebidas.SelectedIndex = -1;
                            txtPrecoTotDesconto.Text = "";
                            lblTotalDesc.Visible = false;
                            txtPrecoTotDesconto.Visible = false;
                            txtTelCli.Text = "";
                            grdVenda.Rows.Clear();
                            lblSaldoCreditoCli.Visible = false;
                            btnAcertarCreditosInsuf.Visible = false;


                            //conexao c = new conexao();
                            int id = c.RetornaIdVendaAtual();
                            txtNumPed.Text = id.ToString().PadLeft(5, '0');
                            txtNome.Text = "";
                            txtHrEntrega.Text = "";

                            chkPagtoPendente.Checked = false;
                            chkPagtoPendente.Enabled = false;
                            chkCreditosClientes.Checked = false;
                            chkCreditosClientes.Enabled = false;
                            chkEstudante.Checked = false;
                            chkDin.Checked = false;
                            chkCielo.Checked = false;
                            chkPagseguro.Checked = false;

                            rdoNaoTkt.Checked = false;
                            rdoSimTkt.Checked = true;

                            txtDin.Text = "";
                            txtDin.Visible = false;

                            lblTroco.Text = "";
                            lblTroco.Visible = false;

                            statusBar.Text = "";
                            valorSalvoFrameCreditoClientes_creditoUtilizado = 0;
                            valorSalvoFrameCreditoClientes_valDiferenca = 0;
                            salvouAcertoDiferencaNoFrame = false;

                            txtDetalhesEntrega.Text = "";

                            rdoBalcao.Checked = true;
                            rdoEntrega.Checked = false;
                            groupDetalhesEntrega.Visible = false;

                            //fim limpa o form ....................

                        
                    }
                }
                else
                {
                    MessageBox.Show("Selecione a Forma de Pagamento.", "Erro: Forma de pagamento", MessageBoxButtons.OK);
                }
                }
                else
                {
                    MessageBox.Show("Insira pelo menos um ítem no pedido.", "Erro", MessageBoxButtons.OK);
                }
        DEUERRO:
            int a = 1; //do nothing
            }
//        }

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

            if (!chkCreditosClientes.Checked)
            {
                btnAcertarCreditosInsuf.Visible = false;
            }
        }

        private void chkCielo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDin.Checked)
            {
                txtDin.Visible = true;
            }
            else
            {
                txtDin.Visible = false;
            }

            if (!chkCreditosClientes.Checked)
            {
                btnAcertarCreditosInsuf.Visible = false;
            }
        }

        private void chkPagseguro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDin.Checked)
            {
                txtDin.Visible = true;
            }
            else
            {
                txtDin.Visible = false;
            }

            if (!chkCreditosClientes.Checked)
            {
                btnAcertarCreditosInsuf.Visible = false;
            }
        }

        private void chkPagtoPendente_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDin.Checked)
            {
                txtDin.Visible = true;
            }
            else
            {
                txtDin.Visible = false;
            }

            if (!chkCreditosClientes.Checked)
            {
                btnAcertarCreditosInsuf.Visible = false;
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

                if (Regex.IsMatch(txtDin.Text, @"^\d+$") || txtDin.Text.IndexOf(".")>0)
                {
                    if (!chkEstudante.Checked)
                    {
                        preco = double.Parse(txtPrecoTotal.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        preco = double.Parse(txtPrecoTotDesconto.Text, System.Globalization.CultureInfo.InvariantCulture);
                    }

                    try {
                        dinheiroRecebido = double.Parse(txtDin.Text, System.Globalization.CultureInfo.InvariantCulture);
                        aux = dinheiroRecebido - preco;
                        lblTroco.Visible = true;
                        lblTroco.Text = "Troco: R$ " + aux.ToString("#.00");
                    } catch
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

        private void lblSaldoCreditoCli_Click(object sender, EventArgs e)
        {
            lblSaldoCreditoCli.Text = "(Saldo de Crédito: R$ " + c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString()) + ")";

            double saldocli = double.Parse(c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString()).Replace(".", ","));
            


            if (salvouAcertoDiferencaNoFrame)
            {
                valorSalvoFrameCreditoClientes_creditoUtilizado = saldocli;
                
            }

            if (saldocli != 0)
            {
                chkCreditosClientes.Enabled = true;
            }
        }

        private void chkCreditosClientes_Click(object sender, EventArgs e)
        {
            if (chkCreditosClientes.Checked)
            {
                double saldoCli = double.Parse(c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString()), System.Globalization.CultureInfo.InvariantCulture);
                double preco_total;

                //gambi pra poder fazer venda mais de mil reais
                String preco_to;
                //fim gambi

                if (chkEstudante.Checked)
                {
                    preco_to = txtPrecoTotDesconto.Text;
                    preco_to = preco_to.Replace(".", "");
                    preco_to = preco_to.Insert(preco_to.Length - 2, ".");
                   
                    preco_total = double.Parse(preco_to, System.Globalization.CultureInfo.InvariantCulture);
                }
                else
                {

                    preco_to = txtPrecoTotal.Text;
                    preco_to = preco_to.Replace(".", "");
                    preco_to = preco_to.Insert(preco_to.Length - 2, ".");

                    preco_total = double.Parse(preco_to, System.Globalization.CultureInfo.InvariantCulture);
                }

                if (saldoCli < preco_total)
                {
                    lblSaldoCreditoCli.ForeColor = System.Drawing.Color.DarkRed;
                    btnAcertarCreditosInsuf.Visible = true;
                }else
                {
                    lblSaldoCreditoCli.ForeColor = System.Drawing.Color.ForestGreen;
                    btnAcertarCreditosInsuf.Visible = false;
                    
                }
            }
        }

        private void btnAcertarCreditosInsuf_Click(object sender, EventArgs e)
        {
            double preco_total;
            double saldo_cliente;
            double diferenca;
            double utilizar_saldo;

           // salvouAcertoDiferencaNoFrame = false; //variavel que controla se o user salvou as alteracoes.

            if (chkEstudante.Checked)
            {
                txtFrameTotalPedido.Text = txtPrecoTotDesconto.Text;
      
            }else
            {
                txtFrameTotalPedido.Text = txtPrecoTotal.Text;
            }


            string preco_total_aux = txtFrameTotalPedido.Text.Replace(".", "");
            preco_total_aux = preco_total_aux.Insert(preco_total_aux.Length - 2, ",");
            preco_total = double.Parse(preco_total_aux);

            txtFrameSaldoCli.Text = c.getSaldoCreditoCliente(txtNome.SelectedValue.ToString());

            saldo_cliente = double.Parse(txtFrameSaldoCli.Text.Replace(".", ","));


            if (valorSalvoFrameCreditoClientes_creditoUtilizado != 0 && valorSalvoFrameCreditoClientes_valDiferenca != 0)
            {

                txtFrameUtilizar.Text = valorSalvoFrameCreditoClientes_creditoUtilizado.ToString();
            }
            else
            {
                txtFrameUtilizar.Text = txtFrameSaldoCli.Text;
            }


            utilizar_saldo = double.Parse(txtFrameUtilizar.Text.Replace(".", ","));
            diferenca = preco_total - utilizar_saldo;
            
            if (diferenca < 1)
            {
                txtFrameDiferenca.Text = diferenca.ToString("0.#0");
            }else
            {
                txtFrameDiferenca.Text = diferenca.ToString("#.#0");
            }
            panel2.Visible = true;

        }

        private void btnFrameFechar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void txtFrameUtilizar_TextChanged(object sender, EventArgs e)
        {
            double utilizar;

            if (txtFrameUtilizar.Text != "")
            {
                txtFrameUtilizar.Text = txtFrameUtilizar.Text.Replace(",", ".");
                txtFrameUtilizar.Select(txtFrameUtilizar.Text.Length, 0);
            }
            else
            {
                utilizar = 0;
            }

            if (Regex.IsMatch(txtFrameUtilizar.Text, @"^\d+$") || txtFrameUtilizar.Text.IndexOf(".") > 0)
            {
                
                utilizar = 0;

                double total_ped = double.Parse(txtFrameTotalPedido.Text);

                int posicaoPonto;

                txtFrameUtilizar.Text = txtFrameUtilizar.Text.Replace(",", ".");

                posicaoPonto = txtFrameUtilizar.Text.IndexOf(".");

                // MessageBox.Show(posicaoPonto.ToString());

                try
                {
                    utilizar = double.Parse(txtFrameUtilizar.Text);

                    if (posicaoPonto == -1)
                    {
                        utilizar *= 100; //gambiarra da porra!
                    }

                }
                catch (Exception ex)
                {

                }


                double saldo = double.Parse(txtFrameSaldoCli.Text);

                if (saldo < utilizar)
                {
                    MessageBox.Show("Atencao: O saldo máximo é: " + txtFrameSaldoCli.Text);
                }
                else
                {
                    double dif = total_ped - utilizar;
                    txtFrameDiferenca.Text = dif.ToString();
                    txtFrameDiferenca.Text = txtFrameDiferenca.Text.Insert(txtFrameDiferenca.Text.Length - 2, ".");
                }

            }
        }

        private void btnFrameSalvar_Click(object sender, EventArgs e)
        {
            if (rdoFrameDinheiro.Checked == false && rdoFramePgtoPendente.Checked == false && rdoFrameCartao.Checked == false)
            {
                MessageBox.Show("Selecione a forma de pagamento da diferenca!!");
            }else
            {
                creditosInsuficientes = true; //variavel que controla se a compra excedeu o credito do cliente...


                String fPgto = "";

                if (rdoFrameDinheiro.Checked)
                {
                    fPgto = "Dinheiro:";
                }else if (rdoFrameCartao.Checked)
                {
                    fPgto = "Cartao:";
                }else if (rdoFramePgtoPendente.Checked)
                {
                    fPgto = "Pagamento Pendente:";
                }

                txtFrameUtilizar.Text = txtFrameUtilizar.Text.Replace(",", ".");

                txtFrameDiferenca.Text = txtFrameDiferenca.Text.Replace(",", ".");


               
                
                   valorSalvoFrameCreditoClientes_creditoUtilizado = double.Parse(txtFrameUtilizar.Text);

                   valorSalvoFrameCreditoClientes_valDiferenca = double.Parse(txtFrameDiferenca.Text);

                String S_valorSalvoFrameCreditoClientes_creditoUtilizado = valorSalvoFrameCreditoClientes_creditoUtilizado.ToString();
                String S_valorSalvoFrameCreditoClientes_valDiferenca = valorSalvoFrameCreditoClientes_valDiferenca.ToString();

                if (txtFrameUtilizar.Text.IndexOf(".")>0){
                    S_valorSalvoFrameCreditoClientes_creditoUtilizado=S_valorSalvoFrameCreditoClientes_creditoUtilizado.Insert(S_valorSalvoFrameCreditoClientes_creditoUtilizado.Length - 2, ".");
                }

                if (txtFrameDiferenca.Text.IndexOf(".") > 0)
                {
                    S_valorSalvoFrameCreditoClientes_valDiferenca= S_valorSalvoFrameCreditoClientes_valDiferenca.Insert(S_valorSalvoFrameCreditoClientes_valDiferenca.Length - 2, ".");
                }



                statusBar.Text = "Créditos utilizados: R$ " + S_valorSalvoFrameCreditoClientes_creditoUtilizado
                + "    /     " + fPgto + " R$ " + S_valorSalvoFrameCreditoClientes_valDiferenca ;

                salvouAcertoDiferencaNoFrame = true; // variavel que controla se o user salvou as alteracoes

                if (MessageBox.Show("Salvo !","OK", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    panel2.Visible = false;
                }

            }
        }

        private void rdoEntrega_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoEntrega.Checked)
            {
                groupDetalhesEntrega.Visible = true;
            }else
            {
                groupDetalhesEntrega.Visible = false;
            }
        }

        private void rdoBalcao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBalcao.Checked)
            {
                groupDetalhesEntrega.Visible = false;
            }
            else
            {
                groupDetalhesEntrega.Visible = true;
            }
        }

        private void chkTickets_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTickets.Checked)
            {
                cboTickets.Enabled = true;
            }else
            {
                cboTickets.Enabled = false;
            }
        }

        private void btnAddRef_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddRef_Click(sender, e);
            }
        }
    }
}
