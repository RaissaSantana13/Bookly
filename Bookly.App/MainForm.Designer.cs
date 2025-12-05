namespace Bookly.App
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            airTabPage1 = new ReaLTaiizor.Controls.AirTabPage();
            tabPage1 = new TabPage();
            tbLibary = new TabPage();
            grpCompleted = new ReaLTaiizor.Controls.HopeGroupBox();
            lstCompleted = new ReaLTaiizor.Controls.PoisonListView();
            chTitle2 = new ColumnHeader();
            chAuthor2 = new ColumnHeader();
            chData = new ColumnHeader();
            grpInProgress = new ReaLTaiizor.Controls.HopeGroupBox();
            lstInProgress = new ReaLTaiizor.Controls.PoisonListView();
            chTitle = new ColumnHeader();
            chAuthor = new ColumnHeader();
            chProgress = new ColumnHeader();
            chPercentage = new ColumnHeader();
            btnExcluir = new ReaLTaiizor.Controls.CyberButton();
            btnAdd = new ReaLTaiizor.Controls.CyberButton();
            btnReadingSession = new ReaLTaiizor.Controls.CyberButton();
            label3 = new Label();
            label1 = new Label();
            tabPage3 = new TabPage();
            imageList2 = new ImageList(components);
            imageList1 = new ImageList(components);
            airTabPage1.SuspendLayout();
            tbLibary.SuspendLayout();
            grpCompleted.SuspendLayout();
            grpInProgress.SuspendLayout();
            SuspendLayout();
            // 
            // airTabPage1
            // 
            airTabPage1.Alignment = TabAlignment.Left;
            airTabPage1.BaseColor = Color.FromArgb(126, 87, 194);
            airTabPage1.Controls.Add(tabPage1);
            airTabPage1.Controls.Add(tbLibary);
            airTabPage1.Controls.Add(tabPage3);
            airTabPage1.ImageList = imageList2;
            airTabPage1.ItemSize = new Size(50, 85);
            airTabPage1.Location = new Point(1, 33);
            airTabPage1.Multiline = true;
            airTabPage1.Name = "airTabPage1";
            airTabPage1.NormalTextColor = Color.DimGray;
            airTabPage1.SelectedIndex = 0;
            airTabPage1.SelectedTabBackColor = Color.FromArgb(30, 30, 38);
            airTabPage1.SelectedTextColor = Color.Black;
            airTabPage1.ShowOuterBorders = false;
            airTabPage1.Size = new Size(1365, 737);
            airTabPage1.SizeMode = TabSizeMode.Fixed;
            airTabPage1.SquareColor = Color.FromArgb(179, 229, 196);
            airTabPage1.TabCursor = Cursors.Hand;
            airTabPage1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(30, 30, 38);
            tabPage1.ImageIndex = 2;
            tabPage1.Location = new Point(89, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1272, 729);
            tabPage1.TabIndex = 0;
            // 
            // tbLibary
            // 
            tbLibary.BackColor = Color.FromArgb(30, 30, 38);
            tbLibary.Controls.Add(grpCompleted);
            tbLibary.Controls.Add(grpInProgress);
            tbLibary.Controls.Add(label3);
            tbLibary.Controls.Add(label1);
            tbLibary.ImageIndex = 0;
            tbLibary.Location = new Point(89, 4);
            tbLibary.Name = "tbLibary";
            tbLibary.Padding = new Padding(3);
            tbLibary.Size = new Size(1272, 729);
            tbLibary.TabIndex = 1;
            // 
            // grpCompleted
            // 
            grpCompleted.BackColor = Color.FromArgb(156, 133, 195);
            grpCompleted.BorderColor = Color.FromArgb(220, 223, 230);
            grpCompleted.Controls.Add(lstCompleted);
            grpCompleted.Font = new Font("Segoe UI", 12F);
            grpCompleted.ForeColor = Color.FromArgb(48, 49, 51);
            grpCompleted.LineColor = Color.FromArgb(220, 223, 230);
            grpCompleted.Location = new Point(48, 439);
            grpCompleted.Name = "grpCompleted";
            grpCompleted.ShowText = false;
            grpCompleted.Size = new Size(1099, 259);
            grpCompleted.TabIndex = 4;
            grpCompleted.TabStop = false;
            grpCompleted.Text = "hopeGroupBox2";
            grpCompleted.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // lstCompleted
            // 
            lstCompleted.BackColor = Color.FromArgb(156, 133, 195);
            lstCompleted.Columns.AddRange(new ColumnHeader[] { chTitle2, chAuthor2, chData });
            lstCompleted.Font = new Font("Segoe UI", 12F);
            lstCompleted.FullRowSelect = true;
            lstCompleted.HideSelection = true;
            lstCompleted.Location = new Point(20, 22);
            lstCompleted.Name = "lstCompleted";
            lstCompleted.OwnerDraw = true;
            lstCompleted.Size = new Size(1055, 219);
            lstCompleted.TabIndex = 12;
            lstCompleted.UseCompatibleStateImageBehavior = false;
            lstCompleted.UseSelectable = true;
            lstCompleted.View = View.Details;
            // 
            // chTitle2
            // 
            chTitle2.Text = "Titulo";
            chTitle2.Width = 500;
            // 
            // chAuthor2
            // 
            chAuthor2.Text = "Autor";
            chAuthor2.Width = 400;
            // 
            // chData
            // 
            chData.Text = "Data de Conclusao";
            chData.Width = 150;
            // 
            // grpInProgress
            // 
            grpInProgress.BackColor = Color.FromArgb(156, 133, 195);
            grpInProgress.BorderColor = Color.FromArgb(220, 223, 230);
            grpInProgress.Controls.Add(lstInProgress);
            grpInProgress.Controls.Add(btnExcluir);
            grpInProgress.Controls.Add(btnAdd);
            grpInProgress.Controls.Add(btnReadingSession);
            grpInProgress.Font = new Font("Segoe UI", 12F);
            grpInProgress.ForeColor = Color.FromArgb(48, 49, 51);
            grpInProgress.LineColor = Color.FromArgb(220, 223, 230);
            grpInProgress.Location = new Point(48, 88);
            grpInProgress.Name = "grpInProgress";
            grpInProgress.ShowText = false;
            grpInProgress.Size = new Size(1099, 280);
            grpInProgress.TabIndex = 3;
            grpInProgress.TabStop = false;
            grpInProgress.Text = "hopeGroupBox1";
            grpInProgress.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // lstInProgress
            // 
            lstInProgress.BackColor = Color.FromArgb(156, 133, 195);
            lstInProgress.Columns.AddRange(new ColumnHeader[] { chTitle, chAuthor, chProgress, chPercentage });
            lstInProgress.Font = new Font("Segoe UI", 12F);
            lstInProgress.FullRowSelect = true;
            lstInProgress.HideSelection = true;
            lstInProgress.Location = new Point(20, 15);
            lstInProgress.Name = "lstInProgress";
            lstInProgress.OwnerDraw = true;
            lstInProgress.Size = new Size(1055, 198);
            lstInProgress.TabIndex = 11;
            lstInProgress.Theme = ReaLTaiizor.Enum.Poison.ThemeStyle.Dark;
            lstInProgress.UseCompatibleStateImageBehavior = false;
            lstInProgress.UseSelectable = true;
            lstInProgress.View = View.Details;
            // 
            // chTitle
            // 
            chTitle.Text = "Titulo";
            chTitle.Width = 500;
            // 
            // chAuthor
            // 
            chAuthor.Text = "Autor";
            chAuthor.Width = 400;
            // 
            // chProgress
            // 
            chProgress.DisplayIndex = 3;
            chProgress.Text = "Progresso";
            chProgress.Width = 100;
            // 
            // chPercentage
            // 
            chPercentage.DisplayIndex = 2;
            chPercentage.Text = "%";
            // 
            // btnExcluir
            // 
            btnExcluir.Alpha = 20;
            btnExcluir.Anchor = AnchorStyles.Left;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.BackColor = Color.Transparent;
            btnExcluir.Background = true;
            btnExcluir.Background_WidthPen = 0F;
            btnExcluir.BackgroundPen = true;
            btnExcluir.ColorBackground = Color.FromArgb(179, 229, 196);
            btnExcluir.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            btnExcluir.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            btnExcluir.ColorBackground_Pen = Color.Gray;
            btnExcluir.ColorLighting = Color.FromArgb(29, 200, 238);
            btnExcluir.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnExcluir.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnExcluir.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnExcluir.Effect_1 = true;
            btnExcluir.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnExcluir.Effect_1_Transparency = 25;
            btnExcluir.Effect_2 = true;
            btnExcluir.Effect_2_ColorBackground = Color.White;
            btnExcluir.Effect_2_Transparency = 20;
            btnExcluir.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExcluir.ForeColor = Color.FromArgb(245, 245, 245);
            btnExcluir.Lighting = false;
            btnExcluir.LinearGradient_Background = false;
            btnExcluir.LinearGradientPen = false;
            btnExcluir.Location = new Point(965, 219);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.PenWidth = 15;
            btnExcluir.Rounding = true;
            btnExcluir.RoundingInt = 70;
            btnExcluir.Size = new Size(110, 43);
            btnExcluir.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnExcluir.TabIndex = 10;
            btnExcluir.Tag = "Cyber";
            btnExcluir.TextButton = "Excluir";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdd
            // 
            btnAdd.Alpha = 20;
            btnAdd.Anchor = AnchorStyles.Left;
            btnAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Background = true;
            btnAdd.Background_WidthPen = 0F;
            btnAdd.BackgroundPen = true;
            btnAdd.ColorBackground = Color.FromArgb(179, 229, 196);
            btnAdd.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            btnAdd.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            btnAdd.ColorBackground_Pen = Color.Gray;
            btnAdd.ColorLighting = Color.FromArgb(29, 200, 238);
            btnAdd.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnAdd.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnAdd.Effect_1 = true;
            btnAdd.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnAdd.Effect_1_Transparency = 25;
            btnAdd.Effect_2 = true;
            btnAdd.Effect_2_ColorBackground = Color.White;
            btnAdd.Effect_2_Transparency = 20;
            btnAdd.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.FromArgb(245, 245, 245);
            btnAdd.Lighting = false;
            btnAdd.LinearGradient_Background = false;
            btnAdd.LinearGradientPen = false;
            btnAdd.Location = new Point(837, 219);
            btnAdd.Name = "btnAdd";
            btnAdd.PenWidth = 15;
            btnAdd.Rounding = true;
            btnAdd.RoundingInt = 70;
            btnAdd.Size = new Size(110, 43);
            btnAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 8;
            btnAdd.Tag = "Cyber";
            btnAdd.TextButton = "Adicionar";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReadingSession
            // 
            btnReadingSession.Alpha = 20;
            btnReadingSession.Anchor = AnchorStyles.Left;
            btnReadingSession.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnReadingSession.BackColor = Color.Transparent;
            btnReadingSession.Background = true;
            btnReadingSession.Background_WidthPen = 0F;
            btnReadingSession.BackgroundPen = true;
            btnReadingSession.ColorBackground = Color.FromArgb(179, 229, 196);
            btnReadingSession.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            btnReadingSession.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            btnReadingSession.ColorBackground_Pen = Color.Gray;
            btnReadingSession.ColorLighting = Color.FromArgb(29, 200, 238);
            btnReadingSession.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnReadingSession.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnReadingSession.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnReadingSession.Effect_1 = true;
            btnReadingSession.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnReadingSession.Effect_1_Transparency = 25;
            btnReadingSession.Effect_2 = true;
            btnReadingSession.Effect_2_ColorBackground = Color.White;
            btnReadingSession.Effect_2_Transparency = 20;
            btnReadingSession.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadingSession.ForeColor = Color.FromArgb(245, 245, 245);
            btnReadingSession.Lighting = false;
            btnReadingSession.LinearGradient_Background = false;
            btnReadingSession.LinearGradientPen = false;
            btnReadingSession.Location = new Point(561, 219);
            btnReadingSession.Name = "btnReadingSession";
            btnReadingSession.PenWidth = 15;
            btnReadingSession.Rounding = true;
            btnReadingSession.RoundingInt = 70;
            btnReadingSession.Size = new Size(259, 43);
            btnReadingSession.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnReadingSession.TabIndex = 7;
            btnReadingSession.Tag = "Cyber";
            btnReadingSession.TextButton = "Registrar Sessão de Leitura";
            btnReadingSession.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnReadingSession.Timer_Effect_1 = 5;
            btnReadingSession.Timer_RGB = 300;
            btnReadingSession.Click += btnReadingSession_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(179, 229, 196);
            label3.Location = new Point(48, 371);
            label3.Name = "label3";
            label3.Size = new Size(359, 49);
            label3.TabIndex = 2;
            label3.Text = "Livros concluidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(179, 229, 196);
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(265, 49);
            label1.TabIndex = 0;
            label1.Text = "Lendo agora:";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(30, 30, 38);
            tabPage3.ImageIndex = 1;
            tabPage3.Location = new Point(89, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1272, 729);
            tabPage3.TabIndex = 2;
            tabPage3.Click += tabPage3_Click;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "books.png");
            imageList2.Images.SetKeyName(1, "exit.png");
            imageList2.Images.SetKeyName(2, "home.png");
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 38);
            BorderColor = Color.DarkSlateBlue;
            ClientSize = new Size(1366, 768);
            Controls.Add(airTabPage1);
            HeaderColor = Color.FromArgb(126, 87, 194);
            Image = null;
            Name = "MainForm";
            Text = "Bookly";
            airTabPage1.ResumeLayout(false);
            tbLibary.ResumeLayout(false);
            tbLibary.PerformLayout();
            grpCompleted.ResumeLayout(false);
            grpInProgress.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.AirTabPage airTabPage1;
        private TabPage tabPage1;
        private TabPage tbLibary;
        private ImageList imageList2;
        private ImageList imageList1;
        private TabPage tabPage3;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.HopeGroupBox grpCompleted;
        private ReaLTaiizor.Controls.HopeGroupBox grpInProgress;
        private ReaLTaiizor.Controls.CyberButton btnExcluir;
        private ReaLTaiizor.Controls.CyberButton btnAdd;
        private ReaLTaiizor.Controls.CyberButton btnReadingSession;
        private ReaLTaiizor.Controls.PoisonListView lstCompleted;
        private ReaLTaiizor.Controls.PoisonListView lstInProgress;
        private ColumnHeader chTitle;
        private ColumnHeader chAuthor;
        private ColumnHeader chProgress;
        private ColumnHeader chPercentage;
        private ColumnHeader chTitle2;
        private ColumnHeader chAuthor2;
        private ColumnHeader chData;
    }
}
