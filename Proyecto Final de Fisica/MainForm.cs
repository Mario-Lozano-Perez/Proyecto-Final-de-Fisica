using System;
using System.Windows.Forms;
using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using Proyecto_Final_de_Fisica.Forms_Display;

namespace Proyecto_Final_de_Fisica
{
    public partial class MainForm : Form
    {
        private readonly frm_Logg LoggerForm;

        public FormUsserDashBoard userDashboard;
        public frm_AdminDashboard adminDashboard;
        public Forms_Display.Questionaire.QuestionsStart questionaireStart;
        public FormViewVideos videosView;
        public Config configuration;
        public User CurrentUser;
        public Forms_Display.Questionaire.RankingForm rankingForm;

        public MainForm()
        {
            InitializeComponent();

        }

        public MainForm(User CurrentUser, frm_Logg LogForm)
        {
            this.LoggerForm = LogForm;
            this.CurrentUser = CurrentUser;


            InitializeComponent();
            InitializeForms();

            if (this.CurrentUser.Level < 1)
            {
                btn_adminPanel.Hide();
            }
        }

        private void InitializeForms()
        {
            this.userDashboard = new FormUsserDashBoard(this);
            this.adminDashboard = new frm_AdminDashboard(this);
            this.videosView = new FormViewVideos(this);
            this.questionaireStart = new Forms_Display.Questionaire.QuestionsStart(this);
            this.rankingForm = new Forms_Display.Questionaire.RankingForm(this);

            //Load the User DashBoard
            MostUsed.OpenFormInPanel(userDashboard, pnl_FormContainer);
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
            MostUsed.OpenFormInPanel(userDashboard, pnl_FormContainer);
        }

        private void Btn_adminPanel_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(adminDashboard, pnl_FormContainer);
        }


        //============================Public Methods====================================

        public void LogOut(object sender, EventArgs e)
        {
            LoggerForm.Show();
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
            MostUsed.OpenFormInPanel(videosView, pnl_FormContainer);
        }

        public void ButtonQuestionaire_Click(object sender, EventArgs e)
        {
            if (questionaireStart.NextQuestionArea == null) MostUsed.OpenFormInPanel(questionaireStart, pnl_FormContainer);
            else
            {
                if (questionaireStart.NextQuestionArea.FinishForm == null)
                {
                    MostUsed.OpenFormInPanel(questionaireStart.NextQuestionArea, pnl_FormContainer);
                }
                else
                {
                    MostUsed.OpenFormInPanel(questionaireStart.NextQuestionArea.FinishForm, pnl_FormContainer);
                }
            }
        }

        private void ButtonTrophy_Click(object sender, EventArgs e)
        {
            rankingForm.StartReading();
            MostUsed.OpenFormInPanel(rankingForm, pnl_FormContainer);
        }
    }
}
