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
    public partial class frmListaTorneos : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public List<clsTeam> teamList;
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
            clsNodo indice;
            clsLista listaNueva = new clsLista();
            this.dgvEquipos.Rows.Clear();
            string claveTorneo = cmbTorneos.SelectedItem.ToString();
            clsTournament torneo = (clsTournament)tablaHashTournament.Buscar(claveTorneo);
            teamList = clsArbolAVL.orden(torneo.avlTournament.raizArbol(), new List<clsTeam>());
            var listaOrdenada = teamList.OrderByDescending(e => e.points).ToList();
            foreach (clsTeam equipo in listaOrdenada)
            {
                this.dgvEquipos.Rows.Add(equipo.name, equipo.matches, equipo.victoryMatches, equipo.drawMatches, equipo.loseMatches, 
                    equipo.goalsA, equipo.goalsC, equipo.goalsD, equipo.points);
            }
            
        }
    }
}
