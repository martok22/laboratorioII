using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class ClaseAbstracta2 : ClaseAbstracta1, IGuardable
    {
        protected abstract void Metodo2();

        public void Guardar() { }
    }
}
