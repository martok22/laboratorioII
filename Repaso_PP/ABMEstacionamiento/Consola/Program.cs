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
            // Para mañana poder anadir una moto y un auto con la misma patente, 
            // Si los objetos son de distinta clase, se pueden agregar.
            Estacionamiento estacionamiento = "nuevo";

            estacionamiento = estacionamiento + new Auto("A3", 4, new DateTime(1990,22,3));
            //estacionamiento = estacionamiento - new Auto("A3", 4);
            estacionamiento = estacionamiento + new Moto("A3", 5, new DateTime(1999,2,3));
            estacionamiento += new Auto("A3",4,new DateTime(1452,33,2)); // este no deberia agregarse
            foreach (Vehiculo vehiculo in estacionamiento.Listado)
                System.Console.WriteLine(vehiculo.ToString());
            System.Console.Read();
        }
    }
}
