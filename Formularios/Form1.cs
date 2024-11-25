using Guna.UI2.WinForms;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class InicioCesion : Form
    {
        // Usuario y contraseña predeterminados
        private string usuarioCorrecto = "admin";
        private string contrasenaCorrecta = "123";
        private object guna2TextBox31;

        public InicioCesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void InicioCesion_Load(object sender, EventArgs e)
        {

        }

        // Evento de texto cambiado en el cuadro de texto de usuario
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // Esto previene que el texto se seleccione automáticamente al cambiar el texto
            guna2TextBox1.SelectionLength = 0;
        }

        // Evento de texto cambiado en el cuadro de texto de contraseña
        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            // Aquí puedes añadir lógica si quieres hacer algo cuando el texto cambia
        }

        // Evento del botón Login
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = guna2TextBox3.Text.Trim();  // Elimina espacios alrededor del texto
            string contrasena = guna2TextBox6.Text.Trim();  // Elimina espacios alrededor del texto

            // Verificar los valores ingresados
            MessageBox.Show($"Usuario ingresado: '{usuario}' - Contraseña ingresada: '{contrasena}'");

            // Validación del usuario y contraseña
            if (ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();  // Cierra el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método de validación
        private bool ValidarUsuario(string usuario, string contrasena)
        {
            // Compara los valores ingresados ignorando mayúsculas/minúsculas
            return string.Equals(usuario, usuarioCorrecto, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(contrasena, contrasenaCorrecta, StringComparison.OrdinalIgnoreCase);
        }

        // Evento del botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }

        // Evento del botón Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimiza la ventana
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
