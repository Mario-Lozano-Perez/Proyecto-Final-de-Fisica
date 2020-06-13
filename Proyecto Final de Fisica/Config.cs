using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fruslib;

namespace Proyecto_Final_de_Fisica
{
    public class Config
    {

        readonly string ConfigFilePath = "./sett.cfg";
        public int QuestionNumber { get; set; }
        public bool Remembered { get; set; }
        public string DefaultUserName { get; set; }
        public string DefaultPassword { get; set; }

        public Config()
        {
            if (ReadFile(ConfigFilePath))
            {
                try
                {
                    string[] settingsDefaultString = MostUsed.ReadFile(ConfigFilePath).Split('\n');
                    this.QuestionNumber = Convert.ToInt32(settingsDefaultString[0].Split(':')[1]);
                    this.Remembered = Convert.ToBoolean(settingsDefaultString[1].Split(':')[1]);

                    if (this.Remembered)
                    {
                        this.DefaultUserName = Cipher.CesarDecifrar(settingsDefaultString[2].Split(':')[1].TrimEnd(), 5);
                        this.DefaultPassword = Cipher.CesarDecifrar(settingsDefaultString[3].Split(':')[1].TrimEnd(), 5);
                    }
                    else
                    {
                        this.DefaultUserName = "";
                        this.DefaultPassword = "";
                    }

                    
                }
                catch (Exception)
                {
                    string defaultValues = "QuestionNumber:10\nRemembered:false\nDefaultUserName: \nDefaultPassword: ";
                    MostUsed.WriteFile(this.ConfigFilePath, defaultValues);
                    string[] settingsDefaultString = MostUsed.ReadFile(ConfigFilePath).Split('\n');
                    this.QuestionNumber = Convert.ToInt32(settingsDefaultString[0].Split(':')[1]);
                    this.Remembered = Convert.ToBoolean(settingsDefaultString[1].Split(':')[1]);
                    this.DefaultUserName = Cipher.CesarDecifrar(settingsDefaultString[2].Split(':')[1].TrimEnd(), 5);
                    this.DefaultPassword = Cipher.CesarDecifrar(settingsDefaultString[3].Split(':')[1].TrimEnd(), 5);
                }
            }
        }

        private static bool ReadFile(string Path)
        {
            if (File.Exists(Path))
            {
                return true;
            }
            else
            {
                try
                {
                    File.Create(Path);
                    string defaultValues = "QuestionNumber:10\nRemembered:false\nDefaultUserName: \nDefaultPassword: ";
                    MostUsed.WriteFile(Path, defaultValues);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public void SaveCurrentData()
        {
            string valuesToSave = "QuestionNumber:" + this.QuestionNumber + 
                "\nRemembered:" + this.Remembered.ToString() +
                "\nDefaultUserName:" + Cipher.CesarCifrar(this.DefaultUserName,5) + 
                "\nDefaultPassword:" + Cipher.CesarCifrar(this.DefaultPassword,5);
            MostUsed.WriteFile(this.ConfigFilePath, valuesToSave);

        }

        override public String ToString()
        {
            string valuesToSave = "QuestionNumber:" + this.QuestionNumber +
                "\nRemembered:" + this.Remembered.ToString() +
                "\nDefaultUserName:" + this.DefaultUserName +
                "\nDefaultPassword:" + this.DefaultPassword;
            return valuesToSave;
        }
    }
}
