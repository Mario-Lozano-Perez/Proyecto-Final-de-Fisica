using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_de_Fisica
{
    public partial class MessageForm : Form
    {
        private List<Color> colorList = new List<Color>();

        public MessageForm()
        {
            InitializeComponent();
        }

        public MessageForm(int MessageType, string MessageText)
        {
            InitializeComponent();
            startColorList();
            Colorize(MessageType);
            label1.Text = MessageText;
            this.Show();
        }

        private void startColorList()
        {
            colorList.Add(Color.FromArgb(34, 164, 115));
            colorList.Add(Color.FromArgb(239, 58, 86));
            colorList.Add(Color.FromArgb(253, 131, 30));
        }

        private void Colorize(int colorPos)
        {
            this.BackColor = colorList[colorPos];
            label1.BackColor = colorList[colorPos];
        }

        
        

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
