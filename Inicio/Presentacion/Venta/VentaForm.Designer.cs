namespace Presentacion
{
    partial class VentaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentaForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblEncabezado = new ReaLTaiizor.Controls.LabelEdit();
            btnNotificacion = new Button();
            panel2 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnEliminar = new ReaLTaiizor.Controls.Button();
            btnInsertar = new ReaLTaiizor.Controls.Button();
            lblVentas = new ReaLTaiizor.Controls.HeaderLabel();
            panel3 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnBuscar = new ReaLTaiizor.Controls.Button();
            btnPdf = new ReaLTaiizor.Controls.Button();
            btnExcel = new ReaLTaiizor.Controls.Button();
            dgvVentas = new ReaLTaiizor.Controls.PoisonDataGridView();
            Id = new DataGridViewTextBoxColumn();
            IdCliente = new DataGridViewTextBoxColumn();
            NombreCliente = new DataGridViewTextBoxColumn();
            IdVendedor = new DataGridViewTextBoxColumn();
            NombreVendedor = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tableLayoutPanel7 = new TableLayoutPanel();
            cardVentasRealizadas = new ReaLTaiizor.Controls.ParrotCard();
            cardTotalVendido = new ReaLTaiizor.Controls.ParrotCard();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnLogout = new ReaLTaiizor.Controls.Button();
            btnVendedores = new Button();
            btnVentas = new Button();
            btnClientes = new Button();
            btnProductos = new Button();
            btnDashboard = new Button();
            lblSubtitulo = new ReaLTaiizor.Controls.HeaderLabel();
            lblTitulo = new ReaLTaiizor.Controls.HeaderLabel();
            tableLayoutPanel4 = new TableLayoutPanel();
            imgUsuario = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            lblRol = new ReaLTaiizor.Controls.HeaderLabel();
            lblNombre = new ReaLTaiizor.Controls.HeaderLabel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1852, 1066);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(292, 4);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1556, 1058);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 2);
            tableLayoutPanel2.Controls.Add(dgvVentas, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 59F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1556, 1058);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.Controls.Add(lblEncabezado);
            flowLayoutPanel1.Controls.Add(btnNotificacion);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 62, 0);
            flowLayoutPanel1.Size = new Size(1556, 64);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.FromArgb(103, 121, 141);
            lblEncabezado.Location = new Point(1279, 12);
            lblEncabezado.Margin = new Padding(4, 12, 4, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(211, 32);
            lblEncabezado.TabIndex = 17;
            lblEncabezado.Text = "Sistema de ventas";
            // 
            // btnNotificacion
            // 
            btnNotificacion.BackColor = Color.Transparent;
            btnNotificacion.Dock = DockStyle.Fill;
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNotificacion.ForeColor = Color.FromArgb(0, 75, 115);
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.ImageAlign = ContentAlignment.MiddleLeft;
            btnNotificacion.Location = new Point(1213, 12);
            btnNotificacion.Margin = new Padding(0, 12, 0, 0);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(62, 32);
            btnNotificacion.TabIndex = 18;
            btnNotificacion.UseVisualStyleBackColor = false;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 68);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1548, 56);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 3;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.1149445F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9425287F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9425287F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(btnEliminar, 2, 0);
            tableLayoutPanel8.Controls.Add(btnInsertar, 1, 0);
            tableLayoutPanel8.Controls.Add(lblVentas, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1548, 56);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BorderColor = Color.Brown;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.EnteredBorderColor = Color.Brown;
            btnEliminar.EnteredColor = Color.Brown;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.InactiveColor = Color.Brown;
            btnEliminar.Location = new Point(1320, 4);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedBorderColor = Color.Brown;
            btnEliminar.PressedColor = Color.Brown;
            btnEliminar.Size = new Size(224, 48);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "    Eliminar";
            btnEliminar.TextAlignment = StringAlignment.Near;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Transparent;
            btnInsertar.BorderColor = Color.FromArgb(32, 34, 37);
            btnInsertar.Dock = DockStyle.Fill;
            btnInsertar.EnteredBorderColor = Color.Black;
            btnInsertar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnInsertar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Image = (Image)resources.GetObject("btnInsertar.Image");
            btnInsertar.ImageAlign = ContentAlignment.MiddleLeft;
            btnInsertar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnInsertar.Location = new Point(1089, 4);
            btnInsertar.Margin = new Padding(4);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.PressedBorderColor = Color.Black;
            btnInsertar.PressedColor = Color.Black;
            btnInsertar.Size = new Size(223, 48);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "    Insertar";
            btnInsertar.TextAlignment = StringAlignment.Near;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.BackColor = Color.Transparent;
            lblVentas.Dock = DockStyle.Left;
            lblVentas.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.ForeColor = Color.Black;
            lblVentas.Location = new Point(0, 0);
            lblVentas.Margin = new Padding(0, 0, 4, 0);
            lblVentas.Name = "lblVentas";
            lblVentas.Padding = new Padding(19, 0, 0, 0);
            lblVentas.Size = new Size(324, 56);
            lblVentas.TabIndex = 17;
            lblVentas.Text = "Lista de Ventas";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Dock = DockStyle.Fill;
            panel3.EdgeColor = SystemColors.Control;
            panel3.Location = new Point(26, 128);
            panel3.Margin = new Padding(26, 0, 26, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6);
            panel3.Size = new Size(1504, 59);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 5;
            panel3.Text = "panel3";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 5;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel6.Controls.Add(btnBuscar, 4, 0);
            tableLayoutPanel6.Controls.Add(btnPdf, 1, 0);
            tableLayoutPanel6.Controls.Add(btnExcel, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(6, 6);
            tableLayoutPanel6.Margin = new Padding(4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1492, 47);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BorderColor = Color.FromArgb(255, 128, 0);
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.EnteredBorderColor = Color.FromArgb(255, 128, 0);
            btnBuscar.EnteredColor = Color.FromArgb(255, 128, 0);
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = null;
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.InactiveColor = Color.FromArgb(255, 128, 0);
            btnBuscar.Location = new Point(1196, 4);
            btnBuscar.Margin = new Padding(4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.PressedBorderColor = Color.FromArgb(255, 128, 0);
            btnBuscar.PressedColor = Color.FromArgb(255, 128, 0);
            btnBuscar.Size = new Size(292, 39);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "    Buscar Detalle Venta";
            btnBuscar.TextAlignment = StringAlignment.Near;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnPdf
            // 
            btnPdf.BackColor = Color.Transparent;
            btnPdf.BorderColor = Color.Brown;
            btnPdf.Dock = DockStyle.Fill;
            btnPdf.EnteredBorderColor = Color.Brown;
            btnPdf.EnteredColor = Color.Brown;
            btnPdf.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPdf.Image = (Image)resources.GetObject("btnPdf.Image");
            btnPdf.ImageAlign = ContentAlignment.MiddleRight;
            btnPdf.InactiveColor = Color.Brown;
            btnPdf.Location = new Point(153, 4);
            btnPdf.Margin = new Padding(4);
            btnPdf.Name = "btnPdf";
            btnPdf.PressedBorderColor = Color.Brown;
            btnPdf.PressedColor = Color.Brown;
            btnPdf.Size = new Size(141, 39);
            btnPdf.TabIndex = 17;
            btnPdf.Text = "Exportar";
            btnPdf.TextAlignment = StringAlignment.Near;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Transparent;
            btnExcel.BorderColor = Color.ForestGreen;
            btnExcel.Dock = DockStyle.Fill;
            btnExcel.EnteredBorderColor = Color.ForestGreen;
            btnExcel.EnteredColor = Color.ForestGreen;
            btnExcel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcel.Image = (Image)resources.GetObject("btnExcel.Image");
            btnExcel.ImageAlign = ContentAlignment.MiddleRight;
            btnExcel.InactiveColor = Color.ForestGreen;
            btnExcel.Location = new Point(4, 4);
            btnExcel.Margin = new Padding(4);
            btnExcel.Name = "btnExcel";
            btnExcel.PressedBorderColor = Color.ForestGreen;
            btnExcel.PressedColor = Color.ForestGreen;
            btnExcel.Size = new Size(141, 39);
            btnExcel.TabIndex = 16;
            btnExcel.Text = "Exportar";
            btnExcel.TextAlignment = StringAlignment.Near;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Id, IdCliente, NombreCliente, IdVendedor, NombreVendedor, fecha, Total });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvVentas.GridColor = Color.FromArgb(255, 255, 255);
            dgvVentas.Location = new Point(19, 206);
            dgvVentas.Margin = new Padding(19);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(1518, 658);
            dgvVentas.TabIndex = 6;
            dgvVentas.CellContentClick += dgvVentas_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdVenta";
            Id.FillWeight = 50F;
            Id.HeaderText = "Nº Venta";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // IdCliente
            // 
            IdCliente.DataPropertyName = "IdClienteFk";
            IdCliente.HeaderText = "ID Cliente";
            IdCliente.MinimumWidth = 6;
            IdCliente.Name = "IdCliente";
            IdCliente.ReadOnly = true;
            // 
            // NombreCliente
            // 
            NombreCliente.DataPropertyName = "NombreCliente";
            NombreCliente.HeaderText = "Nombre Cliente";
            NombreCliente.MinimumWidth = 8;
            NombreCliente.Name = "NombreCliente";
            NombreCliente.ReadOnly = true;
            // 
            // IdVendedor
            // 
            IdVendedor.DataPropertyName = "IdVendedorFk";
            IdVendedor.HeaderText = "ID Vendedor";
            IdVendedor.MinimumWidth = 6;
            IdVendedor.Name = "IdVendedor";
            IdVendedor.ReadOnly = true;
            // 
            // NombreVendedor
            // 
            NombreVendedor.DataPropertyName = "NombreVendedor";
            NombreVendedor.HeaderText = "Nombre Vendedor";
            NombreVendedor.MinimumWidth = 8;
            NombreVendedor.Name = "NombreVendedor";
            NombreVendedor.ReadOnly = true;
            // 
            // fecha
            // 
            fecha.DataPropertyName = "Fecha";
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.ReadOnly = true;
            // 
            // Total
            // 
            Total.DataPropertyName = "Total";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel7.Controls.Add(cardVentasRealizadas, 1, 0);
            tableLayoutPanel7.Controls.Add(cardTotalVendido, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(4, 887);
            tableLayoutPanel7.Margin = new Padding(4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1548, 167);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // cardVentasRealizadas
            // 
            cardVentasRealizadas.BackColor = Color.Transparent;
            cardVentasRealizadas.Color1 = Color.LightGray;
            cardVentasRealizadas.Color2 = Color.White;
            cardVentasRealizadas.Dock = DockStyle.Fill;
            cardVentasRealizadas.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardVentasRealizadas.ForeColor = Color.Black;
            cardVentasRealizadas.Location = new Point(812, 19);
            cardVentasRealizadas.Margin = new Padding(38, 19, 38, 19);
            cardVentasRealizadas.Name = "cardVentasRealizadas";
            cardVentasRealizadas.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardVentasRealizadas.Size = new Size(698, 129);
            cardVentasRealizadas.TabIndex = 1;
            cardVentasRealizadas.Text = "parrotCard2";
            cardVentasRealizadas.Text1 = "Ventas Realizadas";
            cardVentasRealizadas.Text2 = "28 Ventas";
            cardVentasRealizadas.Text3 = "";
            cardVentasRealizadas.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // cardTotalVendido
            // 
            cardTotalVendido.BackColor = Color.Transparent;
            cardTotalVendido.Color1 = Color.LightGray;
            cardTotalVendido.Color2 = Color.White;
            cardTotalVendido.Dock = DockStyle.Fill;
            cardTotalVendido.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardTotalVendido.ForeColor = Color.Black;
            cardTotalVendido.Location = new Point(38, 19);
            cardTotalVendido.Margin = new Padding(38, 19, 38, 19);
            cardTotalVendido.Name = "cardTotalVendido";
            cardTotalVendido.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardTotalVendido.Size = new Size(698, 129);
            cardTotalVendido.TabIndex = 0;
            cardTotalVendido.Text = "parrotCard1";
            cardTotalVendido.Text1 = "Total Vendido";
            cardTotalVendido.Text2 = "₡ 850 000";
            cardTotalVendido.Text3 = "";
            cardTotalVendido.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(btnLogout, 0, 9);
            tableLayoutPanel3.Controls.Add(btnVendedores, 0, 6);
            tableLayoutPanel3.Controls.Add(btnVentas, 0, 5);
            tableLayoutPanel3.Controls.Add(btnClientes, 0, 4);
            tableLayoutPanel3.Controls.Add(btnProductos, 0, 3);
            tableLayoutPanel3.Controls.Add(btnDashboard, 0, 2);
            tableLayoutPanel3.Controls.Add(lblSubtitulo, 0, 1);
            tableLayoutPanel3.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 8);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(4, 4);
            tableLayoutPanel3.Margin = new Padding(4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 10;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel3.Size = new Size(280, 1058);
            tableLayoutPanel3.TabIndex = 4;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.BorderColor = Color.Brown;
            btnLogout.Dock = DockStyle.Fill;
            btnLogout.EnteredBorderColor = Color.Brown;
            btnLogout.EnteredColor = Color.Brown;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Image = null;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.InactiveColor = Color.Brown;
            btnLogout.Location = new Point(4, 994);
            btnLogout.Margin = new Padding(4);
            btnLogout.Name = "btnLogout";
            btnLogout.PressedBorderColor = Color.Brown;
            btnLogout.PressedColor = Color.Brown;
            btnLogout.Size = new Size(272, 60);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.TextAlignment = StringAlignment.Center;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.BackColor = Color.Transparent;
            btnVendedores.Dock = DockStyle.Fill;
            btnVendedores.FlatAppearance.BorderSize = 0;
            btnVendedores.FlatStyle = FlatStyle.Flat;
            btnVendedores.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendedores.ForeColor = Color.FromArgb(0, 75, 115);
            btnVendedores.Image = (Image)resources.GetObject("btnVendedores.Image");
            btnVendedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendedores.Location = new Point(0, 394);
            btnVendedores.Margin = new Padding(0);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(280, 69);
            btnVendedores.TabIndex = 10;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = false;
            btnVendedores.Visible = false;
            btnVendedores.Click += btnVendedores_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = SystemColors.Control;
            btnVentas.Dock = DockStyle.Fill;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = Color.FromArgb(0, 75, 115);
            btnVentas.Image = (Image)resources.GetObject("btnVentas.Image");
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 325);
            btnVentas.Margin = new Padding(0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(280, 69);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = Color.Transparent;
            btnClientes.Dock = DockStyle.Fill;
            btnClientes.FlatAppearance.BorderSize = 0;
            btnClientes.FlatStyle = FlatStyle.Flat;
            btnClientes.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.ForeColor = Color.FromArgb(0, 75, 115);
            btnClientes.Image = (Image)resources.GetObject("btnClientes.Image");
            btnClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnClientes.Location = new Point(0, 256);
            btnClientes.Margin = new Padding(0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(280, 69);
            btnClientes.TabIndex = 8;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = false;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.Transparent;
            btnProductos.Dock = DockStyle.Fill;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProductos.ForeColor = Color.FromArgb(0, 75, 115);
            btnProductos.Image = (Image)resources.GetObject("btnProductos.Image");
            btnProductos.ImageAlign = ContentAlignment.MiddleLeft;
            btnProductos.Location = new Point(0, 187);
            btnProductos.Margin = new Padding(0);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(280, 69);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(10, 75, 115);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 118);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(280, 69);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Dock = DockStyle.Top;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.FromArgb(103, 121, 141);
            lblSubtitulo.ImageAlign = ContentAlignment.TopCenter;
            lblSubtitulo.Location = new Point(4, 69);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(272, 32);
            lblSubtitulo.TabIndex = 5;
            lblSubtitulo.Text = "Sistema de ventas";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Image = (Image)resources.GetObject("lblTitulo.Image");
            lblTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Location = new Point(4, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(12);
            lblTitulo.Size = new Size(272, 60);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "EdgeMarket PoS";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(imgUsuario, 0, 0);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 915);
            tableLayoutPanel4.Margin = new Padding(4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.Size = new Size(272, 71);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // imgUsuario
            // 
            imgUsuario.Anchor = AnchorStyles.Right;
            imgUsuario.BackgroundImage = (Image)resources.GetObject("imgUsuario.BackgroundImage");
            imgUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            imgUsuario.Location = new Point(9, 5);
            imgUsuario.Margin = new Padding(4);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(68, 60);
            imgUsuario.TabIndex = 0;
            imgUsuario.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lblRol, 0, 1);
            tableLayoutPanel5.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(85, 4);
            tableLayoutPanel5.Margin = new Padding(4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(183, 63);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Dock = DockStyle.Top;
            lblRol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(103, 121, 141);
            lblRol.ImageAlign = ContentAlignment.TopCenter;
            lblRol.Location = new Point(4, 31);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(175, 32);
            lblRol.TabIndex = 9;
            lblRol.Text = "Rol**";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(103, 121, 141);
            lblNombre.ImageAlign = ContentAlignment.TopCenter;
            lblNombre.Location = new Point(4, 0);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(175, 31);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre**";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 241, 251);
            ClientSize = new Size(1852, 1066);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4);
            Name = "VentaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnVendedores;
        private Button btnVentas;
        private Button btnClientes;
        private Button btnProductos;
        private Button btnDashboard;
        private ReaLTaiizor.Controls.HeaderLabel lblSubtitulo;
        private ReaLTaiizor.Controls.HeaderLabel lblTitulo;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox imgUsuario;
        private TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.HeaderLabel lblRol;
        private ReaLTaiizor.Controls.HeaderLabel lblNombre;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Button btnEliminar;
        private ReaLTaiizor.Controls.Button btnInsertar;
        private ReaLTaiizor.Controls.HeaderLabel lblVentas;
        private ReaLTaiizor.Controls.Panel panel3;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.Button btnPdf;
        private ReaLTaiizor.Controls.Button btnExcel;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvVentas;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.ParrotCard cardVentasRealizadas;
        private ReaLTaiizor.Controls.ParrotCard cardTotalVendido;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.LabelEdit lblEncabezado;
        private Button btnNotificacion;
        private ReaLTaiizor.Controls.Button btnLogout;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn IdCliente;
        private DataGridViewTextBoxColumn NombreCliente;
        private DataGridViewTextBoxColumn IdVendedor;
        private DataGridViewTextBoxColumn NombreVendedor;
        private DataGridViewTextBoxColumn fecha;
        private DataGridViewTextBoxColumn Total;
    }
}