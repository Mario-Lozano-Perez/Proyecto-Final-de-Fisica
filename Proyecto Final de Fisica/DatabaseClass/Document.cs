using fruslib;
using System;
using System.Collections.Generic;
using System.IO;

namespace Proyecto_Final_de_Fisica.DatabaseClass
{
    public class Document
    {
        private static readonly string DATABASE_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        private static readonly string DOCUMENTS_FOLDER_PATH = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "Documentos");
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }

        public Document(int id, string title, string url)
        {
            Id = id;
            Title = title;
            Url = url;
        }

        public Document() { }

        public Document(int ID)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(DATABASE_PATH, "SELECT * FROM documents WHERE id = '" + ID + "'");
            if (DataReceived.Tables[0].Rows.Count == 0)
            {
                throw new IndexOutOfRangeException("No hay ningun Video registrado conese ID.");
            }
            else
            {
                Id = ID;
                Title = DataReceived.Tables[0].Rows[0]["title"].ToString();
                Url = DataReceived.Tables[0].Rows[0]["url"].ToString();
            }
        }

        public static System.Data.DataTable Find(string parameters)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(DATABASE_PATH,
                "SELECT id, title as \"Titulo\" FROM documents WHERE id LIKE '%" + parameters + "%' OR title LIKE '%" + parameters + "%'").
                Tables[0];
            return DataReceived;
        }

        public void Insert(string originUrl)
        {
            try
            {
                string query = "INSERT INTO documents (title,url) VALUES ('" +
                    Title + "','" + Url + "')";

                if (!Directory.Exists(DOCUMENTS_FOLDER_PATH)) Directory.CreateDirectory(DOCUMENTS_FOLDER_PATH);

                string finalUrl = DOCUMENTS_FOLDER_PATH + "/" + Url;
                if (File.Exists(finalUrl))
                {
                    throw new Exception("File already exist");
                    //File.Delete(finalUrl);
                }

                File.Copy(originUrl, finalUrl);

                SqliteHelper.Ejecutar_CMD(DATABASE_PATH, query);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string GetFullUrl()
        {
            return DOCUMENTS_FOLDER_PATH + "/" + Url;
        }



        public void OpenFileUrl()
        {
            try
            {
                string finalUrl = DOCUMENTS_FOLDER_PATH + "/" + Url;
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
                string query = "DELETE FROM documents WHERE id = '" + Id + "'";
                SqliteHelper.Ejecutar_CMD(DATABASE_PATH, query);
                File.Delete(GetFullUrl());
            }
            catch (Exception)
            {

                throw;
            }
        }

        private string GetFullUrlName(string url)
        {
            return DOCUMENTS_FOLDER_PATH + "/" + url;
        }

        public void Update(string oldUrl, string newUrl = "")
        {
            try
            {
                string query = "UPDATE documents SET title = '" + Title + "', url = '" + Url + "' WHERE id = '" + Id + "'";
                if (oldUrl != Url)
                {
                    if (File.Exists(GetFullUrlName(oldUrl))) File.Delete(GetFullUrlName(oldUrl));
                    if (!File.Exists(GetFullUrl())) File.Copy(newUrl, GetFullUrl());
                    else throw new Exception("File Already Exists");
                }
                SqliteHelper.Ejecutar_CMD(DATABASE_PATH, query);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<Document> FindArray(string parameters)
        {
            var DataReceived = SqliteHelper.LlenarDataSet(DATABASE_PATH,
                "SELECT id, title as \"Titulo\" FROM documents WHERE id LIKE '%" + parameters + "%' OR title LIKE '%" + parameters + "%'").
                Tables[0];
            //return DataReceived;

            List<Document> videoList = new List<Document>();

            for (int i = 0; i < DataReceived.Rows.Count; i++)
            {
                int id = Convert.ToInt32(DataReceived.Rows[i]["id"].ToString());
                Document currentDocument = new Document(id);
                videoList.Add(currentDocument);
            }

            return videoList;
        }
    }
}
