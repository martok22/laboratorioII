using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Clases_2
{
    public sealed class Alumno : Persona
    {
        private int _legajo;
        private bool _esEgresado;

        public Alumno(int legajo, bool esEsgresado, string nombre, string dni)
            : base(nombre, dni)
        {
            this._legajo = legajo;
            this._esEgresado = esEsgresado; 
        }

        public override string ToString()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine(this._nombre);
            bloque.AppendLine(this._dni);
            bloque.AppendLine(""+this._legajo);
            bloque.AppendLine(""+this._esEgresado);
            return bloque.ToString();
        }
    }
}
