using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediaEscolar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, media;
            string situacao;

            n1 = double.Parse(txtN1.Text);
            n2 = double.Parse(txtN2.Text);
            n3 = double.Parse(txtN3.Text);

            media = (n1 + n2 + n3) / 3;

            if (media >= 7)
            {
                situacao = "Aprovado";
            }
            else if (media >= 4)
            {
                situacao = "Prova Final";
            }
            else
            {
                situacao = "Reprovado";
            }
            MessageBox.Show($"Média: {media.ToString("0.00")} \nSituação: {situacao}",
                "Média Escolar",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
