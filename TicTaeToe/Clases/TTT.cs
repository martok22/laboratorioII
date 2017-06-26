using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TTT
    {
        private char[,] matriz;
        private static Random numeroRandom;

        public TTT()
        {
            this.matriz = new char[3, 3];
        }

        static TTT()
        {
            numeroRandom = new Random();
        }

        public string ImprimirTicTaeToe()
        {
            StringBuilder formato = new StringBuilder();
            formato.AppendLine("---------------------");
            formato.AppendLine("|  " + this.matriz[0, 0] + "  |  " + this.matriz[0, 1] + "  |  " + this.matriz[0, 2] + "  |  ");
            formato.AppendLine("|     |     |     |");
            formato.AppendLine("|  " + this.matriz[1, 0] + "  |  " + this.matriz[1, 1] + "  |  " + this.matriz[1, 2] + "  |  ");
            formato.AppendLine("|     |     |     |");
            formato.AppendLine("|  " + this.matriz[2, 0] + "  |  " + this.matriz[2, 1] + "  |  " + this.matriz[2, 2] + "  |  ");
            formato.AppendLine("|     |     |     |");
            formato.Append("---------------------");
            return formato.ToString();
        }

        public void MaquinaJugar()
        {
            // TURNO 1

            // Me fijo si alguien puso algo en el centro.
            if (this.matriz[1, 1] == 'O')
            {
                //this.matriz[numeroRandom.Next(2), numeroRandom.Next(2)] = 'X';
                this.matriz[0, 2] = 'X';
            }
            else
                this.matriz[1, 1] = 'X';

            for (int contador = 0; contador < 3; contador++)
            {
                for (int contadorDos = 0; contadorDos < 3; contador++)
                {
                    if (this.matriz[contador,contadorDos] == 'O')
                        if (this.matriz[contador+1, contadorDos] == 'O')
                }
            }

            // TURNO 2

            for (int contador=0; contador<3; contador++)
            {
                for (int contadorDos=0; contadorDos<3; contador++)
                {
                    int decision = -1;
                    if( this.matriz[contador,contadorDos] == 'O')
                        if (contador % 2 == 0 && contadorDos % 2 == 0)
                            if (contadorDos == 2)
                                if(this.matriz[contador,contadorDos] == 'O')
                                {
                                    decision = numeroRandom.Next(2);
                                    if (decision == 1)
                                        this.matriz[contador, (contadorDos) - 1] = 'X';
                                    if (decision == 0)
                                        this.matriz[contador + 1, (contadorDos)] = 'X';
                                }
                        else
                }
            }

            // TURNO 3

            for (int contador = 0; contador < 3; contador++)
            {
                for (int contadorDos = 0; contadorDos < 3; contador++)
                {
                    int decision = -1;
                    if (contador % 2 == 0 && contadorDos % 2 == 0)
                        if (contadorDos == 2)
                            if (this.matriz[contador, contadorDos] == 'O')
                                decision = numeroRandom.Next(2);

                    if (decision == 1)
                        this.matriz[contador, (contadorDos) - 1] = 'X';
                    if (decision == 0)
                        this.matriz[contador + 1, (contadorDos)] = 'X';
                }
            }

        }


    }
}
