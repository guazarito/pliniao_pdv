using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{
    public partial class frmCadastro : Form
    {
        public frmCadastro(int idprod=0)
        {
            InitializeComponent();
            this.ActiveControl = txtNewNome;
            this.txtNewNome.Focus();
           this.tabCad.SelectedIndexChanged += new EventHandler(tabCad_SelectedIndexChanged);
           conexao c = new conexao();
           if (idprod != 0)
           {
               this.tabCad.SelectedIndex=1;
               c.fillCombo(this.cboProcurarProduto, "select * from produto", "id", "descr");
               cboProcurarProduto.SelectedValue=idprod;
               this.btnEditar_Click(null, null);
           }

        }

        
        private void tabCad_SelectedIndexChanged(Object sender, EventArgs e) {

            switch ((sender as TabControl).SelectedIndex)
            {
                
                case 1:
                    conexao c = new conexao();
                    c.fillCombo(this.cboProcurarProduto, "select * from produto", "id", "descr");
                    cboProcurarProduto.Text = "";
                    break;
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNewCode.Text = "";
            txtNewNome.Text = "";
            cboTipoProd.SelectedIndex = 0;
            txtNewPreco2.Text = "";
            txtNewNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

           

                if (txtNewNome.Text != "" && cboTipoProd.Text != "" && txtNewPreco2.Text != "")
                {
                
                   txtNewPreco2.Text = txtNewPreco2.Text.Replace(",", ".");

                    conexao Con = new conexao();


                    String sQuery;
                    sQuery = "insert into produto(descr, preco, tipo) values('" + txtNewNome.Text + "'," + txtNewPreco2.Text + "," + cboTipoProd.SelectedIndex + ")";
                    if (Con.ExecutaQuery(sQuery))
                    {
                        txtNewCode.Text = Con.RetornaQuery("select max(id) as id from produto", "id");
                        MessageBox.Show("Concluido");
                        btnLimpar_Click(sender, e);

                    }
                }
                else
                {
                    MessageBox.Show("Nome, tipo e preço devem ser preenchidos!", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
  
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

           
            
            if (cboProcurarProduto.Text != "")
            {
                conexao Con = new conexao();
                String sQuery;
                sQuery = "select descr, preco,tipo from produto where id=" + cboProcurarProduto.SelectedValue.ToString();

                txtCod_ed.Text = cboProcurarProduto.SelectedValue.ToString();
                txtNomeProd_ed.Text = Con.RetornaQuery(sQuery, "descr");
                txtPreco_ed.Text = Con.RetornaQuery(sQuery, "preco");
                cboTipo_ed.SelectedIndex = Convert.ToInt32(Con.RetornaQuery(sQuery, "tipo"));

                btnDel.Enabled = true;
            }
        }

        private void btnLimpar2_Click(object sender, EventArgs e)
        {
            cboProcurarProduto.Text = "";
            txtCod_ed.Text = "";
            txtNomeProd_ed.Text = "";
            txtPreco_ed.Text = "";
            cboTipo_ed.Text = "";
            btnDel.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNomeProd_ed.Text != "" && cboTipo_ed.Text != "" && txtPreco_ed.Text != "  .")
            {

                txtPreco_ed.Text = txtPreco_ed.Text.Replace(",", ".");

                conexao Con = new conexao();
                String sQuery;
                sQuery = "update produto set descr='" + txtNomeProd_ed.Text + "', preco=" + txtPreco_ed.Text + ", tipo=" + cboTipo_ed.SelectedIndex + " where id=" + cboProcurarProduto.SelectedValue;
                if (Con.ExecutaQuery(sQuery))
                {

                    MessageBox.Show("Concluido");
                   

                }
            }
            else
            {
                MessageBox.Show("Nome, tipo e preço devem ser preenchidos!", "Preencha os campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            conexao Con = new conexao();
            String sQuery;
            sQuery = "delete from produto where id=" + cboProcurarProduto.SelectedValue.ToString();

            if (MessageBox.Show("Tem certeza que deseja DELETAR ?", "Deletar?", MessageBoxButtons.YesNoCancel,
        MessageBoxIcon.Information) == DialogResult.Yes)
            {

                Con.ExecutaQuery(sQuery);
                btnLimpar2_Click(sender, e);
                btnDel.Enabled = false;

                Con.fillCombo(this.cboProcurarProduto, "select * from produto", "id", "descr");
                
            }
        }

        








      


    }

  
}
