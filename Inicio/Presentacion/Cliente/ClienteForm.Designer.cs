namespace Presentacion
{
    partial class ClienteForm
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteForm));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblEncabezado = new ReaLTaiizor.Controls.LabelEdit();
            btnNotificacion = new Button();
            panel3 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnPdf = new ReaLTaiizor.Controls.Button();
            btnExcel = new ReaLTaiizor.Controls.Button();
            dgvClientes = new ReaLTaiizor.Controls.PoisonDataGridView();
            Id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            tableLayoutPanel7 = new TableLayoutPanel();
            cardClientes = new ReaLTaiizor.Controls.ParrotCard();
            panel2 = new Panel();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnEliminar = new ReaLTaiizor.Controls.Button();
            btnActualizar = new ReaLTaiizor.Controls.Button();
            btnInsertar = new ReaLTaiizor.Controls.Button();
            lblClientes = new ReaLTaiizor.Controls.HeaderLabel();
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
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgUsuario).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 289F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1851, 1062);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(293, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1554, 1056);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 0, 2);
            tableLayoutPanel2.Controls.Add(dgvClientes, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1554, 1056);
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
            flowLayoutPanel1.Padding = new Padding(0, 0, 61, 0);
            flowLayoutPanel1.Size = new Size(1554, 63);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.FromArgb(103, 121, 141);
            lblEncabezado.Location = new Point(1278, 12);
            lblEncabezado.Margin = new Padding(4, 12, 4, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(211, 32);
            lblEncabezado.TabIndex = 11;
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
            btnNotificacion.Size = new Size(61, 32);
            btnNotificacion.TabIndex = 12;
            btnNotificacion.UseVisualStyleBackColor = false;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Dock = DockStyle.Fill;
            panel3.EdgeColor = SystemColors.Control;
            panel3.Location = new Point(26, 126);
            panel3.Margin = new Padding(26, 0, 26, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(6, 7, 6, 7);
            panel3.Size = new Size(1502, 58);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 5;
            panel3.Text = "panel3";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 4;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel6.Controls.Add(btnPdf, 1, 0);
            tableLayoutPanel6.Controls.Add(btnExcel, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(6, 7);
            tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1490, 44);
            tableLayoutPanel6.TabIndex = 0;
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
            btnPdf.Location = new Point(153, 3);
            btnPdf.Margin = new Padding(4, 3, 4, 3);
            btnPdf.Name = "btnPdf";
            btnPdf.PressedBorderColor = Color.Brown;
            btnPdf.PressedColor = Color.Brown;
            btnPdf.Size = new Size(141, 38);
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
            btnExcel.Location = new Point(4, 3);
            btnExcel.Margin = new Padding(4, 3, 4, 3);
            btnExcel.Name = "btnExcel";
            btnExcel.PressedBorderColor = Color.ForestGreen;
            btnExcel.PressedColor = Color.ForestGreen;
            btnExcel.Size = new Size(141, 38);
            btnExcel.TabIndex = 16;
            btnExcel.Text = "Exportar";
            btnExcel.TextAlignment = StringAlignment.Near;
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClientes.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Gray;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, nombre, telefono, correo });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle8.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle8;
            dgvClientes.Dock = DockStyle.Fill;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvClientes.GridColor = Color.FromArgb(255, 255, 255);
            dgvClientes.Location = new Point(19, 202);
            dgvClientes.Margin = new Padding(19, 18, 19, 18);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Gainsboro;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle9.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvClientes.RowHeadersWidth = 51;
            dgvClientes.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(1516, 661);
            dgvClientes.TabIndex = 6;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdCliente";
            Id.FillWeight = 50F;
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "Nombre";
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "Telefono";
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            // 
            // correo
            // 
            correo.DataPropertyName = "Correo";
            correo.HeaderText = "Correo";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.ReadOnly = true;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel7.Controls.Add(cardClientes, 2, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(4, 884);
            tableLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1546, 169);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // cardClientes
            // 
            cardClientes.BackColor = Color.Transparent;
            cardClientes.Color1 = Color.LightGray;
            cardClientes.Color2 = Color.White;
            cardClientes.Dock = DockStyle.Fill;
            cardClientes.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardClientes.ForeColor = Color.Black;
            cardClientes.Location = new Point(1069, 18);
            cardClientes.Margin = new Padding(39, 18, 39, 18);
            cardClientes.Name = "cardClientes";
            cardClientes.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardClientes.RightToLeft = RightToLeft.No;
            cardClientes.Size = new Size(438, 133);
            cardClientes.TabIndex = 2;
            cardClientes.Text = "parrotCard3";
            cardClientes.Text1 = "Clientes Totales";
            cardClientes.Text2 = "Sin datos";
            cardClientes.Text3 = "";
            cardClientes.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(4, 66);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1546, 57);
            panel2.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 4;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13F));
            tableLayoutPanel8.Controls.Add(btnEliminar, 3, 0);
            tableLayoutPanel8.Controls.Add(btnActualizar, 2, 0);
            tableLayoutPanel8.Controls.Add(btnInsertar, 1, 0);
            tableLayoutPanel8.Controls.Add(lblClientes, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1546, 57);
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
            btnEliminar.Location = new Point(1347, 3);
            btnEliminar.Margin = new Padding(4, 3, 4, 3);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedBorderColor = Color.Brown;
            btnEliminar.PressedColor = Color.Brown;
            btnEliminar.Size = new Size(195, 51);
            btnEliminar.TabIndex = 19;
            btnEliminar.Text = "    Eliminar";
            btnEliminar.TextAlignment = StringAlignment.Near;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Transparent;
            btnActualizar.BorderColor = Color.FromArgb(0, 51, 81);
            btnActualizar.Dock = DockStyle.Fill;
            btnActualizar.EnteredBorderColor = Color.FromArgb(0, 51, 81);
            btnActualizar.EnteredColor = Color.FromArgb(0, 51, 81);
            btnActualizar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = (Image)resources.GetObject("btnActualizar.Image");
            btnActualizar.ImageAlign = ContentAlignment.MiddleLeft;
            btnActualizar.InactiveColor = Color.FromArgb(0, 51, 81);
            btnActualizar.Location = new Point(1147, 3);
            btnActualizar.Margin = new Padding(4, 3, 4, 3);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.PressedBorderColor = Color.FromArgb(0, 51, 81);
            btnActualizar.PressedColor = Color.FromArgb(0, 51, 81);
            btnActualizar.Size = new Size(192, 51);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "    Actualizar";
            btnActualizar.TextAlignment = StringAlignment.Near;
            btnActualizar.Click += btnActualizar_Click;
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
            btnInsertar.Location = new Point(947, 3);
            btnInsertar.Margin = new Padding(4, 3, 4, 3);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.PressedBorderColor = Color.Black;
            btnInsertar.PressedColor = Color.Black;
            btnInsertar.Size = new Size(192, 51);
            btnInsertar.TabIndex = 17;
            btnInsertar.Text = "    Insertar";
            btnInsertar.TextAlignment = StringAlignment.Near;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.BackColor = Color.Transparent;
            lblClientes.Dock = DockStyle.Left;
            lblClientes.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.ForeColor = Color.Black;
            lblClientes.Location = new Point(0, 0);
            lblClientes.Margin = new Padding(0, 0, 4, 0);
            lblClientes.Name = "lblClientes";
            lblClientes.Padding = new Padding(19, 0, 0, 0);
            lblClientes.Size = new Size(341, 57);
            lblClientes.TabIndex = 16;
            lblClientes.Text = "Lista de clientes";
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
            tableLayoutPanel3.Location = new Point(4, 3);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
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
            tableLayoutPanel3.Size = new Size(281, 1056);
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
            btnLogout.Location = new Point(4, 992);
            btnLogout.Margin = new Padding(4, 3, 4, 3);
            btnLogout.Name = "btnLogout";
            btnLogout.PressedBorderColor = Color.Brown;
            btnLogout.PressedColor = Color.Brown;
            btnLogout.Size = new Size(273, 61);
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
            btnVendedores.Size = new Size(281, 69);
            btnVendedores.TabIndex = 10;
            btnVendedores.Text = "      Vendedores";
            btnVendedores.TextAlign = ContentAlignment.MiddleLeft;
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
            btnVentas.Size = new Size(281, 69);
            btnVentas.TabIndex = 9;
            btnVentas.Text = "      Ventas";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnClientes
            // 
            btnClientes.BackColor = SystemColors.Control;
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
            btnClientes.Size = new Size(281, 69);
            btnClientes.TabIndex = 8;
            btnClientes.Text = "      Clientes";
            btnClientes.TextAlign = ContentAlignment.MiddleLeft;
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
            btnProductos.Size = new Size(281, 69);
            btnProductos.TabIndex = 7;
            btnProductos.Text = "      Productos";
            btnProductos.TextAlign = ContentAlignment.MiddleLeft;
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
            btnDashboard.Size = new Size(281, 69);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "      Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
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
            lblSubtitulo.Size = new Size(273, 32);
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
            lblTitulo.Padding = new Padding(11, 12, 11, 12);
            lblTitulo.Size = new Size(273, 60);
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
            tableLayoutPanel4.Location = new Point(4, 913);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.Size = new Size(273, 73);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // imgUsuario
            // 
            imgUsuario.Anchor = AnchorStyles.Right;
            imgUsuario.BackgroundImage = (Image)resources.GetObject("imgUsuario.BackgroundImage");
            imgUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            imgUsuario.Location = new Point(8, 6);
            imgUsuario.Margin = new Padding(4, 3, 4, 3);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(69, 60);
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
            tableLayoutPanel5.Location = new Point(85, 3);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(184, 67);
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
            lblRol.Location = new Point(4, 33);
            lblRol.Margin = new Padding(4, 0, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(176, 32);
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
            lblNombre.Size = new Size(176, 32);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre**";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ClienteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 241, 251);
            ClientSize = new Size(1851, 1062);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ClienteForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel8.PerformLayout();
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
        private ReaLTaiizor.Controls.Panel panel3;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvClientes;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Button btnEliminar;
        private ReaLTaiizor.Controls.Button btnActualizar;
        private ReaLTaiizor.Controls.Button btnInsertar;
        private ReaLTaiizor.Controls.HeaderLabel lblClientes;
        private ReaLTaiizor.Controls.Button btnPdf;
        private ReaLTaiizor.Controls.Button btnExcel;
        private ReaLTaiizor.Controls.ParrotCard cardClientes;
        private ReaLTaiizor.Controls.LabelEdit lblEncabezado;
        private Button btnNotificacion;
        private ReaLTaiizor.Controls.Button btnLogout;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn correo;
    }
}