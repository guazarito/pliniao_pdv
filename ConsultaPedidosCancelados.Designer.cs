namespace WindowsFormsApplication2
{
    partial class ConsultaPedidosCancelados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPedidosCancelados));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dtConsulta = new System.Windows.Forms.DateTimePicker();
            this.grdConsultaVendasCanceladas = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaVendasCanceladas)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Salmon;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 1;
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
            // dtConsulta
            // 
            this.dtConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtConsulta.Location = new System.Drawing.Point(39, 3);
            this.dtConsulta.Name = "dtConsulta";
            this.dtConsulta.Size = new System.Drawing.Size(96, 20);
            this.dtConsulta.TabIndex = 3;
            // 
            // grdConsultaVendasCanceladas
            // 
            this.grdConsultaVendasCanceladas.AllowUserToAddRows = false;
            this.grdConsultaVendasCanceladas.AllowUserToDeleteRows = false;
            this.grdConsultaVendasCanceladas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultaVendasCanceladas.Location = new System.Drawing.Point(0, 29);
            this.grdConsultaVendasCanceladas.Name = "grdConsultaVendasCanceladas";
            this.grdConsultaVendasCanceladas.ReadOnly = true;
            this.grdConsultaVendasCanceladas.Size = new System.Drawing.Size(651, 538);
            this.grdConsultaVendasCanceladas.TabIndex = 4;
            // 
            // ConsultaPedidosCancelados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 570);
            this.Controls.Add(this.grdConsultaVendasCanceladas);
            this.Controls.Add(this.dtConsulta);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ConsultaPedidosCancelados";
            this.Text = "Consultar Pedidos Cancelados";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultaVendasCanceladas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DateTimePicker dtConsulta;
        private System.Windows.Forms.DataGridView grdConsultaVendasCanceladas;
    }
}