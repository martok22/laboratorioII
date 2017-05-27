using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIAulas
{
    public partial class FRMPrincipal : Form
    {

        private EntidadDeAula.Aula _miAula;
        public FRMPrincipal()
        {
            InitializeComponent();
            //inicializar aula
            this._miAula = new EntidadDeAula.Aula(1);
        }

        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMAlumno FRM = new FRMAlumno();
            if (FRM.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //agregar alumno a aula (fijarse distintas formas)
                this._miAula.ListaAlumnos.Add(FRM.miAlumno);
                //this._miAula = this._miAula
            }
            
        }
    }
}
