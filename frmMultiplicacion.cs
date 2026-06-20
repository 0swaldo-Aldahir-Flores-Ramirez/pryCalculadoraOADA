using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadoraOADA
{
    public partial class frmMultiplicacion : Form
    {
        // Creacion de Obejeto
        private clsMultiplicacion multi;

        public frmMultiplicacion()
        {
            InitializeComponent();
            multi = new clsMultiplicacion();
        }
        // Evento para calcular la operacion
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            multi.Numero1 = double.Parse(txtNumero1.Text.Trim());
            multi.Numero2 = double.Parse(txtNumero2.Text.Trim());

            lblResultado.Text = "Resultado: " + multi.CalcularOperacion();
            LimpiarCajas();
        }
        // Metodo para limpiar las cajas
        private void LimpiarCajas()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
