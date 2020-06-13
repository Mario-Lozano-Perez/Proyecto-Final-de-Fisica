using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Frms
{
    public partial class QuestionsListForm : Form
    {
        private int questionIdToDelete;
        private frm_AdminDashboard adminForm;

        public QuestionsListForm()
        {
            InitializeComponent();
            SearchData();

        }

        public QuestionsListForm(frm_AdminDashboard adminForm)
        {
            this.adminForm = adminForm;
            InitializeComponent();
            SearchData();
            txt_SearchFied.Focus();
        }

        private void Btn_Back_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(adminForm, adminForm.fatherForm.pnl_FormContainer);
        }


        public void SearchData()
        {
            dgv_List.DataSource = Question.FindAll(txt_SearchFied.Text);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                questionIdToDelete = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());
                pnl_ConfirmDeleteBack.Visible = true;
                var tittle = dgv_List.SelectedRows[0].Cells[1].Value.ToString();
                lbl_UserToDeleteName.Text = tittle;
            }
            catch (Exception) { }
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            QuestionManageForm frm = new QuestionManageForm(this);
            frm.Show();
        }

        private void ToggleChek(KstomChekTextBox checkText)
        {
            foreach (var item in pnl_view.Controls)
            {
                if (item.GetType() == checkText.GetType())
                {
                    var temp = (KstomChekTextBox)item;

                    if (checkText.IsSelected && temp != checkText)
                        temp.IsSelected = false;
                }
            }
        }

        private void Dgv_List_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());

                Question selectedQuestion = new Question(id);

                txt_questText.Text = selectedQuestion.QuestionText;

                qst_1.Value = selectedQuestion.ArrayOfPosiblesQuestions[0];
                qst_2.Value = selectedQuestion.ArrayOfPosiblesQuestions[1];
                qst_3.Value = selectedQuestion.ArrayOfPosiblesQuestions[2];
                qst_4.Value = selectedQuestion.ArrayOfPosiblesQuestions[3];

                if (selectedQuestion.CorrectQuestionNumber == 0)
                {
                    qst_1.IsSelected = true;
                    qst_2.IsSelected = qst_3.IsSelected = qst_4.IsSelected = false;
                }
                if (selectedQuestion.CorrectQuestionNumber == 1)
                {
                    qst_2.IsSelected = true;
                    qst_1.IsSelected = qst_3.IsSelected = qst_4.IsSelected = false;
                }
                if (selectedQuestion.CorrectQuestionNumber == 2)
                {
                    qst_3.IsSelected = true;
                    qst_1.IsSelected = qst_2.IsSelected = qst_4.IsSelected = false;
                }
                if (selectedQuestion.CorrectQuestionNumber == 3)
                {
                    qst_4.IsSelected = true;
                    qst_2.IsSelected = qst_3.IsSelected = qst_1.IsSelected = false;
                }


            }
            catch (Exception)
            {
                //MessageBox.Show(error.Message);
            }
        }

        private void Qst_1_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(qst_1);
        }

        private void Qst_2_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(qst_2);
        }

        private void Qst_3_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(qst_3);
        }

        private void Qst_4_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(qst_4);
        }

        private void Btn_CancelDelete_Click(object sender, EventArgs e)
        {
            pnl_ConfirmDeleteBack.Visible = false;
            questionIdToDelete = -1;
        }

        private void Btn_ConfirmDelete_Click(object sender, EventArgs e)
        {
            if(questionIdToDelete >= 0)

            try
            {
                var id = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());
                Question.DeleteByID(questionIdToDelete);
                pnl_ConfirmDeleteBack.Visible = false;
                SearchData();
                questionIdToDelete = -1;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Btn_Edit_Click_1(object sender, EventArgs e)
        {
            try
            {
                var id = Convert.ToInt32(dgv_List.SelectedRows[0].Cells[0].Value.ToString());
                Question questionToEdit = new Question(id);
                QuestionManageForm formToLaunch = new QuestionManageForm(this, questionToEdit);
                formToLaunch.Show();

            }
            catch (Exception)
            {

            }
        }
    }
}
