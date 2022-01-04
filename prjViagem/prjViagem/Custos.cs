using System;
using System.Collections.Generic;
using System.Text;

namespace prjViagem
{
    class Custos
    {
        public double totalPercurso { get; set; }

        public Custos(double totalPercurso)
        {
            this.totalPercurso = totalPercurso;
        }

        public Custos()
        {
            this.totalPercurso = 0;
        }

        public void calcularViagem (Percurso p)
        {
            totalPercurso = p.valorCombustivel + p.valorPedagio;
        }
    }
}
