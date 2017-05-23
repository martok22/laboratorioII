using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            bool respuesta=true;
            string ingreso;
            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Ingrese numero entre -100 y 100: ");
                ingreso=Console.ReadLine();
                while(!int.TryParse(ingreso, out num1)
                {
                    Console.WriteLine("Error. Ingrese numero: ");
                    ingreso=Console.ReadLine();
                }
                num1 = int.Parse(ingreso);
                while(!(respuesta=Validación.Validar(num1,-100,100)))
                {
                    Console.WriteLine("Error, el numero no se encuentra dentro del rango -100 y 100");
                    Console.ReadLine();
                }
            }
        }
    }
}
