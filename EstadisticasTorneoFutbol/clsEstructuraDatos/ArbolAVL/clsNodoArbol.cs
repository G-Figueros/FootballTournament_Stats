using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsEstructuraDatos.ArbolAVL
{
    public class clsNodoArbol
    {
        protected Object dato;
        protected clsNodoArbol izdo;
        protected clsNodoArbol dcho;

        public clsNodoArbol(Object valor)
        {
            dato = valor;
            izdo = dcho = null;
        }

        public clsNodoArbol(clsNodoArbol ramaIzdo, Object valor, clsNodoArbol ramaDcho)
        {
            this.dato = valor;
            this.izdo = ramaIzdo;
            this.dcho = ramaDcho;
        }

        // operaciones de acceso
        public Object valorNodo() { return dato; }
        public clsNodoArbol subArbolIzdo() { return izdo; }
        public clsNodoArbol subArbolDcho() { return dcho; }
        public void nuevoValor(Object d) { dato = d; }
        public void ramaIzdo(clsNodoArbol n) { izdo = n; }
        public void ramaDcho(clsNodoArbol n) { dcho = n; }
        public string visitar() { return dato.ToString(); }
    }
}
