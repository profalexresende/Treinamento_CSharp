using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleCaixa
{
    public partial class Form1 : Form
    {
        double saldo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double valor=0;

            if (!(cmbOpcao.SelectedIndex == 2))
            {
                if (double.TryParse(txtValor.Text, out valor) == false)
                {
                    MessageBox.Show("Digite um valor válido");
                    txtValor.Clear();
                    txtValor.Focus();
                    return;
                }
            }

            switch (cmbOpcao.SelectedIndex)
            {
                case 0:
                    saldo += valor; //saldo=saldo+valor
                    MessageBox.Show("Depósito efetuado!");
                    break;
                case 1:
                    saldo -= valor; //saldo=saldo-valor
                    MessageBox.Show("Saque efetuado!");
                    break;
                case 2:
                    MessageBox.Show($"Seu saldo é de R${saldo.ToString("0.00")}");
                    break;
                default:
                    MessageBox.Show("Opção Inválida!");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOpcao.SelectedIndex = 0;
        }
    }
}
