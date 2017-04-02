using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ejercicio_11
{
    
    class Validación
    {
        

        public static bool Validar (int num, int min, int max)
        {
            bool retorno = false;
            if ( max < min )
            {
                int aux;
                min = aux;
                min = max;
                max = aux;
            }
            if (num >= min && num <= max) retorno = true;
            return retorno;
        }
    }
}
