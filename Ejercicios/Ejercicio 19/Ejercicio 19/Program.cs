using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio_19_Clases.Boligrafo boli1 = new Ejercicio_19_Clases.Boligrafo(ConsoleColor.Blue, 100);
            Ejercicio_19_Clases.Boligrafo boli2 = new Ejercicio_19_Clases.Boligrafo(ConsoleColor.Red, 50);
            Console.WriteLine("El boligrafo 1 tiene tinta de color" + boli1.GetColor() + " y tiene " + boli1.GetTinta() + " de tinta");
            Console.WriteLine("El boligrafo 2 tiene tinta de color" + boli2.GetColor() + " y tiene " + boli2.GetTinta() + " de tinta");
            if (boli1.Pintar(25)) Console.WriteLine("Se pinto y ahora la tinta del boli 1 es " + boli1.GetTinta());
            boli1.Recargar();
            Console.WriteLine("Recargamo y ahora la tinta del boli 1 es: "+boli1.GetTinta());

            Ejercicio_19_Clases.Boligrafo boli3 = new Ejercicio_19_Clases.Boligrafo(ConsoleColor.Black);
            Console.WriteLine("El boligrafo 3 tiene tinta de color" + boli3.GetColor() + " y tiene " + boli3.GetTinta() + " de tinta");
            Console.ReadLine();

        }
    }
}
