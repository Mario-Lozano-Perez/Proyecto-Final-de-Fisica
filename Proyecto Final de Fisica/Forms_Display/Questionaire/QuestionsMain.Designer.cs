namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    partial class QuestionsMain
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
            this.LabelWrongAnswers = new System.Windows.Forms.Label();
            this.LabelCorrectAnswers = new System.Windows.Forms.Label();
            this.LabelCurrentQuestion = new System.Windows.Forms.Label();
            this.LabelTotalQuestions = new System.Windows.Forms.Label();
            this.LabelPoints = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextQuestionContent = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.buttonVerify = new FontAwesome.Sharp.IconButton();
            this.PanelChekContain = new System.Windows.Forms.Panel();
            this.Qst1 = new fruslib.KstomChekBox();
            this.Qst4 = new fruslib.KstomChekBox();
            this.Qst3 = new fruslib.KstomChekBox();
            this.Qst2 = new fruslib.KstomChekBox();
            this.ButtonInterrupt = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelChekContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.ButtonInterrupt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.LabelWrongAnswers);
            this.panel1.Controls.Add(this.LabelCorrectAnswers);
            this.panel1.Controls.Add(this.LabelCurrentQuestion);
            this.panel1.Controls.Add(this.LabelTotalQuestions);
            this.panel1.Controls.Add(this.LabelPoints);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 594);
            this.panel1.TabIndex = 0;
            // 
            // LabelWrongAnswers
            // 
            this.LabelWrongAnswers.AutoSize = true;
            this.LabelWrongAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWrongAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LabelWrongAnswers.Location = new System.Drawing.Point(12, 459);
            this.LabelWrongAnswers.Name = "LabelWrongAnswers";
            this.LabelWrongAnswers.Size = new System.Drawing.Size(187, 20);
            this.LabelWrongAnswers.TabIndex = 26;
            this.LabelWrongAnswers.Text = "Respuestas Incorrectas";
            // 
            // LabelCorrectAnswers
            // 
            this.LabelCorrectAnswers.AutoSize = true;
            this.LabelCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCorrectAnswers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelCorrectAnswers.Location = new System.Drawing.Point(12, 416);
            this.LabelCorrectAnswers.Name = "LabelCorrectAnswers";
            this.LabelCorrectAnswers.Size = new System.Drawing.Size(177, 20);
            this.LabelCorrectAnswers.TabIndex = 25;
            this.LabelCorrectAnswers.Text = "Respuestas Correctas";
            // 
            // LabelCurrentQuestion
            // 
            this.LabelCurrentQuestion.AutoSize = true;
            this.LabelCurrentQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCurrentQuestion.ForeColor = System.Drawing.Color.Silver;
            this.LabelCurrentQuestion.Location = new System.Drawing.Point(12, 368);
            this.LabelCurrentQuestion.Name = "LabelCurrentQuestion";
            this.LabelCurrentQuestion.Size = new System.Drawing.Size(128, 20);
            this.LabelCurrentQuestion.TabIndex = 24;
            this.LabelCurrentQuestion.Text = "Pregunta Actual";
            // 
            // LabelTotalQuestions
            // 
            this.LabelTotalQuestions.AutoSize = true;
            this.LabelTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotalQuestions.ForeColor = System.Drawing.Color.Silver;
            this.LabelTotalQuestions.Location = new System.Drawing.Point(12, 328);
            this.LabelTotalQuestions.Name = "LabelTotalQuestions";
            this.LabelTotalQuestions.Size = new System.Drawing.Size(154, 20);
            this.LabelTotalQuestions.TabIndex = 22;
            this.LabelTotalQuestions.Text = "Total De Preguntas";
            // 
            // LabelPoints
            // 
            this.LabelPoints.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.LabelPoints.Location = new System.Drawing.Point(50, 237);
            this.LabelPoints.Name = "LabelPoints";
            this.LabelPoints.Size = new System.Drawing.Size(147, 38);
            this.LabelPoints.TabIndex = 23;
            this.LabelPoints.Text = "0";
            this.LabelPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.label1.Location = new System.Drawing.Point(86, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Puntos";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(111)))));
            this.iconPictureBox2.IconSize = 109;
            this.iconPictureBox2.Location = new System.Drawing.Point(70, 115);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(112, 109);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.TextQuestionContent);
            this.panel2.Location = new System.Drawing.Point(309, 58);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(6);
            this.panel2.Size = new System.Drawing.Size(673, 199);
            this.panel2.TabIndex = 21;
            // 
            // TextQuestionContent
            // 
            this.TextQuestionContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.TextQuestionContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextQuestionContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextQuestionContent.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextQuestionContent.ForeColor = System.Drawing.Color.Silver;
            this.TextQuestionContent.Location = new System.Drawing.Point(6, 6);
            this.TextQuestionContent.Name = "TextQuestionContent";
            this.TextQuestionContent.ReadOnly = true;
            this.TextQuestionContent.Size = new System.Drawing.Size(661, 187);
            this.TextQuestionContent.TabIndex = 0;
            this.TextQuestionContent.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.label7.Location = new System.Drawing.Point(21, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cuestionario en Curso";
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(237)))), ((int)(((byte)(230)))));
            this.LabelTitle.Location = new System.Drawing.Point(304, 21);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(66, 25);
            this.LabelTitle.TabIndex = 28;
            this.LabelTitle.Text = "Titulo:";
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
            this.buttonVerify.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.buttonVerify.IconColor = System.Drawing.Color.White;
            this.buttonVerify.IconSize = 24;
            this.buttonVerify.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonVerify.Location = new System.Drawing.Point(804, 534);
            this.buttonVerify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.buttonVerify.Rotation = 0D;
            this.buttonVerify.Size = new System.Drawing.Size(178, 39);
            this.buttonVerify.TabIndex = 29;
            this.buttonVerify.Text = "Verificar";
            this.buttonVerify.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.ButtonVerify_Click);
            // 
            // PanelChekContain
            // 
            this.PanelChekContain.Controls.Add(this.Qst1);
            this.PanelChekContain.Controls.Add(this.Qst4);
            this.PanelChekContain.Controls.Add(this.Qst3);
            this.PanelChekContain.Controls.Add(this.Qst2);
            this.PanelChekContain.Location = new System.Drawing.Point(290, 272);
            this.PanelChekContain.Name = "PanelChekContain";
            this.PanelChekContain.Size = new System.Drawing.Size(716, 257);
            this.PanelChekContain.TabIndex = 30;
            // 
            // Qst1
            // 
            this.Qst1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Qst1.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.Qst1.CheckContainerPadding = new System.Windows.Forms.Padding(13);
            this.Qst1.ChkBorderPadding = new System.Windows.Forms.Padding(2);
            this.Qst1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Qst1.IsSelected = false;
            this.Qst1.Location = new System.Drawing.Point(19, 12);
            this.Qst1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Qst1.Name = "Qst1";
            this.Qst1.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Qst1.Size = new System.Drawing.Size(673, 49);
            this.Qst1.TabIndex = 26;
            this.Qst1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qst1.TextColor = System.Drawing.Color.White;
            this.Qst1.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst1.Value = "Recordarme";
            this.Qst1.CheckChange += new System.EventHandler(this.Qst1_CheckChange);
            // 
            // Qst4
            // 
            this.Qst4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Qst4.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.Qst4.CheckContainerPadding = new System.Windows.Forms.Padding(13);
            this.Qst4.ChkBorderPadding = new System.Windows.Forms.Padding(2);
            this.Qst4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Qst4.IsSelected = false;
            this.Qst4.Location = new System.Drawing.Point(19, 202);
            this.Qst4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Qst4.Name = "Qst4";
            this.Qst4.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Qst4.Size = new System.Drawing.Size(673, 49);
            this.Qst4.TabIndex = 25;
            this.Qst4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qst4.TextColor = System.Drawing.Color.White;
            this.Qst4.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst4.Value = "Recordarme";
            this.Qst4.CheckChange += new System.EventHandler(this.Qst4_CheckChange);
            // 
            // Qst3
            // 
            this.Qst3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Qst3.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.Qst3.CheckContainerPadding = new System.Windows.Forms.Padding(13);
            this.Qst3.ChkBorderPadding = new System.Windows.Forms.Padding(2);
            this.Qst3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Qst3.IsSelected = false;
            this.Qst3.Location = new System.Drawing.Point(19, 136);
            this.Qst3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Qst3.Name = "Qst3";
            this.Qst3.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Qst3.Size = new System.Drawing.Size(673, 49);
            this.Qst3.TabIndex = 24;
            this.Qst3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qst3.TextColor = System.Drawing.Color.White;
            this.Qst3.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst3.Value = "Recordarme";
            this.Qst3.CheckChange += new System.EventHandler(this.Qst3_CheckChange);
            // 
            // Qst2
            // 
            this.Qst2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.Qst2.CheckBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(91)))), ((int)(((byte)(102)))));
            this.Qst2.CheckContainerPadding = new System.Windows.Forms.Padding(13);
            this.Qst2.ChkBorderPadding = new System.Windows.Forms.Padding(2);
            this.Qst2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Qst2.IsSelected = false;
            this.Qst2.Location = new System.Drawing.Point(19, 74);
            this.Qst2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Qst2.Name = "Qst2";
            this.Qst2.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Qst2.Size = new System.Drawing.Size(673, 49);
            this.Qst2.TabIndex = 23;
            this.Qst2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.Qst2.TextColor = System.Drawing.Color.White;
            this.Qst2.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qst2.Value = "Recordarme";
            this.Qst2.CheckChange += new System.EventHandler(this.Qst2_CheckChange);
            // 
            // ButtonInterrupt
            // 
            this.ButtonInterrupt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ButtonInterrupt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonInterrupt.FlatAppearance.BorderSize = 0;
            this.ButtonInterrupt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInterrupt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonInterrupt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonInterrupt.ForeColor = System.Drawing.Color.White;
            this.ButtonInterrupt.IconChar = FontAwesome.Sharp.IconChar.SquareFull;
            this.ButtonInterrupt.IconColor = System.Drawing.Color.White;
            this.ButtonInterrupt.IconSize = 24;
            this.ButtonInterrupt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonInterrupt.Location = new System.Drawing.Point(16, 526);
            this.ButtonInterrupt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonInterrupt.Name = "ButtonInterrupt";
            this.ButtonInterrupt.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.ButtonInterrupt.Rotation = 0D;
            this.ButtonInterrupt.Size = new System.Drawing.Size(216, 39);
            this.ButtonInterrupt.TabIndex = 30;
            this.ButtonInterrupt.Text = "Interrumpir";
            this.ButtonInterrupt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonInterrupt.UseVisualStyleBackColor = false;
            this.ButtonInterrupt.Click += new System.EventHandler(this.ButtonInterrupt_Click);
            // 
            // QuestionsMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.PanelChekContain);
            this.Controls.Add(this.buttonVerify);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionsMain";
            this.Text = "QuestionsMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PanelChekContain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox TextQuestionContent;
        private System.Windows.Forms.Label LabelWrongAnswers;
        private System.Windows.Forms.Label LabelCorrectAnswers;
        private System.Windows.Forms.Label LabelCurrentQuestion;
        private System.Windows.Forms.Label LabelTotalQuestions;
        private System.Windows.Forms.Label LabelPoints;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LabelTitle;
        private FontAwesome.Sharp.IconButton buttonVerify;
        private System.Windows.Forms.Panel PanelChekContain;
        private fruslib.KstomChekBox Qst1;
        private fruslib.KstomChekBox Qst4;
        private fruslib.KstomChekBox Qst3;
        private fruslib.KstomChekBox Qst2;
        private FontAwesome.Sharp.IconButton ButtonInterrupt;
    }
}