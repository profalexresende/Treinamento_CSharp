using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace opLogicoOU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total;
            string cupom;

            total = double.Parse(txtTotal.Text);
            cupom = txtCupom.Text.ToUpper();

            if(total>1000 || cupom == "DESCONTO20")
            {
                total = total - (total * 0.2);
            }

            MessageBox.Show($"Total a pagar: R${total.ToString("0.00")}");
        }
    }
}
