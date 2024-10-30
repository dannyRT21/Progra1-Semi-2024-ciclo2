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
    public partial class fmr_usuario : Form
    {
        Conexion ObjConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public fmr_usuario()
        {
            InitializeComponent();
        }

        private void fmr_usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = ObjConexion.obtenerDatos();

            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            grdDatosUsuarios.DataSource = miTabla;
            mostrarDatosUsuarios();
        }
        private void mostrarDatosUsuarios()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtUsarioCampo.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClveUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtConficClave.Text = miTabla.Rows[posicion].ItemArray[2].ToString();

                txtNombreUSuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonoUsuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosUsuarios.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegación de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el último registro", "Navegación de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuarios();
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuarios();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosClientes.Enabled = estado;
            grbNavegacionUsuarios.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (btnNuevoUsuario.Text == "Nuevo")
            {
                // Cambia el texto del botón a "Guardar" y activa los controles de entrada
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {
                // Validación de nombre de usuario
                string usuario = txtUsarioCampo.Text;
                if (usuario.Length < 6 || usuario.Length > 16)
                {
                    MessageBox.Show("El nombre de usuario debe tener entre 6 y 16 caracteres.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de contraseña
                string clave = txtClveUsuario.Text;
                string confirmarClave = txtConficClave.Text;

                if (clave != confirmarClave)
                {
                    MessageBox.Show("Las contraseñas no coinciden.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validación de letras y números en la contraseña
                bool tieneLetra = clave.Any(char.IsLetter);
                bool tieneNumero = clave.Any(char.IsDigit);

                if (!tieneLetra || !tieneNumero)
                {
                    MessageBox.Show("La contraseña debe contener letras y números.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Código para guardar los datos si todas las validaciones se cumplen
                String[] usuarios = {
            accion,
            miTabla.Rows.Count > 0 ? miTabla.Rows[posicion]["idUsuario"].ToString() : "0", // Evita error si no hay registros previos
            txtUsarioCampo.Text,
            txtClveUsuario.Text,
            txtNombreUSuario.Text,
            txtDireccionUsuario.Text,
            txtTelefonoUsuario.Text
        };
                String respuesta = ObjConexion.mantenimiento_Usuarios(usuarios);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Usuario guardado con éxito.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNuevoUsuario.Text = "Nuevo";
                    btnModificarUsuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        private void limpiarCajas()
        {
            txtUsarioCampo.Text = "";
            txtClveUsuario.Text = "";
            txtConficClave.Text = "";
            txtNombreUSuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnNuevoUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {
                btnNuevoUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";
                estadoControles(false);
                mostrarDatosUsuarios();
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show  ("Estas seguro de eliminar a "   +   txtNombreUSuario.Text.Trim() + "?", "Eliminar Usuario", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] usuarios = {
                    "eliminar",miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = ObjConexion.mantenimiento_Usuarios(usuarios);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuarios();
                }

            }
        }
        private void filtrarDatos(string filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "usuario like '%" + filtro + "%' OR nombre like '%" + filtro + "%' OR telefono like '%" + filtro + "%'";
            grdDatosUsuarios.DataSource = dv;
        }
        private void SeleccionarUsuario()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosUsuarios.CurrentRow.Cells["idUsuario"].Value.ToString()));
                mostrarDatosUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Registro NO encontrado", "Error en la selección de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarUsuarios.Text);
            if (e.KeyValue == 13)
            {//Tecla enter
                SeleccionarUsuario();
            }
        }

        private void grdDatosUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarUsuario();
        }
    }
}

