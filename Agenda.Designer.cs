namespace WindowsFormsApplication2
{
    partial class frmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEndCliAg = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelCliAg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomeCliAg = new System.Windows.Forms.TextBox();
            this.btnLimparCliAg = new System.Windows.Forms.Button();
            this.btnSalvarCliAg = new System.Windows.Forms.Button();
            this.btnDeletarCliAg = new System.Windows.Forms.Button();
            this.grdClientesAg = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientesAg)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndCliAg);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelCliAg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtNomeCliAg);
            this.groupBox1.Controls.Add(this.btnLimparCliAg);
            this.groupBox1.Controls.Add(this.btnSalvarCliAg);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 212);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // txtEndCliAg
            // 
            this.txtEndCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCliAg.Location = new System.Drawing.Point(122, 61);
            this.txtEndCliAg.Name = "txtEndCliAg";
            this.txtEndCliAg.Size = new System.Drawing.Size(304, 45);
            this.txtEndCliAg.TabIndex = 27;
            this.txtEndCliAg.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 31;
            this.label2.Text = "Telefone";
            // 
            // txtTelCliAg
            // 
            this.txtTelCliAg.BackColor = System.Drawing.Color.White;
            this.txtTelCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCliAg.Location = new System.Drawing.Point(122, 121);
            this.txtTelCliAg.Name = "txtTelCliAg";
            this.txtTelCliAg.Size = new System.Drawing.Size(202, 22);
            this.txtTelCliAg.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 29;
            this.label1.Text = "Endereço";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(5, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 18);
            this.label19.TabIndex = 27;
            this.label19.Text = "Nome";
            // 
            // txtNomeCliAg
            // 
            this.txtNomeCliAg.BackColor = System.Drawing.Color.White;
            this.txtNomeCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliAg.Location = new System.Drawing.Point(122, 19);
            this.txtNomeCliAg.Name = "txtNomeCliAg";
            this.txtNomeCliAg.Size = new System.Drawing.Size(304, 22);
            this.txtNomeCliAg.TabIndex = 26;
            // 
            // btnLimparCliAg
            // 
            this.btnLimparCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCliAg.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCliAg.Image")));
            this.btnLimparCliAg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCliAg.Location = new System.Drawing.Point(122, 168);
            this.btnLimparCliAg.Name = "btnLimparCliAg";
            this.btnLimparCliAg.Size = new System.Drawing.Size(103, 32);
            this.btnLimparCliAg.TabIndex = 31;
            this.btnLimparCliAg.Text = "Limpar";
            this.btnLimparCliAg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCliAg.UseVisualStyleBackColor = true;
            this.btnLimparCliAg.Click += new System.EventHandler(this.btnLimparCliAg_Click);
            // 
            // btnSalvarCliAg
            // 
            this.btnSalvarCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliAg.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCliAg.Image")));
            this.btnSalvarCliAg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCliAg.Location = new System.Drawing.Point(8, 168);
            this.btnSalvarCliAg.Name = "btnSalvarCliAg";
            this.btnSalvarCliAg.Size = new System.Drawing.Size(103, 32);
            this.btnSalvarCliAg.TabIndex = 30;
            this.btnSalvarCliAg.Text = "Salvar";
            this.btnSalvarCliAg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCliAg.UseVisualStyleBackColor = true;
            this.btnSalvarCliAg.Click += new System.EventHandler(this.btnSalvarCliAg_Click);
            // 
            // btnDeletarCliAg
            // 
            this.btnDeletarCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCliAg.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarCliAg.Image")));
            this.btnDeletarCliAg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarCliAg.Location = new System.Drawing.Point(484, 400);
            this.btnDeletarCliAg.Name = "btnDeletarCliAg";
            this.btnDeletarCliAg.Size = new System.Drawing.Size(83, 23);
            this.btnDeletarCliAg.TabIndex = 38;
            this.btnDeletarCliAg.Text = "Deletar";
            this.btnDeletarCliAg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarCliAg.UseVisualStyleBackColor = true;
            this.btnDeletarCliAg.Visible = false;
            this.btnDeletarCliAg.Click += new System.EventHandler(this.btnDeletarCliAg_Click);
            // 
            // grdClientesAg
            // 
            this.grdClientesAg.AllowUserToAddRows = false;
            this.grdClientesAg.AllowUserToDeleteRows = false;
            this.grdClientesAg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientesAg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientesAg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdClientesAg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClientesAg.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdClientesAg.Location = new System.Drawing.Point(8, 230);
            this.grdClientesAg.MultiSelect = false;
            this.grdClientesAg.Name = "grdClientesAg";
            this.grdClientesAg.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientesAg.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdClientesAg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientesAg.ShowEditingIcon = false;
            this.grdClientesAg.Size = new System.Drawing.Size(559, 164);
            this.grdClientesAg.TabIndex = 37;
            this.grdClientesAg.TabStop = false;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeletarCliAg);
            this.Controls.Add(this.grdClientesAg);
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientesAg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtEndCliAg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelCliAg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNomeCliAg;
        private System.Windows.Forms.Button btnLimparCliAg;
        private System.Windows.Forms.Button btnSalvarCliAg;
        private System.Windows.Forms.Button btnDeletarCliAg;
        private System.Windows.Forms.DataGridView grdClientesAg;
    }
}