using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using Epson;

namespace WindowsFormsApplication2
{
    public partial class frmPedido : Form
    {
        public frmPedido(int id_pedido)
        {


            InitializeComponent();
            conexao c = new conexao();
            int id = id_pedido;
            txtIdPed.Text = id.ToString().PadLeft(4, '0');

            txtNome.Text = c.RetornaQuery("select nome from vendas where id=" + id, "nome");
            txtObs.Text = c.RetornaQuery("select obs from vendas where id=" + id, "obs");

            //preenche grid ... 

            string select = "select p.descr as 'Ítem', vi.qtt as 'Qtdade', concat('R$ ',convert(varchar, cast(vi.preco_item as money),1)) as 'Preço Ítem' , concat(isnull(v.desconto,0)*100,'%') as 'Desconto', concat('R$ ',convert(varchar, cast(vi.preco_item*vi.qtt-(vi.preco_item*vi.qtt*v.desconto) as money),1)) as 'Preço Total' from vendas_itens vi left outer join produto p on p.id=vi.id_prod left outer join vendas v on v.id=vi.id_venda where vi.id_venda=" + id_pedido;

            var conn = new OdbcConnection();
            conn.ConnectionString =
            "Dsn=odbc_pliniao;" +
            "Uid=sa;" +
            "Pwd=chico110388;";
            conn.Open();
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter(select, conn);

            OdbcCommandBuilder commandBuilder = new OdbcCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            grdItens.ReadOnly = true;
            grdItens.DataSource = ds.Tables[0];

            grdItens.Columns[0].Width = 200;
            grdItens.Columns[1].Width = 80;
            grdItens.Columns[2].Width = 80;
            grdItens.Columns[3].Width = 80;



            this.grdItens.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.grdItens.MultiSelect = false;

            grdItens.ClearSelection();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o pedido?", "Certeza?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtIdPed.Text != "")
                {   
                    conexao c = new conexao();
                    int idvenda = Convert.ToInt32(txtIdPed.Text);

                    String forma_pagto = c.RetornaQuery("SELECT FORMA_PAGTO FROM VENDAS WHERE ID = " + idvenda.ToString(), "FORMA_PAGTO");

                    if (forma_pagto == "5")
                    {
                        if (MessageBox.Show("Essa venda debitou creditos do cliente e eles serão ESTORNADOS automaticamente. Continuar?", "Continuar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            c.ExecutaQuery("update vendas set isCancelado=1 where id=" + idvenda.ToString());
                            MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        c.ExecutaQuery("update vendas set isCancelado=1 where id=" + idvenda.ToString());
                        MessageBox.Show("CANCELADO!", "Canceled", MessageBoxButtons.OK);
                    }

                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            frmFazerVenda print = new frmFazerVenda();
            conexao c = new conexao();


        }
    }
}
