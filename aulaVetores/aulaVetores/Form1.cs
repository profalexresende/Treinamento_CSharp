using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaVetores
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
            double[] v = new double[5];

            v[0] = double.Parse(txtV1.Text);
            v[1] = double.Parse(txtV2.Text);
            v[2] = double.Parse(txtV3.Text);
            v[3] = double.Parse(txtV4.Text);
            v[4] = double.Parse(txtV5.Text);

            total = v[0] + v[1] + v[2] + v[3] + v[4];

            MessageBox.Show($"Total das vendas {total.ToString("0.00")}");
        }
    }
}
