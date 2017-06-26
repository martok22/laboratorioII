using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace WebClientEjemplo
{
    public class Descargador
    {
        public string html;
        private Uri direccion;

        public Descargador(Uri direccion)
        {
            this.html = "";
            this.direccion = direccion;
        }

        public void IniciarDescarga()
        {
            try
            {
                WebClient cliente = new WebClient();
                //cliente.DownloadProgressChanged += ;
                cliente.DownloadStringCompleted += new DownloadStringCompletedEventHandler(UnMetodo);
                cliente.DownloadStringAsync(this.direccion);
                //cliente.DownloadStringAsync();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UnMetodo(object sender, DownloadStringCompletedEventArgs e)
        {
            string resultado = e.Result;
            this.html = resultado;
        }

        public string OtroMetodo(string resultado)
        {
            return resultado;
        }
    }
}
