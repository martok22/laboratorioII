using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinHerencia
{
    class AlumnoEgresado
    {
        private int _dni;
        private string _legajo;
        private string _nombre;
        private string _apellido;
        private DateTime _fechaEgreso;

        public AlumnoEgresado(int dni, string legajo)
        {
            this._dni=dni;
            this._legajo = legajo;
        }

        public void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();

            bloque.Append("DNI: " + this._dni);
            bloque.Append("Nombre: " + this._nombre);
            bloque.Append("Legajo: " + this._legajo);
            bloque.Append("Apellido: " + this._apellido);
            bloque.Append("Fecha Egreso: " + this._fechaEgreso);

            System.Console.WriteLine(bloque.ToString());
        }
    }
}
