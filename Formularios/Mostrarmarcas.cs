using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.ProductosForm;
using WindowsFormsApp2.ProductosFOrm;

namespace WindowsFormsApp2.Formularios
{
    public partial class Mostrarmarcas : Form
    {
        public Mostrarmarcas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void NikesPr_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNike
            MostrarNike mostrarNikeForm = new MostrarNike();

            // Mostrar el formulario
            mostrarNikeForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNike
            MostrarNike mostrarNikeForm = new MostrarNike();

            // Mostrar el formulario
            mostrarNikeForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarAdidas
            MostrarAdidas mostrarAdidadForm = new MostrarAdidas();

            // Mostrar el formulario
            mostrarAdidadForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void MostrarADidas_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarAdidas
            MostrarAdidas mostrarAdidasForm = new MostrarAdidas();

            // Mostrar el formulario
            mostrarAdidasForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void MostrarPuma_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarPuma
            MOstrarPuma mostrarPumaForm = new MOstrarPuma();

            // Mostrar el formulario
            mostrarPumaForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarPuma
            MOstrarPuma mostrarPumaForm = new MOstrarPuma();

            // Mostrar el formulario
            mostrarPumaForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void MostrarunderAR_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarUnderArmour
            MostarUnderArmour mostrarUnderForm = new MostarUnderArmour();

            // Mostrar el formulario
            mostrarUnderForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarUnderArmour
            MostarUnderArmour mostrarUnderForm = new MostarUnderArmour();

            // Mostrar el formulario
            mostrarUnderForm.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void MostrarCOnv_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarConverse
            MostrarCOnverse mostrarConverseform = new MostrarCOnverse();

            // Mostrar el formulario
            mostrarConverseform.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarConverse
            MostrarCOnverse mostrarConverseform = new MostrarCOnverse();

            // Mostrar el formulario
            mostrarConverseform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void MostrarNEwB_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNewBalance
            MostrarNewBalance mostrarNBform = new MostrarNewBalance();

            // Mostrar el formulario
            mostrarNBform.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNewBalance
            MostrarNewBalance mostrarNBform = new MostrarNewBalance();

            // Mostrar el formulario
            mostrarNBform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarVans
            MostrarVAns mostrarVNform = new MostrarVAns();

            // Mostrar el formulario
            mostrarVNform.Show();
            this.Hide(); // Ocultar el formulario actual
        }
        private void MostrarVans_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarVans
            MostrarVAns mostrarVNform = new MostrarVAns();

            // Mostrar el formulario
            mostrarVNform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void MostrarNC_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNica
            MostrarNica mostrarNSform = new MostrarNica();

            // Mostrar el formulario
            mostrarNSform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarNica
            MostrarNica mostrarNSform = new MostrarNica();

            // Mostrar el formulario
            mostrarNSform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void MOstrarCOban_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarCoban
            MostrarCOban mostrarCBform = new MostrarCOban();

            // Mostrar el formulario
            mostrarCBform.Show();
            this.Hide(); // Ocultar el formulario actual
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario MostrarCoban
            MostrarCOban mostrarCBform = new MostrarCOban();

            // Mostrar el formulario
            mostrarCBform.Show();
            this.Hide(); // Ocultar el formulario actual
        }
    }
}
