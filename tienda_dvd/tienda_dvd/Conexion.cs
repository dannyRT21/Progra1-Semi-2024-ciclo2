using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace tienda_dvd
{
    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand misComandos = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Conexion()
        {
            string CadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\tienda.mdf;Integrated Security=True";
            miConexion.ConnectionString = CadenaConexion;
            miConexion.Open();
        }

        public DataSet obtenerDatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;

            misComandos.CommandText = "SELECT * FROM clientes";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "clientes");

            misComandos.CommandText = "SELECT * FROM proveedores";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "proveedores");

            // Obtener datos de peliculas
            misComandos.CommandText = "SELECT * FROM peliculas";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "peliculas");

            // Obtener datos de usuarios 
            misComandos.CommandText = "SELECT * FROM usuarios";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "usuarios");

            return ds;
        }

        public String AdministrarClientes(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO clientes(nombre, direccion, telefono, correo) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE clientes SET nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" +
                    datos[4] + "', correo='" + datos[5] + "' WHERE idcliente=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM clientes WHERE idcliente=" + datos[1];
            }
            return ejecutarSQL(sql);
        }

        public String mantenimiento_Usuarios(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO usuarios(usuario, clave, nombre, direccion, telefono) VALUES('" +
         datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE usuarios SET usuario='" + datos[2] + "', clave='" + datos[3] + "', nombre='" +
        datos[4] + "', direccion='" + datos[5] + "', telefono='" + datos[6] + "' WHERE idUsuario=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario=" + datos[1];
            }
            return ejecutarSQL(sql);
        }


        // Método para administrar registros en la tabla proveedores
        public String AdministrarProveedores(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO proveedores(nombre, tipo, telefono, moneda, Estatus) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE proveedores SET nombre='" + datos[2] + "', tipo='" + datos[3] + "', telefono='" +
                    datos[4] + "', moneda='" + datos[5] + "', Estatus='" + datos[6] + "' WHERE idProveedor=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM proveedores WHERE idProveedor=" + datos[1];
            }
            //metodo para form usuarios

           

            return ejecutarSQL(sql);
        }
        public bool ValidarUsuario(string usuario, string contrasena)
        {
            try
            {
                misComandos.Connection = miConexion;
                misComandos.CommandText = "SELECT COUNT(*) FROM usuarios WHERE usuario = @usuario AND clave = @contrasena";
                misComandos.Parameters.Clear(); // Limpiar los parámetros antes de cada ejecución
                misComandos.Parameters.AddWithValue("@usuario", usuario);
                misComandos.Parameters.AddWithValue("@contrasena", contrasena);

                int numFilas = (int)misComandos.ExecuteScalar();
                return numFilas > 0;
            }
            catch (Exception ex)
            {
                // alerta de error al validar usuario
                MessageBox.Show("Error al validar usuario: " + ex.Message);
                return false;
            }
        }

        private String ejecutarSQL(String sql)
        {
            try
            {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                return misComandos.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }

        
    }
}




