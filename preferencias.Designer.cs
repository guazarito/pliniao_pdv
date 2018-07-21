namespace WindowsFormsApplication2
{
    partial class preferencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(preferencias));
            this.rdoTpServidor = new System.Windows.Forms.RadioButton();
            this.rdTpEstacao = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdoTpServidor
            // 
            this.rdoTpServidor.AutoSize = true;
            this.rdoTpServidor.Location = new System.Drawing.Point(88, 33);
            this.rdoTpServidor.Name = "rdoTpServidor";
            this.rdoTpServidor.Size = new System.Drawing.Size(64, 17);
            this.rdoTpServidor.TabIndex = 0;
            this.rdoTpServidor.TabStop = true;
            this.rdoTpServidor.Text = "Servidor";
            this.rdoTpServidor.UseVisualStyleBackColor = true;
            // 
            // rdTpEstacao
            // 
            this.rdTpEstacao.AutoSize = true;
            this.rdTpEstacao.Location = new System.Drawing.Point(88, 56);
            this.rdTpEstacao.Name = "rdTpEstacao";
            this.rdTpEstacao.Size = new System.Drawing.Size(64, 17);
            this.rdTpEstacao.TabIndex = 1;
            this.rdTpEstacao.TabStop = true;
            this.rdTpEstacao.Text = "Estação";
            this.rdTpEstacao.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(71, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 73);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo Máquina";
            // 
            // txtTempo
            // 
            this.txtTempo.Location = new System.Drawing.Point(169, 111);
            this.txtTempo.Name = "txtTempo";
            this.txtTempo.Size = new System.Drawing.Size(59, 20);
            this.txtTempo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tempo fila impressão (ms)";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(71, 143);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 32);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // preferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 187);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTempo);
            this.Controls.Add(this.rdTpEstacao);
            this.Controls.Add(this.rdoTpServidor);
            this.Controls.Add(this.groupBox1);
            this.Name = "preferencias";
            this.Text = "Preferências";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoTpServidor;
        private System.Windows.Forms.RadioButton rdTpEstacao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvar;
    }
}