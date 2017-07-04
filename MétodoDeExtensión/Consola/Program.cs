using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using Clases_2;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno(1, true, "Jorge", "22222222");
            Extensora.MostrarDatos(alumno1);
            Console.WriteLine(alumno1.MostrarDatos());
            "asdsad".MostrarDatos();
            int a = 3;
            
            
            Console.ReadLine();
        }
    }

    public static class Extensora
    {
        public static string MostrarDatos(this Alumno aux)
        {
            return aux.ToString();
        }

        public static string MostrarDatos(this Alumno aux, this Alumno aux2)
        {
            return "";
        }

        public static string MostrarDatos(this string aux)
        {
            return "zz";
        }

        public static int MostrarDatos(this int aux)
        {
            return 3;
        }
    }
}
