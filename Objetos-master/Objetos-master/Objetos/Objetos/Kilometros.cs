using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Kilometro
    {
        private Kilometro(int cantidad)
        {
            this.cantidad = cantidad;
        }
        public static Kilometro Sumar(Kilometro k1, Kilometro  k2)
        {
            Kilometro aux;

            aux = new Kilometro(0);
            aux.cantidad = k1.cantidad + k2.cantidad;
            return aux;
        }
        public static Kilometro operator +(Kilometro k1, Kilometro k2)
        {
            Kilometro aux;

            aux = new Kilometro(0);
            aux.cantidad = k1.cantidad + k2.cantidad;
            return aux;
        }
        public static int operator +(Kilometro k1, int k2)
        {
            int aux;

            aux = k1.cantidad + k2;
            return aux;
        }
        public int cantidad;

        public static bool operator ==(Kilometro k1, Kilometro k2)
        {
            if (k1.cantidad == k2.cantidad)
                return true;
            return false;
        }
        public static bool operator !=(Kilometro k1, Kilometro k2)
        {
            
            return !(k1==k2);
        }

        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }

        public static implicit operator int(Kilometro k1)
        {
            return k1.cantidad;
        }

    }
}
