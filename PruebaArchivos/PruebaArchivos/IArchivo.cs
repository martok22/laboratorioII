using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaArchivos
{
    interface IArchivo<T>
    {
        bool Guardar(string datos);
        bool Leer(out List<string> datos);
    }
}
