using Proyecto_Final_de_Fisica.Forms_Display.Questionaire;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Forms_Display
{
    public partial class QuestionFinish : Form
    {
        public QuestionsMain Father { get; set; }
        public DatabaseClass.Questionaire Questionario { get; set; }

        public QuestionFinish()
        {
            InitializeComponent();
        }

        public QuestionFinish(QuestionsMain father)
        {
            InitializeComponent();
            this.Father = father;
            Questionario = Father.CurrentQuestionaire;

            int Max = Questionario.Preguntas.Count;
            int Correctas = Father.correct;

            string BaseString = "Has respondido correctamente " + Correctas + " preguntas de " + Max + " en total. ";
            PrepareDataToShow(Max, Correctas, BaseString);

            
        }

        private int Percent(int Total, int Part)
        {
            //P/T == %/100

            //P*100/T

            return (Part *100)/Total;
        }

        private void PrepareDataToShow(int Total, int Part, string Suplement)
        {
            if (Percent(Total, Part) == 100)
            {
                Pic.Image = Properties.Resources.checked_cloud;
                LblSuplement.Text = Suplement + "Lo has hecho estupendo no se puede pedir nada más.";

            }
            if (Percent(Total, Part) < 100)
            {
                Pic.Image = Properties.Resources.book_cloud;
                LblSuplement.Text = Suplement + "Si estudias un poco más puedes obtener una mejor puntuación.";
            }
            if (Percent(Total, Part) < 65)
            {
                Pic.Image = Properties.Resources.warning_cloud;
                LblSuplement.Text = Suplement + "Es imperativo el que estudies más.";
            }
            if (Percent(Total, Part) == 0)
            {
                Pic.Image = Properties.Resources.error_cloud;
                LblSuplement.Text = Suplement + "Esto parece una broma. ¿ Seguro que intentaste acertar alguna ?";
            }
        }

        private void ButtonVerify_Click(object sender, EventArgs e)
        {
            Father.FatherForm.FatherForm.USER_DASHBOARD.LoadUserData();
            Father.ButtonInterrupt_Click(sender, e);
            this.Dispose();
            Close();
        }

       

        //this.Pic.Image = global::Proyecto_Final_de_Fisica.Properties.Resources.questions_cloud;
    }
}
