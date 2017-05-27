using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConHerencia
{
    public class Alumno
    {
        
        protected string _legajo;
        

        public Alumno(int dni, string legajo)
        {
            this._dni=dni;
            this._legajo = legajo;
        }

        public virtual void Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("DNI: " + this._dni);
            bloque.AppendLine("Nombre: " + this._nombre);
            bloque.AppendLine("Apellido: " + this._apellido);
            bloque.AppendLine("Legajo: " + this._legajo);
            
            System.Console.WriteLine(bloque.ToString());

        }
    }
}
