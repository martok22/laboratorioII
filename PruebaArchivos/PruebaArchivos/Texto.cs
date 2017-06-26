using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PruebaArchivos
{
    public class Texto : IArchivo<string>
    {
        private string archivo;

        public Texto(string archivo)
        {
            this.archivo = archivo;
        }

        public bool Guardar(string datos)
        {
            throw new NotImplementedException();
        }

        public bool Leer(out List<string> datos)
        {
            datos = new List<string>();
            using (StreamReader lector = new StreamReader(this.archivo))
            {
                string linea = "a";
                while (linea != null)
                {
                    linea = lector.ReadLine();
                    datos.Add(linea);
                }
                return true;
            }
        }
    }
}
