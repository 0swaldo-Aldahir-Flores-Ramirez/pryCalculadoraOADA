using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadoraOADA
{
    internal class ClsDivision : clsOperacion
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public override double CalcularOperacion()
        {
            if (Numero2 == 0)
            {
                MessageBox.Show("No se puede dividir entre cero tonto");
                return 0;
            }

            return Numero1 / Numero2;
        }

    }
}
