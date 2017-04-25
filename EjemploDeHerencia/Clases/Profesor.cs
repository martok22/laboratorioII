using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinHerencia
{
    class Profesor
    {
        private int _dni;
        private DateTime _fechaIngreso;
        private string _fichaDocente;
        private string _nombre;
        private string _apellido;

        public Profesor(int dni, string ficha)
        {
            this._dni = dni;
            this._fichaDocente = ficha;
        }

        public void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.Append("DNI: " + this._dni);
            bloque.Append("Nombre: " + this._nombre);
            bloque.Append("Apellido: " + this._apellido);
            
            bloque.Append("Fecha Ingreso: " + this._fechaIngreso);
            bloque.Append("FichaDocente: " + this._fichaDocente);

            System.Console.WriteLine(bloque.ToString());
            
        }
    }

    

}
