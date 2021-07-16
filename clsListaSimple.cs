using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructura_de_Datos
{
    public class clsListaSimple
    {
        private clsNodo objLS;
        public int tamanio;
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
        public int getTamanio()
        {
            return tamanio;
        }
        public Boolean esVacia()
        {
            return objLS == null;
        }      
        public void InsertarOrdenadoMenorAMayor(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if (objLS == null)
            {
                objLS = nA;
            }
            else
            {
                if (nA.getDato() < objLS.getDato())
                {
                    nA.setRefN(objLS);
                    objLS = nA;
                }
                else
                {
                    clsNodo copyLS = objLS;
                    while (copyLS.getRefN() != null && nA.getDato() > (copyLS.getRefN()).getDato())
                    {
                        copyLS = copyLS.getRefN();
                    }
                    nA.setRefN(copyLS.getRefN());
                    copyLS.setRefN(nA);
                }
            }
            tamanio++;
        }
        public void Elimnar(int dato)
        {
            if(objLS != null)
            {
                if (objLS.getDato() == dato)
                {
                    objLS = objLS.getRefN();
                }
                else
                {
                    clsNodo copyLS = objLS;
                    while(dato < copyLS.getDato() && copyLS.getRefN() != null)
                    {
                        if((copyLS.getRefN()).getDato() == dato)
                        {
                            copyLS.setRefN((copyLS.getRefN()).getRefN());
                        }
                        else
                        {
                            copyLS = copyLS.getRefN();
                        }
                    }
                }
            }
            tamanio--;
        }
        public int EliminarPorPosicion(int posicion)
        {
            clsNodo incio = new clsNodo(posicion);
            if(posicion >= 0 && posicion < tamanio)
            {
                if(posicion == 0)
                {
                    incio = incio.getRefN();
                }
                else
                {
                    clsNodo copyLS = objLS;
                    for(int i = 0; i < posicion; i++)
                    {
                        copyLS = copyLS.getRefN();
                    }
                    clsNodo siguiente = copyLS.getRefN();
                    copyLS.setRefN(siguiente.getRefN());
                }
                tamanio++;
            }
            return posicion;
        }
        public int SumarElementos() 
        {
            int n1 = 0;
            int n2 = 0;
            clsNodo nA = this.objLS;
            if (!esVacia())
            {
                while(nA.getRefN() != null)
                {
                    n1 = n1 + nA.getDato();
                    nA = nA.getRefN();
                }
                n2 = (n1 + nA.getDato());
            }
            return n2;
        }
        public int cantPrimos()
        {
            int can = 0;
            clsNodo nA = this.objLS;
            if (!esVacia())
            {
                while(nA.getRefN() != null)
                {
                    if (Primo(nA.getDato()))
                    {
                        can++;
                    }
                    nA = nA.getRefN();
                }
                if (Primo(nA.getDato()))
                {
                    can++;
                }
            }
            MessageBox.Show("La cantidad de primo en la lista es " + can);
            return can;
        }
        public Boolean Primo(int numero)
        {
            Boolean EsPrimoActual = true;
            if(numero < 2)
            {
                EsPrimoActual = false;
            }
            else
            {
                for(int i = 2; i * i <= numero; i++)
                {
                    if(numero % i == 0)
                    {
                        EsPrimoActual = false;
                        break;
                    }
                }
            }
            return EsPrimoActual;
        }
        public int canNodos()
        {
            clsNodo nA = objLS;
            int contador = 0;
            while(nA.getRefN() != null)
            {
                contador++;
                nA = nA.getRefN();
            }
            contador++;
            return contador;
        }
        public double Promedio()
        {
            int cant = 0;
            int proParcial = 0;
            double proTotal = 0;
            clsNodo nA = this.objLS;
            if (!esVacia())
            {
                while(nA.getRefN() != null)
                {
                    cant++;
                    proParcial = proParcial + nA.getDato();
                    nA = nA.getRefN();
                }
                proTotal = ((double)(proParcial + nA.getDato() / (cant + 1)));
            }
            MessageBox.Show("El promedio es " + proTotal);
            return proTotal;
        }
        public void InsertarUltimo(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if (objLS == null)
            {
                objLS = nA;
            }
            else
            {
                clsNodo copyLS = objLS;
                while (copyLS.getRefN() != null)
                {
                    copyLS = copyLS.getRefN();
                }
                copyLS.setRefN(nA);
            }
        }
        public void InsertarInicio(int dato)
        {
            clsNodo nA = new clsNodo(dato);
            if (objLS == null)
            {
                objLS = nA;
            }
            else
            {
                nA.setRefN(objLS);
                objLS = nA;
            }
        }
        public Boolean VerificarMenorAMayor()
        {
            clsNodo nA = objLS;
            Boolean verificar = false;
            while (nA.getRefN() != null)
            {
                if (nA.getDato() < (nA.getRefN()).getDato())
                {
                    verificar = true;
                }
                else
                {
                    verificar = false;
                    break;
                }
                nA = nA.getRefN();
            }
            return verificar;
        }
    }
}
