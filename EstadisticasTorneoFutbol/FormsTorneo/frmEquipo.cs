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
    public partial class frmEquipo : Form
    {
        public frmEquipo()
        {
            InitializeComponent();
        }

        private void frmEquipo_Load(object sender, EventArgs e)
        {
          /* foreach (clsTorneos torneo in clsListaTorneo.torneos)
            {
                cmbTorneo.Items.Add(torneo.Nombre);
            }*/
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEquipo.Text;
            string nombreSeleccionado = cmbTorneo.SelectedItem.ToString();

            /*clsTorneos torneoSeleccionado = clsListaTorneo.torneos.Find(torneo => torneo.Nombre == nombreSeleccionado);

            clsEquipo nuevoEquipo = new clsEquipo(nombre);
            clsListaEquipo.equipos.Add(nuevoEquipo);

            clsEquipo.insertarEquipo(torneoSeleccionado, nuevoEquipo);*/

            this.Close();
        }
    }
}
