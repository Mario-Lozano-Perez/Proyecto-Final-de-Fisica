using fruslib;
using Proyecto_Final_de_Fisica.Forms_Display.Document;
using Proyecto_Final_de_Fisica.Frms;
using Proyecto_Final_de_Fisica.Frms.VideosAdmin;
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

namespace Proyecto_Final_de_Fisica
{
    public partial class frm_AdminDashboard : Form
    {
        UserListForm userListForm;
        QuestionsListForm questionsListForm;
        VideosListForm videoListForm;
        FormDocumentManage documentListForm;

        private readonly string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        public MainForm fatherForm;

        public frm_AdminDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        public frm_AdminDashboard(MainForm fatherForm)
        {
            InitializeComponent();
            this.userListForm = new UserListForm(this);
            this.questionsListForm = new QuestionsListForm(this);
            videoListForm = new VideosListForm(this);
            documentListForm = new FormDocumentManage(this);
            this.fatherForm = fatherForm;
            LoadData();
        }

        public void LoadData()
        {
            int userCount = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM users").Tables[0].Rows.Count;
            lbl_UserCount.Text = userCount.ToString();

            var topUserData = SqliteHelper.LlenarDataSet(databasePath, "Select name from ranking limit 1").Tables[0];

            try
            {
                string UserName = topUserData.Rows[0]["name"].ToString();
                LabelTopUser.Text = UserName;
            }
            catch (Exception _)
            {
                LabelTopUser.Text = "Actualmente no hay ranking";
            }

            LabelQuestionairesAmount.Text = SqliteHelper.LlenarDataSet(databasePath, "Select count(id) as count from questionaire").Tables[0].Rows[0]["count"].ToString();

            LabelVideosAmount.Text = SqliteHelper.LlenarDataSet(databasePath, "Select count(id) as count from videos").Tables[0].Rows[0]["count"].ToString();

            LabelQuestionsAmount.Text = SqliteHelper.LlenarDataSet(databasePath, "Select count(id) as count from questions").Tables[0].Rows[0]["count"].ToString();

        }

        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_usersList_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(userListForm, this.fatherForm.pnl_FormContainer);
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(questionsListForm, this.fatherForm.pnl_FormContainer);
        }

        private void Btn_Videos_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(videoListForm, this.fatherForm.pnl_FormContainer);
        }

        private void Btn_Documents_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(documentListForm, this.fatherForm.pnl_FormContainer);

        }
    }
}
