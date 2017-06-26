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
            TTT juego = new TTT();
            System.Console.WriteLine(juego.ImprimirTicTaeToe());
            System.Console.Read();
        }
    }
}
