using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form1 : Form
    {
        private Conta c;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.c = new Conta();
            c.Numero = 1;
            Cliente cliente = new Cliente("carlos matheus");
            c.Titular = cliente;

            textoTitular.Text = c.Titular.Nome;
            textoNumero.Text = Convert.ToString(c.Numero);
            textoSaldo.Text = Convert.ToString(c.Saldo);
        }

        private void botaoDepositar_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            c.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.c.Saldo);
            MessageBox.Show("Depósito realizado com sucesso!");
        }
    }
}
