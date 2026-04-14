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
    public partial class ActualizarVendedorForm : Form
    {
        private VendedorDTO vendedor;
        public ActualizarVendedorForm(VendedorDTO vendedor)
        {
            InitializeComponent();
            CargarRoles();
            this.vendedor = vendedor;
            CargarDatos();
        }

        private void CargarRoles()
        {
            BLL.RolesBLL bll = new BLL.RolesBLL();
            var lista = bll.ObtenerTodos();

            cmbRol.DataSource = null;
            cmbRol.DisplayMember = "Descripcion";
            cmbRol.ValueMember = "IdRol";
            cmbRol.DataSource = lista;
        }
        private void CargarDatos()
        {
            txtId.TextButton = vendedor.IdVendedor.ToString();
            txtNombre.TextButton = vendedor.Nombre;
            txtUsuario.TextButton = vendedor.Usuario;

            cmbRol.SelectedValue = vendedor.IdRolFk; //OJO ESTO ES CLAVE
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Agregar lógica para actualizar el vendedor en la base de datos
            try
            {
                vendedor.Nombre = txtNombre.TextButton.Trim();
                vendedor.Usuario = txtUsuario.TextButton.Trim();
                vendedor.IdRolFk = Convert.ToInt32(cmbRol.SelectedValue);
                if (!string.IsNullOrWhiteSpace(txtContrasenna.TextButton))
                {
                    vendedor.Contrasena = txtContrasenna.TextButton.Trim();
                }
                else
                {
                    vendedor.Contrasena = null;
                }
                BLL.VendedoresBLL bll = new BLL.VendedoresBLL();
                bll.Actualizar(vendedor);

                MessageBox.Show("Vendedor actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
    }
}
