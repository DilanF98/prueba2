using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BLL;
using DTO;

namespace UI.Venta
{
    public partial class InsertarVentaForm : Form
    {
        private readonly VentasBLL ventasBll = new VentasBLL();
        private readonly ClientesBLL clientesBll = new ClientesBLL();
        private readonly ProductosBLL productosBll = new ProductosBLL();

        private List<ClienteDTO> _todosClientes = new List<ClienteDTO>();
        private List<ProductoDTO> _todosProductos = new List<ProductoDTO>();

        private List<(DetalleVentaDTO Detalle, ProductoDTO Producto)> _carro
            = new List<(DetalleVentaDTO, ProductoDTO)>();

        private VendedorDTO _vendedorActivo;
        private ProductoDTO _productoSeleccionado;

        private bool _seleccionandoProducto = false;
        private bool _seleccionandoCliente = false;

        // Texto exacto del item seleccionado — para detectar si el usuario escribió algo nuevo
        private string _textoSeleccionadoProducto = null;
        private string _textoSeleccionadoCliente = null;

        private const decimal TASA_IVA = 0.13m;

        public InsertarVentaForm(VendedorDTO vendedor)
        {
            InitializeComponent();
            _vendedorActivo = vendedor;
            CargarDatosTemporales();
            SuscribirEventos();
        }

        private void SuscribirEventos()
        {
            cmbCliente.TextChanged += cmbCliente_TextChanged;
            cmbCliente.SelectedIndexChanged += cmbCliente_SelectedIndexChanged;
            cmbCliente.DropDown += (s, e) => _seleccionandoCliente = true;

            cmbProducto.TextChanged += cmbProducto_TextChanged;
            cmbProducto.SelectedIndexChanged += cmbProducto_SelectedIndexChanged;
            cmbProducto.DropDown += (s, e) => _seleccionandoProducto = true;

            btnAgregar.Click += btnAgregar_Click;
            btnLimpiar.Click += btnLimpiar_Click;
        }

        private void CargarDatosTemporales()
        {
            try
            {
                _todosClientes = clientesBll.ObtenerTodos();
                _todosProductos = productosBll.ObtenerTodos();

                cmbCliente.AutoCompleteMode = AutoCompleteMode.None;
                cmbProducto.AutoCompleteMode = AutoCompleteMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------- AUTOCOMPLETE CLIENTE -----------------------
        private void cmbCliente_TextChanged(object sender, EventArgs e)
        {
            string texto = cmbCliente.Text;

            // Si hay una selección activa pero el texto ya cambió, el usuario volvió a escribir
            if (_seleccionandoCliente)
            {
                if (texto != _textoSeleccionadoCliente)
                    _seleccionandoCliente = false;
                else
                    return;
            }

            if (string.IsNullOrWhiteSpace(texto))
            {
                _textoSeleccionadoCliente = null;
                cmbCliente.TextChanged -= cmbCliente_TextChanged;
                cmbCliente.DataSource = null;
                cmbCliente.TextChanged += cmbCliente_TextChanged;
                return;
            }

            var filtrados = _todosClientes
                .Where(c => c.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
                         || c.Correo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            cmbCliente.TextChanged -= cmbCliente_TextChanged;

            if (filtrados.Count > 0)
            {
                cmbCliente.DataSource = filtrados;
                cmbCliente.DisplayMember = "Nombre";
                cmbCliente.ValueMember = "IdCliente";
                cmbCliente.Text = texto;
                cmbCliente.SelectionStart = texto.Length;

                if (cmbCliente.Focused && !cmbCliente.DroppedDown)
                    SendKeys.Send("{F4}");
            }

            cmbCliente.TextChanged += cmbCliente_TextChanged;
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem is ClienteDTO cliente)
            {
                _seleccionandoCliente = true;
                _textoSeleccionadoCliente = cliente.Nombre;
            }
        }

        // ----------------- AUTOCOMPLETE PRODUCTO -----------------------
        private void cmbProducto_TextChanged(object sender, EventArgs e)
        {
            string texto = cmbProducto.Text;

            // Si hay una selección activa pero el texto ya cambió, el usuario volvió a escribir
            if (_seleccionandoProducto)
            {
                if (texto != _textoSeleccionadoProducto)
                    _seleccionandoProducto = false;
                else
                    return;
            }

            if (string.IsNullOrWhiteSpace(texto))
            {
                _productoSeleccionado = null;
                _textoSeleccionadoProducto = null;
                txtPrecio.TextButton = string.Empty;
                cmbProducto.TextChanged -= cmbProducto_TextChanged;
                cmbProducto.DataSource = null;
                cmbProducto.TextChanged += cmbProducto_TextChanged;
                return;
            }

            var filtrados = _todosProductos
                .Where(p => p.Nombre.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0
                         || p.Codigo.IndexOf(texto, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            cmbProducto.TextChanged -= cmbProducto_TextChanged;

            if (filtrados.Count > 0)
            {
                cmbProducto.DataSource = filtrados;
                cmbProducto.DisplayMember = "Nombre";
                cmbProducto.ValueMember = "IdProducto";
                cmbProducto.Text = texto;
                cmbProducto.SelectionStart = texto.Length;

                if (cmbProducto.Focused && !cmbProducto.DroppedDown)
                    SendKeys.Send("{F4}");
            }

            cmbProducto.TextChanged += cmbProducto_TextChanged;
        }

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedItem is ProductoDTO prod)
            {
                _seleccionandoProducto = true;
                _textoSeleccionadoProducto = prod.Nombre;
                _productoSeleccionado = prod;
                txtPrecio.TextButton = prod.Precio.ToString("N2");
            }
        }

        // ------------------- AGREGAR AL CARRO -----------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado == null && cmbProducto.SelectedItem is ProductoDTO prodCombo)
                _productoSeleccionado = prodCombo;

            if (_productoSeleccionado == null)
            {
                MessageBox.Show("Seleccione un producto válido de la lista.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cantidadTexto = txtCantidad.TextButton?.Trim() ?? string.Empty;
            if (!int.TryParse(cantidadTexto, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor a 0.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var enCarro = _carro.FirstOrDefault(x => x.Detalle.CodigoProducto == _productoSeleccionado.Codigo);
            int yaAgregado = enCarro.Detalle?.Cantidad ?? 0;
            int stockLibre = _productoSeleccionado.Stock - yaAgregado;

            if (cantidad > stockLibre)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {stockLibre} unidades.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enCarro.Detalle != null)
            {
                enCarro.Detalle.Cantidad += cantidad;
                enCarro.Detalle.Subtotal = enCarro.Detalle.PrecioUnitario * enCarro.Detalle.Cantidad;
            }
            else
            {
                var detalle = new DetalleVentaDTO
                {
                    CodigoProducto = _productoSeleccionado.Codigo,
                    Cantidad = cantidad,
                    PrecioUnitario = _productoSeleccionado.Precio,
                    Subtotal = _productoSeleccionado.Precio * cantidad
                };
                _carro.Add((detalle, _productoSeleccionado));
            }

            ActualizarGridCarro();

            cmbProducto.TextChanged -= cmbProducto_TextChanged;
            cmbProducto.DataSource = null;
            cmbProducto.Text = string.Empty;
            cmbProducto.TextChanged += cmbProducto_TextChanged;

            txtCantidad.TextButton = string.Empty;
            txtPrecio.TextButton = string.Empty;
            _productoSeleccionado = null;
            _seleccionandoProducto = false;
            _textoSeleccionadoProducto = null;
        }

        // ------------------- REFRESCAR GRID -----------------------
        private void ActualizarGridCarro()
        {
            dgvCarro.Rows.Clear();
            decimal subtotalSinIva = 0;

            foreach (var (detalle, producto) in _carro)
            {
                dgvCarro.Rows.Add(
                    producto.Codigo,
                    producto.Nombre,
                    producto.Descripcion,
                    detalle.Cantidad,
                    detalle.Subtotal.ToString("N2")
                );
                subtotalSinIva += detalle.Subtotal;
            }

            decimal iva = subtotalSinIva * TASA_IVA;
            decimal total = subtotalSinIva + iva;

            lblSubtotal.Text = subtotalSinIva.ToString("N2") + " ₡";
            lblIva.Text = iva.ToString("N2") + " ₡";
            lblTotal.Text = total.ToString("N2") + " ₡";
        }

        // ------------------- FINALIZAR COMPRA -----------------------
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (!(cmbCliente.SelectedItem is ClienteDTO clienteSeleccionado))
            {
                MessageBox.Show("Seleccione un cliente válido de la lista.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_carro.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto al carro antes de finalizar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal = _carro.Sum(x => x.Detalle.Subtotal);
            decimal iva = subtotal * TASA_IVA;
            decimal total = subtotal + iva;

            VentaDTO venta = new VentaDTO
            {
                IdClienteFk = clienteSeleccionado.IdCliente,
                IdVendedorFk = _vendedorActivo.IdVendedor,
                Fecha = DateTime.Now,
                Total = total
            };

            List<DetalleVentaDTO> detalles = _carro.Select(x => x.Detalle).ToList();

            try
            {
                int idVenta = ventasBll.RegistrarVenta(venta, detalles);

                MessageBox.Show($"¡Venta #{idVenta} registrada exitosamente!\nTotal: ₡{total:N2}",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                _todosProductos = productosBll.ObtenerTodos();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar la venta: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------------------- LIMPIAR --------------------------
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de que desea limpiar el carro?",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            _carro.Clear();
            _productoSeleccionado = null;
            _seleccionandoProducto = false;
            _seleccionandoCliente = false;
            _textoSeleccionadoProducto = null;
            _textoSeleccionadoCliente = null;

            dgvCarro.Rows.Clear();

            lblSubtotal.Text = "0.00 ₡";
            lblIva.Text = "0.00 ₡";
            lblTotal.Text = "0.00 ₡";

            cmbCliente.TextChanged -= cmbCliente_TextChanged;
            cmbCliente.DataSource = null;
            cmbCliente.Text = string.Empty;
            cmbCliente.TextChanged += cmbCliente_TextChanged;

            cmbProducto.TextChanged -= cmbProducto_TextChanged;
            cmbProducto.DataSource = null;
            cmbProducto.Text = string.Empty;
            cmbProducto.TextChanged += cmbProducto_TextChanged;

            txtCantidad.TextButton = string.Empty;
            txtPrecio.TextButton = string.Empty;
        }

        private void cmbCliente_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}