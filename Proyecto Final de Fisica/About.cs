﻿using fruslib;
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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonGithub_Click(object sender, EventArgs e)
        {
            MostUsed.ExecuteShellUrl(Properties.Resources.GitHubLink);
        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
