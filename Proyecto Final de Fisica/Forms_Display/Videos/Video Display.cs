using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_de_Fisica.DatabaseClass;
using fruslib;

namespace Proyecto_Final_de_Fisica.Forms_Display
{
    public partial class Video_Display : UserControl
    {
        private Video CurrentVideo;
        public Video Video
        {
            get
            {
                return CurrentVideo;
            }
            set
            {
                CurrentVideo = value;
                labelVideoName.Text = CurrentVideo.Tittle;
            }
        }

        public Video_Display()
        {
            InitializeComponent();
        }

        public Video_Display(Video video)
        {
            InitializeComponent();
            Video = video;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MostUsed.ExecuteShellUrl(CurrentVideo.getFullUrl());
        }
    }
}
