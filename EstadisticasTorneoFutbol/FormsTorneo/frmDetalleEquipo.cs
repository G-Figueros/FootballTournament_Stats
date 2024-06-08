using clsEstructuraDatos.ArbolAVL;
using clsEstructuraDatos.ListaSimple;
using clsEstructuraDatos.Modelos;
using clsEstructuraDatos.TablasHash;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TorneoPOO;

namespace FormsTorneo
{
    public partial class frmDetalleEquipo : Form
    {
        public List<clsTeam> teamList;
        public clsTablaHashTournament tablaHashTournament;
        public string gridSelected;
        Boolean flujo = true;
        string clave;
        public int idSeleccion;
        public frmDetalleEquipo(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;

            InitializeComponent();
        }

        void frmDetalleEquipo_Load(object sender, EventArgs e)
        {
            this.btnEliminarEquipos.Enabled = false;
            this.btnActualizarEquipos.Enabled = false;
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.cmbTorneo.Items.Add(item.tournamentName);
                }
            }
        }

        private void btnActualizarEquipos_Click(object sender, EventArgs e)
        {
            frmEquipo equipo = new frmEquipo(tablaHashTournament, false, gridSelected);
            equipo.Show();
        }

        private void btnEliminarEquipos_Click(object sender, EventArgs e)
        {
            clsTournament torneo = (clsTournament)tablaHashTournament.Buscar(gridSelected);
            clsBalanceo balance = (clsBalanceo)torneo.avlTournament.buscar(idSeleccion);
            torneo.avlTournament.eliminar(balance.team);
        }

        private void btnRefrescarEquipos_Click(object sender, EventArgs e)
        {
            this.btnEliminarEquipos.Enabled = false;
            this.btnActualizarEquipos.Enabled = false;
            this.dgvEquipos.Rows.Clear();
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.dgvEquipos.Rows.Add(item.tournamentName);
                }
            }
        }

        private void cmbTorneo_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsNodo indice;
            clsLista listaNueva = new clsLista();
            this.dgvEquipos.Rows.Clear();
            string claveTorneo = cmbTorneo.SelectedItem.ToString();
            clsTournament torneo = (clsTournament)tablaHashTournament.Buscar(claveTorneo);
            teamList = clsArbolAVL.orden(torneo.avlTournament.raizArbol(), new List<clsTeam>());
            var listaOrdenada = teamList.OrderByDescending(e => e.points).ToList();
            foreach (clsTeam equipo in listaOrdenada)
            {
                this.dgvEquipos.Rows.Add(equipo.id, equipo.name, equipo.country, equipo.stadium);
            }
        }

        private void dgvEquipos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvDetalle = (DataGridView)sender;
            DataGridViewCellCollection selected = dgvDetalle.CurrentRow.Cells;
            if (selected[0].Value != null)
            {
                idSeleccion = int.Parse(selected[0].Value.ToString());
                gridSelected = selected[0].Value.ToString();
                this.btnEliminarEquipos.Enabled = true;
                this.btnActualizarEquipos.Enabled = true;
            }
            else
            {
                this.btnEliminarEquipos.Enabled = false;
                this.btnActualizarEquipos.Enabled = false;
            }
        }
    }
}
