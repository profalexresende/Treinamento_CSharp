using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ifComposto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double doacao,investir;

            doacao = double.Parse(txtDoacao.Text);

            if (doacao <= 1000)
            {
                investir = doacao * 0.05;
            }
            else
            {
                investir = doacao * 0.15;
            }
            MessageBox.Show($"O investimento será de R${investir.ToString("0.00")}",
                "Doação - ONG", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
