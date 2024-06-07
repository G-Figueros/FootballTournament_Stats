//using clsTorneo;
using clsEstructuraDatos;
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
    public partial class frmRojas : Form
    {
        public frmRojas()
        {
            InitializeComponent();
        }

        private void frmRojas_Load(object sender, EventArgs e)
        {
            /*foreach (clsJugador jugador in clsListaJugadores.jugadores)
            {
                cmbJugador.Items.Add(jugador.Nombre);
            }*/
        }

        private void btnGuardarRojas_Click(object sender, EventArgs e)
        {
            int cantidad = (int)upCantidad.Value;
            string nombreSeleccionado = cmbJugador.SelectedItem.ToString();

            /*clsJugador jugadorSeleccionado = clsListaJugadores.jugadores.Find(jugadores => jugadores.Nombre == nombreSeleccionado);

            clsJugador.IncrementarTarjetasRojas(jugadorSeleccionado, cantidad);*/
            
            this.Close();
        }
    }
}
