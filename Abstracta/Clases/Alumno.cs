using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Alumno : Persona
    {
        protected int legajo;

        public Alumno(string nombre, int legajo, string dni):base(dni,nombre)
        {
            this.legajo = legajo;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            // Un mètodo heredado de una clase donde el método es abstracto, 
            // puede ser sobreescrito (override) y utilizar base."nombre"
        }

        
    }
}
