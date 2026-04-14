using ReaLTaiizor.Controls;

namespace Presentacion
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new ReaLTaiizor.Controls.Panel();
            txtContrasenna = new CyberTextBox();
            txtUsuario = new CyberRichTextBox();
            btnIngresar = new ReaLTaiizor.Controls.Button();
            lblContrasenna = new LabelEdit();
            lblUsuario = new LabelEdit();
            lblSubtitulo = new LabelEdit();
            lblTitulo = new HeaderLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(txtContrasenna);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(lblContrasenna);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(lblTitulo);
            panel1.EdgeColor = SystemColors.ButtonFace;
            panel1.Location = new Point(694, 250);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(6, 7, 6, 7);
            panel1.Size = new Size(464, 567);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // txtContrasenna
            // 
            txtContrasenna.Alpha = 20;
            txtContrasenna.Anchor = AnchorStyles.None;
            txtContrasenna.BackColor = Color.Transparent;
            txtContrasenna.Background_WidthPen = 3F;
            txtContrasenna.BackgroundPen = true;
            txtContrasenna.ColorBackground = Color.White;
            txtContrasenna.ColorBackground_Pen = Color.Gray;
            txtContrasenna.ColorLighting = Color.DarkGray;
            txtContrasenna.ColorPen_1 = Color.White;
            txtContrasenna.ColorPen_2 = Color.White;
            txtContrasenna.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            txtContrasenna.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            txtContrasenna.ForeColor = Color.Black;
            txtContrasenna.Lighting = false;
            txtContrasenna.LinearGradientPen = false;
            txtContrasenna.Location = new Point(54, 338);
            txtContrasenna.Margin = new Padding(39, 62, 27, 92);
            txtContrasenna.MaximumSize = new Size(349, 65);
            txtContrasenna.MinimumSize = new Size(349, 65);
            txtContrasenna.Name = "txtContrasenna";
            txtContrasenna.Password = true;
            txtContrasenna.PasswordChar = '*';
            txtContrasenna.PenWidth = 15;
            txtContrasenna.RGB = false;
            txtContrasenna.Rounding = true;
            txtContrasenna.RoundingInt = 20;
            txtContrasenna.Size = new Size(349, 65);
            txtContrasenna.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtContrasenna.TabIndex = 8;
            txtContrasenna.Tag = "Cyber";
            txtContrasenna.TextAlign = HorizontalAlignment.Left;
            txtContrasenna.TextButton = "";
            txtContrasenna.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            txtContrasenna.Timer_RGB = 300;
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
            txtUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.ForeColor = Color.Black;
            txtUsuario.Lighting = false;
            txtUsuario.LinearGradientPen = false;
            txtUsuario.Location = new Point(54, 227);
            txtUsuario.Margin = new Padding(4, 3, 4, 3);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PenWidth = 15;
            txtUsuario.RGB = false;
            txtUsuario.Rounding = true;
            txtUsuario.RoundingInt = 20;
            txtUsuario.Size = new Size(349, 65);
            txtUsuario.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            txtUsuario.TabIndex = 7;
            txtUsuario.Tag = "Cyber";
            txtUsuario.TextButton = "";
            txtUsuario.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            txtUsuario.Timer_RGB = 300;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.BorderColor = Color.FromArgb(32, 34, 37);
            btnIngresar.EnteredBorderColor = Color.Black;
            btnIngresar.EnteredColor = Color.FromArgb(32, 34, 37);
            btnIngresar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.Image = null;
            btnIngresar.ImageAlign = ContentAlignment.MiddleLeft;
            btnIngresar.InactiveColor = Color.FromArgb(32, 34, 37);
            btnIngresar.Location = new Point(119, 443);
            btnIngresar.Margin = new Padding(4, 3, 4, 3);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.PressedBorderColor = Color.Black;
            btnIngresar.PressedColor = Color.Black;
            btnIngresar.Size = new Size(234, 62);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlignment = StringAlignment.Center;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblContrasenna
            // 
            lblContrasenna.AutoSize = true;
            lblContrasenna.BackColor = Color.Transparent;
            lblContrasenna.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContrasenna.ForeColor = Color.Gray;
            lblContrasenna.Location = new Point(54, 295);
            lblContrasenna.Margin = new Padding(4, 0, 4, 0);
            lblContrasenna.Name = "lblContrasenna";
            lblContrasenna.Size = new Size(252, 32);
            lblContrasenna.TabIndex = 3;
            lblContrasenna.Text = "Ingrese su contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.Gray;
            lblUsuario.Location = new Point(54, 183);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(215, 32);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Ingrese su Usuario";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.BackColor = Color.Transparent;
            lblSubtitulo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitulo.ForeColor = Color.Gray;
            lblSubtitulo.Location = new Point(59, 65);
            lblSubtitulo.Margin = new Padding(4, 0, 4, 0);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(275, 32);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingrese sus credenciales";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.Location = new Point(54, 92);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(387, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido de nuevo!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1851, 1062);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button btnIngresar;
        private ReaLTaiizor.Controls.LabelEdit lblContrasenna;
        private ReaLTaiizor.Controls.LabelEdit lblUsuario;
        private LabelEdit lblSubtitulo;
        private ReaLTaiizor.Controls.HeaderLabel lblTitulo;
        private ReaLTaiizor.Controls.CyberRichTextBox txtUsuario;
        private ReaLTaiizor.Controls.CyberTextBox txtContrasenna;
    }
}
