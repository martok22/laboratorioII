using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Clase4 : ClaseAbstracta2
    {
        public void MetodoNormal2() { }

        protected override void Metodo2()
        {
            throw new NotImplementedException();
        }

        protected override void Metodo1()
        {
            throw new NotImplementedException();
        }
    }
}
