namespace Bookly.App.Register
{
    partial class AuthorForm
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
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.FromArgb(44, 55, 66);
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "Nome";
            txtName.Location = new Point(26, 62);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(501, 38);
            txtName.TabIndex = 9;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtId
            // 
            txtId.BackColor = Color.White;
            txtId.BaseColor = Color.FromArgb(44, 55, 66);
            txtId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.ForeColor = Color.FromArgb(48, 49, 51);
            txtId.Hint = "Id";
            txtId.Location = new Point(588, 62);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(70, 38);
            txtId.TabIndex = 10;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 222);
            Controls.Add(txtId);
            Controls.Add(txtName);
            Name = "AuthorForm";
            Text = "Registrar Autor";
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtId, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
    }
}