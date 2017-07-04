using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        protected string _nombre;
        protected string _dni;

        public Persona(string nombre, string dni)
        {
            this._nombre = nombre;
            this._dni = dni;
        }

    }
}
