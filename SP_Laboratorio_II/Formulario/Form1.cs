using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;
using System.Threading;

namespace Formulario
{
    public delegate void miDelegado(object sender, EventArgs e);

    public partial class Form1 : Form
    {
        private Tienda _miTienda;
        private Tienda _miTiendaLeída;
        public event miDelegado guardar;
        public event miDelegado cargar;

        public Form1()
        {
            InitializeComponent();
            this._miTienda = new Tienda("legajo", 33, "Calle Siempreviva");
            this.guardar += new miDelegado(btnGuardar_Click);
            this.cargar += new miDelegado(btnLeer_Click);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            IniciarThreadGuardar();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            IniciarThreadCargar();
        }

        public void IniciarThreadGuardar()
        {
            Thread thGuardar = new Thread(IniciarGuardar);
            thGuardar.Start();
        }

        public void IniciarThreadCargar()
        {
            Thread thCargar = new Thread(IniciarCargar);
            thCargar.Start();
        }

        private void IniciarCargar()
        {
            _miTienda.Leer("Archivo.bin", out _miTiendaLeída);
        }

        private void IniciarGuardar()
        {
            _miTienda.Guardar("Archivo.bin", _miTienda);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_miTiendaLeída!=null)
            {
                MessageBox.Show(this._miTiendaLeída.MostrarDatos());
            }
        }
    }
}
