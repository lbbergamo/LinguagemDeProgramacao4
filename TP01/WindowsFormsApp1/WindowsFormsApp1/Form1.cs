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
    public partial class form_select : Form
    {
        public form_select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        /**
         * Botao para função
         */
        private void btn_funcao_Click(object sender, EventArgs e)
        {
            var form2 = new form_charts(true);
            form2.Show();
        }
        /**
         Botão para importar o banco de dados 
             */
        private void btn_result_Click(object sender, EventArgs e)
        {
            var form2 = new form_charts(false);
            form2.Show();

        }
    }
}
