using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaPropiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Propiedades.Aula MiAula = new Propiedades.Aula();
            MiAula.Profesor = "maxi";
            string a = MiAula.Profesor;
            MiAula.NumeroLegajo = 55;
        }
    }
}
