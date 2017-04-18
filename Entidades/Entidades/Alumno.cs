using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        private string Apellido;
        private string Nombre;
        private int Legajo;

        public Alumno(string apel, string nom, int leg)
        {
            this.Apellido = apel;
            this.Nombre = nom;
            this.Legajo = leg;
        }

        public static bool operator ==(Alumno alumnoX, Alumno alumnoY)
        {
            return (alumnoX.Apellido == alumnoY.Apellido && alumnoX.Legajo == alumnoY.Legajo);
        }

        public static bool operator !=(Alumno alumnoX, Alumno alumnoY)
        {
            return !(alumnoX == alumnoY);
        }

        public static bool operator ==(Alumno alumnoX, int legajo)
        {
            return (alumnoX.Legajo == legajo);
        }
        public static bool operator !=(Alumno alumnoX, int legajo)
        {
            return (!(alumnoX.Legajo == legajo));
        }

        
    }
}
