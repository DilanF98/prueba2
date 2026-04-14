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
    
    public partial class ActualizarProductoForm : Form
    {
        
    
        private ProductoDTO producto;
        public ActualizarProductoForm(ProductoDTO producto)
        {
            InitializeComponent();
            this.producto = producto;
            CargarDatos();
        }

        public void CargarDatos()
        {
            txtId.TextButton = producto.IdProducto.ToString();   
            txtCodigo.TextButton = producto.Codigo;
            txtNombre.TextButton = producto.Nombre;
            txtDescripcion.TextButton = producto.Descripcion;
            txtPrecio.TextButton = producto.Precio.ToString();
            txtCantidad.TextButton = producto.Stock.ToString();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {


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

                producto.Codigo = txtCodigo.TextButton;
                producto.Nombre = txtNombre.TextButton;
                producto.Descripcion = txtDescripcion.TextButton;
                producto.Precio = decimal.Parse(txtPrecio.TextButton);
                producto.Stock = int.Parse(txtCantidad.TextButton);

                //Agregar lógica para actualizar el producto en la base de datos
                BLL.ProductosBLL bll = new BLL.ProductosBLL();

                bll.Actualizar(producto);

                MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(Exception ex)
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
