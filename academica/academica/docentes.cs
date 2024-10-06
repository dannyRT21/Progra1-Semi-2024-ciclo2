using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academica
{
    public partial class docentes : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";

        public docentes()
        {
            InitializeComponent();
        }

        private void docentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerDatos();
            miTabla = ds.Tables["docentes"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["Id"] };
            grdDatosDocente.DataSource = miTabla;
            mostrarDatosDocente();
        }
        private void mostrarDatosDocente()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtCodigoDocentes.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtNombreDocentes.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDireccionDocentes.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtTelefonoDocentes.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtDuiDocentes.Text = miTabla.Rows[posicion].ItemArray[5].ToString();
                txtEmailDocentes.Text = miTabla.Rows[posicion].ItemArray[6].ToString();

                lblRegistrosDocente.Text = (posicion + 1) + " de " + miTabla.Rows.Count;

            }
        }

        private void btnSiguienteDocente_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosDocente();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocente_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosDocente();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocente_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosDocente();
        }

        private void btnPrimeroDocente_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosDocente();
        }
        private void estadoControles(Boolean estado)
        {
            grbDatosDocente.Enabled = estado;
            grbNavegacionDocente.Enabled = !estado;
            btnEliminarDocente.Enabled = !estado;
        }

        private void btnNuevoDocente_Click(object sender, EventArgs e)
        {
            if (btnNuevoDocente.Text == "Nuevo")
            {
                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                accion = "nuevo";
                estadoControles(true);
                limpiarCajas();
            }
            else
            {//Guardar
                String[] Docente = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtCodigoDocentes.Text, txtNombreDocentes.Text, txtDireccionDocentes.Text, txtTelefonoDocentes.Text, txtDuiDocentes.Text, txtEmailDocentes.Text, cbxEspecialidadDocente.Text
                };
                String respuesta = objConexion.administrarDocentes(Docente);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de docente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnNuevoDocente.Text = "Nuevo";
                    btnModificarDocente.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
        }
        void limpiarCajas()
        {
            txtCodigoDocentes.Text = "";
            txtNombreDocentes.Text = "";
            txtDireccionDocentes.Text = "";
            txtTelefonoDocentes.Text = "";
            txtDuiDocentes.Text = "";
            txtEmailDocentes.Text = "";
            cbxEspecialidadDocente.Text = "";
        }

        private void btnModificarDocente_Click(object sender, EventArgs e)
        {
            if (btnModificarDocente.Text == "Modificar")
            {
                btnNuevoDocente.Text = "Guardar";
                btnModificarDocente.Text = "Cancelar";
                accion = "modificar";
                estadoControles(true);
               
            }
            else
            {//Cancelar
                mostrarDatosDocente();
                btnNuevoDocente.Text = "Nuevo";
                btnModificarDocente.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreDocentes.Text.Trim() + "?", "Eliminar docentes", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] docentes = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarDocentes(docentes);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de docentes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosDocente();
                }
            }
        }

        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "codigo like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosDocente.DataSource = dv;
        }

        private void txtBuscarDocente_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocente.Text);
            //if (e.KeyValue == 13) {//tecla enter
            seleccionarAlDocente();
            //}
        }

        private void seleccionarAlDocente()
        {
            posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosDocente.CurrentRow.Cells["Id"].Value.ToString()));
            mostrarDatosDocente();
        }

        private void grdDatosDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarAlDocente();
        }

        private void txtBuscarDocente_TextChanged(object sender, EventArgs e)
        {

        }
    }

}



