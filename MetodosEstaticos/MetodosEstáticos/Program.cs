using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstáticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int elMayor, otroNum;
            string dato;
            //Console.WriteLine("Hola Mundo");
            elMayor = Comparadora.RetornarMayor(10, 5);
            Sello.mensaje = "nuevo mensaje";
            Sello.color = ConsoleColor.Green;
            dato = Sello.Imprimir();
            Sello.ImprimirEnColor();
            Console.ReadLine();
            otroNum = dato.Length;
            Console.WriteLine(otroNum);
            Console.ReadLine();
            Sello.ImprimirConDeco();
            Console.ReadLine();
            Sello.mensaje = "otro mensaje para probar";
            Sello.ImprimirConDeco();
            Console.ReadLine();

        }
    }
}
