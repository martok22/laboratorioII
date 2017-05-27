using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3
{
    class Auto
    {
        public Rueda RuedaDT;
        public Rueda RuedaDD;
        public Rueda RuedaID;
        public Rueda RuedaIT;
        public static int CantidadDeInstancias;
        private eFabricante Fabricante;
        public static Random numeroRandom;
        public int tiempoDemorado;

        // Private puede asignarse en el constructor, o pasarse como param al metodo
        // Los atributos privados son accesibles para su escritura (asignarle un valor) a través
        // de los constructores publicos y los métodos públicos.
        // Pueden ser accedidos para lectura (devolver el valor del dato) 
        // a través de métodos públicos.
        // En este lenguaje también se los puede acceder para lectura y escritura a través
        // de las propiedades
        private int kilometrosRecorridos;
        static Auto()
        {
            Auto.CantidadDeInstancias = 0;
            //Auto.CantidadDeInstancias++ lo aumentaria una sola vez
            // porq este constructor solo es llamado 1 sola vez

            //El fabricante cargado se genere de manera random
            // entre las 3 opciones existentes
            // Probar que haya generado 3 objetos random
            // Creo 1 atributo estatico de tipo random
            // Inicializao el objeto en el constructor estatico
            Auto.numeroRandom = new Random();

        }

        public Auto()
        {
            this.RuedaDD = new Rueda();
            this.RuedaID = new Rueda();
            this.RuedaDT = new Rueda();
            this.RuedaIT = new Rueda();
            Auto.CantidadDeInstancias++;
            this.Fabricante = (eFabricante)numeroRandom.Next(3);
            /*switch (numeroRandom.Next(3))
            {
            }*/
            this.tiempoDemorado = 0;

        }

        public Auto(Rueda ruedaDD)
        {
            this.RuedaDD = ruedaDD;
        }

        public Auto(Rueda ruedaDD, Rueda ruedaID)
            : this(ruedaDD)
        {
            this.RuedaID = ruedaID;
        }

        public Auto(Rueda ruedaDD, Rueda ruedaID, Rueda ruedaDT)
            : this(ruedaDD, ruedaID)
        {
            this.RuedaDT = ruedaDT;
        }

        public Auto(Rueda ruedaDD, Rueda ruedaID, Rueda ruedaDT, Rueda ruedaIT)
            : this(ruedaDD, ruedaID, ruedaDT)
        {
            this.RuedaIT = ruedaIT;
        }


        /* Constructores de instancia
         * 1)Tienen el mismo nombre q la clase
         * 2)Pueden tener modificador de visibilidad public, private, etc.
         * 3)No tienen valor de retorno
         * 4)Pueden tener parámetros
         * 5)Se ejecutan al crear una instancia de la clase (objeto)
         * 6)Se puede y debe utilizarse el operador this
         * 7)Puede acceder a los atributos de instancia 
         * 8)Puede acceder a los atributos estáticos*/

        // 1) No puede tener modificador de visibilidad
        // 2) No se puede utilizar el operador this
        // 3)

        public void AgregarKilometros(int kilometros)
        {
            this.kilometrosRecorridos = this.kilometrosRecorridos + kilometros;

        }

        // No usar guiones bajos en nomenclatura de variables o metodos

        public void VolverACero()
        {
            this.kilometrosRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        public int GetKms()
        {
            return this.kilometrosRecorridos;
        }

        public void AgregarTiempo(int tiempo)
        {
            this.tiempoDemorado = tiempoDemorado + tiempo;
        }

        public void MostrarAuto()
        {
            // Console.writeLine mostrar fabricante, abajo 
            // Console.WriteLine mostrar kms
            Console.WriteLine("El fabricante del auto es: " + this.Fabricante);
            Console.WriteLine("El kilometraje del auto es: " + this.kilometrosRecorridos);
            this.RuedaDD.MostrarRueda();
            this.RuedaID.MostrarRueda();
            this.RuedaIT.MostrarRueda();
            this.RuedaDT.MostrarRueda();
        }

    }
}
