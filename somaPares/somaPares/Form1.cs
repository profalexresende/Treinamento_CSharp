using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somaPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            //EXEMPLO SEM OS EXTREMOS

            int n1, n2, qtdePares=0;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            lblRes.Text = "";

            if (n1 < n2)
            {
                do
                {
                    if (n1 % 2 == 0)
                    {
                        qtdePares++;
                    }
                    n1++;
                } while (n1 < n2);
                lblRes.Text = qtdePares.ToString();
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }
        }
    }
}
