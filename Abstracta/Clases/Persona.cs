using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona : Humano
    {
        protected string dni;

        public Persona(string dni, string nombre):base(nombre) 
        {
            this.dni = dni;
        }

        public override void Mostrar()
        {
            //throw new NotImplementedException();

        }
    }
}
