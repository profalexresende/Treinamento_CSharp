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

namespace somaMatriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[2, 2];
            int soma=0;

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna <matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digite um número para a posição [{linha.ToString()},{coluna.ToString()}] da matriz"));
                    soma += matriz[linha, coluna];
                }
            }
            MessageBox.Show($"Soma: {soma.ToString()}");
        }
    }
}
