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
    public partial class frmFaturamento : Form
    {
        int CboSelMes;
        String CboSelAno;
        conexao c = new conexao();
        String dtIni;
        String dtFim;

        public frmFaturamento()
        {
            InitializeComponent();

            //combo boxes Mes e Ano..........................................................


            PreencheCboMes(cboMes);
            CboSelMes = int.Parse(DateTime.Now.Month.ToString());
            cboMes.SelectedValue = CboSelMes;

            PreencheCboAno(cboAno);
            CboSelAno = DateTime.Now.Year.ToString();
            cboAno.SelectedText = CboSelAno;

            DateTime dtini = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + "1");
            DateTime dtfim = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + DateTime.DaysInMonth(int.Parse(CboSelAno), CboSelMes).ToString());

            dtIni = dtini.ToString("yyyy-MM-dd");
            dtFim = dtfim.ToString("yyyy-MM-dd");

            PreencheCboMes(cboMes);
            CboSelMes = int.Parse(DateTime.Now.Month.ToString());
            cboMes.SelectedValue = CboSelMes;

            PreencheCboAno(cboAno);
            CboSelAno = DateTime.Now.Year.ToString();
            cboAno.SelectedText = CboSelAno;
            //combo boxes Mes e Ano................................................

            preenche_grid();
  

        }


        public void preenche_grid()
        {
            DateTime dtini = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + "1");
            DateTime dtfim = Convert.ToDateTime(CboSelAno + "-" + CboSelMes.ToString() + "-" + DateTime.DaysInMonth(int.Parse(CboSelAno), CboSelMes).ToString());

            dtIni = dtini.ToString("yyyy-MM-dd");
            dtFim = dtfim.ToString("yyyy-MM-dd");

            treeView1.Nodes.Clear();

            //vendas.......................................................................................

            String q = c.RetornaQuery("select concat('R$ ',convert(varchar, cast(sum(preco_total-(preco_total*desconto)) as money),1)) as 'preco_total' from vendas where isCancelado<>1 and isnull(is_pagto_pendente,0)<>1 and convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "'", "preco_total");
            if (q == "R$ ")
            {
                q = "0";
            }
            double total_vendas = double.Parse(q.Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
            TreeNode tnVendas = new TreeNode("Vendas:  R$" + String.Format("{0:n2}", total_vendas).Replace(",", "."));

            tnVendas.ForeColor = Color.DarkGreen;
            treeView1.Nodes.Add(tnVendas);


            String query = "select convert(varchar, data, 103) as 'data', concat('R$ ',convert(varchar, cast(sum(preco_total-(preco_total*desconto)) as money),1)) as 'total_dia' from vendas where isCancelado<>1 and isnull(is_pagto_pendente,0)<>1 and convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' group by convert(varchar, data, 103)";
            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388;";

            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }

            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                tnVendas.Nodes.Add(dr["data"] + "  " + dr["total_dia"]);
            }

            dr.Close();
            conn.Close();

            //fim vendas..........................................................

            //pagtos pendentes
            String q5 = c.RetornaQuery("select concat('R$ ',convert(varchar, cast(sum(preco_total-(preco_total*desconto)) as money),1)) as 'preco_total' from vendas where isCancelado<>1 and isnull(is_pagto_pendente,0)=1 and convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "'", "preco_total");
            if (q5 == "R$ ")
            {
                q5 = "0";
            }
            double total_ped_pendentes = double.Parse(q5.Replace("R$ ", ""), System.Globalization.CultureInfo.InvariantCulture);
            TreeNode tnPedPendentes = new TreeNode("Pagamentos Pendentes:  R$" + String.Format("{0:n2}", total_ped_pendentes).Replace(",", "."));

            tnPedPendentes.ForeColor = Color.DarkGreen;
            treeView1.Nodes.Add(tnPedPendentes);


            String query5 = "select convert(varchar, data, 103) as 'data', concat('R$ ',convert(varchar, cast(sum(preco_total-(preco_total*desconto)) as money),1)) as 'total_dia' from vendas where isCancelado<>1 and isnull(is_pagto_pendente,0)=1 and convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' group by convert(varchar, data, 103)";
            
            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }

            OdbcCommand cmd5 = new OdbcCommand(query5, conn);
            OdbcDataReader dr5 = cmd5.ExecuteReader();

            while (dr5.Read())
            {
                tnPedPendentes.Nodes.Add(dr5["data"] + "  " + dr5["total_dia"]);
            }

            dr5.Close();
            conn.Close();

            //fim pagtos pendentes




            //funcionarios........................................................

            double total_gastos_func = 0;

            // String query2 = "select pf.valor_total_func as 'total_gasto_func', f.salario, f.nome from funcionarios f left join pagar_funcionarios pf on f.id=pf.id_func where f.isInativo<>1 and convert(date, pf.data_pagto, 103) >='" + dtIni + "' and convert(date, pf.data_pagto, 103)<='" + dtFim + "' order by f.nome";
            String query2 = "select isnull(sum(og.valor),0)+isnull(f.salario,0) as 'total_gasto_func', f.id as 'id_func', f.dia_pagto, f.nome from funcionarios f left join outros_gastos_funcionarios og on f.id=og.id_func where f.isInativo<>1 and convert(date, f.dia_pagto, 103) >='" + dtIni + "' and convert(date, f.dia_pagto, 103)<='" + dtFim + "' group by f.id, f.salario, f.nome, f.dia_pagto order by f.nome";


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
            TreeNode tnFunc = new TreeNode();
            double total_gastos_func_aux = 0;
            String sTotal = "";

            while (dr2.Read())
            {

               // MessageBox.Show("salario: " + dr2["salario"].ToString() + " total: " + dr2["total_gasto_func"].ToString());

                sTotal = dr2["total_gasto_func"].ToString().Replace(",", ".");
                Double Tot = double.Parse(sTotal, System.Globalization.CultureInfo.InvariantCulture);
                 
              //  MessageBox.Show( " tot: " + Tot.ToString());

                total_gastos_func = total_gastos_func + Tot;
                tnFunc.Nodes.Add(dr2["nome"] + "  " + "R$ " + total_gastos_func.ToString());

               // MessageBox.Show("total gasto func " + total_gastos_func);

                total_gastos_func_aux = total_gastos_func_aux + total_gastos_func;
                total_gastos_func = 0;

              //   MessageBox.Show("total gasto func aux " + total_gastos_func_aux);
            }

            dr2.Close();
            conn.Close();


            tnFunc.Text = "Pagamento de Funcionários:  R$ " + String.Format("{0:n2}", total_gastos_func_aux).Replace(",", ".");
            tnFunc.ForeColor = Color.DarkRed;

            treeView1.Nodes.Add(tnFunc);

            //fim funcionarios....................................................

            //contas a pagar......................................................

            String q2 = c.RetornaQuery("select concat('R$ ',convert(varchar, cast(sum(valor) as money),1)) as 'valor_total_ct_paga' from contas_pagar where convert(date, vencimento, 103) >='" + dtIni + "' and convert(date, vencimento, 103)<='" + dtFim + "'", "valor_total_ct_paga").Replace(",", "");

            if (q2 == "R$ ")
            {
                q2 = "0";
            }


            String tota_ct = q2.Replace("R$ ", "");
            tota_ct = tota_ct.Replace(",", ".");

            double total_ct_pagar = double.Parse(tota_ct, System.Globalization.CultureInfo.InvariantCulture);

          

            TreeNode tnCtPagar = new TreeNode("Contas a pagar:  " + String.Format("{0:n2}", q2).Replace(",", "."));
            tnCtPagar.ForeColor = Color.DarkRed;
            treeView1.Nodes.Add(tnCtPagar);


            String query3 = "select tipo, concat('R$ ',convert(varchar, cast(valor as money),1)) as 'valor' from contas_pagar where convert(date, vencimento, 103) >='" + dtIni + "' and convert(date, vencimento, 103)<='" + dtFim + "' order by tipo";

            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }

            OdbcCommand cmd3 = new OdbcCommand(query3, conn);
            OdbcDataReader dr3 = cmd3.ExecuteReader();

            while (dr3.Read())
            {
                tnCtPagar.Nodes.Add(dr3["tipo"] + "  " + dr3["valor"]);
            }

            dr3.Close();
            conn.Close();
            //fim contas a pagar..................................................

            //despesas gerais......................................................

            String q4 = c.RetornaQuery("select concat('R$ ',convert(varchar, cast(sum(valor) as money),1)) as 'valor' from despesas_gerais where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "'", "valor").Replace(",", "");

            if (q4 == "R$ ")
            {
                q4 = "0";
            }

            q4 = q4.Replace("R$ ", "");
            
            double total_despesas_gerais = double.Parse(q4, System.Globalization.CultureInfo.InvariantCulture);


            TreeNode tnDespesasGerais = new TreeNode("Despesas Gerais:  " + String.Format("{0:n2}", q4).Replace(",", "."));
            tnDespesasGerais.ForeColor = Color.DarkRed;
            treeView1.Nodes.Add(tnDespesasGerais);


            String query4 = "select descricao, concat('R$ ',convert(varchar, cast(valor as money),1)) as 'valor' from despesas_gerais where convert(date, data, 103) >='" + dtIni + "' and convert(date, data, 103)<='" + dtFim + "' order by descricao";

            try
            {
                conn.Open();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + exx);
            }

            OdbcCommand cmd4 = new OdbcCommand(query4, conn);
            OdbcDataReader dr4 = cmd4.ExecuteReader();

            while (dr4.Read())
            {
                tnDespesasGerais.Nodes.Add(dr4["descricao"] + "  " + dr4["valor"]);
            }

            dr4.Close();
            conn.Close();
            //fim despesas gerais.................................................

            double lucro;
            String sLucro;

            //MessageBox.Show("total vendas: " + total_vendas.ToString());
            //MessageBox.Show("total_gastos_func_aux: " + total_gastos_func_aux.ToString());
            //MessageBox.Show("total_ct_pagar: " + total_ct_pagar.ToString());
            //MessageBox.Show("total_despesas_gerais: " + total_despesas_gerais.ToString());

            lucro = (total_vendas + total_ped_pendentes) - (total_gastos_func_aux + total_ct_pagar + total_despesas_gerais);

            //MessageBox.Show("lucro: " + lucro.ToString());

            sLucro = "R$ " + String.Format("{0:n2}", lucro);

           // MessageBox.Show("slucro: " + sLucro);

            label1.Text = "Lucro Líquido: " + sLucro;

            if (lucro > 0)
            {
                label1.ForeColor = Color.DarkGreen;
            }
            else
            {
                label1.ForeColor = Color.DarkRed;
            }
            
        }

        public class Mes
        {
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
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CboSelMes = int.Parse(cboMes.SelectedValue.ToString());
            CboSelAno = cboAno.SelectedValue.ToString();

            preenche_grid();
        }

    }
}
