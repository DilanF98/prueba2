namespace Presentacion
{
    partial class DashboardForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvProductos = new ReaLTaiizor.Controls.PoisonDataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblEncabezado = new ReaLTaiizor.Controls.LabelEdit();
            btnNotificacion = new Button();
            tableLayoutPanel6 = new TableLayoutPanel();
            cardVendedores = new ReaLTaiizor.Controls.ParrotCard();
            cardStock = new ReaLTaiizor.Controls.ParrotCard();
            cardVentasTotales = new ReaLTaiizor.Controls.ParrotCard();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            dgvVentas = new ReaLTaiizor.Controls.PoisonDataGridView();
            Id = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            lblTopVentas = new ReaLTaiizor.Controls.LabelEdit();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblTopProductos = new ReaLTaiizor.Controls.LabelEdit();
            lblSubtexto = new ReaLTaiizor.Controls.LabelEdit();
            lblBienvenida = new ReaLTaiizor.Controls.LabelEdit();
            lblTextoPrincipal = new ReaLTaiizor.Controls.LabelEdit();
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
            tableLayoutPanel5 = new TableLayoutPanel();
            lblRol = new ReaLTaiizor.Controls.HeaderLabel();
            lblNombre = new ReaLTaiizor.Controls.HeaderLabel();
            imgUsuario = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).BeginInit();
            tableLayoutPanel9.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
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
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(292, 4);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1556, 1058);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(dgvProductos, 0, 3);
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel6, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0, 4, 4, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Size = new Size(1556, 1058);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, Nombre, Descripcion, Cantidad });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.Dock = DockStyle.Fill;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvProductos.GridColor = Color.FromArgb(255, 255, 255);
            dgvProductos.Location = new Point(19, 729);
            dgvProductos.Margin = new Padding(19, 19, 19, 19);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(1518, 310);
            dgvProductos.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdProducto";
            dataGridViewTextBoxColumn1.FillWeight = 26.7379684F;
            dataGridViewTextBoxColumn1.HeaderText = "Id";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
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
            lblEncabezado.TabIndex = 3;
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
            btnNotificacion.TabIndex = 10;
            btnNotificacion.UseVisualStyleBackColor = false;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel6.Controls.Add(cardVendedores, 2, 0);
            tableLayoutPanel6.Controls.Add(cardStock, 1, 0);
            tableLayoutPanel6.Controls.Add(cardVentasTotales, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 68);
            tableLayoutPanel6.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 141F));
            tableLayoutPanel6.Size = new Size(1548, 141);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // cardVendedores
            // 
            cardVendedores.BackColor = Color.Transparent;
            cardVendedores.Color1 = Color.LightGray;
            cardVendedores.Color2 = Color.White;
            cardVendedores.Dock = DockStyle.Fill;
            cardVendedores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardVendedores.ForeColor = Color.DimGray;
            cardVendedores.Location = new Point(1087, 4);
            cardVendedores.Margin = new Padding(4, 4, 4, 4);
            cardVendedores.Name = "cardVendedores";
            cardVendedores.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardVendedores.Size = new Size(457, 133);
            cardVendedores.TabIndex = 2;
            cardVendedores.Text = "parrotCard1";
            cardVendedores.Text1 = "Vendedores Activos";
            cardVendedores.Text2 = "6 Vendedores";
            cardVendedores.Text3 = "2 Nuevas Contrataciones";
            cardVendedores.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // cardStock
            // 
            cardStock.BackColor = Color.Transparent;
            cardStock.Color1 = Color.White;
            cardStock.Color2 = Color.White;
            cardStock.Dock = DockStyle.Fill;
            cardStock.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardStock.ForeColor = Color.Black;
            cardStock.Location = new Point(623, 4);
            cardStock.Margin = new Padding(4, 4, 4, 4);
            cardStock.Name = "cardStock";
            cardStock.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardStock.Size = new Size(456, 133);
            cardStock.TabIndex = 1;
            cardStock.Text = "parrotCard1";
            cardStock.Text1 = "Stock";
            cardStock.Text2 = "400 Unidades";
            cardStock.Text3 = "88% de capacidad maxima";
            cardStock.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // cardVentasTotales
            // 
            cardVentasTotales.BackColor = Color.Transparent;
            cardVentasTotales.Color1 = Color.FromArgb(0, 75, 115);
            cardVentasTotales.Color2 = Color.FromArgb(0, 75, 115);
            cardVentasTotales.Dock = DockStyle.Fill;
            cardVentasTotales.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardVentasTotales.ForeColor = Color.White;
            cardVentasTotales.Location = new Point(4, 4);
            cardVentasTotales.Margin = new Padding(4, 4, 4, 4);
            cardVentasTotales.Name = "cardVentasTotales";
            cardVentasTotales.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardVentasTotales.Size = new Size(611, 133);
            cardVentasTotales.TabIndex = 0;
            cardVentasTotales.Text = "parrotCard1";
            cardVentasTotales.Text1 = "Ventas totales";
            cardVentasTotales.Text2 = "25 Ventas en la semana";
            cardVentasTotales.Text3 = "+ 15% vs la anterior";
            cardVentasTotales.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.48387F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.51613F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 1, 0);
            tableLayoutPanel7.Controls.Add(tableLayoutPanel9, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(4, 217);
            tableLayoutPanel7.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1548, 489);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Controls.Add(dgvVentas, 0, 1);
            tableLayoutPanel8.Controls.Add(lblTopVentas, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(1017, 4);
            tableLayoutPanel8.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 2;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel8.Size = new Size(527, 481);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // dgvVentas
            // 
            dgvVentas.AllowUserToAddRows = false;
            dgvVentas.AllowUserToDeleteRows = false;
            dgvVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvVentas.BorderStyle = BorderStyle.None;
            dgvVentas.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentas.Columns.AddRange(new DataGridViewColumn[] { Id, Fecha, Total });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvVentas.DefaultCellStyle = dataGridViewCellStyle8;
            dgvVentas.Dock = DockStyle.Fill;
            dgvVentas.EnableHeadersVisualStyles = false;
            dgvVentas.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvVentas.GridColor = Color.FromArgb(255, 255, 255);
            dgvVentas.Location = new Point(19, 67);
            dgvVentas.Margin = new Padding(19, 19, 19, 19);
            dgvVentas.Name = "dgvVentas";
            dgvVentas.ReadOnly = true;
            dgvVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvVentas.RowHeadersWidth = 51;
            dgvVentas.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVentas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentas.Size = new Size(489, 395);
            dgvVentas.TabIndex = 7;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdProducto";
            Id.FillWeight = 26.7379684F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // lblTopVentas
            // 
            lblTopVentas.AutoSize = true;
            lblTopVentas.BackColor = Color.Transparent;
            lblTopVentas.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopVentas.ForeColor = Color.Black;
            lblTopVentas.Location = new Point(12, 4);
            lblTopVentas.Margin = new Padding(12, 4, 4, 4);
            lblTopVentas.Name = "lblTopVentas";
            lblTopVentas.Size = new Size(210, 38);
            lblTopVentas.TabIndex = 4;
            lblTopVentas.Text = "Ultimas ventas";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 1;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Controls.Add(lblTopProductos, 0, 3);
            tableLayoutPanel9.Controls.Add(lblSubtexto, 0, 2);
            tableLayoutPanel9.Controls.Add(lblBienvenida, 0, 0);
            tableLayoutPanel9.Controls.Add(lblTextoPrincipal, 0, 1);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(4, 4);
            tableLayoutPanel9.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 4;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 136F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 142F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel9.Size = new Size(1005, 481);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // lblTopProductos
            // 
            lblTopProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTopProductos.AutoSize = true;
            lblTopProductos.BackColor = Color.Transparent;
            lblTopProductos.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTopProductos.ForeColor = Color.Black;
            lblTopProductos.Location = new Point(12, 439);
            lblTopProductos.Margin = new Padding(12, 4, 4, 4);
            lblTopProductos.Name = "lblTopProductos";
            lblTopProductos.Size = new Size(417, 38);
            lblTopProductos.TabIndex = 8;
            lblTopProductos.Text = "Productos con mayor cantidad";
            // 
            // lblSubtexto
            // 
            lblSubtexto.Anchor = AnchorStyles.Top;
            lblSubtexto.AutoSize = true;
            lblSubtexto.BackColor = Color.Transparent;
            lblSubtexto.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtexto.ForeColor = Color.Black;
            lblSubtexto.Location = new Point(265, 281);
            lblSubtexto.Margin = new Padding(12, 4, 4, 4);
            lblSubtexto.Name = "lblSubtexto";
            lblSubtexto.Size = new Size(482, 48);
            lblSubtexto.TabIndex = 7;
            lblSubtexto.Text = "¿Qué deseas gestionar hoy?";
            // 
            // lblBienvenida
            // 
            lblBienvenida.Anchor = AnchorStyles.Bottom;
            lblBienvenida.AutoSize = true;
            lblBienvenida.BackColor = Color.Transparent;
            lblBienvenida.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.ForeColor = Color.Black;
            lblBienvenida.Location = new Point(225, 84);
            lblBienvenida.Margin = new Padding(12, 4, 4, 4);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(562, 48);
            lblBienvenida.TabIndex = 5;
            lblBienvenida.Text = "Bienvenido al Sistema de Ventas";
            // 
            // lblTextoPrincipal
            // 
            lblTextoPrincipal.Anchor = AnchorStyles.None;
            lblTextoPrincipal.AutoSize = true;
            lblTextoPrincipal.BackColor = Color.Transparent;
            lblTextoPrincipal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTextoPrincipal.ForeColor = Color.FromArgb(0, 75, 115);
            lblTextoPrincipal.Location = new Point(506, 184);
            lblTextoPrincipal.Margin = new Padding(12, 4, 4, 4);
            lblTextoPrincipal.Name = "lblTextoPrincipal";
            lblTextoPrincipal.Size = new Size(0, 45);
            lblTextoPrincipal.TabIndex = 6;
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
            tableLayoutPanel3.Margin = new Padding(4, 4, 4, 4);
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
            btnLogout.Margin = new Padding(4, 4, 4, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.PressedBorderColor = Color.Brown;
            btnLogout.PressedColor = Color.Brown;
            btnLogout.Size = new Size(272, 60);
            btnLogout.TabIndex = 22;
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
            btnVentas.BackColor = Color.Transparent;
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
            btnDashboard.BackColor = SystemColors.Control;
            btnDashboard.Dock = DockStyle.Fill;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.FromArgb(0, 75, 115);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 118);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(280, 69);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click_1;
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
            lblTitulo.Padding = new Padding(12, 14, 12, 14);
            lblTitulo.Size = new Size(272, 64);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "EdgeMarket PoS";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.15873F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.84127F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 0);
            tableLayoutPanel4.Controls.Add(imgUsuario, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(4, 915);
            tableLayoutPanel4.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.Size = new Size(272, 71);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(lblRol, 0, 1);
            tableLayoutPanel5.Controls.Add(lblNombre, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(86, 4);
            tableLayoutPanel5.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 48.93617F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 51.06383F));
            tableLayoutPanel5.Size = new Size(182, 63);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // lblRol
            // 
            lblRol.BackColor = Color.Transparent;
            lblRol.Dock = DockStyle.Top;
            lblRol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.FromArgb(103, 121, 141);
            lblRol.ImageAlign = ContentAlignment.TopCenter;
            lblRol.Location = new Point(4, 30);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(174, 33);
            lblRol.TabIndex = 9;
            lblRol.Text = "Rol**";
            lblRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblNombre
            // 
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Dock = DockStyle.Top;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.FromArgb(103, 121, 141);
            lblNombre.ImageAlign = ContentAlignment.TopCenter;
            lblNombre.Location = new Point(8, 0);
            lblNombre.Margin = new Padding(8, 0, 11, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(163, 30);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre**";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgUsuario
            // 
            imgUsuario.Anchor = AnchorStyles.Right;
            imgUsuario.BackgroundImage = (Image)resources.GetObject("imgUsuario.BackgroundImage");
            imgUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            imgUsuario.Location = new Point(11, 5);
            imgUsuario.Margin = new Padding(10, 4, 10, 4);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(61, 60);
            imgUsuario.TabIndex = 0;
            imgUsuario.TabStop = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 241, 251);
            ClientSize = new Size(1852, 1066);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "DashboardForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentas).EndInit();
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgUsuario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnProductos;
        private Button btnClientes;
        private Button btnDashboard;
        private ReaLTaiizor.Controls.HeaderLabel lblSubtitulo;
        private ReaLTaiizor.Controls.HeaderLabel lblTitulo;
        private Button btnVendedores;
        private Button btnVentas;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox imgUsuario;
        private TableLayoutPanel tableLayoutPanel5;
        private ReaLTaiizor.Controls.HeaderLabel lblRol;
        private ReaLTaiizor.Controls.HeaderLabel lblNombre;
        private FlowLayoutPanel flowLayoutPanel1;
        private ReaLTaiizor.Controls.LabelEdit lblEncabezado;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.ParrotCard cardVentasTotales;
        private ReaLTaiizor.Controls.ParrotCard cardVendedores;
        private ReaLTaiizor.Controls.ParrotCard cardStock;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.LabelEdit lblTopVentas;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvVentas;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvProductos;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btnNotificacion;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Total;
        private ReaLTaiizor.Controls.LabelEdit lblBienvenida;
        private ReaLTaiizor.Controls.LabelEdit lblTextoPrincipal;
        private ReaLTaiizor.Controls.LabelEdit lblTopProductos;
        private ReaLTaiizor.Controls.LabelEdit lblSubtexto;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private ReaLTaiizor.Controls.Button btnLogout;
    }
}