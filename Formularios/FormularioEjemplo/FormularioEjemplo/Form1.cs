using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // No hacer doble click en partes del formulario donde no se quiera, porque los 
        // métodos que crea, al borrarlos, genera errores.
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            
            string miVariable;
            miVariable = this.txtnombre.Text;
            MessageBox.Show("hola mundo formularios " + miVariable);
            this.lblnombre.Text = miVariable;
        }
    }
}
