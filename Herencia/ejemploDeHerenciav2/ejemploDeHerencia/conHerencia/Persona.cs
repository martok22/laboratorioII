using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace conHerencia
{
    public class Persona
    {
        private int _dni;

        protected int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }
        protected string _nombre;
        protected string _apellido;

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        private string _legajo;

        public Persona(int dni  )
        {
            this._dni = dni; 
        }
      
        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine("DNI: " + this._dni);
            Bloque.AppendLine("Apellido: " + this._apellido);
            Bloque.AppendLine("Nombre: " + this._nombre);
            return Bloque.ToString();
        }

        public void Mostrar()
        {           
            Console.Write(this.ToString());
        }

        // Uno de los parámetros pasado al operador de una clase tiene que ser de la misma clase
                
        
        public static bool operator ==(Persona unaPersona, Persona dosPersona)
        {
            if (unaPersona.Dni == dosPersona.Dni)
                return true;
            return false;
        }
        
        public static bool operator !=(Persona unaPersona, Persona dosPersona)
        {
            return (!(unaPersona == dosPersona));
        }

        public override bool Equals(object obj)
        {
            if (obj is Persona)
                return true;
            return false;
        }
    }
}
