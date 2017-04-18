using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoGenerics;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaEnteros = new List<int>();
            List<string> ListaString = new List<string>();
            List<Producto> ListaProductos = new List<Producto>();
            
            ListaProductos.Add(new Producto("galletitas"));
            ListaProductos.Add(new Producto("Nesquick"));
            ListaProductos.Add(new Producto("Oreo"));
            foreach(var item in ListaProductos)
            {
                item.Mostrar();
            }
            System.Console.ReadLine();
        }
    }
}
