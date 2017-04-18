using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Aula
    {
        private int _numeroDeAula;
        private List<Alumno> _ListaAlumnos;
        // agregar atributo capacidad, y metodo calcularLugaresLibres

        public Aula()
        {
            this._ListaAlumnos = new List<Alumno>();
        }

        public Alumno this[int indice]
        {
            set 
            { 
                // si existe, asignar
                if (indice<=_ListaAlumnos.Count) 
                    this._ListaAlumnos[indice] = value; 
                else
                    this._ListaAlumnos.Add(new Alumno(indice));
                // si no existe, agregar
                
            }
            get { return this._ListaAlumnos[indice]; }
        }
    }

    
}
