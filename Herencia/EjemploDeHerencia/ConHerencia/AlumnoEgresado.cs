using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConHerencia
{
    public class AlumnoEgresado:Alumno
    {
        private DateTime _fechaEgreso;

        public AlumnoEgresado(int dni, string legajo,DateTime fechaEgreso):base(dni,legajo)
        {
            this._fechaEgreso = fechaEgreso;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("Fecha Egreso: " + this._fechaEgreso);
            System.Console.WriteLine(bloque.ToString());
        }

        /*public void Mostrar()
        {
            Mostrar();
            Mostrar();
        }*/
    }
}
