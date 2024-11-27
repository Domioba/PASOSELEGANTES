using Guna.UI2.WinForms;

namespace WindowsFormsApp2
{
    partial class InicioCesion
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2TextBox ingresoUsuario;
        private Guna2TextBox ingresoContrasena;
        private Guna2Button btnAcceso;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InicioCesion));
            this.ingresoUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.ingresoContrasena = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAcceso = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ingresoUsuario
            // 
            this.ingresoUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ingresoUsuario.BorderRadius = 16;
            this.ingresoUsuario.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.ingresoUsuario.BorderThickness = 3;
            this.ingresoUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingresoUsuario.DefaultText = "";
            this.ingresoUsuario.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ingresoUsuario.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoUsuario.ForeColor = System.Drawing.Color.White;
            this.ingresoUsuario.Location = new System.Drawing.Point(22, 323);
            this.ingresoUsuario.Name = "ingresoUsuario";
            this.ingresoUsuario.PasswordChar = '\0';
            this.ingresoUsuario.PlaceholderForeColor = System.Drawing.Color.White;
            this.ingresoUsuario.PlaceholderText = "Ingrese Usuario";
            this.ingresoUsuario.SelectedText = "";
            this.ingresoUsuario.Size = new System.Drawing.Size(270, 41);
            this.ingresoUsuario.TabIndex = 0;
            this.ingresoUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ingresoContrasena
            // 
            this.ingresoContrasena.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ingresoContrasena.BorderRadius = 16;
            this.ingresoContrasena.BorderThickness = 3;
            this.ingresoContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ingresoContrasena.DefaultText = "";
            this.ingresoContrasena.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ingresoContrasena.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresoContrasena.ForeColor = System.Drawing.Color.White;
            this.ingresoContrasena.Location = new System.Drawing.Point(22, 443);
            this.ingresoContrasena.Name = "ingresoContrasena";
            this.ingresoContrasena.PasswordChar = '*';
            this.ingresoContrasena.PlaceholderForeColor = System.Drawing.Color.White;
            this.ingresoContrasena.PlaceholderText = "Ingrese Contraseña";
            this.ingresoContrasena.SelectedText = "";
            this.ingresoContrasena.Size = new System.Drawing.Size(270, 41);
            this.ingresoContrasena.TabIndex = 1;
            this.ingresoContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAcceso
            // 
            this.btnAcceso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAcceso.BorderRadius = 22;
            this.btnAcceso.BorderThickness = 3;
            this.btnAcceso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.btnAcceso.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.ForeColor = System.Drawing.Color.White;
            this.btnAcceso.Location = new System.Drawing.Point(50, 514);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(202, 54);
            this.btnAcceso.TabIndex = 2;
            this.btnAcceso.Text = "Acceder";
            this.btnAcceso.TextFormatNoPrefix = true;
            this.btnAcceso.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.BorderRadius = 16;
            this.guna2TextBox1.BorderThickness = 3;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2TextBox1.DefaultText = "USUARIO";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(52, 269);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox1.TabIndex = 3;
            this.guna2TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.BorderRadius = 16;
            this.guna2TextBox2.BorderThickness = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2TextBox2.DefaultText = "CONTRASEÑA";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.ForeColor = System.Drawing.Color.White;
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(50, 382);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(200, 36);
            this.guna2TextBox2.TabIndex = 4;
            this.guna2TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(22, 12);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(270, 238);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 5;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // InicioCesion
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(31)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(313, 580);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.guna2TextBox2);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.ingresoUsuario);
            this.Controls.Add(this.ingresoContrasena);
            this.Controls.Add(this.btnAcceso);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InicioCesion";
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Guna2TextBox guna2TextBox1;
        private Guna2TextBox guna2TextBox2;
        private Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}
