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
    public partial class frmDivision : Form
    {
       
        private ClsDivision division;
        public frmDivision()
        {
            InitializeComponent();
            division = new ClsDivision();
        }
       
        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            division.Numero1 = double.Parse(txtNumero1.Text.Trim());
            division.Numero2 = double.Parse(txtNumero2.Text.Trim());

            lblResultado.Text = "Resultado: " + division.CalcularOperacion();
            LimpiarCajas();
        }
        private void LimpiarCajas()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
        }
    }
}
