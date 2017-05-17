using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza) 
        { 

        }

        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            Bloque.AppendLine(base.DatosCompletos());
            return Bloque.ToString(); 
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public override bool Equals(object obj)
        {
            if(obj is Gato && (Gato)obj == this)
                return true;
            return false;
        }

        public static bool operator ==(Gato gatoUno, Gato gatoDos)
        {
            if (gatoUno.Nombre == gatoDos.Nombre &&
                gatoUno.Raza == gatoDos.Raza)
                return true;
            return false;
        }

        public static bool operator !=(Gato gatoUno, Gato gatoDos)
        {
            if (gatoUno.Nombre == gatoDos.Nombre &&
                gatoUno.Raza == gatoDos.Raza)
                return false;
            return true;
        }
    }
}
