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
            tabPageMain = new ReaLTaiizor.Controls.AirTabPage();
            tabHome = new TabPage();
            hopeGroupBox4 = new ReaLTaiizor.Controls.HopeGroupBox();
            plotDaysMonth = new ScottPlot.WinForms.FormsPlot();
            label7 = new Label();
            hopeGroupBox3 = new ReaLTaiizor.Controls.HopeGroupBox();
            label6 = new Label();
            lblDays = new Label();
            label8 = new Label();
            cyberButton7 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton8 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton9 = new ReaLTaiizor.Controls.CyberButton();
            hopeGroupBox2 = new ReaLTaiizor.Controls.HopeGroupBox();
            label4 = new Label();
            lblWeek = new Label();
            label5 = new Label();
            cyberButton4 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton5 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton6 = new ReaLTaiizor.Controls.CyberButton();
            hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            lblBookYear = new Label();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            label2 = new Label();
            tabLibary = new TabPage();
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
            tabClose = new TabPage();
            imageList2 = new ImageList(components);
            imageList1 = new ImageList(components);
            tabPageMain.SuspendLayout();
            tabHome.SuspendLayout();
            hopeGroupBox4.SuspendLayout();
            hopeGroupBox3.SuspendLayout();
            hopeGroupBox2.SuspendLayout();
            hopeGroupBox1.SuspendLayout();
            tabLibary.SuspendLayout();
            grpCompleted.SuspendLayout();
            grpInProgress.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageMain
            // 
            tabPageMain.Alignment = TabAlignment.Left;
            tabPageMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabPageMain.BaseColor = Color.FromArgb(126, 87, 194);
            tabPageMain.Controls.Add(tabHome);
            tabPageMain.Controls.Add(tabLibary);
            tabPageMain.Controls.Add(tabClose);
            tabPageMain.ImageList = imageList2;
            tabPageMain.ItemSize = new Size(50, 85);
            tabPageMain.Location = new Point(1, 33);
            tabPageMain.Multiline = true;
            tabPageMain.Name = "tabPageMain";
            tabPageMain.NormalTextColor = Color.DimGray;
            tabPageMain.SelectedIndex = 0;
            tabPageMain.SelectedTabBackColor = Color.FromArgb(30, 30, 38);
            tabPageMain.SelectedTextColor = Color.Black;
            tabPageMain.ShowOuterBorders = false;
            tabPageMain.Size = new Size(1365, 737);
            tabPageMain.SizeMode = TabSizeMode.Fixed;
            tabPageMain.SquareColor = Color.FromArgb(179, 229, 196);
            tabPageMain.TabCursor = Cursors.Hand;
            tabPageMain.TabIndex = 0;
            tabPageMain.SelectedIndexChanged += tabPageMain_Click;
            // 
            // tabHome
            // 
            tabHome.AutoScroll = true;
            tabHome.AutoScrollMargin = new Size(10, 10);
            tabHome.AutoScrollMinSize = new Size(10, 10);
            tabHome.BackColor = Color.FromArgb(30, 30, 38);
            tabHome.Controls.Add(hopeGroupBox4);
            tabHome.Controls.Add(hopeGroupBox3);
            tabHome.Controls.Add(hopeGroupBox2);
            tabHome.Controls.Add(hopeGroupBox1);
            tabHome.Controls.Add(label2);
            tabHome.ImageIndex = 2;
            tabHome.Location = new Point(89, 4);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(1272, 729);
            tabHome.TabIndex = 0;
            // 
            // hopeGroupBox4
            // 
            hopeGroupBox4.BorderColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox4.Controls.Add(plotDaysMonth);
            hopeGroupBox4.Controls.Add(label7);
            hopeGroupBox4.Font = new Font("Segoe UI", 12F);
            hopeGroupBox4.ForeColor = Color.FromArgb(48, 49, 51);
            hopeGroupBox4.LineColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox4.Location = new Point(34, 646);
            hopeGroupBox4.Name = "hopeGroupBox4";
            hopeGroupBox4.ShowText = false;
            hopeGroupBox4.Size = new Size(1099, 381);
            hopeGroupBox4.TabIndex = 15;
            hopeGroupBox4.TabStop = false;
            hopeGroupBox4.Text = "hopeGroupBox4";
            hopeGroupBox4.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // plotDaysMonth
            // 
            plotDaysMonth.DisplayScale = 1F;
            plotDaysMonth.Location = new Point(49, 89);
            plotDaysMonth.Name = "plotDaysMonth";
            plotDaysMonth.Size = new Size(1011, 269);
            plotDaysMonth.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(46, 46, 58);
            label7.Location = new Point(259, 25);
            label7.Name = "label7";
            label7.Size = new Size(585, 61);
            label7.TabIndex = 14;
            label7.Text = "Reading days per month:";
            // 
            // hopeGroupBox3
            // 
            hopeGroupBox3.BackColor = Color.White;
            hopeGroupBox3.BorderColor = Color.FromArgb(209, 186, 255);
            hopeGroupBox3.Controls.Add(label6);
            hopeGroupBox3.Controls.Add(lblDays);
            hopeGroupBox3.Controls.Add(label8);
            hopeGroupBox3.Controls.Add(cyberButton7);
            hopeGroupBox3.Controls.Add(cyberButton8);
            hopeGroupBox3.Controls.Add(cyberButton9);
            hopeGroupBox3.Font = new Font("Segoe UI", 12F);
            hopeGroupBox3.ForeColor = Color.Black;
            hopeGroupBox3.LineColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox3.Location = new Point(620, 288);
            hopeGroupBox3.Name = "hopeGroupBox3";
            hopeGroupBox3.ShowText = false;
            hopeGroupBox3.Size = new Size(489, 317);
            hopeGroupBox3.TabIndex = 14;
            hopeGroupBox3.TabStop = false;
            hopeGroupBox3.Text = "hopeGroupBox3";
            hopeGroupBox3.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(46, 46, 58);
            label6.Location = new Point(152, 194);
            label6.Name = "label6";
            label6.Size = new Size(172, 81);
            label6.TabIndex = 13;
            label6.Text = "Days";
            // 
            // lblDays
            // 
            lblDays.AutoSize = true;
            lblDays.BackColor = Color.Transparent;
            lblDays.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDays.ForeColor = Color.FromArgb(46, 46, 58);
            lblDays.Location = new Point(181, 97);
            lblDays.Name = "lblDays";
            lblDays.Size = new Size(0, 81);
            lblDays.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(46, 46, 58);
            label8.Location = new Point(103, 25);
            label8.Name = "label8";
            label8.Size = new Size(290, 37);
            label8.TabIndex = 5;
            label8.Text = "Record daily streak:";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyberButton7
            // 
            cyberButton7.Alpha = 20;
            cyberButton7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cyberButton7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton7.BackColor = Color.Transparent;
            cyberButton7.Background = true;
            cyberButton7.Background_WidthPen = 0F;
            cyberButton7.BackgroundPen = true;
            cyberButton7.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton7.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton7.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton7.ColorBackground_Pen = Color.Gray;
            cyberButton7.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton7.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton7.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton7.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton7.Effect_1 = true;
            cyberButton7.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton7.Effect_1_Transparency = 25;
            cyberButton7.Effect_2 = true;
            cyberButton7.Effect_2_ColorBackground = Color.White;
            cyberButton7.Effect_2_Transparency = 20;
            cyberButton7.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton7.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton7.Lighting = false;
            cyberButton7.LinearGradient_Background = false;
            cyberButton7.LinearGradientPen = false;
            cyberButton7.Location = new Point(965, 681);
            cyberButton7.Name = "cyberButton7";
            cyberButton7.PenWidth = 15;
            cyberButton7.Rounding = true;
            cyberButton7.RoundingInt = 70;
            cyberButton7.Size = new Size(110, 43);
            cyberButton7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton7.TabIndex = 10;
            cyberButton7.Tag = "Cyber";
            cyberButton7.TextButton = "Delete";
            cyberButton7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton7.Timer_Effect_1 = 5;
            cyberButton7.Timer_RGB = 300;
            // 
            // cyberButton8
            // 
            cyberButton8.Alpha = 20;
            cyberButton8.Anchor = AnchorStyles.Bottom;
            cyberButton8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton8.BackColor = Color.Transparent;
            cyberButton8.Background = true;
            cyberButton8.Background_WidthPen = 0F;
            cyberButton8.BackgroundPen = true;
            cyberButton8.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton8.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton8.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton8.ColorBackground_Pen = Color.Gray;
            cyberButton8.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton8.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton8.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton8.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton8.Effect_1 = true;
            cyberButton8.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton8.Effect_1_Transparency = 25;
            cyberButton8.Effect_2 = true;
            cyberButton8.Effect_2_ColorBackground = Color.White;
            cyberButton8.Effect_2_Transparency = 20;
            cyberButton8.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton8.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton8.Lighting = false;
            cyberButton8.LinearGradient_Background = false;
            cyberButton8.LinearGradientPen = false;
            cyberButton8.Location = new Point(1574, 681);
            cyberButton8.Name = "cyberButton8";
            cyberButton8.PenWidth = 15;
            cyberButton8.Rounding = true;
            cyberButton8.RoundingInt = 70;
            cyberButton8.Size = new Size(110, 43);
            cyberButton8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton8.TabIndex = 8;
            cyberButton8.Tag = "Cyber";
            cyberButton8.TextButton = "To add";
            cyberButton8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton8.Timer_Effect_1 = 5;
            cyberButton8.Timer_RGB = 300;
            // 
            // cyberButton9
            // 
            cyberButton9.Alpha = 20;
            cyberButton9.Anchor = AnchorStyles.Bottom;
            cyberButton9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton9.BackColor = Color.Transparent;
            cyberButton9.Background = true;
            cyberButton9.Background_WidthPen = 0F;
            cyberButton9.BackgroundPen = true;
            cyberButton9.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton9.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton9.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton9.ColorBackground_Pen = Color.Gray;
            cyberButton9.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton9.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton9.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton9.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton9.Effect_1 = true;
            cyberButton9.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton9.Effect_1_Transparency = 25;
            cyberButton9.Effect_2 = true;
            cyberButton9.Effect_2_ColorBackground = Color.White;
            cyberButton9.Effect_2_Transparency = 20;
            cyberButton9.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton9.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton9.Lighting = false;
            cyberButton9.LinearGradient_Background = false;
            cyberButton9.LinearGradientPen = false;
            cyberButton9.Location = new Point(1298, 681);
            cyberButton9.Name = "cyberButton9";
            cyberButton9.PenWidth = 15;
            cyberButton9.Rounding = true;
            cyberButton9.RoundingInt = 70;
            cyberButton9.Size = new Size(259, 43);
            cyberButton9.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton9.TabIndex = 7;
            cyberButton9.Tag = "Cyber";
            cyberButton9.TextButton = "Register Reading Session";
            cyberButton9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton9.Timer_Effect_1 = 5;
            cyberButton9.Timer_RGB = 300;
            // 
            // hopeGroupBox2
            // 
            hopeGroupBox2.BackColor = Color.White;
            hopeGroupBox2.BorderColor = Color.FromArgb(209, 186, 255);
            hopeGroupBox2.Controls.Add(label4);
            hopeGroupBox2.Controls.Add(lblWeek);
            hopeGroupBox2.Controls.Add(label5);
            hopeGroupBox2.Controls.Add(cyberButton4);
            hopeGroupBox2.Controls.Add(cyberButton5);
            hopeGroupBox2.Controls.Add(cyberButton6);
            hopeGroupBox2.Font = new Font("Segoe UI", 12F);
            hopeGroupBox2.ForeColor = Color.Black;
            hopeGroupBox2.LineColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox2.Location = new Point(63, 288);
            hopeGroupBox2.Name = "hopeGroupBox2";
            hopeGroupBox2.ShowText = false;
            hopeGroupBox2.Size = new Size(489, 317);
            hopeGroupBox2.TabIndex = 11;
            hopeGroupBox2.TabStop = false;
            hopeGroupBox2.Text = "hopeGroupBox2";
            hopeGroupBox2.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(46, 46, 58);
            label4.Location = new Point(112, 194);
            label4.Name = "label4";
            label4.Size = new Size(228, 81);
            label4.TabIndex = 13;
            label4.Text = "Weeks";
            // 
            // lblWeek
            // 
            lblWeek.AutoSize = true;
            lblWeek.BackColor = Color.Transparent;
            lblWeek.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeek.ForeColor = Color.FromArgb(46, 46, 58);
            lblWeek.Location = new Point(181, 97);
            lblWeek.Name = "lblWeek";
            lblWeek.Size = new Size(0, 81);
            lblWeek.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Trebuchet MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(46, 46, 58);
            label5.Location = new Point(82, 25);
            label5.Name = "label5";
            label5.Size = new Size(322, 37);
            label5.TabIndex = 5;
            label5.Text = "Record weekly streak:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyberButton4
            // 
            cyberButton4.Alpha = 20;
            cyberButton4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cyberButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton4.BackColor = Color.Transparent;
            cyberButton4.Background = true;
            cyberButton4.Background_WidthPen = 0F;
            cyberButton4.BackgroundPen = true;
            cyberButton4.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton4.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton4.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton4.ColorBackground_Pen = Color.Gray;
            cyberButton4.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton4.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton4.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton4.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton4.Effect_1 = true;
            cyberButton4.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton4.Effect_1_Transparency = 25;
            cyberButton4.Effect_2 = true;
            cyberButton4.Effect_2_ColorBackground = Color.White;
            cyberButton4.Effect_2_Transparency = 20;
            cyberButton4.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton4.Lighting = false;
            cyberButton4.LinearGradient_Background = false;
            cyberButton4.LinearGradientPen = false;
            cyberButton4.Location = new Point(965, 464);
            cyberButton4.Name = "cyberButton4";
            cyberButton4.PenWidth = 15;
            cyberButton4.Rounding = true;
            cyberButton4.RoundingInt = 70;
            cyberButton4.Size = new Size(110, 43);
            cyberButton4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton4.TabIndex = 10;
            cyberButton4.Tag = "Cyber";
            cyberButton4.TextButton = "Delete";
            cyberButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton4.Timer_Effect_1 = 5;
            cyberButton4.Timer_RGB = 300;
            // 
            // cyberButton5
            // 
            cyberButton5.Alpha = 20;
            cyberButton5.Anchor = AnchorStyles.Bottom;
            cyberButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton5.BackColor = Color.Transparent;
            cyberButton5.Background = true;
            cyberButton5.Background_WidthPen = 0F;
            cyberButton5.BackgroundPen = true;
            cyberButton5.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton5.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton5.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton5.ColorBackground_Pen = Color.Gray;
            cyberButton5.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton5.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton5.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton5.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton5.Effect_1 = true;
            cyberButton5.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton5.Effect_1_Transparency = 25;
            cyberButton5.Effect_2 = true;
            cyberButton5.Effect_2_ColorBackground = Color.White;
            cyberButton5.Effect_2_Transparency = 20;
            cyberButton5.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton5.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton5.Lighting = false;
            cyberButton5.LinearGradient_Background = false;
            cyberButton5.LinearGradientPen = false;
            cyberButton5.Location = new Point(1430, 464);
            cyberButton5.Name = "cyberButton5";
            cyberButton5.PenWidth = 15;
            cyberButton5.Rounding = true;
            cyberButton5.RoundingInt = 70;
            cyberButton5.Size = new Size(110, 43);
            cyberButton5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton5.TabIndex = 8;
            cyberButton5.Tag = "Cyber";
            cyberButton5.TextButton = "To add";
            cyberButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton5.Timer_Effect_1 = 5;
            cyberButton5.Timer_RGB = 300;
            // 
            // cyberButton6
            // 
            cyberButton6.Alpha = 20;
            cyberButton6.Anchor = AnchorStyles.Bottom;
            cyberButton6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton6.BackColor = Color.Transparent;
            cyberButton6.Background = true;
            cyberButton6.Background_WidthPen = 0F;
            cyberButton6.BackgroundPen = true;
            cyberButton6.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton6.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton6.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton6.ColorBackground_Pen = Color.Gray;
            cyberButton6.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton6.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton6.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton6.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton6.Effect_1 = true;
            cyberButton6.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton6.Effect_1_Transparency = 25;
            cyberButton6.Effect_2 = true;
            cyberButton6.Effect_2_ColorBackground = Color.White;
            cyberButton6.Effect_2_Transparency = 20;
            cyberButton6.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton6.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton6.Lighting = false;
            cyberButton6.LinearGradient_Background = false;
            cyberButton6.LinearGradientPen = false;
            cyberButton6.Location = new Point(1154, 464);
            cyberButton6.Name = "cyberButton6";
            cyberButton6.PenWidth = 15;
            cyberButton6.Rounding = true;
            cyberButton6.RoundingInt = 70;
            cyberButton6.Size = new Size(259, 43);
            cyberButton6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton6.TabIndex = 7;
            cyberButton6.Tag = "Cyber";
            cyberButton6.TextButton = "Register Reading Session";
            cyberButton6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton6.Timer_Effect_1 = 5;
            cyberButton6.Timer_RGB = 300;
            // 
            // hopeGroupBox1
            // 
            hopeGroupBox1.BackColor = Color.White;
            hopeGroupBox1.BorderColor = Color.FromArgb(209, 186, 255);
            hopeGroupBox1.Controls.Add(lblBookYear);
            hopeGroupBox1.Controls.Add(cyberButton1);
            hopeGroupBox1.Controls.Add(cyberButton3);
            hopeGroupBox1.Font = new Font("Segoe UI", 12F);
            hopeGroupBox1.ForeColor = Color.Black;
            hopeGroupBox1.LineColor = Color.FromArgb(220, 223, 230);
            hopeGroupBox1.Location = new Point(34, 108);
            hopeGroupBox1.Name = "hopeGroupBox1";
            hopeGroupBox1.ShowText = false;
            hopeGroupBox1.Size = new Size(1099, 128);
            hopeGroupBox1.TabIndex = 4;
            hopeGroupBox1.TabStop = false;
            hopeGroupBox1.Text = "hopeGroupBox1";
            hopeGroupBox1.ThemeColor = Color.FromArgb(156, 133, 195);
            // 
            // lblBookYear
            // 
            lblBookYear.AutoSize = true;
            lblBookYear.BackColor = Color.Transparent;
            lblBookYear.Font = new Font("Trebuchet MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBookYear.ForeColor = Color.FromArgb(46, 46, 58);
            lblBookYear.Location = new Point(130, 25);
            lblBookYear.Name = "lblBookYear";
            lblBookYear.Size = new Size(0, 81);
            lblBookYear.TabIndex = 5;
            lblBookYear.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cyberButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 0F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton1.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton1.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton1.ColorBackground_Pen = Color.Gray;
            cyberButton1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton1.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton1.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(965, 247);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(110, 43);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 10;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Delete";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.Anchor = AnchorStyles.Bottom;
            cyberButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 0F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.FromArgb(179, 229, 196);
            cyberButton3.ColorBackground_1 = Color.FromArgb(179, 229, 196);
            cyberButton3.ColorBackground_2 = Color.FromArgb(179, 229, 196);
            cyberButton3.ColorBackground_Pen = Color.Gray;
            cyberButton3.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberButton3.ColorPen_1 = Color.FromArgb(37, 52, 68);
            cyberButton3.ColorPen_2 = Color.FromArgb(41, 63, 86);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cyberButton3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(1010, 247);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(259, 43);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 7;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Register Reading Session";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(179, 229, 196);
            label2.Location = new Point(34, 27);
            label2.Name = "label2";
            label2.Size = new Size(249, 61);
            label2.TabIndex = 1;
            label2.Text = "Welcome!";
            // 
            // tabLibary
            // 
            tabLibary.BackColor = Color.FromArgb(30, 30, 38);
            tabLibary.Controls.Add(grpCompleted);
            tabLibary.Controls.Add(grpInProgress);
            tabLibary.Controls.Add(label3);
            tabLibary.Controls.Add(label1);
            tabLibary.ImageIndex = 0;
            tabLibary.Location = new Point(89, 4);
            tabLibary.Name = "tabLibary";
            tabLibary.Padding = new Padding(3);
            tabLibary.Size = new Size(1272, 729);
            tabLibary.TabIndex = 1;
            // 
            // grpCompleted
            // 
            grpCompleted.BackColor = Color.FromArgb(209, 186, 255);
            grpCompleted.BorderColor = Color.FromArgb(220, 223, 230);
            grpCompleted.Controls.Add(lstCompleted);
            grpCompleted.Font = new Font("Segoe UI", 12F);
            grpCompleted.ForeColor = Color.Black;
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
            lstCompleted.BackColor = Color.FromArgb(209, 186, 255);
            lstCompleted.Columns.AddRange(new ColumnHeader[] { chTitle2, chAuthor2, chData });
            lstCompleted.Font = new Font("Segoe UI", 12F);
            lstCompleted.FullRowSelect = true;
            lstCompleted.HideSelection = true;
            lstCompleted.Location = new Point(20, 22);
            lstCompleted.Name = "lstCompleted";
            lstCompleted.OwnerDraw = true;
            lstCompleted.Size = new Size(1055, 219);
            lstCompleted.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple;
            lstCompleted.TabIndex = 12;
            lstCompleted.UseCompatibleStateImageBehavior = false;
            lstCompleted.UseCustomForeColor = true;
            lstCompleted.UseSelectable = true;
            lstCompleted.View = View.Details;
            // 
            // chTitle2
            // 
            chTitle2.Text = "Title";
            chTitle2.Width = 500;
            // 
            // chAuthor2
            // 
            chAuthor2.Text = "Author";
            chAuthor2.Width = 400;
            // 
            // chData
            // 
            chData.Text = "Completion date";
            chData.Width = 150;
            // 
            // grpInProgress
            // 
            grpInProgress.BackColor = Color.White;
            grpInProgress.BorderColor = Color.FromArgb(209, 186, 255);
            grpInProgress.Controls.Add(lstInProgress);
            grpInProgress.Controls.Add(btnExcluir);
            grpInProgress.Controls.Add(btnAdd);
            grpInProgress.Controls.Add(btnReadingSession);
            grpInProgress.Font = new Font("Segoe UI", 12F);
            grpInProgress.ForeColor = Color.Black;
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
            lstInProgress.BackColor = Color.FromArgb(209, 186, 255);
            lstInProgress.Columns.AddRange(new ColumnHeader[] { chTitle, chAuthor, chProgress, chPercentage });
            lstInProgress.Font = new Font("Segoe UI", 12F);
            lstInProgress.ForeColor = SystemColors.InactiveCaptionText;
            lstInProgress.FullRowSelect = true;
            lstInProgress.HideSelection = true;
            lstInProgress.Location = new Point(20, 15);
            lstInProgress.Name = "lstInProgress";
            lstInProgress.OwnerDraw = true;
            lstInProgress.Size = new Size(1055, 198);
            lstInProgress.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Purple;
            lstInProgress.TabIndex = 11;
            lstInProgress.UseCompatibleStateImageBehavior = false;
            lstInProgress.UseCustomBackColor = true;
            lstInProgress.UseCustomForeColor = true;
            lstInProgress.UseSelectable = true;
            lstInProgress.View = View.Details;
            // 
            // chTitle
            // 
            chTitle.Text = "Title";
            chTitle.Width = 500;
            // 
            // chAuthor
            // 
            chAuthor.Text = "Author";
            chAuthor.Width = 400;
            // 
            // chProgress
            // 
            chProgress.DisplayIndex = 3;
            chProgress.Text = "Progress";
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
            btnExcluir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
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
            btnExcluir.TextButton = "Delete";
            btnExcluir.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnExcluir.Timer_Effect_1 = 5;
            btnExcluir.Timer_RGB = 300;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAdd
            // 
            btnAdd.Alpha = 20;
            btnAdd.Anchor = AnchorStyles.Bottom;
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
            btnAdd.TextButton = "To add";
            btnAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Timer_Effect_1 = 5;
            btnAdd.Timer_RGB = 300;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnReadingSession
            // 
            btnReadingSession.Alpha = 20;
            btnReadingSession.Anchor = AnchorStyles.Bottom;
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
            btnReadingSession.TextButton = "Register Reading Session";
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
            label3.Location = new Point(48, 387);
            label3.Name = "label3";
            label3.Size = new Size(335, 49);
            label3.TabIndex = 2;
            label3.Text = "Complete books:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(179, 229, 196);
            label1.Location = new Point(48, 25);
            label1.Name = "label1";
            label1.Size = new Size(274, 49);
            label1.TabIndex = 0;
            label1.Text = "Reading now:";
            // 
            // tabClose
            // 
            tabClose.BackColor = Color.FromArgb(30, 30, 38);
            tabClose.ImageIndex = 1;
            tabClose.Location = new Point(89, 4);
            tabClose.Name = "tabClose";
            tabClose.Padding = new Padding(3);
            tabClose.Size = new Size(1272, 729);
            tabClose.TabIndex = 2;
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
            Controls.Add(tabPageMain);
            HeaderColor = Color.FromArgb(126, 87, 194);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Image = null;
            Name = "MainForm";
            Text = "Bookly";
            WindowState = FormWindowState.Maximized;
            tabPageMain.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            hopeGroupBox4.ResumeLayout(false);
            hopeGroupBox4.PerformLayout();
            hopeGroupBox3.ResumeLayout(false);
            hopeGroupBox3.PerformLayout();
            hopeGroupBox2.ResumeLayout(false);
            hopeGroupBox2.PerformLayout();
            hopeGroupBox1.ResumeLayout(false);
            hopeGroupBox1.PerformLayout();
            tabLibary.ResumeLayout(false);
            tabLibary.PerformLayout();
            grpCompleted.ResumeLayout(false);
            grpInProgress.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.AirTabPage tabPageMain;
        private TabPage tabHome;
        private TabPage tabLibary;
        private ImageList imageList2;
        private ImageList imageList1;
        private TabPage tabClose;
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
        private Label label2;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private Label lblBookYear;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox2;
        private Label label5;
        private ReaLTaiizor.Controls.CyberButton cyberButton4;
        private ReaLTaiizor.Controls.CyberButton cyberButton5;
        private ReaLTaiizor.Controls.CyberButton cyberButton6;
        private Label lblWeek;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox3;
        private Label label6;
        private Label lblDays;
        private Label label8;
        private ReaLTaiizor.Controls.CyberButton cyberButton7;
        private ReaLTaiizor.Controls.CyberButton cyberButton8;
        private ReaLTaiizor.Controls.CyberButton cyberButton9;
        private Label label4;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox4;
        private Label label7;
        private ScottPlot.WinForms.FormsPlot plotDaysMonth;
    }
}
