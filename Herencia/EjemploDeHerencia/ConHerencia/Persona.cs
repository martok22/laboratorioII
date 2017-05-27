using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConHerencia
{
    class Persona
    {
        protected int _dni;
        protected string _nombre;
        protected string _apellido;

        public Persona(int dni, string apellido, string nombre)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._nombre = nombre;
        }

        public override string ToString()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("Dni: " + this._dni);
            bloque.AppendLine("Nombre: " + this._nombre);
            bloque.AppendLine("Apellido: " + this._apellido);
            return bloque.ToString();
        }

        public void Mostrar()
        {
            System.Console.WriteLine(this.ToString());
        }
    }
}
