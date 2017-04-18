using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Carrera
    {

        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        public static Random KilometrosRecorridos;


        public Carrera()
        {
            auto1= new Auto();
            auto2= new Auto();
            auto3= new Auto();
            auto4= new Auto();
            auto5= new Auto();
            auto6= new Auto();          
            
        }

        static Carrera()
        {
            KilometrosRecorridos = new Random();

        }
        /// <summary>
        /// se recibe un entero que representa la cantidad
        /// de iteraciones que se realizaran asignandole
        /// a cada auto una cantidad de kilometros
        /// aleatoerea. Al terminar las iteraciones
        /// mostrar que auto recorrio mas y gano la carrera
        /// </summary>
        /// <param name="minutos"></param>
        public void PorTiempo(int minutos)
        {
            int iteraciones;
            for (iteraciones = 0; iteraciones < minutos; iteraciones++)
            {
                this.auto1.AgregarKilometros(KilometrosRecorridos.Next(0, 100));
                this.auto2.AgregarKilometros(KilometrosRecorridos.Next(0, 100));
                this.auto3.AgregarKilometros(KilometrosRecorridos.Next(0, 100));
                this.auto4.AgregarKilometros(KilometrosRecorridos.Next(0, 100));
                this.auto5.AgregarKilometros(KilometrosRecorridos.Next(0, 100));
                this.auto6.AgregarKilometros(KilometrosRecorridos.Next(0, 100));

            }
        }

    }


}


