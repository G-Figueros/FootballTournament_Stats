using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using clsTorneo;

namespace TorneoPOO
{
    public partial class frmNuevoJugador : Form
    {
        public frmNuevoJugador()
        {
            InitializeComponent();
        }

        private void btnGuardarJugador_Click(object sender, EventArgs e)
        {
            
            string nombre = txtNombreJugador.Text;
            int numeroCamisola = (int)upCamisola.Value;
            string nombreSeleccionado = cmbEquipo.SelectedItem.ToString();

            /*clsEquipo equipoSeleccionado = clsListaEquipo.equipos.Find(equipo => equipo.Nombre == nombreSeleccionado);

            clsJugador nuevoJugador = new clsJugador(nombre, numeroCamisola);
            clsListaJugadores.jugadores.Add(nuevoJugador);

            clsJugador.insertarJugador(equipoSeleccionado, nuevoJugador);*/

            this.Close();
        }

        private void frmNuevoJugador_Load(object sender, EventArgs e)
        {
            /*foreach (clsEquipo equipo in clsListaEquipo.equipos)
            {
                cmbEquipo.Items.Add(equipo.Nombre);
            }*/
        }
    }
}
