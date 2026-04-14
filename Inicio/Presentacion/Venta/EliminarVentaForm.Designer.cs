namespace UI.Venta
{
    partial class EliminarVentaForm
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
            btnEliminar = new ReaLTaiizor.Controls.Button();
            lblId = new ReaLTaiizor.Controls.LabelEdit();
            txtIdVenta = new ReaLTaiizor.Controls.CyberRichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnEliminar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdVenta, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(50, 3, 50, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.Size = new Size(382, 253);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Transparent;
            btnEliminar.BorderColor = Color.Brown;
            btnEliminar.Dock = DockStyle.Fill;
            btnEliminar.EnteredBorderColor = Color.Brown;
            btnEliminar.EnteredColor = Color.Brown;
            btnEliminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Image = null;
            btnEliminar.ImageAlign = ContentAlignment.MiddleRight;
            btnEliminar.InactiveColor = Color.Brown;
            btnEliminar.Location = new Point(90, 170);
            btnEliminar.Margin = new Padding(90, 30, 90, 30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedBorderColor = Color.Brown;
            btnEliminar.PressedColor = Color.Brown;
            btnEliminar.Size = new Size(202, 53);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlignment = StringAlignment.Center;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Gray;
            lblId.Location = new Point(128, 23);
            lblId.Margin = new Padding(3, 20, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(125, 28);
            lblId.TabIndex = 12;
            lblId.Text = "Id a eliminar";
            // 
            // txtIdVenta
            // 
            txtIdVenta.Alpha = 20;
            txtIdVenta.BackColor = Color.Transparent;
            txtIdVenta.Background_WidthPen = 3F;
            txtIdVenta.BackgroundPen = true;
            txtIdVenta.ColorBackground = Color.White;
            txtIdVenta.ColorBackground_Pen = Color.Gray;
            txtIdVenta.ColorLighting = Color.FromArgb(29, 200, 238);
            txtIdVenta.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtIdVenta.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtIdVenta.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtIdVenta.Dock = DockStyle.Top;
            txtIdVenta.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtIdVenta.ForeColor = Color.Black;
            txtIdVenta.Lighting = false;
            txtIdVenta.LinearGradientPen = false;
            txtIdVenta.Location = new Point(50, 58);
            txtIdVenta.Margin = new Padding(50, 3, 50, 3);
            txtIdVenta.Name = "txtIdVenta";
            txtIdVenta.PenWidth = 15;
            txtIdVenta.RGB = false;
            txtIdVenta.Rounding = true;
            txtIdVenta.RoundingInt = 20;
            txtIdVenta.Size = new Size(282, 55);
            txtIdVenta.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtIdVenta.TabIndex = 13;
            txtIdVenta.Tag = "Cyber";
            txtIdVenta.TextButton = "";
            txtIdVenta.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtIdVenta.Timer_RGB = 300;
            // 
            // EliminarVentaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 253);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EliminarVentaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btnEliminar;
        private ReaLTaiizor.Controls.LabelEdit lblId;
        private ReaLTaiizor.Controls.CyberRichTextBox txtIdVenta;
    }
}