using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tienda_dvd
{
    public partial class login : Form
    {
        private Conexion conexion = new Conexion();

        public login()
        {
            InitializeComponent();
        }

        private void btnLogi_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogi.Text;
            string contrasena = txtContraseñaLogi.Text;

            // usa el metodo ValidarUsuario de conexion.cs
            if (conexion.ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("¡Bienvenido!");
                // Mostrar el formulario principal y ocultar el login
                principal formularioPrincipal = new principal();
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