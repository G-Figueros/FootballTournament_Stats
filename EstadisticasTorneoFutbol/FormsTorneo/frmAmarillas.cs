//using clsTorneo;
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
    public partial class frmAmarillas : Form
    {
        public frmAmarillas()
        {
            InitializeComponent();
        }

        private void frmAmarillas_Load(object sender, EventArgs e)
        {
            /*foreach (clsJugador jugador in clsListaJugadores.jugadores)
            {
                cmbJugador.Items.Add(jugador.Nombre);
            }*/
        }

        private void btnGuardarAmarillas_Click(object sender, EventArgs e)
        {
            int cantidad = (int)upCantidad.Value;
            string nombreSeleccionado = cmbJugador.SelectedItem.ToString();

           // clsJugador jugadorSeleccionado = clsListaJugadores.jugadores.Find(jugadores => jugadores.Nombre == nombreSeleccionado);

           // clsJugador.IncrementarTarjetasAmarillas(jugadorSeleccionado, cantidad);
            
            this.Close();
        }
    }
}
