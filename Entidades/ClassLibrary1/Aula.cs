using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Propiedades
{
    public class Aula
    {
        // En esta parte realizaremos la practica sobre el concepto
        // de propiedades

        // Se agrega _ a las propiedades cuando son privadas
        
        private int _numero;
        public int Numero
        {
            get { return this._numero; }
        }

        private List<Entidades.Alumno> _MisAlumnos;
        private int _capacidad;

        public int GetterCapacidad()
        {
            return this._capacidad;
        }

        public void SetterCapacidad(int capacidad)
        {
            this._capacidad = capacidad;
        }

        private string _profesor;
        public string Profesor
        {
            get { return this._profesor; }
            set { this._profesor = value; }
        }

        public Aula()
        {
            _MisAlumnos = new List<Entidades.Alumno>();
        }

        public int NumeroLegajo
        {
            set
            {
                bool esta = false;
                foreach(Entidades.Alumno alumno in _MisAlumnos)
                {
                    if(value>0)
                    {
                        if(alumno==value)
                        {
                            esta = true;
                            break;
                        }   
                    }         
                }
                this._MisAlumnos.Add(new Entidades.Alumno("n", "n", value));
                
            }
        }
                

    }
}
