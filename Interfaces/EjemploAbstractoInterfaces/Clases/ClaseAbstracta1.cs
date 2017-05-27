using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    // 

    public abstract class ClaseAbstracta1 : IGuardable
    {
        protected abstract void Metodo1();

        public void Guardar()
        {
            throw new NotImplementedException();
        }
    }
}
