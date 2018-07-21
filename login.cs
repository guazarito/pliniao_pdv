using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            conexao Con = new conexao();

            //MessageBox.Show(Con.ExecutaQuery("select id from vendas"));
        }
    }
}
