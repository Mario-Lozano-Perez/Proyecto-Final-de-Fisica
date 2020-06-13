using fruslib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_Fisica.DatabaseClass
{
    public class User
    {
        private readonly string databasePath = "./database.db3";
        public string Ci { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }

        public User() { }

        public User(int ID)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(this.databasePath, "SELECT * FROM users WHERE id = '" + ID + "'");
            if (DataReceived.Tables[0].Rows.Count == 0)
            {
                throw new IndexOutOfRangeException("No hay ningun usuario registrado con ese carnet de identidad.");
            }
            else
            {
                this.Ci = DataReceived.Tables[0].Rows[0]["ci"].ToString();
                this.Id = Convert.ToInt32(DataReceived.Tables[0].Rows[0]["id"].ToString());
                this.Name = DataReceived.Tables[0].Rows[0]["name"].ToString();
                this.Password = Cipher.CesarDecifrar(DataReceived.Tables[0].Rows[0]["password"].ToString(), 5);
                this.Level = Convert.ToInt32(DataReceived.Tables[0].Rows[0]["level"].ToString());
            }
        }

        public User(string Ci)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(this.databasePath, "SELECT * FROM users WHERE ci = '" + Ci + "'");
            if (DataReceived.Tables[0].Rows.Count == 0)
            {
                throw new IndexOutOfRangeException("No hay ningun usuario registrado con ese carnet de identidad.");
            }
            else
            {
                this.Ci = Ci;
                this.Id = Convert.ToInt32(DataReceived.Tables[0].Rows[0]["id"].ToString());
                this.Name = DataReceived.Tables[0].Rows[0]["name"].ToString();
                this.Password = Cipher.CesarDecifrar(DataReceived.Tables[0].Rows[0]["password"].ToString(), 5);
                this.Level = Convert.ToInt32(DataReceived.Tables[0].Rows[0]["level"].ToString());
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public bool VerifyPassword(string passwordToVerify)
        {
            if (Password == passwordToVerify)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insert()
        {
            try
            {
                string query = "INSERT INTO users (ci,name,password,level) VALUES ('" + this.Ci + "','" + this.Name + "','" + this.Password + "','" + this.Level.ToString() + "')";

                SqliteHelper.Ejecutar_CMD("./database.db3", query);
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public void Update()
        {
            try
            {
                string query = "UPDATE users SET name = '" + Name + "', password = '" + Password + "', level = '" + Level.ToString() + "' WHERE ci = '" + Ci + "'";

                SqliteHelper.Ejecutar_CMD("./database.db3", query);

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public Image GetSexImage()
        {
            int NumericSex = Convert.ToInt32(Ci[9].ToString());

            if (NumericSex % 2 == 0) return Properties.Resources.user_male_circle;
            else return Properties.Resources.user_female_circle;

        }

        public void Delete()
        {
            try
            {
                string query = "DELETE FROM users WHERE ci = '" + Ci + "'";

                SqliteHelper.Ejecutar_CMD("./database.db3", query);

            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int GetPoints()
        {
            try
            {
                string query = "SELECT SUM(points) as \"points\" FROM questionaire WHERE user_id = '" + Id + "'";

                var DataReceived = SqliteHelper.LlenarDataSet(databasePath, query).Tables[0];

                int points = Convert.ToInt32(DataReceived.Rows[0]["points"].ToString());

                return points;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public int GetRankingPosition()
        {
            try
            {
                string query = "SELECT * FROM ranking";

                //string query = "SELECT q.user_id, SUM(q.points) as \"points\", u.name, u.ci FROM questionaire as q JOIN users as u WHERE q.user_id = u.id GROUP BY q.user_id ORDER BY points DESC";

                var DataReceived = SqliteHelper.LlenarDataSet(databasePath, query).Tables[0];

                int points = Convert.ToInt32(DataReceived.Rows[0]["points"].ToString());

                List<int> UsersIds = new List<int>();

                for (int i = 0; i < DataReceived.Rows.Count; i++)
                {
                    int id = Convert.ToInt32(DataReceived.Rows[i]["user_id"].ToString());
                    //Question currentQuestion = new Question(id);
                    UsersIds.Add(id);
                }

                return UsersIds.IndexOf(Id) + 1;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }

        public int GetAmountOfQuestionaires()
        {
            try
            {
                string query = "SELECT count(id) as count FROM questionaire WHERE user_id = '" + Id + "'";

                var DataReceived = SqliteHelper.LlenarDataSet(databasePath, query).Tables[0];

                int Count = Convert.ToInt32(DataReceived.Rows[0]["count"].ToString());

                return Count;
            }
            catch (Exception)
            {
                return 0;
                //throw;
            }
        }
    }

    //SELECT count(id) as count FROM questionaire WHERE user_id = 3


}
