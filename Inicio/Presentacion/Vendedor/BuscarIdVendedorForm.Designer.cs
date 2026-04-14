namespace UI.Vendedor
{
    partial class BuscarIdVendedorForm
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
            txtIdVendedor = new ReaLTaiizor.Controls.CyberRichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnBuscar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdVendedor, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(50, 3, 50, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 113F));
            tableLayoutPanel1.Size = new Size(382, 253);
            tableLayoutPanel1.TabIndex = 1;
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
            // txtIdVendedor
            // 
            txtIdVendedor.Alpha = 20;
            txtIdVendedor.BackColor = Color.Transparent;
            txtIdVendedor.Background_WidthPen = 3F;
            txtIdVendedor.BackgroundPen = true;
            txtIdVendedor.ColorBackground = Color.White;
            txtIdVendedor.ColorBackground_Pen = Color.Gray;
            txtIdVendedor.ColorLighting = Color.FromArgb(29, 200, 238);
            txtIdVendedor.ColorPen_1 = Color.FromArgb(29, 200, 238);
            txtIdVendedor.ColorPen_2 = Color.FromArgb(37, 52, 68);
            txtIdVendedor.CyberRichTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtIdVendedor.Dock = DockStyle.Top;
            txtIdVendedor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            txtIdVendedor.ForeColor = Color.Black;
            txtIdVendedor.Lighting = false;
            txtIdVendedor.LinearGradientPen = false;
            txtIdVendedor.Location = new Point(50, 58);
            txtIdVendedor.Margin = new Padding(50, 3, 50, 3);
            txtIdVendedor.Name = "txtIdVendedor";
            txtIdVendedor.PenWidth = 15;
            txtIdVendedor.RGB = false;
            txtIdVendedor.Rounding = true;
            txtIdVendedor.RoundingInt = 20;
            txtIdVendedor.Size = new Size(282, 55);
            txtIdVendedor.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtIdVendedor.TabIndex = 13;
            txtIdVendedor.Tag = "Cyber";
            txtIdVendedor.TextButton = "";
            txtIdVendedor.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtIdVendedor.Timer_RGB = 300;
            // 
            // BuscarIdVendedorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(382, 253);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BuscarIdVendedorForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.Button btnBuscar;
        private ReaLTaiizor.Controls.LabelEdit lblId;
        private ReaLTaiizor.Controls.CyberRichTextBox txtIdVendedor;
    }
}