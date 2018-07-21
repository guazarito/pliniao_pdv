using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmSenha : Form
    {
        public frmSenha()
        {
            InitializeComponent();

           

            AlteraVersao altera = new AlteraVersao();

            

            this.textBox1.KeyDown +=new KeyEventHandler(textBox1_KeyDown);
        }


        public void textBox1_KeyDown(Object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Enter)
            {
                btnAcesso_Click(new Object(), new EventArgs());
            }
        }


        private void btnAcesso_Click(object sender, EventArgs e)
        {
            conexao c = new conexao();
            if (textBox1.Text == c.RetornaQuery("select senha from senha_form", "senha"))
            {
                MDIParent1 FrmMain = new MDIParent1();
                FrmMain.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Senha incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

    }
}
