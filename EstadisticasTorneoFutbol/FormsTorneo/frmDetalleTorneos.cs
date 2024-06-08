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
using TorneoPOO;

namespace FormsTorneo
{
    public partial class frmDetalleTorneos : Form
    {
        public clsTablaHashTournament tablaHashTournament;
        public string gridSelected;
        public frmDetalleTorneos(clsTablaHashTournament tournamentNw)
        {
            this.tablaHashTournament = tournamentNw;
            InitializeComponent();
        }

        private void btnActualizarTorneos_Click(object sender, EventArgs e)
        {
            frmTorneo torneo = new frmTorneo(this.tablaHashTournament, false, gridSelected); //[0]:EnviarDatosGlobalesPorSesion [1]:BooleanoParaInsertarActualizar
            torneo.Show();
        }

        private void btnEliminarTorneos_Click(object sender, EventArgs e)
        {
            tablaHashTournament.Eliminar(gridSelected);
            this.dgvDetalleTorneos.Rows.Clear();
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.dgvDetalleTorneos.Rows.Add(item.tournamentName);
                }
            }
        }

        private void dgvDetalleTorneos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvDetalle = (DataGridView)sender;
            DataGridViewCellCollection selected = dgvDetalle.CurrentRow.Cells;
            if (selected[0].Value != null)
            {
                gridSelected = selected[0].Value.ToString();
                this.btnEliminarTorneos.Enabled = true;
                this.btnActualizarTorneos.Enabled = true;
            }
            else
            {
                this.btnEliminarTorneos.Enabled = false;
                this.btnActualizarTorneos.Enabled = false;
            }
        }

        private void frmDetalleTorneos_Load(object sender, EventArgs e)
        {
            this.btnEliminarTorneos.Enabled = false;
            this.btnActualizarTorneos.Enabled = false;
            this.dgvDetalleTorneos.Rows.Clear();
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.dgvDetalleTorneos.Rows.Add(item.tournamentName);
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.btnEliminarTorneos.Enabled = false;
            this.btnActualizarTorneos.Enabled = false;
            this.dgvDetalleTorneos.Rows.Clear();
            foreach (var item in tablaHashTournament.tabla)
            {
                if (item != null)
                {
                    this.dgvDetalleTorneos.Rows.Add(item.tournamentName);
                }
            }
        }
    }
}
