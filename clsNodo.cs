using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos
{
    public class clsNodo
    {
        private int dato;
        private clsNodo refN;

        public clsNodo(int dato)
        {
            this.dato = dato;
            this.refN = null;
        }

        public int getDato()
        {
            return dato;
        }

        public void setDato(int dato)
        {
            this.dato = dato;
        }

        public clsNodo getRefN()
        {
            return refN;
        }

        public void setRefN(clsNodo refN)
        {
            this.refN = refN;
        }
    }
}
