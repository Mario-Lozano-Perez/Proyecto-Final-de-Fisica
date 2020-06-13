namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    partial class RankingForm
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
            this.PanelRank = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonReload = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.ButtonReload);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 61);
            this.panel1.TabIndex = 0;
            // 
            // PanelRank
            // 
            this.PanelRank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.PanelRank.Location = new System.Drawing.Point(24, 107);
            this.PanelRank.Name = "PanelRank";
            this.PanelRank.Padding = new System.Windows.Forms.Padding(5);
            this.PanelRank.Size = new System.Drawing.Size(994, 461);
            this.PanelRank.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Honeydew;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ranking de Usuarios";
            // 
            // ButtonReload
            // 
            this.ButtonReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ButtonReload.FlatAppearance.BorderSize = 2;
            this.ButtonReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ButtonReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(13)))), ((int)(((byte)(16)))));
            this.ButtonReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReload.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ButtonReload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.ButtonReload.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ButtonReload.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
            this.ButtonReload.IconSize = 32;
            this.ButtonReload.Location = new System.Drawing.Point(932, 0);
            this.ButtonReload.Name = "ButtonReload";
            this.ButtonReload.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.ButtonReload.Rotation = 0D;
            this.ButtonReload.Size = new System.Drawing.Size(62, 61);
            this.ButtonReload.TabIndex = 13;
            this.ButtonReload.UseVisualStyleBackColor = true;
            this.ButtonReload.Click += new System.EventHandler(this.ButtonReload_Click);
            // 
            // RankingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.PanelRank);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankingForm";
            this.Text = "Ranking";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel PanelRank;
        private FontAwesome.Sharp.IconButton ButtonReload;
    }
}