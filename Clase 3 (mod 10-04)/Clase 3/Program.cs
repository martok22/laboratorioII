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
            Auto.CantidadDeInstancias = 0;

            Rueda miRueda = new Rueda();
            Rueda otraRueda = new Rueda();
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
            //Console.WriteLine(otro = km1 == km2);
			
			Metro unmetro;

            Kilometro k1 = (Kilometro)33;

            Kilometro k2 = 66;

            int num = k1 + k2;

            unmetro = k1;

            Metro resultado = unmetro + k2;

            resultado.MostrarMetro();

            Console.ReadLine();
        }

    }
}
