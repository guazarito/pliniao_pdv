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
    public partial class senha_form : Form
    {
        Form frm;
        public senha_form(Form form)
        {
            InitializeComponent();
            
            this.textBox1.KeyDown += new KeyEventHandler(textBox1_KeyDown);

            this.Show();

            frm = form;
        }

        public void textBox1_KeyDown(Object sender, KeyEventArgs e)
        {
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

               // frmRel newMDIChild4 = new frmRel();
                frm.MdiParent = this.ParentForm;
                frm.Show();

                this.Close();
           
            }
            else
            {
                MessageBox.Show("Senha incorreta", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
