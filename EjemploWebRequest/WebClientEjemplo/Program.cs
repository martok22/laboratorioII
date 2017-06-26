using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebClientEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri objeto = new Uri("http://www.google.com.ar");
            Descargador descarga = new Descargador(objeto);
            descarga.IniciarDescarga();
            System.Console.WriteLine(descarga.html);
            Console.Read();
        }
    }
}
