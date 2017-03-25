using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    class Auto
    {
       public Rueda RuedaDT;
       public Rueda RuedaDD;
       public Rueda RuedaID;
       public Rueda RuedaIT;
       public static int CantidadDeInstancias;
       public eFabricante Fabricante;

        public Auto()
       {
            this.RuedaDD = new Rueda();
            this.RuedaID = new Rueda();
            this.RuedaID = new Rueda();
            this.RuedaIT = new Rueda();
            Auto.CantidadDeInstancias++;
            this.Fabricante = FORD;
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
        }
    }
}
