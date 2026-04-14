using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            Utilidades.InterfazHelper.CargarDatosPerfil(lblNombre, lblRol);

            //Solo los administradores pueden ver el botón de vendedores
            if (lblRol.Text == "Administrador")
            {
                btnVendedores.Visible = true;
            }

            //Texto Principal
            lblTextoPrincipal.Text = "Hoy es " + DateTime.Now.ToString("dddd, dd MMMM yyyy") + "\n¡EdgeMarket PoS te desea un grandioso día!\n";
            CargarCards();
            CargarDGVs();
        }

        private void CargarCards()
        {
            // --- Ventas Totales ---
            BLL.VentasBLL ventasBLL = new BLL.VentasBLL();
            List<VentaDTO> listaVentas = ventasBLL.ObtenerTodas();
            cardVentasTotales.Text2 = listaVentas.Count + " Ventas";

            // --- Stock Total (suma de todos los productos) ---
            BLL.ProductosBLL productosBLL = new BLL.ProductosBLL();
            List<ProductoDTO> listaProductos = productosBLL.ObtenerTodos();
            int stockTotal = listaProductos.Sum(p => p.Stock);
            cardStock.Text2 = stockTotal + " Unidades";

            // --- Vendedores Activos ---
            BLL.VendedoresBLL vendedoresBLL = new BLL.VendedoresBLL();
            List<VendedorListadoDTO> listaVendedores = vendedoresBLL.ObtenerTodos();
            cardVendedores.Text2 = listaVendedores.Count + " Vendedores";
        }

        private void CargarDGVs()
        {
            // --- Últimas 10 ventas ---
            BLL.VentasBLL ventasBLL = new BLL.VentasBLL();
            List<VentaDTO> ultimasVentas = ventasBLL.ObtenerTodas()
                .OrderByDescending(v => v.Fecha)
                .Take(10)
                .ToList();
            dgvVentas.AutoGenerateColumns = false;
            dgvVentas.DataSource = ultimasVentas;

            // --- Top 50 productos con más stock ---
            BLL.ProductosBLL productosBLL = new BLL.ProductosBLL();
            List<ProductoDTO> topProductos = productosBLL.ObtenerTodos()
                .OrderByDescending(p => p.Stock)
                .Take(50)
                .ToList();
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.DataSource = topProductos;
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            DashboardForm dashboard = new DashboardForm();
            //Captura el tamaño de la ventana
            dashboard.WindowState = this.WindowState;
            //Si no esta maximizado se toma el tamaño actual
            if (this.WindowState == FormWindowState.Normal)
            {
                dashboard.Size = this.Size;
            }
            dashboard.Location = this.Location;
            dashboard.Show();
            this.Hide();

            dashboard.FormClosed += (s, args) => this.Close();

        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductoForm producto = new ProductoForm();

            producto.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                producto.Size = this.Size;
            }
            producto.Location = this.Location;
            producto.Show();
            this.Hide();

            producto.FormClosed += (s, args) => this.Close();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClienteForm cliente = new ClienteForm();

            cliente.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                cliente.Size = this.Size;
            }
            cliente.Location = this.Location;
            cliente.Show();
            this.Hide();

            cliente.FormClosed += (s, args) => this.Close();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            VentaForm venta = new VentaForm();

            venta.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                venta.Size = this.Size;
            }
            venta.Location = this.Location;
            venta.Show();
            this.Hide();

            venta.FormClosed += (s, args) => this.Close();
        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {
            VendedorForm vendedor = new VendedorForm();

            vendedor.WindowState = this.WindowState;

            if (this.WindowState == FormWindowState.Normal)
            {
                vendedor.Size = this.Size;
            }
            vendedor.Location = this.Location;
            vendedor.Show();
            this.Hide();

            vendedor.FormClosed += (s, args) => this.Close();
        }

        private void btnNotificacion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dilanf98@gmail.com" +
                "\nnavier@gmail.com" +
                "\nzamirelizondo1409@gmail.com" +
                "\nmurillotrejosmarcos18@gmail.com" +
                "\nderekrodrigo2026@gmail.com" +
                "\njurenamcr@gmail.com", "Contactanos en caso de apoyo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.WindowState = this.WindowState;
            MessageBox.Show("¡Hasta luego " + lblNombre.Text + "!", "Cerrando sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (this.WindowState == FormWindowState.Normal)
            {
                login.Size = this.Size;
            } 
            login.Location = this.Location;
            login.Show();
            this.Hide();

            login.FormClosed += (s, args) => this.Close();
        }
    }
}
