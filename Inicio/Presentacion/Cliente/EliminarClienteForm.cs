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
    public partial class EliminarClienteForm : Form
    {
        public EliminarClienteForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí implementar la lógica para eliminar el cliente por su ID.
            try
            {
                if (!int.TryParse(txtIdCliente.TextButton, out int IdCliente))
                {
                    MessageBox.Show("Por favor, ingresa un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              
                BLL.ClientesBLL bll = new BLL.ClientesBLL();
                bll.Eliminar(IdCliente);

                MessageBox.Show("Cliente eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
           
        }
    }
}
