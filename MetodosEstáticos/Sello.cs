using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstáticos
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            return "algo";
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor=Sello.color;
            Console.WriteLine(Sello.mensaje);
        }
    }
}
