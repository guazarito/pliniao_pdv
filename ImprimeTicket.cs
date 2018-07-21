using System;
using Epson;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace ImprimeTicketNE
{

    public class ImprimeTicket
    {
        public ImprimeTicket()
        {
        }


        public static string DoFormat(double myNumber)
        {
            var s = string.Format("{0:0.00}", myNumber);

            if (s.EndsWith("00"))
            {
                return ((int)myNumber).ToString();
            }
            else
            {
                return s;
            }
        }

        String szTextoCli = "";
        String szTextoEmp = "";

        public String getTicketCliente()
        {
            return this.szTextoCli;
        }

        public String getTicketEmpresa()
        {
            return this.szTextoEmp;
        }

        public void GeraLayoutTicket(DataGridView grd, conexao c, int num_ped, CheckBox chkEstudante)
        {
            int k;

            String sEntrega = "BALCÃO";

            for (k = 0; k < grd.RowCount; k++)
            {
                if (grd[3, k].Value.ToString().IndexOf("entrega") > 0)
                {
                    sEntrega = "ENTREGA";
                }
            }

            int iIsentrega;
            iIsentrega = int.Parse(c.RetornaQuery("select isnull(isEntrega,0) as isEntrega from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "isEntrega"));

            if (sEntrega == "ENTREGA" || iIsentrega == 1)
            {
                sEntrega = "ENTREGA";
            }

            String detalhes_entrega = "";

            if (iIsentrega == 1)
            {
                detalhes_entrega = c.RetornaQuery("select isnull(detalhes_entrega,'') as detalhes_entrega from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "detalhes_entrega");

            }


            String sNome;
            String sObs;
            sNome = c.RetornaQuery("select isnull(nome,'') as nome from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "nome");
            sObs = c.RetornaQuery("select isnull(obs,'') as obs from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "obs");


            //preco total do pedido
            String sPrecoTotalPedido = "0";
            String sPrecoTotalPedidoComDesconto = "0";

            int tem2formasPagto_pendente_credito = 0;

            tem2formasPagto_pendente_credito = Convert.ToInt32(c.RetornaQuery("select is2Formaspagto_PagtoPend_Credito from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "is2Formaspagto_PagtoPend_Credito"));

            //se tem 2 formas de pagamento, o valor total esta na tabela auxiliar auxCreditosUtilizados, se nao o valor total esta na tabela vendas msm
            if (tem2formasPagto_pendente_credito == 1)
            {
                sPrecoTotalPedido = c.RetornaQuery("select isnull(valor_total_venda,0) as valor_total_venda from auxCreditosUtilizados where id_venda=" + Convert.ToInt32(num_ped).ToString(), "valor_total_venda");
            } else
            {
                sPrecoTotalPedido = c.RetornaQuery("select isnull(preco_total,0) as preco_total from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "preco_total");
            }


            double Desconto = 0;


            Desconto = double.Parse(c.RetornaQuery("select isnull(desconto,0) as desconto from vendas where id=" + Convert.ToInt32(num_ped).ToString(), "desconto").Replace(",", "."), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);

            if (Desconto != 0) //possui desconto...
            {

                double auxPrecoTotal;

                auxPrecoTotal = double.Parse(sPrecoTotalPedido.Replace(",", "."), System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.NumberFormatInfo.InvariantInfo);

                sPrecoTotalPedidoComDesconto = auxPrecoTotal.ToString();

                auxPrecoTotal = auxPrecoTotal / (1 - Desconto);

                sPrecoTotalPedido = auxPrecoTotal.ToString("#.#0");
            }
            else
            {
                double auxPT = Convert.ToDouble(sPrecoTotalPedido);

                sPrecoTotalPedido = auxPT.ToString("#.#0");
            }

            //VIA CLIENTE ============================================================================================================



            szTextoCli = "<ce>------------------------------------------\n</ce>";
            szTextoCli += "<ce><c><e><b>MARMITARIA PLINIÃO</b></e>\n";
            szTextoCli += "CNPJ: 22.095.906/0001-70   Inscrição Estadual: 181.233.395.114\n";
            szTextoCli += "Rua: Mario Ybarra de Almeida, 295   Bairro: Centro\n";
            szTextoCli += "<b>Tel: (16) 3472-0905</b>   Cidade: Araraquara/SP\n";
            szTextoCli += "--------------------------------------------------------\n";
            szTextoCli += "<c><b><e>" + sEntrega + "</e></b></c>\n";
            szTextoCli += "Número do pedido:\n";
            szTextoCli += "<e><b><s>" + num_ped.ToString() + "</s></b></e>\n";
            szTextoCli += "</c></ce><c>----------------------------------------------------------------\n";
            szTextoCli += "Ítem   Qtde   Descrição                 Vlr. Unit.    Vlr.Total\n";
            szTextoCli += "----------------------------------------------------------------\n</c>";

            int tamanho_espacos1 = 28;
            int tamanho_espacos2 = 14;
            string spc1 = "";
            string spc2 = "";

            String nome_item = "";
            String preco_item = ""; 

            for (k = 0; k < grd.RowCount; k++)
            {
                nome_item =  grd[3, k].Value.ToString();
                preco_item = grd[2, k].Value.ToString();

                if (nome_item.Length > tamanho_espacos1)
                {
                    nome_item = nome_item.Substring(0, tamanho_espacos1 -2);
                }

                spc1 = new String(' ', tamanho_espacos1 - nome_item.Length);
                
                if (preco_item.Length >= tamanho_espacos2)
                {
                    preco_item = preco_item.Substring(0, tamanho_espacos2);
                }
            
                spc2 = new String(' ', tamanho_espacos2 - preco_item.Length);

                preco_item = preco_item.Replace("R$ ", "");

                szTextoCli += "<c>  " + grd[0, k].Value.ToString() + "     " + grd[1, k].Value.ToString() + "     " + nome_item + spc1 + preco_item + spc2 + grd[4, k].Value.ToString().Replace("R$ ","") + "</c>\n";
            }

            szTextoCli += "<c>----------------------------------------------------------------</c>\n";
            szTextoCli += "<b><ad>VALOR TOTAL: " + sPrecoTotalPedido + "</ad></b>\n";

            if (chkEstudante.Checked == true)
            {
                szTextoCli += "<b><ad>VALOR TOTAL COM DESCONTO: <s>" + sPrecoTotalPedidoComDesconto + "</s></ad></b>\n";
            }

            szTextoCli += "<c>----------------------------------------------------------------</c>\n";
            szTextoCli += "<c><ce>";
            szTextoCli += "Emissão " + DateTime.Now.ToString("g") + "</c></ce>\n\n";
            szTextoCli += "<ce><b></c><c><b>Via do Cliente</c></b>\n";
            szTextoCli += "<c><e><s>" + sNome + "</s></e></c>\n\n";
            szTextoCli += "</b></ce><c><ce>Cardápio diário em:</c>\n";
            szTextoCli += "<c>www.facebook.com/marmitariapliniao \n";
            szTextoCli += "";
            szTextoCli += "</ce></c>";
            szTextoCli += "<c><ce>--------------------------------------------------------</ce></c>\n";
            szTextoCli += "<c><ce><b>OBRIGADO PELA PREFERÊNCIA, VOLTE SEMPRE</b></ce></c>\n";
            szTextoCli += "<c><ce>--------------------------------------------------------</ce></c>\n";
            szTextoCli += "<gui></gui>";

            //FIM VIA CLIENTE ================================================================================================

            //VIA EMPRESA ============================================================================================================


            String sIdCli = "0";

            sIdCli = c.RetornaQuery("select isnull(id_cliente,0) as id_cliente from vendas where id =" + Convert.ToInt32(num_ped).ToString(), "id_cliente");

            //String sHrEntrega = txtHrEntrega.Text;
            //String STelCli = txtTelCli.Text;

            String sHrEntrega = "";
            String STelCli = "";

            sHrEntrega = c.RetornaQuery("select hora_entrega from clientes where id =" + sIdCli, "hora_entrega");
            STelCli = c.RetornaQuery("select telefone from clientes where id =" + sIdCli, "telefone");


            if (sHrEntrega != "")
            {
                sHrEntrega = "<s>Entregar:</s> " + sHrEntrega;
            }


            szTextoEmp += "Número do pedido:           " + "<ad>" + DateTime.Now.ToString("g") + "</ad>\n"; ;
            szTextoEmp += "<e><b><s>" + num_ped.ToString() + "</s></b></e>\n";
            szTextoEmp += "<ce><b><xl>" + sEntrega + "</xl></b></ce>\n";
            szTextoEmp += "<c><e>--------------------------------\n</e></c>";
            szTextoEmp += "<c>Qtde   Descrição                                    Vlr.Total\n</c>";
            szTextoEmp += "<c><e>--------------------------------\n</e></c>";

            int tamanho_espacos_1 = 23;
          //  int tamanho_espacos_2 = 4;
            string spc_1 = "";
            string spc_2 = "";

            String nome_item_ = ""; 
            String preco_item_ = ""; 

            for (k = 0; k < grd.RowCount; k++)
            {
                nome_item_ =  grd[3, k].Value.ToString();
                preco_item_ = grd[2, k].Value.ToString();

                if (nome_item_.Length > tamanho_espacos_1)
                {
                    nome_item_ = nome_item_.Substring(0,tamanho_espacos_1 -2);
                }

                spc_1 = new String(' ', tamanho_espacos_1 - nome_item_.Length);

             /*   if (preco_item_.Length >= tamanho_espacos_2)
                {
                    preco_item_ = preco_item_.Substring(0, tamanho_espacos_2);
                }
            */
              //  spc_2 = new String(' ', tamanho_espacos_2 - preco_item_.Length);

                preco_item_ = preco_item_.Replace("R$ ", "");


               // szTextoEmp += "<c><e> " + grd[1, k].Value.ToString() + " " + nome_item_ + spc_1 + preco_item_ + spc_2 + grd[4, k].Value.ToString() + "<e></c>\n";
                szTextoEmp += "<c><e> " + grd[1, k].Value.ToString() + " " + nome_item_ + spc_1 + grd[4, k].Value.ToString().Replace("R$ ", "") + "<e></c>\n";

            }

            /*          for (k = 0; k < grd.RowCount; k++)
                       {
                           string spc1 = new String(' ', 21 - grd[3, k].Value.ToString().Length);
                           string spc2 = new String(' ', 10 - grd[2, k].Value.ToString().Length);


                           szTextoEmp += "<c><e>   " + grd[1, k].Value.ToString() + " " + grd[3, k].Value.ToString() + spc1 + grd[2, k].Value.ToString() + spc2 + grd[4, k].Value.ToString() + "<e></c>\n";
                       }
           */
            szTextoEmp += "<c><e>--------------------------------</e></c>\n";
            szTextoEmp += "<b><ad><da>VALOR TOTAL: " + sPrecoTotalPedido + "</da></ad></b>\n";

            if (chkEstudante.Checked == true)
            {
                szTextoEmp += "<b><ad><da>VALOR TOTAL COM DESCONTO: <s>" + sPrecoTotalPedidoComDesconto + "</s></da></ad></b>\n";
            }



            szTextoEmp += "<c>----------------------------------------------------------------</c>\n";
            // szTextoEmp += "<c><ce>";
            //szTextoEmp += "Emissão " + DateTime.Now.ToString("g") + "</c></ce>\n";
            //szTextoEmp += "<ce><b></c><c><b>Via Marmitaria</c></b>\n\n";
            szTextoEmp += "<ce><b><xl><s>" + sNome + "</s></xl></b></ce>\n\n";
            szTextoEmp += "<e><c><b><s>" + "Info Pedido:" + "</s></b></c></e>\n";
            szTextoEmp += "<e><c>" + sObs + "</c></e> \n";
            szTextoEmp += "<c>-------------------------------------------</c>\n";
            szTextoEmp += "<e><c><b><s>" + "Info Entrega:" + "</s></b></c></e>\n";
            szTextoEmp += "<e><c> " + detalhes_entrega + "</c></e> \n";



            if (sHrEntrega != "")
            {
                szTextoEmp += "<e><c><b>" + sHrEntrega + "</b><c></e>\n";
            }

            if (STelCli != "")
            {
                szTextoEmp += "<e><c>Tel: " + STelCli + "<c></e>\n";
            }

            String qGarfo = "select garfo from vendas where id=" + Convert.ToInt32(num_ped).ToString();

            if (c.RetornaQuery(qGarfo, "garfo") == "1")
            {
                szTextoEmp += "<e><c><b><s>" + "==== ENVIAR GARFO =====" + "</s></b></c></e>\n";
            }

            szTextoEmp += "<e><c><b><s>" + "Info Entrega:" + "</s></b></c></e>\n";
            szTextoEmp += "<e><c> " + detalhes_entrega + "</c></e> \n";

            szTextoEmp += "</e></ce></c>";
            szTextoEmp += "<gui></gui>";
            //fim prepara string para impressao

        }


        //funcoes da impressora termica ===================================================================================================================
        private int iRetorno;

        public bool iniciaPortaToolStripMenuItem()
        {
            //Para impressora USB
            if (File.Exists(@"c:\pliniao\confiprinterport.dat"))
            {

                String porta = File.ReadAllText(@"c:\pliniao\confiprinterport.dat");

                try
                {
                    iRetorno = InterfaceEpsonNF.IniciaPorta(porta);
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Erro ao iniciar porta " + porta + "\n\n" + exx.ToString());
                }

            }
            else
            {
                try
                {
                    iRetorno = InterfaceEpsonNF.IniciaPorta("USB");
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Erro ao iniciar porta USB" + "\n\n" + exx.ToString());
                }
            }

            

            if (iRetorno == 1)
                // System.Windows.Forms.MessageBox.Show("Porta de comunicação aberta com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            else
                System.Windows.Forms.MessageBox.Show("Erro ao conectar com a Impressora Térmica.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }


        //fim funcoes da impressora termica ===============================================================================================================

        public void ImprimeTkt(String strCli = "", String strEmpr = "")
        {
            if (iniciaPortaToolStripMenuItem())
            {
                if (strCli != "")
                {
                    iRetorno = InterfaceEpsonNF.ImprimeTextoTag(strCli);

                    if (iRetorno != 1)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao imprimir texto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                if (strEmpr != "")
                {
                    iRetorno = InterfaceEpsonNF.ImprimeTextoTag(strEmpr);

                    if (iRetorno != 1)
                    {
                        System.Windows.Forms.MessageBox.Show("Erro ao imprimir texto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


                InterfaceEpsonNF.FechaPorta();

            }
        }
        
    }
}

