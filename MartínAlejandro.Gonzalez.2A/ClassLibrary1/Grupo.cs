using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private static TipoManada _tipo;

        public static TipoManada Tipo
        {
            set { _tipo = value; }
        }
        private string _nombre;

        static Grupo()
        {
            Tipo = TipoManada.UNICA;
        }

        private Grupo()
        { 
            this._manada = new List<Mascota>();
        }

        public Grupo(string nombre)
            : this()
        {
            this._nombre = nombre;
        }

        public Grupo(string nombre, TipoManada tipo)
            : this(nombre)
        {
        }

        public static implicit operator string(Grupo e)
        {
            string retorno = "";
            foreach (Mascota item in e._manada)
            {
                retorno += item.ToString();
            }
            return retorno;
        }

        public static Grupo operator +(Grupo e, Mascota j)
        {
            if (!EstaEnLaLista(e, j)) e._manada.Add(j);
            return e;
                    
        }

        public static Grupo operator -(Grupo e, Mascota j)
        {
            if (EstaEnLaLista(e, j)) e._manada.Remove(j);
            return e;
        }

        public static bool operator ==(Grupo e, Mascota j)
        {
            if (EstaEnLaLista(e, j)) return true;
            return false;
        }

        public static bool operator !=(Grupo e, Mascota j)
        {
            if (EstaEnLaLista(e, j)) return false;
            return true;
        }

        /// <summary>
        /// Chequea que la Mascota pasada como parametro este en la lista del grupo 
        /// pasado como parametro
        /// </summary>
        /// <param name="e">Grupo</param>
        /// <param name="j">Mascota</param>
        /// <returns>true en caso de que encuntre resultado, false caso contrario</returns>

        public static bool EstaEnLaLista(Grupo e, Mascota j)
        {
            foreach (Mascota item in e._manada)
            {
                if (j is Perro)
                {
                    if (item is Perro && j == item)
                    {
                        return true;
                    }
                }

                if (j is Gato)
                {
                    if (item is Gato && j == item)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        

    }

}
