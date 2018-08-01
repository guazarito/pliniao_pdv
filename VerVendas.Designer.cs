namespace WindowsFormsApplication2
{
    partial class frmVerVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerVendas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2formas_pend = new System.Windows.Forms.Label();
            this.lblCreditoUtz = new System.Windows.Forms.Label();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.chkCreditoCli = new System.Windows.Forms.RadioButton();
            this.groupDetalhesEntrega = new System.Windows.Forms.GroupBox();
            this.txtDetalhesEntrega = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoEntrega = new System.Windows.Forms.RadioButton();
            this.rdoBalcao = new System.Windows.Forms.RadioButton();
            this.chkDesconto = new System.Windows.Forms.CheckBox();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHrEntrega = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkPagtoPendente = new System.Windows.Forms.RadioButton();
            this.chkPagseguro = new System.Windows.Forms.RadioButton();
            this.chkCielo = new System.Windows.Forms.RadioButton();
            this.chkDin = new System.Windows.Forms.RadioButton();
            this.txtPrecoTotDesconto = new System.Windows.Forms.TextBox();
            this.lblTotalDesc = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPed = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdItens = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkCredito = new System.Windows.Forms.RadioButton();
            this.chkDebito = new System.Windows.Forms.RadioButton();
            this.chkTicket = new System.Windows.Forms.RadioButton();
            this.lblTpTicket = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupDetalhesEntrega.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(473, 599);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 50);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Fechar";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(56, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 50);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "Cancelar pedido";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.lblTpTicket);
            this.panel1.Controls.Add(this.chkTicket);
            this.panel1.Controls.Add(this.chkCredito);
            this.panel1.Controls.Add(this.chkDebito);
            this.panel1.Controls.Add(this.lbl2formas_pend);
            this.panel1.Controls.Add(this.lblCreditoUtz);
            this.panel1.Controls.Add(this.lblCancelado);
            this.panel1.Controls.Add(this.chkCreditoCli);
            this.panel1.Controls.Add(this.groupDetalhesEntrega);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.chkDesconto);
            this.panel1.Controls.Add(this.txtTelCli);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHrEntrega);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.chkPagtoPendente);
            this.panel1.Controls.Add(this.chkPagseguro);
            this.panel1.Controls.Add(this.chkCielo);
            this.panel1.Controls.Add(this.chkDin);
            this.panel1.Controls.Add(this.txtPrecoTotDesconto);
            this.panel1.Controls.Add(this.lblTotalDesc);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtObs);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdPed);
            this.panel1.Controls.Add(this.txtPrecoTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.grdItens);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 593);
            this.panel1.TabIndex = 18;
            // 
            // lbl2formas_pend
            // 
            this.lbl2formas_pend.AutoSize = true;
            this.lbl2formas_pend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2formas_pend.Location = new System.Drawing.Point(171, 543);
            this.lbl2formas_pend.Name = "lbl2formas_pend";
            this.lbl2formas_pend.Size = new System.Drawing.Size(124, 20);
            this.lbl2formas_pend.TabIndex = 39;
            this.lbl2formas_pend.Text = "bl2formas_pend";
            this.lbl2formas_pend.Visible = false;
            // 
            // lblCreditoUtz
            // 
            this.lblCreditoUtz.AutoSize = true;
            this.lblCreditoUtz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditoUtz.Location = new System.Drawing.Point(171, 517);
            this.lblCreditoUtz.Name = "lblCreditoUtz";
            this.lblCreditoUtz.Size = new System.Drawing.Size(100, 20);
            this.lblCreditoUtz.TabIndex = 50;
            this.lblCreditoUtz.Text = "lblCreditoUtz";
            this.lblCreditoUtz.Visible = false;
            // 
            // lblCancelado
            // 
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelado.ForeColor = System.Drawing.Color.Red;
            this.lblCancelado.Location = new System.Drawing.Point(240, 468);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(127, 24);
            this.lblCancelado.TabIndex = 37;
            this.lblCancelado.Text = "CANCELADO";
            this.lblCancelado.Visible = false;
            // 
            // chkCreditoCli
            // 
            this.chkCreditoCli.AutoSize = true;
            this.chkCreditoCli.Location = new System.Drawing.Point(9, 546);
            this.chkCreditoCli.Name = "chkCreditoCli";
            this.chkCreditoCli.Size = new System.Drawing.Size(93, 17);
            this.chkCreditoCli.TabIndex = 36;
            this.chkCreditoCli.TabStop = true;
            this.chkCreditoCli.Text = "Crédito Cliente";
            this.chkCreditoCli.UseVisualStyleBackColor = true;
            // 
            // groupDetalhesEntrega
            // 
            this.groupDetalhesEntrega.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupDetalhesEntrega.Controls.Add(this.txtDetalhesEntrega);
            this.groupDetalhesEntrega.Location = new System.Drawing.Point(139, 44);
            this.groupDetalhesEntrega.Name = "groupDetalhesEntrega";
            this.groupDetalhesEntrega.Size = new System.Drawing.Size(473, 102);
            this.groupDetalhesEntrega.TabIndex = 35;
            this.groupDetalhesEntrega.TabStop = false;
            this.groupDetalhesEntrega.Text = "Detalhes da entrega";
            // 
            // txtDetalhesEntrega
            // 
            this.txtDetalhesEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhesEntrega.Location = new System.Drawing.Point(6, 20);
            this.txtDetalhesEntrega.Name = "txtDetalhesEntrega";
            this.txtDetalhesEntrega.Size = new System.Drawing.Size(461, 74);
            this.txtDetalhesEntrega.TabIndex = 16;
            this.txtDetalhesEntrega.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.rdoEntrega);
            this.groupBox4.Controls.Add(this.rdoBalcao);
            this.groupBox4.Location = new System.Drawing.Point(12, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(109, 102);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // rdoEntrega
            // 
            this.rdoEntrega.AutoSize = true;
            this.rdoEntrega.Enabled = false;
            this.rdoEntrega.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEntrega.Location = new System.Drawing.Point(9, 63);
            this.rdoEntrega.Name = "rdoEntrega";
            this.rdoEntrega.Size = new System.Drawing.Size(96, 29);
            this.rdoEntrega.TabIndex = 32;
            this.rdoEntrega.Text = "Entrega";
            this.rdoEntrega.UseVisualStyleBackColor = true;
            // 
            // rdoBalcao
            // 
            this.rdoBalcao.AutoSize = true;
            this.rdoBalcao.Enabled = false;
            this.rdoBalcao.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBalcao.Location = new System.Drawing.Point(9, 10);
            this.rdoBalcao.Name = "rdoBalcao";
            this.rdoBalcao.Size = new System.Drawing.Size(88, 29);
            this.rdoBalcao.TabIndex = 31;
            this.rdoBalcao.Text = "Balcao";
            this.rdoBalcao.UseVisualStyleBackColor = true;
            // 
            // chkDesconto
            // 
            this.chkDesconto.AutoSize = true;
            this.chkDesconto.Location = new System.Drawing.Point(467, 468);
            this.chkDesconto.Name = "chkDesconto";
            this.chkDesconto.Size = new System.Drawing.Size(94, 17);
            this.chkDesconto.TabIndex = 23;
            this.chkDesconto.Text = "Com desconto";
            this.chkDesconto.UseVisualStyleBackColor = true;
            this.chkDesconto.Visible = false;
            // 
            // txtTelCli
            // 
            this.txtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCli.Location = new System.Drawing.Point(105, 190);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(189, 22);
            this.txtTelCli.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Telefone:";
            // 
            // txtHrEntrega
            // 
            this.txtHrEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHrEntrega.Location = new System.Drawing.Point(403, 190);
            this.txtHrEntrega.Name = "txtHrEntrega";
            this.txtHrEntrega.Size = new System.Drawing.Size(215, 22);
            this.txtHrEntrega.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Hora entrega:";
            // 
            // chkPagtoPendente
            // 
            this.chkPagtoPendente.AutoSize = true;
            this.chkPagtoPendente.Location = new System.Drawing.Point(9, 525);
            this.chkPagtoPendente.Name = "chkPagtoPendente";
            this.chkPagtoPendente.Size = new System.Drawing.Size(128, 17);
            this.chkPagtoPendente.TabIndex = 22;
            this.chkPagtoPendente.TabStop = true;
            this.chkPagtoPendente.Text = "Pagamento Pendente";
            this.chkPagtoPendente.UseVisualStyleBackColor = true;
            // 
            // chkPagseguro
            // 
            this.chkPagseguro.AutoSize = true;
            this.chkPagseguro.Location = new System.Drawing.Point(9, 462);
            this.chkPagseguro.Name = "chkPagseguro";
            this.chkPagseguro.Size = new System.Drawing.Size(118, 17);
            this.chkPagseguro.TabIndex = 21;
            this.chkPagseguro.TabStop = true;
            this.chkPagseguro.Text = "Cartão [PagSeguro]";
            this.chkPagseguro.UseVisualStyleBackColor = true;
            // 
            // chkCielo
            // 
            this.chkCielo.AutoSize = true;
            this.chkCielo.Location = new System.Drawing.Point(9, 441);
            this.chkCielo.Name = "chkCielo";
            this.chkCielo.Size = new System.Drawing.Size(88, 17);
            this.chkCielo.TabIndex = 20;
            this.chkCielo.TabStop = true;
            this.chkCielo.Text = "Cartão (Cielo)";
            this.chkCielo.UseVisualStyleBackColor = true;
            // 
            // chkDin
            // 
            this.chkDin.AutoSize = true;
            this.chkDin.Location = new System.Drawing.Point(9, 420);
            this.chkDin.Name = "chkDin";
            this.chkDin.Size = new System.Drawing.Size(64, 17);
            this.chkDin.TabIndex = 19;
            this.chkDin.TabStop = true;
            this.chkDin.Text = "Dinheiro";
            this.chkDin.UseVisualStyleBackColor = true;
            // 
            // txtPrecoTotDesconto
            // 
            this.txtPrecoTotDesconto.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecoTotDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotDesconto.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrecoTotDesconto.Location = new System.Drawing.Point(538, 528);
            this.txtPrecoTotDesconto.Name = "txtPrecoTotDesconto";
            this.txtPrecoTotDesconto.ReadOnly = true;
            this.txtPrecoTotDesconto.Size = new System.Drawing.Size(74, 29);
            this.txtPrecoTotDesconto.TabIndex = 14;
            this.txtPrecoTotDesconto.Text = "0,00";
            this.txtPrecoTotDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecoTotDesconto.Visible = false;
            // 
            // lblTotalDesc
            // 
            this.lblTotalDesc.AutoSize = true;
            this.lblTotalDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDesc.Location = new System.Drawing.Point(405, 534);
            this.lblTotalDesc.Name = "lblTotalDesc";
            this.lblTotalDesc.Size = new System.Drawing.Size(127, 20);
            this.lblTotalDesc.TabIndex = 13;
            this.lblTotalDesc.Text = "Total c/ desc. R$";
            this.lblTotalDesc.Visible = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(69, 160);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(551, 22);
            this.txtNome.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Observação:";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(104, 218);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(433, 66);
            this.txtObs.TabIndex = 13;
            this.txtObs.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Número do Pedido";
            // 
            // txtIdPed
            // 
            this.txtIdPed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtIdPed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdPed.Location = new System.Drawing.Point(10, 5);
            this.txtIdPed.Name = "txtIdPed";
            this.txtIdPed.ReadOnly = true;
            this.txtIdPed.Size = new System.Drawing.Size(70, 26);
            this.txtIdPed.TabIndex = 6;
            this.txtIdPed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.BackColor = System.Drawing.SystemColors.Info;
            this.txtPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotal.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtPrecoTotal.Location = new System.Drawing.Point(538, 491);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(74, 29);
            this.txtPrecoTotal.TabIndex = 4;
            this.txtPrecoTotal.Text = "0,00";
            this.txtPrecoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total R$";
            // 
            // grdItens
            // 
            this.grdItens.AllowUserToAddRows = false;
            this.grdItens.AllowUserToDeleteRows = false;
            this.grdItens.AllowUserToOrderColumns = true;
            this.grdItens.AllowUserToResizeRows = false;
            this.grdItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdItens.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdItens.Location = new System.Drawing.Point(10, 293);
            this.grdItens.MultiSelect = false;
            this.grdItens.Name = "grdItens";
            this.grdItens.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdItens.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdItens.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdItens.Size = new System.Drawing.Size(617, 124);
            this.grdItens.TabIndex = 0;
            this.grdItens.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(245, 628);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 22);
            this.button2.TabIndex = 22;
            this.button2.Text = "Imprimir 2ª via Empresa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(245, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 22);
            this.button1.TabIndex = 21;
            this.button1.Text = "Imprimir 2ª via Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(9, 505);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(92, 17);
            this.chkCredito.TabIndex = 52;
            this.chkCredito.TabStop = true;
            this.chkCredito.Text = "Cartão Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Location = new System.Drawing.Point(9, 484);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(90, 17);
            this.chkDebito.TabIndex = 51;
            this.chkDebito.TabStop = true;
            this.chkDebito.Text = "Cartão Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkTicket
            // 
            this.chkTicket.AutoSize = true;
            this.chkTicket.Location = new System.Drawing.Point(9, 569);
            this.chkTicket.Name = "chkTicket";
            this.chkTicket.Size = new System.Drawing.Size(65, 17);
            this.chkTicket.TabIndex = 53;
            this.chkTicket.TabStop = true;
            this.chkTicket.Text = "Voucher";
            this.chkTicket.UseVisualStyleBackColor = true;
            // 
            // lblTpTicket
            // 
            this.lblTpTicket.AutoSize = true;
            this.lblTpTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTpTicket.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTpTicket.Location = new System.Drawing.Point(76, 568);
            this.lblTpTicket.Name = "lblTpTicket";
            this.lblTpTicket.Size = new System.Drawing.Size(90, 18);
            this.lblTpTicket.TabIndex = 54;
            this.lblTpTicket.Text = "lblTpTicket";
            this.lblTpTicket.Visible = false;
            // 
            // frmVerVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 661);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.Name = "frmVerVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pedido";
            this.Load += new System.EventHandler(this.load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupDetalhesEntrega.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPrecoTotDesconto;
        private System.Windows.Forms.Label lblTotalDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPed;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdItens;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton chkPagtoPendente;
        private System.Windows.Forms.RadioButton chkPagseguro;
        private System.Windows.Forms.RadioButton chkCielo;
        private System.Windows.Forms.RadioButton chkDin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtObs;
        private System.Windows.Forms.TextBox txtTelCli;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHrEntrega;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkDesconto;
        private System.Windows.Forms.GroupBox groupDetalhesEntrega;
        private System.Windows.Forms.RichTextBox txtDetalhesEntrega;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoEntrega;
        private System.Windows.Forms.RadioButton rdoBalcao;
        private System.Windows.Forms.RadioButton chkCreditoCli;
        private System.Windows.Forms.Label lblCancelado;
        private System.Windows.Forms.Label lblCreditoUtz;
        private System.Windows.Forms.Label lbl2formas_pend;
        private System.Windows.Forms.RadioButton chkTicket;
        private System.Windows.Forms.RadioButton chkCredito;
        private System.Windows.Forms.RadioButton chkDebito;
        private System.Windows.Forms.Label lblTpTicket;
    }
}