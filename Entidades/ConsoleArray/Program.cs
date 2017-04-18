using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int Indice;
            Entidades.Aula MiAula=new Entidades.Aula();

            for (int ContadorDeLegajo = 0; ContadorDeLegajo < 11; ContadorDeLegajo++)
            {                
            Entidades.Alumno NuevoAlumno = new Entidades.Alumno("Jarkodeo", "Furioso", ContadorDeLegajo);
            MiAula.AgregarAlumno(NuevoAlumno);
            }

            Entidades.Alumno borrado = new Entidades.Alumno("Jarkodeo", "Furioso", 6);

            MiAula.BorrarAlumno(borrado);

            
            //Indice = MiAula.ObtenerLugarLibre();
        
        }
    }
}
