namespace WindowsFormsApplication2
{
    partial class QuitarPagtosPendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuitarPagtosPendentes));
            this.grdQuitarPagtosPendentes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecoTotalQuitarPendente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitarSel = new System.Windows.Forms.Button();
            this.btnExcelPgtosPendentes = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtTotalSelecionado = new System.Windows.Forms.TextBox();
            this.lblTotalSelecionado = new System.Windows.Forms.Label();
            this.lblRSsel = new System.Windows.Forms.Label();
            this.grdResumoQuitar = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chkImprimeRecibo = new System.Windows.Forms.CheckBox();
            this.txtDin = new System.Windows.Forms.TextBox();
            this.chkCredito = new System.Windows.Forms.RadioButton();
            this.chkDebito = new System.Windows.Forms.RadioButton();
            this.chkDin = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTroco = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdQuitarPagtosPendentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoQuitar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdQuitarPagtosPendentes
            // 
            this.grdQuitarPagtosPendentes.AllowUserToAddRows = false;
            this.grdQuitarPagtosPendentes.AllowUserToDeleteRows = false;
            this.grdQuitarPagtosPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdQuitarPagtosPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdQuitarPagtosPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdQuitarPagtosPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdQuitarPagtosPendentes.Location = new System.Drawing.Point(11, 38);
            this.grdQuitarPagtosPendentes.Name = "grdQuitarPagtosPendentes";
            this.grdQuitarPagtosPendentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdQuitarPagtosPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdQuitarPagtosPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdQuitarPagtosPendentes.Size = new System.Drawing.Size(604, 307);
            this.grdQuitarPagtosPendentes.TabIndex = 38;
            this.grdQuitarPagtosPendentes.TabStop = false;
            this.grdQuitarPagtosPendentes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CellMouseClick);
            this.grdQuitarPagtosPendentes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.abreProduto);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "label1";
            // 
            // txtPrecoTotalQuitarPendente
            // 
            this.txtPrecoTotalQuitarPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPrecoTotalQuitarPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalQuitarPendente.Location = new System.Drawing.Point(895, 411);
            this.txtPrecoTotalQuitarPendente.Name = "txtPrecoTotalQuitarPendente";
            this.txtPrecoTotalQuitarPendente.ReadOnly = true;
            this.txtPrecoTotalQuitarPendente.Size = new System.Drawing.Size(105, 29);
            this.txtPrecoTotalQuitarPendente.TabIndex = 41;
            this.txtPrecoTotalQuitarPendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(862, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(862, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 42;
            this.label2.Text = "R$";
            // 
            // btnQuitarSel
            // 
            this.btnQuitarSel.Enabled = false;
            this.btnQuitarSel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarSel.Image = ((System.Drawing.Image)(resources.GetObject("btnQuitarSel.Image")));
            this.btnQuitarSel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarSel.Location = new System.Drawing.Point(11, 422);
            this.btnQuitarSel.Name = "btnQuitarSel";
            this.btnQuitarSel.Size = new System.Drawing.Size(196, 31);
            this.btnQuitarSel.TabIndex = 44;
            this.btnQuitarSel.Text = "Quitar Selecionados";
            this.btnQuitarSel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarSel.UseVisualStyleBackColor = true;
            this.btnQuitarSel.Click += new System.EventHandler(this.btnQuitarSel_Click);
            // 
            // btnExcelPgtosPendentes
            // 
            this.btnExcelPgtosPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelPgtosPendentes.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPgtosPendentes.Image")));
            this.btnExcelPgtosPendentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelPgtosPendentes.Location = new System.Drawing.Point(11, 459);
            this.btnExcelPgtosPendentes.Name = "btnExcelPgtosPendentes";
            this.btnExcelPgtosPendentes.Size = new System.Drawing.Size(196, 33);
            this.btnExcelPgtosPendentes.TabIndex = 45;
            this.btnExcelPgtosPendentes.Text = "Exportar para Excel";
            this.btnExcelPgtosPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelPgtosPendentes.UseVisualStyleBackColor = true;
            this.btnExcelPgtosPendentes.Click += new System.EventHandler(this.btnExcelPgtosPendentes_Click);
            // 
            // txtTotalSelecionado
            // 
            this.txtTotalSelecionado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtTotalSelecionado.Enabled = false;
            this.txtTotalSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSelecionado.Location = new System.Drawing.Point(681, 411);
            this.txtTotalSelecionado.Name = "txtTotalSelecionado";
            this.txtTotalSelecionado.ReadOnly = true;
            this.txtTotalSelecionado.Size = new System.Drawing.Size(105, 29);
            this.txtTotalSelecionado.TabIndex = 46;
            this.txtTotalSelecionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalSelecionado
            // 
            this.lblTotalSelecionado.AutoSize = true;
            this.lblTotalSelecionado.Enabled = false;
            this.lblTotalSelecionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSelecionado.Location = new System.Drawing.Point(648, 392);
            this.lblTotalSelecionado.Name = "lblTotalSelecionado";
            this.lblTotalSelecionado.Size = new System.Drawing.Size(122, 16);
            this.lblTotalSelecionado.TabIndex = 48;
            this.lblTotalSelecionado.Text = "Total Selecionado:";
            // 
            // lblRSsel
            // 
            this.lblRSsel.AutoSize = true;
            this.lblRSsel.Enabled = false;
            this.lblRSsel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRSsel.Location = new System.Drawing.Point(648, 422);
            this.lblRSsel.Name = "lblRSsel";
            this.lblRSsel.Size = new System.Drawing.Size(27, 18);
            this.lblRSsel.TabIndex = 47;
            this.lblRSsel.Text = "R$";
            // 
            // grdResumoQuitar
            // 
            this.grdResumoQuitar.AllowUserToAddRows = false;
            this.grdResumoQuitar.AllowUserToDeleteRows = false;
            this.grdResumoQuitar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdResumoQuitar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResumoQuitar.Location = new System.Drawing.Point(634, 69);
            this.grdResumoQuitar.MultiSelect = false;
            this.grdResumoQuitar.Name = "grdResumoQuitar";
            this.grdResumoQuitar.ReadOnly = true;
            this.grdResumoQuitar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdResumoQuitar.Size = new System.Drawing.Size(361, 276);
            this.grdResumoQuitar.TabIndex = 49;
            this.grdResumoQuitar.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(630, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Resumo Itens:";
            // 
            // chkImprimeRecibo
            // 
            this.chkImprimeRecibo.AutoSize = true;
            this.chkImprimeRecibo.Checked = true;
            this.chkImprimeRecibo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkImprimeRecibo.Location = new System.Drawing.Point(16, 357);
            this.chkImprimeRecibo.Name = "chkImprimeRecibo";
            this.chkImprimeRecibo.Size = new System.Drawing.Size(98, 17);
            this.chkImprimeRecibo.TabIndex = 51;
            this.chkImprimeRecibo.Text = "Imprimir Recibo";
            this.chkImprimeRecibo.UseVisualStyleBackColor = true;
            // 
            // txtDin
            // 
            this.txtDin.BackColor = System.Drawing.SystemColors.Info;
            this.txtDin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDin.Location = new System.Drawing.Point(97, 19);
            this.txtDin.Name = "txtDin";
            this.txtDin.Size = new System.Drawing.Size(51, 24);
            this.txtDin.TabIndex = 56;
            this.txtDin.Visible = false;
            this.txtDin.TextChanged += new System.EventHandler(this.txtDin_TextChanged);
            // 
            // chkCredito
            // 
            this.chkCredito.AutoSize = true;
            this.chkCredito.Location = new System.Drawing.Point(9, 78);
            this.chkCredito.Name = "chkCredito";
            this.chkCredito.Size = new System.Drawing.Size(92, 17);
            this.chkCredito.TabIndex = 54;
            this.chkCredito.TabStop = true;
            this.chkCredito.Text = "Cartão Crédito";
            this.chkCredito.UseVisualStyleBackColor = true;
            // 
            // chkDebito
            // 
            this.chkDebito.AutoSize = true;
            this.chkDebito.Location = new System.Drawing.Point(9, 49);
            this.chkDebito.Name = "chkDebito";
            this.chkDebito.Size = new System.Drawing.Size(90, 17);
            this.chkDebito.TabIndex = 53;
            this.chkDebito.TabStop = true;
            this.chkDebito.Text = "Cartão Débito";
            this.chkDebito.UseVisualStyleBackColor = true;
            // 
            // chkDin
            // 
            this.chkDin.AutoSize = true;
            this.chkDin.Location = new System.Drawing.Point(9, 21);
            this.chkDin.Name = "chkDin";
            this.chkDin.Size = new System.Drawing.Size(64, 17);
            this.chkDin.TabIndex = 52;
            this.chkDin.TabStop = true;
            this.chkDin.Text = "Dinheiro";
            this.chkDin.UseVisualStyleBackColor = true;
            this.chkDin.CheckedChanged += new System.EventHandler(this.chkDin_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDin);
            this.groupBox1.Controls.Add(this.chkCredito);
            this.groupBox1.Controls.Add(this.chkDebito);
            this.groupBox1.Controls.Add(this.chkDin);
            this.groupBox1.Location = new System.Drawing.Point(238, 351);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 98);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTroco.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTroco.Location = new System.Drawing.Point(423, 374);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(72, 20);
            this.lblTroco.TabIndex = 57;
            this.lblTroco.Text = "lblTroco";
            this.lblTroco.Visible = false;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(12, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 31);
            this.button1.TabIndex = 60;
            this.button1.Text = "Imprimir Selecionados";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuitarPagtosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTroco);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkImprimeRecibo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grdResumoQuitar);
            this.Controls.Add(this.txtTotalSelecionado);
            this.Controls.Add(this.lblTotalSelecionado);
            this.Controls.Add(this.lblRSsel);
            this.Controls.Add(this.btnExcelPgtosPendentes);
            this.Controls.Add(this.btnQuitarSel);
            this.Controls.Add(this.txtPrecoTotalQuitarPendente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdQuitarPagtosPendentes);
            this.Name = "QuitarPagtosPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quitar pagamentos pendentes";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.grdQuitarPagtosPendentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdResumoQuitar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdQuitarPagtosPendentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecoTotalQuitarPendente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitarSel;
        private System.Windows.Forms.Button btnExcelPgtosPendentes;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtTotalSelecionado;
        private System.Windows.Forms.Label lblTotalSelecionado;
        private System.Windows.Forms.Label lblRSsel;
        private System.Windows.Forms.DataGridView grdResumoQuitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkImprimeRecibo;
        private System.Windows.Forms.TextBox txtDin;
        private System.Windows.Forms.RadioButton chkCredito;
        private System.Windows.Forms.RadioButton chkDebito;
        private System.Windows.Forms.RadioButton chkDin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Button button1;
    }
}