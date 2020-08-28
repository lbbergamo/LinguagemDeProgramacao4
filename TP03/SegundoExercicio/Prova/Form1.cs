using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BLL.conecta();
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            BLL.desconecta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            if (textBox1.Text != "")
            {
                Cliente.setCNPJ(textBox1.Text);
                BLL.validaCNPJ();
                DAL.getProximo();
                int total = 0;
                int valor;
                chart1.Series[0].Points.Clear();
                while (!Erro.getErro())
                {
                    if (radioButton2.Checked)
                    {
                        valor = int.Parse(VendaCliente.getToneladas());
                    }
                    else
                    {
                        valor = int.Parse(VendaCliente.getToneladas());

                    }
                    total += valor;
                    textBox2.Text = Cliente.getNome();
                    chart1.Series[0].Points.AddXY(VendaCliente.getData(), valor);
                    DAL.getProximo();
                }
                textBox3.Text = "" + total;
            }
            else
            {
                MessageBox.Show("Digite um valor!");
            }
        }
    }
}
