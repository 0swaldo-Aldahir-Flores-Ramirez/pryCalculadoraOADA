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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormularioHijo(Form frmHijo)
        {
            // Verifica si ya hay un formulario hijo abierto
            if (this.MdiChildren.Length > 0)
            {
                // Cierra el formulario que ya está abierto
                this.MdiChildren[0].Close();
            }
            frmHijo.MdiParent = this;
            frmHijo.StartPosition = FormStartPosition.CenterScreen;
            frmHijo.Show();
        }
        // Abre formulario Suma
        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmSuma());
        }
        // Cierra todo
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Mensaje Acerca de
        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Calculadora Basica v1.0\n\nPrueba del mejor equipo del C\ntrabajo colaborativo con Git y GitHub.",
                "Acerca de Calculadora",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Abre formulario Resta
        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmResta());
        }
        // Abre formulario Multiplicacion
        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmMultiplicacion());
        }
        // Abre formulario Divion
        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new frmDivision());
        }
    }
}
