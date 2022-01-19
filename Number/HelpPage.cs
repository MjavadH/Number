﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;
using System.IO;

namespace Number
{
    public partial class HelpPage : Form
    {
        public HelpPage()
        {InitializeComponent();}
        private void HelpPage_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            try
            {
                HelpText.Text = Resources.HelpText;
            }
            catch (Exception)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {this.Close();}
    }
}