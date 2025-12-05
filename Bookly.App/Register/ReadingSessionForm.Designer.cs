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
            txtData = new ReaLTaiizor.Controls.HopeTextBox();
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
            txtPagesRead.Hint = "Numero de Paginas Lidas";
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
            // txtData
            // 
            txtData.BackColor = Color.FromArgb(209, 186, 255);
            txtData.BaseColor = Color.FromArgb(44, 55, 66);
            txtData.BorderColorA = Color.FromArgb(64, 158, 255);
            txtData.BorderColorB = Color.FromArgb(220, 223, 230);
            txtData.Font = new Font("Segoe UI", 12F);
            txtData.ForeColor = Color.FromArgb(48, 49, 51);
            txtData.Hint = "Data";
            txtData.Location = new Point(284, 58);
            txtData.MaxLength = 32767;
            txtData.Multiline = false;
            txtData.Name = "txtData";
            txtData.PasswordChar = '\0';
            txtData.ScrollBars = ScrollBars.None;
            txtData.SelectedText = "";
            txtData.SelectionLength = 0;
            txtData.SelectionStart = 0;
            txtData.Size = new Size(148, 38);
            txtData.TabIndex = 11;
            txtData.TabStop = false;
            txtData.UseSystemPasswordChar = false;
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
            Controls.Add(txtData);
            Controls.Add(txtPagesRead);
            Name = "ReadingSessionForm";
            Text = "ReadingSessionForm";
            Controls.SetChildIndex(saveBtn, 0);
            Controls.SetChildIndex(cancelBtn, 0);
            Controls.SetChildIndex(txtPagesRead, 0);
            Controls.SetChildIndex(txtData, 0);
            Controls.SetChildIndex(txtId, 0);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtPagesRead;
        private ReaLTaiizor.Controls.HopeTextBox txtData;
        private ReaLTaiizor.Controls.HopeTextBox txtId;
    }
}