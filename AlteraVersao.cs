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
    class AlteraVersao{

        conexao c = new conexao();

        public AlteraVersao()
        {


          //  MessageBox.Show("teste2");

            //coluna forma_pagto - tabela vendas
            c.ExecutaQuery("if not exists(select 1 from syscolumns where id = object_id('vendas') and name = 'forma_pagto') ALTER TABLE vendas ADD forma_pagto INT null");
            
            //tabela tipo_contas_pagar
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tipo_contas_pagar') CREATE TABLE [dbo].[tipo_contas_pagar]([id] [int] IDENTITY(1,1) NOT NULL, [descricao] [varchar](50) NOT NULL)");
        
            //tabela contas_pagar
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'contas_pagar') CREATE TABLE [dbo].[contas_pagar]( [id] [int] IDENTITY(1,1) NOT NULL, [tipo] [varchar](50) NOT NULL, [valor] [float] NOT NULL,	[vencimento] [date] NOT NULL, [alertar] [int] NOT NULL,	[isDespesaFixa] [int] NOT NULL, [id_ref] [int] not null)");
       
            //senha form
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'senha_form') CREATE TABLE [dbo].[senha_form]([id] [int] IDENTITY(1,1) NOT NULL, [senha] [varchar](50) NOT NULL)");
            c.ExecutaQuery("if not exists(SELECT senha FROM senha_form) insert into senha_form values ('azarito92')");

            //tabela cargo funcionarios
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'cargos_func') CREATE TABLE [dbo].[cargos_func]([id] [int] IDENTITY(1,1) NOT NULL, [descricao] [varchar](50) NOT NULL)");

            //tabela funcionarios
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'funcionarios') CREATE TABLE [dbo].[funcionarios] ([id] [int] NOT NULL, [nome] [varchar](50) NOT NULL, [id_cargo] [int] not null, [salario] [float] not null, [dia_pagto] [int] not null, [isInativo] [int] default 0)");

            //tabela outros gastos funcionarios
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'outros_gastos_funcionarios') CREATE TABLE [dbo].[outros_gastos_funcionarios] ([id] [int] IDENTITY(1,1) NOT NULL, [id_func] [int] not null, [descricao] [varchar](50) not null, [valor] [float] not null)");

            //tabela despesas gerais
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'despesas_gerais') CREATE TABLE [dbo].[despesas_gerais] ([id] [int] IDENTITY(1,1) NOT NULL,  [descricao] [varchar](50) not null, [valor] [float] not null, [data] [datetime] not null)");

            //tabela cadastro clientes
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'clientes') CREATE TABLE [dbo].[clientes] ([id] [int] IDENTITY(1,1) NOT NULL,  nome [varchar](50) not null, [endereco] [text], [telefone] [varchar](50), [hora_entrega] [varchar](50))");

            //coluna is_pagto_pendente
            c.ExecutaQuery("if not exists(select 1 from syscolumns where id = object_id('vendas') and name = 'is_pagto_pendente') ALTER TABLE vendas ADD is_pagto_pendente INT null default 0");


            //coluna id cliente
            c.ExecutaQuery("if not exists(select 1 from syscolumns where id = object_id('vendas') and name = 'id_cliente') ALTER TABLE vendas ADD id_cliente INT null default 0");
        
            //tabela pedidos_pendentes_quitados
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'pedidos_pendentes_quitados') CREATE TABLE [dbo].[pedidos_pendentes_quitados] ([id] [int] IDENTITY(1,1) NOT NULL,  id_pedido [int] not null, data_quitacao [datetime] not null )");

            //tabela pagar_funcionarios 
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'pagar_funcionarios') CREATE TABLE [dbo].[pagar_funcionarios]( [id] [int] IDENTITY(1,1) NOT NULL, [id_func] [int] NOT NULL, [valor_total_func] [float] NOT NULL, [data_pagto] [date] NOT NULL)");


            //tabela cadastro clientes
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'agenda') CREATE TABLE [dbo].[agenda] ([id] [int] IDENTITY(1,1) NOT NULL,  nome [varchar](50) not null, [endereco] [text], [telefone] [varchar](50))");

            //campo troco
            c.ExecutaQuery("if not exists(select 1 from syscolumns where id = object_id('vendas') and name = 'dinheiro_recebido') ALTER TABLE vendas ADD dinheiro_recebido float default 0");

       //     MessageBox.Show("teste3");

            //tabela tempo_fila_impressao
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'tempo_fila_impressao') begin CREATE TABLE[dbo].[tempo_fila_impressao] (id int default 1, tempo int default 10000) insert into tempo_fila_impressao values(1,10000) end");

       //     MessageBox.Show("teste4");

            //tabela fila_impressao
            c.ExecutaQuery("if not exists(SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'fila_impressao') create table fila_impressao(id int IDENTITY(1,1) NOT NULL, id_pedido int, textocli text, textoemp text, status varchar(50))");

           // MessageBox.Show("teste5");

        }

        //public void gera_pagto_funcionario()
        //{

        //    String MesAtual = DateTime.Today.Month.ToString("#0");
        //    String AnoAtual = DateTime.Today.Year.ToString();
        //    String DaysNoMonth = DateTime.DaysInMonth(int.Parse(AnoAtual), int.Parse(MesAtual)).ToString();

        //    var conn = new OdbcConnection();
        //    conn.ConnectionString =
        //                  "Dsn=odbc_pliniao;" +
        //                  "Uid=sa;" +
        //                  "Pwd=chico110388@@;";

        //    try
        //    {
        //        conn.Open();
        //    }
        //    catch (Exception exx)
        //    {
        //        MessageBox.Show("erro " + exx.ToString());
        //    }

        //    String query2 = "select isnull(sum(og.valor),0)+isnull(f.salario,0) as 'total_func', f.id as 'id_func', f.dia_pagto from funcionarios f left join outros_gastos_funcionarios og on f.id=og.id_func where f.isInativo<>1 group by f.id, f.salario, f.nome, f.dia_pagto order by f.nome";
        //    OdbcCommand cmd2 = new OdbcCommand(query2, conn);
        //    OdbcDataReader dr2 = cmd2.ExecuteReader();

        //    while (dr2.Read())
        //    {
        //        // MessageBox.Show(dr2["total_func"].ToString());
        //        String valorfunc = dr2["total_func"].ToString().Replace(",", ".");
        //        c.ExecutaQuery("if not exists(select 1 from pagar_funcionarios where id_func=" + dr2["id_func"] + " and data_pagto >= '" + AnoAtual + "-" + MesAtual + "-01' and data_pagto <= '" + AnoAtual + "-" + MesAtual + "-" + DaysNoMonth + "')" + " insert into pagar_funcionarios values(" + dr2["id_func"] + "," + valorfunc + ",'" + AnoAtual + "-" + MesAtual + "-" + dr2["dia_pagto"] + "')");
        //    }

        //    dr2.Close();
        //    conn.Close();
        //}
    }
}
