using BLL;
using DTO;
using Mysqlx.Crud;
using Presentacion.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ClienteForm : Form
    {
        BLL.ClientesBLL bll = new BLL.ClientesBLL();
        public ClienteForm()
        {
            InitializeComponent();

            Utilidades.InterfazHelper.CargarDatosPerfil(lblNombre, lblRol);

            //Solo los administradores pueden ver el botón de vendedores
            if (lblRol.Text == "Administrador")
            {
                btnVendedores.Visible = true;
            }

            // Recarga automatica del DGV
            this.Activated += (s, e) => CargarVentas();
        }

        private void CargarVentas()
        {
            ClientesBLL ClienteBLL = new ClientesBLL();
            List<ClienteDTO> lista = ClienteBLL.ObtenerTodos();
            dgvClientes.DataSource = lista;

            // Cantidad de clientes en el card
            cardClientes.Text2 = lista.Count + " Clientes";
        }

        private void Listar()
        {
            try
            {
                var lista = bll.ObtenerTodos();

                if (lista != null && lista.Count > 0)
                {
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = lista;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la tabla " + ex.Message);
            }
        }



        private void btnDashboard_Click(object sender, EventArgs e)
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

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            InsertarClienteForm insertar = new InsertarClienteForm();

            insertar.ShowDialog();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            BuscarIdClienteForm buscar = new BuscarIdClienteForm();

            buscar.ShowDialog();
            
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarClienteForm eliminar = new EliminarClienteForm();
            eliminar.ShowDialog();
           
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
