using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegando04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabVendedorVendasTableAdapter.Fill(this.bDVendasDataSet.TabVendedorVendas);
        }

        private void bindingSource2_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
