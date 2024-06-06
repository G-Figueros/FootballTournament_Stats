using clsEstructuraDatos.ListaSimple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.TablasHash
{
    public class clsTablaDispercionModCol
    {
        public static readonly int M = 250;
        clsLista[] tabla = new clsLista[M];

        public int FuncionHash(string x)
        {
            int numericValue = 0;
            foreach (char item in x)
            {
                numericValue += (int)item;
            }
            return (numericValue % M);
        }

        public void Insertar(Object Dato, String Clave)
        {
            int pos = 0;
            pos = FuncionHash(Clave);
            if (tabla[pos] == null)
            {
                tabla[pos] = new clsLista();
            }
            tabla[pos].insertHeaderLista(Dato);
        }

        public Object Buscar(String clave)
        {
            int pos = 0;
            string[] claves = clave.Split(" ");
            pos = FuncionHash(claves[1]);
            if (tabla[pos] == null)
            {
                return null;
            }
            return tabla[pos].readNodos(clave);
        }

        public void Actualizar(Object Dato, String clave)
        {
            int pos = 0;
            string[] claves = clave.Split(" ");
            pos = FuncionHash(claves[1]);
            if (tabla[pos] == null)
            {
                return;
            }
            tabla[pos].updateNodos(Dato, clave);

        }

        public void Eliminar(Object Dato, String clave)
        {
            int pos = 0;
            string[] claves = clave.Split(" ");
            pos = FuncionHash(claves[1]);
            if (tabla[pos] == null)
            {
                return;
            }
            tabla[pos].deleteNodos(Dato);
        }
    }
}
