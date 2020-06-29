using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.DatabaseClass
{
    public class Questionaire
    {
        private readonly static string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        public User Usuario { get; set; }
        public List<Question> Preguntas { get; set; }
        public int Points { get; set; }

        public Questionaire(User Usuario, int AmountOfQuestions = 10)
        {
            this.Usuario = Usuario;
            StartQuestionaire(AmountOfQuestions);
        }

        public void StartQuestionaire(int AmountOfQuestions = 10)
        {
            try
            {
                Preguntas = Question.FindRandomArray(AmountOfQuestions);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //throw;
            }
        }

        public void Insert()
        {
            try
            {
                string query = "INSERT INTO questionaire (user_id,points) VALUES ('" + Usuario.Id + "', '" + Points + "')";
                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
