using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        protected float _peso;

        public Galletita(int codigoBarra, EMarcaProducto marcaProd, float precio, float peso)
            : base(codigoBarra, marcaProd, precio)
        {
            this._peso = peso;
        }

        public string MostrarGalletita()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine(base.Mostrar());
            bloque.AppendLine("Peso: " + this._peso);
            return bloque.ToString();
        }
    }
}
