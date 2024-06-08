using clsEstructuraDatos.TablasHash;
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
    public partial class frmListaTorneos : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public frmListaTorneos(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void frmListaTorneos_Load(object sender, EventArgs e)
        {
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.cmbTorneos.Items.Add(item.tournamentName);
                }
            }
        }

        private void cmbTorneos_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvEquipos.Rows.Clear();
            string nombreSeleccionado = cmbTorneos.SelectedItem.ToString();
           /* clsTorneos torneoSeleccionado = clsListaTorneo.torneos.Find(torneo => torneo.Nombre == nombreSeleccionado);

            if (torneoSeleccionado != null)
            {
                foreach (clsEquipo equipo in torneoSeleccionado.Equipos)
                {
                    if (equipo != null)
                    {
                        int plazas = 0;
                        foreach (clsJugador jugador in equipo.Jugadores)
                        {
                            if (jugador != null)
                            {
                                plazas++;
                            }
                        }
                        dgvEquipos.Rows.Add(equipo.Nombre, plazas);
                    }
                }
            }*/
        }
    }
}
