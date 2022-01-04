using System;
using System.Collections.Generic;
using System.Text;

namespace prjComissao
{
    class Vendedor
    {
        //ATRIBUTOS
        public string nome { get; set; }
        public double salarioBase { get; set; }

        //CONSTRUTORES
        public Vendedor(string nome, double salarioBase)
        {
            this.nome = nome;
            this.salarioBase = salarioBase;
        }

        public Vendedor()
        {
            this.nome = "";
            this.salarioBase = 0;
        }

        //MÉTODOS DA CLASSE
        public double calculoComissao(double valorVendido)
        {
            return valorVendido * 0.1;
        }
    }
}
