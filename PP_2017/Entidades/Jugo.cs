using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        protected ESaborJugo _jugo;

        public Jugo(int codigoBarra, EMarcaProducto marcaProd, float precio, ESaborJugo jugo)
            : base(codigoBarra, marcaProd, precio)
        {
            this._jugo = jugo;
        }

        public string MostrarJugo()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine(base.Mostrar());
            bloque.AppendLine("Sabor Jugo:_"+this._jugo);
            return bloque.ToString();
        }
    }
}
