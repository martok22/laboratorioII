using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace ConsolaAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Humano unHumano = new Humano(); No se puede inicializar clases abstractas
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("35323847","Gonzalo");
            personas.Add(new Alumno("Juan",333,"1100011"));
            //personas.Add(new Humano("algo"); no se puede agregar 
            foreach(Persona item in personas)
            {
                item.Mostrar();
            }

            List<Humano> Humanos = new List<Humano>();
            Humanos.Add(new Persona("35323847","Gonzalo");
            Humanos.Add(new Alumno("Juan",333,"1100011"));
            foreach(Humano item in Humanos)
            {
                item.Mostrar();
            }
        }
    }
}
