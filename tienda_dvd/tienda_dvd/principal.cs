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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void ProveeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proveedores objForm = new Proveedores();
            this.Hide(); // Oculta el formulario principal
            objForm.ShowDialog(); // Muestra el formulario secundario como modal
            this.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes objForm = new Clientes();
            this.Hide();
            objForm.ShowDialog();
            this.Show();
        }


        private void PelisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pelis objForm = new Pelis();
            this.Hide();
            objForm.ShowDialog();
            this.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
         
            DialogResult result = MessageBox.Show("¿Estás segurx de cerrar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; 
            }
        }

        private void gestionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmr_usuario objForm = new fmr_usuario();
            this.Hide();
            objForm.ShowDialog();
            this.Show();
        }
    }
}
