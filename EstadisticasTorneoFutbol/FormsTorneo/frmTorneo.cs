//using clsTorneo;
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
        public frmTorneo()
        {
            InitializeComponent();
        }

        private void btnGuardarTorneo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreTorneo.Text;

            /*clsTorneos nuevoTorneo = new clsTorneos(nombre);
            clsListaTorneo.torneos.Add(nuevoTorneo);*/

            this.Close();
        }
    }
}
