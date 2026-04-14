using ReaLTaiizor.Controls;

namespace Presentacion.Cliente
{
    partial class InsertarClienteForm
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
            txtNombre = new CyberRichTextBox();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            btnGuardar = new ReaLTaiizor.Controls.Button();
            txtCorreo = new CyberRichTextBox();
            this.lblCorreo = new LabelEdit();
            this.lblTelefono = new LabelEdit();
            txtTelefono = new CyberRichTextBox();
            lblNombre = new LabelEdit();
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
            tableLayoutPanel1.Size = new Size(582, 503);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = AnchorStyles.None;
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = Color.Transparent;
            this.lblEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblEncabezado.ForeColor = Color.Black;
            this.lblEncabezado.Location = new Point(121, 2);
            this.lblEncabezado.Margin = new Padding(0, 0, 3, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Padding = new Padding(15, 0, 0, 0);
            this.lblEncabezado.Size = new Size(336, 46);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Registro de Cliente";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1319427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8680573F));
            tableLayoutPanel2.Controls.Add(txtNombre, 0, 2);
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 7);
            tableLayoutPanel2.Controls.Add(btnGuardar, 0, 7);
            tableLayoutPanel2.Controls.Add(txtCorreo, 0, 4);
            tableLayoutPanel2.Controls.Add(this.lblCorreo, 0, 3);
            tableLayoutPanel2.Controls.Add(this.lblTelefono, 1, 1);
            tableLayoutPanel2.Controls.Add(txtTelefono, 1, 2);
            tableLayoutPanel2.Controls.Add(lblNombre, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 53);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 8;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 66F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.Size = new Size(576, 447);
            tableLayoutPanel2.TabIndex = 6;
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
            txtNombre.Location = new Point(3, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.PenWidth = 15;
            txtNombre.RGB = false;
            txtNombre.Rounding = true;
            txtNombre.RoundingInt = 20;
            txtNombre.Size = new Size(277, 55);
            txtNombre.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNombre.TabIndex = 26;
            txtNombre.Tag = "Cyber";
            txtNombre.TextButton = "";
            txtNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNombre.Timer_RGB = 300;
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
            btnRegresar.Location = new Point(328, 382);
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
            btnGuardar.Location = new Point(45, 382);
            btnGuardar.Margin = new Padding(45, 30, 45, 30);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.PressedBorderColor = Color.ForestGreen;
            btnGuardar.PressedColor = Color.ForestGreen;
            btnGuardar.Size = new Size(193, 35);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlignment = StringAlignment.Center;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Alpha = 20;
            txtCorreo.BackColor = Color.Transparent;
            txtCorreo.Background_WidthPen = 3F;
            txtCorreo.BackgroundPen = true;
            txtCorreo.ColorBackground = Color.White;
            txtCorreo.ColorBackground_Pen = Color.Gray;
            txtCorreo.ColorLighting = Color.FromArgb(29, 200, 238);
            txtCorreo.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtCorreo.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtCorreo.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtCorreo.ForeColor = Color.Black;
            txtCorreo.Lighting = false;
            txtCorreo.LinearGradientPen = false;
            txtCorreo.Location = new Point(3, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PenWidth = 15;
            txtCorreo.RGB = false;
            txtCorreo.Rounding = true;
            txtCorreo.RoundingInt = 20;
            txtCorreo.Size = new Size(277, 55);
            txtCorreo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCorreo.TabIndex = 16;
            txtCorreo.Tag = "Cyber";
            txtCorreo.TextButton = "";
            txtCorreo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCorreo.Timer_RGB = 300;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = Color.Transparent;
            this.lblCorreo.Dock = DockStyle.Fill;
            this.lblCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCorreo.ForeColor = Color.Gray;
            this.lblCorreo.Location = new Point(3, 164);
            this.lblCorreo.Margin = new Padding(3, 20, 3, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new Size(277, 33);
            this.lblCorreo.TabIndex = 14;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = Color.Transparent;
            this.lblTelefono.Dock = DockStyle.Fill;
            this.lblTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTelefono.ForeColor = Color.Gray;
            this.lblTelefono.Location = new Point(286, 43);
            this.lblTelefono.Margin = new Padding(3, 20, 3, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new Size(287, 35);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtTelefono
            // 
            txtTelefono.Alpha = 20;
            txtTelefono.BackColor = Color.Transparent;
            txtTelefono.Background_WidthPen = 3F;
            txtTelefono.BackgroundPen = true;
            txtTelefono.ColorBackground = Color.White;
            txtTelefono.ColorBackground_Pen = Color.Gray;
            txtTelefono.ColorLighting = Color.FromArgb(29, 200, 238);
            txtTelefono.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtTelefono.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtTelefono.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtTelefono.ForeColor = Color.Black;
            txtTelefono.Lighting = false;
            txtTelefono.LinearGradientPen = false;
            txtTelefono.Location = new Point(286, 81);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PenWidth = 15;
            txtTelefono.RGB = false;
            txtTelefono.Rounding = true;
            txtTelefono.RoundingInt = 20;
            txtTelefono.Size = new Size(278, 55);
            txtTelefono.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTelefono.TabIndex = 8;
            txtTelefono.Tag = "Cyber";
            txtTelefono.TextButton = "";
            txtTelefono.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTelefono.Timer_RGB = 300;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Dock = DockStyle.Fill;
            lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = Color.Gray;
            lblNombre.Location = new Point(3, 43);
            lblNombre.Margin = new Padding(3, 20, 3, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(277, 35);
            lblNombre.TabIndex = 5;
            lblNombre.Text = "Nombre";
            // 
            // InsertarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 503);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "InsertarClienteForm";
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
        private ReaLTaiizor.Controls.Button btnGuardar;
        private CyberRichTextBox txtCorreo;
        private LabelEdit lblCorreo;
        private LabelEdit lblTelefono;
        private CyberRichTextBox txtTelefono;
        private ReaLTaiizor.Controls.LabelEdit lblNombre;
        private CyberRichTextBox txtNombre;
    }
}