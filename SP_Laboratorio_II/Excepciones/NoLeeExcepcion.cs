using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NoLeeExcepcion : Exception
    {
        public NoLeeExcepcion() : base() { }
        public NoLeeExcepcion(string mensaje) : base(mensaje) { }
        public NoLeeExcepcion(string mensaje, Exception e) : base(mensaje, e) { }
    }
}
