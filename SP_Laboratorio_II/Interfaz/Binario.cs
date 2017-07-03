using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IArchivo
{
    public interface Binario<T>
    {
        void Leer(string archivo, out T datos);
        void Guardar(string archivo, T datos);
    }
}
