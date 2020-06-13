namespace Proyecto_Final_de_Fisica.Forms_Display
{
    partial class QuestionFinish
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
            this.label1 = new System.Windows.Forms.Label();
            this.LblSuplement = new System.Windows.Forms.Label();
            this.buttonVerify = new FontAwesome.Sharp.IconButton();
            this.Pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(460, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Finalizado";
            // 
            // LblSuplement
            // 
            this.LblSuplement.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSuplement.ForeColor = System.Drawing.Color.Silver;
            this.LblSuplement.Location = new System.Drawing.Point(236, 363);
            this.LblSuplement.Name = "LblSuplement";
            this.LblSuplement.Size = new System.Drawing.Size(571, 130);
            this.LblSuplement.TabIndex = 2;
            this.LblSuplement.Text = "Texto Final";
            this.LblSuplement.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.buttonVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerify.FlatAppearance.BorderSize = 0;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.buttonVerify.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVerify.ForeColor = System.Drawing.Color.White;
            this.buttonVerify.IconChar = FontAwesome.Sharp.IconChar.FlagCheckered;
            this.buttonVerify.IconColor = System.Drawing.Color.White;
            this.buttonVerify.IconSize = 24;
            this.buttonVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVerify.Location = new System.Drawing.Point(432, 486);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonVerify.Rotation = 0D;
            this.buttonVerify.Size = new System.Drawing.Size(178, 39);
            this.buttonVerify.TabIndex = 30;
            this.buttonVerify.Text = "Finalizar";
            this.buttonVerify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // Pic
            // 
            this.Pic.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.questions_cloud;
            this.Pic.Location = new System.Drawing.Point(390, 67);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(262, 262);
            this.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic.TabIndex = 0;
            this.Pic.TabStop = false;
            // 
            // QuestionFinish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.LblSuplement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionFinish";
            this.Text = "Texto Final";
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSuplement;
        private FontAwesome.Sharp.IconButton buttonVerify;
    }
}