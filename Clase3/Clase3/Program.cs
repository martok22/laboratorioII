using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Rueda miRueda = new Rueda();
            Rueda otraRueda = new Rueda();
            Auto.CantidadDeInstancias = 0;
            Auto miAuto = new Auto();

            Auto miAuto1 = new Auto();
            Auto miAuto2 = new Auto();
            Auto miAuto3 = new Auto();
            Auto miAuto4 = new Auto();

            eFabricante fabricante;
            fabricante = eFabricante.CHEVROLET;
            fabricante = (eFabricante)0;

        }
    }
}
