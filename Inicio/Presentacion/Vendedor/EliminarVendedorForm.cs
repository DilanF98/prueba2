using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Vendedor
{
    public partial class EliminarVendedorForm : Form
    {
        public EliminarVendedorForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Aquí implementar la lógica para eliminar el vendedor por su ID.

            try
            {
                if(!int.TryParse(txtIdVendedor.TextButton,out int idVendedor))
                {
                     MessageBox.Show("Por favor, ingresa un ID de vendedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     return;
                }

                BLL.VendedoresBLL bll = new BLL.VendedoresBLL();

                bll.Eliminar(idVendedor);

                MessageBox.Show("Vendedor eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
        }
    }
}
