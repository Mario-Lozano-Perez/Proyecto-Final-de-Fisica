using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace Proyecto_Final_de_Fisica.Settings
{
    public static class UserSettingsLoader
    {
        public static void SaveSettings(UserSettings settings)
        {
            string path = Application.StartupPath + "/UserConfiguration.cfg";

            BinaryFormatter formatter = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Create);

            formatter.Serialize(stream, settings);
            stream.Close();
        }

        public static UserSettings LoadSettings()
        {
            string path = Application.StartupPath + "/UserConfiguration.cfg";
            FileStream stream = new FileStream(path, FileMode.Open);

            if (File.Exists(path))  
            {
                BinaryFormatter formatter = new BinaryFormatter();

                UserSettings data = formatter.Deserialize(stream) as UserSettings;
                stream.Close();

                return data;
            }
            else
            {
                stream.Close();
                throw new Exception("File is missing");
            }
        }
    }
}
