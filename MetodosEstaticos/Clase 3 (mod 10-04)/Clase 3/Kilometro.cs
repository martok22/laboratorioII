using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Kilometro
    {
        public int cantidad;

        public Kilometro(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public static Kilometro operator + (Kilometro km1, Kilometro km2)
        {
            Kilometro retorno = new Kilometro(0);
            retorno.cantidad = km1.cantidad + km2.cantidad;
            return retorno;
        }

        public static int operator +(Kilometro km1, int km2)
        {
            int retorno;
            retorno = km1.cantidad + km2;
            return retorno;
        }

        public static bool operator ==(Kilometro km1, Kilometro km2)
        {
            bool retorno=false;
            if(km1.cantidad==km2.cantidad) retorno=true;
            return retorno;
        }

        public static bool operator !=(Kilometro km1, Kilometro km2)
        {
            return !(km1==km2);
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
