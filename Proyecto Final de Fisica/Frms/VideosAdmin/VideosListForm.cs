using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Frms.VideosAdmin
{

    public partial class VideosListForm : Form
    {
        frm_AdminDashboard FatherForm;
        Video currentVideo;

        public VideosListForm()
        {
            InitializeComponent();
        }

        public VideosListForm(frm_AdminDashboard FatherForm)
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
            dgv_List.DataSource = Video.Find(txt_SearchFied.Text);
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            VideoManagement createForm = new VideoManagement(this);
            createForm.Show();
        }

        private void Dgv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());

                currentVideo = new Video(id);

                TextTittle.Text = currentVideo.Tittle;

            }
            catch (Exception)
            {
                currentVideo = null;
                //MessageBox.Show(error.Message);
            }
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            if (currentVideo != null)
            {
                currentVideo.OpenFileUrl();
            }
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (currentVideo != null)
            {
                pnl_ConfirmDeleteBack.Visible = true;
                lbl_UserToDeleteName.Text = currentVideo.Tittle;
            }
        }

        private void Btn_ConfirmDelete_Click(object sender, EventArgs e)
        {
            if(currentVideo != null)
            {
                try
                {
                    currentVideo.Delete();
                    currentVideo = null;
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
            if(currentVideo != null)
            {
                VideoManagement form = new VideoManagement(this, currentVideo);
                form.Show();
            }
        }
    }
}
