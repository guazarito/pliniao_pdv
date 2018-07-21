namespace WindowsFormsApplication2
{
    partial class PagtosPendentes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagtosPendentes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPagtosQuitados = new System.Windows.Forms.TabControl();
            this.tabPagamentosPendentes = new System.Windows.Forms.TabPage();
            this.txtPrecoTotalPendente = new System.Windows.Forms.TextBox();
            this.btnExcelPgtosPendentes = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grdPagtosPendentes = new System.Windows.Forms.DataGridView();
            this.tabPagamentosQuitados = new System.Windows.Forms.TabPage();
            this.txtPrecoTotalPagamentosQuitados = new System.Windows.Forms.TextBox();
            this.btnExcelPagamentosQuitados = new System.Windows.Forms.Button();
            this.btnFechar1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grdPagamentosQuitados = new System.Windows.Forms.DataGridView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabPagtosQuitados.SuspendLayout();
            this.tabPagamentosPendentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagtosPendentes)).BeginInit();
            this.tabPagamentosQuitados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagamentosQuitados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPagtosQuitados
            // 
            this.tabPagtosQuitados.Controls.Add(this.tabPagamentosPendentes);
            this.tabPagtosQuitados.Controls.Add(this.tabPagamentosQuitados);
            this.tabPagtosQuitados.Location = new System.Drawing.Point(2, 2);
            this.tabPagtosQuitados.Name = "tabPagtosQuitados";
            this.tabPagtosQuitados.SelectedIndex = 0;
            this.tabPagtosQuitados.Size = new System.Drawing.Size(614, 420);
            this.tabPagtosQuitados.TabIndex = 0;
            // 
            // tabPagamentosPendentes
            // 
            this.tabPagamentosPendentes.Controls.Add(this.txtPrecoTotalPendente);
            this.tabPagamentosPendentes.Controls.Add(this.btnExcelPgtosPendentes);
            this.tabPagamentosPendentes.Controls.Add(this.btnFechar);
            this.tabPagamentosPendentes.Controls.Add(this.label3);
            this.tabPagamentosPendentes.Controls.Add(this.label2);
            this.tabPagamentosPendentes.Controls.Add(this.grdPagtosPendentes);
            this.tabPagamentosPendentes.Location = new System.Drawing.Point(4, 22);
            this.tabPagamentosPendentes.Name = "tabPagamentosPendentes";
            this.tabPagamentosPendentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamentosPendentes.Size = new System.Drawing.Size(606, 394);
            this.tabPagamentosPendentes.TabIndex = 0;
            this.tabPagamentosPendentes.Text = "Pagamentos Pendentes";
            this.tabPagamentosPendentes.UseVisualStyleBackColor = true;
            // 
            // txtPrecoTotalPendente
            // 
            this.txtPrecoTotalPendente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPrecoTotalPendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalPendente.Location = new System.Drawing.Point(454, 357);
            this.txtPrecoTotalPendente.Name = "txtPrecoTotalPendente";
            this.txtPrecoTotalPendente.ReadOnly = true;
            this.txtPrecoTotalPendente.Size = new System.Drawing.Size(105, 29);
            this.txtPrecoTotalPendente.TabIndex = 38;
            this.txtPrecoTotalPendente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExcelPgtosPendentes
            // 
            this.btnExcelPgtosPendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelPgtosPendentes.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPgtosPendentes.Image")));
            this.btnExcelPgtosPendentes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelPgtosPendentes.Location = new System.Drawing.Point(104, 353);
            this.btnExcelPgtosPendentes.Name = "btnExcelPgtosPendentes";
            this.btnExcelPgtosPendentes.Size = new System.Drawing.Size(139, 33);
            this.btnExcelPgtosPendentes.TabIndex = 42;
            this.btnExcelPgtosPendentes.Text = "Exportar Excel";
            this.btnExcelPgtosPendentes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelPgtosPendentes.UseVisualStyleBackColor = true;
            this.btnExcelPgtosPendentes.Click += new System.EventHandler(this.btnExcelPgtosPendentes_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(288, 353);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 33);
            this.btnFechar.TabIndex = 41;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(421, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(421, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "R$";
            // 
            // grdPagtosPendentes
            // 
            this.grdPagtosPendentes.AllowUserToAddRows = false;
            this.grdPagtosPendentes.AllowUserToDeleteRows = false;
            this.grdPagtosPendentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPagtosPendentes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdPagtosPendentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPagtosPendentes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdPagtosPendentes.Location = new System.Drawing.Point(-1, 5);
            this.grdPagtosPendentes.MultiSelect = false;
            this.grdPagtosPendentes.Name = "grdPagtosPendentes";
            this.grdPagtosPendentes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPagtosPendentes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdPagtosPendentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPagtosPendentes.Size = new System.Drawing.Size(604, 320);
            this.grdPagtosPendentes.TabIndex = 37;
            this.grdPagtosPendentes.TabStop = false;
            this.grdPagtosPendentes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.abrePedidoPagtoPendente);
            // 
            // tabPagamentosQuitados
            // 
            this.tabPagamentosQuitados.Controls.Add(this.txtPrecoTotalPagamentosQuitados);
            this.tabPagamentosQuitados.Controls.Add(this.btnExcelPagamentosQuitados);
            this.tabPagamentosQuitados.Controls.Add(this.btnFechar1);
            this.tabPagamentosQuitados.Controls.Add(this.label1);
            this.tabPagamentosQuitados.Controls.Add(this.label4);
            this.tabPagamentosQuitados.Controls.Add(this.grdPagamentosQuitados);
            this.tabPagamentosQuitados.Location = new System.Drawing.Point(4, 22);
            this.tabPagamentosQuitados.Name = "tabPagamentosQuitados";
            this.tabPagamentosQuitados.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagamentosQuitados.Size = new System.Drawing.Size(606, 394);
            this.tabPagamentosQuitados.TabIndex = 1;
            this.tabPagamentosQuitados.Text = "Pagamentos Quitados";
            this.tabPagamentosQuitados.UseVisualStyleBackColor = true;
            // 
            // txtPrecoTotalPagamentosQuitados
            // 
            this.txtPrecoTotalPagamentosQuitados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPrecoTotalPagamentosQuitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoTotalPagamentosQuitados.Location = new System.Drawing.Point(455, 357);
            this.txtPrecoTotalPagamentosQuitados.Name = "txtPrecoTotalPagamentosQuitados";
            this.txtPrecoTotalPagamentosQuitados.ReadOnly = true;
            this.txtPrecoTotalPagamentosQuitados.Size = new System.Drawing.Size(97, 29);
            this.txtPrecoTotalPagamentosQuitados.TabIndex = 44;
            // 
            // btnExcelPagamentosQuitados
            // 
            this.btnExcelPagamentosQuitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelPagamentosQuitados.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelPagamentosQuitados.Image")));
            this.btnExcelPagamentosQuitados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcelPagamentosQuitados.Location = new System.Drawing.Point(105, 353);
            this.btnExcelPagamentosQuitados.Name = "btnExcelPagamentosQuitados";
            this.btnExcelPagamentosQuitados.Size = new System.Drawing.Size(139, 33);
            this.btnExcelPagamentosQuitados.TabIndex = 48;
            this.btnExcelPagamentosQuitados.Text = "Exportar Excel";
            this.btnExcelPagamentosQuitados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcelPagamentosQuitados.UseVisualStyleBackColor = true;
            // 
            // btnFechar1
            // 
            this.btnFechar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar1.Location = new System.Drawing.Point(289, 353);
            this.btnFechar1.Name = "btnFechar1";
            this.btnFechar1.Size = new System.Drawing.Size(97, 33);
            this.btnFechar1.TabIndex = 47;
            this.btnFechar1.Text = "Fechar";
            this.btnFechar1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(422, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 18);
            this.label4.TabIndex = 45;
            this.label4.Text = "R$";
            // 
            // grdPagamentosQuitados
            // 
            this.grdPagamentosQuitados.AllowUserToAddRows = false;
            this.grdPagamentosQuitados.AllowUserToDeleteRows = false;
            this.grdPagamentosQuitados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPagamentosQuitados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdPagamentosQuitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPagamentosQuitados.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPagamentosQuitados.Location = new System.Drawing.Point(1, 5);
            this.grdPagamentosQuitados.Name = "grdPagamentosQuitados";
            this.grdPagamentosQuitados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdPagamentosQuitados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grdPagamentosQuitados.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.grdPagamentosQuitados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdPagamentosQuitados.Size = new System.Drawing.Size(602, 320);
            this.grdPagamentosQuitados.TabIndex = 43;
            // 
            // PagtosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 422);
            this.Controls.Add(this.tabPagtosQuitados);
            this.Name = "PagtosPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagamentos Pendentes";
            this.Load += new System.EventHandler(this.load);
            this.tabPagtosQuitados.ResumeLayout(false);
            this.tabPagamentosPendentes.ResumeLayout(false);
            this.tabPagamentosPendentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagtosPendentes)).EndInit();
            this.tabPagamentosQuitados.ResumeLayout(false);
            this.tabPagamentosQuitados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPagamentosQuitados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPagtosQuitados;
        private System.Windows.Forms.TabPage tabPagamentosPendentes;
        private System.Windows.Forms.TextBox txtPrecoTotalPendente;
        private System.Windows.Forms.Button btnExcelPgtosPendentes;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdPagtosPendentes;
        private System.Windows.Forms.TabPage tabPagamentosQuitados;
        private System.Windows.Forms.TextBox txtPrecoTotalPagamentosQuitados;
        private System.Windows.Forms.Button btnExcelPagamentosQuitados;
        private System.Windows.Forms.Button btnFechar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView grdPagamentosQuitados;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}