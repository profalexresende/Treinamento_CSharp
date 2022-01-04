using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sobrecarga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            CalculadoraSalario cs = new CalculadoraSalario();
            
            double cotacao=0;
            try
            {
                cs.valorHora = double.Parse(txtVHora.Text);
                cs.qtdeHoras = double.Parse(txtTotalHoras.Text);
                cotacao = double.Parse(txtDolar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (cotacao == 0)
            {
                MessageBox.Show($"Total a receber: R${cs.calcularSalario():f2}");
            }
            else
            {
                MessageBox.Show($"Total a receber: R${cs.calcularSalario(cotacao):f2}");
            }
        }
    }
}
