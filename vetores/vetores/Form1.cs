using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;//Adicionando um namespace

namespace vetores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            double[] v = new double[10];
            double total=0;

            for (int i = 0; i <v.Length; i++)
            {
                v[i] = double.Parse(Interaction.InputBox
                    ($"Digite o valor da venda do vendedor {(i+1).ToString()}"));

                total += v[i];
            }
            MessageBox.Show($"Total das vendas R${total.ToString("0.00")}");
        }
    }
}
