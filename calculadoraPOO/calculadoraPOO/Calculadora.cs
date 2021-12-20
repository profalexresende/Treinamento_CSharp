using System;
using System.Collections.Generic;
using System.Text;

namespace calculadoraPOO
{
    public class Calculadora
    {
        //ATRIBUTOS
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double res { get; set; }

        //CONSTRUTOR
        public Calculadora()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.res = 0;
        }

        public Calculadora(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            this.res = 0;
        }

        public void somar()
        {
           this.res = this.n1 + this.n2;
        }

        public void subtrair()
        {
            res = n1 - n2;
        }

        public void multiplicar()
        {
            res = n1 * n2;
        }

        public void dividir()
        {
            res = n1 / n2;
        }
    }
}
