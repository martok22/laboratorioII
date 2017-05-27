using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
        }


        /// <summary>
        /// Se recibe un entero que representa la cantidad de iteraciones
        /// que se realizarán asignandole a cada auto una cantidad de kilometros random
        /// Al terminar las iteraciones, mostrar que auto recorrió más y qué auto gano
        /// la carrera.
        /// </summary>
        /// <param name="minutos"></param>
        public void porTiempo(int minutos)
        {
            Random rd = new Random();
            int[] kilometrajes;
            this.auto1.VolverACero();
            this.auto2.VolverACero();
            this.auto3.VolverACero();
            this.auto4.VolverACero();
            this.auto5.VolverACero();
            this.auto6.VolverACero();
            for (int contador = 0; contador < minutos; contador++)
            {

                this.auto1.AgregarKilometros(rd.Next(0, 100));
                this.auto2.AgregarKilometros(rd.Next(0, 100));
                this.auto3.AgregarKilometros(rd.Next(0, 100));
                this.auto4.AgregarKilometros(rd.Next(0, 100));
                this.auto5.AgregarKilometros(rd.Next(0, 100));
                this.auto6.AgregarKilometros(rd.Next(0, 100));

            }
            /*for (int contador = 0; contador < 5; contador++)
            {
                Hacer if nested con ganador
			   
            }*/

        }

        public void CorrerCarrera()
        {

        }

        public void CorrerCarrera(Tiempo tiempo)
        {

        }

        public void CorrerCarrera(Kilometro kilometro)
        {

        }


    }
}
