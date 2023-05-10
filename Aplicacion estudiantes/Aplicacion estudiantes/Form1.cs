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
            if (contador < 5)
            {
                bool verificado = true;
                if(txtbcarnet.Text == "")
                {
                    lblerrorcarnet.Text = "El carnet no puede ser vacio";
                    lblerrorcarnet.Visible = true;
                    verificado= false;
                }
                if (txtbnombre.Text == "")
                {
                    lblerrorname.Text = "El nombre no puede ser vacio";
                    lblerrorname.Visible = true;
                    verificado= false;
                }
                if(verificado)
                {
                    estudiantes[contador] = new Estudiantes(txtbcarnet.Text, txtbnombre.Text);
                    contador++;

                    txtbcarnet.Text = "";
                    txtbnombre.Text = "";
                    lblerrorcarnet.Visible = false;
                    lblerrorname.Visible= false;
                }
            } else
            {
                lblerror.Text = "No es posible almacenar más estudiantes"; 
                lblerror.Visible = true;
            }
        }

        private void txtNombre_key(object sender, KeyPressEventArgs e)
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

        private void txtbNombre_key(object sender, KeyPressEventArgs e)
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
}