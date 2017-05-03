using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Docente : Empleado
    {
        public override float Sueldo
        {
            get
            {
                //throw new NotImplementedException();
            }
            set
            {
                //throw new NotImplementedException();
            }
        }

        // Un metodo abstracto al q se le hace override en una clase hija
        // "queda" como metodo virtual, y permite posteriores overrides
        // en otras clases que hereden


    }
}
