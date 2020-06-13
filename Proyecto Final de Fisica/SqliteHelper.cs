using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_Fisica
{
    public static class SqliteHelper
    {

        #region Llenar DataSet
        public static DataSet LlenarDataSet(string path, string CMD)
        {

            DataSet DS = new DataSet();

            SQLiteConnection Con = new SQLiteConnection(@"Data Source = " + path +
                "; Version= 3; New= True; Compressed = True; ");
            Con.Open();
            SQLiteDataAdapter DP = new SQLiteDataAdapter(CMD, Con);
            DP.Fill(DS);

            return DS;
        }
        #endregion

        #region Ejecutar Querry
        public static void Ejecutar_CMD(string path, string CMD)
        {
            SQLiteConnection Con = new SQLiteConnection(@"Data Source = " + path +
                "; Version = 3; New= True; Compressed = True;");
            Con.Open();
            SQLiteCommand Comando = Con.CreateCommand();
            Comando.CommandText = CMD;
            Comando.ExecuteNonQuery();
            Con.Close();

        }
        #endregion
    }
}
