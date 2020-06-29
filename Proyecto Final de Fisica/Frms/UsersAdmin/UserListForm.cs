using fruslib;
using System;
using System.Windows.Forms;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System.IO;

namespace Proyecto_Final_de_Fisica.Frms
{
    public partial class UserListForm : Form
    {
        private readonly string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        private frm_AdminDashboard adminForm;
        private User UserToDelete;

        public UserListForm()
        {
            InitializeComponent();
        }

        public UserListForm(frm_AdminDashboard adminForm)
        {
            this.adminForm = adminForm;
            InitializeComponent();
            ReadData();
            txt_SearchFied.Focus();
        }


        public void ReadData()
        {

            var Datos = SqliteHelper.LlenarDataSet(databasePath, "SELECT id as \"ID\", ci as \"CI\", name as \"Nombre\", level as \"Nivel\" from users where name LIKE '%" + txt_SearchFied.Text + "%' OR ci LIKE '%" + txt_SearchFied.Text + "%'").Tables[0];
            dgv_List.DataSource = Datos;

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(this.adminForm, this.adminForm.fatherForm.pnl_FormContainer);
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            FormManageUserValues frmUserToCreate = new FormManageUserValues(this);
            frmUserToCreate.Show();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            var text = dgv_List.SelectedRows[0].Cells[1].Value.ToString();
            var User = new User(text);
            FormManageUserValues frmUserToCreate = new FormManageUserValues(this, User);
            frmUserToCreate.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            var text = dgv_List.SelectedRows[0].Cells[1].Value.ToString();
            UserToDelete = new User(text);
            pnl_ConfirmDeleteBack.Visible = true;
            lbl_UserToDeleteName.Text = this.UserToDelete.ToString();
        }

        private void Btn_CancelDelete_Click(object sender, EventArgs e)
        {
            pnl_ConfirmDeleteBack.Visible = false;
            this.UserToDelete = null;
        }

        private void Btn_ConfirmDelete_Click(object sender, EventArgs e)
        {
            this.UserToDelete.Delete();
            this.UserToDelete = null;
            pnl_ConfirmDeleteBack.Visible = false;
            this.ReadData();
        }

        private void Txt_SearchFied_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
