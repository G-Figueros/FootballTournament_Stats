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

namespace FormsTorneo
{
    public partial class frmMenuPartidos : Form
    {
        public clsTablaHashGames tablaHashGames;
        public frmMenuPartidos(clsTablaHashGames tablaHashGamesNw)
        {
            this.tablaHashGames = tablaHashGamesNw;
            InitializeComponent();
        }

        private void btnNuevoPartido_Click(object sender, EventArgs e)
        {
            frmPartido partido = new frmPartido();
            partido.Show();
        }
    }
}
