namespace Bookly.App.Register
{
    partial class ReadingSessionForm
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
            txtPagesRead = new ReaLTaiizor.Controls.HopeTextBox();
            txtDate = new ReaLTaiizor.Controls.HopeTextBox();
            txtId = new ReaLTaiizor.Controls.HopeTextBox();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(497, 119);
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(607, 119);
            // 
            // txtPagesRead
            // 
            txtPagesRead.BackColor = Color.FromArgb(209, 186, 255);
            txtPagesRead.BaseColor = Color.FromArgb(44, 55, 66);
            txtPagesRead.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPagesRead.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPagesRead.Font = new Font("Segoe UI", 12F);
            txtPagesRead.ForeColor = Color.FromArgb(48, 49, 51);
            txtPagesRead.Hint = "Number of Pages Read";
            txtPagesRead.Location = new Point(26, 58);
            txtPagesRead.MaxLength = 32767;
            txtPagesRead.Multiline = false;
            txtPagesRead.Name = "txtPagesRead";
            txtPagesRead.PasswordChar = '\0';
            txtPagesRead.ScrollBars = ScrollBars.None;
            txtPagesRead.SelectedText = "";
            txtPagesRead.SelectionLength = 0;
            txtPagesRead.SelectionStart = 0;
            txtPagesRead.Size = new Size(201, 38);
            txtPagesRead.TabIndex = 10;
            txtPagesRead.TabStop = false;
            txtPagesRead.UseSystemPasswordChar = false;
            // 
            // txtDate
            // 
            txtDate.BackColor = Color.FromArgb(209, 186, 255);
            txtDate.BaseColor = Color.FromArgb(44, 55, 66);
            txtDate.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDate.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDate.Font = new Font("Segoe UI", 12F);
            txtDate.ForeColor = Color.FromArgb(48, 49, 51);
            txtDate.Hint = "Date";
            txtDate.Location = new Point(284, 58);
            txtDate.MaxLength = 32767;
            txtDate.Multiline = false;
            txtDate.Name = "txtDate";
            txtDate.PasswordChar = '\0';
            txtDate.ScrollBars = ScrollBars.None;
            txtDate.SelectedText = "";
            txtDate.SelectionLength = 0;
            txtDate.SelectionStart = 0;
            txtDate.Size = new Size(148, 38);
            txtDate.TabIndex = 11;
            txtDate.TabStop = false;
            txtDate.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(480, 58);
            txtId.MaxLength = 32767;
            txtId.Multiline = false;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.ScrollBars = ScrollBars.None;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.Size = new Size(148, 38);
            txtId.TabIndex = 12;
            txtId.TabStop = false;
            txtId.UseSystemPasswordChar = false;
            // 
            // ReadingSessionForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 183);
            Controls.Add(txtId);
            Controls.Add(txtDate);
            Controls.Add(txtPagesRead);
            Name = "ReadingSessionForm";
            Text = "ReadingSessionForm";
            Controls.SetChildIndex(saveBtn, 0);
            Controls.SetChildIndex(cancelBtn, 0);
            Controls.SetChildIndex(txtPagesRead, 0);
            Controls.SetChildIndex(txtDate, 0);
            Controls.SetChildIndex(txtId, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtPagesRead;
        private ReaLTaiizor.Controls.HopeTextBox txtDate;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
    }
}