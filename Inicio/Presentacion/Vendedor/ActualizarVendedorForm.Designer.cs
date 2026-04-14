using ReaLTaiizor.Controls;

namespace UI.Vendedor
{
    partial class ActualizarVendedorForm
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
            txtId = new CyberRichTextBox();
            lblId = new LabelEdit();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            btnGuardar = new ReaLTaiizor.Controls.Button();
            txtContrasenna = new CyberRichTextBox();
            lblRol = new LabelEdit();
            lblContrasenna = new LabelEdit();
            lblUsuario = new LabelEdit();
            txtUsuario = new CyberRichTextBox();
            txtNombre = new CyberRichTextBox();
            lblNombre = new LabelEdit();
            cmbRol = new CyberComboBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 26F));
            tableLayoutPanel1.Controls.Add(lblEncabezado, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(727, 628);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblEncabezado
            // 
            lblEncabezado.Anchor = AnchorStyles.None;
            lblEncabezado.AutoSize = true;
            lblEncabezado.BackColor = Color.Transparent;
            lblEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEncabezado.ForeColor = Color.Black;
            lblEncabezado.Location = new Point(121, 4);
            lblEncabezado.Margin = new Padding(0, 0, 4, 0);
            lblEncabezado.Name = "lblEncabezado";
            lblEncabezado.Padding = new Padding(19, 0, 0, 0);
            lblEncabezado.Size = new Size(481, 54);
            lblEncabezado.TabIndex = 5;
            lblEncabezado.Text = "Actualizar de Vendedor";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.13194F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8680573F));
            tableLayoutPanel2.Controls.Add(txtId, 0, 1);
            tableLayoutPanel2.Controls.Add(lblId, 0, 0);
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 6);
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 6);
            tableLayoutPanel2.Controls.Add(txtContrasenna, 0, 5);
            tableLayoutPanel2.Controls.Add(lblRol, 1, 4);
            tableLayoutPanel2.Controls.Add(lblContrasenna, 0, 4);
            tableLayoutPanel2.Controls.Add(lblUsuario, 1, 2);
            tableLayoutPanel2.Controls.Add(txtUsuario, 1, 3);
            tableLayoutPanel2.Controls.Add(txtNombre, 0, 3);
            tableLayoutPanel2.Controls.Add(lblNombre, 0, 2);
            tableLayoutPanel2.Controls.Add(cmbRol, 1, 5);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(4, 66);
            tableLayoutPanel2.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 7;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 72F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel2.Size = new Size(719, 559);
            tableLayoutPanel2.TabIndex = 6;
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
            txtId.Location = new Point(4, 71);
            txtId.Margin = new Padding(4, 3, 4, 3);
            txtId.Name = "txtId";
            txtId.PenWidth = 15;
            txtId.RGB = false;
            txtId.Rounding = true;
            txtId.RoundingInt = 20;
            txtId.Size = new Size(344, 67);
            txtId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtId.TabIndex = 27;
            txtId.Tag = "Cyber";
            txtId.TextButton = "";
            txtId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtId.Timer_RGB = 300;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Gray;
            lblId.Location = new Point(4, 25);
            lblId.Margin = new Padding(4, 25, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(345, 43);
            lblId.TabIndex = 25;
            lblId.Text = "Id";
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
            btnRegresar.Location = new Point(409, 477);
            btnRegresar.Margin = new Padding(56, 37, 56, 37);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.PressedBorderColor = Color.Gray;
            btnRegresar.PressedColor = Color.Gray;
            btnRegresar.Size = new Size(254, 45);
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
            btnGuardar.Location = new Point(56, 477);
            btnGuardar.Margin = new Padding(56, 37, 56, 37);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedBorderColor = Color.ForestGreen;
            btnGuardar.PressedColor = Color.ForestGreen;
            btnGuardar.Size = new Size(241, 45);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtContrasenna
            // 
            txtContrasenna.Alpha = 20;
            txtContrasenna.BackColor = Color.Transparent;
            txtContrasenna.Background_WidthPen = 3F;
            txtContrasenna.BackgroundPen = true;
            txtContrasenna.ColorBackground = Color.White;
            txtContrasenna.ColorBackground_Pen = Color.Gray;
            txtContrasenna.ColorLighting = Color.FromArgb(29, 200, 238);
            txtContrasenna.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtContrasenna.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtContrasenna.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtContrasenna.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtContrasenna.ForeColor = Color.Black;
            txtContrasenna.Lighting = false;
            txtContrasenna.LinearGradientPen = false;
            txtContrasenna.Location = new Point(4, 363);
            txtContrasenna.Margin = new Padding(4, 3, 4, 3);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.PenWidth = 15;
            txtContrasenna.RGB = false;
            txtContrasenna.Rounding = true;
            txtContrasenna.RoundingInt = 20;
            txtContrasenna.Size = new Size(344, 68);
            txtContrasenna.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtContrasenna.TabIndex = 16;
            txtContrasenna.Tag = "Cyber";
            txtContrasenna.TextButton = "";
            txtContrasenna.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtContrasenna.Timer_RGB = 300;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.BackColor = Color.Transparent;
            lblRol.Dock = DockStyle.Fill;
            lblRol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRol.ForeColor = Color.Gray;
            lblRol.Location = new Point(357, 318);
            lblRol.Margin = new Padding(4, 25, 4, 0);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(358, 42);
            lblRol.TabIndex = 15;
            lblRol.Text = "Rol";
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.BackColor = Color.Transparent;
            lblContrasenna.Dock = DockStyle.Fill;
            lblContrasenna.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasenna.ForeColor = Color.Gray;
            lblContrasenna.Location = new Point(4, 318);
            lblContrasenna.Margin = new Padding(4, 25, 4, 0);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(345, 42);
            lblContrasenna.TabIndex = 14;
            lblContrasenna.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Dock = DockStyle.Fill;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Gray;
            lblUsuario.Location = new Point(357, 168);
            lblUsuario.Margin = new Padding(4, 25, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(358, 47);
            lblUsuario.TabIndex = 11;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Alpha = 20;
            txtUsuario.BackColor = Color.Transparent;
            txtUsuario.Background_WidthPen = 3F;
            txtUsuario.BackgroundPen = true;
            txtUsuario.ColorBackground = Color.White;
            txtUsuario.ColorBackground_Pen = Color.Gray;
            txtUsuario.ColorLighting = Color.FromArgb(29, 200, 238);
            txtUsuario.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtUsuario.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtUsuario.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Lighting = false;
            txtUsuario.LinearGradientPen = false;
            txtUsuario.Location = new Point(357, 218);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PenWidth = 15;
            txtUsuario.RGB = false;
            txtUsuario.Rounding = true;
            txtUsuario.RoundingInt = 20;
            txtUsuario.Size = new Size(347, 68);
            txtUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUsuario.TabIndex = 8;
            txtUsuario.Tag = "Cyber";
            txtUsuario.TextButton = "";
            txtUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtUsuario.Timer_RGB = 300;
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
            txtNombre.Location = new Point(4, 218);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.PenWidth = 15;
            txtNombre.RGB = false;
            txtNombre.Rounding = true;
            txtNombre.RoundingInt = 20;
            txtNombre.Size = new Size(344, 68);
            txtNombre.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNombre.TabIndex = 7;
            txtNombre.Tag = "Cyber";
            txtNombre.TextButton = "";
            txtNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNombre.Timer_RGB = 300;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Gray;
            lblNombre.Location = new Point(4, 168);
            lblNombre.Margin = new Padding(4, 25, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(345, 47);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.White;
            cmbRol.ColorArrow = Color.Gray;
            cmbRol.ColorBackground = Color.White;
            cmbRol.ColorBackground_Pen = Color.Gray;
            cmbRol.ColorItemHover = Color.White;
            cmbRol.ColorPen_1 = Color.Gray;
            cmbRol.ColorPen_2 = Color.Gray;
            cmbRol.CyberComboBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cmbRol.Dock = DockStyle.Fill;
            cmbRol.DrawMode = DrawMode.OwnerDrawFixed;
            cmbRol.DropDownHeight = 150;
            cmbRol.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRol.FlatStyle = FlatStyle.Flat;
            cmbRol.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbRol.ForeColor = Color.Black;
            cmbRol.FormattingEnabled = true;
            cmbRol.IntegralHeight = false;
            cmbRol.ItemHeight = 48;
            cmbRol.Location = new Point(357, 363);
            cmbRol.Margin = new Padding(4, 3, 4, 3);
            cmbRol.Name = "cmbRol";
            cmbRol.RGB = false;
            cmbRol.RoundingInt = 20;
            cmbRol.Size = new Size(358, 54);
            cmbRol.TabIndex = 24;
            cmbRol.Timer_RGB = 300;
            // 
            // ActualizarVendedorForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 628);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ActualizarVendedorForm";
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
        private ReaLTaiizor.Controls.Button btnGuardar;
        private ReaLTaiizor.Controls.CyberRichTextBox txtContrasenna;
        private LabelEdit lblRol;
        private LabelEdit lblContrasenna;
        private LabelEdit lblUsuario;
        private ReaLTaiizor.Controls.CyberRichTextBox txtUsuario;
        private ReaLTaiizor.Controls.CyberRichTextBox txtNombre;
        private ReaLTaiizor.Controls.LabelEdit lblNombre;
        private ReaLTaiizor.Controls.CyberComboBox cmbRol;
        private ReaLTaiizor.Controls.LabelEdit lblId;
        private ReaLTaiizor.Controls.CyberRichTextBox txtId;
    }
}