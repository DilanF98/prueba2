namespace UI.Venta
{
    partial class DetalleVentaForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlTotal = new ReaLTaiizor.Controls.Panel();
            lblIdVenta = new ReaLTaiizor.Controls.HeaderLabel();
            lblId = new ReaLTaiizor.Controls.HeaderLabel();
            lblTitulo = new ReaLTaiizor.Controls.HeaderLabel();
            dgvDetalle = new ReaLTaiizor.Controls.PoisonDataGridView();
            Vendedor = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            SubTotal = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new ReaLTaiizor.Controls.Panel();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            panel1 = new ReaLTaiizor.Controls.Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            lblTotal = new ReaLTaiizor.Controls.HeaderLabel();
            lblTotalDetalle = new ReaLTaiizor.Controls.HeaderLabel();
            lblIva = new ReaLTaiizor.Controls.HeaderLabel();
            lbIvaDetalle = new ReaLTaiizor.Controls.HeaderLabel();
            lblSubtotal = new ReaLTaiizor.Controls.HeaderLabel();
            lblSubtotalDetalle = new ReaLTaiizor.Controls.HeaderLabel();
            tableLayoutPanel1.SuspendLayout();
            pnlTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(pnlTotal, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvDetalle, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1035, 490);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pnlTotal
            // 
            pnlTotal.BackColor = Color.White;
            pnlTotal.Controls.Add(lblIdVenta);
            pnlTotal.Controls.Add(lblId);
            pnlTotal.Controls.Add(lblTitulo);
            pnlTotal.Dock = DockStyle.Top;
            pnlTotal.EdgeColor = SystemColors.Control;
            pnlTotal.Location = new Point(6, 3);
            pnlTotal.Margin = new Padding(6, 3, 6, 3);
            pnlTotal.Name = "pnlTotal";
            pnlTotal.Padding = new Padding(4);
            pnlTotal.Size = new Size(1023, 31);
            pnlTotal.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pnlTotal.TabIndex = 21;
            pnlTotal.Text = "panel3";
            // 
            // lblIdVenta
            // 
            lblIdVenta.AutoSize = true;
            lblIdVenta.BackColor = Color.Transparent;
            lblIdVenta.Dock = DockStyle.Right;
            lblIdVenta.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIdVenta.ForeColor = Color.Black;
            lblIdVenta.Location = new Point(834, 4);
            lblIdVenta.Margin = new Padding(0, 0, 3, 0);
            lblIdVenta.Name = "lblIdVenta";
            lblIdVenta.Padding = new Padding(13, 0, 0, 0);
            lblIdVenta.Size = new Size(136, 28);
            lblIdVenta.TabIndex = 21;
            lblIdVenta.Text = "Id de venta:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Dock = DockStyle.Right;
            lblId.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Black;
            lblId.Location = new Point(970, 4);
            lblId.Margin = new Padding(0, 0, 3, 0);
            lblId.Name = "lblId";
            lblId.Padding = new Padding(13, 0, 0, 0);
            lblId.Size = new Size(49, 28);
            lblId.TabIndex = 20;
            lblId.Text = "27";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Dock = DockStyle.Left;
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(4, 4);
            lblTitulo.Margin = new Padding(0, 0, 3, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(13, 0, 0, 0);
            lblTitulo.Size = new Size(181, 28);
            lblTitulo.TabIndex = 19;
            lblTitulo.Text = "Detalle de venta";
            // 
            // dgvDetalle
            // 
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.AllowUserToDeleteRows = false;
            dgvDetalle.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetalle.BackgroundColor = Color.FromArgb(255, 255, 255);
            dgvDetalle.BorderStyle = BorderStyle.None;
            dgvDetalle.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgvDetalle.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Gray;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Columns.AddRange(new DataGridViewColumn[] { Vendedor, Cliente, Fecha, Nombre, Cantidad, Precio, SubTotal });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalle.Dock = DockStyle.Fill;
            dgvDetalle.EnableHeadersVisualStyles = false;
            dgvDetalle.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dgvDetalle.GridColor = Color.FromArgb(255, 255, 255);
            dgvDetalle.Location = new Point(13, 48);
            dgvDetalle.Margin = new Padding(13, 11, 13, 11);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Gainsboro;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.Gainsboro;
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvDetalle.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dgvDetalle.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.Size = new Size(1009, 340);
            dgvDetalle.TabIndex = 9;
            // 
            // Vendedor
            // 
            Vendedor.HeaderText = "Vendedor";
            Vendedor.MinimumWidth = 6;
            Vendedor.Name = "Vendedor";
            Vendedor.ReadOnly = true;
            // 
            // Cliente
            // 
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre de Producto";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio x Unidad";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // SubTotal
            // 
            SubTotal.HeaderText = "SubTotal";
            SubTotal.MinimumWidth = 6;
            SubTotal.Name = "SubTotal";
            SubTotal.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 1, 0);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 401);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1029, 87);
            tableLayoutPanel2.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnRegresar);
            panel2.Dock = DockStyle.Fill;
            panel2.EdgeColor = SystemColors.Control;
            panel2.Location = new Point(689, 23);
            panel2.Margin = new Padding(175, 23, 175, 23);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(4);
            panel2.Size = new Size(165, 41);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 23;
            panel2.Text = "panel3";
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.BorderColor = Color.Gray;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.EnteredBorderColor = Color.Gray;
            btnRegresar.EnteredColor = Color.Gray;
            btnRegresar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegresar.Image = null;
            btnRegresar.ImageAlign = ContentAlignment.MiddleRight;
            btnRegresar.InactiveColor = Color.Gray;
            btnRegresar.Location = new Point(4, 4);
            btnRegresar.Margin = new Padding(0);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.PressedBorderColor = Color.Gray;
            btnRegresar.PressedColor = Color.Gray;
            btnRegresar.Size = new Size(157, 33);
            btnRegresar.TabIndex = 30;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlignment = StringAlignment.Center;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel9);
            panel1.Dock = DockStyle.Fill;
            panel1.EdgeColor = SystemColors.Control;
            panel1.Location = new Point(6, 3);
            panel1.Margin = new Padding(6, 3, 6, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(4);
            panel1.Size = new Size(502, 81);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 22;
            panel1.Text = "panel3";
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
            tableLayoutPanel9.Location = new Point(4, 4);
            tableLayoutPanel9.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 3;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel9.Size = new Size(494, 73);
            tableLayoutPanel9.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BackColor = Color.Transparent;
            lblTotal.Dock = DockStyle.Left;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.Black;
            lblTotal.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotal.Location = new Point(197, 50);
            lblTotal.Margin = new Padding(0, 2, 3, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Padding = new Padding(13, 0, 0, 0);
            lblTotal.Size = new Size(124, 23);
            lblTotal.TabIndex = 32;
            lblTotal.Text = "1500 Colones";
            // 
            // lblTotalDetalle
            // 
            lblTotalDetalle.AutoSize = true;
            lblTotalDetalle.BackColor = Color.Transparent;
            lblTotalDetalle.Dock = DockStyle.Left;
            lblTotalDetalle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalDetalle.ForeColor = Color.Black;
            lblTotalDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            lblTotalDetalle.Location = new Point(0, 48);
            lblTotalDetalle.Margin = new Padding(0, 0, 3, 0);
            lblTotalDetalle.Name = "lblTotalDetalle";
            lblTotalDetalle.Padding = new Padding(13, 0, 0, 0);
            lblTotalDetalle.Size = new Size(73, 25);
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
            lblIva.Location = new Point(197, 26);
            lblIva.Margin = new Padding(0, 2, 3, 0);
            lblIva.Name = "lblIva";
            lblIva.Padding = new Padding(13, 0, 0, 0);
            lblIva.Size = new Size(115, 22);
            lblIva.TabIndex = 30;
            lblIva.Text = "500 Colones";
            // 
            // lbIvaDetalle
            // 
            lbIvaDetalle.AutoSize = true;
            lbIvaDetalle.BackColor = Color.Transparent;
            lbIvaDetalle.Dock = DockStyle.Left;
            lbIvaDetalle.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbIvaDetalle.ForeColor = Color.Black;
            lbIvaDetalle.ImageAlign = ContentAlignment.MiddleLeft;
            lbIvaDetalle.Location = new Point(0, 24);
            lbIvaDetalle.Margin = new Padding(0, 0, 3, 0);
            lbIvaDetalle.Name = "lbIvaDetalle";
            lbIvaDetalle.Padding = new Padding(13, 0, 0, 0);
            lbIvaDetalle.Size = new Size(61, 24);
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
            lblSubtotal.Location = new Point(197, 2);
            lblSubtotal.Margin = new Padding(0, 2, 3, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Padding = new Padding(13, 0, 0, 0);
            lblSubtotal.Size = new Size(124, 22);
            lblSubtotal.TabIndex = 28;
            lblSubtotal.Text = "1000 Colones";
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
            lblSubtotalDetalle.Margin = new Padding(0, 0, 3, 0);
            lblSubtotalDetalle.Name = "lblSubtotalDetalle";
            lblSubtotalDetalle.Padding = new Padding(13, 0, 0, 0);
            lblSubtotalDetalle.Size = new Size(108, 24);
            lblSubtotalDetalle.TabIndex = 27;
            lblSubtotalDetalle.Text = "SubTotal:";
            // 
            // DetalleVentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 490);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DetalleVentaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            pnlTotal.ResumeLayout(false);
            pnlTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            tableLayoutPanel9.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.PoisonDataGridView dgvDetalle;
        private DataGridViewTextBoxColumn Vendedor;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn SubTotal;
        private ReaLTaiizor.Controls.Panel pnlTotal;
        private ReaLTaiizor.Controls.HeaderLabel lblTitulo;
        private ReaLTaiizor.Controls.HeaderLabel lblIdVenta;
        private ReaLTaiizor.Controls.HeaderLabel lblId;
        private TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.Panel panel2;
        private ReaLTaiizor.Controls.Panel panel1;
        private TableLayoutPanel tableLayoutPanel9;
        private ReaLTaiizor.Controls.HeaderLabel lblTotal;
        private ReaLTaiizor.Controls.HeaderLabel lblTotalDetalle;
        private ReaLTaiizor.Controls.HeaderLabel lblIva;
        private ReaLTaiizor.Controls.HeaderLabel lbIvaDetalle;
        private ReaLTaiizor.Controls.HeaderLabel lblSubtotal;
        private ReaLTaiizor.Controls.HeaderLabel lblSubtotalDetalle;
        private ReaLTaiizor.Controls.Button btnRegresar;
    }
}