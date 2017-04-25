using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadDeAula;

namespace UIAulas
{
    public partial class FRMListado : Form
    {
        public FRMListado()
        {
            InitializeComponent();
        }

        public FRMListado(EntidadDeAula.Aula aula) : this()
        {
            foreach(EntidadDeAula.Alumno alumno in aula.ListaAlumnos)
            {
                aula.ListaAlumnos.Add((Alumno)this.lstListado.SelectedItem);
                    
            }
        }

        private void FRMListado_Load(object sender, EventArgs e)
        {

        }
    }
}
