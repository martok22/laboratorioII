using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Rueda miRueda = new Rueda();
            Rueda otraRueda = new Rueda();
            Auto.CantidadDeInstancias = 0;
            Auto miAuto = new Auto();

            Auto miAuto1 = new Auto();
            Auto miAuto2 = new Auto();
            Auto miAuto3 = new Auto();
            Auto miAuto4 = new Auto();

            eFabricante fabricante;
            fabricante = eFabricante.CHEVROLET;
            fabricante = (eFabricante)0;

            /*Random rd = new Random();
            miAuto4.Fabricante = (eFabricante)rd.Next(3);
            miAuto4.Fabricante = (eFabricante)rd.Next(3);
            miAuto4.Fabricante = (eFabricante)rd.Next(3);
            */
            miAuto4.MostrarAuto();
            miAuto4.VolverACero();
            Carrera cr = new Carrera();
            cr.porTiempo(10);
            Rueda rueda = new Rueda(30, "Pirelli");
            Rueda rueda2 = new Rueda(24);
            Rueda rueda3 = new Rueda();

            Kilometro km1 = new Kilometro(5);
            Kilometro km2 = new Kilometro(10);
            //Kilometro aux = Kilometro.Sumar(km1, km2);
            //Console.WriteLine(aux.cantidad);
            //Console.ReadLine();
            int dato;
            bool otro;
            dato = km1 + 33;
            Console.WriteLine(otro = km1 == km2);
        }

    }
}
