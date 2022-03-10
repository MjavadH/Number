using System;
using System.Drawing;
using Number.Properties;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Number
{
    public partial class AlertBox : Form
    {
        /*------------------ Rounding form Start ------------------*/
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public AlertBox()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
        }
        /*------------------ Rounding form End ------------------*/
        /*------------------ Enum & Var Start  ------------------*/
        public enum enmAction
        {
            wait,
            start,
            close
        }
        private AlertBox.enmAction action;

        private int x, y;
        /*------------------ Enum & Var End  ------------------*/
        /*--------- Close  ---------*/
        private void closebtn_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }
        /*--------- Start Timer  ---------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 3000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void AlertBox_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
            }
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                closebtn.Image = Resources.delete_black;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.Font = Settings.Default.AppFont;
        }

        /*--------- Show  ---------*/
        public void showAlert(string msg)
        {
            /*----- Setting form -----*/
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 0; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertBox frm = (AlertBox)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, 1);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


            this.AlertText.Text = msg;
            /*----- Start Show -----*/
            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
            /*----- Sound -----*/
            if (Settings.Default.Sound_EFX)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                switch (Settings.Default.Sound_Num)
                {
                    case 1:
                        player.Stream = Resources.mixkit_alert_quick_chime_766;
                        break;
                    case 2:
                        player.Stream = Resources.mixkit_software_interface_start_2574;
                        break;
                    case 3:
                        player.Stream = Resources.mixkit_tile_game_reveal_960;
                        break;
                    case 4:
                        player.Stream = Resources.mixkit_bonus_earned_in_video_game_2058;
                        break;
                    case 5:
                        player.Stream = Resources.mixkit_doorbell_tone_2864;
                        break;
                }
                player.Play();
            }
        }
    }
}
