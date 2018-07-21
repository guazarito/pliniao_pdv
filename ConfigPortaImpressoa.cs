using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ConfigPortaImpressoa : Form
    {
        public ConfigPortaImpressoa()
        {
           InitializeComponent();

            if (File.Exists(@"c:\pliniao\confiprinterport.dat"))
            {

                String porta = File.ReadAllText(@"c:\pliniao\confiprinterport.dat");

                txtPorta.Text = porta;

            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try {
                FileStream fs = File.Create(@"c:\pliniao\confiprinterport.dat");
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(txtPorta.Text.ToUpper());
                txtPorta.Text = txtPorta.Text.ToUpper();
                sw.Close();
                MessageBox.Show("Concluído");
            }
            catch(Exception ev)
            {
                MessageBox.Show("erro criando arquivo dat " + ev.Message);
            }


        }
    }
}
