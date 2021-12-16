using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace somaFor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            //EXEMPLO SEM INCLUIR OS EXTREMOS
            int n1, n2, soma=0, cont;

            n1 = int.Parse(txtN1.Text);
            n2 = int.Parse(txtN2.Text);

            lblRes.Text = "";

            if (n1 < n2)
            {
                for (cont=n1+1;cont<n2; cont++)
                {
                    soma += cont;
                }
                lblRes.Text = soma.ToString();
            }
            else
            {
                MessageBox.Show("O primeiro número deve ser menor que o segundo!");
            }
        }
    }
}
