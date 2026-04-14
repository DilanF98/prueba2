using ReaLTaiizor.Controls;

namespace Presentacion.Cliente
{
    partial class ActualizarClienteForm
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
            this.lblEncabezado = new ReaLTaiizor.Controls.HeaderLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRegresar = new ReaLTaiizor.Controls.Button();
            btnActualizar = new ReaLTaiizor.Controls.Button();
            txtCorreo = new ReaLTaiizor.Controls.CyberRichTextBox();
            txtTelefono = new ReaLTaiizor.Controls.CyberRichTextBox();
            this.lblCorreo = new ReaLTaiizor.Controls.LabelEdit();
            this.lblTelefono = new ReaLTaiizor.Controls.LabelEdit();
            this.lblNombre = new ReaLTaiizor.Controls.LabelEdit();
            txtNombre = new ReaLTaiizor.Controls.CyberRichTextBox();
            txtId = new ReaLTaiizor.Controls.CyberRichTextBox();
            lblId = new ReaLTaiizor.Controls.LabelEdit();
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
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = AnchorStyles.None;
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.BackColor = Color.Transparent;
            this.lblEncabezado.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblEncabezado.ForeColor = Color.Black;
            this.lblEncabezado.Location = new Point(132, 2);
            this.lblEncabezado.Margin = new Padding(0, 0, 3, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Padding = new Padding(15, 0, 0, 0);
            this.lblEncabezado.Size = new Size(315, 46);
            this.lblEncabezado.TabIndex = 5;
            this.lblEncabezado.Text = "Actualizar Cliente";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.1319427F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.8680573F));
            tableLayoutPanel2.Controls.Add(btnRegresar, 1, 7);
            tableLayoutPanel2.Controls.Add(btnActualizar, 0, 7);
            tableLayoutPanel2.Controls.Add(txtCorreo, 1, 4);
            tableLayoutPanel2.Controls.Add(txtTelefono, 0, 4);
            tableLayoutPanel2.Controls.Add(this.lblCorreo, 1, 3);
            tableLayoutPanel2.Controls.Add(this.lblTelefono, 0, 3);
            tableLayoutPanel2.Controls.Add(this.lblNombre, 1, 1);
            tableLayoutPanel2.Controls.Add(txtNombre, 1, 2);
            tableLayoutPanel2.Controls.Add(txtId, 0, 2);
            tableLayoutPanel2.Controls.Add(lblId, 0, 1);
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanel2.Size = new Size(576, 447);
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
            btnRegresar.Location = new Point(328, 381);
            btnRegresar.Margin = new Padding(45, 30, 45, 30);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.PressedBorderColor = Color.Gray;
            btnRegresar.PressedColor = Color.Gray;
            btnRegresar.Size = new Size(203, 36);
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
            btnActualizar.Location = new Point(45, 381);
            btnActualizar.Margin = new Padding(45, 30, 45, 30);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.PressedBorderColor = Color.ForestGreen;
            btnActualizar.PressedColor = Color.ForestGreen;
            btnActualizar.Size = new Size(193, 36);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.TextAlignment = StringAlignment.Center;
            btnActualizar.Click += btnActualizar_Click;
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
            txtCorreo.Location = new Point(286, 200);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PenWidth = 15;
            txtCorreo.RGB = false;
            txtCorreo.Rounding = true;
            txtCorreo.RoundingInt = 20;
            txtCorreo.Size = new Size(277, 55);
            txtCorreo.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtCorreo.TabIndex = 17;
            txtCorreo.Tag = "Cyber";
            txtCorreo.TextButton = "";
            txtCorreo.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtCorreo.Timer_RGB = 300;
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
            txtTelefono.Location = new Point(3, 200);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PenWidth = 15;
            txtTelefono.RGB = false;
            txtTelefono.Rounding = true;
            txtTelefono.RoundingInt = 20;
            txtTelefono.Size = new Size(277, 55);
            txtTelefono.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtTelefono.TabIndex = 16;
            txtTelefono.Tag = "Cyber";
            txtTelefono.TextButton = "";
            txtTelefono.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtTelefono.Timer_RGB = 300;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = Color.Transparent;
            this.lblCorreo.Dock = DockStyle.Fill;
            this.lblCorreo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblCorreo.ForeColor = Color.Gray;
            this.lblCorreo.Location = new Point(286, 164);
            this.lblCorreo.Margin = new Padding(3, 20, 3, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new Size(287, 33);
            this.lblCorreo.TabIndex = 15;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = Color.Transparent;
            this.lblTelefono.Dock = DockStyle.Fill;
            this.lblTelefono.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTelefono.ForeColor = Color.Gray;
            this.lblTelefono.Location = new Point(3, 164);
            this.lblTelefono.Margin = new Padding(3, 20, 3, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new Size(277, 33);
            this.lblTelefono.TabIndex = 14;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = Color.Transparent;
            this.lblNombre.Dock = DockStyle.Fill;
            this.lblNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblNombre.ForeColor = Color.Gray;
            this.lblNombre.Location = new Point(286, 45);
            this.lblNombre.Margin = new Padding(3, 20, 3, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new Size(287, 33);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre";
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
            txtNombre.Location = new Point(286, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.PenWidth = 15;
            txtNombre.RGB = false;
            txtNombre.Rounding = true;
            txtNombre.RoundingInt = 20;
            txtNombre.Size = new Size(278, 55);
            txtNombre.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtNombre.TabIndex = 8;
            txtNombre.Tag = "Cyber";
            txtNombre.TextButton = "";
            txtNombre.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtNombre.Timer_RGB = 300;
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
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Gray;
            lblId.Location = new Point(3, 45);
            lblId.Margin = new Padding(3, 20, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(277, 33);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // ActualizarClienteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 503);
            ControlBox = false;
            Controls.Add(tableLayoutPanel1);
            Name = "ActualizarClienteForm";
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
        private ReaLTaiizor.Controls.CyberRichTextBox txtCorreo;
        private ReaLTaiizor.Controls.CyberRichTextBox txtTelefono;
        private LabelEdit lblCorreo;
        private LabelEdit lblTelefono;
        private LabelEdit lblNombre;
        private ReaLTaiizor.Controls.CyberRichTextBox txtNombre;
        private ReaLTaiizor.Controls.CyberRichTextBox txtId;
        private ReaLTaiizor.Controls.LabelEdit lblId;
    }
}