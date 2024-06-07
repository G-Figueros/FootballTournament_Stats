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
using TorneoPOO;

namespace TorneoPOO
{
    public partial class frmListaJugadores : Form
    {
        public frmListaJugadores()
        {
            InitializeComponent();
        }

        private void frmListaJugadores_Load(object sender, EventArgs e)
        {
           /* foreach (clsJugador jugador in clsListaJugadores.jugadores)
            {

                this.dgvListaJugadores.Rows.Add(jugador.Nombre, jugador.NoCamisola, jugador.TarjetasAmarillas, jugador.TarjetasRojas, jugador.Goles);
            }*/
        }
    }
}
