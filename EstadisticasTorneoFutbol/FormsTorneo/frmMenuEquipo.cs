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
    public partial class frmMenuEquipo : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public frmMenuEquipo(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            frmEquipo equipo = new frmEquipo(this.tablaHashTournament);
            equipo.Show();
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            frmListaEquipos listaEquipos = new frmListaEquipos();
            listaEquipos.Show();
        }

        private void btnDetalleEquipos_Click(object sender, EventArgs e)
        {

        }
    }
}
