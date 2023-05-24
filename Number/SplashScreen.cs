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
            this.Visible = true;
            if (!Settings.Default.DefaultColor)
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
            Label[] CharT = { n_Text, u_Text, m_Text, b_Text, e_Text, r_Text };
            TextChar = CharT[CharL];
            if (CharL >= 5)
            {
                startApp_Timer.Start();
                main_Timer.Stop();
            }
            else
            {
                CharL++;
                text_Timer.Start();
                main_Timer.Stop();
            }
        }

        private void Text_Tick(object sender, EventArgs e)
        {
            if (TextChar.Location.Y < 2)
            {
                main_Timer.Start();
            }
            else
            {
                TextChar.Location = new Point(TextChar.Location.X, TextChar.Location.Y - 5);
            }
        }

        private void StartApp_Tick(object sender, EventArgs e)
        {
            this.Hide();
            startApp_Timer.Stop();
        }
        /*------------------ Animation End ------------------*/

    }
}
