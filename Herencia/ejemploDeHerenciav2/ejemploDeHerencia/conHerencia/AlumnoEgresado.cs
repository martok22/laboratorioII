using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conHerencia
{
    public class AlumnoEgresado:Alumno
    {

      
        private DateTime _fechaEgreso;


        public AlumnoEgresado(int dni, string legajo, DateTime fechaEgreso):base(dni,legajo)
        {
            this._fechaEgreso = fechaEgreso;

        }

       
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.ToString());
         
            Bloque.AppendLine("Fecha de egreso: " + this._fechaEgreso);

            return Bloque.ToString();

        }

        public static bool operator ==(AlumnoEgresado unaAlumnoEgresado, AlumnoEgresado dosAlumnoEgresado)
        {
            if ((unaAlumnoEgresado.Dni == dosAlumnoEgresado.Dni) && 
                (unaAlumnoEgresado._legajo == dosAlumnoEgresado._legajo) &&
                (unaAlumnoEgresado._fechaEgreso == dosAlumnoEgresado._fechaEgreso))
                return true;
            return false;
        }

        public static bool operator !=(AlumnoEgresado unaAlumnoEgresado, AlumnoEgresado dosAlumnoEgresado)
        {
            return (!(unaAlumnoEgresado == dosAlumnoEgresado));
        }

        public override bool Equals(object obj)
        {
            if (obj is AlumnoEgresado)
                return true;
            return false;
        }
    }
}
