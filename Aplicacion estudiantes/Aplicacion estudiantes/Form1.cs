using System.Windows.Forms;
using System.Collections.Generic;

namespace Aplicacion_estudiantes
{
    public partial class Form1 : Form
    {
        Estudiantes[] estudiantes = new Estudiantes[5]; // solo 5 estudiantes
        int contador = 0;
        bool verificado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            if (!existStudent(txtbcarnet.Text)) {
                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbcarnet.Text == "")
                    {
                        lblerrorcarnet.Text = "El carnet no puede ser vacio";
                        lblerrorcarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbnombre.Text == "")
                    {
                        lblerrorname.Text = "El nombre no puede ser vacio";
                        lblerrorname.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        estudiantes[contador] = new Estudiantes(txtbcarnet.Text, txtbnombre.Text);
                        contador++;

                        txtbcarnet.Text = "";
                        txtbnombre.Text = "";
                        lblerrorcarnet.Visible = false;
                        lblerrorname.Visible = false;
                    }
                }
                else
                {
                    lblerror.Text = "No es posible almacenar más estudiantes";
                    lblerror.Visible = true;
                }
            } else
            {
                lblerror.Text = "Estudiante ya existente";
                lblerror.Visible = true;
            }
            
        }


        private void txtbNombre_key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbcarnet.Text == "")
                    {
                        lblerrorcarnet.Text = "El carnet no puede ser vacio";
                        lblerrorcarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbnombre.Text == "")
                    {
                        lblerrorname.Text = "El nombre no puede ser vacio";
                        lblerrorname.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        estudiantes[contador] = new Estudiantes(txtbcarnet.Text, txtbnombre.Text);
                        contador++;

                        txtbcarnet.Text = "";
                        txtbnombre.Text = "";
                        lblerrorcarnet.Visible = false;
                        lblerrorname.Visible = false;
                    }
                }
                else
                {
                    lblerror.Text = "No es posible almacenar más estudiantes";
                    lblerror.Visible = true;
                }
            }          
        }

        private void txtbCarnet_key(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (contador < 5)
                {
                    bool verificado = true;
                    if (txtbcarnet.Text == "")
                    {
                        lblerrorcarnet.Text = "El carnet no puede ser vacio";
                        lblerrorcarnet.Visible = true;
                        verificado = false;
                    }
                    if (txtbnombre.Text == "")
                    {
                        lblerrorname.Text = "El nombre no puede ser vacio";
                        lblerrorname.Visible = true;
                        verificado = false;
                    }
                    if (verificado)
                    {
                        estudiantes[contador] = new Estudiantes(txtbcarnet.Text, txtbnombre.Text);
                        contador++;

                        txtbcarnet.Text = "";
                        txtbnombre.Text = "";
                        lblerrorcarnet.Visible = false;
                        lblerrorname.Visible = false;
                    }
                }
                else
                {
                    lblerror.Text = "No es posible almacenar más estudiantes";
                    lblerror.Visible = true;
                }
            }
        }

        public bool existStudent(String studentID)
        {
            bool result = false;

            foreach (Estudiantes item in estudiantes) {
                if (item !=null && item.getId() == studentID )
                {
                    result= true;
                    break;
                }           
            }
            return result;
        }

        public Estudiantes finStudents (String studentID)
        {
            Estudiantes estudiante = null;

            foreach (Estudiantes item in estudiantes) {
                if (item !=null && item.getId() == studentID) { 
                    estudiante = item;
                    break;          
                }   
            }
            return estudiante;
        }
    }
}