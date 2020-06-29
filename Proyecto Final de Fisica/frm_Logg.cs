using Proyecto_Final_de_Fisica.DatabaseClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_de_Fisica.Frms;
using fruslib;
using Proyecto_Final_de_Fisica.Settings;
using System.IO;
using System.Data.SQLite;

namespace Proyecto_Final_de_Fisica
{
    public partial class frm_Logg : Form
    {
        private UserSettings currentSettings;

        public frm_Logg()
        {
            InitializeComponent();
            var Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica");
            if (!Directory.Exists(Folder)) Directory.CreateDirectory(Folder);

            ReadSettings();
            CreateDatabase();



        }


        private void Btn_acces_Click_1(object sender, EventArgs e)
        {
            try
            {
                string UserId = TextId.Value;
                string UserPassword = TextPassword.Value;

                User accesUser = new User(UserId);
                if (accesUser.VerifyPassword(UserPassword))
                {
                    MainForm homeForm = new MainForm(accesUser, this);

                    if (CheckRemember.IsSelected)
                    {
                        var userTem = new UserSettings(CheckRemember.IsSelected, TextId.Value, TextPassword.Value);
                        userTem.Save();
                    }
                    else
                    {
                        var userTem = new UserSettings(false, "", "");
                        userTem.Save();
                    }

                    homeForm.Show();
                    this.Hide();

                }
                else
                {
                    TextPassword.IsWrong();
                    //new MessageForm(2, "La contraseña no es correcta.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                //new MessageForm(1, error.Message);
                TextId.IsWrong();
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReadSettings()
        {
            try
            {
                currentSettings = UserSettings.getFile();
                if (currentSettings.Remember)
                {
                    TextId.Value = currentSettings.UserName;
                    TextPassword.Value = currentSettings.Password;
                    CheckRemember.IsSelected = currentSettings.Remember;
                }
            }
            catch (Exception)
            {
                currentSettings = new UserSettings(false, "", "");
                currentSettings.Save();
                ReadSettings();
            }
        }

        private void CreateDatabase()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");

            if (!File.Exists(databasePath))
            {
                try
                {
                    //if (Directory.Exists(Application.StartupPath + "/videos")) Directory.Delete(Application.StartupPath + "/videos");

                    //SQLiteConnection.CreateFile(databasePath);

                    //string QueryMax = MostUsed.ReadFile(Properties.Resources.SQL_BUILDER);
                    SqliteHelper.Ejecutar_CMD(databasePath, Properties.Resources.SQL_BUILDER);

                    var temporal = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM users").Tables[0];
                    if (temporal.Rows.Count == 0)
                    {
                        User adminUser = new User
                        {
                            Ci = "00000000000",
                            Name = "Admin",
                            Password = Cipher.CesarCifrar("admin", 5),
                            Level = 1
                        };

                        adminUser.Insert();

                        MessageBox.Show(
                            "Se ha creado el usuario administrador:\nCi: 00000000000\nContraseña: admin",
                            "Usuario Administrador Creado",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ha ocurrido un error mientras se cargaba la base de datos.\n" + err.Message);
                }
            }
        }
    }
}
