using fruslib;
namespace Proyecto_Final_de_Fisica.Frms
{
    partial class FormManageUserValues
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new fruslib.KstomTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new fruslib.KstomTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_UsrMod = new System.Windows.Forms.Label();
            this.chk_Admin = new fruslib.KstomChekBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_CI = new fruslib.KstomTextBox();
            this.dragControl1 = new fruslib.DragControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(325, 470);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.btn_Apply);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Name);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_UsrMod);
            this.panel2.Controls.Add(this.chk_Admin);
            this.panel2.Controls.Add(this.btn_Cancel);
            this.panel2.Controls.Add(this.txt_CI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(5, 5);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 460);
            this.panel2.TabIndex = 0;
            // 
            // btn_Apply
            // 
            this.btn_Apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Apply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn_Apply.FlatAppearance.BorderSize = 0;
            this.btn_Apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Apply.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Apply.ForeColor = System.Drawing.Color.White;
            this.btn_Apply.Location = new System.Drawing.Point(173, 398);
            this.btn_Apply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(121, 39);
            this.btn_Apply.TabIndex = 11;
            this.btn_Apply.Text = "Aplicar";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.Btn_Apply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(19, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // txt_Password
            // 
            this.txt_Password.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(19, 256);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.OverallPading = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_Password.Paragraph = false;
            this.txt_Password.Size = new System.Drawing.Size(275, 47);
            this.txt_Password.TabIndex = 9;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TextColor = System.Drawing.Color.White;
            this.txt_Password.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.TextLetters = 32767;
            this.txt_Password.TextPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txt_Password.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.txt_Password.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Password.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_Password.UnderBarHeight = 4;
            this.txt_Password.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_Password.UseSystemPasswordChar = false;
            this.txt_Password.Value = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(19, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre";
            // 
            // txt_Name
            // 
            this.txt_Name.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.txt_Name.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(19, 177);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.OverallPading = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_Name.Paragraph = false;
            this.txt_Name.Size = new System.Drawing.Size(275, 47);
            this.txt_Name.TabIndex = 7;
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Name.TextColor = System.Drawing.Color.White;
            this.txt_Name.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.TextLetters = 32767;
            this.txt_Name.TextPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txt_Name.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.txt_Name.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Name.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_Name.UnderBarHeight = 4;
            this.txt_Name.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_Name.UseSystemPasswordChar = false;
            this.txt_Name.Value = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Carnet de Identidad";
            // 
            // lbl_UsrMod
            // 
            this.lbl_UsrMod.AutoSize = true;
            this.lbl_UsrMod.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UsrMod.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_UsrMod.Location = new System.Drawing.Point(16, 16);
            this.lbl_UsrMod.Name = "lbl_UsrMod";
            this.lbl_UsrMod.Size = new System.Drawing.Size(142, 28);
            this.lbl_UsrMod.TabIndex = 5;
            this.lbl_UsrMod.Text = "Añadir Usuario";
            // 
            // chk_Admin
            // 
            this.chk_Admin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.chk_Admin.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.chk_Admin.CheckContainerPadding = new System.Windows.Forms.Padding(12);
            this.chk_Admin.ChkBorderPadding = new System.Windows.Forms.Padding(3);
            this.chk_Admin.Cursor = System.Windows.Forms.Cursors.Default;
            this.chk_Admin.IsSelected = false;
            this.chk_Admin.Location = new System.Drawing.Point(5, 322);
            this.chk_Admin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chk_Admin.Name = "chk_Admin";
            this.chk_Admin.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.chk_Admin.Size = new System.Drawing.Size(219, 49);
            this.chk_Admin.TabIndex = 4;
            this.chk_Admin.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_Admin.TextColor = System.Drawing.Color.White;
            this.chk_Admin.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Admin.Value = "Administrador";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.FlatAppearance.BorderSize = 0;
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.White;
            this.btn_Cancel.Location = new System.Drawing.Point(19, 398);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(121, 39);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txt_CI
            // 
            this.txt_CI.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.txt_CI.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CI.Location = new System.Drawing.Point(19, 96);
            this.txt_CI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CI.Name = "txt_CI";
            this.txt_CI.OverallPading = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.txt_CI.Paragraph = false;
            this.txt_CI.Size = new System.Drawing.Size(275, 47);
            this.txt_CI.TabIndex = 1;
            this.txt_CI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_CI.TextColor = System.Drawing.Color.White;
            this.txt_CI.TextFont = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CI.TextLetters = 11;
            this.txt_CI.TextPadding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.txt_CI.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.txt_CI.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_CI.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_CI.UnderBarHeight = 4;
            this.txt_CI.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.txt_CI.UseSystemPasswordChar = false;
            this.txt_CI.Value = "";
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.panel2;
            // 
            // FormManageUserValues
            // 
            this.AcceptButton = this.btn_Apply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(325, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormManageUserValues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormManageUserValues";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private fruslib.DragControl dragControl1;
        private fruslib.KstomTextBox txt_CI;
        private System.Windows.Forms.Button btn_Cancel;
        private fruslib.KstomChekBox chk_Admin;
        private System.Windows.Forms.Label label4;
        private fruslib.KstomTextBox txt_Password;
        private System.Windows.Forms.Label label3;
        private fruslib.KstomTextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_UsrMod;
        private System.Windows.Forms.Button btn_Apply;
    }
}