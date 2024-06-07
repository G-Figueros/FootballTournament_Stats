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
    public partial class frmMenuEquipo : Form
    {
        public frmMenuEquipo()
        {
            InitializeComponent();
        }

        private void btnNuevoEquipo_Click(object sender, EventArgs e)
        {
            frmEquipo equipo = new frmEquipo();
            equipo.Show();
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            frmListaEquipos listaEquipos = new frmListaEquipos();
            listaEquipos.Show();
        }
    }
}
