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
            Calculadora calc = new Calculadora();


            switch (cmbOperacao.SelectedIndex)
            {
                case 0://sem parametro e sem retorno
                    calc.n1 = double.Parse(txtN1.Text);
                    calc.n2 = double.Parse(txtN2.Text);
                    calc.somar();
                    lblRes.Text = calc.res.ToString();
                    break;
                case 1://sem parametro e com retorno
                    calc.n1 = double.Parse(txtN1.Text);
                    calc.n2 = double.Parse(txtN2.Text);
                    lblRes.Text = calc.subtrair().ToString();
                    break;
                case 2://com parametro e sem retorno
                    calc.multiplicar(double.Parse(txtN1.Text), double.Parse(txtN2.Text));
                    lblRes.Text = calc.res.ToString();
                    break;
                case 3://com parametro e com retorno
                    lblRes.Text= calc.dividir(double.Parse(txtN1.Text), double.Parse(txtN2.Text)).ToString();
                    break;
                default:
                    MessageBox.Show("Selecione uma operação");
                    break;
            }
            
        }
    }
}
