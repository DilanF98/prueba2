using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion.Cliente
{
    
    public partial class ActualizarClienteForm : Form
    {
        private ClienteDTO cliente;
        public ActualizarClienteForm(ClienteDTO cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CargarDatos();
        }

        public void CargarDatos()
        {
            txtId.TextButton = cliente.IdCliente.ToString();
            txtNombre.TextButton = cliente.Nombre;
            txtTelefono.TextButton = cliente.Telefono;
            txtCorreo.TextButton = cliente.Correo;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //Agregar lógica para actualizar el cliente en la base de datos

            try
            {
                cliente.IdCliente = int.Parse(txtId.TextButton);
                cliente.Nombre = txtNombre.TextButton;
                cliente.Telefono = txtTelefono.TextButton;
                cliente.Correo = txtCorreo.TextButton;

                BLL.ClientesBLL bLL = new BLL.ClientesBLL();
                bLL.Actualizar(cliente);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
