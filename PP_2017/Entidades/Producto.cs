using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        protected int _codigoBarra;
        protected EMarcaProducto _marca;

        public EMarcaProducto Marca
        {
            get { return _marca; }
        }
        protected float _precio;

        public float Precio
        {
            get { return _precio; }
        }
        
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigoBarra;
            this._marca = marca;
            this._precio = precio;
        }

        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1.Marca == prod2.Marca &&
                prod2._codigoBarra == prod1._codigoBarra)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }

        public static bool operator ==(Producto prod1, EMarcaProducto marca)
        {
            if (prod1.Marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, EMarcaProducto marca)
        {
            return !(prod1.Marca == marca);
        }

        public static explicit operator int (Producto prod1)
        {
            return prod1._codigoBarra;
        }

        protected string Mostrar()
        {
            StringBuilder bloque = new StringBuilder();
            bloque.AppendLine("Codigo Barra: " + this._codigoBarra);
            bloque.AppendLine("Marca: " + this._codigoBarra);
            bloque.AppendLine("Precio: " + this._codigoBarra);
            return bloque.ToString();

        }


        
    }
}
