using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            //eFabricante fabricante;

            Auto NuevoAuto;
            Auto NuevoAuto2;
            Auto NuevoAuto3;
            Auto NuevoAuto4;
            Rueda miRueda1;
            Rueda miRueda2;
            Rueda miRueda3;
            Kilometro kilometro1;
            Kilometro kilometro2;
            Kilometro aux;
            /*****************************************
            fabricante = eFabricante.Hundai;
            fabricante = (eFabricante)1; casteo malo
            *****************************************/


            //kilometro1 = new Kilometro(10);
            //kilometro2 = new Kilometro(5);
            //aux = new Kilometro(0);

            //aux = Kilometro.Sumar(kilometro1, kilometro2);
            
            //aux = kilometro1 + kilometro2;

            //int dato = kilometro1 + 33;
            /*
            if (kilometro1 == kilometro2)
            { 
            
            
            }*/

            Metro unmetro;

            Kilometro k1 = (Kilometro)33;

            Kilometro k2 = 66;

            int num = k1 + k2;

            unmetro = k1;

            Metro resultado = unmetro + k2;

            NuevoAuto = new Auto();
            NuevoAuto.MostrarAuto();
            NuevoAuto2 = new Auto();
            NuevoAuto3 = new Auto();
            NuevoAuto4 = new Auto();

            miRueda1 = new Rueda();
            miRueda2 = new Rueda(66,"Michelin");
            miRueda3 = new Rueda(33);


        }
    }
}
