using fruslib;
using Proyecto_Final_de_Fisica.Frms;
using Proyecto_Final_de_Fisica.Frms.VideosAdmin;
using System;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica
{
    public partial class frm_AdminDashboard : Form
    {
        UserListForm userListForm;
        QuestionsListForm questionsListForm;
        VideosListForm videoListForm;

        private readonly string databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica", "database.db3");
        public MainForm fatherForm;

        public frm_AdminDashboard()
        {
            InitializeComponent();
            LoadData();
        }

        public frm_AdminDashboard(MainForm fatherForm)
        {
            InitializeComponent();
            this.userListForm = new UserListForm(this);
            this.questionsListForm = new QuestionsListForm(this);
            videoListForm = new VideosListForm(this);
            this.fatherForm = fatherForm;
            LoadData();
        }

        public void LoadData()
        {
            int userCount = SqliteHelper.LlenarDataSet(databasePath, "SELECT * FROM users").Tables[0].Rows.Count;
            lbl_UserCount.Text = userCount.ToString();
        }

        private void Btn_Reload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Btn_usersList_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(userListForm, this.fatherForm.pnl_FormContainer);
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(questionsListForm, this.fatherForm.pnl_FormContainer);
        }

        private void Btn_Videos_Click(object sender, EventArgs e)
        {
            MostUsed.OpenFormInPanel(videoListForm, this.fatherForm.pnl_FormContainer);
        }

        private void ButtonCreateBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica");

                string TemporalDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PFFTemporal");

                SaveFileDialog SaveBackupDialog = new SaveFileDialog
                {
                    Title = "Selecciona un archivo de video",
                    Filter = "Backup File|*.fbp",
                };

                //ZipFile.CreateFromDirectory("C:\\Preuea", "D:\\test.zip");

                if (SaveBackupDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(TemporalDirectory)) Directory.Delete(TemporalDirectory, true);

                    Directory.CreateDirectory(TemporalDirectory);

                    foreach (string dirpath in Directory.GetDirectories(FolderPath, "*", SearchOption.AllDirectories))
                        Directory.CreateDirectory(dirpath.Replace(FolderPath, TemporalDirectory));

                    foreach (string newPath in Directory.GetFiles(FolderPath, "*.*", SearchOption.AllDirectories))
                        File.Copy(newPath, newPath.Replace(FolderPath, TemporalDirectory));

                    ZipFile.CreateFromDirectory(TemporalDirectory, SaveBackupDialog.FileName);

                    Directory.Delete(TemporalDirectory, true);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Error" + err.Message);
            }
        }

        private void ButtonRestoreBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                string FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Proyecto Final de Fisica");

                string TemporalDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PFFTemporal");

                OpenFileDialog loadFile = new OpenFileDialog
                {
                    Title = "Selecciona un archivo de video",
                    Filter = "Backup File|*.fbp",
                    Multiselect = false
                };

                if (loadFile.ShowDialog() == DialogResult.OK)
                {
                    if (Directory.Exists(FolderPath)) Directory.Delete(FolderPath, true);
                    Directory.CreateDirectory(FolderPath);
                    ZipFile.ExtractToDirectory(loadFile.FileName, FolderPath);
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
