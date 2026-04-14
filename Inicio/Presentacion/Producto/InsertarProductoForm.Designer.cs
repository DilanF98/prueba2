
using ReaLTaiizor.Controls;

namespace Presentacion
{
    partial class InsertarProductoForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblEncabezado = new HeaderLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            btnGuardar = new ReaLTaiizor.Controls.Button();
            txtCantidad = new CyberRichTextBox();
            lblCantidad = new LabelEdit();
            txtPrecio = new CyberRichTextBox();
            txtDescripcion = new CyberRichTextBox();
            lblPrecio = new LabelEdit();
            lblDescripcion = new LabelEdit();
            lblNombre = new LabelEdit();
            txtNombre = new CyberRichTextBox();
            txtCodigo = new CyberRichTextBox();
            lblCodigo = new LabelEdit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Controls.Add(lblEncabezado, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(509, 399);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.None;
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.Black;
            lblEncabezado.Location = new Point(101, 0);
            lblEncabezado.Margin = new Padding(0, 0, 3, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Padding = new Padding(13, 0, 0, 0);
            lblEncabezado.Size = new Size(303, 37);
            lblEncabezado.TabIndex = 5;
            lblEncabezado.Text = "Registro de producto";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1319427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8680573F));
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 7);
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 7);
            tableLayoutPanel2.Controls.Add(txtCantidad, 0, 6);
            tableLayoutPanel2.Controls.Add(lblCantidad, 0, 5);
            tableLayoutPanel2.Controls.Add(txtPrecio, 1, 4);
            tableLayoutPanel2.Controls.Add(txtDescripcion, 0, 4);
            tableLayoutPanel2.Controls.Add(lblPrecio, 1, 3);
            tableLayoutPanel2.Controls.Add(lblDescripcion, 0, 3);
            tableLayoutPanel2.Controls.Add(lblNombre, 1, 1);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 2);
            tableLayoutPanel2.Controls.Add(txtCodigo, 0, 2);
            tableLayoutPanel2.Controls.Add(lblCodigo, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 40);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 11F));
            tableLayoutPanel2.Size = new Size(503, 357);
            tableLayoutPanel2.TabIndex = 6;
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
            btnRegresar.Location = new Point(286, 309);
            btnRegresar.Margin = new Padding(39, 22, 39, 22);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.PressedBorderColor = Color.Gray;
            btnRegresar.PressedColor = Color.Gray;
            btnRegresar.Size = new Size(178, 26);
            btnRegresar.TabIndex = 23;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlignment = StringAlignment.Center;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.BorderColor = Color.ForestGreen;
            btnGuardar.Dock = DockStyle.Fill;
            btnGuardar.EnteredBorderColor = Color.ForestGreen;
            btnGuardar.EnteredColor = Color.ForestGreen;
            btnGuardar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Image = null;
            btnGuardar.ImageAlign = ContentAlignment.MiddleRight;
            btnGuardar.InactiveColor = Color.ForestGreen;
            btnGuardar.Location = new Point(39, 309);
            btnGuardar.Margin = new Padding(39, 22, 39, 22);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedBorderColor = Color.ForestGreen;
            btnGuardar.PressedColor = Color.ForestGreen;
            btnGuardar.Size = new Size(169, 26);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.Click += btnGuardar_Click;
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
            txtCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCantidad.ForeColor = Color.Black;
            txtCantidad.Lighting = false;
            txtCantidad.LinearGradientPen = false;
            txtCantidad.Location = new Point(3, 241);
            txtCantidad.Margin = new Padding(3, 2, 3, 2);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PenWidth = 15;
            txtCantidad.RGB = false;
            txtCantidad.Rounding = true;
            txtCantidad.RoundingInt = 20;
            txtCantidad.Size = new Size(241, 41);
            txtCantidad.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCantidad.TabIndex = 20;
            txtCantidad.Tag = "Cyber";
            txtCantidad.TextButton = "";
            txtCantidad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCantidad.Timer_RGB = 300;
            
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.BackColor = Color.Transparent;
            lblCantidad.Dock = DockStyle.Fill;
            lblCantidad.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.ForeColor = Color.Gray;
            lblCantidad.Location = new Point(3, 215);
            lblCantidad.Margin = new Padding(3, 15, 3, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(241, 24);
            lblCantidad.TabIndex = 18;
            lblCantidad.Text = "Cantidad";
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
            txtPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtPrecio.ForeColor = Color.Black;
            txtPrecio.Lighting = false;
            txtPrecio.LinearGradientPen = false;
            txtPrecio.Location = new Point(250, 151);
            txtPrecio.Margin = new Padding(3, 2, 3, 2);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PenWidth = 15;
            txtPrecio.RGB = false;
            txtPrecio.Rounding = true;
            txtPrecio.RoundingInt = 20;
            txtPrecio.Size = new Size(242, 41);
            txtPrecio.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPrecio.TabIndex = 17;
            txtPrecio.Tag = "Cyber";
            txtPrecio.TextButton = "";
            txtPrecio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPrecio.Timer_RGB = 300;
            txtPrecio.Load += txtPrecio_Load;
            
            // 
            // txtDescripcion
            // 
            txtDescripcion.Alpha = 20;
            txtDescripcion.BackColor = Color.Transparent;
            txtDescripcion.Background_WidthPen = 3F;
            txtDescripcion.BackgroundPen = true;
            txtDescripcion.ColorBackground = Color.White;
            txtDescripcion.ColorBackground_Pen = Color.Gray;
            txtDescripcion.ColorLighting = Color.FromArgb(29, 200, 238);
            txtDescripcion.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtDescripcion.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtDescripcion.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtDescripcion.ForeColor = Color.Black;
            txtDescripcion.Lighting = false;
            txtDescripcion.LinearGradientPen = false;
            txtDescripcion.Location = new Point(3, 151);
            txtDescripcion.Margin = new Padding(3, 2, 3, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PenWidth = 15;
            txtDescripcion.RGB = false;
            txtDescripcion.Rounding = true;
            txtDescripcion.RoundingInt = 20;
            txtDescripcion.Size = new Size(241, 41);
            txtDescripcion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtDescripcion.TabIndex = 16;
            txtDescripcion.Tag = "Cyber";
            txtDescripcion.TextButton = "";
            txtDescripcion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtDescripcion.Timer_RGB = 300;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Dock = DockStyle.Fill;
            lblPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.ForeColor = Color.Gray;
            lblPrecio.Location = new Point(250, 124);
            lblPrecio.Margin = new Padding(3, 15, 3, 0);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(250, 25);
            lblPrecio.TabIndex = 15;
            lblPrecio.Text = "Precio";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Dock = DockStyle.Fill;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = Color.Gray;
            lblDescripcion.Location = new Point(3, 124);
            lblDescripcion.Margin = new Padding(3, 15, 3, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(241, 25);
            lblDescripcion.TabIndex = 14;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Gray;
            lblNombre.Location = new Point(250, 34);
            lblNombre.Margin = new Padding(3, 15, 3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(250, 25);
            lblNombre.TabIndex = 11;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Alpha = 20;
            txtNombre.BackColor = Color.Transparent;
            txtNombre.Background_WidthPen = 3F;
            txtNombre.BackgroundPen = true;
            txtNombre.ColorBackground = Color.White;
            txtNombre.ColorBackground_Pen = Color.Gray;
            txtNombre.ColorLighting = Color.FromArgb(29, 200, 238);
            txtNombre.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtNombre.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtNombre.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Lighting = false;
            txtNombre.LinearGradientPen = false;
            txtNombre.Location = new Point(250, 61);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.PenWidth = 15;
            txtNombre.RGB = false;
            txtNombre.Rounding = true;
            txtNombre.RoundingInt = 20;
            txtNombre.Size = new Size(243, 41);
            txtNombre.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNombre.TabIndex = 8;
            txtNombre.Tag = "Cyber";
            txtNombre.TextButton = "";
            txtNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNombre.Timer_RGB = 300;
            // 
            // txtCodigo
            // 
            txtCodigo.Alpha = 20;
            txtCodigo.BackColor = Color.Transparent;
            txtCodigo.Background_WidthPen = 3F;
            txtCodigo.BackgroundPen = true;
            txtCodigo.ColorBackground = Color.White;
            txtCodigo.ColorBackground_Pen = Color.Gray;
            txtCodigo.ColorLighting = Color.FromArgb(29, 200, 238);
            txtCodigo.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtCodigo.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtCodigo.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCodigo.ForeColor = Color.Black;
            txtCodigo.Lighting = false;
            txtCodigo.LinearGradientPen = false;
            txtCodigo.Location = new Point(3, 61);
            txtCodigo.Margin = new Padding(3, 2, 3, 2);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PenWidth = 15;
            txtCodigo.RGB = false;
            txtCodigo.Rounding = true;
            txtCodigo.RoundingInt = 20;
            txtCodigo.Size = new Size(241, 41);
            txtCodigo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCodigo.TabIndex = 7;
            txtCodigo.Tag = "Cyber";
            txtCodigo.TextButton = "";
            txtCodigo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCodigo.Timer_RGB = 300;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.BackColor = Color.Transparent;
            lblCodigo.Dock = DockStyle.Fill;
            lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.ForeColor = Color.Gray;
            lblCodigo.Location = new Point(3, 34);
            lblCodigo.Margin = new Padding(3, 15, 3, 0);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(241, 25);
            lblCodigo.TabIndex = 5;
            lblCodigo.Text = "Codigo";
            // 
            // InsertarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 399);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "InsertarProductoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private HeaderLabel lblEncabezado;
        private TableLayoutPanel tableLayoutPanel2;
        private CyberRichTextBox txtNombre;
        private CyberRichTextBox txtCodigo;
        private ReaLTaiizor.Controls.LabelEdit lblCodigo;
        private ReaLTaiizor.Controls.LabelEdit lblCantidad;
        private CyberRichTextBox txtPrecio;
        private ReaLTaiizor.Controls.CyberRichTextBox txtDescripcion;
        private LabelEdit lblPrecio;
        private LabelEdit lblDescripcion;
        private LabelEdit lblNombre;
        private ReaLTaiizor.Controls.Button btnGuardar;
        private CyberRichTextBox txtCantidad;
        private ReaLTaiizor.Controls.Button btnRegresar;
    }
}