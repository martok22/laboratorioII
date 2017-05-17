using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Mascota
    {
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
        }

        private string _raza;
        public string Raza
        {
            get { return _raza; }
        }

        public Mascota(string nombre, string raza)
        {
            this._nombre = nombre;
            this._raza = raza;
        }

        protected abstract string Ficha(); 

        protected virtual string DatosCompletos() 
        {
            return String.Format("{0} {1}, ", this.Nombre.ToString(), this.Raza.ToString());  
        }

    }
}
