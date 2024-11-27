using System;
using System.Windows.Forms;
using WindowsFormsApp2.Formularios;

namespace WindowsFormsApp2
{
    public partial class InicioCesion : Form
    {
        // Usuario y contraseña predeterminados
        private string usuarioCorrecto = "1";
        private string contrasenaCorrecta = "1";

        public InicioCesion()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen; // Centrar la ventana
        }

        private void InicioCesion_Load(object sender, EventArgs e)
        {
            // Cualquier código adicional al cargar el formulario
        }

        // Evento del botón Login (Acceso)
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            // Obtener valores ingresados
            string usuario = ingresoUsuario.Text.Trim();       // Campo para el usuario
            string contrasena = ingresoContrasena.Text.Trim(); // Campo para la contraseña

            // Validar credenciales
            if (ValidarUsuario(usuario, contrasena))
            {
                MessageBox.Show("¡Login exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario principal
                Principal principal = new Principal(); // Asegúrate de que el formulario `Principal` existe
                principal.Show();
                this.Hide(); // Ocultar el formulario actual
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método de validación de credenciales
        private bool ValidarUsuario(string usuario, string contrasena)
        {
            return string.Equals(usuario, usuarioCorrecto, StringComparison.OrdinalIgnoreCase) &&
                   string.Equals(contrasena, contrasenaCorrecta, StringComparison.OrdinalIgnoreCase);
        }

        // Evento del botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Salir de la aplicación
        }

        // Evento del botón Minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Minimizar la ventana
        }
    }
}
