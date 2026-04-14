using DTO;
using Presentacion;
using Presentacion.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UI.Vendedor
{
    public partial class BuscarIdVendedorForm : Form
    {
        public BuscarIdVendedorForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica para buscar el ID del vendedor 
            if (!int.TryParse(txtIdVendedor.TextButton, out int idVendedor))
            {
                MessageBox.Show("Por favor, ingresa un ID de vendedor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            BLL.VendedoresBLL bll = new BLL.VendedoresBLL();

            VendedorDTO vendedor = bll.ObtenerPorId(idVendedor);
            if (vendedor == null)
            {
                MessageBox.Show("Vendedor no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            ActualizarVendedorForm actualizar = new ActualizarVendedorForm(vendedor);
            this.Close();
            actualizar.ShowDialog();
        }
    }
}
