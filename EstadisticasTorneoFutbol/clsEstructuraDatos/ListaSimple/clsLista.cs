using clsEstructuraDatos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.ListaSimple
{
    public class clsLista
    {
        public clsNodo vtHeader { get; set; }

        public clsLista()
        {
            vtHeader = null;
        }

        public void insertHeaderLista(object objNodo)
        {
            clsNodo nuevoNodo = new clsNodo(objNodo);
            nuevoNodo.Enlace = vtHeader;
            vtHeader = nuevoNodo;
        }

        public Object readNodos(string strNodo)
        {
            string[] nombre = strNodo.Split(" ");
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.name == nombre[0])
                {
                    return player;
                }
            }
            return null;
        }

        public clsLista updateNodos(Object vDato, string strNodo)
        {
            string[] nombre = strNodo.Split(" ");
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.name == nombre[0])
                {
                    indice.Dato = vDato;
                }
            }
            return this;
        }

        public void deleteNodos(Object vDato)
        {
            clsNodo actual, anterior;
            Boolean encontrado;
            actual = vtHeader;
            anterior = null;
            encontrado = false;
            while ((actual != null) && (!encontrado))
            {
                encontrado = (actual.Dato.Equals(vDato));
                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.Enlace;
                }
            }

            if (actual != null)
            {
                if (actual == vtHeader)
                {
                    vtHeader = actual.Enlace;
                }
                else
                {
                    anterior.Enlace = actual.Enlace;
                }
                actual = null;
            }
        }
    }
}
