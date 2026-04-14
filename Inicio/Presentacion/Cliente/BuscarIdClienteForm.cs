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
    public partial class BuscarIdClienteForm : Form
    {
        public BuscarIdClienteForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!int.TryParse(txtIdCliente.TextButton, out int IdCliente))
                {
                    MessageBox.Show("Por favor, ingresa un ID de cliente válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BLL.ClientesBLL clientesBLL = new BLL.ClientesBLL();



                ClienteDTO cliente = clientesBLL.ObtenerPorId(IdCliente);

              

                if (cliente == null)
                {
                    MessageBox.Show("Cliente no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ActualizarClienteForm actualizar = new ActualizarClienteForm(cliente);
                this.Close();
                actualizar.ShowDialog();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
          
        }
    }
}
