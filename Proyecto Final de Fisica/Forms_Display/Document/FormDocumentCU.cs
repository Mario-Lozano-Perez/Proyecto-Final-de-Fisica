using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_de_Fisica.DatabaseClass;

namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    public partial class FormDocumentCU : Form
    {

        private FormDocumentManage fatherForm;
        private DatabaseClass.Document oldDocument;
        private string fileOriginPath;
        private string fileName;

        private readonly OpenFileDialog FindVideoDialog = new OpenFileDialog
        {
            Title = "Selecciona un Documento",
            Filter = "Documentos|*.doc;*.docx;*.ppt;*.pptx;*.pdf;*.cls;*.xls;*.xlsx;*.epub|Todos los archivos|*.*",
            Multiselect = false
        };

        public FormDocumentCU()
        {
            InitializeComponent();
            if (fileName != null) PanelFileChecked.BackColor = Color.PaleGreen;
            else PanelFileChecked.BackColor = Color.LightCoral;
        }

        public FormDocumentCU(FormDocumentManage fatherForm)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            if (fileName != null) PanelFileChecked.BackColor = Color.PaleGreen;
            else PanelFileChecked.BackColor = Color.LightCoral;
        }

        public FormDocumentCU(FormDocumentManage fatherForm, DatabaseClass.Document oldVideo)
        {
            InitializeComponent();
            this.fatherForm = fatherForm;
            this.oldDocument = oldVideo;
            fileName = this.oldDocument.Url;
            fileOriginPath = this.oldDocument.GetFullUrl();
            KtextTittle.Value = this.oldDocument.Title;

            if (fileName != null) PanelFileChecked.BackColor = Color.PaleGreen;
            else PanelFileChecked.BackColor = Color.LightCoral;
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
                if (oldDocument != null)
                {
                    fileOriginPath = FindVideoDialog.FileName;
                    fileName = FindVideoDialog.SafeFileName;

                    if (fileName != null) PanelFileChecked.BackColor = Color.PaleGreen;
                    else PanelFileChecked.BackColor = Color.LightCoral;
                }
                else
                {
                    fileOriginPath = FindVideoDialog.FileName;
                    fileName = FindVideoDialog.SafeFileName;

                    if (fileName != null) PanelFileChecked.BackColor = Color.PaleGreen;
                    else PanelFileChecked.BackColor = Color.LightCoral;
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
                if (oldDocument == null) await CreateRegisterAsynk();
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
                DatabaseClass.Document videoToAdd = new DatabaseClass.Document(oldDocument.Id);
                videoToAdd.Title = KtextTittle.Value;
                videoToAdd.Url = fileName;

                try
                {
                    videoToAdd.Update(oldDocument.Url, fileOriginPath);
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
                DatabaseClass.Document videoToAdd = new DatabaseClass.Document
                {
                    Title = KtextTittle.Value,
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
