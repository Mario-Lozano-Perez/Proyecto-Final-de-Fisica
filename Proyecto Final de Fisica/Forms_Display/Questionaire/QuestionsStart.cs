using fruslib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    public partial class QuestionsStart : Form
    {
        public MainForm FatherForm { get; set; }
        public QuestionsMain NextQuestionArea { get; set; }
        public DatabaseClass.Questionaire Questionaire { get; set; }

        public QuestionsStart()
        {
            InitializeComponent();
        }

        public QuestionsStart(MainForm fatherForm)
        {
            InitializeComponent();
            FatherForm = fatherForm;
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                int value = Convert.ToInt32(TextMaxNumber.Text);
                int CuestionMaxNumber = Convert.ToInt32(TextMaxNumber.Text);
                Questionaire = new DatabaseClass.Questionaire(FatherForm.CURRENT_USER, CuestionMaxNumber);
                NextQuestionArea = new QuestionsMain(this);
                MostUsed.OpenFormInPanel(NextQuestionArea, FatherForm.pnl_FormContainer);
            }
            catch (Exception)
            {

            }


        }
    }
}
