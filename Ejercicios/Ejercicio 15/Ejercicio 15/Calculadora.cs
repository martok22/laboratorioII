using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static int Calcular(int num1, int num2, string operador)
        {
            if (operador == "+") return num1 + num2;
            if (operador == "-") return num1 - num2;
            if (operador == "*") return num1 * num2;
            if (operador == "/" && Validar(num2)) return num1 / num2;
            else
                return 0;
        }

        private static bool Validar(int num2)
        {
            bool retorno = false;
            if (num2 != 0) retorno = true;
            return retorno;
        }

        public static void Mostrar(int resultado)
        {
            System.Console.WriteLine("El resultado de la operacion es: " + resultado);
        }
    }
}
