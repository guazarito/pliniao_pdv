using System;
using System.Drawing;
using Epson;
using System.Windows.Forms;
using System.IO;
using ImprimeTicketNE;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{

    public partial class MDIParent1 : Form
    {


        public MDIParent1()
        {

            InitializeComponent();


            AlteraVersao altera = new AlteraVersao();
            //altera.gera_pagto_funcionario();

            toolMnuCadastro.LostFocus += new EventHandler(toolStripContainer1_LostFocus);


            //alerta de contas a pagar::

            DateTime dtini = DateTime.Now;
            DateTime dtfim = DateTime.Now.AddDays(5);

            String dtIni = dtini.ToString("yyyy-MM-dd");
            String dtFim = dtfim.ToString("yyyy-MM-dd");

            conexao c = new conexao();

            timer1.Enabled = true;
            int interval = int.Parse(c.RetornaQuery("select isnull(tempo,0) as tempo from tempo_fila_impressao", "tempo"));

            if (interval == 0)
            {
                timer1.Interval = 10000; //tempo padrao.. 10s
            }
            else
            {
                timer1.Interval = interval;
            }


            int qtt_ct_pagar_prox_vencto = int.Parse(c.RetornaQuery("select isnull(count(*),0) as 'ct' from contas_pagar where convert(date, vencimento, 103) >='" + dtIni + "' and convert(date, vencimento, 103)<='" + dtFim + "'", "ct"));

            if (qtt_ct_pagar_prox_vencto > 0)
            {
                notifyIcon1.Text = "Ct Pagar Pliniao";
                notifyIcon1.Icon = SystemIcons.Exclamation;
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(4000, "Contas a Pagar", qtt_ct_pagar_prox_vencto.ToString() + " Contas próximas ao vencimento", ToolTipIcon.Info);
                notifyIcon1.Click += new EventHandler(notifyIcon1_Click);
            }
            //fim alerta contas a pagar....
        }

        public void notifyIcon1_Click(object sender, EventArgs e)
        {
            frmFinancas finan = new frmFinancas();
            finan.Show();
        }

        public void toggleVisibleSubMenus(ToolStripContainer tsc)
        {


            if (tsc != null)
            {
                if (tsc.Visible)
                {
                    tsc.Visible = false;
                }
                else
                {
                    tsc.Visible = true;
                }
            }
            else
            {
                toolMnuCadastro.Visible = false;
                mnuRelatorios.Visible = false;
            }

        }


        public void toolStripContainer1_LostFocus(object sender, EventArgs e)
        {
            toolMnuCadastro.Visible = false;
        }


        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnVenda_Click(object sender, EventArgs e)
        {
            frmFazerVenda newMDIChild = new frmFazerVenda();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();

            toggleVisibleSubMenus(null);

        }


        public void btnConsulta_Click(object sender, EventArgs e)
        {

            frmConsulta newMDIChild2 = new frmConsulta();
            // newMDIChild2.MdiParent = this;
            newMDIChild2.Show();

            toggleVisibleSubMenus(null);
        }



        private void btnCadastro_Click(object sender, EventArgs e)
        {
            //if (toolMnuCadastro.Visible)
            //{
            //    toolMnuCadastro.Visible = false;
            //}
            //else
            //{
            //    toolMnuCadastro.Visible = true;
            //}

            toggleVisibleSubMenus(toolMnuCadastro);

            //frmCadastro newMDIChild3 = new frmCadastro();
            //newMDIChild3.MdiParent = this;
            //newMDIChild3.Show();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            frmLogin newMDIChild4 = new frmLogin();
            newMDIChild4.MdiParent = this;
            newMDIChild4.Show();
        }

        private void btnRels_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(mnuRelatorios);

        }

        private int iRetorno;
        private void statusImpressoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirPortaUSBToolStrip();
            iRetorno = InterfaceEpsonNF.Le_Status();

            switch (iRetorno)
            {
                case 0:
                    System.Windows.Forms.MessageBox.Show("Erro de comunicação / Impressora OFFLINE.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 5:
                    System.Windows.Forms.MessageBox.Show("Impressora com pouco papel.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 9:
                    System.Windows.Forms.MessageBox.Show("Tampa aberta.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 24:
                    System.Windows.Forms.MessageBox.Show("Impressora 'ONLINE'.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case 32:
                    System.Windows.Forms.MessageBox.Show("Impressora sem papel.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            InterfaceEpsonNF.FechaPorta();
        }

        private void abrirPortaUSBToolStrip()
        {

            if (File.Exists(@"c:\pliniao\confiprinterport.dat"))
            {

                String porta = File.ReadAllText(@"c:\pliniao\confiprinterport.dat");

                iRetorno = InterfaceEpsonNF.IniciaPorta(porta);
            }
            else {

                iRetorno = InterfaceEpsonNF.IniciaPorta("USB");
            }

            if (iRetorno == 1)
            {
                //System.Windows.Forms.MessageBox.Show("Porta de comunicação aberta com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Erro ao conectar com a Impressora Térmica.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnFinancas_Click(object sender, EventArgs e)
        {
            frmFinancas newMDIChild = new frmFinancas();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
            toggleVisibleSubMenus(null);
        }

        private void btnCadProd_Click(object sender, EventArgs e)
        {
            frmCadastro newMDIChild3 = new frmCadastro();
            newMDIChild3.MdiParent = this;
            newMDIChild3.Show();

            toggleVisibleSubMenus(toolMnuCadastro);
        }

        private void Form_closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadCli_Click(object sender, EventArgs e)
        {
            frmCadCli newMDIChild3 = new frmCadCli();
            newMDIChild3.MdiParent = this;
            newMDIChild3.Show();

            toggleVisibleSubMenus(toolMnuCadastro);
        }

        private void btnRelVendas_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(mnuRelatorios);
            frmRel rel = new frmRel();
            rel.MdiParent = this;
            //MessageBox.Show("aqui ok");
            senha_form frm = new senha_form(rel);
        }

        private void btnRelPagtosPendentes_Click(object sender, EventArgs e)
        {
            toggleVisibleSubMenus(mnuRelatorios);

            PagtosPendentes pp = new PagtosPendentes();
            pp.MdiParent = this;
            //pp.Show();

            senha_form frm = new senha_form(pp);


        }

        private void button2_Click(object sender, EventArgs e)
        {

            toggleVisibleSubMenus(mnuRelatorios);
            frmFaturamento fatu = new frmFaturamento();
            fatu.MdiParent = this;
            senha_form frm = new senha_form(fatu);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmAgenda ag = new frmAgenda();
            ag.Show();

            toggleVisibleSubMenus(null);
        }

        private void configurarPortaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigPortaImpressoa config = new ConfigPortaImpressoa();
            config.Show();
        }

        private void preferênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preferencias p = new preferencias();

            p.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (File.Exists(@"c:\pliniao\prefmaq.dat"))
            {

                String tpMaq = File.ReadAllText(@"c:\pliniao\prefmaq.dat");

                if (tpMaq == "SER")
                {

                    conexao c = new conexao();

                    //abrirPortaUSBToolStrip();
                    //iRetorno = InterfaceEpsonNF.Le_Status();


                    var conn = new OdbcConnection();
                    conn.ConnectionString =
                                  "Dsn=odbc_pliniao;" +
                                  "Uid=sa;" +
                                  "Pwd=chico110388;";

                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao conectar no banco de dados.\n" + ex);
                    }

                    String query = "select * from fila_impressao where status='na fila' or status='erro'";
                    OdbcCommand cmd = new OdbcCommand(query, conn);
                    OdbcDataReader dr = cmd.ExecuteReader();

                    String id_item_fila;
                    String texto_impressao_cli;
                    String texto_impressao_empresa;

                    while (dr.Read())
                    {

                        id_item_fila = dr["id"].ToString();
                        texto_impressao_cli = dr["textocli"].ToString();
                        texto_impressao_empresa = dr["textoemp"].ToString();

                        ImprimeTicket i = new ImprimeTicket();
                        try
                        {
                            i.ImprimeTkt(texto_impressao_cli, texto_impressao_empresa);
                            c.ExecutaQuery("update fila_impressao set status='impresso' where id=" + id_item_fila);
                        }
                        catch
                        {
                            c.ExecutaQuery("update fila_impressao set status='erro' where id=" + id_item_fila);
                        }
                    }
                }
            }


            // AlteraVersao altera = new AlteraVersao();

            //   private void atualiza_tabela_pagar_func(object sender, EventArgs e)
            //   {
            // altera.gera_pagto_funcionario();
            // MessageBox.Show(DateTime.Now.ToString());
            //    }







        }

        private void filaImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFilaImpressao fi = new FrmFilaImpressao();
            fi.Show();
        }

        private void btnShowCreditos_Click(object sender, EventArgs e)
        {
            frmCreditoCli cc = new frmCreditoCli();
            cc.Show();
        }

        private void btnTpTickets_Click(object sender, EventArgs e)
        {
            cadTickets ct = new cadTickets();
            ct.MdiParent = this;
            ct.Show();
            toggleVisibleSubMenus(toolMnuCadastro);
        }

        private void btnExtratoCliente_Click(object sender, EventArgs e)
        {
            ExtratoCreditoCli ecc = new ExtratoCreditoCli();
            ecc.MdiParent = this;
            ecc.Show();
            toggleVisibleSubMenus(mnuRelatorios);
        }
    }
}
