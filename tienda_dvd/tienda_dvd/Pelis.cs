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
    public partial class Pelis : Form
    {
        Conexion ObjConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        string accion = "nuevo";

        public Pelis()
        {
            InitializeComponent();
        }

        private void Pelis_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }
        private void actualizarDs()
        {
            ds.Clear();
            ds = ObjConexion.obtenerDatos();

            miTabla = ds.Tables["peliculas"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idPelicula"] };
            //grdDatosPeliculas.DataSource = miTabla;
            mostrarDatosPeliculas();
        }
        private void mostrarDatosPeliculas()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtTituloPelicula.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtAñoPelicula.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtDuracionPelicula.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtCategotriaPelicula.Text = miTabla.Rows[posicion].ItemArray[4].ToString();



                lblRegistrosPeliculas.Text = (posicion + 1) + " de " + miTabla.Rows.Count;
            }
        }

        private void btnAnteriorPeliculas_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosPeliculas();
            }
            else
            {
                MessageBox.Show("¡Estás en la primera peli!", "Navegación de películas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Mostrar la imagen correspondiente a la posición actual
            switch (posicion)
            {
                case 0:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\1.jpeg");
                    break;
                case 1:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\2.jpeg");
                    break;
                case 2:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\3.jpeg");
                    break;
                case 3:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\4.jpeg");
                    break;
                case 4:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\5.jpeg");
                    break;
            }

            // Forzar la actualización del PictureBox
            Foto.Refresh();
        }

        private void btnSiguientePeliculas_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 0)
            {
                posicion++;
                mostrarDatosPeliculas();
            }
            else
            {
                MessageBox.Show("Esta es nuestra ultima peli ;(",
                    "Navegacion de peliculas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Mostrar la imagen correspondiente a la posición actual
            switch (posicion)
            {
                case 0:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\1.jpeg");
                    break;
                case 1:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\2.jpeg");
                    break;
                case 2:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\3.jpeg");
                    break;
                case 3:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\4.jpeg");
                    break;
                case 4:
                    Foto.Image = new Bitmap("C:\\Users\\MINEDUCYT\\Desktop\\tienda_dvd\\Pelis-Image\\5.jpeg");
                    break;
              
            }

            // Forzar la actualización del PictureBox
            Foto.Refresh();
        }


        private void btnPrimeroPeliculas_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosPeliculas();
        }

        private void btnUltimoPeliculas_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosPeliculas();
        }

    }

}
