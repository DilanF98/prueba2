using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class EliminarProductoForm : Form
    {
        public EliminarProductoForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Implementa aquí la lógica para eliminar el producto utilizando el ID ingresado.
            try
            {

                if (!int.TryParse(txtIdProducto.TextButton, out int idProducto))
                {
                    MessageBox.Show("Por favor, ingresa un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                BLL.ProductosBLL bll = new BLL.ProductosBLL();
                bll.Eliminar(idProducto);

                MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }

               
        }
    }
}
