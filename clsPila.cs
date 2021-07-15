using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos
{
    public class clsPila
    {
        private clsNodo tope;
        public clsPila()
        {
            this.tope = null;
        }

        public clsNodo getTope()
        {
            return tope;
        }

        public void setTope(clsNodo tope)
        {
            this.tope = tope;
        }
        public Boolean estaVacia()
        {
            return (this.tope == null) ? true : false;
        }
        //Metodo Insertar Nodo
        public void push(int dato)
        {
            clsNodo aux = new clsNodo(dato);
            if (estaVacia())
            {
                this.tope = aux;
            }
            else
            {
                aux.setRefN(this.tope);
                this.tope = aux;
            }
        }
        //Metodo eliminar Nodo
        public int pop()
        {
            int n = -1;
            if (!estaVacia())
            {
                n = this.tope.getDato();
                this.tope = this.tope.getRefN();
            }
            return n;
        }
    }
}
