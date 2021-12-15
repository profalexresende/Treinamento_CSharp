using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saldoMedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            double saldo, credito;

            if (double.TryParse(txtSaldo.Text,out saldo) == false)
            {
                MessageBox.Show($"Digite um número válido!", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSaldo.Clear();//limpa a textbox
                txtSaldo.Focus();//posiciona o cursor no componente
                lblCredito.Text = "";//limpa a label
                return;//Abortar
            }
            if (saldo <= 200)
            {
                credito = 0;
            }
            else if (saldo<=400)
            {
                credito = saldo * 0.2;
            }
            else if (saldo <= 600)
            {
                credito = saldo * 0.3;
            }
            else
            {
                credito = saldo * 0.4;
            }
            lblCredito.Text = $"Seu crédito: R${credito.ToString("0.00")}";
        }
    }
}
