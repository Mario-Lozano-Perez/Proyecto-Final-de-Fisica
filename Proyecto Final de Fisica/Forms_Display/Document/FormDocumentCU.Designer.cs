namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    partial class FormDocumentCU
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
            this.PanelFileChecked = new System.Windows.Forms.Panel();
            this.LabelProcces = new System.Windows.Forms.Label();
            this.btn_Register = new FontAwesome.Sharp.IconButton();
            this.btn_close = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.KtextTittle = new fruslib.KstomTextBox();
            this.dragControl2 = new fruslib.DragControl();
            this.dragControl1 = new fruslib.DragControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.PanelFileChecked);
            this.panel1.Controls.Add(this.LabelProcces);
            this.panel1.Controls.Add(this.btn_Register);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.KtextTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 238);
            this.panel1.TabIndex = 1;
            // 
            // PanelFileChecked
            // 
            this.PanelFileChecked.BackColor = System.Drawing.Color.LightCoral;
            this.PanelFileChecked.Location = new System.Drawing.Point(20, 125);
            this.PanelFileChecked.Name = "PanelFileChecked";
            this.PanelFileChecked.Size = new System.Drawing.Size(10, 10);
            this.PanelFileChecked.TabIndex = 25;
            // 
            // LabelProcces
            // 
            this.LabelProcces.AutoSize = true;
            this.LabelProcces.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelProcces.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LabelProcces.Location = new System.Drawing.Point(21, 192);
            this.LabelProcces.Name = "LabelProcces";
            this.LabelProcces.Size = new System.Drawing.Size(99, 23);
            this.LabelProcces.TabIndex = 24;
            this.LabelProcces.Text = "Procesando";
            this.LabelProcces.Visible = false;
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_Register.IconColor = System.Drawing.Color.White;
            this.btn_Register.IconSize = 24;
            this.btn_Register.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Register.Location = new System.Drawing.Point(205, 182);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btn_Register.Rotation = 0D;
            this.btn_Register.Size = new System.Drawing.Size(148, 39);
            this.btn_Register.TabIndex = 23;
            this.btn_Register.Text = "Aceptar";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
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
            this.btn_close.Location = new System.Drawing.Point(308, 18);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Padding = new System.Windows.Forms.Padding(5);
            this.btn_close.Rotation = 0D;
            this.btn_close.Size = new System.Drawing.Size(45, 33);
            this.btn_close.TabIndex = 19;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconSize = 24;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.Location = new System.Drawing.Point(17, 122);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(336, 39);
            this.iconButton1.TabIndex = 22;
            this.iconButton1.Text = "Seleccionar Archivo";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.IconButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(17, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Titulo del documento";
            // 
            // KtextTittle
            // 
            this.KtextTittle.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.KtextTittle.Location = new System.Drawing.Point(17, 61);
            this.KtextTittle.Name = "KtextTittle";
            this.KtextTittle.OverallPading = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.KtextTittle.Paragraph = false;
            this.KtextTittle.Size = new System.Drawing.Size(336, 44);
            this.KtextTittle.TabIndex = 20;
            this.KtextTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.KtextTittle.TextColor = System.Drawing.Color.Silver;
            this.KtextTittle.TextFont = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KtextTittle.TextLetters = 32767;
            this.KtextTittle.TextPadding = new System.Windows.Forms.Padding(3);
            this.KtextTittle.UnderBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.KtextTittle.UnderBarErrorColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.KtextTittle.UnderBarFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.KtextTittle.UnderBarHeight = 3;
            this.KtextTittle.UnderBarHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(203)))), ((int)(((byte)(184)))));
            this.KtextTittle.UseSystemPasswordChar = false;
            this.KtextTittle.Value = "";
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.panel1;
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this.label2;
            // 
            // FormDocumentCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(376, 244);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDocumentCU";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDocumentCU";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelFileChecked;
        private System.Windows.Forms.Label LabelProcces;
        private FontAwesome.Sharp.IconButton btn_Register;
        private FontAwesome.Sharp.IconButton btn_close;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label2;
        private fruslib.KstomTextBox KtextTittle;
        private fruslib.DragControl dragControl2;
        private fruslib.DragControl dragControl1;
    }
}