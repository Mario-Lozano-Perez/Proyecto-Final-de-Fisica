namespace Proyecto_Final_de_Fisica
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonGithub = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(301, 267);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ButtonGithub);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(293, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Información";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // ButtonGithub
            // 
            this.ButtonGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ButtonGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGithub.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ButtonGithub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonGithub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGithub.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonGithub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGithub.ForeColor = System.Drawing.Color.White;
            this.ButtonGithub.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.ButtonGithub.IconColor = System.Drawing.Color.White;
            this.ButtonGithub.IconSize = 24;
            this.ButtonGithub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonGithub.Location = new System.Drawing.Point(18, 159);
            this.ButtonGithub.Name = "ButtonGithub";
            this.ButtonGithub.Rotation = 0D;
            this.ButtonGithub.Size = new System.Drawing.Size(257, 28);
            this.ButtonGithub.TabIndex = 19;
            this.ButtonGithub.Text = "Ver en GitHub";
            this.ButtonGithub.UseVisualStyleBackColor = false;
            this.ButtonGithub.Click += new System.EventHandler(this.ButtonGithub_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Versión: 1.0.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor: Mario Alejandro Lozano Pérez";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: Proyecto Final de Física";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(293, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Requisitos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Memoria: 300MB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Pantalla: 1280x720";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 280);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(14, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(264, 1);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(14, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 1);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(13, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 1);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(0, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 1);
            this.panel4.TabIndex = 21;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(14, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(264, 1);
            this.panel5.TabIndex = 22;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Location = new System.Drawing.Point(0, 44);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(264, 1);
            this.panel6.TabIndex = 21;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Información";
            this.TopMost = true;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton ButtonGithub;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}