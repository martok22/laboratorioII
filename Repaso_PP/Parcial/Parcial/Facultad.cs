using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial
{
    public class Facultad
    {
        private static int _num;

        
        public Facultad()
        {
            // no se puede utilizar el this con atributos estaticos 
            // aun fuera del constr estatico
            _num = 22;
        }

        static Facultad()
        {
            //Facultad._num = 22;
            _num = 33;
        }

        //public static implicit operator int

        public static void Mostrar (Facultad a)
        {
            Console.WriteLine("El nombre es: " + a._num);
        }


    }
}
