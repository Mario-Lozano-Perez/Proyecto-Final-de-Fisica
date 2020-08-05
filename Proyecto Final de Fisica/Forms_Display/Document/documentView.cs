using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fruslib;

namespace Proyecto_Final_de_Fisica.Forms_Display.Document
{
    public partial class documentView : UserControl
    {
        public DatabaseClass.Document Documento { get; set; }
        Random random = new Random();


        public Color[] COLORS_ARRAY =
        {
            Color.FromArgb(189, 234, 96),
            Color.FromArgb(97, 175, 184),
            Color.FromArgb(229, 192, 123),
            Color.FromArgb(198, 120, 221),
            Color.FromArgb(22, 160, 93),
            Color.FromArgb(230, 128, 119),
            Color.FromArgb(255, 206, 69),
            Color.FromArgb(34, 207, 242),
            Color.FromArgb(54, 166, 101)
        };

        public documentView()
        {
            InitializeComponent();
        }

        public documentView(DatabaseClass.Document document)
        {
            InitializeComponent();
            Documento = document;
            LabelTitle.Text = Documento.Title;
            int position = random.Next(0, COLORS_ARRAY.Length);
            LabelTitle.ForeColor = COLORS_ARRAY[position];
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            MostUsed.ExecuteShellUrl(Documento.GetFullUrl());
        }
    }
}
