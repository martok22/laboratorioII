using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Empleado : Humano
    {
        public abstract float Sueldo // propiedad abstracta
        {
            get { }
            set { }
        }

        public Empleado(string nombre)
            : base(nombre)
        {
            // Metodos abstractos no son obligatorios a implementarse 
            // en clases abstractas
        }
        /* Se pueden implementar overrides en métodos abstractos heredados,
         * no es obligatorio
         * 
        public override void Mostrar()
        {
            //throw new NotImplementedException();
        }
        */
    
    }
}
