using Proyecto_Final_de_Fisica.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_de_Fisica.Settings
{
    [System.Serializable]
    public class UserSettings
    {
        public bool Remember { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserSettings(bool remember, string userName, string password)
        {
            Remember = remember;
            UserName = userName;
            Password = password;
        }

        public void Save()
        {
            UserSettingsLoader.SaveSettings(this);
        }

        public static UserSettings getFile()
        {
            try
            {
                return UserSettingsLoader.LoadSettings();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
