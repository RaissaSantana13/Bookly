namespace Bookly.App.Register
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            txtTitle = new ReaLTaiizor.Controls.HopeTextBox();
            txtYear = new ReaLTaiizor.Controls.HopeTextBox();
            txtPages = new ReaLTaiizor.Controls.HopeTextBox();
            clbAuthors = new CheckedListBox();
            clbGenres = new CheckedListBox();
            cbStatus = new ReaLTaiizor.Controls.HopeComboBox();
            btnNewAuthor = new ReaLTaiizor.Controls.CyberButton();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(569, 238);
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(679, 238);
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.FromArgb(209, 186, 255);
            txtTitle.BaseColor = Color.FromArgb(44, 55, 66);
            txtTitle.BorderColorA = Color.FromArgb(64, 158, 255);
            txtTitle.BorderColorB = Color.FromArgb(220, 223, 230);
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.ForeColor = Color.FromArgb(48, 49, 51);
            txtTitle.Hint = "Title";
            txtTitle.Location = new Point(31, 69);
            txtTitle.MaxLength = 32767;
            txtTitle.Multiline = false;
            txtTitle.Name = "txtTitle";
            txtTitle.PasswordChar = '\0';
            txtTitle.ScrollBars = ScrollBars.None;
            txtTitle.SelectedText = "";
            txtTitle.SelectionLength = 0;
            txtTitle.SelectionStart = 0;
            txtTitle.Size = new Size(409, 38);
            txtTitle.TabIndex = 9;
            txtTitle.TabStop = false;
            txtTitle.UseSystemPasswordChar = false;
            // 
            // txtYear
            // 
            txtYear.BackColor = Color.FromArgb(209, 186, 255);
            txtYear.BaseColor = Color.FromArgb(44, 55, 66);
            txtYear.BorderColorA = Color.FromArgb(64, 158, 255);
            txtYear.BorderColorB = Color.FromArgb(220, 223, 230);
            txtYear.Font = new Font("Segoe UI", 12F);
            txtYear.ForeColor = Color.FromArgb(48, 49, 51);
            txtYear.Hint = "Year";
            txtYear.Location = new Point(618, 69);
            txtYear.MaxLength = 32767;
            txtYear.Multiline = false;
            txtYear.Name = "txtYear";
            txtYear.PasswordChar = '\0';
            txtYear.ScrollBars = ScrollBars.None;
            txtYear.SelectedText = "";
            txtYear.SelectionLength = 0;
            txtYear.SelectionStart = 0;
            txtYear.Size = new Size(75, 38);
            txtYear.TabIndex = 10;
            txtYear.TabStop = false;
            txtYear.UseSystemPasswordChar = false;
            // 
            // txtPages
            // 
            txtPages.BackColor = Color.FromArgb(209, 186, 255);
            txtPages.BaseColor = Color.FromArgb(44, 55, 66);
            txtPages.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPages.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPages.Font = new Font("Segoe UI", 12F);
            txtPages.ForeColor = Color.FromArgb(48, 49, 51);
            txtPages.Hint = "Number of Pages";
            txtPages.Location = new Point(457, 69);
            txtPages.MaxLength = 32767;
            txtPages.Multiline = false;
            txtPages.Name = "txtPages";
            txtPages.PasswordChar = '\0';
            txtPages.ScrollBars = ScrollBars.None;
            txtPages.SelectedText = "";
            txtPages.SelectionLength = 0;
            txtPages.SelectionStart = 0;
            txtPages.Size = new Size(147, 38);
            txtPages.TabIndex = 11;
            txtPages.TabStop = false;
            txtPages.UseSystemPasswordChar = false;
            // 
            // clbAuthors
            // 
            clbAuthors.BackColor = Color.FromArgb(209, 186, 255);
            clbAuthors.FormattingEnabled = true;
            clbAuthors.Location = new Point(473, 147);
            clbAuthors.Name = "clbAuthors";
            clbAuthors.Size = new Size(241, 28);
            clbAuthors.TabIndex = 12;
            // 
            // clbGenres
            // 
            clbGenres.BackColor = Color.FromArgb(209, 186, 255);
            clbGenres.CheckOnClick = true;
            clbGenres.FormattingEnabled = true;
            clbGenres.Location = new Point(31, 147);
            clbGenres.Name = "clbGenres";
            clbGenres.Size = new Size(247, 28);
            clbGenres.TabIndex = 13;
            clbGenres.Tag = "";
            // 
            // cbStatus
            // 
            cbStatus.BackColor = Color.FromArgb(209, 186, 255);
            cbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbStatus.FlatStyle = FlatStyle.Flat;
            cbStatus.Font = new Font("Segoe UI", 12F);
            cbStatus.FormattingEnabled = true;
            cbStatus.ItemHeight = 30;
            cbStatus.Location = new Point(320, 144);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(121, 36);
            cbStatus.TabIndex = 14;
            // 
            // btnNewAuthor
            // 
            btnNewAuthor.Alpha = 20;
            btnNewAuthor.Anchor = AnchorStyles.Left;
            btnNewAuthor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNewAuthor.BackColor = Color.Transparent;
            btnNewAuthor.Background = true;
            btnNewAuthor.Background_WidthPen = 1F;
            btnNewAuthor.BackgroundPen = true;
            btnNewAuthor.ColorBackground = Color.FromArgb(146, 227, 169);
            btnNewAuthor.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            btnNewAuthor.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            btnNewAuthor.ColorBackground_Pen = Color.Gray;
            btnNewAuthor.ColorLighting = Color.FromArgb(29, 200, 238);
            btnNewAuthor.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnNewAuthor.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnNewAuthor.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnNewAuthor.Effect_1 = true;
            btnNewAuthor.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnNewAuthor.Effect_1_Transparency = 25;
            btnNewAuthor.Effect_2 = true;
            btnNewAuthor.Effect_2_ColorBackground = Color.White;
            btnNewAuthor.Effect_2_Transparency = 20;
            btnNewAuthor.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewAuthor.ForeColor = Color.FromArgb(245, 245, 245);
            btnNewAuthor.Lighting = false;
            btnNewAuthor.LinearGradient_Background = false;
            btnNewAuthor.LinearGradientPen = false;
            btnNewAuthor.Location = new Point(720, 145);
            btnNewAuthor.Name = "btnNewAuthor";
            btnNewAuthor.PenWidth = 15;
            btnNewAuthor.Rounding = true;
            btnNewAuthor.RoundingInt = 70;
            btnNewAuthor.Size = new Size(27, 30);
            btnNewAuthor.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnNewAuthor.TabIndex = 15;
            btnNewAuthor.Tag = "Cyber";
            btnNewAuthor.TextButton = "+";
            btnNewAuthor.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnNewAuthor.Timer_Effect_1 = 5;
            btnNewAuthor.Timer_RGB = 300;
            btnNewAuthor.Click += btnNewAuthor_Click;
            // 
            // txtId
            // 
            txtId.BackColor = Color.FromArgb(209, 186, 255);
            txtId.BaseColor = Color.FromArgb(44, 55, 66);
            txtId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "Id";
            txtId.Location = new Point(720, 69);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(75, 38);
            txtId.TabIndex = 16;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 302);
            Controls.Add(txtId);
            Controls.Add(btnNewAuthor);
            Controls.Add(cbStatus);
            Controls.Add(clbGenres);
            Controls.Add(clbAuthors);
            Controls.Add(txtPages);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BookForm";
            Text = "Cadastrar Livro";
            MdiChildActivate += btnNewAuthor_Click;
            Controls.SetChildIndex(saveBtn, 0);
            Controls.SetChildIndex(cancelBtn, 0);
            Controls.SetChildIndex(txtTitle, 0);
            Controls.SetChildIndex(txtYear, 0);
            Controls.SetChildIndex(txtPages, 0);
            Controls.SetChildIndex(clbAuthors, 0);
            Controls.SetChildIndex(clbGenres, 0);
            Controls.SetChildIndex(cbStatus, 0);
            Controls.SetChildIndex(btnNewAuthor, 0);
            Controls.SetChildIndex(txtId, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtTitle;
        private ReaLTaiizor.Controls.HopeTextBox txtYear;
        private ReaLTaiizor.Controls.HopeTextBox txtPages;
        private CheckedListBox clbAuthors;
        private CheckedListBox clbGenres;
        private ReaLTaiizor.Controls.HopeComboBox cbStatus;
        private ReaLTaiizor.Controls.CyberButton btnNewAuthor;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
    }
}