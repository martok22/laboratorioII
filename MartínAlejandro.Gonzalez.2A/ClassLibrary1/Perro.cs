using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Perro : Mascota
    {
        private int _edad;
        public int Edad
        {
            get { return _edad; }
            set { this._edad = value; }
        }
        private bool _esAlfa;

        public bool EsAlfa
        {
            get { return _esAlfa; }
            set { _esAlfa = value; }
        }

        public Perro(string nombre, string raza) : base(nombre, raza)
        {
            this.Edad = 0;
            this.EsAlfa = false;
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.Edad = edad;
            this.EsAlfa = esAlfa;
        }


        public override string ToString()
        {
            StringBuilder Bloque = new StringBuilder();
            if (this.EsAlfa == true)
            {
                Bloque.AppendLine(base.DatosCompletos() + "alfa de la manada " + "edad " + this.Edad);
            }
            else
            {
                Bloque.AppendLine(base.DatosCompletos() + "edad " + this.Edad);
            }
            return Bloque.ToString();
        }

        protected override string Ficha()
        {
            return base.DatosCompletos();
        }

        public override bool Equals(object obj)
        {
            if (obj is Perro && (Perro)obj == this)
                return true;
            return false;
        }

        public static explicit operator int(Perro perro)
        {
            return perro.Edad;
        }

        public static bool operator ==(Perro perroUno, Perro perroDos)
        {
            if (perroUno.Nombre == perroDos.Nombre &&
                perroUno.Edad == perroDos.Edad &&
                perroUno.Raza == perroDos.Raza)
                return true;
            return false;
        }

        // Forma incorrecta. Forma más corta de hacerlo:
        // public static bool operator != (Perro perroUno, Perro perroDos)
        // {
        //      if (!(perroUno==perroDos)) return true;
        //      return false;
        // }

        public static bool operator !=(Perro perroUno, Perro perroDos)
        {
            if (perroUno.Nombre == perroDos.Nombre &&
                perroUno.Edad == perroDos.Edad &&
                perroUno.Raza == perroDos.Raza)
                return false;
            return true;
        }



    }
}
