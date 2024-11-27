using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Mostrarmarcas
            Mostrarmarcas mostrarMarcasForm = new Mostrarmarcas();

            // Mostrar el formulario como una ventana independiente
            mostrarMarcasForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
          
        }

    }
}
