using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pryCalculadoraOADA;

namespace pryCalculadoraOADA
{
    internal class clsResta: clsOperacion
    {
        public double   Numero1 { get; set;}

        public double Numero2 { get; set; }

        public override double CalcularOperacion()
        {
            return Numero1 - Numero2;

        }
    }
}