using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace inverterVetor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInverter_Click(object sender, EventArgs e)
        {
            double[] a = new double[15];
            double[] b = new double[15];
            
            string saida="";

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = double.Parse(Interaction.InputBox($"Digite o {(i + 1).ToString()}º número"));
                b[(a.Length-1)-i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                lstVetorB.Items.Add(b[i].ToString());
                saida += b[i].ToString() + "\n";
            }
            MessageBox.Show(saida);
        }
    }
}
