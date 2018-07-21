using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class preferencias : Form
    {
        public preferencias()
        {
            InitializeComponent();

   

            if (File.Exists(@"c:\pliniao\prefmaq.dat"))
            {

                String tpMaq = File.ReadAllText(@"c:\pliniao\prefmaq.dat");

                if (tpMaq == "SER")
                {
                    rdoTpServidor.Checked = true;
                }else if (tpMaq == "EST")
                {
                    rdTpEstacao.Checked = true;
                }

            }

            conexao c = new conexao();

            txtTempo.Text = c.RetornaQuery("select isnull(tempo,0) as tempo from tempo_fila_impressao", "tempo");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = File.Create(@"c:\pliniao\prefmaq.dat");
                StreamWriter sw = new StreamWriter(fs);
                String sTpMaq = "SER";
                if (rdTpEstacao.Checked)
                {
                    sTpMaq = "EST";
                }
                sw.Write(sTpMaq); 
                sw.Close();         
            }
            catch (Exception ev)
            {
                MessageBox.Show("erro criando arquivo dat " + ev.Message);
            }

            conexao c = new conexao();

            try {
                c.ExecutaQuery("update tempo_fila_impressao set tempo=" + txtTempo.Text + " where id=1");
            }
            catch
            {
                MessageBox.Show("insira valor numerico");
            }
            MessageBox.Show("Concluído");
        }
    }
}
