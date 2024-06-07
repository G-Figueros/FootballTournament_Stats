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
    public partial class frmListaEquipos : Form
    {
        public frmListaEquipos()
        {
            InitializeComponent();
        }

        private void frmListaEquipos_Load(object sender, EventArgs e)
        {
            /*foreach (clsEquipo equipo in clsListaEquipo.equipos)
            {
                cmbEquipos.Items.Add(equipo.Nombre);
            }*/
        }

        private void cmbEquipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvJugadores.Rows.Clear();
            string nombreSeleccionado = cmbEquipos.SelectedItem.ToString();
            /*clsEquipo equipoSeleccionado = clsListaEquipo.equipos.Find(equipo => equipo.Nombre == nombreSeleccionado);

            if (equipoSeleccionado != null)
            {
                foreach (clsJugador jugador in equipoSeleccionado.Jugadores)
                {
                    if (jugador != null)
                    {
                        dgvJugadores.Rows.Add(jugador.Nombre, jugador.NoCamisola);
                    }
                }
            }*/
        }
    }
}
