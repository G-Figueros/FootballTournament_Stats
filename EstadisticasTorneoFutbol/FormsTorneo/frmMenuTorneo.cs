using clsEstructuraDatos.TablasHash;
using FormsTorneo;
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
    public partial class frmMenuTorneo : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public frmMenuTorneo(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void btnNuevoTorneo_Click(object sender, EventArgs e)
        {
            frmTorneo torneo = new frmTorneo(this.tablaHashTournament, true, ""); //[0]:EnviarDatosGlobalesPorSesion [1]:BooleanoParaInsertarActualizar
            torneo.Show();
        }

        private void btnVerTorneos_Click(object sender, EventArgs e)
        {
            frmListaTorneos listaTorneos = new frmListaTorneos(this.tablaHashTournament);
            listaTorneos.Show();
        }

        private void btnDetalleTorneos_Click(object sender, EventArgs e)
        {
            frmDetalleTorneos udTorneos = new frmDetalleTorneos(this.tablaHashTournament);
            udTorneos.Show();
        }
    }
}
