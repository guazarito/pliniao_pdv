namespace WindowsFormsApplication2
{
    partial class frmCadCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadCli));
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomeCli = new System.Windows.Forms.TextBox();
            this.grdClientes = new System.Windows.Forms.DataGridView();
            this.btnLimparCli = new System.Windows.Forms.Button();
            this.btnSalvarCli = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelCli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraEntregaCli = new System.Windows.Forms.TextBox();
            this.txtEndCli = new System.Windows.Forms.RichTextBox();
            this.btnDeletarCli = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            // txtNomeCli
            // 
            this.txtNomeCli.BackColor = System.Drawing.Color.White;
            this.txtNomeCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCli.Location = new System.Drawing.Point(122, 19);
            this.txtNomeCli.Name = "txtNomeCli";
            this.txtNomeCli.Size = new System.Drawing.Size(304, 29);
            this.txtNomeCli.TabIndex = 26;
            // 
            // grdClientes
            // 
            this.grdClientes.AllowUserToAddRows = false;
            this.grdClientes.AllowUserToDeleteRows = false;
            this.grdClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdClientes.Location = new System.Drawing.Point(12, 238);
            this.grdClientes.MultiSelect = false;
            this.grdClientes.Name = "grdClientes";
            this.grdClientes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdClientes.ShowEditingIcon = false;
            this.grdClientes.Size = new System.Drawing.Size(903, 464);
            this.grdClientes.TabIndex = 23;
            this.grdClientes.TabStop = false;
            // 
            // btnLimparCli
            // 
            this.btnLimparCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCli.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCli.Image")));
            this.btnLimparCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimparCli.Location = new System.Drawing.Point(446, 161);
            this.btnLimparCli.Name = "btnLimparCli";
            this.btnLimparCli.Size = new System.Drawing.Size(103, 32);
            this.btnLimparCli.TabIndex = 31;
            this.btnLimparCli.Text = "Limpar";
            this.btnLimparCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCli.UseVisualStyleBackColor = true;
            this.btnLimparCli.Click += new System.EventHandler(this.btnLimparCli_Click);
            // 
            // btnSalvarCli
            // 
            this.btnSalvarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCli.Image")));
            this.btnSalvarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCli.Location = new System.Drawing.Point(446, 118);
            this.btnSalvarCli.Name = "btnSalvarCli";
            this.btnSalvarCli.Size = new System.Drawing.Size(103, 32);
            this.btnSalvarCli.TabIndex = 30;
            this.btnSalvarCli.Text = "Salvar";
            this.btnSalvarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCli.UseVisualStyleBackColor = true;
            this.btnSalvarCli.Click += new System.EventHandler(this.btnSalvarCli_Click);
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
            // txtTelCli
            // 
            this.txtTelCli.BackColor = System.Drawing.Color.White;
            this.txtTelCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelCli.Location = new System.Drawing.Point(122, 121);
            this.txtTelCli.Name = "txtTelCli";
            this.txtTelCli.Size = new System.Drawing.Size(202, 22);
            this.txtTelCli.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Horário entrega";
            // 
            // txtHoraEntregaCli
            // 
            this.txtHoraEntregaCli.BackColor = System.Drawing.Color.White;
            this.txtHoraEntregaCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoraEntregaCli.Location = new System.Drawing.Point(122, 168);
            this.txtHoraEntregaCli.Name = "txtHoraEntregaCli";
            this.txtHoraEntregaCli.Size = new System.Drawing.Size(202, 22);
            this.txtHoraEntregaCli.TabIndex = 29;
            // 
            // txtEndCli
            // 
            this.txtEndCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndCli.Location = new System.Drawing.Point(122, 61);
            this.txtEndCli.Name = "txtEndCli";
            this.txtEndCli.Size = new System.Drawing.Size(304, 45);
            this.txtEndCli.TabIndex = 27;
            this.txtEndCli.Text = "";
            // 
            // btnDeletarCli
            // 
            this.btnDeletarCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCli.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarCli.Image")));
            this.btnDeletarCli.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarCli.Location = new System.Drawing.Point(12, 724);
            this.btnDeletarCli.Name = "btnDeletarCli";
            this.btnDeletarCli.Size = new System.Drawing.Size(83, 23);
            this.btnDeletarCli.TabIndex = 35;
            this.btnDeletarCli.Text = "Deletar";
            this.btnDeletarCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarCli.UseVisualStyleBackColor = true;
            this.btnDeletarCli.Visible = false;
            this.btnDeletarCli.Click += new System.EventHandler(this.btnDeletarCli_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEndCli);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoraEntregaCli);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelCli);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtNomeCli);
            this.groupBox1.Controls.Add(this.btnLimparCli);
            this.groupBox1.Controls.Add(this.btnSalvarCli);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 209);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // frmCadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 769);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeletarCli);
            this.Controls.Add(this.grdClientes);
            this.Name = "frmCadCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Clientes";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNomeCli;
        private System.Windows.Forms.DataGridView grdClientes;
        private System.Windows.Forms.Button btnLimparCli;
        private System.Windows.Forms.Button btnSalvarCli;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelCli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoraEntregaCli;
        private System.Windows.Forms.RichTextBox txtEndCli;
        private System.Windows.Forms.Button btnDeletarCli;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}