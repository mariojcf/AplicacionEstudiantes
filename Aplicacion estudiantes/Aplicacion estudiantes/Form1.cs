namespace Aplicacion_estudiantes
{
    public partial class Form1 : Form
    {
        Estudiantes[] estudiantes = new Estudiantes[5]; // solo 5 estudiantes
        int contador = 0;
        bool verificado = false;
        List<(string nombre, string carnet)> Estudiantes = new List<(string, string)>();

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
                /*if (Name.Any(est.name == Name || est.carnet == carnet))
                {
                    MessageBox.Show("Ya existe un estudiante con este nombre o carnet. Ingrese datos diferentes.", "Error");
                    return;
                }*/
            } else
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

        private void txtbCarnet_key(object sender, KeyPressEventArgs e)
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