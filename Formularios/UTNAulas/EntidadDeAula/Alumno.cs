using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDeAula
{
    public class Alumno
    {
        private int _legajo;
        private eSexo _sexo;
        private string _nombre;

        public Alumno(int legajo, eSexo sexo, string nombre)
        {
            this._legajo = legajo;
            this._sexo = sexo;
            this._nombre = nombre;
        }

        public int Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }

        public eSexo Sexo
        {
            get
            {
                return this._sexo;
            }
            set
            {
                this._sexo = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
                
            }
        }

        
    }
        

   
}
