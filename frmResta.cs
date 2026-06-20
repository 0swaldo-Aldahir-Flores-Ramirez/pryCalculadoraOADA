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
    public partial class frmResta : Form
    {
        public frmResta()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            clsResta resta = new clsResta();
            resta.Numero1 = Convert.ToDouble(txtNumero1.Text);
            resta.Numero2 = Convert.ToDouble(txtNumero2.Text);

            lblResultado.Text = "Resultado: " + resta.CalcularOperacion().ToString();

        }
    }
}
