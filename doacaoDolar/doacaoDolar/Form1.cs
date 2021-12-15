using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doacaoDolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double cotacao;
            double valorDoacao,valorReais;

            valorDoacao = Convert.ToDouble(txtDoacao.Text.Replace(".",","));
            cotacao = Convert.ToDouble(txtCotacaoDolar.Text.Replace(".", ","));

            valorReais = valorDoacao * cotacao;

            lblResultado.Text = $"R${valorReais.ToString("0.00")}";
        }
    }
}
