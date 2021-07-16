using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos
{
    public class clsCola
    {
        private clsNodo nPrimero, nUltimo;
        public clsCola()
        {
            nPrimero = nUltimo = null;
        }
        //Insertar Cola
        public void push(int dato)
        {
            clsNodo nAux = new clsNodo(dato);
            if (nPrimero == null && nUltimo == null)
            {
                nPrimero = nUltimo = nAux;
            }
            else
            {
                nUltimo.setRefN(nAux);
                nUltimo = nAux;
            }
        }
        //Eliminar
        public int pop()
        {
            int n = -1;
            if (!estaVacia())
            {
                n = nPrimero.getDato();
                if (nPrimero.getRefN() == null)
                {
                    nPrimero = nUltimo = null;
                }
                else
                {
                    nPrimero = nPrimero.getRefN();
                }
            }
            return n;
        }
        public Boolean estaVacia()
        {
            if (nPrimero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public clsNodo getnPrimero()
        {
            return nPrimero;
        }
        public void setnPrimero(clsNodo nPrimero)
        {
            this.nPrimero = nPrimero;
        }
        public clsNodo getnUltimo()
        {
            return nUltimo;
        }
        public void setnUltimo(clsNodo nUltimo)
        {
            this.nUltimo = nUltimo;
        }
    }
}
