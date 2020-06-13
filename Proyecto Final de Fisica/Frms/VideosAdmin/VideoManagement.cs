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

namespace Proyecto_Final_de_Fisica.Frms.VideosAdmin
{
    public partial class VideoManagement : Form
    {
        private VideosListForm fatherForm;
        private Video oldVideo;
        private string fileOriginPath;
        private string fileName;

        private readonly OpenFileDialog FindVideoDialog = new OpenFileDialog
        {
            Title = "Selecciona un archivo de video",
            Filter = "Archivos de video|*.mpg;*.avi;*.mp4;*.mkv;*.ogg;*.flv;*.mov;*.wmv|Todos los archivos|*.*",
            Multiselect = false
        };

        public VideoManagement()
        {
            InitializeComponent();
        }

        public VideoManagement(VideosListForm fatherForm)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
        }

        public VideoManagement(VideosListForm fatherForm, Video oldVideo)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            this.oldVideo = oldVideo;
            fileName = this.oldVideo.Url;
            fileOriginPath = this.oldVideo.getFullUrl();
            KtextTittle.Value = this.oldVideo.Tittle;
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {
            //_ = Application.StartupPath + "/Videos";
            //if (!Directory.Exists(currentUrl)) Directory.CreateDirectory(currentUrl);

            if (FindVideoDialog.ShowDialog() == DialogResult.OK)
            {
                if (oldVideo != null)
                {
                    fileOriginPath = FindVideoDialog.FileName;
                    fileName = FindVideoDialog.SafeFileName;
                }
                else
                {
                    fileOriginPath = FindVideoDialog.FileName;
                    fileName = FindVideoDialog.SafeFileName;
                }
            }
        }

        private async void Btn_Register_Click(object sender, EventArgs e)
        {
            LabelProcces.Visible = true;
            LabelProcces.ForeColor = Color.FromArgb(128, 255, 255);
            LabelProcces.Text = "Procesando";

            try
            {
                if (oldVideo == null) await CreateRegisterAsynk();
                else await UpdateRegisterAsynk();
            }
            catch (Exception)
            {
                LabelProcces.Visible = true;
                LabelProcces.ForeColor = Color.Coral;
                LabelProcces.Text = "Error";
                //throw;
            }


            LabelProcces.ForeColor = Color.FromArgb(128, 255, 255);
            LabelProcces.Visible = false;

            fatherForm.SearchData();
            Dispose();
        }

        //Generate Asynchronous Tasks
        #region Async Declaration
        private Task CreateRegisterAsynk()
        {
            return Task.Factory.StartNew(() => CreateRegister());
        }

        private Task UpdateRegisterAsynk()
        {
            return Task.Factory.StartNew(() => UpdateRegister());
        }
        #endregion

        private void UpdateRegister()
        {
            if (KtextTittle.Value == "")
            {
                KtextTittle.IsWrong();
                return;
            }

            if (fileName != "" && fileOriginPath != "")
            {
                Video videoToAdd = new Video(oldVideo.Id);
                videoToAdd.Tittle = KtextTittle.Value;
                videoToAdd.Url = fileName;

                try
                {
                    videoToAdd.Update(oldVideo.Url, fileOriginPath);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
            }
        }

        private void CreateRegister()
        {
            if (KtextTittle.Value == "")
            {
                KtextTittle.IsWrong();
                return;
            }

            if (fileName != "" && fileOriginPath != "")
            {
                Video videoToAdd = new Video
                {
                    Tittle = KtextTittle.Value,
                    Url = fileName
                };

                try
                {
                    videoToAdd.Insert(fileOriginPath);
                    //fatherForm.SearchData();
                    //Dispose();
                }
                catch (Exception err)
                {
                    //throw;
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);
                }
            }
        }
    }
}
