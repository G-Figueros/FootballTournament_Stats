using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clsEstructuraDatos.Interfaces;

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
