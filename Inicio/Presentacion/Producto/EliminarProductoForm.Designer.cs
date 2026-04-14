namespace Presentacion
{
    partial class EliminarProductoForm
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
            txtIdProducto = new ReaLTaiizor.Controls.CyberRichTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnEliminar, 0, 2);
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtIdProducto, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(44, 2, 44, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 85F));
            tableLayoutPanel1.Size = new Size(334, 190);
            tableLayoutPanel1.TabIndex = 1;
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
            btnEliminar.Location = new Point(79, 127);
            btnEliminar.Margin = new Padding(79, 22, 79, 22);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.PressedBorderColor = Color.Brown;
            btnEliminar.PressedColor = Color.Brown;
            btnEliminar.Size = new Size(176, 41);
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
            lblId.Location = new Point(117, 17);
            lblId.Margin = new Padding(3, 15, 3, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(99, 21);
            lblId.TabIndex = 12;
            lblId.Text = "Id a eliminar";
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
            txtIdProducto.Location = new Point(44, 43);
            txtIdProducto.Margin = new Padding(44, 2, 44, 2);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.PenWidth = 15;
            txtIdProducto.RGB = false;
            txtIdProducto.Rounding = true;
            txtIdProducto.RoundingInt = 20;
            txtIdProducto.Size = new Size(246, 41);
            txtIdProducto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtIdProducto.TabIndex = 13;
            txtIdProducto.Tag = "Cyber";
            txtIdProducto.TextButton = "";
            txtIdProducto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtIdProducto.Timer_RGB = 300;
            // 
            // EliminarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(334, 190);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EliminarProductoForm";
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
        private ReaLTaiizor.Controls.CyberRichTextBox txtIdProducto;
    }
}