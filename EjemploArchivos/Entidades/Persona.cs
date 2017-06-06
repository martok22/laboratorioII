using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]

    public class Persona
    {
        public string _nombre;
        public string _apellido;

        public Persona(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
        }

        public Persona()
        {
        }
    }
}
