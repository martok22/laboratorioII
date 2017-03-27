using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Calculos
    {
        public static int num, max, min, num2;
        public static string dato;
        public static bool a;

        public static void PedirNumeros()
        {
            
            for(int contador = 0; contador < 5; contador++)
            {
                
                Console.WriteLine("Ingrese un nro: ");
                dato = Console.ReadLine();

                while (!int.TryParse(dato, out num))
                {
                    Console.WriteLine("Error. Ingrese nro: ");
                    dato = Console.ReadLine();
                }
                num = int.Parse(dato);
                if (contador == 0)
                {
                    max = num;
                    min = num;
                }
                else
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                }
                    



            }
        }
    }
}
