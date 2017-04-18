using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace NoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList lista = new ArrayList(2);
            Producto prod1 = new Producto();
            lista.Add(prod1);
            lista.Add(3);
            lista.Add("hola");
            lista.Add("chau");
            //lista.Sort();
            
            /*Genera error al no ser de tipo producto
            foreach (Producto item in lista)
            {
                item.Mostrar();
            }
            */
            /*
            Stack Pila = new Stack();
            Pila.Push(1);
            Pila.Pop(); // Elimina y muestra el ultimo
            Pila.Peek(); // Muestra el ultimo

            Queue Cola = new Queue();
            Cola.Peek();
            Cola.Enqueue(1); // Analogos a push y pop
            Cola.Dequeue();
            */
        }
    }
}
