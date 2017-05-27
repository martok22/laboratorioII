using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploParcial;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            // Para mañana poder anadir una moto y un auto con la misma patente, 
            // Si los objetos son de distinta clase, se pueden agregar.
            Estacionamiento estacionamiento = "nuevo";

            estacionamiento = estacionamiento + new Auto("A3", 4);
            estacionamiento = estacionamiento - new Auto("A3", 4);
        }
    }
}
