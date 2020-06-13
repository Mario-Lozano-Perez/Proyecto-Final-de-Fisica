namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    partial class RankUser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicSex = new System.Windows.Forms.PictureBox();
            this.LabelPos = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicSex)).BeginInit();
            this.SuspendLayout();
            // 
            // PicSex
            // 
            this.PicSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.PicSex.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.user_male_circle;
            this.PicSex.Location = new System.Drawing.Point(5, 5);
            this.PicSex.Name = "PicSex";
            this.PicSex.Padding = new System.Windows.Forms.Padding(4);
            this.PicSex.Size = new System.Drawing.Size(67, 67);
            this.PicSex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSex.TabIndex = 0;
            this.PicSex.TabStop = false;
            // 
            // LabelPos
            // 
            this.LabelPos.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelPos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelPos.Location = new System.Drawing.Point(646, 5);
            this.LabelPos.Name = "LabelPos";
            this.LabelPos.Size = new System.Drawing.Size(99, 67);
            this.LabelPos.TabIndex = 1;
            this.LabelPos.Text = "Posición: 255595";
            this.LabelPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.DarkGray;
            this.LabelName.Location = new System.Drawing.Point(83, 20);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(230, 32);
            this.LabelName.TabIndex = 2;
            this.LabelName.Text = "Nombre del Usuario";
            // 
            // LabelPoints
            // 
            this.LabelPoints.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelPoints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelPoints.Location = new System.Drawing.Point(558, 5);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(88, 67);
            this.LabelPoints.TabIndex = 3;
            this.LabelPoints.Text = "Puntos: 4589";
            this.LabelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RankUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Controls.Add(this.LabelPoints);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelPos);
            this.Controls.Add(this.PicSex);
            this.Name = "RankUser";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 1, 5);
            this.Size = new System.Drawing.Size(746, 77);
            ((System.ComponentModel.ISupportInitialize)(this.PicSex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicSex;
        private System.Windows.Forms.Label LabelPos;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LabelPoints;
    }
}
