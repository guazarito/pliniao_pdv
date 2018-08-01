namespace WindowsFormsApplication2
{
    partial class frmRel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRel));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.stNumpeds = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabRelatorio = new System.Windows.Forms.TabPage();
            this.txtTotalCaixa = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grdResumoPgtos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalPeriodo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPendentePagto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrecoDesc2 = new System.Windows.Forms.Label();
            this.lblPrecoDesc = new System.Windows.Forms.Label();
            this.txtPrecoTotalDEsc = new System.Windows.Forms.TextBox();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdRelResumo = new System.Windows.Forms.DataGridView();
            this.grdRel = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoMes = new System.Windows.Forms.RadioButton();
            this.rdoSemana = new System.Windows.Forms.RadioButton();
            this.rdoHoje = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.tabRels = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.stNumpeds.SuspendLayout();
            this.tabRelatorio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoPgtos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelResumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRel)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabRels.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // stNumpeds
            // 
            this.stNumpeds.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stNumpeds.Location = new System.Drawing.Point(0, 733);
            this.stNumpeds.Name = "stNumpeds";
            this.stNumpeds.Size = new System.Drawing.Size(865, 22);
            this.stNumpeds.TabIndex = 21;
            this.stNumpeds.Tag = "";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // tabRelatorio
            // 
            this.tabRelatorio.Controls.Add(this.txtTotalCaixa);
            this.tabRelatorio.Controls.Add(this.label12);
            this.tabRelatorio.Controls.Add(this.label13);
            this.tabRelatorio.Controls.Add(this.grdResumoPgtos);
            this.tabRelatorio.Controls.Add(this.label11);
            this.tabRelatorio.Controls.Add(this.txtTotalPeriodo);
            this.tabRelatorio.Controls.Add(this.label9);
            this.tabRelatorio.Controls.Add(this.label10);
            this.tabRelatorio.Controls.Add(this.txtTotalPendentePagto);
            this.tabRelatorio.Controls.Add(this.label7);
            this.tabRelatorio.Controls.Add(this.label8);
            this.tabRelatorio.Controls.Add(this.lblPrecoDesc2);
            this.tabRelatorio.Controls.Add(this.lblPrecoDesc);
            this.tabRelatorio.Controls.Add(this.txtPrecoTotalDEsc);
            this.tabRelatorio.Controls.Add(this.txtPrecoTotal);
            this.tabRelatorio.Controls.Add(this.button3);
            this.tabRelatorio.Controls.Add(this.button2);
            this.tabRelatorio.Controls.Add(this.label4);
            this.tabRelatorio.Controls.Add(this.label3);
            this.tabRelatorio.Controls.Add(this.label2);
            this.tabRelatorio.Controls.Add(this.grdRelResumo);
            this.tabRelatorio.Controls.Add(this.grdRel);
            this.tabRelatorio.Controls.Add(this.panel1);
            this.tabRelatorio.Location = new System.Drawing.Point(4, 22);
            this.tabRelatorio.Name = "tabRelatorio";
            this.tabRelatorio.Padding = new System.Windows.Forms.Padding(3);
            this.tabRelatorio.Size = new System.Drawing.Size(856, 704);
            this.tabRelatorio.TabIndex = 0;
            this.tabRelatorio.Text = "Relatório";
            this.tabRelatorio.UseVisualStyleBackColor = true;
            // 
            // txtTotalCaixa
            // 
            this.txtTotalCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtTotalCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCaixa.Location = new System.Drawing.Point(716, 634);
            this.txtTotalCaixa.Name = "txtTotalCaixa";
            this.txtTotalCaixa.ReadOnly = true;
            this.txtTotalCaixa.Size = new System.Drawing.Size(97, 29);
            this.txtTotalCaixa.TabIndex = 41;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(678, 614);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Total no caixa no período";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(683, 641);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(27, 18);
            this.label13.TabIndex = 42;
            this.label13.Text = "R$";
            // 
            // grdResumoPgtos
            // 
            this.grdResumoPgtos.AllowUserToAddRows = false;
            this.grdResumoPgtos.AllowUserToDeleteRows = false;
            this.grdResumoPgtos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdResumoPgtos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdResumoPgtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdResumoPgtos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdResumoPgtos.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdResumoPgtos.Location = new System.Drawing.Point(441, 30);
            this.grdResumoPgtos.Name = "grdResumoPgtos";
            this.grdResumoPgtos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdResumoPgtos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdResumoPgtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdResumoPgtos.Size = new System.Drawing.Size(397, 136);
            this.grdResumoPgtos.TabIndex = 40;
            this.grdResumoPgtos.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Forma Pagamento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(438, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Resumo Pagamentos:";
            // 
            // txtTotalPeriodo
            // 
            this.txtTotalPeriodo.BackColor = System.Drawing.Color.White;
            this.txtTotalPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeriodo.Location = new System.Drawing.Point(536, 634);
            this.txtTotalPeriodo.Name = "txtTotalPeriodo";
            this.txtTotalPeriodo.ReadOnly = true;
            this.txtTotalPeriodo.Size = new System.Drawing.Size(97, 29);
            this.txtTotalPeriodo.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(503, 615);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Total vendas no período";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(503, 641);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 18);
            this.label10.TabIndex = 37;
            this.label10.Text = "R$";
            // 
            // txtTotalPendentePagto
            // 
            this.txtTotalPendentePagto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtTotalPendentePagto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPendentePagto.Location = new System.Drawing.Point(528, 534);
            this.txtTotalPendentePagto.Name = "txtTotalPendentePagto";
            this.txtTotalPendentePagto.ReadOnly = true;
            this.txtTotalPendentePagto.Size = new System.Drawing.Size(97, 29);
            this.txtTotalPendentePagto.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 512);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Total pendente pagto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "R$";
            // 
            // lblPrecoDesc2
            // 
            this.lblPrecoDesc2.AutoSize = true;
            this.lblPrecoDesc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoDesc2.Location = new System.Drawing.Point(493, 445);
            this.lblPrecoDesc2.Name = "lblPrecoDesc2";
            this.lblPrecoDesc2.Size = new System.Drawing.Size(132, 16);
            this.lblPrecoDesc2.TabIndex = 32;
            this.lblPrecoDesc2.Text = "Total com Desconto:";
            this.lblPrecoDesc2.Visible = false;
            // 
            // lblPrecoDesc
            // 
            this.lblPrecoDesc.AutoSize = true;
            this.lblPrecoDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoDesc.Location = new System.Drawing.Point(495, 471);
            this.lblPrecoDesc.Name = "lblPrecoDesc";
            this.lblPrecoDesc.Size = new System.Drawing.Size(27, 18);
            this.lblPrecoDesc.TabIndex = 31;
            this.lblPrecoDesc.Text = "R$";
            this.lblPrecoDesc.Visible = false;
            // 
            // txtPrecoTotalDEsc
            // 
            this.txtPrecoTotalDEsc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPrecoTotalDEsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalDEsc.Location = new System.Drawing.Point(528, 466);
            this.txtPrecoTotalDEsc.Name = "txtPrecoTotalDEsc";
            this.txtPrecoTotalDEsc.ReadOnly = true;
            this.txtPrecoTotalDEsc.Size = new System.Drawing.Size(97, 29);
            this.txtPrecoTotalDEsc.TabIndex = 30;
            this.txtPrecoTotalDEsc.Visible = false;
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtPrecoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotal.Location = new System.Drawing.Point(528, 399);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(97, 29);
            this.txtPrecoTotal.TabIndex = 24;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 33);
            this.button2.TabIndex = 28;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Resumo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "R$";
            // 
            // grdRelResumo
            // 
            this.grdRelResumo.AllowUserToAddRows = false;
            this.grdRelResumo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRelResumo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdRelResumo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRelResumo.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdRelResumo.Location = new System.Drawing.Point(10, 384);
            this.grdRelResumo.Name = "grdRelResumo";
            this.grdRelResumo.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRelResumo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdRelResumo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdRelResumo.Size = new System.Drawing.Size(463, 111);
            this.grdRelResumo.TabIndex = 23;
            // 
            // grdRel
            // 
            this.grdRel.AllowUserToAddRows = false;
            this.grdRel.AllowUserToDeleteRows = false;
            this.grdRel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdRel.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdRel.Location = new System.Drawing.Point(7, 172);
            this.grdRel.Name = "grdRel";
            this.grdRel.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdRel.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdRel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdRel.Size = new System.Drawing.Size(831, 183);
            this.grdRel.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(7, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(425, 161);
            this.panel1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filtros:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoMes);
            this.groupBox3.Controls.Add(this.rdoSemana);
            this.groupBox3.Controls.Add(this.rdoHoje);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtFim);
            this.groupBox3.Controls.Add(this.dtIni);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 128);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // rdoMes
            // 
            this.rdoMes.AutoSize = true;
            this.rdoMes.Location = new System.Drawing.Point(9, 88);
            this.rdoMes.Name = "rdoMes";
            this.rdoMes.Size = new System.Drawing.Size(52, 20);
            this.rdoMes.TabIndex = 7;
            this.rdoMes.Text = "Mês";
            this.rdoMes.UseVisualStyleBackColor = true;
            // 
            // rdoSemana
            // 
            this.rdoSemana.AutoSize = true;
            this.rdoSemana.Location = new System.Drawing.Point(9, 62);
            this.rdoSemana.Name = "rdoSemana";
            this.rdoSemana.Size = new System.Drawing.Size(77, 20);
            this.rdoSemana.TabIndex = 6;
            this.rdoSemana.Text = "Semana";
            this.rdoSemana.UseVisualStyleBackColor = true;
            // 
            // rdoHoje
            // 
            this.rdoHoje.AutoSize = true;
            this.rdoHoje.Checked = true;
            this.rdoHoje.Location = new System.Drawing.Point(9, 36);
            this.rdoHoje.Name = "rdoHoje";
            this.rdoHoje.Size = new System.Drawing.Size(55, 20);
            this.rdoHoje.TabIndex = 5;
            this.rdoHoje.TabStop = true;
            this.rdoHoje.Text = "Hoje";
            this.rdoHoje.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Inicial";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(124, 91);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(108, 22);
            this.dtFim.TabIndex = 2;
            // 
            // dtIni
            // 
            this.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIni.Location = new System.Drawing.Point(124, 40);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(108, 22);
            this.dtIni.TabIndex = 1;
            // 
            // tabRels
            // 
            this.tabRels.Controls.Add(this.tabRelatorio);
            this.tabRels.Location = new System.Drawing.Point(1, 0);
            this.tabRels.Name = "tabRels";
            this.tabRels.SelectedIndex = 0;
            this.tabRels.Size = new System.Drawing.Size(864, 730);
            this.tabRels.TabIndex = 22;
            this.tabRels.SelectedIndexChanged += new System.EventHandler(this.tabRels_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(78, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 33);
            this.button3.TabIndex = 29;
            this.button3.Text = "Exportar Excel";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(267, 80);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 35);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Gerar Relatório";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmRel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 755);
            this.Controls.Add(this.stNumpeds);
            this.Controls.Add(this.tabRels);
            this.Name = "frmRel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Vendas por Período";
            this.stNumpeds.ResumeLayout(false);
            this.stNumpeds.PerformLayout();
            this.tabRelatorio.ResumeLayout(false);
            this.tabRelatorio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoPgtos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRelResumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRel)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabRels.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.StatusStrip stNumpeds;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabPage tabRelatorio;
        private System.Windows.Forms.Label lblPrecoDesc2;
        private System.Windows.Forms.Label lblPrecoDesc;
        private System.Windows.Forms.TextBox txtPrecoTotalDEsc;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdRelResumo;
        private System.Windows.Forms.DataGridView grdRel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoMes;
        private System.Windows.Forms.RadioButton rdoSemana;
        private System.Windows.Forms.RadioButton rdoHoje;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.TabControl tabRels;
        private System.Windows.Forms.TextBox txtTotalPendentePagto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalPeriodo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView grdResumoPgtos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox txtTotalCaixa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}