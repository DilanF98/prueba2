using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Vendedor
{
    public partial class InsertarVendedorForm : Form
    {
        public InsertarVendedorForm()
        {
            InitializeComponent();
            CargarRoles();
        }
        private void CargarRoles()
        {
            BLL.RolesBLL bll = new BLL.RolesBLL();
            var lista = bll.ObtenerTodos();

            cmbRol.DataSource = null; // IMPORTANTE (reset)

            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "IdRol";

            cmbRol.DataSource = lista;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
         {

            try
            {
                VendedorDTO vendedor = new VendedorDTO();
                vendedor.Nombre = txtNombre.TextButton.Trim();
                vendedor.Usuario = txtUsuario.TextButton.Trim();
                vendedor.Contrasena = txtContrasenna.TextButton.Trim();
                vendedor.IdRolFk = Convert.ToInt32(cmbRol.SelectedValue);

                BLL.VendedoresBLL bll = new BLL.VendedoresBLL();
                bll.Insertar(vendedor);

                MessageBox.Show("Vendedor guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
    }
}
