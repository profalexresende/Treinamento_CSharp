using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjComissao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComissao_Click(object sender, EventArgs e)
        {
            Vendedor v = new Vendedor(txtNome.Text,double.Parse(txtSBase.Text));

            MessageBox.Show($"Comissão: R${v.calculoComissao(double.Parse(txtVendas.Text)).ToString()}");
        }
    }
}
