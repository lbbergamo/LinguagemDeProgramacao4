using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDLivrosDataSet.TabLivro'. Você pode movê-la ou removê-la conforme necessário.
            this.tabLivroTableAdapter.Fill(this.bDLivrosDataSet.TabLivro);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bindingSource1.EndEdit();
            this.tabLivroTableAdapter.Update(this.bDLivrosDataSet);
            MessageBox.Show("Banco de Dados atualizado!");
        }
    }
}
