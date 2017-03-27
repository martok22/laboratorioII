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

        public static void ImprimirConDeco()
        {
            int longitudMensaje;
            longitudMensaje = mensaje.Length;
            if (longitudMensaje > 0)
            {
                Console.Write("*");
                //Console.WriteLine(longitudMensaje);
                for(int contador = 0; contador < longitudMensaje; contador++ )
                {
                    Console.Write("*");
                }
                Console.Write("*\n");
                Console.Write("*");
                Console.WriteLine(Sello.mensaje+"*");
                //Sello.ImprimirEnColor();
                //Console.Write("*\n");
                Console.Write("*");
                for (int contador = 0; contador < longitudMensaje; contador++)
                {
                    Console.Write("*");
                }
                Console.Write("*\n"); 
            }
            //Console.Write("*");
        }
    }
}
