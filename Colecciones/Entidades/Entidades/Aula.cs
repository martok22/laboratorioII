using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Aula
    {
        private Alumno[] MisAlumnos;

        /// <summary>
        /// Constructor por defecto
        /// </summary>
        public Aula()
        {
            this.MisAlumnos=new Alumno[10];
        }

        /// <summary>
        /// Agrega un alumno a la coleccion
        /// </summary>
        /// <param name="NewAlumno"></param>
        public void AgregarAlumno(Alumno NewAlumno)
        {
            int Indx = this.ObtenerLugarLibre();

            if (Indx!=-1)
                this.MisAlumnos[Indx] = NewAlumno;

        }

        /// <summary>
        /// Obtiene el indice del primer lugar en NULL,
        /// retorna -1 si no hay lugar
        /// </summary>
        /// <returns>el indice o -1</returns>
        private int ObtenerLugarLibre()
        {
            int retorno = -1;
            int cont = 0;

            foreach (Alumno AlumnoRecorrido in this.MisAlumnos)
            {
                if ((object)AlumnoRecorrido == null)
                {
                    //retorno = cont;
                    //break;
                    return cont;
                }

                cont++;
            }
            
            return retorno;
        }

        /// <summary>
        /// Elimina un alumno especificado de la coleccion
        /// </summary>
        /// <param name="alumno">datos del alumno que desea borrar</param>
        public void BorrarAlumno(Alumno alumno) 
        {
            int indice = RetornarIndiceDeObjeto(alumno);

            if (indice!=-1)
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
        private int RetornarIndiceDeObjeto(Alumno alumno)
        {
            int retorno = -1;

            for (int indice = 0; indice < this.MisAlumnos.Length; indice++)
            {
                if (alumno==this.MisAlumnos[indice])
                {
                    retorno = indice;
                    break;
                }
            }


            return retorno;
        }

    }
}
