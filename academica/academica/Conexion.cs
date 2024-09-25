using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta libreria nos servira para conectarnos a la BD.
using System.Data.SqlClient; //Libreria necesaria para conectarnos a SQL Server.


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
    }
}
