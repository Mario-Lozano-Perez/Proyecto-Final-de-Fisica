using fruslib;
using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Frms
{
    public partial class QuestionManageForm : Form
    {
        private QuestionsListForm FATHER_FORM;
        private Question currentQuestion;
        private bool isEditing = false;

        public QuestionManageForm()
        {
            InitializeComponent();
        }

        public QuestionManageForm(QuestionsListForm fatherForm, Question currentQuestion)
        {
            InitializeComponent();
            isEditing = true;
            FATHER_FORM = fatherForm;
            this.currentQuestion = currentQuestion;

            KtextText.Value = currentQuestion.QuestionText;
            KtextTittle.Value = currentQuestion.Tittle;

            qst_1.Value = currentQuestion.ArrayOfPosiblesQuestions[0];
            qst_2.Value = currentQuestion.ArrayOfPosiblesQuestions[1];
            qst_3.Value = currentQuestion.ArrayOfPosiblesQuestions[2];
            qst_4.Value = currentQuestion.ArrayOfPosiblesQuestions[3];

            switch (currentQuestion.CorrectQuestionNumber)
            {
                case 0:
                    qst_1.IsSelected = true;
                    break;

                case 1:
                    qst_2.IsSelected = true;
                    break;

                case 2:
                    qst_3.IsSelected = true;
                    break;

                case 3:
                    qst_4.IsSelected = true;
                    break;

                default:
                    qst_1.IsSelected = true;
                    break;
            }
        }

        public QuestionManageForm(QuestionsListForm fatherForm)
        {
            InitializeComponent();
            FATHER_FORM = fatherForm;
        }

        private int GetSelectedIndex()
        {
            if (qst_1.IsSelected) return 0;
            if (qst_2.IsSelected) return 1;
            if (qst_3.IsSelected) return 2;
            if (qst_4.IsSelected) return 3;

            return 0;
        }

        private void ToggleChek(KstomChekTextBox checkText)
        {
            foreach (var item in pnl_Main.Controls)
            {
                if (item.GetType() == checkText.GetType())
                {
                    var temp = (KstomChekTextBox)item;

                    if (checkText.IsSelected && temp != checkText)
                        temp.IsSelected = false;
                }
            }
        }

        private void Qst_1_Click(object sender, EventArgs e)
        {
            ToggleChek(qst_1);
        }

        private void Qst_2_Click(object sender, EventArgs e)
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

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            try
            {
                if (isEditing)
                {
                    UpdateCurrentQuestion();
                }
                else
                {
                    CreateNewQuestion();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UpdateCurrentQuestion()
        {
            if (currentQuestion != null)
            {
                if (KtextTittle.Value == "")
                {
                    KtextTittle.IsWrong();
                    return;
                }

                if (KtextText.Value == "")
                {
                    KtextText.IsWrong();
                    return;
                }

                currentQuestion.Tittle = KtextTittle.Value;
                currentQuestion.QuestionText = KtextText.Value;

                currentQuestion.ArrayOfPosiblesQuestions = new String[] { qst_1.Value, qst_2.Value, qst_3.Value, qst_4.Value };

                currentQuestion.CorrectQuestionNumber = GetSelectedIndex();

                currentQuestion.Update();


                FATHER_FORM.SearchData();
                this.Dispose();
            }
        }

        //CreateNewQuestion

        private void CreateNewQuestion()
        {
            if (currentQuestion == null)
            {
                if (KtextTittle.Value == "")
                {
                    KtextTittle.IsWrong();
                    return;
                }

                if (KtextText.Value == "")
                {
                    KtextText.IsWrong();
                    return;
                }

                currentQuestion = new Question();
                currentQuestion.Tittle = KtextTittle.Value;
                currentQuestion.QuestionText = KtextText.Value;

                currentQuestion.ArrayOfPosiblesQuestions = new String[] { qst_1.Value, qst_2.Value, qst_3.Value, qst_4.Value };

                currentQuestion.CorrectQuestionNumber = GetSelectedIndex();

                currentQuestion.Insert();

                currentQuestion = null;

                KtextText.Value = KtextTittle.Value = "";

                qst_1.Value = qst_2.Value = qst_3.Value = qst_4.Value = "Posible respuesta";
                qst_1.IsSelected = qst_2.IsSelected = qst_3.IsSelected = qst_4.IsSelected = false;

                FATHER_FORM.SearchData();
                this.Dispose();
            }
        }

    }
}
