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

namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    public partial class RankingForm : Form
    {
        public MainForm FatherForm { get; set; }

        public RankingForm()
        {
            InitializeComponent();
        }

        public RankingForm(MainForm fatherForm)
        {
            InitializeComponent();
            FatherForm = fatherForm;
            StartReading();
        }

        public async void StartReading()
        {
            PanelRank.Controls.Clear();

            var usuarios = await ReadDataAsynk();

            foreach (User item in usuarios)
            {
                RankUser userToDisplay = new RankUser(item);
                if (item.Id == FatherForm.CURRENT_USER.Id) userToDisplay.NameColor = Color.NavajoWhite;
                userToDisplay.Width = PanelRank.Width - 36;

                PanelRank.Controls.Add(userToDisplay);
            }
        }


        public Task<List<User>> ReadDataAsynk()
        {
            return Task.Factory.StartNew(() => Question.GetRanking());
        }

        private void ReadData()
        {
            PanelRank.Controls.Clear();

            var usuarios = Question.GetRanking();

            foreach (User item in usuarios)
            {
                RankUser userToDisplay = new RankUser(item);
                if (item.Id == FatherForm.CURRENT_USER.Id) userToDisplay.NameColor = Color.Green;
                userToDisplay.Width = PanelRank.Width - 30;

                PanelRank.Controls.Add(userToDisplay);
            }
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            ReadDataAsynk();
        }
    }
}
