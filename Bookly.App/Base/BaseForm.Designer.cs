namespace Bookly.App.Base
{
    partial class BaseForm
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
            saveBtn = new ReaLTaiizor.Controls.CyberButton();
            cancelBtn = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Alpha = 20;
            saveBtn.Anchor = AnchorStyles.Bottom;
            saveBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveBtn.BackColor = Color.Transparent;
            saveBtn.Background = true;
            saveBtn.Background_WidthPen = 0F;
            saveBtn.BackgroundPen = true;
            saveBtn.ColorBackground = Color.FromArgb(179, 229, 196);
            saveBtn.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            saveBtn.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            saveBtn.ColorBackground_Pen = Color.Gray;
            saveBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            saveBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            saveBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            saveBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            saveBtn.Effect_1 = true;
            saveBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            saveBtn.Effect_1_Transparency = 25;
            saveBtn.Effect_2 = true;
            saveBtn.Effect_2_ColorBackground = Color.White;
            saveBtn.Effect_2_Transparency = 20;
            saveBtn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.FromArgb(245, 245, 245);
            saveBtn.Lighting = false;
            saveBtn.LinearGradient_Background = false;
            saveBtn.LinearGradientPen = false;
            saveBtn.Location = new Point(541, 386);
            saveBtn.Name = "saveBtn";
            saveBtn.PenWidth = 15;
            saveBtn.Rounding = true;
            saveBtn.RoundingInt = 70;
            saveBtn.Size = new Size(89, 40);
            saveBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            saveBtn.TabIndex = 7;
            saveBtn.Tag = "Cyber";
            saveBtn.TextButton = "Save";
            saveBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            saveBtn.Timer_Effect_1 = 5;
            saveBtn.Timer_RGB = 300;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Alpha = 20;
            cancelBtn.Anchor = AnchorStyles.Bottom;
            cancelBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelBtn.BackColor = Color.Transparent;
            cancelBtn.Background = true;
            cancelBtn.Background_WidthPen = 0F;
            cancelBtn.BackgroundPen = true;
            cancelBtn.ColorBackground = Color.FromArgb(179, 229, 196);
            cancelBtn.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cancelBtn.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cancelBtn.ColorBackground_Pen = Color.Gray;
            cancelBtn.ColorLighting = Color.FromArgb(29, 200, 238);
            cancelBtn.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cancelBtn.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cancelBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cancelBtn.Effect_1 = true;
            cancelBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cancelBtn.Effect_1_Transparency = 25;
            cancelBtn.Effect_2 = true;
            cancelBtn.Effect_2_ColorBackground = Color.White;
            cancelBtn.Effect_2_Transparency = 20;
            cancelBtn.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = Color.FromArgb(245, 245, 245);
            cancelBtn.Lighting = false;
            cancelBtn.LinearGradient_Background = false;
            cancelBtn.LinearGradientPen = false;
            cancelBtn.Location = new Point(651, 386);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.PenWidth = 15;
            cancelBtn.Rounding = true;
            cancelBtn.RoundingInt = 70;
            cancelBtn.Size = new Size(89, 40);
            cancelBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cancelBtn.TabIndex = 8;
            cancelBtn.Tag = "Cyber";
            cancelBtn.TextButton = "Cancel";
            cancelBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cancelBtn.Timer_Effect_1 = 5;
            cancelBtn.Timer_RGB = 300;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 38);
            BorderColor = Color.DarkSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            HeaderColor = Color.FromArgb(126, 87, 194);
            Image = null;
            Name = "BaseForm";
            Text = "BaseForm";
            ResumeLayout(false);
        }

        #endregion

        protected ReaLTaiizor.Controls.CyberButton saveBtn;
        protected ReaLTaiizor.Controls.CyberButton cancelBtn;
    }
}