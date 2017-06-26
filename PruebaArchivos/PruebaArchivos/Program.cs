using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PruebaArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>();
            Texto archivo = new Texto("historico.dat");
            archivo.Leer(out lista);
            foreach(string a in lista)
            {
                Console.WriteLine(a);
            }
            Console.Read();
        }
    }
}
