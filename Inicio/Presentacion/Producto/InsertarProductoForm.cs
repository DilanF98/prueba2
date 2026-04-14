using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DTO;

namespace Presentacion
{
    public partial class InsertarProductoForm : Form
    {
        public InsertarProductoForm()
        {
            InitializeComponent();
        }

       

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Agregar lógica para guardar el producto en la base de datos


            try
            {
                // Validar precio
                if (!decimal.TryParse(txtPrecio.TextButton, out decimal precio))
                {
                    MessageBox.Show("Ingrese un precio válido");
                    return;
                }

                // Validar cantidad
                if (!int.TryParse(txtCantidad.TextButton, out int cantidad))
                {
                    MessageBox.Show("Ingrese una cantidad válida");
                    return;
                }

                ProductoDTO producto = new ProductoDTO();
                producto.Codigo = txtCodigo.TextButton.Trim();
                producto.Nombre = txtNombre.TextButton.Trim();
                producto.Descripcion = txtDescripcion.TextButton.Trim();
                producto.Precio = precio;
                producto.Stock = cantidad;

                BLL.ProductosBLL bll = new BLL.ProductosBLL();
                bll.Insertar(producto);

                MessageBox.Show("Producto guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }


        }

        private void txtPrecio_Load(object sender, EventArgs e)
        {

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {

            this.Close();
        }


    }
}
