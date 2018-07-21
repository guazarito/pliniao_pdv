using System;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{
    public partial class frmCreditoCli : Form
    {
        conexao c = new conexao();
        string id_cli;

        public frmCreditoCli()
        {
            InitializeComponent();
            c.fillCombo(this.txtNomeCli, "select * from clientes order by nome", "id", "nome");
            txtNomeCli.SelectedValue = 0;


        }


        public void preenche_grid(DataGridView grd, string id_cli, string filtro="")
        {

            String sQuery;
            String tabela;
            String tipo_credito;
            String sinal_operacao;
            
            if(grd.Name == "grdHistoricoCreditoDado")
            {
                tabela = "historico_credito_dado";
                tipo_credito = "Dado";
                sinal_operacao = "+";
                sQuery = "select concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', obs as 'Obs' from " + tabela + " where id_cliente=" + id_cli + filtro + " order by data desc";

            }
            else
            {
                tabela = "historico_credito_utilizado";
                tipo_credito = "Utilizado";
                sinal_operacao = "-";
                sQuery = "select concat('" + sinal_operacao + "  R$ ',convert(varchar, cast(valor_credito as money),1)) as 'Valor do Crédito " + tipo_credito + "', data as 'Data / Hora', id_venda as Pedido, obs as 'Obs' from " + tabela + " where id_cliente=" + id_cli + filtro + " order by data desc";

            }


            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();

            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);

            ds = new DataSet();

            dataAdapter.Fill(ds);

            grd.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grd.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grd.ReadOnly = true;

            grd.DataSource = ds.Tables[0];

            grd.CurrentCell = null;

            //grd.Columns[0].Visible = false;
            grd.ClearSelection();

            conn.Close();

            calculaTotalPeriodo(grd, filtro);
        }

        private void txtNomeCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtNomeCli.SelectedIndex != 0 && txtNomeCli.SelectedIndex != -1)
            {

                //para dar efeitinho que mudou.. da uma piscadela
                groupBox1.Visible = false;
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                tabControl1.Visible = false;
                //---

                id_cli = txtNomeCli.SelectedValue.ToString();
                groupBox1.Visible = true;
                groupBox2.Visible = true;
                groupBox3.Visible = true;
                tabControl1.Visible = true;

                preenche_grid(grdHistoricoCreditoDado, id_cli);
                preenche_grid(grdHistoricoCreditosUsados, id_cli);


                if (grdHistoricoCreditoDado.RowCount > 0)
                {
                    groupBox2.Visible = true;
                }

                groupBox3.Visible = true;

                getSaldoCli();

            }
        }

        public void calculaTotalPeriodo(DataGridView grd, string filtro = "")
        {
            string tabela;
            TextBox txt;

            if (grd.Name == "grdHistoricoCreditoDado")
            {
                tabela = "historico_credito_dado";
                txt = txtTotalPeriodoDado;
            }else
            {
                tabela = "historico_credito_utilizado";
                txt = txtTotalPeriodoUsado;
            }
               
            string query = "select convert(varchar, cast(isnull(sum(valor_credito),0) as money),1) as 'totalPeriodo' from "+ tabela +" where id_cliente = " + id_cli + " and (obs='' or isnull(obs,'')='') " + filtro;
            txt.Text = c.RetornaQuery(query, "totalPeriodo");
        }

        public void getSaldoCli()
        {
            string saldo;

            saldo = c.RetornaQuery("select convert(varchar, cast(isnull(saldo,0) as money),1) as 'saldo' from saldo_credito_cli where id_cliente=" + id_cli, "saldo");

            txtSaldo.Text = saldo;
        }

        private void btnAddCredito_Click(object sender, EventArgs e)
        {
            //double valor_credito_dado;
            string sValor;
            string data;


            if (txtValorDado.Text == "")
            {
                MessageBox.Show("Valor não pode ser branco");
            }
            else
            {
                data = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
                sValor = txtValorDado.Text.Replace(",", ".");


                c.ExecutaQuery("insert into historico_credito_dado values(" + id_cli + "," + sValor + ",'" + data + "', '')");


                preenche_grid(grdHistoricoCreditoDado, id_cli);
                txtValorDado.Text = "";
                groupBox2.Visible = true;
                getSaldoCli();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //eu viajei.. pq eh possivel adicionar valor ao grid "utilizados"
            //fiquei com preguica de arrumar.. vou desabilitar o botao e boa!

            string tab_titulo = tabControl1.SelectedTab.ToString();
           // DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                btnAddCredito.Enabled = true;
            }
            else
            {
                btnAddCredito.Enabled = false;
            }

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            string tab_titulo = tabControl1.SelectedTab.ToString();
            DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                grid = grdHistoricoCreditoDado;
            }else
            {
                grid = grdHistoricoCreditosUsados;
            }

            String dtInic = dtIni.Value.ToString("yyyy-MM-dd");
            String dtFinal = dtFim.Value.ToString("yyyy-MM-dd");

            if (Convert.ToDateTime(dtInic) <= Convert.ToDateTime(dtFinal))
            {
                string filtro;
                filtro = "and convert(date, data, 103) >= '" + dtInic + "' and convert(date, data,103) <= '" + dtFinal + "'";
                preenche_grid(grid, id_cli, filtro);
            }
            else
            {
                MessageBox.Show("A data inicial deve ser MENOR OU IGUAL que a data final !", "Erro datas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtValorDado.Text = "";
        }

        private void btnLimpaFiltro_Click(object sender, EventArgs e)
        {
            string tab_titulo = tabControl1.SelectedTab.ToString();
            DataGridView grid;

            if (tab_titulo == "TabPage: {Histórico créditos dados}")
            {
                grid = grdHistoricoCreditoDado;
            }
            else
            {
                grid = grdHistoricoCreditosUsados;
            }

            preenche_grid(grid, id_cli);
        }

        private void abrePedido(object sender, DataGridViewCellEventArgs e)
        {
            int idp = Convert.ToInt32(grdHistoricoCreditosUsados[2, grdHistoricoCreditosUsados.CurrentRow.Index].Value);
            frmVerVendas frm = new frmVerVendas(idp);
            
            frm.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            txtNomeCli_SelectedIndexChanged(sender, e);
        }
    }
}
