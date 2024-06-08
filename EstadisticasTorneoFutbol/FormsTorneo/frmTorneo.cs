//using clsTorneo;
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
    public partial class frmTorneo : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public frmTorneo(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void btnGuardarTorneo_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombreTorneo.Text;
            this.tablaHashTournament.Insertar(nombre);
            this.Close();
        }
    }
}
