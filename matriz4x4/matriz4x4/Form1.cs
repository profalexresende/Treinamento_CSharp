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

namespace matriz4x4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] matriz = new int[4, 4];
            int soma = 0;
            double media=0;
            int mult;
            string sMult="";

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna=0; coluna < matriz.GetLength(1); coluna++)
                {
                    matriz[linha, coluna] = int.Parse(Interaction.InputBox(
                        $"Digite um valor para a posição [{linha},{coluna}] da matriz."));
                    if (linha == 0)
                    {
                        soma += matriz[0, coluna];
                    }

                    if (linha == 1)
                    {
                        media += matriz[1, coluna];
                    }

                    if (linha == 3)
                    {
                        mult = matriz[2, coluna] * matriz[3, coluna];
                        sMult += mult + " - ";
                    }
                }
            }
            media = media / 4;
            MessageBox.Show($"Soma da linha 0 {soma.ToString()}\n" +
                $"Média da linha 1: {media.ToString()}\n" +
                $"Multiplicação linhas 2 e 3: {sMult}");
        }
    }
}
