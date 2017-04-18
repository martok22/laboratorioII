using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19_Clases
{
    class Boligrafo
    {
        private ConsoleColor color;
        private int tinta;
        
        public Boligrafo(ConsoleColor color)
        {
            //this.tinta = 0;
            this.color = color;
        }

        public Boligrafo(ConsoleColor color, int tinta):this(color)
        {
            this.tinta = tinta;
            this.color = color;
        }


        public bool Pintar(int gasto)
        {
            bool retorno = true;
            if (this.tinta != 0) this.tinta = this.tinta - gasto;
            else
                retorno = false;
            return retorno;
        }

        public void Recargar()
        {
            this.tinta = this.tinta + 10;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }


    }

   

}
