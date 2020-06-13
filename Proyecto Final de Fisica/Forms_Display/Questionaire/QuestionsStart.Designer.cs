namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    partial class QuestionsStart
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
            this.TextMaxNumber = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Start = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextMaxNumber
            // 
            this.TextMaxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.TextMaxNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextMaxNumber.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMaxNumber.ForeColor = System.Drawing.Color.Silver;
            this.TextMaxNumber.Location = new System.Drawing.Point(408, 398);
            this.TextMaxNumber.Mask = "99";
            this.TextMaxNumber.Name = "TextMaxNumber";
            this.TextMaxNumber.PromptChar = ' ';
            this.TextMaxNumber.Size = new System.Drawing.Size(227, 31);
            this.TextMaxNumber.TabIndex = 0;
            this.TextMaxNumber.Text = "10";
            this.TextMaxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextMaxNumber.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.questions_cloud;
            this.pictureBox1.Location = new System.Drawing.Point(383, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(375, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Iniciar un questionario";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Start.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btn_Start.IconColor = System.Drawing.Color.White;
            this.btn_Start.IconSize = 24;
            this.btn_Start.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Start.Location = new System.Drawing.Point(368, 463);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btn_Start.Rotation = 0D;
            this.btn_Start.Size = new System.Drawing.Size(306, 39);
            this.btn_Start.TabIndex = 24;
            this.btn_Start.Text = "Iniciar Cuestionario";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(396, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Cantidad maxima de preguntas";
            // 
            // QuestionsStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextMaxNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionsStart";
            this.Text = "QuestionsStart";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TextMaxNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Start;
        private System.Windows.Forms.Label label2;
    }
}