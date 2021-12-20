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

namespace vetorMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[] notas = new double[10];
            double somaNotas=0,media;

            for(int i = 0; i < notas.Length; i++)
            {
                notas[i] = double.Parse(Interaction.InputBox($"Digite a {(i + 1).ToString()}ª nota."));
                somaNotas += notas[i];
            }
            media = somaNotas / notas.Length;
            MessageBox.Show($"Média da turma: {media.ToString("0.0")}");
        }
    }
}
