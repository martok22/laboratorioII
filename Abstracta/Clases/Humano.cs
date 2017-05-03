using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Humano
    {
        protected string nombre;
        

        public Humano(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract void Mostrar();
       
            // Los métodos siempre van en clases abstractas
        // Metodos abstractos no tienen implementacion
      
    }
}
