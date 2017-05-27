using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConHerencia;

namespace ConsolaConHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEgresado alu1 = new AlumnoEgresado(22, "23",new DateTime(2017, 10, 6));
            alu1.Mostrar();
            Alumno alu2 = new Alumno(24, "66");
            System.Console.ReadKey();
            
            
        }
    }
}
