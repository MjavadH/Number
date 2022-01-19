﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;


namespace Number
{
    public partial class ColorPick : Form
    {
        public ColorPick()
        {InitializeComponent();}
        private void ColorPick_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            RC.Value = Settings.Default.LightTheme.R;
            GC.Value = Settings.Default.LightTheme.G;
            BC.Value = Settings.Default.LightTheme.B;
            RT.Text = "مقدار رنگ قرمز: " + RC.Value;
            GT.Text = "مقدار رنگ سبز: " + GC.Value;
            BT.Text = "مقدار رنگ آبی: " + BC.Value;
        }
        /*------------------ Move Form Start ------------------*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void NumberForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*------------------ Move Form End ------------------*/
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.LightTheme = this.BackColor;
            Settings.Default.Save();
            this.Close();
        }

        private void RC_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(RC.Value, GC.Value, BC.Value);
            RT.Text = "مقدار رنگ قرمز: " + RC.Value;
            GT.Text = "مقدار رنگ سبز: " + GC.Value;
            BT.Text = "مقدار رنگ آبی: " + BC.Value;
        }
    }
}