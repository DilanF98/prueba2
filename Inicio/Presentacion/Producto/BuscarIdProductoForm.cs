using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class BuscarIdProductoForm : Form
    {
        public BuscarIdProductoForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí deberías implementar la lógica para buscar el producto por su ID.

            if (!int.TryParse(txtIdProducto.TextButton, out int idProducto))
            {
                MessageBox.Show("Por favor, ingresa un ID de producto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLL.ProductosBLL bll = new BLL.ProductosBLL();

            ProductoDTO producto = bll.ObtenerPorId(idProducto);

            if (producto == null)
            {
                MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ActualizarProductoForm actualizar = new ActualizarProductoForm(producto);
            this.Close();
            actualizar.ShowDialog();

          
        }
    }
}
