namespace Proyecto_Final_de_Fisica
{
    partial class MessageForm
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
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.dragControl1 = new fruslib.DragControl();
            this.dragControl2 = new fruslib.DragControl();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Close.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_Close.IconColor = System.Drawing.Color.Black;
            this.btn_Close.IconSize = 16;
            this.btn_Close.Location = new System.Drawing.Point(305, 109);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Rotation = 0D;
            this.btn_Close.Size = new System.Drawing.Size(109, 34);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Aceptar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // dragControl1
            // 
            this.dragControl1.SelectControl = this;
            // 
            // dragControl2
            // 
            this.dragControl2.SelectControl = this.label1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // MessageForm
            // 
            this.AcceptButton = this.btn_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(426, 152);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageForm";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btn_Close;
        private fruslib.DragControl dragControl1;
        private fruslib.DragControl dragControl2;
        private System.Windows.Forms.Label label1;
    }
}