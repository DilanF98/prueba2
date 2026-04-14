namespace Presentacion
{
    partial class VendedorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendedorForm));
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
            btnActualizar = new ReaLTaiizor.Controls.Button();
            btnInsertar = new ReaLTaiizor.Controls.Button();
            lblVendedores = new ReaLTaiizor.Controls.HeaderLabel();
            panel3 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            btnPdf = new ReaLTaiizor.Controls.Button();
            btnExcel = new ReaLTaiizor.Controls.Button();
            dgvVendedores = new ReaLTaiizor.Controls.PoisonDataGridView();
            tableLayoutPanel7 = new TableLayoutPanel();
            cardStockTotal = new ReaLTaiizor.Controls.ParrotCard();
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
            Id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).BeginInit();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 202F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1296, 637);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(205, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1088, 633);
            panel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 0, 2);
            tableLayoutPanel2.Controls.Add(dgvVendedores, 0, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1088, 633);
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
            flowLayoutPanel1.Padding = new Padding(0, 0, 43, 0);
            flowLayoutPanel1.Size = new Size(1088, 38);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.FromArgb(103, 121, 141);
            lblEncabezado.Location = new Point(901, 7);
            lblEncabezado.Margin = new Padding(3, 7, 3, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Size = new Size(141, 21);
            lblEncabezado.TabIndex = 15;
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
            btnNotificacion.Location = new Point(855, 7);
            btnNotificacion.Margin = new Padding(0, 7, 0, 0);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(43, 21);
            btnNotificacion.TabIndex = 16;
            btnNotificacion.UseVisualStyleBackColor = false;
            btnNotificacion.Click += btnNotificacion_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 40);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1082, 34);
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
            tableLayoutPanel8.Controls.Add(lblVendedores, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(1082, 34);
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
            btnEliminar.Location = new Point(943, 2);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedBorderColor = Color.Brown;
            btnEliminar.PressedColor = Color.Brown;
            btnEliminar.Size = new Size(136, 30);
            btnEliminar.TabIndex = 20;
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
            btnActualizar.Location = new Point(803, 2);
            btnActualizar.Margin = new Padding(3, 2, 3, 2);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.PressedBorderColor = Color.FromArgb(0, 51, 81);
            btnActualizar.PressedColor = Color.FromArgb(0, 51, 81);
            btnActualizar.Size = new Size(134, 30);
            btnActualizar.TabIndex = 19;
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
            btnInsertar.Location = new Point(663, 2);
            btnInsertar.Margin = new Padding(3, 2, 3, 2);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.PressedBorderColor = Color.Black;
            btnInsertar.PressedColor = Color.Black;
            btnInsertar.Size = new Size(134, 30);
            btnInsertar.TabIndex = 18;
            btnInsertar.Text = "    Insertar";
            btnInsertar.TextAlignment = StringAlignment.Near;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // lblVendedores
            // 
            lblVendedores.AutoSize = true;
            lblVendedores.BackColor = Color.Transparent;
            lblVendedores.Dock = DockStyle.Left;
            lblVendedores.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVendedores.ForeColor = Color.Black;
            lblVendedores.Location = new Point(0, 0);
            lblVendedores.Margin = new Padding(0, 0, 3, 0);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Padding = new Padding(13, 0, 0, 0);
            lblVendedores.Size = new Size(287, 34);
            lblVendedores.TabIndex = 17;
            lblVendedores.Text = "Lista de Vendedores";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(tableLayoutPanel6);
            panel3.Dock = DockStyle.Fill;
            panel3.EdgeColor = SystemColors.Control;
            panel3.Location = new Point(18, 76);
            panel3.Margin = new Padding(18, 0, 18, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(4);
            panel3.Size = new Size(1052, 35);
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
            tableLayoutPanel6.Location = new Point(4, 4);
            tableLayoutPanel6.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(1044, 27);
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
            btnPdf.Location = new Point(107, 2);
            btnPdf.Margin = new Padding(3, 2, 3, 2);
            btnPdf.Name = "btnPdf";
            btnPdf.PressedBorderColor = Color.Brown;
            btnPdf.PressedColor = Color.Brown;
            btnPdf.Size = new Size(98, 23);
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
            btnExcel.Location = new Point(3, 2);
            btnExcel.Margin = new Padding(3, 2, 3, 2);
            btnExcel.Name = "btnExcel";
            btnExcel.PressedBorderColor = Color.ForestGreen;
            btnExcel.PressedColor = Color.ForestGreen;
            btnExcel.Size = new Size(98, 23);
            btnExcel.TabIndex = 16;
            btnExcel.Text = "Exportar";
            btnExcel.TextAlignment = StringAlignment.Near;
            // 
            // dgvVendedores
            // 
            dgvVendedores.AllowUserToAddRows = false;
            dgvVendedores.AllowUserToDeleteRows = false;
            dgvVendedores.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvVendedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVendedores.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvVendedores.BorderStyle = BorderStyle.None;
            dgvVendedores.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvVendedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvVendedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvVendedores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendedores.Columns.AddRange(new DataGridViewColumn[] { Id, nombre, Usuario, Rol });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvVendedores.DefaultCellStyle = dataGridViewCellStyle3;
            dgvVendedores.Dock = DockStyle.Fill;
            dgvVendedores.EnableHeadersVisualStyles = false;
            dgvVendedores.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvVendedores.GridColor = Color.FromArgb(255, 255, 255);
            dgvVendedores.Location = new Point(13, 122);
            dgvVendedores.Margin = new Padding(13, 11, 13, 11);
            dgvVendedores.Name = "dgvVendedores";
            dgvVendedores.ReadOnly = true;
            dgvVendedores.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvVendedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvVendedores.RowHeadersWidth = 51;
            dgvVendedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvVendedores.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvVendedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVendedores.Size = new Size(1062, 395);
            dgvVendedores.TabIndex = 6;
            dgvVendedores.CellContentClick += dgvVendedores_CellContentClick;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(cardStockTotal, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 530);
            tableLayoutPanel7.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(1082, 101);
            tableLayoutPanel7.TabIndex = 7;
            // 
            // cardStockTotal
            // 
            cardStockTotal.BackColor = Color.Transparent;
            cardStockTotal.Color1 = Color.LightGray;
            cardStockTotal.Color2 = Color.White;
            cardStockTotal.Dock = DockStyle.Fill;
            cardStockTotal.Font = new Font("Segoe UI Black", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cardStockTotal.ForeColor = Color.Black;
            cardStockTotal.Location = new Point(784, 11);
            cardStockTotal.Margin = new Padding(27, 11, 27, 11);
            cardStockTotal.Name = "cardStockTotal";
            cardStockTotal.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            cardStockTotal.Size = new Size(271, 79);
            cardStockTotal.TabIndex = 1;
            cardStockTotal.Text = "parrotCard2";
            cardStockTotal.Text1 = "Vendedores Activos";
            cardStockTotal.Text2 = "6 Vendedores";
            cardStockTotal.Text3 = "";
            cardStockTotal.TextRenderingType = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            tableLayoutPanel3.Location = new Point(3, 2);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
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
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel3.Size = new Size(196, 633);
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
            btnLogout.Location = new Point(3, 592);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.PressedBorderColor = Color.Brown;
            btnLogout.PressedColor = Color.Brown;
            btnLogout.Size = new Size(190, 39);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Cerrar Sesion";
            btnLogout.TextAlignment = StringAlignment.Center;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnVendedores
            // 
            btnVendedores.BackColor = SystemColors.Control;
            btnVendedores.Dock = DockStyle.Fill;
            btnVendedores.FlatAppearance.BorderSize = 0;
            btnVendedores.FlatStyle = FlatStyle.Flat;
            btnVendedores.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendedores.ForeColor = Color.FromArgb(0, 75, 115);
            btnVendedores.Image = (Image)resources.GetObject("btnVendedores.Image");
            btnVendedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnVendedores.Location = new Point(0, 234);
            btnVendedores.Margin = new Padding(0);
            btnVendedores.Name = "btnVendedores";
            btnVendedores.Size = new Size(196, 41);
            btnVendedores.TabIndex = 10;
            btnVendedores.Text = "Vendedores";
            btnVendedores.UseVisualStyleBackColor = false;
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
            btnVentas.Location = new Point(0, 193);
            btnVentas.Margin = new Padding(0);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(196, 41);
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
            btnClientes.Location = new Point(0, 152);
            btnClientes.Margin = new Padding(0);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(196, 41);
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
            btnProductos.Location = new Point(0, 111);
            btnProductos.Margin = new Padding(0);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(196, 41);
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
            btnDashboard.ForeColor = Color.FromArgb(0, 75, 115);
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(0, 70);
            btnDashboard.Margin = new Padding(0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(196, 41);
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
            lblSubtitulo.Location = new Point(3, 41);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(190, 21);
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
            lblTitulo.Location = new Point(3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(8, 7, 8, 7);
            lblTitulo.Size = new Size(190, 39);
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
            tableLayoutPanel4.Location = new Point(3, 545);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new Size(190, 43);
            tableLayoutPanel4.TabIndex = 11;
            // 
            // imgUsuario
            // 
            imgUsuario.Anchor = AnchorStyles.Right;
            imgUsuario.BackgroundImage = (Image)resources.GetObject("imgUsuario.BackgroundImage");
            imgUsuario.BackgroundImageLayout = ImageLayout.Stretch;
            imgUsuario.Location = new Point(6, 3);
            imgUsuario.Margin = new Padding(3, 2, 3, 2);
            imgUsuario.Name = "imgUsuario";
            imgUsuario.Size = new Size(48, 36);
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
            tableLayoutPanel5.Location = new Point(60, 2);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(127, 39);
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
            lblRol.Location = new Point(3, 19);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(121, 20);
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
            lblNombre.Location = new Point(3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(121, 19);
            lblNombre.TabIndex = 8;
            lblNombre.Text = "Nombre**";
            lblNombre.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdVendedor";
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
            // Usuario
            // 
            Usuario.DataPropertyName = "Usuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 6;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            // 
            // Rol
            // 
            Rol.DataPropertyName = "IdRolFk";
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            // 
            // VendedorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 241, 251);
            ClientSize = new Size(1296, 637);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "VendedorForm";
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
            ((System.ComponentModel.ISupportInitialize)dgvVendedores).EndInit();
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
        private ReaLTaiizor.Controls.Button btnActualizar;
        private ReaLTaiizor.Controls.Button btnInsertar;
        private ReaLTaiizor.Controls.HeaderLabel lblVendedores;
        private ReaLTaiizor.Controls.Panel panel3;
        private TableLayoutPanel tableLayoutPanel6;
        private ReaLTaiizor.Controls.Button btnPdf;
        private ReaLTaiizor.Controls.Button btnExcel;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvVendedores;
        private TableLayoutPanel tableLayoutPanel7;
        private ReaLTaiizor.Controls.ParrotCard cardStockTotal;
        private ReaLTaiizor.Controls.LabelEdit lblEncabezado;
        private Button btnNotificacion;
        private ReaLTaiizor.Controls.Button btnLogout;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Rol;
    }
}