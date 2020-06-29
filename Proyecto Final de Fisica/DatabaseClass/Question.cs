using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_Fisica.DatabaseClass
{
    public class Question
    {
        private static readonly string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        public int ID { get; set; }
        public string Tittle { get; set; }
        public string QuestionText { get; set; }
        public string[] ArrayOfPosiblesQuestions { get; set; }
        public int CorrectQuestionNumber { get; set; }
        private readonly string[] delimiters = { "-|-" };

        public override string ToString()
        {
            return base.ToString();
        }

        public Question() { }
        public Question(int ID)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM questions WHERE id = '" + ID + "'");
            if (DataReceived.Tables[0].Rows.Count == 0)
            {
                throw new IndexOutOfRangeException("No hay ningun usuario registrado con ese carnet de identidad.");
            }
            else
            {
                this.ID = ID;
                QuestionText = DataReceived.Tables[0].Rows[0]["text"].ToString();
                Tittle = DataReceived.Tables[0].Rows[0]["tittle"].ToString();
                ArrayOfPosiblesQuestions = DataReceived.Tables[0].Rows[0]["questions_text"].ToString().Split(delimiters, StringSplitOptions.None);
                CorrectQuestionNumber = Convert.ToInt32(DataReceived.Tables[0].Rows[0]["correct_question"].ToString());
            }
        }

        public static System.Data.DataTable FindAll()
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM questions").Tables[0];
            return DataReceived;
        }

        public static System.Data.DataTable FindAll(string param)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath,
                "SELECT id, tittle as \"Titulo\" FROM questions WHERE id LIKE '%" + param + "%' OR tittle LIKE '%" + param + "%'").
                Tables[0];
            return DataReceived;
        }

        public static System.Data.DataTable FindOne(string paramToSearch)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM questions WHERE id LIKE '%" + paramToSearch + "%' OR text LIKE '%" + paramToSearch + "%'").Tables[0];
            return DataReceived;
        }

        private string ConcatenatedArrayOfQuestions()
        {
            string valueToReturn = "";

            for (int i = 0; i < ArrayOfPosiblesQuestions.Length; i++)
            {
                if (i < ArrayOfPosiblesQuestions.Length - 1)
                {
                    valueToReturn += ArrayOfPosiblesQuestions[i] + "-|-";
                }
                else
                {
                    valueToReturn += ArrayOfPosiblesQuestions[i];
                }
            }

            return valueToReturn;
        }

        public void Insert()
        {
            try
            {
                /*string query = "INSERT INTO questions (text,questions_text,correct_question, tittle) VALUES ('" + QuestionText + "','" + ConcatenatedArrayOfQuestions() + "','" + CorrectQuestionNumber + "','"+Tittle+"'')";*/

                string query = "INSERT INTO questions (tittle,text,questions_text, correct_question) VALUES ('" +
                    this.Tittle + "','" + this.QuestionText + "','" + this.ConcatenatedArrayOfQuestions() + "','" +
                    this.CorrectQuestionNumber + "')";

                /*string query = "INSERT INTO users (ci,name,password,level) VALUES ('" + this.Ci + "','" + this.Name + "','" + this.Password + "','" + this.Level.ToString() + "')";*/


                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public static void DeleteByID(int id)
        {
            try
            {
                string query = "DELETE FROM questions WHERE id = '" + id + "'";
                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update()
        {
            try
            {
                string query = "UPDATE questions SET tittle = '" + Tittle + "', text = '" + QuestionText + "', questions_text = '" + ConcatenatedArrayOfQuestions() + "', correct_question = '" + CorrectQuestionNumber + "' WHERE id = '" + ID + "'";
                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception)
            {
                throw;
            }

        }

        public void Delete()
        {
            try
            {
                string query = "DELETE FROM questions WHERE id = '" + this.ID + "'";
                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Question> FindRandomArray(int parameters)
        {
            string query = "SELECT id FROM questions WHERE id IN (SELECT id FROM questions ORDER BY RANDOM() LIMIT " + parameters + ") ORDER BY RANDOM()";
            //return DataReceived;

            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, query).Tables[0];

            List<Question> questionListResult = new List<Question>();

            for (int i = 0; i < DataReceived.Rows.Count; i++)
            {
                int id = Convert.ToInt32(DataReceived.Rows[i]["id"].ToString());
                Question currentQuestion = new Question(id);
                questionListResult.Add(currentQuestion);
            }

            return questionListResult;
        }


        public static List<User> GetRanking()
        {
            string query = "SELECT user_id FROM ranking";
            //return DataReceived;

            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, query).Tables[0];

            List<User> questionListResult = new List<User>();

            for (int i = 0; i < DataReceived.Rows.Count; i++)
            {
                int UserId = Convert.ToInt32(DataReceived.Rows[i]["user_id"].ToString());
                User currentQuestion = new User(UserId);
                questionListResult.Add(currentQuestion);

            }

            return questionListResult;
        }
    }
}
