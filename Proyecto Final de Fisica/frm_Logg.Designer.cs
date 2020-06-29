namespace Proyecto_Final_de_Fisica
{
    partial class frm_Logg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Logg));
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_Container = new System.Windows.Forms.Panel();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.CheckRemember = new fruslib.KstomChekBox();
            this.TextPassword = new fruslib.KstomTextBox();
            this.TextId = new fruslib.KstomTextBox();
            this.btn_acces = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Back = new System.Windows.Forms.Panel();
            this.dragControl1 = new fruslib.DragControl();
            this.dragControl2 = new fruslib.DragControl();
            this.ellipse1 = new fruslib.Ellipse();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnl_Container.SuspendLayout();
            this.pnl_Back.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.iconPictureBox1.IconSize = 98;
            this.iconPictureBox1.Location = new System.Drawing.Point(101, 31);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(108, 98);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.pnl_Container.Controls.Add(this.btn_close);
            this.pnl_Container.Controls.Add(this.CheckRemember);
            this.pnl_Container.Controls.Add(this.TextPassword);
            this.pnl_Container.Controls.Add(this.TextId);
            this.pnl_Container.Controls.Add(this.btn_acces);
            this.pnl_Container.Controls.Add(this.label2);
            this.pnl_Container.Controls.Add(this.label1);
            this.pnl_Container.Controls.Add(this.iconPictureBox1);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.Location = new System.Drawing.Point(4, 4);
            this.pnl_Container.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.Size = new System.Drawing.Size(300, 458);
            this.pnl_Container.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_close.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btn_close.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.btn_close.IconSize = 20;
            this.btn_close.Location = new System.Drawing.Point(248, 9);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(5);
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 33);
            this.btn_close.TabIndex = 17;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // CheckRemember
            // 
            this.CheckRemember.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.CheckRemember.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.CheckRemember.CheckContainerPadding = new System.Windows.Forms.Padding(13);
            this.CheckRemember.ChkBorderPadding = new System.Windows.Forms.Padding(2);
            this.CheckRemember.Cursor = System.Windows.Forms.Cursors.Default;
            this.CheckRemember.IsSelected = false;
            this.CheckRemember.Location = new System.Drawing.Point(11, 331);
            this.CheckRemember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckRemember.Name = "CheckRemember";
            this.CheckRemember.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.CheckRemember.Size = new System.Drawing.Size(204, 49);
            this.CheckRemember.TabIndex = 16;
            this.CheckRemember.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.CheckRemember.TextColor = System.Drawing.Color.White;
            this.CheckRemember.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRemember.Value = "Recordarme";
            // 
            // TextPassword
            // 
            this.TextPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.TextPassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.TextPassword.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.Location = new System.Drawing.Point(21, 271);
            this.TextPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.OverallPading = new System.Windows.Forms.Padding(5, 3, 5, 6);
            this.TextPassword.Paragraph = false;
            this.TextPassword.Size = new System.Drawing.Size(260, 47);
            this.TextPassword.TabIndex = 15;
            this.TextPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextPassword.TextColor = System.Drawing.Color.White;
            this.TextPassword.TextFont = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.TextLetters = 32767;
            this.TextPassword.TextPadding = new System.Windows.Forms.Padding(3);
            this.TextPassword.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.TextPassword.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextPassword.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.TextPassword.UnderBarHeight = 4;
            this.TextPassword.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.TextPassword.UseSystemPasswordChar = true;
            this.TextPassword.Value = "";
            // 
            // TextId
            // 
            this.TextId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.TextId.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.TextId.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextId.Location = new System.Drawing.Point(21, 185);
            this.TextId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextId.Name = "TextId";
            this.TextId.OverallPading = new System.Windows.Forms.Padding(5, 3, 5, 6);
            this.TextId.Paragraph = false;
            this.TextId.Size = new System.Drawing.Size(260, 47);
            this.TextId.TabIndex = 14;
            this.TextId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextId.TextColor = System.Drawing.Color.White;
            this.TextId.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextId.TextLetters = 11;
            this.TextId.TextPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.TextId.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.TextId.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextId.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.TextId.UnderBarHeight = 4;
            this.TextId.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.TextId.UseSystemPasswordChar = false;
            this.TextId.Value = "";
            // 
            // btn_acces
            // 
            this.btn_acces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn_acces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acces.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.btn_acces.FlatAppearance.BorderSize = 0;
            this.btn_acces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acces.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_acces.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acces.ForeColor = System.Drawing.Color.White;
            this.btn_acces.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_acces.IconColor = System.Drawing.Color.White;
            this.btn_acces.IconSize = 24;
            this.btn_acces.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acces.Location = new System.Drawing.Point(27, 395);
            this.btn_acces.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_acces.Name = "btn_acces";
            this.btn_acces.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btn_acces.Rotation = 0D;
            this.btn_acces.Size = new System.Drawing.Size(249, 46);
            this.btn_acces.TabIndex = 12;
            this.btn_acces.Text = "Acceder";
            this.btn_acces.UseVisualStyleBackColor = false;
            this.btn_acces.Click += new System.EventHandler(this.Btn_acces_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(21, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(20, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Carnet de Identidad";
            // 
            // pnl_Back
            // 
            this.pnl_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.pnl_Back.Controls.Add(this.pnl_Container);
            this.pnl_Back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Back.Location = new System.Drawing.Point(0, 0);
            this.pnl_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.pnl_Back.Name = "pnl_Back";
            this.pnl_Back.Padding = new System.Windows.Forms.Padding(4);
            this.pnl_Back.Size = new System.Drawing.Size(308, 466);
            this.pnl_Back.TabIndex = 0;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.iconPictureBox1;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.pnl_Container;
            // 
            // ellipse1
            // 
            this.ellipse1.CornerRadius = 0;
            this.ellipse1.TargetControl = this;
            // 
            // frm_Logg
            // 
            this.AcceptButton = this.btn_acces;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(308, 466);
            this.Controls.Add(this.pnl_Back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_Logg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Logg";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnl_Container.ResumeLayout(false);
            this.pnl_Container.PerformLayout();
            this.pnl_Back.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private fruslib.DragControl dragControl1;
        private fruslib.DragControl dragControl2;
        private fruslib.Ellipse ellipse1;
        private System.Windows.Forms.Panel pnl_Back;
        private System.Windows.Forms.Panel pnl_Container;
        private FontAwesome.Sharp.IconButton btn_acces;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private fruslib.KstomTextBox TextPassword;
        private fruslib.KstomTextBox TextId;
        private fruslib.KstomChekBox CheckRemember;
        private FontAwesome.Sharp.IconButton btn_close;
    }
}