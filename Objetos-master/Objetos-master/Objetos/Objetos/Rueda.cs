using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{

    class Rueda
    {
        private int Tamanio;

        private string Marca;


        public Rueda()
        {
            this.Marca = "Sin marca.";
        }
        public Rueda(string marca)
        {            
            this.Marca = marca;
        }
        public Rueda(int tamanio):this()
        {
            this.Tamanio = tamanio;
        }
        public Rueda(int tamanio,string marca):this( tamanio)
        {
           
        }
        public void MostrarRueda()
        {
            Console.WriteLine("Marca: " + this.Marca);
        }        
    }
}
