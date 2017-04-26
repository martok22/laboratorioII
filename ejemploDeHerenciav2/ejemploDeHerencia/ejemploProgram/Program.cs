using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using conHerencia;

namespace ejemploProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AlumnoEgresado aluEgresado = new AlumnoEgresado(32322, "123", new DateTime(2017, 4, 25));
            AlumnoEgresado aluEgresado2 = new AlumnoEgresado(32323, "123", new DateTime(2017, 4, 25));
            Alumno alu = new Alumno(111, "222");
            Alumno alu2 = new Alumno(111, "222");
            Alumno alu3 = new Alumno(444, "333");
           // Alumno alumnoUno = new Alumno(23312, "3232");
            aluEgresado.Apellido = "perez";
            aluEgresado.Mostrar();
            Aula aula1 = new Aula(2, "algo", 5);
            aula1.agregarPersona(aluEgresado);
            Profesor profe1 = new Profesor(22, "algo");
            aula1.agregarPersona(profe1);
            aula1.agregarPersona(alu);
            aula1.agregarPersona(alu2);
            aula1.agregarPersona(alu3);
            aula1.agregarPersona(aluEgresado2);

            foreach (Persona item in aula1.ListadoDePersonas1)
                item.Mostrar();
            
            /*if (aula1.GetType() == profe1.GetType())
                System.Console.WriteLine("aula y profe son iguales");
            else
                System.Console.WriteLine("no son iguales");
            System.Console.WriteLine(aula1.cantidadDeProfesores);
            System.Console.WriteLine(profe1.Equals(profe1));*/

            System.Console.WriteLine(aluEgresado == aluEgresado2);
            System.Console.ReadKey();



        }
    }
}
