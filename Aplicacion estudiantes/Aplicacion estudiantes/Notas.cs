using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_estudiantes
{
    public partial class Notas : Form
    {
        public Notas()
        {
            InitializeComponent();
            Form1.instance.getEstudiantes();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            foreach (Estudiantes item in Form1.instance.getEstudiantes()) {
                if(item != null && item.getId()== txtCarnet.Text) //en nuestrs notas cuando agreguemos la nota, debe de encontrar el nombre y ya usamos la info
                {
                    item.getCursos()[0] = new Curso(txtCarnet.Text, Int32.Parse(txtNota.Text));
                    break;
                }          
            }
        }
    }
}
