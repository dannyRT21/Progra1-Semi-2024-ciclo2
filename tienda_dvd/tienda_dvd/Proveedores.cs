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
    public partial class Proveedores : Form
    {
        Conexion ObjConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = ObjConexion.obtenerDatos();

            miTabla = ds.Tables["proveedores"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idProveedor"] };
            grdDatosProveedores.DataSource = miTabla;
            mostrarDatosProveedores();
        }
        private void mostrarDatosProveedores()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtNombreProveedores.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                cbxTipoProveedor.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtTelefonoProveedor.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                cbxMonedaProveedor.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                cbxEstatusProveedor.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosProveedor.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnAnteriorProveedor_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosProveedores();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteProveedor_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosProveedores();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPrimeroProveedor_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosProveedores();
        }

        private void btnUltimoProveedor_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosProveedores();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosProveedor.Enabled = estado;
            grbNavegacionProveedor.Enabled = !estado;
            btnEliminarProveedor.Enabled = !estado;
        }

        void limpiarCajas()
        {
            txtNombreProveedores.Text = "";
            cbxTipoProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            cbxMonedaProveedor.Text = "";
            cbxEstatusProveedor.Text = "";
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            if (btnNuevoProveedor.Text == "Nuevo")
            {
                btnNuevoProveedor.Text = "Guardar";
                btnModificarProveedor.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {
                String[] proveedores = {
                    accion, miTabla.Rows[posicion]["idProveedor"].ToString(),
                    txtNombreProveedores.Text, cbxTipoProveedor.Text, txtTelefonoProveedor.Text, cbxMonedaProveedor.Text, cbxEstatusProveedor.Text
                };
                String respuesta = ObjConexion.AdministrarProveedores(proveedores);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoProveedor.Text = "Nuevo";
                    btnModificarProveedor.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (btnModificarProveedor.Text == "Modificar")
            {
                btnNuevoProveedor.Text = "Guardar";
                btnModificarProveedor.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {
                mostrarDatosProveedores();
                btnNuevoProveedor.Text = "Nuevo";
                btnModificarProveedor.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de eliminar a " + txtNombreProveedores.Text.Trim() + "?", "Eliminar proveedor", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] proveedores = { "eliminar", miTabla.Rows[posicion]["idProveedor"].ToString() };
                String respuesta = ObjConexion.AdministrarProveedores(proveedores);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosProveedores();
                }
            }
        }
        private void filtrarDatos(string filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "nombre like '%" + filtro + "%' OR tipo like '%" + filtro + "%' OR telefono like '%" + filtro + "%'";
            grdDatosProveedores.DataSource = dv;
        }

        private void txtBuscarProveedor_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarProveedor.Text);
            if (e.KeyValue == 13)
            { //Tecla enter
                SeleccionarProveedor();
            }
        }
        private void SeleccionarProveedor()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosProveedores.CurrentRow.Cells["idProveedor"].Value.ToString()));
                mostrarDatosProveedores();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Registro NO encontrado", "Error en la selección de proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grdDatosProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProveedor();
        }
    }
}


