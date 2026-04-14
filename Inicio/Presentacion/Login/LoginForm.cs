using BLL;
using DTO;
using Presentacion;
using System;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            VendedoresBLL vendedoresBll = new VendedoresBLL();
            VendedorDTO vendedorActivo = null;

            // Se obtienen los valores ingresados por el usuario

            string usuario = txtUsuario.TextButton.Trim();
            string contrasena = txtContrasenna.TextButton.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, ingrese el usuario y la contraseña.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Logica de validación

                vendedorActivo = vendedoresBll.Login(usuario, contrasena);

                if (vendedorActivo != null)
                {
                    MessageBox.Show($"Bienvenido, {vendedorActivo.Nombre}.", "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DTO.Sesion.VendedorActivo = vendedorActivo;

                    DashboardForm dashboard = new DashboardForm();
                    
                    dashboard.WindowState = this.WindowState;
                    
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        dashboard.Size = this.Size;
                    }
                    dashboard.Location = this.Location;
                    dashboard.Show();
                    this.Hide();

                    dashboard.FormClosed += (s, args) => this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasenna.TextButton = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error crítico", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}