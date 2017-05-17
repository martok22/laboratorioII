using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro perro1 = new Perro("Jorge", "Dobberman");
            Perro perro2 = new Perro("Firulais", "Caniche Toy", 10, true);
            Gato gato1 = new Gato("Garfield", "Siames");
            Grupo grupo1 = new Grupo("Manada");

            System.Console.WriteLine(perro1.ToString());
            System.Console.WriteLine(gato1.ToString());

            // pruebo operadores

            grupo1 += perro1;
            grupo1 += gato1;

            // explicito a string: muestro lista
            System.Console.WriteLine((string)grupo1);

            grupo1 -= perro1;

            // explicito a string: muestro lista
            System.Console.WriteLine((string)grupo1);
            System.Console.ReadKey();

            

        }
    }
}
