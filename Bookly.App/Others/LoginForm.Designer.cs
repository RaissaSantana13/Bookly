namespace Bookly.App.Others
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new ReaLTaiizor.Controls.BigTextBox();
            txtEmail = new ReaLTaiizor.Controls.BigTextBox();
            pictureBox1 = new PictureBox();
            btnLogin = new ReaLTaiizor.Controls.CyberButton();
            hopeGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // hopeGroupBox1
            // 
            hopeGroupBox1.Anchor = AnchorStyles.Left;
            hopeGroupBox1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox1.Controls.Add(btnLogin);
            hopeGroupBox1.Controls.Add(label2);
            hopeGroupBox1.Controls.Add(label1);
            hopeGroupBox1.Controls.Add(txtPassword);
            hopeGroupBox1.Controls.Add(txtEmail);
            hopeGroupBox1.Font = new Font("Segoe UI", 12F);
            hopeGroupBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeGroupBox1.LineColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox1.Location = new Point(98, 101);
            hopeGroupBox1.Name = "hopeGroupBox1";
            hopeGroupBox1.ShowText = false;
            hopeGroupBox1.Size = new Size(362, 376);
            hopeGroupBox1.TabIndex = 0;
            hopeGroupBox1.TabStop = false;
            hopeGroupBox1.Text = "hopeGroupBox1";
            hopeGroupBox1.ThemeColor = Color.FromArgb(209, 186, 255);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 166);
            label2.Name = "label2";
            label2.Size = new Size(91, 35);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 48);
            label1.Name = "label1";
            label1.Size = new Size(83, 35);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.Font = new Font("Tahoma", 11F);
            txtPassword.ForeColor = Color.DimGray;
            txtPassword.Image = null;
            txtPassword.Location = new Point(31, 204);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.ReadOnly = false;
            txtPassword.Size = new Size(293, 41);
            txtPassword.TabIndex = 1;
            txtPassword.TextAlignment = HorizontalAlignment.Left;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Transparent;
            txtEmail.Font = new Font("Tahoma", 11F);
            txtEmail.ForeColor = Color.DimGray;
            txtEmail.Image = null;
            txtEmail.Location = new Point(31, 95);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = false;
            txtEmail.Size = new Size(293, 41);
            txtEmail.TabIndex = 0;
            txtEmail.TextAlignment = HorizontalAlignment.Left;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.Login;
            pictureBox1.Location = new Point(226, -91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 600);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.Alpha = 20;
            btnLogin.Anchor = AnchorStyles.Left;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.BackColor = Color.Transparent;
            btnLogin.Background = true;
            btnLogin.Background_WidthPen = 1F;
            btnLogin.BackgroundPen = true;
            btnLogin.ColorBackground = Color.FromArgb(146, 227, 169);
            btnLogin.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            btnLogin.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            btnLogin.ColorBackground_Pen = Color.Gray;
            btnLogin.ColorLighting = Color.FromArgb(29, 200, 238);
            btnLogin.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnLogin.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnLogin.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnLogin.Effect_1 = true;
            btnLogin.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnLogin.Effect_1_Transparency = 25;
            btnLogin.Effect_2 = true;
            btnLogin.Effect_2_ColorBackground = Color.White;
            btnLogin.Effect_2_Transparency = 20;
            btnLogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(245, 245, 245);
            btnLogin.Lighting = false;
            btnLogin.LinearGradient_Background = false;
            btnLogin.LinearGradientPen = false;
            btnLogin.Location = new Point(69, 285);
            btnLogin.Name = "btnLogin";
            btnLogin.PenWidth = 15;
            btnLogin.Rounding = true;
            btnLogin.RoundingInt = 70;
            btnLogin.Size = new Size(200, 55);
            btnLogin.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogin.TabIndex = 7;
            btnLogin.Tag = "Cyber";
            btnLogin.TextButton = "Login";
            btnLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnLogin.Timer_Effect_1 = 5;
            btnLogin.Timer_RGB = 300;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(30, 30, 38);
            BorderColor = Color.DarkSlateBlue;
            ClientSize = new Size(909, 566);
            Controls.Add(pictureBox1);
            Controls.Add(hopeGroupBox1);
            HeaderColor = Color.FromArgb(126, 87, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.bookly;
            Name = "LoginForm";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            hopeGroupBox1.ResumeLayout(false);
            hopeGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private Label label2;
        private Label label1;
        private ReaLTaiizor.Controls.BigTextBox txtPassword;
        private ReaLTaiizor.Controls.BigTextBox txtEmail;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton btnLogin;
    }
}