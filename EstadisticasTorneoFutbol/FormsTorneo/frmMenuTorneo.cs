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
    public partial class frmMenuTorneo : Form
    {
        public frmMenuTorneo()
        {
            InitializeComponent();
        }

        private void btnNuevoTorneo_Click(object sender, EventArgs e)
        {
            frmTorneo torneo = new frmTorneo();
            torneo.Show();
        }

        private void btnVerTorneos_Click(object sender, EventArgs e)
        {
            frmListaTorneos listaTorneos = new frmListaTorneos();
            listaTorneos.Show();
        }
    }
}
