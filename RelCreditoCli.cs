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
    public partial class RelCreditoCli : Form
    {
        public RelCreditoCli()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                string filtro;
                filtro = "and convert(date, data, 103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "'";
                preenche_grid(grdHistoricoCreditoDado,  filtro);
            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL que a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        public void preenche_grid(DataGridView grd, string filtro = "")
        { }

     
    }
}
