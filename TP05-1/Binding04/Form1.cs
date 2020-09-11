using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binding04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDVendasDataSet.TabVendedorVendas'. Você pode movê-la ou removê-la conforme necessário.
            this.tabVendedorVendasTableAdapter.Fill(this.bDVendasDataSet.TabVendedorVendas);
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_vendas.Text == "" && tb_nome.Text != "")
            {
                tabVendedorVendasBindingSource.Filter = "Nome like '%" + tb_nome.Text + "%'";
                MessageBox.Show("Pesquisa por nome realizado com sucesso!");
            }
            else
            {
                string teste = "Vendas " + cb_vendas.Text + " " + tb_vendas.Text;
                MessageBox.Show("Pesquisa por valor da venda realizado com sucesso!");
                tabVendedorVendasBindingSource.Filter = "Vendas " + cb_vendas.Text + " " + tb_vendas.Text;
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tb_vendas_TextChanged(object sender, EventArgs e)
        {
            cb_vendas.Visible = true;
        }
    }
}
