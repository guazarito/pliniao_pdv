namespace WindowsFormsApplication2
{
    partial class frmCreditoCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditoCli));
            this.txtNomeCli = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTotalPeriodoDado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdHistoricoCreditoDado = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTotalPeriodoUsado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdHistoricoCreditosUsados = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.qttVias = new System.Windows.Forms.NumericUpDown();
            this.chkImprimir = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAddCredito = new System.Windows.Forms.Button();
            this.txtValorDado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimpaFiltro = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.chkCredito = new System.Windows.Forms.RadioButton();
            this.chkDebito = new System.Windows.Forms.RadioButton();
            this.chkDin = new System.Windows.Forms.RadioButton();
            this.chkDebito_ = new System.Windows.Forms.RadioButton();
            this.cboTickets = new System.Windows.Forms.ComboBox();
            this.chkTickets = new System.Windows.Forms.RadioButton();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditoDado)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditosUsados)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qttVias)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeCli
            // 
            this.txtNomeCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtNomeCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.FormattingEnabled = true;
            this.txtNomeCli.Location = new System.Drawing.Point(100, 30);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(515, 23);
            this.txtNomeCli.TabIndex = 14;
            this.txtNomeCli.SelectedIndexChanged += new System.EventHandler(this.txtNomeCli_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cliente:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(34, 274);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 288);
            this.tabControl1.TabIndex = 15;
            this.tabControl1.Visible = false;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Silver;
            this.tabPage2.Controls.Add(this.txtTotalPeriodoDado);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.grdHistoricoCreditoDado);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(578, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico créditos dados";
            // 
            // txtTotalPeriodoDado
            // 
            this.txtTotalPeriodoDado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalPeriodoDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeriodoDado.Location = new System.Drawing.Point(447, 223);
            this.txtTotalPeriodoDado.Name = "txtTotalPeriodoDado";
            this.txtTotalPeriodoDado.Size = new System.Drawing.Size(114, 29);
            this.txtTotalPeriodoDado.TabIndex = 17;
            this.txtTotalPeriodoDado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Total créditos adicionados no período:    R$";
            // 
            // grdHistoricoCreditoDado
            // 
            this.grdHistoricoCreditoDado.AllowUserToAddRows = false;
            this.grdHistoricoCreditoDado.AllowUserToDeleteRows = false;
            this.grdHistoricoCreditoDado.AllowUserToResizeColumns = false;
            this.grdHistoricoCreditoDado.AllowUserToResizeRows = false;
            this.grdHistoricoCreditoDado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistoricoCreditoDado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistoricoCreditoDado.Location = new System.Drawing.Point(2, 3);
            this.grdHistoricoCreditoDado.MultiSelect = false;
            this.grdHistoricoCreditoDado.Name = "grdHistoricoCreditoDado";
            this.grdHistoricoCreditoDado.ReadOnly = true;
            this.grdHistoricoCreditoDado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHistoricoCreditoDado.Size = new System.Drawing.Size(573, 214);
            this.grdHistoricoCreditoDado.TabIndex = 0;
            this.grdHistoricoCreditoDado.MouseClick += new System.Windows.Forms.MouseEventHandler(this.grdHistoricoCreditoDado_MouseClick);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.txtTotalPeriodoUsado);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.grdHistoricoCreditosUsados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(578, 262);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Histórico créditos usados";
            // 
            // txtTotalPeriodoUsado
            // 
            this.txtTotalPeriodoUsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalPeriodoUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeriodoUsado.Location = new System.Drawing.Point(452, 226);
            this.txtTotalPeriodoUsado.Name = "txtTotalPeriodoUsado";
            this.txtTotalPeriodoUsado.Size = new System.Drawing.Size(114, 29);
            this.txtTotalPeriodoUsado.TabIndex = 19;
            this.txtTotalPeriodoUsado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(208, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total créditos usados no período:    R$";
            // 
            // grdHistoricoCreditosUsados
            // 
            this.grdHistoricoCreditosUsados.AllowUserToAddRows = false;
            this.grdHistoricoCreditosUsados.AllowUserToDeleteRows = false;
            this.grdHistoricoCreditosUsados.AllowUserToResizeColumns = false;
            this.grdHistoricoCreditosUsados.AllowUserToResizeRows = false;
            this.grdHistoricoCreditosUsados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHistoricoCreditosUsados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHistoricoCreditosUsados.Location = new System.Drawing.Point(0, 0);
            this.grdHistoricoCreditosUsados.MultiSelect = false;
            this.grdHistoricoCreditosUsados.Name = "grdHistoricoCreditosUsados";
            this.grdHistoricoCreditosUsados.ReadOnly = true;
            this.grdHistoricoCreditosUsados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdHistoricoCreditosUsados.Size = new System.Drawing.Size(578, 220);
            this.grdHistoricoCreditosUsados.TabIndex = 1;
            this.grdHistoricoCreditosUsados.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.abrePedido);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.qttVias);
            this.groupBox1.Controls.Add(this.chkImprimir);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnAddCredito);
            this.groupBox1.Controls.Add(this.txtValorDado);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 136);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dar crédito ao cliente";
            this.groupBox1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(178, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "via(s)";
            // 
            // qttVias
            // 
            this.qttVias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qttVias.Location = new System.Drawing.Point(137, 104);
            this.qttVias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.qttVias.Name = "qttVias";
            this.qttVias.Size = new System.Drawing.Size(36, 24);
            this.qttVias.TabIndex = 19;
            this.qttVias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkImprimir
            // 
            this.chkImprimir.AutoSize = true;
            this.chkImprimir.Checked = true;
            this.chkImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkImprimir.Location = new System.Drawing.Point(10, 107);
            this.chkImprimir.Name = "chkImprimir";
            this.chkImprimir.Size = new System.Drawing.Size(115, 20);
            this.chkImprimir.TabIndex = 18;
            this.chkImprimir.Text = "Imprimir recibo";
            this.chkImprimir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(6, 71);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 26);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAddCredito
            // 
            this.btnAddCredito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCredito.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCredito.Image")));
            this.btnAddCredito.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCredito.Location = new System.Drawing.Point(109, 70);
            this.btnAddCredito.Name = "btnAddCredito";
            this.btnAddCredito.Size = new System.Drawing.Size(107, 27);
            this.btnAddCredito.TabIndex = 17;
            this.btnAddCredito.Text = "Adicionar";
            this.btnAddCredito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCredito.UseVisualStyleBackColor = true;
            this.btnAddCredito.Click += new System.EventHandler(this.btnAddCredito_Click);
            // 
            // txtValorDado
            // 
            this.txtValorDado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtValorDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDado.Location = new System.Drawing.Point(83, 29);
            this.txtValorDado.Name = "txtValorDado";
            this.txtValorDado.Size = new System.Drawing.Size(133, 29);
            this.txtValorDado.TabIndex = 15;
            this.txtValorDado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor:    R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Inicial";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(133, 41);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(108, 20);
            this.dtFim.TabIndex = 18;
            // 
            // dtIni
            // 
            this.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIni.Location = new System.Drawing.Point(9, 41);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(108, 20);
            this.dtIni.TabIndex = 17;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrar.Image")));
            this.btnFiltrar.Location = new System.Drawing.Point(268, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(21, 31);
            this.btnFiltrar.TabIndex = 21;
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnFiltrar, "Filtrar");
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpaFiltro);
            this.groupBox2.Controls.Add(this.btnFiltrar);
            this.groupBox2.Controls.Add(this.dtIni);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dtFim);
            this.groupBox2.Location = new System.Drawing.Point(313, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 126);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            this.groupBox2.Visible = false;
            // 
            // btnLimpaFiltro
            // 
            this.btnLimpaFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpaFiltro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpaFiltro.Location = new System.Drawing.Point(9, 72);
            this.btnLimpaFiltro.Name = "btnLimpaFiltro";
            this.btnLimpaFiltro.Size = new System.Drawing.Size(90, 26);
            this.btnLimpaFiltro.TabIndex = 22;
            this.btnLimpaFiltro.Text = "Limpar Filtro";
            this.btnLimpaFiltro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpaFiltro.UseVisualStyleBackColor = true;
            this.btnLimpaFiltro.Click += new System.EventHandler(this.btnLimpaFiltro_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(297, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 54);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(193, 14);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(109, 29);
            this.txtSaldo.TabIndex = 26;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "SALDO ATUAL: R$";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(648, 25);
            this.toolStrip1.TabIndex = 24;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Atualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(35, 251);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(92, 17);
            this.chkCredito.TabIndex = 55;
            this.chkCredito.TabStop = true;
            this.chkCredito.Text = "Cartão Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            this.chkCredito.Visible = false;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Location = new System.Drawing.Point(35, -65);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(90, 17);
            this.chkDebito.TabIndex = 54;
            this.chkDebito.TabStop = true;
            this.chkDebito.Text = "Cartão Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkDin
            // 
            this.chkDin.AutoSize = true;
            this.chkDin.Location = new System.Drawing.Point(35, 207);
            this.chkDin.Name = "chkDin";
            this.chkDin.Size = new System.Drawing.Size(64, 17);
            this.chkDin.TabIndex = 53;
            this.chkDin.TabStop = true;
            this.chkDin.Text = "Dinheiro";
            this.chkDin.UseVisualStyleBackColor = true;
            this.chkDin.Visible = false;
            // 
            // chkDebito_
            // 
            this.chkDebito_.AutoSize = true;
            this.chkDebito_.Location = new System.Drawing.Point(35, 229);
            this.chkDebito_.Name = "chkDebito_";
            this.chkDebito_.Size = new System.Drawing.Size(90, 17);
            this.chkDebito_.TabIndex = 56;
            this.chkDebito_.TabStop = true;
            this.chkDebito_.Text = "Cartão Débito";
            this.chkDebito_.UseVisualStyleBackColor = true;
            this.chkDebito_.Visible = false;
            // 
            // cboTickets
            // 
            this.cboTickets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cboTickets.Enabled = false;
            this.cboTickets.FormattingEnabled = true;
            this.cboTickets.Location = new System.Drawing.Point(173, 209);
            this.cboTickets.Name = "cboTickets";
            this.cboTickets.Size = new System.Drawing.Size(121, 21);
            this.cboTickets.TabIndex = 58;
            this.cboTickets.Text = "Ticket";
            this.cboTickets.Visible = false;
            // 
            // chkTickets
            // 
            this.chkTickets.AutoSize = true;
            this.chkTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTickets.Location = new System.Drawing.Point(148, 211);
            this.chkTickets.Name = "chkTickets";
            this.chkTickets.Size = new System.Drawing.Size(14, 13);
            this.chkTickets.TabIndex = 57;
            this.chkTickets.TabStop = true;
            this.chkTickets.UseVisualStyleBackColor = true;
            this.chkTickets.Visible = false;
            this.chkTickets.CheckedChanged += new System.EventHandler(this.chkTickets_CheckedChanged);
            // 
            // btnDelItem
            // 
            this.btnDelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDelItem.Image")));
            this.btnDelItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelItem.Location = new System.Drawing.Point(460, 256);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(156, 34);
            this.btnDelItem.TabIndex = 59;
            this.btnDelItem.Text = "Deletar Item";
            this.btnDelItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelItem.UseVisualStyleBackColor = true;
            this.btnDelItem.Click += new System.EventHandler(this.btnDelItem_Click);
            // 
            // frmCreditoCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 569);
            this.Controls.Add(this.btnDelItem);
            this.Controls.Add(this.cboTickets);
            this.Controls.Add(this.chkTickets);
            this.Controls.Add(this.chkDebito_);
            this.Controls.Add(this.chkCredito);
            this.Controls.Add(this.chkDebito);
            this.Controls.Add(this.chkDin);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtNomeCli);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "frmCreditoCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crédito Clientes";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditoDado)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditosUsados)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qttVias)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtNomeCli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtValorDado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCredito;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView grdHistoricoCreditoDado;
        private System.Windows.Forms.DataGridView grdHistoricoCreditosUsados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtTotalPeriodoDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalPeriodoUsado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpaFiltro;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.RadioButton chkCredito;
        private System.Windows.Forms.RadioButton chkDebito;
        private System.Windows.Forms.RadioButton chkDin;
        private System.Windows.Forms.RadioButton chkDebito_;
        private System.Windows.Forms.ComboBox cboTickets;
        private System.Windows.Forms.RadioButton chkTickets;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.CheckBox chkImprimir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown qttVias;
    }
}