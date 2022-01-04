using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    class CalculadoraSalarioDolar:CalculadoraSalario
    {
        public double cotacao { get; set; }

        public CalculadoraSalarioDolar()
        {
            cotacao = 0;
        }

        public override double calcularSalario()
        {
            return (this.valorHora * this.qtdeHoras) * this.cotacao;
        }
    }
}
