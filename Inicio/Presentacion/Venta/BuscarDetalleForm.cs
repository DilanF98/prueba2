using System;
using System.Windows.Forms;

namespace UI.Venta
{
    public partial class BuscarDetalleForm : Form
    {
        public BuscarDetalleForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtIdVenta.TextButton?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingrese un Id de venta.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texto, out int idVenta) || idVenta <= 0)
            {
                MessageBox.Show("El Id debe ser un número entero mayor a 0.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DetalleVentaForm detalle = new DetalleVentaForm(idVenta);
            detalle.Show();
            this.Close();
        }
    }
}