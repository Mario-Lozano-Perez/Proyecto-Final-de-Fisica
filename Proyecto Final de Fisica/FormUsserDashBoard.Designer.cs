namespace Proyecto_Final_de_Fisica
{
    partial class FormUsserDashBoard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LabelQuestionairesTaken = new System.Windows.Forms.Label();
            this.LabelRankingPos = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PictureUserSex = new System.Windows.Forms.PictureBox();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelPoints = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.ButtonRanking = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_books = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserSex)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LabelPoints);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 10, 5, 10);
            this.panel1.Size = new System.Drawing.Size(1042, 275);
            this.panel1.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel5.Controls.Add(this.LabelQuestionairesTaken);
            this.panel5.Controls.Add(this.LabelRankingPos);
            this.panel5.Location = new System.Drawing.Point(266, 92);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(711, 169);
            this.panel5.TabIndex = 18;
            // 
            // LabelQuestionairesTaken
            // 
            this.LabelQuestionairesTaken.AutoSize = true;
            this.LabelQuestionairesTaken.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQuestionairesTaken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelQuestionairesTaken.Location = new System.Drawing.Point(12, 99);
            this.LabelQuestionairesTaken.Name = "LabelQuestionairesTaken";
            this.LabelQuestionairesTaken.Size = new System.Drawing.Size(273, 30);
            this.LabelQuestionairesTaken.TabIndex = 18;
            this.LabelQuestionairesTaken.Text = "Cuestionarios Realizados: 1";
            // 
            // LabelRankingPos
            // 
            this.LabelRankingPos.AutoSize = true;
            this.LabelRankingPos.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRankingPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelRankingPos.Location = new System.Drawing.Point(12, 28);
            this.LabelRankingPos.Name = "LabelRankingPos";
            this.LabelRankingPos.Size = new System.Drawing.Size(233, 30);
            this.LabelRankingPos.TabIndex = 16;
            this.LabelRankingPos.Text = "Posición en el ranking: ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(27)))));
            this.panel4.Controls.Add(this.PictureUserSex);
            this.panel4.Controls.Add(this.lbl_userName);
            this.panel4.Location = new System.Drawing.Point(266, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(711, 67);
            this.panel4.TabIndex = 17;
            // 
            // PictureUserSex
            // 
            this.PictureUserSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.PictureUserSex.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.user_male_circle2;
            this.PictureUserSex.Location = new System.Drawing.Point(0, 0);
            this.PictureUserSex.Name = "PictureUserSex";
            this.PictureUserSex.Padding = new System.Windows.Forms.Padding(7);
            this.PictureUserSex.Size = new System.Drawing.Size(67, 67);
            this.PictureUserSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureUserSex.TabIndex = 15;
            this.PictureUserSex.TabStop = false;
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.lbl_userName.Location = new System.Drawing.Point(73, 14);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(252, 35);
            this.lbl_userName.TabIndex = 9;
            this.lbl_userName.Text = "Nombre del Usuario";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.iconButton6);
            this.panel3.Controls.Add(this.iconButton5);
            this.panel3.Controls.Add(this.iconButton4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(990, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(47, 255);
            this.panel3.TabIndex = 14;
            // 
            // iconButton6
            // 
            this.iconButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton6.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton6.FlatAppearance.BorderSize = 2;
            this.iconButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton6.IconSize = 32;
            this.iconButton6.Location = new System.Drawing.Point(0, 47);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.iconButton6.Rotation = 0D;
            this.iconButton6.Size = new System.Drawing.Size(47, 47);
            this.iconButton6.TabIndex = 14;
            this.iconButton6.UseVisualStyleBackColor = true;
            this.iconButton6.Click += new System.EventHandler(this.IconButton6_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton5.FlatAppearance.BorderSize = 2;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.UserAltSlash;
            this.iconButton5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton5.IconSize = 32;
            this.iconButton5.Location = new System.Drawing.Point(0, 208);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.iconButton5.Rotation = 0D;
            this.iconButton5.Size = new System.Drawing.Size(47, 47);
            this.iconButton5.TabIndex = 13;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.SystemLogout);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton4.FlatAppearance.BorderSize = 2;
            this.iconButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.iconButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.iconButton4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconButton4.IconSize = 32;
            this.iconButton4.Location = new System.Drawing.Point(0, 0);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.iconButton4.Rotation = 0D;
            this.iconButton4.Size = new System.Drawing.Size(47, 47);
            this.iconButton4.TabIndex = 12;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.BtnRedo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.label3.Location = new System.Drawing.Point(32, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Puntos Acumulados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPoints
            // 
            this.LabelPoints.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.LabelPoints.Location = new System.Drawing.Point(40, 191);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(167, 44);
            this.LabelPoints.TabIndex = 8;
            this.LabelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(32)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(257, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 247);
            this.panel2.TabIndex = 6;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.iconPictureBox2.IconSize = 109;
            this.iconPictureBox2.Location = new System.Drawing.Point(70, 83);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(112, 109);
            this.iconPictureBox2.TabIndex = 5;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(107)))), ((int)(((byte)(124)))));
            this.iconButton3.IconSize = 60;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton3.Location = new System.Drawing.Point(747, 349);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(154, 147);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Text = "Documentos";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // ButtonRanking
            // 
            this.ButtonRanking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ButtonRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRanking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ButtonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRanking.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonRanking.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRanking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.ButtonRanking.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.ButtonRanking.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.ButtonRanking.IconSize = 60;
            this.ButtonRanking.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonRanking.Location = new System.Drawing.Point(538, 349);
            this.ButtonRanking.Name = "ButtonRanking";
            this.ButtonRanking.Padding = new System.Windows.Forms.Padding(15);
            this.ButtonRanking.Rotation = 0D;
            this.ButtonRanking.Size = new System.Drawing.Size(154, 147);
            this.ButtonRanking.TabIndex = 7;
            this.ButtonRanking.Text = "Ranking";
            this.ButtonRanking.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ButtonRanking.UseVisualStyleBackColor = false;
            this.ButtonRanking.Click += new System.EventHandler(this.ButtonRanking_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(155)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(155)))));
            this.iconButton1.IconSize = 60;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iconButton1.Location = new System.Drawing.Point(326, 349);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 15, 10, 10);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(154, 147);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Cuestionario";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // btn_books
            // 
            this.btn_books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_books.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_books.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_books.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_books.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_books.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_books.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btn_books.IconChar = FontAwesome.Sharp.IconChar.Video;
            this.btn_books.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            this.btn_books.IconSize = 60;
            this.btn_books.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_books.Location = new System.Drawing.Point(114, 349);
            this.btn_books.Name = "btn_books";
            this.btn_books.Padding = new System.Windows.Forms.Padding(15);
            this.btn_books.Rotation = 0D;
            this.btn_books.Size = new System.Drawing.Size(154, 147);
            this.btn_books.TabIndex = 5;
            this.btn_books.Text = "Videos";
            this.btn_books.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_books.UseVisualStyleBackColor = false;
            this.btn_books.Click += new System.EventHandler(this.Btn_books_Click);
            // 
            // FormUsserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1042, 594);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.ButtonRanking);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btn_books);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsserDashBoard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUserSex)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_books;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton ButtonRanking;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label LabelPoints;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private System.Windows.Forms.PictureBox PictureUserSex;
        private System.Windows.Forms.Label LabelRankingPos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LabelQuestionairesTaken;
        private System.Windows.Forms.Panel panel5;
    }
}