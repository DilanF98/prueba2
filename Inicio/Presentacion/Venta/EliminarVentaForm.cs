using System;
using System.Windows.Forms;
using BLL;

namespace UI.Venta
{
    public partial class EliminarVentaForm : Form
    {
        private readonly VentasBLL ventasBll = new VentasBLL();

        public EliminarVentaForm()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
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

            // Confirmación antes de eliminar
            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro que desea eliminar la venta con Id {idVenta}?\nEsta acción no se puede deshacer.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirmacion != DialogResult.Yes)
                return;

            try
            {
                ventasBll.Eliminar(idVenta);
                MessageBox.Show($"Venta {idVenta} eliminada exitosamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}