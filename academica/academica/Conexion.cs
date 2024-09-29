using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta libreria nos servira para conectarnos a la BD.
using System.Data.SqlClient;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Runtime.InteropServices; //Libreria necesaria para conectarnos a SQL Server.


namespace academica
{
    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection();//Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand();//ejecutar SQL en la BD.
        SqlDataAdapter miAdaptador = new SqlDataAdapter();//Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();//es la representacion grafica de la BD en memoria RAM.

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;

            misComandos.CommandText = "SELECT * FROM alumnos";
            miAdaptador.SelectCommand = misComandos;
            miAdaptador.Fill(ds, "alumnos");

            return ds;
        }
        public String administrarAlumnos(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, dui) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" +
                    datos[5] + "', dui='" + datos[6] + "' WHERE idAlumnos=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumnos=" + datos[1];
            }
            return ejecutarSQL(sql);
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