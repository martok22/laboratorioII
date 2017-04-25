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
    public partial class FRMAlumno : Form
    {
        private Alumno _miAlumno;

        public Alumno miAlumno
        {
            get
            {
                return this._miAlumno;
            }
        
        }

        public FRMAlumno()
        {
            InitializeComponent();
        }

        private void FRMAlumno_Load(object sender, EventArgs e)
        {
            this.cmbSexo.Items.Add(EntidadDeAula.eSexo.MASCULINO);
            this.cmbSexo.Items.Add(EntidadDeAula.eSexo.FEMENINO);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajoAux;
            int.TryParse(txtLegajo.Text, out legajoAux);
            if(legajoAux!=0 && legajoAux>0)
                _miAlumno = new Alumno(legajoAux, (eSexo)cmbSexo.SelectedItem, txtNombre.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }




    }
}
