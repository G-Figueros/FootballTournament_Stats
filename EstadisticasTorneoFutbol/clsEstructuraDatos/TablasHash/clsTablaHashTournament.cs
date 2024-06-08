using clsEstructuraDatos.Modelos;
using clsEstructuraDatos.ArbolAVL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.TablasHash
{
    public class clsTablaHashTournament
    {
        public static readonly int M = 300;

        public clsTournament[] tabla = new clsTournament[M];

        public int FuncionHash(string x)
        {
            int numericValue = 0;
            foreach (char item in x)
            {
                numericValue += (int)item;
            }
            return (numericValue % M);
        }

        public void Insertar(String clave)
        {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                tabla[pos] = new clsTournament();
                tabla[pos].tournamentName = clave;
                tabla[pos].avlTournament = new clsArbolAVL();
            }
            else
            {
                return;
            }
        }

        public void Actualizar(string Dato, String clave)
        {
            int pos = 0;
            int posNuevo = 0;
            clsTournament torneoAnterior;
            pos = FuncionHash(clave);
            posNuevo = FuncionHash(Dato);
            if (tabla[pos] == null)
            {
                return;
            }
            else
            {
                torneoAnterior = tabla[pos];
                torneoAnterior.tournamentName = Dato;
                tabla[posNuevo] = torneoAnterior;
                tabla[pos] = null;
            }
        }

        public Object Buscar(String clave)
        {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                return null;
            }
            else
            {
                return tabla[pos];
            }
        }

        public void Eliminar(String clave)
        {
            int pos = 0;
            pos = FuncionHash(clave);
            if (tabla[pos] == null)
            {
                return;
            }
            tabla[pos] = null;
        }
    }
}
