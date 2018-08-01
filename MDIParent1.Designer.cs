namespace WindowsFormsApplication2
{
    partial class MDIParent1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnVenda = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnShowCreditos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFinancas = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnRels = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.impressoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusImpressoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurarPortaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaImpressãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aaaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolMnuCadastro = new System.Windows.Forms.ToolStripContainer();
            this.btnTpTickets = new System.Windows.Forms.Button();
            this.btnCadCli = new System.Windows.Forms.Button();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripContainer();
            this.btnExtratoCliente = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRelPagtosPendentes = new System.Windows.Forms.Button();
            this.btnRelVendas = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolMnuCadastro.ContentPanel.SuspendLayout();
            this.toolMnuCadastro.SuspendLayout();
            this.mnuRelatorios.ContentPanel.SuspendLayout();
            this.mnuRelatorios.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 517);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(698, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // btnVenda
            // 
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.Image = ((System.Drawing.Image)(resources.GetObject("btnVenda.Image")));
            this.btnVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVenda.Location = new System.Drawing.Point(5, 3);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(118, 50);
            this.btnVenda.TabIndex = 4;
            this.btnVenda.Text = " Venda";
            this.btnVenda.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnVenda.UseVisualStyleBackColor = true;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnShowCreditos);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnFinancas);
            this.panel1.Controls.Add(this.btnCadastro);
            this.panel1.Controls.Add(this.btnRels);
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.btnVenda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(128, 493);
            this.panel1.TabIndex = 6;
            // 
            // btnShowCreditos
            // 
            this.btnShowCreditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCreditos.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCreditos.Image")));
            this.btnShowCreditos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowCreditos.Location = new System.Drawing.Point(5, 279);
            this.btnShowCreditos.Name = "btnShowCreditos";
            this.btnShowCreditos.Size = new System.Drawing.Size(118, 49);
            this.btnShowCreditos.TabIndex = 13;
            this.btnShowCreditos.Text = "Crédito Clientes";
            this.btnShowCreditos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnShowCreditos.UseVisualStyleBackColor = true;
            this.btnShowCreditos.Click += new System.EventHandler(this.btnShowCreditos_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(5, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 49);
            this.button1.TabIndex = 12;
            this.button1.Text = "Agenda";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFinancas
            // 
            this.btnFinancas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinancas.Image = ((System.Drawing.Image)(resources.GetObject("btnFinancas.Image")));
            this.btnFinancas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinancas.Location = new System.Drawing.Point(5, 169);
            this.btnFinancas.Name = "btnFinancas";
            this.btnFinancas.Size = new System.Drawing.Size(118, 49);
            this.btnFinancas.TabIndex = 11;
            this.btnFinancas.Text = "Finanças";
            this.btnFinancas.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFinancas.UseVisualStyleBackColor = true;
            this.btnFinancas.Click += new System.EventHandler(this.btnFinancas_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastro.Image")));
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.Location = new System.Drawing.Point(5, 114);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(118, 49);
            this.btnCadastro.TabIndex = 10;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnRels
            // 
            this.btnRels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRels.Image = ((System.Drawing.Image)(resources.GetObject("btnRels.Image")));
            this.btnRels.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRels.Location = new System.Drawing.Point(5, 337);
            this.btnRels.Name = "btnRels";
            this.btnRels.Size = new System.Drawing.Size(118, 49);
            this.btnRels.TabIndex = 9;
            this.btnRels.Text = "Relatórios";
            this.btnRels.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRels.UseVisualStyleBackColor = true;
            this.btnRels.Click += new System.EventHandler(this.btnRels_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnConsulta.Image")));
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsulta.Location = new System.Drawing.Point(5, 59);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(118, 49);
            this.btnConsulta.TabIndex = 8;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressoraToolStripMenuItem,
            this.configuraçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // impressoraToolStripMenuItem
            // 
            this.impressoraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusImpressoraToolStripMenuItem,
            this.configurarPortaToolStripMenuItem,
            this.filaImpressãoToolStripMenuItem});
            this.impressoraToolStripMenuItem.Name = "impressoraToolStripMenuItem";
            this.impressoraToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.impressoraToolStripMenuItem.Text = "Impressora";
            // 
            // statusImpressoraToolStripMenuItem
            // 
            this.statusImpressoraToolStripMenuItem.Name = "statusImpressoraToolStripMenuItem";
            this.statusImpressoraToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.statusImpressoraToolStripMenuItem.Text = "Status Impressora";
            this.statusImpressoraToolStripMenuItem.Click += new System.EventHandler(this.statusImpressoraToolStripMenuItem_Click);
            // 
            // configurarPortaToolStripMenuItem
            // 
            this.configurarPortaToolStripMenuItem.Name = "configurarPortaToolStripMenuItem";
            this.configurarPortaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.configurarPortaToolStripMenuItem.Text = "Configurar porta";
            this.configurarPortaToolStripMenuItem.Click += new System.EventHandler(this.configurarPortaToolStripMenuItem_Click);
            // 
            // filaImpressãoToolStripMenuItem
            // 
            this.filaImpressãoToolStripMenuItem.Name = "filaImpressãoToolStripMenuItem";
            this.filaImpressãoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.filaImpressãoToolStripMenuItem.Text = "Fila Impressão";
            this.filaImpressãoToolStripMenuItem.Click += new System.EventHandler(this.filaImpressãoToolStripMenuItem_Click);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferênciasToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // preferênciasToolStripMenuItem
            // 
            this.preferênciasToolStripMenuItem.Name = "preferênciasToolStripMenuItem";
            this.preferênciasToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.preferênciasToolStripMenuItem.Text = "Preferências";
            this.preferênciasToolStripMenuItem.Click += new System.EventHandler(this.preferênciasToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aaaaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // aaaaToolStripMenuItem
            // 
            this.aaaaToolStripMenuItem.Name = "aaaaToolStripMenuItem";
            this.aaaaToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.aaaaToolStripMenuItem.Text = "aaaa";
            // 
            // toolMnuCadastro
            // 
            // 
            // toolMnuCadastro.ContentPanel
            // 
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnTpTickets);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadCli);
            this.toolMnuCadastro.ContentPanel.Controls.Add(this.btnCadProd);
            this.toolMnuCadastro.ContentPanel.Size = new System.Drawing.Size(108, 99);
            this.toolMnuCadastro.Location = new System.Drawing.Point(130, 139);
            this.toolMnuCadastro.Name = "toolMnuCadastro";
            this.toolMnuCadastro.Size = new System.Drawing.Size(108, 124);
            this.toolMnuCadastro.TabIndex = 10;
            this.toolMnuCadastro.Text = "toolStripContainer1";
            this.toolMnuCadastro.Visible = false;
            // 
            // btnTpTickets
            // 
            this.btnTpTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTpTickets.Location = new System.Drawing.Point(1, 66);
            this.btnTpTickets.Name = "btnTpTickets";
            this.btnTpTickets.Size = new System.Drawing.Size(107, 30);
            this.btnTpTickets.TabIndex = 2;
            this.btnTpTickets.Text = "Tipo de TIcket";
            this.btnTpTickets.UseVisualStyleBackColor = true;
            this.btnTpTickets.Click += new System.EventHandler(this.btnTpTickets_Click);
            // 
            // btnCadCli
            // 
            this.btnCadCli.Image = ((System.Drawing.Image)(resources.GetObject("btnCadCli.Image")));
            this.btnCadCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadCli.Location = new System.Drawing.Point(1, 33);
            this.btnCadCli.Name = "btnCadCli";
            this.btnCadCli.Size = new System.Drawing.Size(107, 30);
            this.btnCadCli.TabIndex = 1;
            this.btnCadCli.Text = "Clientes";
            this.btnCadCli.UseVisualStyleBackColor = true;
            this.btnCadCli.Click += new System.EventHandler(this.btnCadCli_Click);
            // 
            // btnCadProd
            // 
            this.btnCadProd.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProd.Image")));
            this.btnCadProd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadProd.Location = new System.Drawing.Point(1, 3);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(107, 30);
            this.btnCadProd.TabIndex = 0;
            this.btnCadProd.Text = "Produtos";
            this.btnCadProd.UseVisualStyleBackColor = true;
            this.btnCadProd.Click += new System.EventHandler(this.btnCadProd_Click);
            // 
            // mnuRelatorios
            // 
            // 
            // mnuRelatorios.ContentPanel
            // 
            this.mnuRelatorios.ContentPanel.Controls.Add(this.btnExtratoCliente);
            this.mnuRelatorios.ContentPanel.Controls.Add(this.button2);
            this.mnuRelatorios.ContentPanel.Controls.Add(this.btnRelPagtosPendentes);
            this.mnuRelatorios.ContentPanel.Controls.Add(this.btnRelVendas);
            this.mnuRelatorios.ContentPanel.Size = new System.Drawing.Size(161, 103);
            this.mnuRelatorios.Location = new System.Drawing.Point(130, 362);
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(161, 128);
            this.mnuRelatorios.TabIndex = 12;
            this.mnuRelatorios.Text = "toolStripContainer1";
            this.mnuRelatorios.Visible = false;
            // 
            // btnExtratoCliente
            // 
            this.btnExtratoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExtratoCliente.Location = new System.Drawing.Point(3, 96);
            this.btnExtratoCliente.Name = "btnExtratoCliente";
            this.btnExtratoCliente.Size = new System.Drawing.Size(155, 27);
            this.btnExtratoCliente.TabIndex = 3;
            this.btnExtratoCliente.Text = "Extrato créditos clientes";
            this.btnExtratoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtratoCliente.UseVisualStyleBackColor = true;
            this.btnExtratoCliente.Click += new System.EventHandler(this.btnExtratoCliente_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(3, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Faturamento Mensal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRelPagtosPendentes
            // 
            this.btnRelPagtosPendentes.Image = ((System.Drawing.Image)(resources.GetObject("btnRelPagtosPendentes.Image")));
            this.btnRelPagtosPendentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelPagtosPendentes.Location = new System.Drawing.Point(3, 31);
            this.btnRelPagtosPendentes.Name = "btnRelPagtosPendentes";
            this.btnRelPagtosPendentes.Size = new System.Drawing.Size(155, 27);
            this.btnRelPagtosPendentes.TabIndex = 1;
            this.btnRelPagtosPendentes.Text = "Pagamentos Pendentes";
            this.btnRelPagtosPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelPagtosPendentes.UseVisualStyleBackColor = true;
            this.btnRelPagtosPendentes.Click += new System.EventHandler(this.btnRelPagtosPendentes_Click);
            // 
            // btnRelVendas
            // 
            this.btnRelVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnRelVendas.Image")));
            this.btnRelVendas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRelVendas.Location = new System.Drawing.Point(3, 4);
            this.btnRelVendas.Name = "btnRelVendas";
            this.btnRelVendas.Size = new System.Drawing.Size(155, 27);
            this.btnRelVendas.TabIndex = 0;
            this.btnRelVendas.Text = "Vendas por Período";
            this.btnRelVendas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelVendas.UseVisualStyleBackColor = true;
            this.btnRelVendas.Click += new System.EventHandler(this.btnRelVendas_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(698, 539);
            this.Controls.Add(this.mnuRelatorios);
            this.Controls.Add(this.toolMnuCadastro);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIParent1";
            this.Text = "PDV Mamitaria Plinião";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_closed);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolMnuCadastro.ContentPanel.ResumeLayout(false);
            this.toolMnuCadastro.ResumeLayout(false);
            this.toolMnuCadastro.PerformLayout();
            this.mnuRelatorios.ContentPanel.ResumeLayout(false);
            this.mnuRelatorios.ResumeLayout(false);
            this.mnuRelatorios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnRels;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem impressoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusImpressoraToolStripMenuItem;
        private System.Windows.Forms.Button btnFinancas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aaaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripContainer toolMnuCadastro;
        private System.Windows.Forms.Button btnCadCli;
        private System.Windows.Forms.Button btnCadProd;
        private System.Windows.Forms.ToolStripContainer mnuRelatorios;
        private System.Windows.Forms.Button btnRelVendas;
        private System.Windows.Forms.Button btnRelPagtosPendentes;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem configurarPortaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaImpressãoToolStripMenuItem;
        private System.Windows.Forms.Button btnShowCreditos;
        private System.Windows.Forms.Button btnTpTickets;
        private System.Windows.Forms.Button btnExtratoCliente;
    }
}



