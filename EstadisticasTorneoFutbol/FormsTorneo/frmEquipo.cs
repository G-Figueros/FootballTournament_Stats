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
    public partial class frmEquipo : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public frmEquipo(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.cmbTorneo.Items.Add(item.tournamentName);
                }
            }
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEquipo.Text;
            string nombreSeleccionado = cmbTorneo.SelectedItem.ToString();

            /*clsTorneos torneoSeleccionado = clsListaTorneo.torneos.Find(torneo => torneo.Nombre == nombreSeleccionado);

            clsEquipo nuevoEquipo = new clsEquipo(nombre);
            clsListaEquipo.equipos.Add(nuevoEquipo);

            clsEquipo.insertarEquipo(torneoSeleccionado, nuevoEquipo);*/

            this.Close();
        }
    }
}
