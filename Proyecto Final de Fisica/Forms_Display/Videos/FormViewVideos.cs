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

namespace Proyecto_Final_de_Fisica.Forms_Display
{
    public partial class FormViewVideos : Form
    {
        private MainForm fatherForm;

        public FormViewVideos()
        {
            InitializeComponent();
        }

        public FormViewVideos(MainForm mainForm)
        {
            InitializeComponent();
            this.fatherForm = mainForm;
            Search();
        }

        private void Search()
        {
            var ArrayOfVideos = Video.FindArray(txt_SearchFied.Text);
            VideoPanel.Controls.Clear();
            foreach (Video item in ArrayOfVideos)
            {
                Video_Display videoToShow = new Video_Display(item);
                videoToShow.Width = VideoPanel.Width - 30;
                VideoPanel.Controls.Add(videoToShow);
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
