using Number.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

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
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                ExitBTN.ForeColor = Color.Black;
                ExitBTN.Image = Resources.exit_black;
            }
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
        /*--------- Exit ---------*/
        private void button1_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
