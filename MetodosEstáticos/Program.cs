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
            int elMayor;
            string dato;
            //Console.WriteLine("Hola Mundo");
            elMayor=Comparadora.RetornarMayor(10,5);
            Sello.mensaje = "nuevo mensaje";
            Sello.color = ConsoleColor.Red;
            dato=Sello.Imprimir();
            Sello.ImprimirEnColor();
            
        }
    }
}
