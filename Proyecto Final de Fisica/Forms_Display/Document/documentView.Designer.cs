namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    partial class documentView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 179);
            this.panel1.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.LabelTitle.Location = new System.Drawing.Point(0, 0);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(114, 179);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Nombre del Documento";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LabelTitle.Click += new System.EventHandler(this.Label1_Click);
            // 
            // documentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(38)))), ((int)(((byte)(46)))));
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "documentView";
            this.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Size = new System.Drawing.Size(122, 187);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTitle;
    }
}
