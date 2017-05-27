using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Rueda
    {
        private string Marca;
        private int Tamaño;

        public Rueda()
        {
            // rueda.marca si es estatico el atributo
            // marca = algo si no es estatico
            this.Marca = "Sin Marca";
        }

        public Rueda(string marca)
        {
            this.Marca = marca;
        }

        public Rueda(int tamaño)
            : this()
        {
            this.Tamaño = tamaño;
        }

        public Rueda(int tamaño, string marca)
            : this(marca)
        {
            this.Tamaño = tamaño;
        }

        public void MostrarRueda()
        {
            Console.WriteLine("La marca de la rueda es: " + this.Marca);
            Console.WriteLine("El tamaño de la rueda es: " + this.Tamaño);
        }


    }
}
