namespace Presentacion
{
    partial class BuscarIdProductoForm
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
            btnBuscar = new ReaLTaiizor.Controls.Button();
            lblId = new ReaLTaiizor.Controls.LabelEdit();
            txtIdProducto = new ReaLTaiizor.Controls.CyberRichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBuscar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdProducto, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(50, 3, 50, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.Size = new Size(382, 253);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.BorderColor = Color.ForestGreen;
            btnBuscar.Dock = DockStyle.Fill;
            btnBuscar.EnteredBorderColor = Color.ForestGreen;
            btnBuscar.EnteredColor = Color.ForestGreen;
            btnBuscar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Image = null;
            btnBuscar.ImageAlign = ContentAlignment.MiddleRight;
            btnBuscar.InactiveColor = Color.ForestGreen;
            btnBuscar.Location = new Point(90, 170);
            btnBuscar.Margin = new Padding(90, 30, 90, 30);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.PressedBorderColor = Color.ForestGreen;
            btnBuscar.PressedColor = Color.ForestGreen;
            btnBuscar.Size = new Size(202, 53);
            btnBuscar.TabIndex = 23;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlignment = StringAlignment.Center;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.None;
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.ForeColor = Color.Gray;
            lblId.Location = new Point(123, 23);
            lblId.Margin = new Padding(3, 20, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(136, 28);
            lblId.TabIndex = 12;
            lblId.Text = "Id a actualizar";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Alpha = 20;
            txtIdProducto.BackColor = Color.Transparent;
            txtIdProducto.Background_WidthPen = 3F;
            txtIdProducto.BackgroundPen = true;
            txtIdProducto.ColorBackground = Color.White;
            txtIdProducto.ColorBackground_Pen = Color.Gray;
            txtIdProducto.ColorLighting = Color.FromArgb(29, 200, 238);
            txtIdProducto.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtIdProducto.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtIdProducto.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtIdProducto.Dock = DockStyle.Top;
            txtIdProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtIdProducto.ForeColor = Color.Black;
            txtIdProducto.Lighting = false;
            txtIdProducto.LinearGradientPen = false;
            txtIdProducto.Location = new Point(50, 58);
            txtIdProducto.Margin = new Padding(50, 3, 50, 3);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.PenWidth = 15;
            txtIdProducto.RGB = false;
            txtIdProducto.Rounding = true;
            txtIdProducto.RoundingInt = 20;
            txtIdProducto.Size = new Size(282, 55);
            txtIdProducto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtIdProducto.TabIndex = 13;
            txtIdProducto.Tag = "Cyber";
            txtIdProducto.TextButton = "";
            txtIdProducto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtIdProducto.Timer_RGB = 300;
            // 
            // BuscarIdProductoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 253);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuscarIdProductoForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.LabelEdit lblId;
        private ReaLTaiizor.Controls.CyberRichTextBox txtIdProducto;
        private ReaLTaiizor.Controls.Button btnBuscar;
    }
}