using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    public partial class FormDocumentView : Form
    {
        private MainForm FATHER_FORM;


        public FormDocumentView()
        {
            InitializeComponent();
        }

        public FormDocumentView(MainForm mainForm)
        {
            InitializeComponent();
            this.FATHER_FORM = mainForm;
            Search();
        }

        private void Search()
        {
            var arrayOfDocuments = DatabaseClass.Document.FindArray(txt_SearchFied.Text);
            DocumentPanel.Controls.Clear();
            foreach (DatabaseClass.Document item in arrayOfDocuments)
            {
                documentView videoToShow = new documentView(item);
                //videoToShow.Width = VideoPanel.Width - 30;
                DocumentPanel.Controls.Add(videoToShow);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
