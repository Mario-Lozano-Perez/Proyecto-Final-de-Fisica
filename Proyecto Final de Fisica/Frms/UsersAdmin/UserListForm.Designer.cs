namespace Proyecto_Final_de_Fisica.Frms
{
    partial class UserListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_List = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_SearchFied = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Search = new FontAwesome.Sharp.IconButton();
            this.btn_Register = new FontAwesome.Sharp.IconButton();
            this.btn_Edit = new FontAwesome.Sharp.IconButton();
            this.btn_Delete = new FontAwesome.Sharp.IconButton();
            this.pnl_ConfirmDeleteBack = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_CancelDelete = new FontAwesome.Sharp.IconButton();
            this.btn_ConfirmDelete = new FontAwesome.Sharp.IconButton();
            this.lbl_UserToDeleteName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_ConfirmDeleteBack.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_List
            // 
            this.dgv_List.AllowUserToAddRows = false;
            this.dgv_List.AllowUserToDeleteRows = false;
            this.dgv_List.AllowUserToOrderColumns = true;
            this.dgv_List.AllowUserToResizeRows = false;
            this.dgv_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_List.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_List.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgv_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_List.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_List.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(181)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_List.EnableHeadersVisualStyles = false;
            this.dgv_List.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgv_List.Location = new System.Drawing.Point(35, 82);
            this.dgv_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_List.MultiSelect = false;
            this.dgv_List.Name = "dgv_List";
            this.dgv_List.ReadOnly = true;
            this.dgv_List.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_List.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_List.RowHeadersVisible = false;
            this.dgv_List.RowTemplate.Height = 24;
            this.dgv_List.RowTemplate.ReadOnly = true;
            this.dgv_List.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_List.ShowEditingIcon = false;
            this.dgv_List.Size = new System.Drawing.Size(973, 434);
            this.dgv_List.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_Back);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(35, 21);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista de Usuarios Registrados";
            // 
            // btn_Back
            // 
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_Back.FlatAppearance.BorderSize = 0;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Back.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btn_Back.IconColor = System.Drawing.Color.White;
            this.btn_Back.IconSize = 25;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Rotation = 0D;
            this.btn_Back.Size = new System.Drawing.Size(49, 49);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_Search);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(545, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(428, 49);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_SearchFied);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.panel3.Size = new System.Drawing.Size(369, 39);
            this.panel3.TabIndex = 1;
            // 
            // txt_SearchFied
            // 
            this.txt_SearchFied.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txt_SearchFied.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SearchFied.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_SearchFied.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SearchFied.ForeColor = System.Drawing.Color.White;
            this.txt_SearchFied.Location = new System.Drawing.Point(5, 5);
            this.txt_SearchFied.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SearchFied.Name = "txt_SearchFied";
            this.txt_SearchFied.Size = new System.Drawing.Size(359, 27);
            this.txt_SearchFied.TabIndex = 4;
            this.txt_SearchFied.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_SearchFied.TextChanged += new System.EventHandler(this.Txt_SearchFied_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(5, 34);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 2);
            this.panel4.TabIndex = 0;
            // 
            // btn_Search
            // 
            this.btn_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Search.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btn_Search.FlatAppearance.BorderSize = 0;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Search.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_Search.IconColor = System.Drawing.Color.White;
            this.btn_Search.IconSize = 20;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Search.Location = new System.Drawing.Point(374, 5);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btn_Search.Rotation = 0D;
            this.btn_Search.Size = new System.Drawing.Size(49, 39);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
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
            this.btn_Register.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btn_Register.IconColor = System.Drawing.Color.White;
            this.btn_Register.IconSize = 24;
            this.btn_Register.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Register.Location = new System.Drawing.Point(789, 532);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_Register.Rotation = 0D;
            this.btn_Register.Size = new System.Drawing.Size(219, 39);
            this.btn_Register.TabIndex = 2;
            this.btn_Register.Text = "Registrar Usuario";
            this.btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.Btn_Register_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.FlatAppearance.BorderSize = 0;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Edit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.Color.White;
            this.btn_Edit.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btn_Edit.IconColor = System.Drawing.Color.White;
            this.btn_Edit.IconSize = 24;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Edit.Location = new System.Drawing.Point(616, 532);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btn_Edit.Rotation = 0D;
            this.btn_Edit.Size = new System.Drawing.Size(167, 39);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Modificar";
            this.btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.UseVisualStyleBackColor = false;
            this.btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btn_Delete.IconColor = System.Drawing.Color.White;
            this.btn_Delete.IconSize = 24;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.Location = new System.Drawing.Point(445, 532);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.btn_Delete.Rotation = 0D;
            this.btn_Delete.Size = new System.Drawing.Size(164, 39);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "Eliminar";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // pnl_ConfirmDeleteBack
            // 
            this.pnl_ConfirmDeleteBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(57)))), ((int)(((byte)(66)))));
            this.pnl_ConfirmDeleteBack.Controls.Add(this.panel6);
            this.pnl_ConfirmDeleteBack.Location = new System.Drawing.Point(308, 201);
            this.pnl_ConfirmDeleteBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_ConfirmDeleteBack.Name = "pnl_ConfirmDeleteBack";
            this.pnl_ConfirmDeleteBack.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_ConfirmDeleteBack.Size = new System.Drawing.Size(427, 187);
            this.pnl_ConfirmDeleteBack.TabIndex = 5;
            this.pnl_ConfirmDeleteBack.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.panel6.Controls.Add(this.btn_CancelDelete);
            this.panel6.Controls.Add(this.btn_ConfirmDelete);
            this.panel6.Controls.Add(this.lbl_UserToDeleteName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(421, 183);
            this.panel6.TabIndex = 0;
            // 
            // btn_CancelDelete
            // 
            this.btn_CancelDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn_CancelDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CancelDelete.FlatAppearance.BorderSize = 0;
            this.btn_CancelDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_CancelDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CancelDelete.ForeColor = System.Drawing.Color.White;
            this.btn_CancelDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_CancelDelete.IconColor = System.Drawing.Color.White;
            this.btn_CancelDelete.IconSize = 30;
            this.btn_CancelDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_CancelDelete.Location = new System.Drawing.Point(221, 127);
            this.btn_CancelDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_CancelDelete.Name = "btn_CancelDelete";
            this.btn_CancelDelete.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_CancelDelete.Rotation = 0D;
            this.btn_CancelDelete.Size = new System.Drawing.Size(77, 39);
            this.btn_CancelDelete.TabIndex = 5;
            this.btn_CancelDelete.Text = "No";
            this.btn_CancelDelete.UseVisualStyleBackColor = false;
            this.btn_CancelDelete.Click += new System.EventHandler(this.Btn_CancelDelete_Click);
            // 
            // btn_ConfirmDelete
            // 
            this.btn_ConfirmDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.btn_ConfirmDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ConfirmDelete.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_ConfirmDelete.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmDelete.ForeColor = System.Drawing.Color.White;
            this.btn_ConfirmDelete.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.btn_ConfirmDelete.IconColor = System.Drawing.Color.White;
            this.btn_ConfirmDelete.IconSize = 30;
            this.btn_ConfirmDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ConfirmDelete.Location = new System.Drawing.Point(305, 127);
            this.btn_ConfirmDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ConfirmDelete.Name = "btn_ConfirmDelete";
            this.btn_ConfirmDelete.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btn_ConfirmDelete.Rotation = 0D;
            this.btn_ConfirmDelete.Size = new System.Drawing.Size(99, 39);
            this.btn_ConfirmDelete.TabIndex = 4;
            this.btn_ConfirmDelete.Text = "Si";
            this.btn_ConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConfirmDelete.UseVisualStyleBackColor = false;
            this.btn_ConfirmDelete.Click += new System.EventHandler(this.Btn_ConfirmDelete_Click);
            // 
            // lbl_UserToDeleteName
            // 
            this.lbl_UserToDeleteName.AutoSize = true;
            this.lbl_UserToDeleteName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserToDeleteName.ForeColor = System.Drawing.Color.Silver;
            this.lbl_UserToDeleteName.Location = new System.Drawing.Point(15, 74);
            this.lbl_UserToDeleteName.Name = "lbl_UserToDeleteName";
            this.lbl_UserToDeleteName.Size = new System.Drawing.Size(171, 25);
            this.lbl_UserToDeleteName.TabIndex = 2;
            this.lbl_UserToDeleteName.Text = "Nombre a remover";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(16, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Desea eliminar a:";
            // 
            // UserListForm
            // 
            this.AcceptButton = this.btn_Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1043, 594);
            this.Controls.Add(this.pnl_ConfirmDeleteBack);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_List);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_List)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_ConfirmDeleteBack.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_List;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_SearchFied;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btn_Back;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btn_Register;
        private FontAwesome.Sharp.IconButton btn_Edit;
        private FontAwesome.Sharp.IconButton btn_Delete;
        private FontAwesome.Sharp.IconButton btn_Search;
        private System.Windows.Forms.Panel pnl_ConfirmDeleteBack;
        private System.Windows.Forms.Panel panel6;
        private FontAwesome.Sharp.IconButton btn_CancelDelete;
        private FontAwesome.Sharp.IconButton btn_ConfirmDelete;
        private System.Windows.Forms.Label lbl_UserToDeleteName;
        private System.Windows.Forms.Label label2;
    }
}