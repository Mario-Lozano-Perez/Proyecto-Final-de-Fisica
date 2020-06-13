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

namespace Proyecto_Final_de_Fisica.Forms_Display.Questionaire
{
    public partial class RankUser : UserControl
    {
        private User Usuario;

        public User CurrentUser
        {
            get { return Usuario; }
            set
            {
                Usuario = value;
                PicSex.Image = Usuario.GetSexImage();
                LabelName.Text = Usuario.Name;
                LabelPoints.Text = "Puntos: " + Usuario.GetPoints();
                LabelPos.Text = "Posición: " + Usuario.GetRankingPosition();
            }
        }

        public Color NameColor
        {
            get { return LabelName.ForeColor; }
            set { LabelName.ForeColor = value; }
        }

        public RankUser()
        {
            InitializeComponent();
        }

        public RankUser(User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
        }
    }
}
