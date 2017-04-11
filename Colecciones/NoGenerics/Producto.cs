using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoGenerics
{
    public class  Producto
    {
        public int codigo;
        public string descripcion;

        public Producto(string desc)
        {
            this.descripcion = desc;
        }

        public Producto()
        {

        }

        public void Mostrar()
        {
            Console.WriteLine("El codigo del producto es: " + this.codigo +
                "y es: " + this.descripcion);
        }

    }
}
