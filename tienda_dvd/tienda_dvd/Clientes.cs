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
    public partial class Clientes : Form
    {
        Conexion ObjConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = ObjConexion.obtenerDatos();

            miTabla = ds.Tables["clientes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idCliente"] };
            grdDatosClientes.DataSource = miTabla;
            mostrarDatosClientes();

        }
      private void mostrarDatosClientes()
        {
        if (miTabla.Rows.Count > 0)
            {
                txtNombreClientes.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtDireccionClientes.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtCorreoClientes.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoClientes.Text = miTabla.Rows[posicion].ItemArray[4].ToString();

                lblRegistrosClientes.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnAnteriorClientes_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosClientes();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteClientes_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosClientes();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroClientes_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosClientes();
        }

        private void btnUltimoClientes_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosClientes();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosClientes.Enabled = estado;
            grbNavegacionClientes.Enabled = !estado;
            btnEliminarClientes.Enabled = !estado;
        }
        void limpiarCajas()

     
            {
                txtNombreClientes.Text = " ";
                txtDireccionClientes.Text = " ";
                txtCorreoClientes.Text = " ";
                txtTelefonoClientes.Text = " ";
            }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (btnModificarCliente.Text == "Modificar")
            {
                btnNuevoCliente.Text = "Guardar";
                btnModificarCliente.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {
                mostrarDatosClientes();
                btnNuevoCliente.Text = "Nuevo";
                btnModificarCliente.Text = "Modificar";
                estadoControles(false);
            }
        }


        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            if (btnNuevoCliente.Text == "Nuevo")
            {
                btnNuevoCliente.Text = "Guardar";
                btnModificarCliente.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {
                String[] clientes = {
                    accion, miTabla.Rows[posicion]["idCliente"].ToString(),
                    txtNombreClientes.Text, txtDireccionClientes.Text, txtCorreoClientes.Text, txtTelefonoClientes.Text
                };
                String respuesta = ObjConexion.AdministrarClientes(clientes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoCliente.Text = "Nuevo";
                    btnModificarCliente.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }

        private void btnEliminarClientes_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a " + txtNombreClientes.Text.Trim() + "?", "Eliminar cliente", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] clientes = { "eliminar", miTabla.Rows[posicion]["idCliente"].ToString() };
                String respuesta = ObjConexion.AdministrarClientes(clientes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosClientes();
                }
            }
        }
    private void filtrarDatos(string filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "nombre like '%" + filtro + "%' OR direccion like '%" + filtro + "%' OR telefono like '%" + filtro +"%'";
            grdDatosClientes.DataSource = dv;
        }


        private void txtBuscarClientes_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarClientes.Text);
            if(e.KeyValue == 13)
            {//Tecla enter
                SeleccionarCliente();
            }
        }
        private void SeleccionarCliente()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosClientes.CurrentRow.Cells["idCliente"].Value.ToString()));
                mostrarDatosClientes();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Registro NO encontrado", "Error en la selección de clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatosClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarCliente(); 
        }
    }
}
