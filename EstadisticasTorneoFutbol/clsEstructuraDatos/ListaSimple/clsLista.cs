using clsEstructuraDatos.Modelos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.ListaSimple
{
    public class clsLista
    {
        public clsNodo vtHeader { get; set; }
        int contador { get; set; }
        public clsLista()
        {
            vtHeader = null;
        }

        public clsLista insertHeaderLista(object objNodo)
        {
            clsNodo nuevoNodo = new clsNodo(objNodo);
            nuevoNodo.Enlace = vtHeader;
            vtHeader = nuevoNodo;
            this.contador += 1;
            return this;
        }

        public void insertLista(List<Object> equipos)
        {
            foreach (clsTeam equipo in equipos)
            {
                if (vtHeader == null)
                {
                    clsNodo nuevo;
                    nuevo = new clsNodo(equipo);
                    nuevo.Enlace = vtHeader;
                    vtHeader = nuevo;
                }
                else
                {
                    clsNodo nuevo, indice;
                    for (indice = vtHeader; indice != null; indice = indice.Enlace)
                    {
                        clsTeam teamLista = (clsTeam)indice.Dato;
                        if (equipo.points > teamLista.points)
                        {
                            nuevo = new clsNodo(equipo);
                            nuevo.Enlace = vtHeader;
                            vtHeader = nuevo;
                            break;
                        }
                    }
                    if (indice == null)
                    {
                        nuevo = new clsNodo(equipo);
                        nuevo.Enlace = vtHeader;
                        vtHeader = nuevo;
                    }
                }
            }
        }

        public Object readNodoPlayer(int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    return player;
                }
            }
            
            return null;
        }

        public Object readNodoGame(int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsGame match = (clsGame)indice.Dato;
                if (match.id == rdNodo)
                {
                    return match;
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

        public clsLista updateYellowCards(int rdNodo, int nyc)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    player.yellowCards += nyc;
                    indice.Dato = player;
                }
            }
            return this;
        }

        public clsLista updateRedCards(int rdNodo, int nrc)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    player.redCards += nrc;
                    indice.Dato = player;
                }
            }
            return this;
        }

        public clsLista updateGoals(int rdNodo, int ng)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    player.goals += ng;
                    indice.Dato = player;
                }
            }
            return this;
        }

        public clsLista updateMinutes(int rdNodo, int mp)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    player.minutesPlayed += mp;
                    indice.Dato = player;
                }
            }
            return this;
        }

        public clsLista updateGameHomeGoals(int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsGame match = (clsGame)indice.Dato;
                if (match.id == rdNodo)
                {
                    match.homeGoalCount += 1;
                    indice.Dato = match;
                }
            }
            return this;
        }

        public clsLista updateGameVisitGoals(int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsGame match = (clsGame)indice.Dato;
                if (match.id == rdNodo)
                {
                    match.visitGoalCount += 1;
                    indice.Dato = match;
                }
            }
            return this;
        }

        public clsLista updatePlayerList(Object vDato, int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsPlayer player = (clsPlayer)indice.Dato;
                if (player.id == rdNodo)
                {
                    indice.Dato = vDato;
                }
            }
            return this;
        }

        public clsLista updateGameList(Object vDato, int rdNodo)
        {
            clsNodo indice;
            for (indice = vtHeader; indice != null; indice = indice.Enlace)
            {
                clsGame match = (clsGame)indice.Dato;
                if (match.id == rdNodo)
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
