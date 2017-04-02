using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0;
            char respuesta;
            string aParsear;
            do
            {
                Console.WriteLine("Ingrese numero a sumar: ");
                aParsear = Console.ReadLine();
                while (!int.TryParse(aParsear, out num))
                {
                    Console.WriteLine("Error. Ingrese nro: ");
                    aParsear = Console.ReadLine();
                }
                num = int.Parse(aParsear);
                suma = suma + num;
                Console.WriteLine("Desea seguir ingresando numeros? Responda S/N");
            }
        }
    }
}
