using System;
using System.Windows.Forms;
using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using Proyecto_Final_de_Fisica.Forms_Display;
using Proyecto_Final_de_Fisica.Forms_Display.Document;

namespace Proyecto_Final_de_Fisica
{
    public partial class MainForm : Form
    {
        private readonly frm_Logg LOGGER_FORM;

        public FormUsserDashBoard USER_DASHBOARD;
        public frm_AdminDashboard ADMIN_DASHBOARD;
        public Forms_Display.Questionaire.QuestionsStart QUESTIONAIRE_START;
        public FormViewVideos VIDEOS_VIEW;
        public Config CONFIGURATION;
        public User CURRENT_USER;
        public Forms_Display.Questionaire.RankingForm RANKING_FORM;
        public FormDocumentView DOCUMENTS_FORM;

        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(User CurrentUser, frm_Logg LogForm)
        {
            LOGGER_FORM = LogForm;
            CURRENT_USER = CurrentUser;


            InitializeComponent();
            InitializeForms();

            if (CURRENT_USER.Level < 1)
            {
                btn_adminPanel.Hide();
            }
        }

        private void InitializeForms()
        {
            USER_DASHBOARD = new FormUsserDashBoard(this);
            ADMIN_DASHBOARD = new frm_AdminDashboard(this);
            VIDEOS_VIEW = new FormViewVideos(this);
            QUESTIONAIRE_START = new Forms_Display.Questionaire.QuestionsStart(this);
            RANKING_FORM = new Forms_Display.Questionaire.RankingForm(this);
            DOCUMENTS_FORM = new FormDocumentView(this);

            //Load the User DashBoard
            MostUsed.OpenFormInPanel(USER_DASHBOARD, pnl_FormContainer);
        }

        private void ExitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeProgram(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Home_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(USER_DASHBOARD, pnl_FormContainer);
        }

        private void Btn_adminPanel_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(ADMIN_DASHBOARD, pnl_FormContainer);
        }


        //============================Public Methods====================================

        public void LogOut(object sender, EventArgs e)
        {
            LOGGER_FORM.Show();
            Dispose();
        }

        public void CerrarSeciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogOut(null, e);
        }

        public void InicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Btn_Home_Click(null, e);
        }

        public void ButtonVideos_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(VIDEOS_VIEW, pnl_FormContainer);
        }

        public void ButtonQuestionaire_Click(object sender, EventArgs e)
        {
            if (QUESTIONAIRE_START.NextQuestionArea == null) MostUsed.OpenFormInPanel(QUESTIONAIRE_START, pnl_FormContainer);
            else
            {
                if (QUESTIONAIRE_START.NextQuestionArea.FinishForm == null)
                {
                    MostUsed.OpenFormInPanel(QUESTIONAIRE_START.NextQuestionArea, pnl_FormContainer);
                }
                else
                {
                    MostUsed.OpenFormInPanel(QUESTIONAIRE_START.NextQuestionArea.FinishForm, pnl_FormContainer);
                }
            }
        }

        private void ButtonTrophy_Click(object sender, EventArgs e)
        {
            RANKING_FORM.StartReading();
            MostUsed.OpenFormInPanel(RANKING_FORM, pnl_FormContainer);
        }

        private void ButtonDocuments_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(DOCUMENTS_FORM, pnl_FormContainer);
        }
    }
}
