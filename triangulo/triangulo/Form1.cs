using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int lado1, lado2, lado3;
            string tipoTriangulo;

            lado1 = int.Parse(txtLado1.Text);
            lado2 = int.Parse(txtLado2.Text);
            lado3 = int.Parse(txtLado3.Text);

            //VERIFICAR SE OS VALORES FORMAM UM TRIANGULO
            if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
            {
                //BLOCO VERDADEIRO: OS LADOS FORMAM UM TRIÂNGULO
                //CHECAR O TIPO DE TRIANGULO FORMADO
                if (lado1 == lado2 && lado2 == lado3)
                {
                    tipoTriangulo = "Equilátero";
                }
                else if (lado1 != lado2 && lado2 != lado3 && lado1 != lado3)
                {
                    tipoTriangulo = "Escaleno";
                }
                else
                {
                    tipoTriangulo = "Isósceles";
                }
                MessageBox.Show($"Os lados informados formam um triângulo {tipoTriangulo}", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                //BLOCO FALSO: OS LADOS NÃO FORMAM UM TRIANGULO
                MessageBox.Show("Os lados informados não formam um triângulo!", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
