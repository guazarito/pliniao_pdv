namespace WindowsFormsApplication2
{
    partial class cadTickets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadTickets));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDeletarTicket = new System.Windows.Forms.Button();
            this.btnSalvarCliAg = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNomeTicket = new System.Windows.Forms.TextBox();
            this.grdTickets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletarTicket
            // 
            this.btnDeletarTicket.Enabled = false;
            this.btnDeletarTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletarTicket.Image")));
            this.btnDeletarTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeletarTicket.Location = new System.Drawing.Point(311, 341);
            this.btnDeletarTicket.Name = "btnDeletarTicket";
            this.btnDeletarTicket.Size = new System.Drawing.Size(83, 23);
            this.btnDeletarTicket.TabIndex = 41;
            this.btnDeletarTicket.Text = "Deletar";
            this.btnDeletarTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletarTicket.UseVisualStyleBackColor = true;
            this.btnDeletarTicket.Click += new System.EventHandler(this.btnDeletarTicket_Click);
            // 
            // btnSalvarCliAg
            // 
            this.btnSalvarCliAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarCliAg.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvarCliAg.Image")));
            this.btnSalvarCliAg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvarCliAg.Location = new System.Drawing.Point(22, 67);
            this.btnSalvarCliAg.Name = "btnSalvarCliAg";
            this.btnSalvarCliAg.Size = new System.Drawing.Size(103, 32);
            this.btnSalvarCliAg.TabIndex = 39;
            this.btnSalvarCliAg.Text = "Salvar";
            this.btnSalvarCliAg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvarCliAg.UseVisualStyleBackColor = true;
            this.btnSalvarCliAg.Click += new System.EventHandler(this.btnSalvarCliAg_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(19, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 18);
            this.label19.TabIndex = 43;
            this.label19.Text = "Nome do ticket";
            // 
            // txtNomeTicket
            // 
            this.txtNomeTicket.BackColor = System.Drawing.Color.White;
            this.txtNomeTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTicket.Location = new System.Drawing.Point(150, 33);
            this.txtNomeTicket.Name = "txtNomeTicket";
            this.txtNomeTicket.Size = new System.Drawing.Size(244, 22);
            this.txtNomeTicket.TabIndex = 42;
            // 
            // grdTickets
            // 
            this.grdTickets.AllowUserToAddRows = false;
            this.grdTickets.AllowUserToDeleteRows = false;
            this.grdTickets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTickets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTickets.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdTickets.Location = new System.Drawing.Point(22, 127);
            this.grdTickets.MultiSelect = false;
            this.grdTickets.Name = "grdTickets";
            this.grdTickets.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTickets.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdTickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdTickets.ShowEditingIcon = false;
            this.grdTickets.Size = new System.Drawing.Size(372, 184);
            this.grdTickets.TabIndex = 44;
            this.grdTickets.TabStop = false;
            this.grdTickets.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdTickets_CellMouseClick);
            // 
            // cadTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(410, 404);
            this.Controls.Add(this.grdTickets);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtNomeTicket);
            this.Controls.Add(this.btnDeletarTicket);
            this.Controls.Add(this.btnSalvarCliAg);
            this.Name = "cadTickets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro tipo de ticket";
            ((System.ComponentModel.ISupportInitialize)(this.grdTickets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDeletarTicket;
        private System.Windows.Forms.Button btnSalvarCliAg;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNomeTicket;
        private System.Windows.Forms.DataGridView grdTickets;
    }
}