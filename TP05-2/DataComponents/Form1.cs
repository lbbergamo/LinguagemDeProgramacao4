using DataComponents.BDVendasDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DataComponents
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
        }

        private void button1_Click(object sender, EventArgs e) // Lista
        {
            chart1.Series.Clear();
            bindingSource1.Filter = query();
            chart1.DataBindTable(bindingSource1, "Mes");
        }

        private void button2_Click(object sender, EventArgs e) // Grafico
        {
            chart1.Series.Clear();
            bindingSource1.Filter = query();
            chart1.DataBindTable(bindingSource1, "Nome");
        }

        public string query()
        {
            bindingSource1.RemoveFilter();
            string query = "";

            if(textBox1.Text != ""){
                query = nome();
            }

            if (textBox2.Text != "")
            {
                query = mes();
            }
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                query = "(" + mes() + ") AND (" + nome() + ")";
            }

            MessageBox.Show(query);
            return query;
        }
        public string mes()
        {
            string teste = textBox2.Text;
            string query = "";
            if (teste.Contains("/")) { 
                string[] teste2 = teste.Split('/');
                for (int i = 0; i <= teste2.Length - 1; i++)
                {
                    if (i != 0 && i == teste2.Length - 1)
                    {
                        query += " OR Mes = ";
                    }
                    query += "'" + teste2[i] + "'";
                }

            }
            else
            {
                query += "'" + teste + "'";
            }
            return "Mes = " + query;
        }

        public string nome()
        {
            string query = "";
            string teste = textBox1.Text;
            if (teste.Contains("/"))
            {
                string[] teste2 = teste.Split('/');
                for (int i = 0; i <= teste2.Length - 1; i++)
                {
                    if (i != 0 && i == teste2.Length - 1)
                    {
                        query += " OR Nome = ";
                    }
                    query += "'" + teste2[i] + "'";
                }
            }
            else{
                query += "'" + teste + "'";
            }
            return "Nome = " + query;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tabVendedorVendasTableAdapter.Fill(this.bDVendasDataSet.TabVendedorVendas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }



    }
}
