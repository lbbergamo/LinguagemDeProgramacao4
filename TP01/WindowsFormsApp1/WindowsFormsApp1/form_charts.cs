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
    public partial class form_charts : Form
    {
        public form_charts(bool function)
        {
            InitializeComponent();
            if (function){
                btn_import.Hide();
            }
            else
            {
                tb_y.Hide();
                tb_x.Hide();
                label_x.Hide();
                label_y.Hide();
                btn_calc.Hide();
                title_calc.Text = "Grafico de Vendas";

                VendaBLL.conecta();
                if (Erro.getErro())
                {
                    MessageBox.Show(Erro.getMsg());
                    Application.Exit();
                }
            }

        }

  

        private void chart_Click(object sender, EventArgs e)
        {
      
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            float x = float.Parse(tb_x.Text);
            float y = float.Parse(tb_y.Text);
            equacao calc = new equacao();
            for (int i = -100; i < 100; i++)
            {
                chart.Series[0].Points.AddXY(i+100, calc.calc(x,y,i));
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
            chart.Series[0].Points.Clear();
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            VendaBLL.getProximo();
            while (!Erro.getErro())
            {
                chart.Series[0].Points.AddXY(Venda.getAno(), Venda.getTotal());
                VendaBLL.getProximo();
            }
        }

        private void form_charts_Load(object sender, EventArgs e)
        {

        }

        private void form_charts_Deactivate(object sender, EventArgs e)
        {
            VendaBLL.desconecta();
        }
    }
}
