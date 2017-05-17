using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Clase3 : ClaseAbstracta1//, IMostrable, IImprimible
    {
        public void MetodoNormal1() { }


        protected override void Metodo1()
        {
            throw new NotImplementedException();
        }

        /*public void Mostrar()
        {
            throw new NotImplementedException();
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }*/
    }
}
