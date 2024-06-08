using clsEstructuraDatos.ArbolAVL;
using clsEstructuraDatos.ListaSimple;
using clsEstructuraDatos.Modelos;
using clsEstructuraDatos.TablasHash;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorneoPOO
{
    public partial class frmNuevoJugador : Form
    {
        public clsTablaHashPlayer tablaHashPlayer;
        public clsTablaHashTournament tablaHashTournament;
        public List<clsTeam> teamList;
        public frmNuevoJugador(clsTablaHashPlayer tablaHashPlayerNw, clsTablaHashTournament tablaHashTournament)
        {
            this.tablaHashPlayer = tablaHashPlayerNw;
            this.tablaHashTournament = tablaHashTournament;
            InitializeComponent();
        }

        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            
            /*string nombre = txtNombreJugador.Text;
            int numeroCamisola = (int)upCamisola.Value;
            string nombreSeleccionado = cmbEquipo.SelectedItem.ToString();*/

            

            this.Close();
        }

        private void frmNuevoJugador_Load(object sender, EventArgs e)
        {

            clsNodo indice;
            clsLista listaNueva = new clsLista();

            clsTournament torneo = (clsTournament)tablaHashTournament.Buscar("LaLiga");
            teamList = clsArbolAVL.orden(torneo.avlTournament.raizArbol(), new List<clsTeam>());
            var listaOrdenada = teamList.OrderByDescending(e => e.points).ToList();
            foreach (clsTeam equipo in listaOrdenada)
            {
                cmbEquipo.Items.Add(equipo.name);
            }

        }
    }
}
