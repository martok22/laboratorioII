using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Alumno:Persona
    {
     
        protected string _legajo;
       

        public Alumno(int dni , string legajo ):base(dni)
        {
          
            this._legajo = legajo;

        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());

            Bloque.AppendLine("Legajo: " + this._legajo);

            return Bloque.ToString();

        }

        public static bool operator ==(Alumno unaAlumno, Alumno dosAlumno)
        {
            if ((unaAlumno.Dni == dosAlumno.Dni) &&
                (unaAlumno._legajo == dosAlumno._legajo))
                return true;
            return false;
        }

        public static bool operator !=(Alumno unaAlumno, Alumno dosAlumno)
        {
            return (!(unaAlumno == dosAlumno));
        }

        public override bool Equals(object obj)
        {
            if (obj is Alumno)
                return true;
            return false;
        }
     
    }
}
