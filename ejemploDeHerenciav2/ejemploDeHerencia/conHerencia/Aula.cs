using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conHerencia
{
    public class Aula
    {
        private int _numero;
        private string _nombre;
        private List<Persona> ListadoDePersonas;

        public List<Persona> ListadoDePersonas1
        {
            get { return ListadoDePersonas; }
            set { ListadoDePersonas = value; }
        }
        private int capacidad;


        public Aula(int numero, string nombre,int capacidad)
        {
            this._nombre = nombre;
            this._numero = numero;
            this.ListadoDePersonas = new List<Persona>();
            this.capacidad = capacidad;
        }
        public int cantidadDePersonas
        {
            get
            {
                return 1;
            }
        }
        public int cantidadDeProfesores
        {
            get
            {
                int aux = 0;
                foreach (Persona item in this.ListadoDePersonas)
                {
                    if (item is Profesor)
                        aux = aux+1;     
                }
                return aux;
            }
        }
        public bool agregarPersona(Persona unaPersona)
        {
            if(this.ListadoDePersonas.Count<=this.capacidad) 
                ListadoDePersonas.Add(unaPersona);
            return true;
        }

        public bool borrarPersona(Persona unaPersona)
        {
            // solucion sin equals
            
           
           foreach(Persona item in this.ListadoDePersonas)
           {
               if (unaPersona is AlumnoEgresado)
               {
                   // if((AlumnoEgresado)unaPersona.Equals(item))
                   
                   if (unaPersona == item)
                   {
                       ListadoDePersonas.Remove(item);
                       return true;
                   }
               }
               else if (unaPersona is Alumno)
               {
                   if (unaPersona == item)
                   {
                       ListadoDePersonas.Remove(item);
                       return true;
                   }
               }
               else if (unaPersona is Profesor)
               {
                   if (unaPersona == item)
                   {
                       ListadoDePersonas.Remove(item);
                       return true;
                   }
               }
               else
               {
                   if (unaPersona == item)
                   {
                       ListadoDePersonas.Remove(item);
                       return true;
                   }
               }
           }
           
            


            return true;
        }

        

        
    }
}
