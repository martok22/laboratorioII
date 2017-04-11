using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Metro
    {
        public int cantidad;

        private Metro(int cant)
        {
            Metro.cantidad = cant;
        }

        public static implicit operator Metro(Kilometro k1)
        {
            return new Metro(k1*1000);
        }
 
        public static Metro  operator +(Metro metros,Kilometro kilometros)
        {
            return new Metro(metros.cantidad+(kilometros.cantidad*1000));
            
        }
    }
}