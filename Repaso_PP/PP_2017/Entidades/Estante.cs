using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _capacidad;
        private List<Producto> _listaProductos;

        protected List<Producto> ListaProductos
        {
            get { return _listaProductos; }
        }

        private Estante()
        {
            this._listaProductos = new List<Producto>();
        }

        public Estante(sbyte capacidad)
            : this()
        {
            this._capacidad = capacidad;
        }

        public static bool operator ==(Estante estante1, Producto prod1)
        {
            foreach (Producto item in estante1.ListaProductos)
            {
                if (item == prod1)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Estante estante1, Producto prod1)
        {
            foreach (Producto item in estante1.ListaProductos)
            {
                if (item == prod1)
                    return true;
            }
            return false;
        }

        public static bool operator ==(Estante estante1, Producto prod1)
        {
            foreach (Producto item in estante1.ListaProductos)
            {
                if (item == prod1)
                    return true;
            }
            return false;
        }



    }
}
