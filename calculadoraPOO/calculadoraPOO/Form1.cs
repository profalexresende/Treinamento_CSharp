using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora(double.Parse(txtN1.Text), double.Parse(txtN2.Text));

            switch (cmbOperacao.SelectedIndex)
            {
                case 0:
                    calc.somar();
                    break;
                case 1:
                    calc.subtrair();
                    break;
                case 2:
                    calc.multiplicar();
                    break;
                case 3:
                    calc.dividir();
                    break;
                default:
                    MessageBox.Show("Selecione uma operação");
                    break;
            }
            lblRes.Text = calc.res.ToString();
        }
    }
}
