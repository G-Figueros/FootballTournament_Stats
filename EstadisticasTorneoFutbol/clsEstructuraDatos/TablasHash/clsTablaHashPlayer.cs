using clsEstructuraDatos.ListaSimple;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.TablasHash
{
    public class clsTablaHashPlayer
    {
        public static readonly int M = 300;
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

        public clsLista buscarLista(String claveTabla)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            return tabla[pos];
        }

        public Object Buscar(String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            return tabla[pos].readNodoPlayer(claveLista);
        }

        public void Actualizar(Object Dato, String claveTabla, int claveLista)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].updatePlayerList(Dato, claveLista);
        }

        public void ActualizarGoles(String claveTabla, int claveLista, int count)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].updateGoals(claveLista, count);
        }

        public void ActualizarTarjetasAmarillas(String claveTabla, int claveLista, int count)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].updateYellowCards(claveLista, count);
        }

        public void ActualizarTarjetasRojas(String claveTabla, int claveLista, int count)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].updateRedCards(claveLista, count);
        }

        public void ActualizarMinutos(String claveTabla, int claveLista, int count)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].updateMinutes(claveLista, count);
        }

        public void Eliminar(Object Dato, String claveTabla)
        {
            int pos = 0;
            pos = FuncionHash(claveTabla);
            tabla[pos].deleteNodos(Dato);
        }
    }
}
