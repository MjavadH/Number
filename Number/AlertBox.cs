﻿using System;
using System.Drawing;
using Number.Properties;
using System.Windows.Forms;

namespace Number
{
    public partial class AlertBox : Form
    {
        /*------------------ Rounding form Start ------------------*/
        public AlertBox()
        {
            InitializeComponent();
        }
        /*------------------ Rounding form End ------------------*/
        /*------------------ Enum & Var Start  ------------------*/
        private enum enmAction ///AlertBox Action
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
            show_Timer.Interval = 1;
            action = enmAction.close;
        }
        /*--------- Start Timer  ---------*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    show_Timer.Interval = 3000;
                    action = enmAction.close;
                    break;
                case enmAction.start: // Show Alert
                    show_Timer.Interval = 1;
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
                    show_Timer.Interval = 1;
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
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                close_BTN.Image = Resources.delete_black;
            }
            this.Font = Settings.Default.AppFont;
        }

        /*--------- Show  ---------*/
        public void showAlert(string msg)
        {
            /*----- Setting form -----*/
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                AlertBox frm = (AlertBox)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


            this.alertText.Text = msg;
            /*----- Start Show -----*/
            this.Show();
            this.action = enmAction.start;
            this.show_Timer.Interval = 1;
            show_Timer.Start();
            /*----- Sound -----*/
            if (Settings.Default.Sound_EFX)
            {
                using (var player = new System.Media.SoundPlayer())
                {
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
}
