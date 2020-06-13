using fruslib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.DatabaseClass
{
    public class Video
    {
        private static readonly string databasePath = "./database.db3";
        private static readonly string VideosFolderPath = Application.StartupPath + "/videos";
        public int Id { get; set; }
        public String Tittle { get; set; }
        public String Url { get; set; }

        public Video(int id, string tittle, string url)
        {
            Id = id;
            Tittle = tittle;
            Url = url;
        }

        public Video()
        {

        }

        public Video(int ID)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM videos WHERE id = '" + ID + "'");
            if (DataReceived.Tables[0].Rows.Count == 0)
            {
                throw new IndexOutOfRangeException("No hay ningun Video registrado conese ID.");
            }
            else
            {
                Id = ID;
                Tittle = DataReceived.Tables[0].Rows[0]["tittle"].ToString();
                Url = DataReceived.Tables[0].Rows[0]["url"].ToString();
            }
        }

        public static System.Data.DataTable Find(string parameters)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath,
                "SELECT id, tittle as \"Titulo\" FROM videos WHERE id LIKE '%" + parameters + "%' OR tittle LIKE '%" + parameters + "%'").
                Tables[0];
            return DataReceived;
        }

        public void Insert(string originUrl)
        {
            try
            {
                string query = "INSERT INTO videos (tittle,url) VALUES ('" +
                    Tittle + "','" + Url + "')";

                if (!Directory.Exists(VideosFolderPath)) Directory.CreateDirectory(VideosFolderPath);

                string finalUrl = VideosFolderPath + "/" + Url;
                if (File.Exists(finalUrl))
                {
                    throw new Exception("File already exist");
                    //File.Delete(finalUrl);
                }

                File.Copy(originUrl, finalUrl);

                SqliteHelper.Ejecutar_CMD(databasePath, query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string getFullUrl()
        {
            return VideosFolderPath + "/" + Url;
        }

        public void OpenFileUrl()
        {
            try
            {
                string finalUrl = VideosFolderPath + "/" + Url;
                MostUsed.ExecuteShellUrl(finalUrl);
            }
            catch (Exception)
            {

                //throw;
            }
        }

        public void Delete()
        {
            try
            {
                string query = "DELETE FROM videos WHERE id = '" + Id + "'";
                SqliteHelper.Ejecutar_CMD(databasePath, query);
                File.Delete(getFullUrl());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string getUrlForName(string url)
        {
            return VideosFolderPath + "/" + url;
        }

        public void Update(string oldUrl, string newUrl = "")
        {
            try
            {
                string query = "UPDATE videos SET tittle = '" + Tittle + "', url = '" + Url + "' WHERE id = '" + Id + "'";
                if (oldUrl != Url)
                {
                    if (File.Exists(getUrlForName(oldUrl))) File.Delete(getUrlForName(oldUrl));
                    if (!File.Exists(getFullUrl())) File.Copy(newUrl, getFullUrl());
                    else throw new Exception("File Already Exists");
                }
                SqliteHelper.Ejecutar_CMD(databasePath, query);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Video> FindArray(String parameters)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(databasePath,
                "SELECT id, tittle as \"Titulo\" FROM videos WHERE id LIKE '%" + parameters + "%' OR tittle LIKE '%" + parameters + "%'").
                Tables[0];
            //return DataReceived;

            List<Video> videoList = new List<Video>();

            for (int i = 0; i < DataReceived.Rows.Count; i++)
            {
                int id = Convert.ToInt32(DataReceived.Rows[i]["id"].ToString());
                Video currentVideo = new Video(id);
                videoList.Add(currentVideo);
            }

            return videoList;
        }
    }
}
