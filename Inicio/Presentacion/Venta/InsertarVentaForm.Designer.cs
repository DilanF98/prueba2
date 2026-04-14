
using ReaLTaiizor.Controls;

namespace UI.Venta
{
    partial class InsertarVentaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsertarVentaForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pnlProducto = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnAgregar = new ReaLTaiizor.Controls.Button();
            cmbProducto = new ComboBox();
            lblProductoDetalle = new HeaderLabel();
            lblProducto = new HeaderLabel();
            tableLayoutPanel6 = new TableLayoutPanel();
            lblPrecio = new HeaderLabel();
            lblCantidad = new HeaderLabel();
            tableLayoutPanel7 = new TableLayoutPanel();
            txtPrecio = new CyberRichTextBox();
            txtCantidad = new CyberRichTextBox();
            pnlCliente = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            cmbCliente = new ComboBox();
            lblClienteDetalle = new HeaderLabel();
            lblCliente = new HeaderLabel();
            lblTitulo = new HeaderLabel();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblCarro = new HeaderLabel();
            dgvCarro = new PoisonDataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            tableLayoutPanel8 = new TableLayoutPanel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            btnLimpiar = new ReaLTaiizor.Controls.Button();
            btnComprar = new ReaLTaiizor.Controls.Button();
            pnlTotal = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblTotal = new HeaderLabel();
            lblTotalDetalle = new HeaderLabel();
            lblIva = new HeaderLabel();
            lbIvaDetalle = new HeaderLabel();
            lblSubtotal = new HeaderLabel();
            lblSubtotalDetalle = new HeaderLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            pnlProducto.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            pnlCliente.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarro).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            panel1.SuspendLayout();
            pnlTotal.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.Size = new Size(1479, 817);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(pnlProducto, 0, 2);
            tableLayoutPanel2.Controls.Add(pnlCliente, 0, 1);
            tableLayoutPanel2.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 3);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 62F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.1233253F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.9436989F));
            tableLayoutPanel2.Size = new Size(435, 811);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // pnlProducto
            // 
            pnlProducto.BackColor = Color.White;
            pnlProducto.Controls.Add(tableLayoutPanel5);
            pnlProducto.Dock = DockStyle.Fill;
            pnlProducto.EdgeColor = SystemColors.Control;
            pnlProducto.Location = new Point(26, 274);
            pnlProducto.Margin = new Padding(26, 25, 26, 25);
            pnlProducto.Name = "pnlProducto";
            pnlProducto.Padding = new Padding(6, 7, 6, 7);
            pnlProducto.Size = new Size(383, 310);
            pnlProducto.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlProducto.TabIndex = 20;
            pnlProducto.Text = "panel1";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(btnAgregar, 0, 5);
            tableLayoutPanel5.Controls.Add(cmbProducto, 0, 2);
            tableLayoutPanel5.Controls.Add(lblProductoDetalle, 0, 1);
            tableLayoutPanel5.Controls.Add(lblProducto, 0, 0);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel5.Controls.Add(tableLayoutPanel7, 0, 4);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(6, 7);
            tableLayoutPanel5.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 37.60684F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 24.7863255F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 37.60684F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel5.Size = new Size(371, 296);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.Transparent;
            btnAgregar.BorderColor = Color.FromArgb(0, 75, 115);
            btnAgregar.Dock = DockStyle.Fill;
            btnAgregar.EnteredBorderColor = Color.FromArgb(0, 75, 115);
            btnAgregar.EnteredColor = Color.FromArgb(0, 75, 115);
            btnAgregar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Image = null;
            btnAgregar.ImageAlign = ContentAlignment.MiddleRight;
            btnAgregar.InactiveColor = Color.FromArgb(0, 75, 115);
            btnAgregar.Location = new Point(0, 242);
            btnAgregar.Margin = new Padding(0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.PressedBorderColor = Color.FromArgb(0, 75, 115);
            btnAgregar.PressedColor = Color.FromArgb(0, 75, 115);
            btnAgregar.Size = new Size(371, 54);
            btnAgregar.TabIndex = 27;
            btnAgregar.Text = "Agregar al Carro";
            btnAgregar.TextAlignment = StringAlignment.Center;
            // 
            // cmbProducto
            // 
            cmbProducto.Dock = DockStyle.Fill;
            cmbProducto.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProducto.FormattingEnabled = true;
            cmbProducto.ItemHeight = 30;
            cmbProducto.Location = new Point(4, 78);
            cmbProducto.Margin = new Padding(4, 3, 4, 3);
            cmbProducto.MaxDropDownItems = 50;
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(363, 38);
            cmbProducto.TabIndex = 24;
            // 
            // lblProductoDetalle
            // 
            lblProductoDetalle.AutoSize = true;
            lblProductoDetalle.BackColor = Color.Transparent;
            lblProductoDetalle.Dock = DockStyle.Left;
            lblProductoDetalle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductoDetalle.ForeColor = Color.Gray;
            lblProductoDetalle.Location = new Point(0, 50);
            lblProductoDetalle.Margin = new Padding(0, 0, 4, 0);
            lblProductoDetalle.Name = "lblProductoDetalle";
            lblProductoDetalle.Padding = new Padding(19, 0, 0, 0);
            lblProductoDetalle.Size = new Size(272, 25);
            lblProductoDetalle.TabIndex = 20;
            lblProductoDetalle.Text = "Ingrese nombre de Producto";
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.BackColor = Color.Transparent;
            lblProducto.Dock = DockStyle.Left;
            lblProducto.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProducto.ForeColor = Color.Black;
            lblProducto.Image = (Image)resources.GetObject("lblProducto.Image");
            lblProducto.ImageAlign = ContentAlignment.MiddleLeft;
            lblProducto.Location = new Point(0, 0);
            lblProducto.Margin = new Padding(0, 0, 4, 0);
            lblProducto.Name = "lblProducto";
            lblProducto.Padding = new Padding(19, 0, 0, 0);
            lblProducto.Size = new Size(206, 50);
            lblProducto.TabIndex = 19;
            lblProducto.Text = "     Producto";
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(lblPrecio, 1, 0);
            tableLayoutPanel6.Controls.Add(lblCantidad, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(4, 141);
            tableLayoutPanel6.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(363, 35);
            tableLayoutPanel6.TabIndex = 25;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Dock = DockStyle.Left;
            lblPrecio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Gray;
            lblPrecio.Location = new Point(181, 0);
            lblPrecio.Margin = new Padding(0, 0, 4, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(143, 35);
            lblPrecio.TabIndex = 22;
            lblPrecio.Text = "Precio x Unidad";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Dock = DockStyle.Left;
            lblCantidad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.Gray;
            lblCantidad.Location = new Point(0, 0);
            lblCantidad.Margin = new Padding(0, 0, 4, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(153, 35);
            lblCantidad.TabIndex = 21;
            lblCantidad.Text = "Ingrese Cantidad";
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(txtPrecio, 1, 0);
            tableLayoutPanel7.Controls.Add(txtCantidad, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(4, 182);
            tableLayoutPanel7.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(363, 57);
            tableLayoutPanel7.TabIndex = 26;
            // 
            // txtPrecio
            // 
            txtPrecio.Alpha = 20;
            txtPrecio.BackColor = Color.Transparent;
            txtPrecio.Background_WidthPen = 3F;
            txtPrecio.BackgroundPen = true;
            txtPrecio.ColorBackground = Color.White;
            txtPrecio.ColorBackground_Pen = Color.Gray;
            txtPrecio.ColorLighting = Color.FromArgb(29, 200, 238);
            txtPrecio.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtPrecio.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtPrecio.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtPrecio.Dock = DockStyle.Fill;
            txtPrecio.Enabled = false;
            txtPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Lighting = false;
            txtPrecio.LinearGradientPen = false;
            txtPrecio.Location = new Point(185, 3);
            txtPrecio.Margin = new Padding(4, 3, 4, 3);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PenWidth = 15;
            txtPrecio.RGB = false;
            txtPrecio.Rounding = true;
            txtPrecio.RoundingInt = 20;
            txtPrecio.Size = new Size(174, 51);
            txtPrecio.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPrecio.TabIndex = 9;
            txtPrecio.Tag = "Cyber";
            txtPrecio.TextButton = "";
            txtPrecio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPrecio.Timer_RGB = 300;
            // 
            // txtCantidad
            // 
            txtCantidad.Alpha = 20;
            txtCantidad.BackColor = Color.Transparent;
            txtCantidad.Background_WidthPen = 3F;
            txtCantidad.BackgroundPen = true;
            txtCantidad.ColorBackground = Color.White;
            txtCantidad.ColorBackground_Pen = Color.Gray;
            txtCantidad.ColorLighting = Color.FromArgb(29, 200, 238);
            txtCantidad.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtCantidad.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtCantidad.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtCantidad.Dock = DockStyle.Fill;
            txtCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCantidad.ForeColor = Color.Black;
            txtCantidad.Lighting = false;
            txtCantidad.LinearGradientPen = false;
            txtCantidad.Location = new Point(4, 3);
            txtCantidad.Margin = new Padding(4, 3, 4, 3);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PenWidth = 15;
            txtCantidad.RGB = false;
            txtCantidad.Rounding = true;
            txtCantidad.RoundingInt = 20;
            txtCantidad.Size = new Size(173, 51);
            txtCantidad.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCantidad.TabIndex = 8;
            txtCantidad.Tag = "Cyber";
            txtCantidad.TextButton = "";
            txtCantidad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCantidad.Timer_RGB = 300;
            // 
            // pnlCliente
            // 
            pnlCliente.BackColor = Color.White;
            pnlCliente.Controls.Add(tableLayoutPanel4);
            pnlCliente.Dock = DockStyle.Fill;
            pnlCliente.EdgeColor = SystemColors.Control;
            pnlCliente.Location = new Point(26, 87);
            pnlCliente.Margin = new Padding(26, 25, 26, 25);
            pnlCliente.Name = "pnlCliente";
            pnlCliente.Padding = new Padding(6, 7, 6, 7);
            pnlCliente.Size = new Size(383, 137);
            pnlCliente.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlCliente.TabIndex = 19;
            pnlCliente.Text = "panel3";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(cmbCliente, 0, 2);
            tableLayoutPanel4.Controls.Add(lblClienteDetalle, 0, 1);
            tableLayoutPanel4.Controls.Add(lblCliente, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(6, 7);
            tableLayoutPanel4.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(371, 123);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // cmbCliente
            // 
            cmbCliente.Dock = DockStyle.Fill;
            cmbCliente.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCliente.FormattingEnabled = true;
            cmbCliente.ItemHeight = 30;
            cmbCliente.Items.AddRange(new object[] { "" });
            cmbCliente.Location = new Point(4, 78);
            cmbCliente.Margin = new Padding(4, 3, 4, 3);
            cmbCliente.MaxDropDownItems = 50;
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(363, 38);
            cmbCliente.TabIndex = 23;
            // 
            // lblClienteDetalle
            // 
            lblClienteDetalle.AutoSize = true;
            lblClienteDetalle.BackColor = Color.Transparent;
            lblClienteDetalle.Dock = DockStyle.Left;
            lblClienteDetalle.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteDetalle.ForeColor = Color.Gray;
            lblClienteDetalle.Location = new Point(0, 50);
            lblClienteDetalle.Margin = new Padding(0, 0, 4, 0);
            lblClienteDetalle.Name = "lblClienteDetalle";
            lblClienteDetalle.Padding = new Padding(19, 0, 0, 0);
            lblClienteDetalle.Size = new Size(254, 25);
            lblClienteDetalle.TabIndex = 20;
            lblClienteDetalle.Text = "Ingrese nombre de Cliente";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BackColor = Color.Transparent;
            lblCliente.Dock = DockStyle.Left;
            lblCliente.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCliente.ForeColor = Color.Black;
            lblCliente.Image = (Image)resources.GetObject("lblCliente.Image");
            lblCliente.ImageAlign = ContentAlignment.MiddleLeft;
            lblCliente.Location = new Point(0, 0);
            lblCliente.Margin = new Padding(0, 0, 4, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Padding = new Padding(19, 0, 0, 0);
            lblCliente.Size = new Size(168, 50);
            lblCliente.TabIndex = 19;
            lblCliente.Text = "    Cliente";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(0, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(19, 0, 0, 0);
            lblTitulo.Size = new Size(387, 62);
            lblTitulo.TabIndex = 18;
            lblTitulo.Text = "Transaccion Nueva Venta";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(lblCarro, 0, 0);
            tableLayoutPanel3.Controls.Add(dgvCarro, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(447, 3);
            tableLayoutPanel3.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 61.2850075F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 38.7149925F));
            tableLayoutPanel3.Size = new Size(1028, 811);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblCarro
            // 
            lblCarro.AutoSize = true;
            lblCarro.BackColor = Color.Transparent;
            lblCarro.Dock = DockStyle.Left;
            lblCarro.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCarro.ForeColor = Color.Black;
            lblCarro.Image = (Image)resources.GetObject("lblCarro.Image");
            lblCarro.ImageAlign = ContentAlignment.MiddleLeft;
            lblCarro.Location = new Point(0, 0);
            lblCarro.Margin = new Padding(0, 0, 4, 0);
            lblCarro.Name = "lblCarro";
            lblCarro.Padding = new Padding(19, 0, 0, 0);
            lblCarro.Size = new Size(332, 50);
            lblCarro.TabIndex = 20;
            lblCarro.Text = "      Carro de compras";
            // 
            // dgvCarro
            // 
            dgvCarro.AllowUserToAddRows = false;
            dgvCarro.AllowUserToDeleteRows = false;
            dgvCarro.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCarro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCarro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarro.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvCarro.BorderStyle = BorderStyle.None;
            dgvCarro.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvCarro.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCarro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCarro.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarro.Columns.AddRange(new DataGridViewColumn[] { Codigo, Nombre, Descripcion, Cantidad, Total });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCarro.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCarro.Dock = DockStyle.Fill;
            dgvCarro.EnableHeadersVisualStyles = false;
            dgvCarro.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvCarro.GridColor = Color.FromArgb(255, 255, 255);
            dgvCarro.Location = new Point(19, 68);
            dgvCarro.Margin = new Padding(19, 18, 19, 18);
            dgvCarro.Name = "dgvCarro";
            dgvCarro.ReadOnly = true;
            dgvCarro.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCarro.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCarro.RowHeadersWidth = 51;
            dgvCarro.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvCarro.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCarro.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarro.Size = new Size(990, 430);
            dgvCarro.TabIndex = 7;
            // 
            // Codigo
            // 
            Codigo.FillWeight = 50F;
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.FillWeight = 120F;
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            Descripcion.FillWeight = 150F;
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.FillWeight = 60F;
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            Total.FillWeight = 91.5775452F;
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(panel1, 1, 0);
            tableLayoutPanel8.Controls.Add(pnlTotal, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(4, 519);
            tableLayoutPanel8.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(1020, 289);
            tableLayoutPanel8.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnComprar);
            panel1.Dock = DockStyle.Top;
            panel1.EdgeColor = SystemColors.Control;
            panel1.Location = new Point(536, 25);
            panel1.Margin = new Padding(26, 25, 26, 25);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 7);
            panel1.Size = new Size(458, 70);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 21;
            panel1.Text = "panel3";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BorderColor = Color.Gray;
            btnLimpiar.Dock = DockStyle.Right;
            btnLimpiar.EnteredBorderColor = Color.Gray;
            btnLimpiar.EnteredColor = Color.Gray;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Image = null;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleRight;
            btnLimpiar.InactiveColor = Color.Gray;
            btnLimpiar.Location = new Point(238, 7);
            btnLimpiar.Margin = new Padding(0);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.PressedBorderColor = Color.Gray;
            btnLimpiar.PressedColor = Color.Gray;
            btnLimpiar.Size = new Size(214, 56);
            btnLimpiar.TabIndex = 29;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlignment = StringAlignment.Center;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.Transparent;
            btnComprar.BorderColor = Color.Green;
            btnComprar.Dock = DockStyle.Left;
            btnComprar.EnteredBorderColor = Color.Green;
            btnComprar.EnteredColor = Color.Green;
            btnComprar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Image = null;
            btnComprar.ImageAlign = ContentAlignment.MiddleRight;
            btnComprar.InactiveColor = Color.Green;
            btnComprar.Location = new Point(6, 7);
            btnComprar.Margin = new Padding(0);
            btnComprar.Name = "btnComprar";
            btnComprar.PressedBorderColor = Color.Green;
            btnComprar.PressedColor = Color.Green;
            btnComprar.Size = new Size(214, 56);
            btnComprar.TabIndex = 28;
            btnComprar.Text = "Finalizar Compra";
            btnComprar.TextAlignment = StringAlignment.Center;
            btnComprar.Click += btnComprar_Click;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.Controls.Add(tableLayoutPanel9);
            pnlTotal.Dock = DockStyle.Top;
            pnlTotal.EdgeColor = SystemColors.Control;
            pnlTotal.Location = new Point(26, 25);
            pnlTotal.Margin = new Padding(26, 25, 26, 25);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(6, 7, 6, 7);
            pnlTotal.Size = new Size(458, 165);
            pnlTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlTotal.TabIndex = 20;
            pnlTotal.Text = "panel3";
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel9.Controls.Add(lblTotal, 1, 2);
            tableLayoutPanel9.Controls.Add(lblTotalDetalle, 0, 2);
            tableLayoutPanel9.Controls.Add(lblIva, 1, 1);
            tableLayoutPanel9.Controls.Add(lbIvaDetalle, 0, 1);
            tableLayoutPanel9.Controls.Add(lblSubtotal, 1, 0);
            tableLayoutPanel9.Controls.Add(lblSubtotalDetalle, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(6, 7);
            tableLayoutPanel9.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(446, 151);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Dock = DockStyle.Left;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotal.Location = new Point(178, 103);
            lblTotal.Margin = new Padding(0, 3, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(19, 0, 0, 0);
            lblTotal.Size = new Size(138, 48);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "Sin datos";
            // 
            // lblTotalDetalle
            // 
            lblTotalDetalle.AutoSize = true;
            lblTotalDetalle.BackColor = Color.Transparent;
            lblTotalDetalle.Dock = DockStyle.Left;
            lblTotalDetalle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDetalle.ForeColor = Color.Black;
            lblTotalDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalDetalle.Location = new Point(0, 100);
            lblTotalDetalle.Margin = new Padding(0, 0, 4, 0);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Padding = new Padding(19, 0, 0, 0);
            lblTotalDetalle.Size = new Size(111, 51);
            lblTotalDetalle.TabIndex = 31;
            lblTotalDetalle.Text = "Total:";
            // 
            // lblIva
            // 
            lblIva.AutoSize = true;
            lblIva.BackColor = Color.Transparent;
            lblIva.Dock = DockStyle.Left;
            lblIva.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIva.ForeColor = Color.Black;
            lblIva.ImageAlign = ContentAlignment.MiddleLeft;
            lblIva.Location = new Point(178, 53);
            lblIva.Margin = new Padding(0, 3, 4, 0);
            lblIva.Name = "lblIva";
            lblIva.Padding = new Padding(19, 0, 0, 0);
            lblIva.Size = new Size(138, 47);
            lblIva.TabIndex = 30;
            lblIva.Text = "Sin datos";
            // 
            // lbIvaDetalle
            // 
            lbIvaDetalle.AutoSize = true;
            lbIvaDetalle.BackColor = Color.Transparent;
            lbIvaDetalle.Dock = DockStyle.Left;
            lbIvaDetalle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIvaDetalle.ForeColor = Color.Black;
            lbIvaDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            lbIvaDetalle.Location = new Point(0, 50);
            lbIvaDetalle.Margin = new Padding(0, 0, 4, 0);
            lbIvaDetalle.Name = "lbIvaDetalle";
            lbIvaDetalle.Padding = new Padding(19, 0, 0, 0);
            lbIvaDetalle.Size = new Size(90, 50);
            lbIvaDetalle.TabIndex = 29;
            lbIvaDetalle.Text = "IVA:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.BackColor = Color.Transparent;
            lblSubtotal.Dock = DockStyle.Left;
            lblSubtotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotal.ForeColor = Color.Black;
            lblSubtotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblSubtotal.Location = new Point(178, 3);
            lblSubtotal.Margin = new Padding(0, 3, 4, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Padding = new Padding(19, 0, 0, 0);
            lblSubtotal.Size = new Size(138, 47);
            lblSubtotal.TabIndex = 28;
            lblSubtotal.Text = "Sin datos";
            // 
            // lblSubtotalDetalle
            // 
            lblSubtotalDetalle.AutoSize = true;
            lblSubtotalDetalle.BackColor = Color.Transparent;
            lblSubtotalDetalle.Dock = DockStyle.Left;
            lblSubtotalDetalle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtotalDetalle.ForeColor = Color.Black;
            lblSubtotalDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            lblSubtotalDetalle.Location = new Point(0, 0);
            lblSubtotalDetalle.Margin = new Padding(0, 0, 4, 0);
            lblSubtotalDetalle.Name = "lblSubtotalDetalle";
            lblSubtotalDetalle.Padding = new Padding(19, 0, 0, 0);
            lblSubtotalDetalle.Size = new Size(163, 50);
            lblSubtotalDetalle.TabIndex = 27;
            lblSubtotalDetalle.Text = "SubTotal:";
            // 
            // InsertarVentaForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1479, 817);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InsertarVentaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            pnlProducto.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            pnlCliente.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarro).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.HeaderLabel lblTitulo;
        private ReaLTaiizor.Controls.Panel pnlCliente;
        private ReaLTaiizor.Controls.Panel pnlProducto;
        private TableLayoutPanel tableLayoutPanel4;
        private ReaLTaiizor.Controls.HeaderLabel lblClienteDetalle;
        private ReaLTaiizor.Controls.HeaderLabel lblCliente;
        private TableLayoutPanel tableLayoutPanel5;
        private HeaderLabel lblProductoDetalle;
        private ReaLTaiizor.Controls.HeaderLabel lblProducto;
        private ComboBox cmbProducto;
        private TableLayoutPanel tableLayoutPanel6;
        private ComboBox cmbCliente;
        private HeaderLabel lblCantidad;
        private HeaderLabel lblPrecio;
        private TableLayoutPanel tableLayoutPanel7;
        private CyberRichTextBox txtCantidad;
        private CyberRichTextBox txtPrecio;
        private ReaLTaiizor.Controls.Button btnAgregar;
        private PoisonDataGridView dgvCarro;
        private HeaderLabel lblCarro;
        private TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Panel pnlTotal;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button btnLimpiar;
        private ReaLTaiizor.Controls.Button btnComprar;
        private TableLayoutPanel tableLayoutPanel9;
        private HeaderLabel lblTotal;
        private HeaderLabel lblTotalDetalle;
        private HeaderLabel lblIva;
        private HeaderLabel lbIvaDetalle;
        private HeaderLabel lblSubtotal;
        private HeaderLabel lblSubtotalDetalle;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
    }
}