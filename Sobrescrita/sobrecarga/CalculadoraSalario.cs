using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecarga
{
    class CalculadoraSalario
    {
        public double valorHora { get; set; }
        public double qtdeHoras { get; set; }

        public CalculadoraSalario()
        {
            this.valorHora = 0;
            this.qtdeHoras = 0;
        }

        public virtual double calcularSalario()
        {
            return this.valorHora * this.qtdeHoras;
        }

       
    }
}
