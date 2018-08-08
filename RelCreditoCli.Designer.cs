namespace WindowsFormsApplication2
{
    partial class RelCreditoCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelCreditoCli));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtTotalPeriodoDado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grdHistoricoCreditoDado = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtTotalPeriodoUsado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grdHistoricoCreditosUsados = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.dtIni = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditoDado)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditosUsados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(2, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(586, 513);
            this.tabControl1.TabIndex = 16;
            this.tabControl1.Visible = false;
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
            this.tabPage2.Size = new System.Drawing.Size(578, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico créditos dados";
            // 
            // txtTotalPeriodoDado
            // 
            this.txtTotalPeriodoDado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalPeriodoDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeriodoDado.Location = new System.Drawing.Point(458, 452);
            this.txtTotalPeriodoDado.Name = "txtTotalPeriodoDado";
            this.txtTotalPeriodoDado.Size = new System.Drawing.Size(114, 29);
            this.txtTotalPeriodoDado.TabIndex = 17;
            this.txtTotalPeriodoDado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 461);
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
            this.grdHistoricoCreditoDado.Size = new System.Drawing.Size(573, 443);
            this.grdHistoricoCreditoDado.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Silver;
            this.tabPage3.Controls.Add(this.txtTotalPeriodoUsado);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.grdHistoricoCreditosUsados);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(578, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Histórico créditos usados";
            // 
            // txtTotalPeriodoUsado
            // 
            this.txtTotalPeriodoUsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtTotalPeriodoUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPeriodoUsado.Location = new System.Drawing.Point(460, 453);
            this.txtTotalPeriodoUsado.Name = "txtTotalPeriodoUsado";
            this.txtTotalPeriodoUsado.Size = new System.Drawing.Size(114, 29);
            this.txtTotalPeriodoUsado.TabIndex = 19;
            this.txtTotalPeriodoUsado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 462);
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
            this.grdHistoricoCreditosUsados.Size = new System.Drawing.Size(578, 447);
            this.grdHistoricoCreditosUsados.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Inicial";
            // 
            // dtFim
            // 
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFim.Location = new System.Drawing.Point(152, 37);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(108, 20);
            this.dtFim.TabIndex = 18;
            // 
            // dtIni
            // 
            this.dtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtIni.Location = new System.Drawing.Point(15, 37);
            this.dtIni.Name = "dtIni";
            this.dtIni.Size = new System.Drawing.Size(108, 20);
            this.dtIni.TabIndex = 17;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(408, 32);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(153, 35);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Gerar Relatório";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // RelCreditoCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 608);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFim);
            this.Controls.Add(this.dtIni);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tabControl1);
            this.Name = "RelCreditoCli";
            this.Text = "Relatório Crédito Clientes Inseridos/Utilizados";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditoDado)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdHistoricoCreditosUsados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtTotalPeriodoDado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grdHistoricoCreditoDado;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtTotalPeriodoUsado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grdHistoricoCreditosUsados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.DateTimePicker dtIni;
        private System.Windows.Forms.Button btnBuscar;
    }
}