using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    [Serializable]
    public abstract class Local
    {
        protected string _direccion;
        protected int _anchoDeFrente; 

        protected abstract string Legajo
        {
            set;
            get;
        }

        public Local(string direccion, int ancho)
        {
            this._direccion = direccion;
            this._anchoDeFrente = ancho;
        }

        public override string ToString()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("Direccion: " + this._direccion);
            bloque.AppendLine("Ancho: " + this._anchoDeFrente);
            return bloque.ToString();
        }

    }
}
