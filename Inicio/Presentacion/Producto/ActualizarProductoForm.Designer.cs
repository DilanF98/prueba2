using ReaLTaiizor.Controls;

namespace Presentacion
{
    partial class ActualizarProductoForm
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
            this.lblEncabezado = new HeaderLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtCantidad = new CyberRichTextBox();
            lblCantidad = new LabelEdit();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            btnActualizar = new ReaLTaiizor.Controls.Button();
            txtPrecio = new CyberRichTextBox();
            this.lblPrecio = new LabelEdit();
            txtDescripcion = new CyberRichTextBox();
            txtNombre = new CyberRichTextBox();
            this.lblDescripcion = new LabelEdit();
            this.lblNombre = new LabelEdit();
            this.lblCodigo = new LabelEdit();
            txtCodigo = new CyberRichTextBox();
            txtId = new CyberRichTextBox();
            this.lblId = new LabelEdit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(this.lblEncabezado, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(582, 532);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = AnchorStyles.None;
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = Color.Transparent;
            this.lblEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblEncabezado.ForeColor = Color.Black;
            this.lblEncabezado.Location = new Point(113, 2);
            this.lblEncabezado.Margin = new Padding(0, 0, 3, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Padding = new Padding(15, 0, 0, 0);
            this.lblEncabezado.Size = new Size(352, 46);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Actualizar producto";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1319427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8680573F));
            tableLayoutPanel2.Controls.Add(txtCantidad, 1, 6);
            tableLayoutPanel2.Controls.Add(lblCantidad, 1, 5);
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 7);
            tableLayoutPanel2.Controls.Add(btnActualizar, 0, 7);
            tableLayoutPanel2.Controls.Add(txtPrecio, 0, 6);
            tableLayoutPanel2.Controls.Add(this.lblPrecio, 0, 5);
            tableLayoutPanel2.Controls.Add(txtDescripcion, 1, 4);
            tableLayoutPanel2.Controls.Add(txtNombre, 0, 4);
            tableLayoutPanel2.Controls.Add(this.lblDescripcion, 1, 3);
            tableLayoutPanel2.Controls.Add(this.lblNombre, 0, 3);
            tableLayoutPanel2.Controls.Add(this.lblCodigo, 1, 1);
            tableLayoutPanel2.Controls.Add(txtCodigo, 1, 2);
            tableLayoutPanel2.Controls.Add(txtId, 0, 2);
            tableLayoutPanel2.Controls.Add(this.lblId, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel2.Size = new Size(576, 476);
            tableLayoutPanel2.TabIndex = 6;
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
            txtCantidad.Location = new Point(286, 320);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.PenWidth = 15;
            txtCantidad.RGB = false;
            txtCantidad.Rounding = true;
            txtCantidad.RoundingInt = 20;
            txtCantidad.Size = new Size(277, 55);
            txtCantidad.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCantidad.TabIndex = 27;
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
            lblCantidad.Location = new Point(286, 285);
            lblCantidad.Margin = new Padding(3, 20, 3, 0);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(287, 32);
            lblCantidad.TabIndex = 26;
            lblCantidad.Text = "Cantidad";
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
            btnRegresar.Location = new Point(328, 411);
            btnRegresar.Margin = new Padding(45, 30, 45, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.PressedBorderColor = Color.Gray;
            btnRegresar.PressedColor = Color.Gray;
            btnRegresar.Size = new Size(203, 35);
            btnRegresar.TabIndex = 23;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlignment = StringAlignment.Center;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Transparent;
            btnActualizar.BorderColor = Color.ForestGreen;
            btnActualizar.Dock = DockStyle.Fill;
            btnActualizar.EnteredBorderColor = Color.ForestGreen;
            btnActualizar.EnteredColor = Color.ForestGreen;
            btnActualizar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Image = null;
            btnActualizar.ImageAlign = ContentAlignment.MiddleRight;
            btnActualizar.InactiveColor = Color.ForestGreen;
            btnActualizar.Location = new Point(45, 411);
            btnActualizar.Margin = new Padding(45, 30, 45, 30);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.PressedBorderColor = Color.ForestGreen;
            btnActualizar.PressedColor = Color.ForestGreen;
            btnActualizar.Size = new Size(193, 35);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = StringAlignment.Center;
            btnActualizar.Click += btnActualizar_Click;
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
            txtPrecio.Location = new Point(3, 320);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.PenWidth = 15;
            txtPrecio.RGB = false;
            txtPrecio.Rounding = true;
            txtPrecio.RoundingInt = 20;
            txtPrecio.Size = new Size(277, 55);
            txtPrecio.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtPrecio.TabIndex = 20;
            txtPrecio.Tag = "Cyber";
            txtPrecio.TextButton = "";
            txtPrecio.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtPrecio.Timer_RGB = 300;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = Color.Transparent;
            this.lblPrecio.Dock = DockStyle.Fill;
            this.lblPrecio.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblPrecio.ForeColor = Color.Gray;
            this.lblPrecio.Location = new Point(3, 285);
            this.lblPrecio.Margin = new Padding(3, 20, 3, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new Size(277, 32);
            this.lblPrecio.TabIndex = 18;
            this.lblPrecio.Text = "Precio";
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
            txtDescripcion.Location = new Point(286, 200);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PenWidth = 15;
            txtDescripcion.RGB = false;
            txtDescripcion.Rounding = true;
            txtDescripcion.RoundingInt = 20;
            txtDescripcion.Size = new Size(277, 55);
            txtDescripcion.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtDescripcion.TabIndex = 17;
            txtDescripcion.Tag = "Cyber";
            txtDescripcion.TextButton = "";
            txtDescripcion.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtDescripcion.Timer_RGB = 300;
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
            txtNombre.Location = new Point(3, 200);
            txtNombre.Name = "txtNombre";
            txtNombre.PenWidth = 15;
            txtNombre.RGB = false;
            txtNombre.Rounding = true;
            txtNombre.RoundingInt = 20;
            txtNombre.Size = new Size(277, 55);
            txtNombre.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNombre.TabIndex = 16;
            txtNombre.Tag = "Cyber";
            txtNombre.TextButton = "";
            txtNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNombre.Timer_RGB = 300;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = Color.Transparent;
            this.lblDescripcion.Dock = DockStyle.Fill;
            this.lblDescripcion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblDescripcion.ForeColor = Color.Gray;
            this.lblDescripcion.Location = new Point(286, 164);
            this.lblDescripcion.Margin = new Padding(3, 20, 3, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new Size(287, 33);
            this.lblDescripcion.TabIndex = 15;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = Color.Transparent;
            this.lblNombre.Dock = DockStyle.Fill;
            this.lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNombre.ForeColor = Color.Gray;
            this.lblNombre.Location = new Point(3, 164);
            this.lblNombre.Margin = new Padding(3, 20, 3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(277, 33);
            this.lblNombre.TabIndex = 14;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = Color.Transparent;
            this.lblCodigo.Dock = DockStyle.Fill;
            this.lblCodigo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCodigo.ForeColor = Color.Gray;
            this.lblCodigo.Location = new Point(286, 45);
            this.lblCodigo.Margin = new Padding(3, 20, 3, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new Size(287, 33);
            this.lblCodigo.TabIndex = 11;
            this.lblCodigo.Text = "Codigo";
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
            txtCodigo.Location = new Point(286, 81);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PenWidth = 15;
            txtCodigo.RGB = false;
            txtCodigo.Rounding = true;
            txtCodigo.RoundingInt = 20;
            txtCodigo.Size = new Size(278, 55);
            txtCodigo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCodigo.TabIndex = 8;
            txtCodigo.Tag = "Cyber";
            txtCodigo.TextButton = "";
            txtCodigo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCodigo.Timer_RGB = 300;
            // 
            // txtId
            // 
            txtId.Alpha = 20;
            txtId.BackColor = Color.Transparent;
            txtId.Background_WidthPen = 3F;
            txtId.BackgroundPen = true;
            txtId.ColorBackground = Color.White;
            txtId.ColorBackground_Pen = Color.Gray;
            txtId.ColorLighting = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtId.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtId.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtId.ForeColor = Color.Black;
            txtId.Lighting = false;
            txtId.LinearGradientPen = false;
            txtId.Location = new Point(3, 81);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 20;
            txtId.Size = new Size(277, 55);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 7;
            txtId.Tag = "Cyber";
            txtId.TextButton = "";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = Color.Transparent;
            this.lblId.Dock = DockStyle.Fill;
            this.lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblId.ForeColor = Color.Gray;
            this.lblId.Location = new Point(3, 45);
            this.lblId.Margin = new Padding(3, 20, 3, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new Size(277, 33);
            this.lblId.TabIndex = 5;
            this.lblId.Text = "Id";
            // 
            // ActualizarProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 532);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "ActualizarProductoForm";
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
        private ReaLTaiizor.Controls.Button btnRegresar;
        private ReaLTaiizor.Controls.Button btnActualizar;
        private ReaLTaiizor.Controls.CyberRichTextBox txtPrecio;
        private LabelEdit lblPrecio;
        private ReaLTaiizor.Controls.CyberRichTextBox txtDescripcion;
        private LabelEdit lblCodigo;
        private CyberRichTextBox txtCodigo;
        private ReaLTaiizor.Controls.CyberRichTextBox txtNombre;
        private LabelEdit lblDescripcion;
        private LabelEdit lblNombre;
        private ReaLTaiizor.Controls.CyberRichTextBox txtId;
        private LabelEdit lblId;
        private ReaLTaiizor.Controls.CyberRichTextBox txtCantidad;
        private ReaLTaiizor.Controls.LabelEdit lblCantidad;

    }
}