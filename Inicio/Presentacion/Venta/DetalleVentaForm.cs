using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UI.Venta
{
    public partial class DetalleVentaForm : Form
    {
        private readonly VentasBLL ventasBll = new VentasBLL();
        private readonly int _idVenta;

        private const decimal TASA_IVA = 0.13m;

        public DetalleVentaForm(int idVenta)
        {
            InitializeComponent();
            _idVenta = idVenta;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            try
            {
                // Encabezado: mostrar el id de venta
                lblId.Text = _idVenta.ToString();

                // Obtener la venta para tener Vendedor, Cliente y Fecha
                VentaDTO venta = ventasBll.ObtenerPorId(_idVenta);

                if (venta == null)
                {
                    MessageBox.Show($"No se encontró ninguna venta con Id {_idVenta}.",
                                    "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener los detalles (líneas de productos)
                List<DetalleVentaDTO> detalles = ventasBll.ObtenerDetalles(_idVenta);

                dgvDetalle.Rows.Clear();

                foreach (DetalleVentaDTO d in detalles)
                {
                    string nombreProducto = ventasBll.ObtenerNombreProducto(d.CodigoProducto);

                    dgvDetalle.Rows.Add(
                        venta.NombreVendedor,
                        venta.NombreCliente,
                        venta.Fecha.ToString("dd/MM/yyyy HH:mm"),
                        nombreProducto,
                        d.Cantidad,
                        d.PrecioUnitario.ToString("N2") + " ₡",
                        d.Subtotal.ToString("N2") + " ₡"
                    );
                }

                // Calcular totales
                decimal subtotal = venta.Total;
                decimal iva = subtotal * 0.13m;
                decimal total = subtotal + iva;

                lblSubtotal.Text = subtotal.ToString("N2") + " ₡";
                lblIva.Text = iva.ToString("N2") + " ₡";
                lblTotal.Text = total.ToString("N2") + " ₡";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el detalle: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}