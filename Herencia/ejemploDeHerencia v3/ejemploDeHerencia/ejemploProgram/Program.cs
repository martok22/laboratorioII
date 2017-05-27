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
            AlumnoEgresado aluEgresado = new AlumnoEgresado(32323, "123", new DateTime(2017, 4, 25));
           // Alumno alumnoUno = new Alumno(23312, "3232");
            aluEgresado.Apellido = "perez";
            aluEgresado.Mostrar();

            List<Persona> listado = new List<Persona>();

            listado.Add(new Alumno(666, "uo234"));
            listado.Add(new Persona(234));
            listado.Add(new Profesor(432, "32rwe"));
            listado.Add(new AlumnoEgresado(555,"23", new DateTime(2017,4,25)));



            foreach (Persona item in listado)
            {
                item.Mostrar();
            }

            Aula nuevaAula = new Aula(5, "laboratorio",20);

            nuevaAula.agregarPersona(new Alumno(666, "uo234"));
            nuevaAula.agregarPersona(new Profesor(432, "32rwe"));
            nuevaAula.agregarPersona(new Profesor(777, "98rwe"));

            Console.Write("cantidad de Profesores: "+ nuevaAula.cantidadDeProfesores);

            Alumno alumnoDos = new Alumno(666, "uo234");
            Profesor profeDos = new Profesor(666, "uo234");

            if (alumnoDos.Equals(profeDos))
            {
            
            
            }
            if (alumnoDos.Equals(aluEgresado))
            {


            }




        }
    }
}
