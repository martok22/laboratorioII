using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3, num2 = 4,resultado;
            string operador = "+";
            Calculadora.Mostrar(Calculadora.Calcular(num1, num2, operador));
            System.Console.ReadLine();

        }
    }
}
