using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeAula
{
    public class Aula
    {
        private int numero;
        private List<Alumno> _listaAlumnos;

        public List<Alumno> ListaAlumnos
        {
            get { return this._listaAlumnos; }
            
        }

        public Aula(int numero)
        {
            this.numero = numero;
            this._listaAlumnos = new List<Alumno>();
        }
    }
}
