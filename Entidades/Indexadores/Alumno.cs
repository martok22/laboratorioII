using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    public class Alumno
    {
        private int _legajo;
        private string _nombre;

        public Alumno(int legajo)
        {
            this._legajo = legajo;

        }
        public Alumno(string nombre, int legajo) : this(legajo)
        {
            this._nombre = nombre;
        }
    }
}
