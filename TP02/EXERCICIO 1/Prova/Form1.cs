﻿using System;
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
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Cliente.setCNPJ(textBox1.Text);
            BLL.validaCNPJ();
            DAL.getProximo();
            while (!Erro.getErro())
            {
                textBox2.Text = Cliente.getNome();
                listBox1.Items.Add(VendaCliente.getData());
                listBox2.Items.Add(VendaCliente.getToneladas());
                listBox3.Items.Add(VendaCliente.getValor());
                DAL.getProximo();
            }
        }
    }
}
