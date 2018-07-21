namespace WindowsFormsApplication2
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.tabCad = new System.Windows.Forms.TabControl();
            this.tabPageNovo = new System.Windows.Forms.TabPage();
            this.txtNewPreco2 = new System.Windows.Forms.TextBox();
            this.cboTipoProd = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNewNome = new System.Windows.Forms.TextBox();
            this.txtNewCode = new System.Windows.Forms.TextBox();
            this.tabPageEdit = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.cboTipo_ed = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPreco_ed = new System.Windows.Forms.TextBox();
            this.btnLimpar2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomeProd_ed = new System.Windows.Forms.TextBox();
            this.txtCod_ed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboProcurarProduto = new System.Windows.Forms.ComboBox();
            this.tabCad.SuspendLayout();
            this.tabPageNovo.SuspendLayout();
            this.tabPageEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCad
            // 
            this.tabCad.Controls.Add(this.tabPageNovo);
            this.tabCad.Controls.Add(this.tabPageEdit);
            this.tabCad.Location = new System.Drawing.Point(7, 3);
            this.tabCad.Name = "tabCad";
            this.tabCad.SelectedIndex = 0;
            this.tabCad.Size = new System.Drawing.Size(591, 257);
            this.tabCad.TabIndex = 0;
            // 
            // tabPageNovo
            // 
            this.tabPageNovo.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageNovo.Controls.Add(this.txtNewPreco2);
            this.tabPageNovo.Controls.Add(this.cboTipoProd);
            this.tabPageNovo.Controls.Add(this.label8);
            this.tabPageNovo.Controls.Add(this.label3);
            this.tabPageNovo.Controls.Add(this.label2);
            this.tabPageNovo.Controls.Add(this.label1);
            this.tabPageNovo.Controls.Add(this.btnLimpar);
            this.tabPageNovo.Controls.Add(this.btnSalvar);
            this.tabPageNovo.Controls.Add(this.txtNewNome);
            this.tabPageNovo.Controls.Add(this.txtNewCode);
            this.tabPageNovo.Location = new System.Drawing.Point(4, 22);
            this.tabPageNovo.Name = "tabPageNovo";
            this.tabPageNovo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNovo.Size = new System.Drawing.Size(583, 231);
            this.tabPageNovo.TabIndex = 0;
            this.tabPageNovo.Text = "Novo Produto";
            // 
            // txtNewPreco2
            // 
            this.txtNewPreco2.Location = new System.Drawing.Point(73, 154);
            this.txtNewPreco2.Name = "txtNewPreco2";
            this.txtNewPreco2.Size = new System.Drawing.Size(68, 20);
            this.txtNewPreco2.TabIndex = 3;
            // 
            // cboTipoProd
            // 
            this.cboTipoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoProd.FormattingEnabled = true;
            this.cboTipoProd.Items.AddRange(new object[] {
            "",
            "Marmita/Marmitex/PF",
            "Bebida",
            "Outro"});
            this.cboTipoProd.Location = new System.Drawing.Point(73, 112);
            this.cboTipoProd.Name = "cboTipoProd";
            this.cboTipoProd.Size = new System.Drawing.Size(186, 21);
            this.cboTipoProd.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Preço R$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(247, 180);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 32);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(130, 180);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(105, 32);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNewNome
            // 
            this.txtNewNome.AcceptsTab = true;
            this.txtNewNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewNome.Location = new System.Drawing.Point(73, 68);
            this.txtNewNome.Name = "txtNewNome";
            this.txtNewNome.Size = new System.Drawing.Size(271, 22);
            this.txtNewNome.TabIndex = 1;
            // 
            // txtNewCode
            // 
            this.txtNewCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtNewCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewCode.Location = new System.Drawing.Point(73, 23);
            this.txtNewCode.Name = "txtNewCode";
            this.txtNewCode.ReadOnly = true;
            this.txtNewCode.Size = new System.Drawing.Size(68, 26);
            this.txtNewCode.TabIndex = 0;
            // 
            // tabPageEdit
            // 
            this.tabPageEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPageEdit.Controls.Add(this.groupBox1);
            this.tabPageEdit.Controls.Add(this.label4);
            this.tabPageEdit.Controls.Add(this.btnEditar);
            this.tabPageEdit.Controls.Add(this.cboProcurarProduto);
            this.tabPageEdit.Location = new System.Drawing.Point(4, 22);
            this.tabPageEdit.Name = "tabPageEdit";
            this.tabPageEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEdit.Size = new System.Drawing.Size(583, 231);
            this.tabPageEdit.TabIndex = 1;
            this.tabPageEdit.Text = "Editar Registros";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.cboTipo_ed);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtPreco_ed);
            this.groupBox1.Controls.Add(this.btnLimpar2);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNomeProd_ed);
            this.groupBox1.Controls.Add(this.txtCod_ed);
            this.groupBox1.Location = new System.Drawing.Point(8, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 191);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.Location = new System.Drawing.Point(346, 149);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(108, 32);
            this.btnDel.TabIndex = 12;
            this.btnDel.Text = "Deletar";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cboTipo_ed
            // 
            this.cboTipo_ed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo_ed.FormattingEnabled = true;
            this.cboTipo_ed.Items.AddRange(new object[] {
            "",
            "Refeição",
            "Bebida",
            "Outro"});
            this.cboTipo_ed.Location = new System.Drawing.Point(72, 83);
            this.cboTipo_ed.Name = "cboTipo_ed";
            this.cboTipo_ed.Size = new System.Drawing.Size(186, 21);
            this.cboTipo_ed.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tipo";
            // 
            // txtPreco_ed
            // 
            this.txtPreco_ed.Location = new System.Drawing.Point(72, 113);
            this.txtPreco_ed.Name = "txtPreco_ed";
            this.txtPreco_ed.Size = new System.Drawing.Size(71, 20);
            this.txtPreco_ed.TabIndex = 2;
            // 
            // btnLimpar2
            // 
            this.btnLimpar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar2.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar2.Image")));
            this.btnLimpar2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar2.Location = new System.Drawing.Point(232, 149);
            this.btnLimpar2.Name = "btnLimpar2";
            this.btnLimpar2.Size = new System.Drawing.Size(97, 32);
            this.btnLimpar2.TabIndex = 4;
            this.btnLimpar2.Text = "Limpar";
            this.btnLimpar2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar2.UseVisualStyleBackColor = true;
            this.btnLimpar2.Click += new System.EventHandler(this.btnLimpar2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.Location = new System.Drawing.Point(108, 149);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(105, 32);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Salvar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Preço  R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código";
            // 
            // txtNomeProd_ed
            // 
            this.txtNomeProd_ed.Location = new System.Drawing.Point(73, 54);
            this.txtNomeProd_ed.Name = "txtNomeProd_ed";
            this.txtNomeProd_ed.Size = new System.Drawing.Size(356, 20);
            this.txtNomeProd_ed.TabIndex = 1;
            // 
            // txtCod_ed
            // 
            this.txtCod_ed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCod_ed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCod_ed.Location = new System.Drawing.Point(72, 15);
            this.txtCod_ed.Name = "txtCod_ed";
            this.txtCod_ed.ReadOnly = true;
            this.txtCod_ed.Size = new System.Drawing.Size(72, 26);
            this.txtCod_ed.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Procurar";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(466, 8);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 27);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Selecionar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // cboProcurarProduto
            // 
            this.cboProcurarProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cboProcurarProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboProcurarProduto.FormattingEnabled = true;
            this.cboProcurarProduto.Location = new System.Drawing.Point(83, 12);
            this.cboProcurarProduto.Name = "cboProcurarProduto";
            this.cboProcurarProduto.Size = new System.Drawing.Size(360, 21);
            this.cboProcurarProduto.TabIndex = 0;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 272);
            this.Controls.Add(this.tabCad);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.tabCad.ResumeLayout(false);
            this.tabPageNovo.ResumeLayout(false);
            this.tabPageNovo.PerformLayout();
            this.tabPageEdit.ResumeLayout(false);
            this.tabPageEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCad;
        private System.Windows.Forms.TabPage tabPageNovo;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNewNome;
        private System.Windows.Forms.TextBox txtNewCode;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cboProcurarProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLimpar2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomeProd_ed;
        private System.Windows.Forms.TextBox txtCod_ed;
        private System.Windows.Forms.ComboBox cboTipoProd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNewPreco2;
        private System.Windows.Forms.TextBox txtPreco_ed;
        private System.Windows.Forms.ComboBox cboTipo_ed;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDel;
    }
}