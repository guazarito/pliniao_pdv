using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{
    public partial class arruma_banco : Form
    {
        public arruma_banco()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            string select = "select * from vendas";
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao_velho;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();

            OdbcCommand cmd = new OdbcCommand(select, conn);
            OdbcDataReader dr = cmd.ExecuteReader();

            int i = 0;
           
            while (dr.Read())
            {
                i++;
            }

            MessageBox.Show(i.ToString());
                    
            conn.Close();
        }
    }
}
