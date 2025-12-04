namespace Bookly.App.Others
{
    partial class InitialForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            loginBtn = new ReaLTaiizor.Controls.CyberButton();
            registerBtn = new ReaLTaiizor.Controls.CyberButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(164, 110, 217);
            label1.Location = new Point(144, 396);
            label1.Name = "label1";
            label1.Size = new Size(233, 81);
            label1.TabIndex = 0;
            label1.Text = "Bookly";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(179, 229, 196);
            label2.Location = new Point(144, 477);
            label2.Name = "label2";
            label2.Size = new Size(418, 74);
            label2.TabIndex = 1;
            label2.Text = "Transforme sua leitura em um \nhábito inspirador.";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "initial_image.png");
            // 
            // loginBtn
            // 
            loginBtn.Alpha = 20;
            loginBtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            loginBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            loginBtn.BackColor = Color.Transparent;
            loginBtn.Background = true;
            loginBtn.Background_WidthPen = 0F;
            loginBtn.BackgroundPen = true;
            loginBtn.ColorBackground = Color.FromArgb(179, 229, 196);
            loginBtn.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            loginBtn.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            loginBtn.ColorBackground_Pen = Color.Gray;
            loginBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            loginBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            loginBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            loginBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            loginBtn.Effect_1 = true;
            loginBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            loginBtn.Effect_1_Transparency = 25;
            loginBtn.Effect_2 = true;
            loginBtn.Effect_2_ColorBackground = Color.White;
            loginBtn.Effect_2_Transparency = 20;
            loginBtn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.ForeColor = Color.FromArgb(245, 245, 245);
            loginBtn.Lighting = false;
            loginBtn.LinearGradient_Background = false;
            loginBtn.LinearGradientPen = false;
            loginBtn.Location = new Point(1781, 56);
            loginBtn.Name = "loginBtn";
            loginBtn.PenWidth = 15;
            loginBtn.Rounding = true;
            loginBtn.RoundingInt = 70;
            loginBtn.Size = new Size(97, 44);
            loginBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            loginBtn.TabIndex = 5;
            loginBtn.Tag = "Cyber";
            loginBtn.TextButton = "Login";
            loginBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            loginBtn.Timer_Effect_1 = 5;
            loginBtn.Timer_RGB = 300;
            loginBtn.Click += loginBtn_Click;
            // 
            // registerBtn
            // 
            registerBtn.Alpha = 20;
            registerBtn.Anchor = AnchorStyles.Left;
            registerBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            registerBtn.BackColor = Color.Transparent;
            registerBtn.Background = true;
            registerBtn.Background_WidthPen = 0F;
            registerBtn.BackgroundPen = true;
            registerBtn.ColorBackground = Color.FromArgb(179, 229, 196);
            registerBtn.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            registerBtn.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            registerBtn.ColorBackground_Pen = Color.Gray;
            registerBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            registerBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            registerBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            registerBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            registerBtn.Effect_1 = true;
            registerBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            registerBtn.Effect_1_Transparency = 25;
            registerBtn.Effect_2 = true;
            registerBtn.Effect_2_ColorBackground = Color.White;
            registerBtn.Effect_2_Transparency = 20;
            registerBtn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerBtn.ForeColor = Color.FromArgb(245, 245, 245);
            registerBtn.Lighting = false;
            registerBtn.LinearGradient_Background = false;
            registerBtn.LinearGradientPen = false;
            registerBtn.Location = new Point(160, 587);
            registerBtn.Name = "registerBtn";
            registerBtn.PenWidth = 15;
            registerBtn.Rounding = true;
            registerBtn.RoundingInt = 70;
            registerBtn.Size = new Size(112, 55);
            registerBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            registerBtn.TabIndex = 6;
            registerBtn.Tag = "Cyber";
            registerBtn.TextButton = "Registrar";
            registerBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            registerBtn.Timer_Effect_1 = 5;
            registerBtn.Timer_RGB = 300;
            registerBtn.Click += registerBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.initial_image;
            pictureBox1.Location = new Point(-1250, 95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.initial_image;
            pictureBox2.Location = new Point(1034, 209);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(657, 684);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // InitialForm
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderColor = Color.DarkSlateBlue;
            ClientSize = new Size(1920, 1080);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(registerBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            HeaderColor = Color.FromArgb(126, 87, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = Properties.Resources.bookly;
            Name = "InitialForm";
            Text = "Bookly";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private ReaLTaiizor.Controls.CyberButton loginBtn;
        private ReaLTaiizor.Controls.CyberButton registerBtn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}