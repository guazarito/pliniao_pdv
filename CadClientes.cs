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
    public partial class frmCadCli : Form
    {
        public frmCadCli()
        {
            InitializeComponent();

            grdClientes.CellMouseClick +=new DataGridViewCellMouseEventHandler(grdClientes_CellMouseClick);

            preencheGrid();
        }

        Boolean is_editing = false;
        conexao c = new conexao();

        public void grdClientes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (grdClientes.RowCount > 0)
            {
                is_editing = true;
                btnDeletarCli.Enabled = true;

                txtNomeCli.Text = c.RetornaQuery("select nome from clientes where id=" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString(), "nome");
                txtEndCli.Text = c.RetornaQuery("select endereco from clientes where id=" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString(), "endereco");
                txtTelCli.Text = c.RetornaQuery("select telefone from clientes where id=" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString(), "telefone");
                txtHoraEntregaCli.Text = c.RetornaQuery("select hora_entrega from clientes where id=" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString(), "hora_entrega");

            }
        }

        private void btnSalvarCli_Click(object sender, EventArgs e)
        {
            if (txtNomeCli.Text == "")
            {
                MessageBox.Show("O campo Nome é obrigatório", "Preencha nome", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String nome = txtNomeCli.Text;
                String endereco = txtEndCli.Text;
                String telefone = txtTelCli.Text;
                String hr_entrega = txtHoraEntregaCli.Text;

                if (!is_editing) //salvando..    
                {
                    try
                    {
                        c.ExecutaQuery("insert into clientes values('" + nome + "', '" + endereco + "', '" + telefone + "', '" + hr_entrega + "')");
                        preencheGrid();
                        btnLimparCli_Click(new Object(), new EventArgs());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else //editando...
                {
                    c.ExecutaQuery("update clientes set nome='" + nome + "', endereco= '" + endereco + "', telefone= '" + telefone + "', hora_entrega= '" + hr_entrega + "' where id ="+ grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                    preencheGrid();
                    btnLimparCli_Click(new Object(), new EventArgs());
                }
            }

            is_editing = false;
        }



        public void preencheGrid()
        {
            String sQuery;
 
   


            sQuery = "select id, nome as 'Nome', endereco as 'Endereço', telefone as 'Telefone', hora_entrega as 'Hora Entrega' from clientes order by nome";




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

            grdClientes.ReadOnly = true;

            grdClientes.DataSource = ds.Tables[0];

            grdClientes.CurrentCell = null;



            grdClientes.Columns[0].Visible = false;
            grdClientes.ClearSelection();

            conn.Close();
        }

        private void load(object sender, EventArgs e)
        {
            grdClientes.ClearSelection();
        }

        private void btnLimparCli_Click(object sender, EventArgs e)
        {
            txtEndCli.Text = "";
            txtHoraEntregaCli.Text = "";
            txtNomeCli.Text = "";
            txtTelCli.Text = "";
            grdClientes.ClearSelection();
            btnDeletarCli.Enabled = false;
        }

        private void btnDeletarCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deletar?", "Certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
                if(c.RetornaQuery("select id from vendas where id_cliente = " + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString() + " and is_pagto_pendente = 1 and isCancelado <> 1", "id") != "0"){
                    MessageBox.Show("Este cliente possui pagamentos pendentes.\nQuite-os antes de deletar!", "Oppss", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    c.ExecutaQuery("delete from clientes where id=" + grdClientes[0, grdClientes.CurrentRow.Index].Value.ToString());
                    preencheGrid();
                    btnLimparCli_Click(new Object(), new EventArgs());
                    is_editing = false;
                    MessageBox.Show("OK", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buscaCli(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in grdClientes.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    if (txtBusca.Text != "")
                    {
                        if (cell.Value.ToString().Trim().ToUpper().Contains(txtBusca.Text.Trim().ToUpper()))
                        {
                            //MessageBox.Show(row.Index.ToString());
                            cell.Style.BackColor = Color.Salmon;
                        }
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }
    }
}
