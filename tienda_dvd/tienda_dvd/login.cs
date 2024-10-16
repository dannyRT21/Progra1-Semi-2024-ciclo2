using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//edwin daniel Romero Turcios USSS025824
//Ahi me disculpa, yo no me gano un cinco como programador Front-End


namespace tienda_dvd
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogi_Click(object sender, EventArgs e)
        {
            string usuarioCorrecto = "admin";
            string contrasenaCorrecta = "12345";

            string usuarioIngresado = txtUsuarioLogi.Text;
            string contrasenaIngresada = txtContraseñaLogi.Text;

            if (usuarioIngresado == usuarioCorrecto && contrasenaIngresada == contrasenaCorrecta)
            {
                MessageBox.Show("¡Bienvenido!");

                // Crear una instancia del formulario principal
                principal formularioPrincipal = new principal();

                // Mostrar el formulario principal y ocultar el login
                formularioPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}