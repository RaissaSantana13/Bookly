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
            txtTitle = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            txtPages = new ReaLTaiizor.Controls.HopeTextBox();
            clbAuhtors = new CheckedListBox();
            clbGenres = new CheckedListBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(541, 256);
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(651, 256);
            // 
            // txtTitle
            // 
            txtTitle.BackColor = Color.White;
            txtTitle.BaseColor = Color.FromArgb(44, 55, 66);
            txtTitle.BorderColorA = Color.FromArgb(64, 158, 255);
            txtTitle.BorderColorB = Color.FromArgb(220, 223, 230);
            txtTitle.Font = new Font("Segoe UI", 12F);
            txtTitle.ForeColor = Color.FromArgb(48, 49, 51);
            txtTitle.Hint = "Titulo";
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
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "Ano";
            hopeTextBox2.Location = new Point(639, 69);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(75, 38);
            hopeTextBox2.TabIndex = 10;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // txtPages
            // 
            txtPages.BackColor = Color.White;
            txtPages.BaseColor = Color.FromArgb(44, 55, 66);
            txtPages.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPages.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPages.Font = new Font("Segoe UI", 12F);
            txtPages.ForeColor = Color.FromArgb(48, 49, 51);
            txtPages.Hint = "Nº de Paginas";
            txtPages.Location = new Point(483, 69);
            txtPages.MaxLength = 32767;
            txtPages.Multiline = false;
            txtPages.Name = "txtPages";
            txtPages.PasswordChar = '\0';
            txtPages.ScrollBars = ScrollBars.None;
            txtPages.SelectedText = "";
            txtPages.SelectionLength = 0;
            txtPages.SelectionStart = 0;
            txtPages.Size = new Size(128, 38);
            txtPages.TabIndex = 11;
            txtPages.TabStop = false;
            txtPages.UseSystemPasswordChar = false;
            // 
            // clbAuhtors
            // 
            clbAuhtors.FormattingEnabled = true;
            clbAuhtors.Location = new Point(473, 147);
            clbAuhtors.Name = "clbAuhtors";
            clbAuhtors.Size = new Size(241, 28);
            clbAuhtors.TabIndex = 12;
            // 
            // clbGenres
            // 
            clbGenres.CheckOnClick = true;
            clbGenres.FormattingEnabled = true;
            clbGenres.Location = new Point(31, 147);
            clbGenres.Name = "clbGenres";
            clbGenres.Size = new Size(247, 28);
            clbGenres.TabIndex = 13;
            clbGenres.Tag = "";
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 320);
            Controls.Add(clbGenres);
            Controls.Add(clbAuhtors);
            Controls.Add(txtPages);
            Controls.Add(hopeTextBox2);
            Controls.Add(txtTitle);
            Name = "BookForm";
            Text = "Cadastrar Livro";
            Controls.SetChildIndex(saveBtn, 0);
            Controls.SetChildIndex(cancelBtn, 0);
            Controls.SetChildIndex(txtTitle, 0);
            Controls.SetChildIndex(hopeTextBox2, 0);
            Controls.SetChildIndex(txtPages, 0);
            Controls.SetChildIndex(clbAuhtors, 0);
            Controls.SetChildIndex(clbGenres, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtTitle;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.HopeTextBox txtPages;
        private CheckedListBox clbAuhtors;
        private CheckedListBox clbGenres;
    }
}