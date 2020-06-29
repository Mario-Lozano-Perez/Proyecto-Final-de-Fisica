namespace Proyecto_Final_de_Fisica
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.drg_topBar = new fruslib.DragControl();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ellipse1 = new fruslib.Ellipse();
            this.dragControl1 = new fruslib.DragControl();
            this.pnl_topBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Context = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            this.iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            this.btn_minimize = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_FormContainer = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButtonTrophy = new FontAwesome.Sharp.IconButton();
            this.btn_adminPanel = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ButtonQuestionaire = new FontAwesome.Sharp.IconButton();
            this.ButtonVideos = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.dragControl2 = new fruslib.DragControl();
            this.pnl_topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Context.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // drg_topBar
            // 
            this.drg_topBar.SelectControl = this.lblTitle;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(43, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(494, 28);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Proyecto Final de Física - Mario Alejandro Lozano Pérez";
            // 
            // ellipse1
            // 
            this.ellipse1.CornerRadius = 0;
            this.ellipse1.TargetControl = this;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.pnl_topBar;
            // 
            // pnl_topBar
            // 
            this.pnl_topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.pnl_topBar.Controls.Add(this.lblTitle);
            this.pnl_topBar.Controls.Add(this.pictureBox1);
            this.pnl_topBar.Controls.Add(this.btn_minimize);
            this.pnl_topBar.Controls.Add(this.btn_close);
            this.pnl_topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_topBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_topBar.Name = "pnl_topBar";
            this.pnl_topBar.Size = new System.Drawing.Size(1091, 46);
            this.pnl_topBar.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.Context;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.Atom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(49, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Context
            // 
            this.Context.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Context.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iconMenuItem1,
            this.iconMenuItem2,
            this.iconMenuItem3,
            this.iconMenuItem4,
            this.toolStripSeparator2,
            this.iconMenuItem5,
            this.iconMenuItem6,
            this.iconMenuItem7,
            this.iconMenuItem8});
            this.Context.Name = "contextMenuStrip2";
            this.Context.Size = new System.Drawing.Size(170, 218);
            // 
            // iconMenuItem1
            // 
            this.iconMenuItem1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconMenuItem1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem1.IconSize = 16;
            this.iconMenuItem1.Name = "iconMenuItem1";
            this.iconMenuItem1.Rotation = 0D;
            this.iconMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem1.Text = "Inicio";
            this.iconMenuItem1.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // iconMenuItem2
            // 
            this.iconMenuItem2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.iconMenuItem2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem2.IconSize = 16;
            this.iconMenuItem2.Name = "iconMenuItem2";
            this.iconMenuItem2.Rotation = 0D;
            this.iconMenuItem2.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem2.Text = "Videos";
            this.iconMenuItem2.Click += new System.EventHandler(this.ButtonVideos_Click);
            // 
            // iconMenuItem3
            // 
            this.iconMenuItem3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconMenuItem3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem3.IconSize = 16;
            this.iconMenuItem3.Name = "iconMenuItem3";
            this.iconMenuItem3.Rotation = 0D;
            this.iconMenuItem3.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem3.Text = "Cuestionario";
            this.iconMenuItem3.Click += new System.EventHandler(this.ButtonQuestionaire_Click);
            // 
            // iconMenuItem4
            // 
            this.iconMenuItem4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconMenuItem4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem4.IconSize = 16;
            this.iconMenuItem4.Name = "iconMenuItem4";
            this.iconMenuItem4.Rotation = 0D;
            this.iconMenuItem4.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem4.Text = "Documentos";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // iconMenuItem5
            // 
            this.iconMenuItem5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconMenuItem5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem5.IconSize = 16;
            this.iconMenuItem5.Name = "iconMenuItem5";
            this.iconMenuItem5.Rotation = 0D;
            this.iconMenuItem5.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem5.Text = "Acerca de";
            // 
            // iconMenuItem6
            // 
            this.iconMenuItem6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconMenuItem6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem6.IconSize = 16;
            this.iconMenuItem6.Name = "iconMenuItem6";
            this.iconMenuItem6.Rotation = 0D;
            this.iconMenuItem6.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem6.Text = "Cerrar Sesión";
            this.iconMenuItem6.Click += new System.EventHandler(this.LogOut);
            // 
            // iconMenuItem7
            // 
            this.iconMenuItem7.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMenuItem7.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem7.IconSize = 16;
            this.iconMenuItem7.Name = "iconMenuItem7";
            this.iconMenuItem7.Rotation = 0D;
            this.iconMenuItem7.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem7.Text = "Minimizar";
            this.iconMenuItem7.Click += new System.EventHandler(this.MinimizeProgram);
            // 
            // iconMenuItem8
            // 
            this.iconMenuItem8.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconMenuItem8.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconMenuItem8.IconSize = 16;
            this.iconMenuItem8.Name = "iconMenuItem8";
            this.iconMenuItem8.Rotation = 0D;
            this.iconMenuItem8.Size = new System.Drawing.Size(169, 26);
            this.iconMenuItem8.Text = "Salir";
            this.iconMenuItem8.Click += new System.EventHandler(this.ExitProgram);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(35)))), ((int)(((byte)(41)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimize.IconColor = System.Drawing.Color.White;
            this.btn_minimize.IconSize = 20;
            this.btn_minimize.Location = new System.Drawing.Point(999, 0);
            this.btn_minimize.Margin = new System.Windows.Forms.Padding(3, 2, 10, 2);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Padding = new System.Windows.Forms.Padding(5);
            this.btn_minimize.Rotation = 0D;
            this.btn_minimize.Size = new System.Drawing.Size(46, 46);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.MinimizeProgram);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_close.IconColor = System.Drawing.Color.White;
            this.btn_close.IconSize = 20;
            this.btn_close.Location = new System.Drawing.Point(1045, 0);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(5);
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(46, 46);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.ExitProgram);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_FormContainer);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnl_topBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 633);
            this.panel1.TabIndex = 0;
            // 
            // pnl_FormContainer
            // 
            this.pnl_FormContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnl_FormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_FormContainer.Location = new System.Drawing.Point(55, 46);
            this.pnl_FormContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_FormContainer.Name = "pnl_FormContainer";
            this.pnl_FormContainer.Size = new System.Drawing.Size(1036, 587);
            this.pnl_FormContainer.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.panel2.Controls.Add(this.ButtonTrophy);
            this.panel2.Controls.Add(this.btn_adminPanel);
            this.panel2.Controls.Add(this.iconButton3);
            this.panel2.Controls.Add(this.ButtonQuestionaire);
            this.panel2.Controls.Add(this.ButtonVideos);
            this.panel2.Controls.Add(this.btn_Home);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel2.Size = new System.Drawing.Size(55, 587);
            this.panel2.TabIndex = 5;
            // 
            // ButtonTrophy
            // 
            this.ButtonTrophy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonTrophy.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonTrophy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ButtonTrophy.FlatAppearance.BorderSize = 0;
            this.ButtonTrophy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(146)))), ((int)(((byte)(114)))));
            this.ButtonTrophy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTrophy.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonTrophy.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.ButtonTrophy.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonTrophy.IconSize = 26;
            this.ButtonTrophy.Location = new System.Drawing.Point(0, 203);
            this.ButtonTrophy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.ButtonTrophy.Name = "ButtonTrophy";
            this.ButtonTrophy.Rotation = 0D;
            this.ButtonTrophy.Size = new System.Drawing.Size(52, 50);
            this.ButtonTrophy.TabIndex = 5;
            this.ButtonTrophy.UseVisualStyleBackColor = true;
            this.ButtonTrophy.Click += new System.EventHandler(this.ButtonTrophy_Click);
            // 
            // btn_adminPanel
            // 
            this.btn_adminPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_adminPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_adminPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btn_adminPanel.FlatAppearance.BorderSize = 0;
            this.btn_adminPanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(113)))));
            this.btn_adminPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adminPanel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_adminPanel.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btn_adminPanel.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_adminPanel.IconSize = 24;
            this.btn_adminPanel.Location = new System.Drawing.Point(0, 534);
            this.btn_adminPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.btn_adminPanel.Name = "btn_adminPanel";
            this.btn_adminPanel.Rotation = 0D;
            this.btn_adminPanel.Size = new System.Drawing.Size(52, 50);
            this.btn_adminPanel.TabIndex = 4;
            this.btn_adminPanel.UseVisualStyleBackColor = true;
            this.btn_adminPanel.Click += new System.EventHandler(this.Btn_adminPanel_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton3.IconSize = 24;
            this.iconButton3.Location = new System.Drawing.Point(0, 153);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(52, 50);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // ButtonQuestionaire
            // 
            this.ButtonQuestionaire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonQuestionaire.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonQuestionaire.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ButtonQuestionaire.FlatAppearance.BorderSize = 0;
            this.ButtonQuestionaire.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(185)))), ((int)(((byte)(172)))));
            this.ButtonQuestionaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonQuestionaire.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonQuestionaire.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.ButtonQuestionaire.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonQuestionaire.IconSize = 24;
            this.ButtonQuestionaire.Location = new System.Drawing.Point(0, 103);
            this.ButtonQuestionaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.ButtonQuestionaire.Name = "ButtonQuestionaire";
            this.ButtonQuestionaire.Rotation = 0D;
            this.ButtonQuestionaire.Size = new System.Drawing.Size(52, 50);
            this.ButtonQuestionaire.TabIndex = 2;
            this.ButtonQuestionaire.UseVisualStyleBackColor = true;
            this.ButtonQuestionaire.Click += new System.EventHandler(this.ButtonQuestionaire_Click);
            // 
            // ButtonVideos
            // 
            this.ButtonVideos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonVideos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonVideos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.ButtonVideos.FlatAppearance.BorderSize = 0;
            this.ButtonVideos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.ButtonVideos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVideos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonVideos.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.ButtonVideos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ButtonVideos.IconSize = 24;
            this.ButtonVideos.Location = new System.Drawing.Point(0, 53);
            this.ButtonVideos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.ButtonVideos.Name = "ButtonVideos";
            this.ButtonVideos.Rotation = 0D;
            this.ButtonVideos.Size = new System.Drawing.Size(52, 50);
            this.ButtonVideos.TabIndex = 1;
            this.ButtonVideos.UseVisualStyleBackColor = true;
            this.ButtonVideos.Click += new System.EventHandler(this.ButtonVideos_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(20)))));
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(113)))));
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Home.IconSize = 24;
            this.btn_Home.Location = new System.Drawing.Point(0, 3);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 25);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Rotation = 0D;
            this.btn_Home.Size = new System.Drawing.Size(52, 50);
            this.btn_Home.TabIndex = 0;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.Btn_Home_Click);
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.pictureBox1;
            // 
            // MainForm
            // 
            this.AcceptButton = this.btn_Home;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(22)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1097, 639);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.pnl_topBar.ResumeLayout(false);
            this.pnl_topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Context.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private fruslib.DragControl drg_topBar;
        private fruslib.Ellipse ellipse1;
        private fruslib.DragControl dragControl1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel pnl_FormContainer;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_adminPanel;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton ButtonQuestionaire;
        private FontAwesome.Sharp.IconButton ButtonVideos;
        private FontAwesome.Sharp.IconButton btn_Home;
        private System.Windows.Forms.Panel pnl_topBar;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btn_minimize;
        private FontAwesome.Sharp.IconButton btn_close;
        private fruslib.DragControl dragControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip Context;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
        private FontAwesome.Sharp.IconButton ButtonTrophy;
    }
}