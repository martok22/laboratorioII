using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesConColeccion
{
    public class AulaConColecciones
    {

        List<Entidades.Alumno> MisAlumnos;
        
        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public AulaConColecciones()
        {
            MisAlumnos = new List<Entidades.Alumno>();
        }

        /// <summary>
        /// Agrega un alumno a la coleccion
        /// </summary>
        /// <param name="NewAlumno"></param>
        public void AgregarAlumno(Entidades.Alumno NewAlumno)
        {
            MisAlumnos.Add(NewAlumno);
        }

        /// <summary>
        /// Elimina un alumno especificado de la coleccion
        /// </summary>
        /// <param name="alumno">datos del alumno que desea borrar</param>
        public void BorrarAlumno(Entidades.Alumno alumno)
        {
            int indice = RetornarIndiceDeObjeto(alumno);

            if (indice != -1)
            {
                this.MisAlumnos[indice] = null;
            }

        }

        /// <summary>
        /// Retorna el indice del objeto del objeto pasado por paramotro,
        /// retorna -1 si no lo encuentra
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        private int RetornarIndiceDeObjeto(Entidades.Alumno alumno)
        {
            int retorno = -1;

            for (int indice = 0; indice < this.MisAlumnos.Count; indice++)
            {
                if (alumno == this.MisAlumnos[indice])
                {
                    retorno = indice;
                    break;
                }
            }

            return retorno;
        }
    }
}
