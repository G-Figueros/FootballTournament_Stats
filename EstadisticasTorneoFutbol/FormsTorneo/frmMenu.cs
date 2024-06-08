using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clsEstructuraDatos;
using clsEstructuraDatos.ListaSimple;
using clsEstructuraDatos.TablasHash;

namespace TorneoPOO
{
    public partial class frmMenu : Form
    {
        clsTablaHashTournament tablaHashTournament = new clsTablaHashTournament(); //Inicialización de tablas hash en el primer form
        clsTablaHashPlayer tablaHashPlayer = new clsTablaHashPlayer();             //Para hacerlas globales en todo el flujo de los
        clsTablaHashGames tablaHashGames = new clsTablaHashGames();                //Formularios ejecutados

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnMenuTorneo_Click(object sender, EventArgs e)
        {
            frmMenuTorneo menuTorneo = new frmMenuTorneo(tablaHashTournament);
            menuTorneo.Show();
        }

        private void btnMenuJugador_Click(object sender, EventArgs e)
        {
            frmJugador menuJugador = new frmJugador();
            menuJugador.Show();
        }

        private void btnMenuEquipo_Click(object sender, EventArgs e)
        {
            frmMenuEquipo menuEquipo = new frmMenuEquipo(tablaHashTournament);
            menuEquipo.Show();
        }
    }
}
