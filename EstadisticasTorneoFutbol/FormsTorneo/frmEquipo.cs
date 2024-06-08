//using clsTorneo;
using clsEstructuraDatos.Modelos;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TorneoPOO
{
    public partial class frmEquipo : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public string gridSelected;
        bool flujo = true;

        string clave;
        public frmEquipo(clsTablaHashTournament tournamentNw, bool tipoFlujo, string claveSeleccionada)
        {
            this.tablaHashTournament = tournamentNw;
            this.flujo = tipoFlujo;
            this.clave = claveSeleccionada;
            InitializeComponent();
            if (this.clave != "")
            {
                this.txtNombreEquipo.Text = clave;
                this.cmbTorneo.Enabled = false;
            }
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
            if (flujo == true) { 
                string nombre = txtNombreEquipo.Text;
                string pais = txtPais.Text;
                string estadio = txtEstadio.Text;
                string claveTorneo = cmbTorneo.SelectedItem.ToString();

                clsTournament torneo = (clsTournament)tablaHashTournament.Buscar(claveTorneo);

                clsTeam equipo = new clsTeam((torneo.avlTournament.posicion + 1), nombre, pais, claveTorneo, estadio);
                torneo.avlTournament.insertar(equipo);
            }
            else
            {
                string nombre = txtNombreEquipo.Text;
                string pais = txtPais.Text;
                string estadio = txtEstadio.Text;
                clsTournament torneo = (clsTournament)tablaHashTournament.Buscar(clave);
                clsTeam equipo = new clsTeam((torneo.avlTournament.posicion + 1), nombre, pais, clave, estadio);
                torneo.avlTournament.actualizar(equipo);
            }

            this.Close();
        }
    }
}
