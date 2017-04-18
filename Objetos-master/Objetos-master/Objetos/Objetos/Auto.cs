using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    
    class Auto
    {
        public Rueda RuedaDD;
        public Rueda RuedaDI;
        public Rueda RuedaTD;
        public Rueda RuedaTI;
        public static Random MiRandom;

        private int KilometrosRecorridos;
        /***********************************************
         * los atributos privados son accesibles
         * para su escritura (asignnacion de valor)
         * a travez de los constructores publicos y
         * los metodos publicos. Pueden ser accedidos
         * para lectura ( devolucion del valor del dato)
         * atravez de metodos publicos. En este lenguaje
         * tambien se los puede acceder para lectura y 
         * escritura a travez de las propiedades
         ***********************************************/
        private static int CantidaDeInstancias;
        private eFabricante fabricante;

        /************************************************
         * constructores de instancia.
         * 
         * tienen el mismo nombre de la  clase,
         * pueden tener modificador de visibilidad
         * (public, private, etc)
         * no tienen valor de retorno
         * pueden tner parametros
         * se ejecutan al crear una instancia de la clase (objeto)
         * se puede y debe utilizar el operador "this"
         * puede acceder a los atributos e instancia
         * puede acceder a los atributos estaticos
         * 
         ************************************************/
        public void AgregarKilometros (int kilometros)
        {
            this.KilometrosRecorridos = kilometros + this.KilometrosRecorridos;
        }

        public void VolverACero()
        {
            this.KilometrosRecorridos = 0;
        }

        public int GetKms()
        {
            return this.KilometrosRecorridos;
        }
        public void MostrarAuto()
        {
            Console.WriteLine(this.fabricante);
            Console.WriteLine(this.KilometrosRecorridos);
            this.RuedaDD.MostrarRueda();
            this.RuedaDI.MostrarRueda();
            this.RuedaTD.MostrarRueda();
            this.RuedaTI.MostrarRueda();
        }
         
         public Auto()
         {
             /*
              * el fabricante cargado se genere
              * aleatoreamente entre las tres
              * opciones existentes
              * 
              * creo un atributo estatico del tipo
              * random
              * 
              * inicializo el objeto en el
              * contructor estatico
              * 
              * 
              * 
              */

             this.fabricante = new eFabricante();

             this.RuedaDD = new Rueda();
             this.RuedaDI = new Rueda();
             this.RuedaTD = new Rueda();
             this.RuedaTI = new Rueda();
             Auto.CantidaDeInstancias++;
         }
               
        /**********************************************
         * 
         * 1- no puede tener modificador de visibilidad
         * 2- no se pede utilizar el operador this
        ***********************************************/
        static Auto()
        {
            Auto.CantidaDeInstancias = 0;
            
           // MiRandom = 0;
           // MiRandom= new Random();
            
        }
    }
}
