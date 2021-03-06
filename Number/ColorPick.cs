using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;


namespace Number
{
    public partial class ColorPick : Form
    {
        public ColorPick()
        {InitializeComponent();}
        void CkeckSettings()
        {
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                CancelBTN.ForeColor = Color.Black;
                CancelBTN.Image = Resources.exit_black;
            }
            else
            {
                this.ForeColor = Color.White;
                CancelBTN.ForeColor = Color.White;
                CancelBTN.Image = Resources.exit;
            }
        }
        private void ColorPick_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            RC.Value = Settings.Default.Theme.R;
            GC.Value = Settings.Default.Theme.G;
            BC.Value = Settings.Default.Theme.B;
            RT.Text = "مقدار رنگ قرمز: " + RC.Value;
            GT.Text = "مقدار رنگ سبز: " + GC.Value;
            BT.Text = "مقدار رنگ آبی: " + BC.Value;
            CkeckSettings();
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
        /*--------- Exit ---------*/
        private void CancelBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = this.BackColor;
            Settings.Default.Save();
            this.Close();
        }
        /*--------- Set Color ---------*/
        private void RC_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(RC.Value, GC.Value, BC.Value);
            RT.Text = "مقدار رنگ قرمز: " + RC.Value;
            GT.Text = "مقدار رنگ سبز: " + GC.Value;
            BT.Text = "مقدار رنگ آبی: " + BC.Value;
            if (RC.Value >= 180 && GC.Value >= 180 && BC.Value >= 180)
            {
                Settings.Default.LightColor = true;
                CkeckSettings();
            }
            else if (RC.Value == 160 && GC.Value == 113 && BC.Value == 255)
            {
                RC.ThumbColor = Color.FromArgb(112, 79, 178);
                GC.ThumbColor = Color.FromArgb(112, 79, 178);
                BC.ThumbColor = Color.FromArgb(112, 79, 178);
            }
            else if (RC.Value == 112 && GC.Value == 79 && BC.Value == 178)
            {
                RC.ThumbColor = Color.FromArgb(160, 113, 255);
                GC.ThumbColor = Color.FromArgb(160, 113, 255);
                BC.ThumbColor = Color.FromArgb(160, 113, 255);
            }
            else Settings.Default.LightColor = false; CkeckSettings();
        }
    }
}
