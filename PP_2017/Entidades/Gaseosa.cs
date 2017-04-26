using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        protected float _litros;

        public Gaseosa(int codigoBarra, EMarcaProducto marcaProd, 
            float precio, float litros)
            : base(codigoBarra, marcaProd, precio)
        {
            this._litros = litros;
        }

        public Gaseosa(Producto producto, float litros):base(
            (int)producto,producto.Marca,producto.Precio)
        {
             
        }
    }


}
