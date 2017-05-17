using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class ClaseAbstracta5 : Clase3,IGuardable
    {
        // Las clases que hereden de una clase padre(no necesariamente directa)
        // que implemente una interfaz, NO necesitan implementar
        // los metodos de esa interfaz
        
        public abstract void Metodo3();

    }
}
