namespace WindowsFormsApplication2
{
    partial class FrmFilaImpressao
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
            this.grdFilaImpressao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilaImpressao)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFilaImpressao
            // 
            this.grdFilaImpressao.AllowUserToAddRows = false;
            this.grdFilaImpressao.AllowUserToDeleteRows = false;
            this.grdFilaImpressao.AllowUserToResizeColumns = false;
            this.grdFilaImpressao.AllowUserToResizeRows = false;
            this.grdFilaImpressao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFilaImpressao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFilaImpressao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFilaImpressao.Location = new System.Drawing.Point(0, 0);
            this.grdFilaImpressao.MultiSelect = false;
            this.grdFilaImpressao.Name = "grdFilaImpressao";
            this.grdFilaImpressao.ReadOnly = true;
            this.grdFilaImpressao.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdFilaImpressao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFilaImpressao.Size = new System.Drawing.Size(721, 231);
            this.grdFilaImpressao.TabIndex = 0;
            // 
            // FrmFilaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 231);
            this.Controls.Add(this.grdFilaImpressao);
            this.Name = "FrmFilaImpressao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fila Impressão";
            ((System.ComponentModel.ISupportInitialize)(this.grdFilaImpressao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFilaImpressao;
    }
}