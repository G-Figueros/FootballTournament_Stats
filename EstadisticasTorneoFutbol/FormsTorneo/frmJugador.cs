using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoPOO
{
    public partial class frmJugador : Form
    {
        public frmJugador()
        {
            InitializeComponent();
        }

        private void btnNuevoJugador_Click(object sender, EventArgs e)
        {
            frmNuevoJugador nuevoJugador = new frmNuevoJugador();
            nuevoJugador.Show();
        }

        private void btnIncrementarGoles_Click(object sender, EventArgs e)
        {
            frmGoles incrementarGoles = new frmGoles();
            incrementarGoles.Show();
        }

        private void btnIncrementarAmarillas_Click(object sender, EventArgs e)
        {
            frmAmarillas incrementarAmarillas = new frmAmarillas();
            incrementarAmarillas.Show();
        }

        private void btnIncrementarRojas_Click(object sender, EventArgs e)
        {
            frmRojas incrementarRojas = new frmRojas();
            incrementarRojas.Show();
        }

        private void btnVerJugadores_Click(object sender, EventArgs e)
        {
            frmListaJugadores verJugadores = new frmListaJugadores();
            verJugadores.Show();
        }
    }
}
