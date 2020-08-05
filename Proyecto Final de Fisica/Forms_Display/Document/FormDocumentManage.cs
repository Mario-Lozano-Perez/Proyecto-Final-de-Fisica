using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;

namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    public partial class FormDocumentManage : Form
    {
        frm_AdminDashboard FatherForm;
        DatabaseClass.Document CURRENT_DOCUMENT;

        public FormDocumentManage()
        {
            InitializeComponent();
        }

        public FormDocumentManage(frm_AdminDashboard FatherForm)
        {
            InitializeComponent();
            SearchData();
            this.FatherForm = FatherForm;
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(FatherForm, FatherForm.fatherForm.pnl_FormContainer);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        public void SearchData()
        {
            dgv_List.DataSource = DatabaseClass.Document.Find(txt_SearchFied.Text);
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            FormDocumentCU createForm = new FormDocumentCU(this);
            createForm.Show();
        }

        private void Dgv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());

                CURRENT_DOCUMENT = new DatabaseClass.Document(id);

                TextTittle.Text = CURRENT_DOCUMENT.Title;

            }
            catch (Exception)
            {
                CURRENT_DOCUMENT = null;
                //MessageBox.Show(error.Message);
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (CURRENT_DOCUMENT != null)
            {
                CURRENT_DOCUMENT.OpenFileUrl();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (CURRENT_DOCUMENT != null)
            {
                pnl_ConfirmDeleteBack.Visible = true;
                lbl_UserToDeleteName.Text = CURRENT_DOCUMENT.Title;
            }
        }

        private void Btn_ConfirmDelete_Click(object sender, EventArgs e)
        {
            if (CURRENT_DOCUMENT != null)
            {
                try
                {
                    CURRENT_DOCUMENT.Delete();
                    CURRENT_DOCUMENT = null;
                    SearchData();
                    pnl_ConfirmDeleteBack.Visible = false;
                }
                catch (Exception err)
                {
                    new MessageForm(0, err.Message);
                }
            }
        }

        private void Btn_CancelDelete_Click(object sender, EventArgs e)
        {
            pnl_ConfirmDeleteBack.Visible = false;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (CURRENT_DOCUMENT != null)
            {
                FormDocumentCU form = new FormDocumentCU(this, CURRENT_DOCUMENT);
                form.Show();
            }
        }

    }


}
