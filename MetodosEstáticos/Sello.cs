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
            return mensaje;
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

        public static void ImprimirFilaAsteriscos(int longCadena)
        {
            for (int contador = 0; contador < longCadena + 2; contador++)
            {
                Console.Write("*");
            }
        }

        public static void ImprimirConDeco()
        {
            int longitudMensaje;
            longitudMensaje = mensaje.Length;
            if (longitudMensaje > 0)
            {
                ImprimirFilaAsteriscos(longitudMensaje);
                Console.Write("\n");
                Console.Write("*");
                Console.WriteLine(Sello.mensaje+"*");
                ImprimirFilaAsteriscos(longitudMensaje);
            }
            
        }

        

    }
}
