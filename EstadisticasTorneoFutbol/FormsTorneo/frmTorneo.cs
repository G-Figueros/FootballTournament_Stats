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
        Boolean flujo = true;
        string clave;
        public frmTorneo(clsTablaHashTournament tournamentNw, Boolean tipoFlujo, string claveSeleccionada)
        {
            this.tablaHashTournament = tournamentNw;
            this.flujo = tipoFlujo;
            this.clave = claveSeleccionada;
            
            InitializeComponent();

            if (this.clave != "")
            {
                this.txtNombreTorneo.Text = clave;
            }
        }

        private void btnGuardarTorneo_Click(object sender, EventArgs e)
        {
            if(flujo == true)
            {
                string nombre = this.txtNombreTorneo.Text;
                this.tablaHashTournament.Insertar(nombre);
            }
            else
            {
                this.tablaHashTournament.Actualizar(this.txtNombreTorneo.Text, clave);
            }
            
            this.Close();
        }
    }
}
