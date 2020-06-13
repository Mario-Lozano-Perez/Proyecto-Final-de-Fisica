using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica
{
    public partial class FormUsserDashBoard : Form
    {
        public MainForm fatherForm;
        private Panel formsHolder;
        private User CurrentUser;

        public FormUsserDashBoard()
        {
            InitializeComponent();
        }

        public FormUsserDashBoard(MainForm fatherForm)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            formsHolder = fatherForm.pnl_FormContainer;
            CurrentUser = fatherForm.CurrentUser;

            LoadUserData();
        }

        public void LoadUserData()
        {
            lbl_userName.Text = this.CurrentUser.Name;
            LabelPoints.Text = CurrentUser.GetPoints().ToString();
            PictureUserSex.Image = CurrentUser.GetSexImage();
            int RankingPosition = CurrentUser.GetRankingPosition();

            LabelRankingPos.Text = "Posición en el ranking: " + RankingPosition;
            if (RankingPosition <= 0) LabelRankingPos.Text = "Debes realizar cuestionarios para entrar en el ranking.";

            LabelQuestionairesTaken.Text = "Cuestionarios Realizados: " + CurrentUser.GetAmountOfQuestionaires();
        }

        private void Btn_books_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(fatherForm.videosView, this.formsHolder);
        }

        private void SystemLogout(object sender, EventArgs e)
        {
            fatherForm.LogOut(sender, e);
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            fatherForm.ButtonQuestionaire_Click(sender, e);
        }

        private void BtnRedo_Click(object sender, EventArgs e)
        {
            LoadUserData();
        }

        private void ButtonRanking_Click(object sender, EventArgs e)
        {
            fatherForm.rankingForm.StartReading();

            MostUsed.OpenFormInPanel(fatherForm.rankingForm, fatherForm.pnl_FormContainer);
        }
    }
}
