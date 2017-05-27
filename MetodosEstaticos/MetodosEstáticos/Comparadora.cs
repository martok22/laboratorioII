using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstáticos
{
    class Comparadora
    {
        /// <summary>
        /// Retorna el mayor de dos numeros
        /// </summary>
        /// <param name="num1">el primero de los dos numeros</param>
        /// <param name="num2">el segundo de los dos numeros</param>
        /// <returns></returns>
        public static int RetornarMayor(int num1, int num2)
        {
            int retorno=0;

            if (num1 > num2)
                retorno = num1;
            else
                retorno = num2;

            return retorno;
        }

        /// <summary>
        /// Muestra el numero del medio entre 3
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="num3"></param>
        /// <returns></returns>

        public static int MuestraElDelMedio(int num1, int num2, int num3)
        {
            int retorno = 0;
            if (num1 > num2)
                if (num1 > num3 && num3 > num2)
                    return num3;
                else
                    return num2;
            else
                if (num2 > num3)
                    return num3;
                else
                    return num2;
        }


    }
}
