using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEstructuraDatos.Interfaces;
using clsEstructuraDatos.Modelos;

namespace clsEstructuraDatos.ArbolAVL
{
    public class clsArbolAVL
    {
        protected clsNodoAVL raiz;
        public int salto = 0;
        public int posicion = 0;
        public clsArbolAVL()
        {
            raiz = null;
        }

        public clsNodoAVL raizArbol()
        {
            return raiz;
        }

        protected Object buscar(clsNodoArbol raizSub, int buscado)
        {
            try
            {
                salto++;
                clsBalanceo posicion = new clsBalanceo();
                clsTeam team = (clsTeam)raizSub.valorNodo();
                if (raizSub == null)
                {
                    return null;
                }
                else if (team.igualQue(buscado))
                {
                    posicion.team = team;
                    posicion.balanceo = salto;
                    return posicion;
                }
                else if (team.menorQue(buscado))
                {
                    return buscar(raizSub.subArbolDcho(), buscado);
                }
                else
                {
                    return buscar(raizSub.subArbolIzdo(), buscado);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        protected Object buscarPorNombre(clsNodoArbol raizSub, string buscado)
        {
            try
            {
                clsTeam team = (clsTeam)raizSub.valorNodo();
                if (raizSub == null)
                {
                    return null;
                }
                else if (team.igualQue(buscado))
                {
                    return team;
                }
                else if (team.menorQue(buscado))
                {
                    return buscarPorNombre(raizSub.subArbolDcho(), buscado);
                }
                else
                {
                    return buscarPorNombre(raizSub.subArbolIzdo(), buscado);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Object buscarPorNombre(string dato)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return buscarPorNombre(raizArbol(), dato);
            }
        }

        public Object buscar(int dato)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                return buscar(raizArbol(), dato);
            }
        }

        public void actualizar(Object valor)
        {
            Comparador dato;
            Logical h = new Logical(false);
            dato = (Comparador)valor;
            raiz = actualizarAvl(raiz, dato, h);
        }

        private clsNodoAVL actualizarAvl(clsNodoAVL raiz, Comparador dt, Logical h)
        {
            clsNodoAVL n1;
            clsTeam team = (clsTeam)raiz.valorNodo();
            if (dt.igualQue(team.name))
            {
                raiz.nuevoValor(dt);
                h.setLogical(true);
            }
            else if (dt.menorQue(team.name))
            {
                clsNodoAVL iz;
                iz = actualizarAvl((clsNodoAVL)raiz.subArbolIzdo(), dt, h);
                raiz.ramaIzdo(iz);
            }
            else if (dt.mayorQue(team.name))
            {
                clsNodoAVL dr;
                dr = actualizarAvl((clsNodoAVL)raiz.subArbolDcho(), dt, h);
                raiz.ramaDcho(dr);
            }
            return raiz;
        }

        public void insertar(Object valor)//throws Exception
        {
            Comparador dato;
            Logical h = new Logical(false); // intercambia un valor booleano
            dato = (Comparador)valor;
            raiz = insertarAvl(raiz, dato, h);
        }

        private clsNodoAVL insertarAvl(clsNodoAVL raiz, Comparador dt, Logical h)
        //throws Exception
        {
            clsNodoAVL n1;
            if (raiz == null)
            {
                raiz = new clsNodoAVL(dt);
                this.posicion += 1;
                h.setLogical(true);
            }
            else
            {
                clsTeam Team = (clsTeam)raiz.valorNodo();
                if (dt.menorQue(Team.name))
                {
                    clsNodoAVL iz;
                    iz = insertarAvl((clsNodoAVL)raiz.subArbolIzdo(), dt, h);
                    raiz.ramaIzdo(iz);
                    // regreso por los nodos del camino de búsqueda
                    if (h.booleanValue())
                    {
                        // decrementa el fe por aumentar la altura de rama izquierda
                        switch (raiz.fe)
                        {
                            case 1:
                                raiz.fe = 0;
                                h.setLogical(false);
                                break;
                            case 0:
                                raiz.fe = -1;
                                break;
                            case -1: // aplicar rotación a la izquierda
                                n1 = (clsNodoAVL)raiz.subArbolIzdo();
                                if (n1.fe == -1)
                                    raiz = rotacionII(raiz, n1);
                                else
                                    raiz = rotacionID(raiz, n1);
                                h.setLogical(false);
                                break;
                        }
                    }
                }
                else if (dt.mayorQue(Team.name))
                {
                    clsNodoAVL dr;
                    dr = insertarAvl((clsNodoAVL)raiz.subArbolDcho(), dt, h);
                    raiz.ramaDcho(dr);
                    // regreso por los nodos del camino de búsqueda
                    if (h.booleanValue())
                    {
                        // incrementa el fe por aumentar la altura de rama izquierda
                        switch (raiz.fe)
                        {
                            case 1: // aplicar rotación a la derecha
                                n1 = (clsNodoAVL)raiz.subArbolDcho();
                                if (n1.fe == +1)
                                    raiz = rotacionDD(raiz, n1);
                                else
                                    raiz = rotacionDI(raiz, n1);
                                h.setLogical(false);
                                break;
                            case 0:
                                raiz.fe = +1;
                                break;
                            case -1:
                                raiz.fe = 0;
                                h.setLogical(false);
                                break;
                        }
                    }
                }
                else
                    throw new Exception("No puede haber claves repetidas ");
            }
            return raiz;
        }

        public void eliminar(Object valor) //throws Exception
        {
            Comparador dato;
            dato = (Comparador)valor;
            Logical flag = new Logical(false);
            raiz = borrarAvl(raiz, dato, flag);
        }

        private clsNodoAVL borrarAvl(clsNodoAVL r, Comparador clave, Logical cambiaAltura) //throws Exception
        {
            if (r == null)
            {
                throw new Exception(" Nodo no encontrado ");
            }
            else if (clave.menorQue(r.valorNodo()))
            {
                clsNodoAVL iz;
                iz = borrarAvl((clsNodoAVL)r.subArbolIzdo(), clave, cambiaAltura);
                r.ramaIzdo(iz);
                if (cambiaAltura.booleanValue())
                    r = equilibrar1(r, cambiaAltura);
            }
            else if (clave.mayorQue(r.valorNodo()))
            {
                clsNodoAVL dr;
                dr = borrarAvl((clsNodoAVL)r.subArbolDcho(), clave, cambiaAltura);
                r.ramaDcho(dr);
                if (cambiaAltura.booleanValue())
                    r = equilibrar2(r, cambiaAltura);
            }
            else // Nodo encontrado
            {
                clsNodoAVL q;
                q = r; // nodo a quitar del árbol
                if (q.subArbolIzdo() == null)
                {
                    r = (clsNodoAVL)q.subArbolDcho();
                    cambiaAltura.setLogical(true);
                }
                else if (q.subArbolDcho() == null)
                {
                    r = (clsNodoAVL)q.subArbolIzdo();
                    cambiaAltura.setLogical(true);
                }
                else
                { // tiene rama izquierda y derecha
                    clsNodoAVL iz;
                    iz = reemplazar(r, (clsNodoAVL)r.subArbolIzdo(), cambiaAltura);
                    r.ramaIzdo(iz);
                    if (cambiaAltura.booleanValue())
                        r = equilibrar1(r, cambiaAltura);
                }
                q = null;
            }
            return r;
        }

        private clsNodoAVL reemplazar(clsNodoAVL n, clsNodoAVL act, Logical cambiaAltura)
        {
            if (act.subArbolDcho() != null)
            {
                clsNodoAVL d;
                d = reemplazar(n, (clsNodoAVL)act.subArbolDcho(), cambiaAltura);
                act.ramaDcho(d);
                if (cambiaAltura.booleanValue())
                    act = equilibrar2(act, cambiaAltura);
            }
            else
            {
                n.nuevoValor(act.valorNodo());
                n = act;
                act = (clsNodoAVL)act.subArbolIzdo();
                n = null;
                cambiaAltura.setLogical(true);
            }
            return act;
        }

        private clsNodoAVL rotacionII(clsNodoAVL n, clsNodoAVL n1)
        {
            n.ramaIzdo(n1.subArbolDcho());
            n1.ramaDcho(n);
            if (n1.fe == -1)
            {
                n.fe = 0;
                n1.fe = 0;
            }
            else
            {
                n.fe = -1;
                n1.fe = 1;
            }
            return n1;
        }

        private clsNodoAVL rotacionDD(clsNodoAVL n, clsNodoAVL n1)
        {
            n.ramaDcho(n1.subArbolIzdo());
            n1.ramaIzdo(n);
            if (n1.fe == +1)
            {
                n.fe = 0;
                n1.fe = 0;
            }
            else
            {
                n.fe = +1;
                n1.fe = -1;
            }
            return n1;
        }

        private clsNodoAVL rotacionID(clsNodoAVL n, clsNodoAVL n1)
        {
            clsNodoAVL n2;
            n2 = (clsNodoAVL)n1.subArbolDcho();
            n.ramaIzdo(n2.subArbolDcho());
            n2.ramaDcho(n);
            n1.ramaDcho(n2.subArbolIzdo());
            n2.ramaIzdo(n1);
            if (n2.fe == +1)
                n1.fe = -1;
            else
                n1.fe = 0;
            if (n2.fe == -1)
                n.fe = 1;
            else
                n.fe = 0;
            n2.fe = 0;
            return n2;
        }

        private clsNodoAVL rotacionDI(clsNodoAVL n, clsNodoAVL n1)
        {
            clsNodoAVL n2;
            n2 = (clsNodoAVL)n1.subArbolIzdo();
            n.ramaDcho(n2.subArbolIzdo());
            n2.ramaIzdo(n);
            n1.ramaIzdo(n2.subArbolDcho());
            n2.ramaDcho(n1);
            if (n2.fe == +1)
                n.fe = -1;
            else
                n.fe = 0;
            if (n2.fe == -1)
                n1.fe = 1;
            else
                n1.fe = 0;
            n2.fe = 0;
            return n2;
        }

        private clsNodoAVL equilibrar1(clsNodoAVL n, Logical cambiaAltura)
        {
            clsNodoAVL n1;
            switch (n.fe)
            {
                case -1:
                    n.fe = 0;
                    break;
                case 0:
                    n.fe = 1;
                    cambiaAltura.setLogical(false);
                    break;
                case +1: //se aplica un tipo de rotación derecha
                    n1 = (clsNodoAVL)n.subArbolDcho();
                    if (n1.fe >= 0)
                    {
                        if (n1.fe == 0) //la altura no vuelve a disminuir
                            cambiaAltura.setLogical(false);
                        n = rotacionDD(n, n1);
                    }
                    else
                        n = rotacionDI(n, n1);
                    break;
            }
            return n;
        }

        private clsNodoAVL equilibrar2(clsNodoAVL n, Logical cambiaAltura)
        {
            clsNodoAVL n1;
            switch (n.fe)
            {
                case -1: // Se aplica un tipo de rotación izquierda
                    n1 = (clsNodoAVL)n.subArbolIzdo();
                    if (n1.fe <= 0)
                    {
                        if (n1.fe == 0)
                            cambiaAltura.setLogical(false);
                        n = rotacionII(n, n1);
                    }
                    else
                        n = rotacionID(n, n1);
                    break;
                case 0:
                    n.fe = -1;
                    cambiaAltura.setLogical(false);
                    break;
                case +1:
                    n.fe = 0;
                    break;
            }
            return n;
        }

        /////////////////////////////////
        /// <summary>
        /// Comprueba el estatus del árbol
        /// </summary>
        /// <returns></returns>
        bool esVacio()
        {
            return raiz == null;
        }

        public static clsNodoAVL nuevoArbol(clsNodoAVL ramaIzqda, Object dato, clsNodoAVL ramaDrcha)
        {
            return new clsNodoAVL(dato, ramaIzqda, ramaDrcha);
        }

        public static List<clsTeam> orden(clsNodoArbol r, List<clsTeam> lista)
        {
            if (r != null)
            {
                lista.Add((clsTeam)r.valorNodo());
                if (r.subArbolIzdo() != null)
                {
                    orden(r.subArbolIzdo(), lista);
                }
                if (r.subArbolDcho() != null)
                {
                    orden(r.subArbolDcho(), lista);
                }
            }
            return lista;
        }

        //binario en preorden
        public static string preorden(clsNodoArbol r)
        {
            if (r != null)
            {
                return r.visitar() + preorden(r.subArbolIzdo()) + preorden(r.subArbolDcho());
            }
            return "";
        }

        // Recorrido de un árbol binario en inorden
        public static string inorden(clsNodoArbol r)
        {
            if (r != null)
            {
                return inorden(r.subArbolIzdo()) + r.visitar() + inorden(r.subArbolDcho());
            }
            return "";
        }

        // Recorrido de un árbol binario en postorden
        public static string postorden(clsNodoArbol r)
        {
            if (r != null)
            {
                return postorden(r.subArbolIzdo()) + postorden(r.subArbolDcho()) + r.visitar();
            }
            return "";
        }

        //Devuelve el número de nodos que tiene el árbol
        public static int numNodos(clsNodoArbol raiz)
        {
            if (raiz == null)
                return 0;
            else
                return 1 + numNodos(raiz.subArbolIzdo()) +
                numNodos(raiz.subArbolDcho());
        }
    }
}
