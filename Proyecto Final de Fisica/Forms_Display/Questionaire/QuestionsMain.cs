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

namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    public partial class QuestionsMain : Form
    {
        public QuestionsStart FatherForm { get; set; }
        public DatabaseClass.Questionaire CurrentQuestionaire;
        public QuestionFinish FinishForm;
        public int index = 0;
        public int correct = 0;

        public QuestionsMain()
        {
            InitializeComponent();
        }

        public QuestionsMain(QuestionsStart fatherForm)
        {
            InitializeComponent();
            FatherForm = fatherForm;
            CurrentQuestionaire = FatherForm.Questionaire;

            var QuestionNumber = CurrentQuestionaire.Preguntas.Count.ToString();

            LabelTotalQuestions.Text = "Total de Preguntas: " + QuestionNumber;

            PrepareAll();

        }


        private KstomChekBox GetCorrectCheck()
        {
            switch (CurrentQuestionaire.Preguntas[index].CorrectQuestionNumber)
            {
                case 0: return Qst1;
                case 1: return Qst2;
                case 2: return Qst3;
                case 3: return Qst4;
                default: return null;
            }
        }

        private KstomChekBox GetCorrectCheck(int Valor)
        {
            switch (Valor)
            {
                case 0: return Qst1;
                case 1: return Qst2;
                case 2: return Qst3;
                case 3: return Qst4;
                default: return null;
            }
        }

        private void ToggleChek(KstomChekBox checkText)
        {
            foreach (var item in PanelChekContain.Controls)
            {
                if (item.GetType() == checkText.GetType())
                {
                    var temp = (KstomChekBox)item;

                    if (checkText.IsSelected && temp != checkText)
                        temp.IsSelected = false;
                }
            }
        }

        private int GetSelectedCheck()
        {
            if (Qst1.IsSelected) return 0;
            if (Qst2.IsSelected) return 1;
            if (Qst3.IsSelected) return 2;
            if (Qst4.IsSelected) return 3;
            return -1;
        }

        private void PrepareAll()
        {
            var QuestionNumber = CurrentQuestionaire.Preguntas.Count;

            if ((index + 1) <= QuestionNumber)
            {
                Question currentQuestion = CurrentQuestionaire.Preguntas[index];
                LabelCurrentQuestion.Text = "Pregunta Actual: " + (index + 1).ToString();
                LabelCorrectAnswers.Text = "Respuestas Correctas: " + correct;
                LabelWrongAnswers.Text = "Respuestas Incorrectas: " + (index - correct).ToString();

                TextQuestionContent.Text = currentQuestion.QuestionText;
                LabelTitle.Text = "Titulo: " + currentQuestion.Tittle;
                LabelPoints.Text = (correct * 10).ToString();

                Qst1.Value = currentQuestion.ArrayOfPosiblesQuestions[0];
                Qst2.Value = currentQuestion.ArrayOfPosiblesQuestions[1];
                Qst3.Value = currentQuestion.ArrayOfPosiblesQuestions[2];
                Qst4.Value = currentQuestion.ArrayOfPosiblesQuestions[3];

                CurrentQuestionaire.Points = correct * 10;

            }
            else
            {
                Question currentQuestion = CurrentQuestionaire.Preguntas[index - 1];
                LabelCurrentQuestion.Text = "Pregunta Actual: " + (index).ToString();
                LabelCorrectAnswers.Text = "Respuestas Correctas: " + correct;
                LabelWrongAnswers.Text = "Respuestas Incorrectas: " + ((index) - correct).ToString();

                TextQuestionContent.Text = currentQuestion.QuestionText;
                LabelTitle.Text = "Titulo: " + currentQuestion.Tittle;
                LabelPoints.Text = (correct * 10).ToString();

                Qst1.Value = currentQuestion.ArrayOfPosiblesQuestions[0];
                Qst2.Value = currentQuestion.ArrayOfPosiblesQuestions[1];
                Qst3.Value = currentQuestion.ArrayOfPosiblesQuestions[2];
                Qst4.Value = currentQuestion.ArrayOfPosiblesQuestions[3];
            }
        }


        private void NextQuestion()
        {
            index++;
            var QuestionNumber = CurrentQuestionaire.Preguntas.Count;

            //ReColorize();
            if ((index + 1) <= QuestionNumber) ReColorize();
            PrepareAll();
        }

        private void ReColorize()
        {
            Qst1.IsSelected = Qst2.IsSelected = Qst3.IsSelected = Qst4.IsSelected = false;
            Qst1.TextColor = Qst2.TextColor = Qst3.TextColor = Qst4.TextColor = Color.FromName("Silver");
        }

        #region Change Check

        private void Qst1_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(Qst1);
        }

        private void Qst2_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(Qst2);
        }

        private void Qst3_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(Qst3);
        }

        private void Qst4_CheckChange(object sender, EventArgs e)
        {
            ToggleChek(Qst4);
        }

        #endregion

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            if(GetSelectedCheck() != -1)
            {
                Verify();
            }
        }

        private void Verify()
        {
            var QuestionNumber = CurrentQuestionaire.Preguntas.Count;

            if (buttonVerify.Text == "Verificar")
            {

                int CorrectNumber = CurrentQuestionaire.Preguntas[index].CorrectQuestionNumber;
                int SelectedBoxIndex = GetSelectedCheck();

                GetCorrectCheck().TextColor = Color.FromArgb(185, 238, 119);
                GetCorrectCheck(SelectedBoxIndex).TextColor = Color.FromArgb(234, 139, 132);

                if (SelectedBoxIndex == CorrectNumber)
                {
                    GetCorrectCheck(SelectedBoxIndex).TextColor = Color.FromArgb(152, 195, 109);
                    correct++;
                }

                if (index + 1 == QuestionNumber) NextQuestion();

                //buttonVerify.Text = "Siguiente";
                if ((index + 2) <= QuestionNumber) buttonVerify.Text = "Siguiente";
                else buttonVerify.Text = "Finalizar";
            }
            else if(buttonVerify.Text == "Siguiente")
            {
                if ((index + 1) <= QuestionNumber)
                {
                    buttonVerify.Text = "Verificar";
                    NextQuestion();
                }
                
                if(index + 1 == QuestionNumber)
                {
                    buttonVerify.Text = "Verificar";
                    PrepareAll();
                }

            }
            else
            {
                try
                {
                    CurrentQuestionaire.Insert();
                    FinishForm= new QuestionFinish(this);
                    MostUsed.OpenFormInPanel(FinishForm, FatherForm.FatherForm.pnl_FormContainer);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        public void ButtonInterrupt_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(FatherForm, FatherForm.FatherForm.pnl_FormContainer);
            FatherForm.Questionaire = null;
            FatherForm.NextQuestionArea = null;
            this.Dispose();
            this.Close();

        }
    }
}
