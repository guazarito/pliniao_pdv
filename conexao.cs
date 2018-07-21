using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

using System.IO;

namespace WindowsFormsApplication2
{


    public class conexao
    {
        public Boolean ExecutaQuery(String query)
        {
            //MessageBox.Show(query);

            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388;";

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + e);
                return false;
            }

            OdbcCommand cmd = new OdbcCommand(query, conn);
            OdbcDataReader dr = cmd.ExecuteReader();
            return true;

        }

        public string RetornaQuery(String query, String campo)
        {

            //MessageBox.Show(query);

            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388;";

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + e);
            }

            try
            {
                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    return dr[campo].ToString();
                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(query + "\n\n" + e.ToString());
                FileStream fs = File.Create(@"c:\pliniao\query.txt");
                StreamWriter sw = new StreamWriter(fs);
                String sTpMaq;

                sTpMaq = query;

                sw.Write(sTpMaq);
                sw.Close();
            }

            return "0";


        }

        public int RetornaIdVendaAtual()
        {
            conexao c = new conexao();
            int id = Convert.ToInt32(c.RetornaQuery("select isnull(max(id),0) as id from vendas", "id"));
            id++;
            return id;
        }

        public void fillCombo(ComboBox nome_combo, String query, String value, String display)
        {
            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();

            String scom = query;
            OdbcDataAdapter da = new OdbcDataAdapter(scom, conn);
            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)


            nome_combo.DataSource = null;
            da.Fill(dtResultado);
            nome_combo.DataSource = dtResultado;
            nome_combo.ValueMember = value;
            nome_combo.DisplayMember = display;
            //nome_combo.Text = "";
            nome_combo.Refresh();
        }


        public bool InsereFilaImpressa(int idPed, String TextoCli, String TextoEmp)
        {
            try {
                this.ExecutaQuery("insert into fila_impressao values(" + idPed + ", '" + TextoCli + "', '" + TextoEmp + "','na fila')");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO ao inserir na fila de impressao\n\n" + ex); return false;
            }

        }


        public string getSaldoCreditoCliente(string id_cliente)
        {
            String saldo = this.RetornaQuery("select convert(varchar, cast(isnull(saldo, 0) as money), 1) as 'saldo' from saldo_credito_cli where id_cliente=" + id_cliente, "saldo");


            if (saldo != "")
            {
                return saldo.Replace(",", "");
            }
            else
            {
                return "0";
            }
        }

        public class Ticket {
            public String id { get; set; }
            public String ticket { get; set; }
        }

        public void fillCboTicket(ComboBox combo)
        {
            var conn = new OdbcConnection();
            conn.ConnectionString =
                          "Dsn=odbc_pliniao;" +
                          "Uid=sa;" +
                          "Pwd=chico110388;";

            var query = "select id,ticket from tp_tickets order by ticket"; 

            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao conectar no banco de dados.\n" + e);
            }

            try
            {
                var dtLista = new List<Ticket>();
                int i = 1;
                dtLista.Add(new Ticket() { id = "0", ticket = " ---- Voucher ----" });

                OdbcCommand cmd = new OdbcCommand(query, conn);
                OdbcDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dtLista.Add(new Ticket() { id = dr[0].ToString(), ticket = dr[1].ToString() });
                    }
                    combo.DataSource = dtLista;
                    combo.DisplayMember = "ticket";
                    combo.ValueMember = "id";
                    combo.DropDownStyle = ComboBoxStyle.DropDownList;

                }

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(query + "\n\n" + e.ToString());
                FileStream fs = File.Create(@"c:\pliniao\query.txt");
                StreamWriter sw = new StreamWriter(fs);
                String sTpMaq;

                sTpMaq = query;

                sw.Write(sTpMaq);
                sw.Close();
            }
        }

    }
       
}
