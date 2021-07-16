using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_Datos
{
    public class clsListaSimple
    {
        private clsNodo objLS;
        public clsListaSimple()
        {
            objLS = null;
        }
        public clsNodo getObjLS()
        {
            return objLS;
        }
        public void setObjLS(clsNodo objLS)
        {
            this.objLS = objLS;
        }
        public void InsertarUltimo(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if(objLS == null)
            {
                objLS = nA;
            }
            else
            {
                clsNodo copyLS = objLS;
                while(copyLS.getRefN() != null)
                {
                    copyLS = copyLS.getRefN();
                }
                copyLS.setRefN(nA);
            }
        }
        public void InsertarInicio(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if(objLS == null)
            {
                objLS = nA;
            }
            else
            {
                nA.setRefN(objLS);
                objLS = nA;
            }
        }
        public void InsertarOrdenado(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if(objLS == null)
            {
                objLS = nA;
            }
            else
            {
                if(nA.getDato() < objLS.getDato())
                {
                    nA.setRefN(objLS);
                    objLS = nA;
                }
                else
                {
                    clsNodo copyLS = objLS;
                    while(copyLS.getRefN() != null && nA.getDato() > (copyLS.getRefN()).getDato()){
                        copyLS = copyLS.getRefN();
                    }
                    nA.setRefN(copyLS.getRefN());
                    copyLS.setRefN(nA);
                }
            }
        }
    }
}
