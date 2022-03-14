using Number.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class SplashScreen : UserControl
    {
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.White;
            }

        }
        /*------------------ Animation Start ------------------*/
        /*--------- var ---------*/
        Label TextChar = new Label();
        int CharL = 0;
        /*--------- Start ---------*/
        private void Main_Tick(object sender, EventArgs e)
        {
            Label[] CharT = { NText, UText, MText, BText, EText, RText, fakeText };
            TextChar = CharT[CharL];
            if (CharL > 5)
            {
                StartApp.Start();
                Main.Stop();
            }
            else
            {
                CharL++;
                TextTimer.Start();
                Main.Stop();
            }
        }

        private void Text_Tick(object sender, EventArgs e)
        {
            TextChar.Location = new Point(TextChar.Location.X, TextChar.Location.Y -5);
            if (TextChar.Location.Y < 2)
            {
                Main.Start();
            }
        }


        private void StartApp_Tick(object sender, EventArgs e)
        {
            this.Hide();
            StartApp.Stop();
        }
        /*------------------ Animation End ------------------*/

    }
}
