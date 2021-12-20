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

namespace matrizPares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int[,] valores = new int[3, 2];
            int qtdePares = 0;

            //ENTRADA
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    valores[linha, coluna] = int.Parse(
                        Interaction.InputBox($"Digite o elemento da posição{linha.ToString()},{coluna.ToString()} da matriz"));
                }
            }
            //PERCORRENDO UM VETOR
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    if (valores[linha, coluna] % 2 == 0)
                    {
                        qtdePares++;
                    }
                }
            }
            MessageBox.Show($"Qtde de números pares: {qtdePares.ToString()}");
        }
    }
}
