using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace prjViagem
{
    class Percurso
    {
        public double kmPercorrida { get; set; }
        public double valorPedagio { get; set; }
        public double valorCombustivel { get; set; }

        public Percurso(double kmPercorrida, double valorPedagio, double valorCombustivel)
        {
            this.kmPercorrida = kmPercorrida;
            this.valorPedagio = valorPedagio;
            this.valorCombustivel = valorCombustivel;
        }

        public Percurso()
        {
            this.kmPercorrida = 0;
            this.valorPedagio = 0;
            this.valorCombustivel = 0;
        }

        public void cadastrarPercurso()
        {
            this.kmPercorrida = double.Parse(Interaction.inputbox("digite a km percorrida"));
            this.valorCombustivel = double.Parse(Interaction.inputbox("digite o valor do combustivel"));
            this.valorPedagio= double.Parse(Interaction.inputbox("digite o valor do pedágio"));
            MessageBox.Show("Percurso cadastrado!");
        }

        public void listarPercurso()
        {
            MessageBox.Show($"Dados do percurso cadastrado:\n\n" +
                $"KM Percorrida: {this.kmPercorrida.ToString()}\n" +
                $"Pedágios: R${this.valorPedagio:f2}\n" +
                $"Combustível: R${this.valorCombustivel.ToString("0.00")}");
        }
    }
}
