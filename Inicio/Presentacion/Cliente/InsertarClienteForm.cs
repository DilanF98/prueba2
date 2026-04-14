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
    public partial class InsertarClienteForm : Form
    {
        public InsertarClienteForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Agregar lógica para guardar el cliente en la base de datos

            try
            {
                ClienteDTO cliente = new ClienteDTO();

                cliente.Nombre = txtNombre.TextButton.Trim();
                cliente.Telefono = txtTelefono.TextButton.Trim();
                cliente.Correo = txtCorreo.TextButton.Trim();

                BLL.ClientesBLL bll = new BLL.ClientesBLL();

                bll.Insertar(cliente);

                MessageBox.Show("Cliente guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
