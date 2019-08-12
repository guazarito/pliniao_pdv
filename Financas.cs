using System;
using System.Collections.Generic;

using System.Data;

using System.Windows.Forms;
using System.Data.Odbc;

namespace WindowsFormsApplication2
{
    

    public partial class frmFinancas : Form
    {
        conexao c = new conexao();

        int CboSelMes;
        String CboSelAno;

        public frmFinancas()
        {
            InitializeComponent();
            
            this.grdContasPagar.CellMouseClick += new DataGridViewCellMouseEventHandler(grdContasPagar_CellMouseClick);


            c.fillCombo(cboTipo, "select id, descricao from tipo_contas_pagar", "id", "descricao");
            cboTipo.SelectedIndex = -1;
            
            
            PreencheCboMes(cboMes);

          

            CboSelMes = int.Parse(DateTime.Now.Month.ToString());

           
            cboMes.SelectedValue = CboSelMes;

            

            PreencheCboAno(cboAno);
            CboSelAno =  DateTime.Now.Year.ToString();
            cboAno.SelectedText = CboSelAno;

        
            //isso preenche o grid contas a pagar:
            button1_Click(new Object(), new EventArgs()); //botao OK -> seleciona periodo 

         

            grdContasPagar.ClearSelection();

            grdOutrosValores.CellMouseClick += new DataGridViewCellMouseEventHandler(grdOutrosValores_CellMouseClick);


            //aba funcionarios
            c.fillCombo(cboCargo, "select id, descricao from cargos_func", "id", "descricao");
            cboCargo.SelectedIndex = -1;

            txtSalario.LostFocus+=new EventHandler(txtSalario_LostFocus);

            tabContas.SelectedIndexChanged +=new EventHandler(tabContas_SelectedIndexChanged);

            this.grdFuncionarios.CellMouseClick += new DataGridViewCellMouseEventHandler(grdFuncionarios_CellMouse);

            //aba despesas gerais
            grdDespesasGerais.CellMouseClick +=new DataGridViewCellMouseEventHandler(grdDespesasGerais_CellMouseClick);
           
           
        }

        Boolean isEditing = false; //provavelmente deve ser da aba ct pagar.. qndo clica no grid muda pra true.
        Boolean updating_func = false;
        Boolean updating_desdesas_gerais = false;

        public void grdDespesasGerais_CellMouseClick(Object sender, DataGridViewCellMouseEventArgs e)
        {
            updating_desdesas_gerais = true;
             int id_dg = 0;

             if (grdDespesasGerais.RowCount > 0)
             {
                 id_dg = int.Parse(grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());


                 String descricao = c.RetornaQuery("select descricao from despesas_gerais where id=" + id_dg.ToString(), "descricao");
                 double valor = double.Parse(c.RetornaQuery("select valor from despesas_gerais where id=" + id_dg.ToString(), "valor"));
                 DateTime data = Convert.ToDateTime(c.RetornaQuery("select convert(varchar,data,103) as data from despesas_gerais where id=" + id_dg.ToString(), "data"));

                 txtDescricaoDespesasGerais.Text = descricao;
                 txtValorDespesasGerais.Text = valor.ToString();
                 txtDataDespesasGerais.Value = data;

                 btnDeletarDespesasGerais.Visible = true;
             }

        }

        public void grdFuncionarios_CellMouse(Object sender, DataGridViewCellMouseEventArgs e)
        {
            updating_func = true;
            int id_func = 0;

            if (grdFuncionarios.RowCount > 0)
            {
                id_func = int.Parse(grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString());

                //btnLimparFunc_Click(new Object(), new EventArgs());
                grdOutrosValores.Rows.Clear();
                grdOutrosValores.Refresh();
                chkInativarFunc.Visible = false;

                String nome = c.RetornaQuery("select nome from funcionarios where id=" + id_func.ToString(), "nome");
                int cargo = int.Parse(c.RetornaQuery("select id_cargo from funcionarios where id=" + id_func.ToString(), "id_cargo"));
                double salario = double.Parse(c.RetornaQuery("select salario from funcionarios where id=" + id_func.ToString(), "salario"));
               
                String DiaPagto = c.RetornaQuery("select dia_pagto from funcionarios where id=" + id_func.ToString(), "dia_pagto");

                txtNomeFunc.Text = nome;
                cboCargo.SelectedValue = cargo;
                txtSalario.Text = salario.ToString().Replace(",",".");
                txtDiaPagto.Text = DiaPagto;

                //MessageBox.Show("até aqui veio");

                txtValorTotalFunc.Text = (salario + double.Parse(grdFuncionarios[5, grdFuncionarios.CurrentRow.Index].Value.ToString(), System.Globalization.CultureInfo.InvariantCulture)).ToString("#.#0").Replace(",", ".");

               // grdOutrosValores.Rows.Clear();
               // grdOutrosValores.Refresh();

                var conn = new OdbcConnection();
                conn.ConnectionString =
                              "Dsn=odbc_pliniao;" +
                              "Uid=sa;" +
                              "Pwd=chico110388@@;";

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao conectar no banco de dados.\n" + ex);
                }
                String query = "select descricao, convert(varchar,cast(valor as money),1) as valor from outros_gastos_funcionarios where id_func=" + id_func.ToString();
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    string[] row1 = new string[] { dr["descricao"].ToString(), dr["valor"].ToString() };
                    grdOutrosValores.Rows.Add(row1);
                }
                grdOutrosValores.ClearSelection();

                dr.Close();
                conn.Close();

                chkInativarFunc.Visible = true;
            }
        }

        public class Mes{
            public int iMes { get; set; }
            public String nMes {get; set; }
        }

        public class Ano
        {
            public String iAno { get; set; }
            public String nAno { get; set; }
        }

        public void PreencheCboMes(ComboBox cbo)
        {
            var dataSource = new List<Mes>();
            dataSource.Add(new Mes() { iMes = 1, nMes = "Janeiro" });
            dataSource.Add(new Mes() { iMes = 2, nMes = "Fevereiro" });
            dataSource.Add(new Mes() { iMes = 3, nMes = "Março" });
            dataSource.Add(new Mes() { iMes = 4, nMes = "Abril" });
            dataSource.Add(new Mes() { iMes = 5, nMes = "Maio" });
            dataSource.Add(new Mes() { iMes = 6, nMes = "Junho" });
            dataSource.Add(new Mes() { iMes = 7, nMes = "Julho" });
            dataSource.Add(new Mes() { iMes = 8, nMes = "Agosto" });
            dataSource.Add(new Mes() { iMes = 9, nMes = "Setembro" });
            dataSource.Add(new Mes() { iMes = 10, nMes = "Outubro" });
            dataSource.Add(new Mes() { iMes = 11, nMes = "Novembro" });
            dataSource.Add(new Mes() { iMes = 12, nMes = "Dezembro" });
            

            //Setup data binding
            cbo.DataSource = dataSource;
            cbo.DisplayMember = "nMes";
            cbo.ValueMember = "iMes";
        }

        public void PreencheCboAno(ComboBox cbo)
        {
            var dataSource = new List<Ano>();
            dataSource.Add(new Ano() { iAno = "2015", nAno = "2015" });
            dataSource.Add(new Ano() { iAno = "2016", nAno = "2016" });
            dataSource.Add(new Ano() { iAno = "2017", nAno = "2017" });
            dataSource.Add(new Ano() { iAno = "2018", nAno = "2018" });
            dataSource.Add(new Ano() { iAno = "2019", nAno = "2019" });
            dataSource.Add(new Ano() { iAno = "2020", nAno = "2020" });
            

            //Setup data binding
            cbo.DataSource = dataSource;

            cbo.DisplayMember = "nAno";
            cbo.ValueMember = "iAno";

            cbo.SelectedIndex = cbo.FindStringExact(DateTime.Now.ToString("yyyy"));


        }

        public void grdContasPagar_CellMouseClick(Object sender, EventArgs e)
        {
            btnEditar_Click(new Object(), new EventArgs());
            
            btnDeletar.Visible = true;
            btnDeletar.Enabled = true;

        }



        public void preenche_grid()
        {
           
            String sQuery;
            DateTime dtini = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + "1");
            DateTime dtfim = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + DateTime.DaysInMonth(int.Parse(CboSelAno), CboSelMes).ToString());

            String dtIni = dtini.ToString("dd/MM/yyyy");
            String dtFim = dtfim.ToString("dd/MM/yyyy");

           

            sQuery = "select id, tipo, convert(varchar, cast(valor as money),1) as valor, convert(varchar,vencimento,103) as vencimento from contas_pagar where convert(varchar, vencimento, 103) >='" + dtIni + "' and convert(varchar, vencimento, 103)<='" + dtFim + "' order by vencimento";

            


            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
            conn.Open();

           

            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);

            ds = new DataSet();

            

            dataAdapter.Fill(ds);

           

            grdContasPagar.ReadOnly = true;
            
            grdContasPagar.DataSource = ds.Tables[0];

            grdContasPagar.CurrentCell = null; 
            


            grdContasPagar.Columns[0].Visible = false;
            grdContasPagar.ClearSelection();
                      
           
            

           
            

            conn.Close();
        }

        private void btnAddTipo_Click(object sender, EventArgs e)
        {
            AddTipoConta frmAddTipo = new AddTipoConta(cboTipo);
            frmAddTipo.Show();
        }



        
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == -1 || txtValor.Text == "")
            {
                if (cboTipo.SelectedIndex == -1)
                {
                    MessageBox.Show("Selecione um tipo da lista", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (txtValor.Text == "")
                {
                    MessageBox.Show("Preencha o Valor", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtValor.Text = txtValor.Text.Replace(",", ".");

                int alerta = 0;
                int custo_fixo = 0;


                if (chkAlerta.Checked)
                {
                    alerta = 1;
                }

                if (chkCustoFixo.Checked)
                {
                    custo_fixo = 1;
                }
                double price;
                price = double.Parse(txtValor.Text, System.Globalization.CultureInfo.InvariantCulture);
                String sPrice = price.ToString().Replace(",", ".");

                DateTime dtVenc;
                dtVenc = DateTime.Parse(txtDtVenc.Text);

                bool gravar_12_registros = false;
                
                int id_ref = 0;
                   
                if (chkCustoFixo.Checked == true)
                {
                        
                        gravar_12_registros = true;
                        
                }

                if (!isEditing)
                {
                    try
                    {
                        c.ExecutaQuery("insert into contas_pagar values('" + cboTipo.GetItemText(cboTipo.SelectedItem).ToString() + "'," + sPrice + ",'" + dtVenc.ToString("MM-dd-yyyy") + "'," + alerta + "," + custo_fixo + ","+id_ref+")");
                        preenche_grid();

                        if (gravar_12_registros)
                        {
                            id_ref = int.Parse(c.RetornaQuery("select max(id) as id from contas_pagar", "id"));
                            DateTime dt1 = Convert.ToDateTime(dtVenc.ToString("yyyy-MM-dd"));
                            int i;
                            for (i = 0; i < 12; i++)
                            {
                                dt1 = dt1.AddMonths(1);
                                c.ExecutaQuery("insert into contas_pagar values('" + cboTipo.GetItemText(cboTipo.SelectedItem).ToString() + "'," + sPrice + ",'" + dt1.ToString("MM-dd-yyyy") + "'," + alerta + "," + custo_fixo + "," + id_ref + ")");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar no banco de dados\n" + ex);
                        return;
                    }

                    //string[] row1 = new string[] { cboTipo.GetItemText(cboTipo.SelectedItem).ToString(), "R$ " + price.ToString("#.#0"), txtDtVenc.Text };
                    //grdContasPagar.Rows.Add(row1);
                }
                else
                {
                    //codigo editar..........

                    try
                    {
                        int estava_ticado_custo_fixo = 0;
                        if (!gravar_12_registros)
                        {
                            estava_ticado_custo_fixo = int.Parse(c.RetornaQuery("select isDespesaFixa from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "isDespesaFixa"));

                            if (estava_ticado_custo_fixo != 0)
                            {
                                if (MessageBox.Show("Isso irá remover os lançamentos futuros registrados para essa conta. \nContinuar?", "Lançamentos Futuros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    String id_ref2 = c.RetornaQuery("select id_ref from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "id_ref");
                                    DateTime dataVenc = Convert.ToDateTime(grdContasPagar[3, grdContasPagar.CurrentRow.Index].Value.ToString());
                                    String dtvenc = dataVenc.ToString("yyyy-MM-dd");

                                    if (id_ref2 == "0")
                                    {
                                        id_ref2 = grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString();
                                    }


                                    c.ExecutaQuery("delete from contas_pagar where id_ref=" + id_ref2 + "and convert(date, vencimento, 103) >'" + dtvenc + "'");


                                    //c.ExecutaQuery("delete from contas_pagar where id_ref=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString());
                                }
                            }
                        }
                        else //esta marcado custo fixo
                        {
                            estava_ticado_custo_fixo = int.Parse(c.RetornaQuery("select isDespesaFixa from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "isDespesaFixa"));
                            if (estava_ticado_custo_fixo != 0)
                            {
                                if (MessageBox.Show("Deseja alterar, também, os lançamentos futuros registrados para essa conta?\n\nAperte 'não' para alterar apenas esse lançamento.", "Lançamentos Futuros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    String id_ref2 = c.RetornaQuery("select id_ref from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "id_ref");
                                    DateTime dataVenc = Convert.ToDateTime(grdContasPagar[3, grdContasPagar.CurrentRow.Index].Value.ToString());
                                    String dtvenc = dataVenc.ToString("yyyy-MM-dd");

                                    

                                    if (id_ref2 == "0")
                                    {
                                        id_ref2 = grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString();
                                    }


                                    // tem que atualizar a data de venc add 1 mes.. mas como ? (done)
                                    //sugest: selecionar quantas linhas tem o id_ref.. ai fazer um for com essa qtt e vai atualizando
                                    //Fazer o while do select e atualizar where id=idSel e id_ref=id_ref2...
                                    String query2 = "select id from contas_pagar where id_ref=" + id_ref2 + " and convert(date, vencimento, 103) >'" + dtvenc + "' order by id";
                                    var conn = new OdbcConnection();
                                    conn.ConnectionString =
                                                  "Dsn=odbc_pliniao;" +
                                                  "Uid=sa;" +
                                                  "Pwd=chico110388@@;";
                                    try
                                    {
                                        conn.Open();
                                    }
                                    catch (Exception exx)
                                    {
                                        MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
                                    }

                                    OdbcCommand cmd2 = new OdbcCommand(query2, conn);
                                    OdbcDataReader dr2 = cmd2.ExecuteReader();

                                    while (dr2.Read())
                                    {
                                          dtVenc = dtVenc.AddMonths(1);
                                          c.ExecutaQuery("update contas_pagar set tipo='" + cboTipo.GetItemText(cboTipo.SelectedItem).ToString() + "', valor=" + sPrice + ",vencimento= '" + dtVenc.ToString("MM-dd-yyyy") + "', alertar=" + alerta + ", isDespesaFixa=" + custo_fixo + "where id=" + dr2["id"] + " and id_ref=" + id_ref2); // + "and convert(date, vencimento, 103) >='" + dtvenc + "'");
                                    }
                                    
                                    dr2.Close();
                                    conn.Close();
                                    //aqui acaba a Sugest aí comentada acima...deu certo ;)
                                }
                            }
                            else //nao estava ticado custo fixo
                            {
                                if (gravar_12_registros)
                                {
                                    id_ref = int.Parse(grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString());
                                    DateTime dt1 = Convert.ToDateTime(dtVenc.ToString("yyyy-MM-dd"));
                                    int i;
                                    for (i = 0; i < 12; i++)
                                    {

                                        dt1 = dt1.AddMonths(1);
                                        c.ExecutaQuery("insert into contas_pagar values('" + cboTipo.GetItemText(cboTipo.SelectedItem).ToString() + "'," + sPrice + ",'" + dt1.ToString("MM-dd-yyyy") + "'," + alerta + "," + custo_fixo + "," + id_ref + ")");
                                    }
                                }
                            }
                        }
                        //aqui pega novamente a data do txtBox pq incrementei-a acima
                        dtVenc = DateTime.Parse(txtDtVenc.Text);
                        c.ExecutaQuery("update contas_pagar set tipo='" + cboTipo.GetItemText(cboTipo.SelectedItem).ToString() + "', valor=" + sPrice + ",vencimento= '" + dtVenc.ToString("MM-dd-yyyy") + "', alertar=" + alerta + ", isDespesaFixa=" + custo_fixo + "where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString());
                        preenche_grid();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao gravar no banco de dados\n" + ex);
                        return;
                    }

                    //...
                    isEditing = false;
                   
                }


                
               
                btnLimpar_Click(new Object(), new EventArgs());

            }
        }

        private void btnLimpar_Click(Object sender, EventArgs e)
        {
            cboTipo.SelectedValue = 0;
            txtValor.Text = "";
            txtDtVenc.Text = DateTime.Today.ToShortDateString();
            chkAlerta.Checked = false;
            chkCustoFixo.Checked = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            isEditing = true;

            String id_c_pagar;
            id_c_pagar = grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString();

            int id_tp_cp = int.Parse(c.RetornaQuery("select tp.id as 'id_tp' from contas_pagar cp left outer join tipo_contas_pagar tp on cp.tipo=tp.descricao where cp.tipo='"+grdContasPagar[1,grdContasPagar.CurrentRow.Index].Value.ToString()+"'","id_tp"));
            cboTipo.SelectedValue = id_tp_cp;

            decimal preco = Convert.ToDecimal(c.RetornaQuery("select valor from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "valor"));
            txtValor.Text = preco.ToString();
            
            txtDtVenc.Value = Convert.ToDateTime(c.RetornaQuery("select convert(varchar, vencimento, 103) as vencimento from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "vencimento"));

            int alertar = int.Parse(c.RetornaQuery("select alertar from contas_pagar where id="+ grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "alertar"));
            int contas_fixas = int.Parse(c.RetornaQuery("select isDespesaFixa from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "isDespesaFixa"));

            if (alertar == 1)
            {
                chkAlerta.Checked = true;
            }
            else
            {
                chkAlerta.Checked = false;
            }

            if (contas_fixas == 1)
            {
                chkCustoFixo.Checked = true;
            }
            else
            {
                chkCustoFixo.Checked = false;
            }

           
            btnDeletar.Enabled = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletar ?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int estava_ticado_custo_fixo = 0;

                estava_ticado_custo_fixo = int.Parse(c.RetornaQuery("select isDespesaFixa from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "isDespesaFixa"));

                if (estava_ticado_custo_fixo != 0)
                {
                    if (MessageBox.Show("Isso removerá também todos lançamentos futuros registrados para essa conta.\nDeseja Continuar?", "Lançamentos futuros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        String id_ref = c.RetornaQuery("select id_ref from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString(), "id_ref");
                        DateTime dataVenc = Convert.ToDateTime(grdContasPagar[3, grdContasPagar.CurrentRow.Index].Value.ToString());
                        String dtvenc = dataVenc.ToString("yyyy-MM-dd");

                        if (id_ref == "0")
                        {
                            id_ref = grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString();
                        }
                        

                        c.ExecutaQuery("delete from contas_pagar where id_ref=" + id_ref + "and convert(date, vencimento, 103) >='" + dtvenc +"'");



                        c.ExecutaQuery("delete from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString());

                    }
                }
                else
                {
                    c.ExecutaQuery("delete from contas_pagar where id=" + grdContasPagar[0, grdContasPagar.CurrentRow.Index].Value.ToString()); 
                }
                preenche_grid();
                btnDeletar.Enabled = false;
                isEditing = false;
                btnLimpar_Click(new Object(), new EventArgs());
            }
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            cboTipo.SelectedValue = 0;
            txtValor.Text = "";
            txtDtVenc.Text = DateTime.Today.ToShortDateString();
            chkAlerta.Checked = false;
            chkCustoFixo.Checked = false;
            btnDeletar.Enabled = false;
            isEditing = false;
            grdContasPagar.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            CboSelMes = int.Parse(cboMes.SelectedValue.ToString());
            CboSelAno = cboAno.SelectedValue.ToString();
           
            preenche_grid();
            btnLimpar_Click(new Object(), new EventArgs());
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            AddCargo cargos = new AddCargo(cboCargo);
            cargos.Show();
        }

        private void btnAddOutrosGatos_Click(object sender, EventArgs e)
        {
            if (txtOutrosGastos.Text != "" && txtValOutrosGastos.Text != "")
            {
                double valorOutrosGastos;
               
                txtValOutrosGastos.Text = txtValOutrosGastos.Text.Replace(",", ".");
                valorOutrosGastos = double.Parse(txtValOutrosGastos.Text,System.Globalization.CultureInfo.InvariantCulture);
                string[] row1 = new string[] { txtOutrosGastos.Text.ToString(), valorOutrosGastos.ToString() };
                grdOutrosValores.Rows.Add(row1);
                grdOutrosValores.ClearSelection();
                txtValOutrosGastos.Text = "";
                txtOutrosGastos.Text = "";
                CalculaPrecoTotalFuncionarios();
            }
            else
            {
                MessageBox.Show("Preencha os campos", "Preencha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void grdOutrosValores_CellMouseClick(Object sender, EventArgs e)
        {
            btnRemoverOutrosGastos.Enabled = true;
        }

        private void btnRemoverOutrosGastos_Click(object sender, EventArgs e)
        {
            grdOutrosValores.Rows.RemoveAt(grdOutrosValores.CurrentRow.Index);
            btnRemoverOutrosGastos.Enabled = false;
            txtValOutrosGastos.Text = "";
            txtOutrosGastos.Text = "";
            grdOutrosValores.ClearSelection();
            CalculaPrecoTotalFuncionarios();
        }

        public void CalculaPrecoTotalFuncionarios()
        {

            double salario = 0;
            
            if (txtSalario.Text != "")
            {
                salario = double.Parse(txtSalario.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
 
            double outros_valores = 0;

            if (grdOutrosValores.RowCount > 0)
            {
                for (int i = 0; i < grdOutrosValores.RowCount; i++)
                {
                    

                    String preco_to = grdOutrosValores.Rows[i].Cells[1].Value.ToString();
                    preco_to = preco_to.Replace(",", ".");
                    int posponto = preco_to.IndexOf(".");
                    preco_to = preco_to.Replace(".", "");
                    if (posponto > 0){
                        preco_to = preco_to.Insert(preco_to.Length - (preco_to.Length - posponto), ".");
                    }
               //    MessageBox.Show(preco_to);
                    outros_valores = outros_valores + double.Parse(preco_to, System.Globalization.CultureInfo.InvariantCulture);
                //   MessageBox.Show(outros_valores.ToString());
                }
            }
        //    MessageBox.Show(salario.ToString());
        //    MessageBox.Show((outros_valores + salario).ToString());
            txtValorTotalFunc.Text = (outros_valores + salario).ToString("#.#0");
        }

        public void txtSalario_LostFocus(Object sender, EventArgs e)
        {
            txtSalario.Text = String.Format("{0:n2}",txtSalario.Text.ToString().Replace(",", "."));
            CalculaPrecoTotalFuncionarios();
            
        }

        
         
        private void btnSalvaFuncionario_Click(object sender, EventArgs e)
        {
            String nome = txtNomeFunc.Text;
            int cargo = 0;
            if (cboCargo.SelectedValue != null)
            {
                cargo = int.Parse(cboCargo.SelectedValue.ToString());
            }

     //       MessageBox.Show("antes de converter: txtSalario.text:  "+ txtSalario.Text);

            double salario = 0;
            String sSalario="";
            if (txtSalario.Text != "")
            {
                salario = double.Parse(txtSalario.Text, System.Globalization.CultureInfo.InvariantCulture);
                sSalario = salario.ToString().Replace(",", ".");
            }

         //   MessageBox.Show("depois de converter para double: salario = double.Parse  " + salario);

            String DiaPagto = txtDiaPagto.Value.ToString("MM-dd-yyyy");


            if (nome != "" && cargo > 0 && salario > 0)
            {

                //salvando...
                if (!updating_func)
                {
                    int id_func = int.Parse(c.RetornaQuery("select isnull(max(id),0) as id from funcionarios", "id"));
                    id_func = id_func + 1;

                    int i;

//                    MessageBox.Show("salvando.... " + salario.ToString("#.#0").Replace(",", "."));

                    try
                    {

                        c.ExecutaQuery("insert into funcionarios values(" + id_func + ", '" + nome + "', " + cargo.ToString() + ", " + sSalario + ", '" + DiaPagto + "', 0)");
                        for (i = 0; i < grdOutrosValores.RowCount; i++)
                        {
                            c.ExecutaQuery("insert into outros_gastos_funcionarios values(" + id_func + ", '" + grdOutrosValores.Rows[i].Cells["descricao"].Value.ToString() + "', " + grdOutrosValores.Rows[i].Cells["valor"].Value.ToString().Replace(",",".") + ")");
                        }

                        
                        btnLimparFunc_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else //atualizando...
                {
                    String SgrdOVQuery;

                    String Valor;
                    
                    SgrdOVQuery = "begin transaction declare @id_func as integer set @id_func="+ grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString();
                    SgrdOVQuery += " delete from outros_gastos_funcionarios where id_func = @id_func ";

                    int i = 0;
                    int pospoint;
                    for (i = 0; i < grdOutrosValores.RowCount; i++)
                    {
                       Valor = grdOutrosValores.Rows[i].Cells["valor"].Value.ToString().Replace(",",".");
                       pospoint = Valor.IndexOf(".");
                       Valor = Valor.Replace(".", "");
                        if (pospoint > 0)
                        {
                            Valor = Valor.Insert(Valor.Length - (Valor.Length - pospoint), ".");
                        }
                   //    MessageBox.Show(Valor);
                       SgrdOVQuery += "insert into outros_gastos_funcionarios values(@id_func, '" + grdOutrosValores.Rows[i].Cells["descricao"].Value.ToString() + "', " + Valor + ") ";
                    }   
                    SgrdOVQuery += "commit";


                    int isInativo;

                    if (chkInativarFunc.Checked == true)
                    {
                        isInativo = 1;
                        if (MessageBox.Show("Inativar um funcionário o tira automaticamente do relatório de faturamento mensal.\n\nDeseja excluir o lançamento desse funcionário do relatório de faturamento do mês atual?\n\nPressione SIM para excluir e NAO para manter.\n\nEm caso de dúvidas, contate o programador fodão que fez o programa", "Faturamento Mensal", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //YES
                            //excluir desse mes e todos futuros...
                            //id func = grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString();
                            String data_ini = DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-01";
                            c.ExecutaQuery("delete from pagar_funcionarios where id_func=" + grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString() + " and convert(date, data_pagto, 103) >= '" + data_ini + "'");
                        }
                        else
                        {
                            //NO
                            //manter esse mes e apagar os futuros..
                            String dia_pagto = c.RetornaQuery("select dia_pagto from funcionarios where id=" + grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString(), "dia_pagto");
                            c.ExecutaQuery("delete from pagar_funcionarios where id_func=" + grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString() + " and convert(date, data_pagto, 103) > '" + DateTime.Today.Year.ToString() + "-" + DateTime.Today.Month.ToString() + "-" + dia_pagto + "'");
                        }
                    }
                    else
                    {
                        isInativo = 0;
                    }

                  //  MessageBox.Show("atualizando .... " + salario.ToString("#.#0").Replace(",", "."));

                    try
                    {
                        String Sal = txtSalario.Text.Replace(",",".");
                        int posponto = Sal.IndexOf(".");
                        Sal = Sal.Replace(".", "");
                        if (posponto > 0)
                        {
                            Sal = Sal.Insert(Sal.Length - (Sal.Length - posponto), ".");
                        }

                     //   MessageBox.Show(Sal);
                        c.ExecutaQuery(SgrdOVQuery);
                        c.ExecutaQuery("update funcionarios set nome= '" + nome + "', id_cargo= " + cargo.ToString() + ", salario=" + Sal + ", dia_pagto='" + DiaPagto + "', isInativo=" + isInativo + " where id="+ grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString());
                        btnLimparFunc_Click(new Object(), new EventArgs());


                        //String MesAtual = DateTime.Today.Month.ToString("#0");
                        //String AnoAtual = DateTime.Today.Year.ToString();
                        //String DaysNoMonth = DateTime.DaysInMonth(int.Parse(AnoAtual), int.Parse(MesAtual)).ToString();
                       
                        //if (MessageBox.Show("Deseja fazer essas alterações para o mês atual ou apenas para os meses futuros?" + "\n" + "Pressione SIM para alterar o relatório de faturamento do mês atual\nPressione NAO para alterar apenas os relatorios futuros", "Faturamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        //{
                        //    c.ExecutaQuery("delete from pagar_funcionarios where id_func=" + grdFuncionarios[0, grdFuncionarios.CurrentRow.Index].Value.ToString() + " and data_pagto >= '" + AnoAtual + "-" + MesAtual + "-01' and data_pagto <= '" + AnoAtual + "-" + MesAtual + "-" + DaysNoMonth + "'");
                        //}

                        
                    }
                      
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                 }

                

                



                updating_func = false;
                carregaGridFunc();

                AlteraVersao pagto_func = new AlteraVersao();
                //pagto_func.gera_pagto_funcionario();
            }
            else
            {
                MessageBox.Show("Preencha os campos", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimparFunc_Click(object sender, EventArgs e)
        {
            txtNomeFunc.Text = "";
            //cboCargo.Text = "";
            cboCargo.SelectedValue = 0;
            txtSalario.Text = "";
            txtDiaPagto.Value = DateTime.Now;
            txtValorTotalFunc.Text = "";
            txtOutrosGastos.Text = "";
            txtValOutrosGastos.Text = "";
            grdFuncionarios.ClearSelection();
            grdOutrosValores.Rows.Clear();
            chkInativarFunc.Visible = false;
            chkInativarFunc.Checked = false;
            updating_func = false;
        }

        public void carregaGridFunc()
        {
            
            DateTime dtini = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + "1");
            DateTime dtfim = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + DateTime.DaysInMonth(int.Parse(CboSelAno), CboSelMes).ToString());

            String dtIni = dtini.ToString("yyyy-MM-dd");
            String dtFim = dtfim.ToString("yyyy-MM-dd");


            grdFuncionarios.Rows.Clear();
            grdFuncionarios.Refresh();

            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388@@;";

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + e);
            }
            String query = "select f.id, nome, cf.descricao as 'cargo', convert(varchar,dia_pagto,103) as 'dia_pagto', convert(varchar,cast(salario as money),1) as 'salario' from funcionarios f left outer join cargos_func cf on f.id_cargo=cf.id where convert(date, dia_pagto, 103) >='" + dtIni + "' and convert(date, dia_pagto, 103)<='" + dtFim + "' and f.isInativo<>1 order by dia_pagto,cargo, nome ";
            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string[] row1 = new string[] { dr["id"].ToString(), dr["nome"].ToString(), dr["cargo"].ToString(), dr["dia_pagto"].ToString(), dr["salario"].ToString(), "" };
                grdFuncionarios.Rows.Add(row1);
            }

            dr.Close();
            conn.Close();

            int i;
            conexao c = new conexao();
            for (i = 0; i < grdFuncionarios.RowCount; i++)
            {
                grdFuncionarios[5, i].Value = c.RetornaQuery("select convert(varchar,cast(isnull(sum(valor),0) as money),1) as outros_gastos from outros_gastos_funcionarios where id_func=" + grdFuncionarios.Rows[i].Cells["id_func"].Value.ToString() + "group by id_func", "outros_gastos");
            }
            grdFuncionarios.ClearSelection();
        }

        public void tabContas_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabContas.SelectedIndex == 1) //funcionarios
            {
                PreencheCboMes(cboFuncMes);
                CboSelMes = int.Parse(DateTime.Now.Month.ToString());
                cboFuncMes.SelectedValue = CboSelMes;

                PreencheCboAno(cboFuncAno);
                CboSelAno = DateTime.Now.Year.ToString();
                cboFuncAno.SelectedText = CboSelAno;

                carregaGridFunc();
            }
            else if (tabContas.SelectedIndex == 2) //despesas gerais
            {
                PreencheCboMes(cboMesDespesasGerais);
                CboSelMes = int.Parse(DateTime.Now.Month.ToString());
                cboMesDespesasGerais.SelectedValue = CboSelMes;

                PreencheCboAno(cboAnoDespesasGerais);
                CboSelAno = DateTime.Now.Year.ToString();
                cboAnoDespesasGerais.SelectedText = CboSelAno;

                preencheGridDespesasGerais();
            }
        }

        private void formLoad(object sender, EventArgs e)
        {
            grdContasPagar.ClearSelection();
        }

        private void btnSalvarDespesasGerais_Click(object sender, EventArgs e)
        {
            if (txtDescricaoDespesasGerais.Text != "" && txtValorDespesasGerais.Text != "")
            {
                txtValorDespesasGerais.Text = txtValorDespesasGerais.Text.Replace(",", ".");
                if (!updating_desdesas_gerais) //salvando ....
                {
                    try
                    {
                        double price;
                        price = double.Parse(txtValorDespesasGerais.Text, System.Globalization.CultureInfo.InvariantCulture);
                        String sPrice = price.ToString().Replace(",", ".");
                       // MessageBox.Show(price.ToString());
                       // MessageBox.Show(price.ToString("#.#0"));
                        c.ExecutaQuery("insert into despesas_gerais values('" + txtDescricaoDespesasGerais.Text.ToString() + "'," + sPrice + ",'" + txtDataDespesasGerais.Value.ToString("MM-dd-yyyy") + "')");
                        preencheGridDespesasGerais();
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else //atualizando....
                {
                    try
                    {
                        double price;
                        price = double.Parse(txtValorDespesasGerais.Text, System.Globalization.CultureInfo.InvariantCulture);
                        String sPrice = price.ToString().Replace(",", ".");
                     //   MessageBox.Show(sPrice);
                    //    MessageBox.Show(price.ToString("#.#0"));
                        c.ExecutaQuery("update despesas_gerais set descricao='" + txtDescricaoDespesasGerais.Text.ToString() + "', valor=" + sPrice + ", data='" + txtDataDespesasGerais.Value.ToString("MM-dd-yyyy") + "' where id="+ grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());
                        preencheGridDespesasGerais();
                        btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos", "erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void preencheGridDespesasGerais()
        {
            String sQuery;
            DateTime dtini = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + "1");
            DateTime dtfim = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + DateTime.DaysInMonth(int.Parse(CboSelAno), CboSelMes).ToString());

            String dtIni = dtini.ToString("yyyy-MM-dd");
            String dtFim = dtfim.ToString("yyyy-MM-dd");



            sQuery = "select id, descricao as 'Descrição', valor as 'Valor', convert(varchar,data,103) as 'Data Compra' from despesas_gerais where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' order by data";




            //PREENCHE O GRID..
            DataSet ds = null;
            string select = sQuery;
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388@@;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            ds = new DataSet();

            dataAdapter.Fill(ds);

            grdDespesasGerais.ReadOnly = true;

            grdDespesasGerais.DataSource = ds.Tables[0];

            grdDespesasGerais.CurrentCell = null;



            grdDespesasGerais.Columns[0].Visible = false;
            grdDespesasGerais.ClearSelection();







            conn.Close();
        }

        private void btnLimparDespesasGerais_Click(object sender, EventArgs e)
        {
            txtDataDespesasGerais.Text = DateTime.Today.ToShortDateString();
            txtDescricaoDespesasGerais.Text = "";
            txtValorDespesasGerais.Text = "";
            grdDespesasGerais.ClearSelection();
            btnDeletarDespesasGerais.Visible = false;
            updating_desdesas_gerais = false;
        }

        private void btnDeletarDespesasGerais_Click(object sender, EventArgs e)
        {
            if (grdDespesasGerais.RowCount > 0)
            {
                if(MessageBox.Show("Deletar?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    c.ExecutaQuery("delete from despesas_gerais where id="+ grdDespesasGerais[0, grdDespesasGerais.CurrentRow.Index].Value.ToString());
                    preencheGridDespesasGerais();
                    btnLimparDespesasGerais_Click(new Object(), new EventArgs());
                    updating_desdesas_gerais = false;
                }
            }
        }

        private void btnSelPeriodoDespesasGerais_Click(object sender, EventArgs e)
        {
            CboSelMes = int.Parse(cboMes.SelectedValue.ToString());
            CboSelAno = cboAno.SelectedValue.ToString();

            preencheGridDespesasGerais();
            btnLimparDespesasGerais_Click(new Object(), new EventArgs());
        }

        private void btnFuncOK_Click(object sender, EventArgs e)
        {
            CboSelMes = int.Parse(cboFuncMes.SelectedValue.ToString());
            CboSelAno = cboFuncAno.SelectedValue.ToString();

            carregaGridFunc();
            btnLimpar_Click(new Object(), new EventArgs());
        }
    }
        
}
