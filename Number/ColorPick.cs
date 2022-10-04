using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;
using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.Linq;

namespace Number
{
    public partial class ColorPick : Form
    {
        public ColorPick()
        {InitializeComponent();}
        void CkeckSettings()
        {
            Guna2CircleButton[] BTN_Color_list = { BTN_Color_1, BTN_Color_2, BTN_Color_3, BTN_Color_4, BTN_Color_5, BTN_Color_6, BTN_Color_7, BTN_Color_8 };

            if (RC.Value >= 180 && GC.Value >= 180 && BC.Value >= 180) Settings.Default.LightColor = true;
            else Settings.Default.LightColor = false;

            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                CancelBTN.ForeColor = Color.Black;
                CancelBTN.Image = Resources.exit_black;
                foreach (var BTN in BTN_Color_list)
                {
                    BTN.BorderColor = Color.Black;
                }

            }
            else
            {
                this.ForeColor = Color.White;
                CancelBTN.ForeColor = Color.White;
                CancelBTN.Image = Resources.exit;
                foreach (var BTN in BTN_Color_list)
                {
                    BTN.BorderColor = Color.White;
                }
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

            if (!string.IsNullOrEmpty(Settings.Default.Color_History))
            {
                IList<string> Color_History = new List<string> { };
                string[] Colors = Settings.Default.Color_History.Split('\n');

                for (int i = 0; i < Colors.Length -1; i++)
                {
                    Color_History.Add(Colors[i]);
                }

                Color_History = Color_History.Distinct(StringComparer.InvariantCultureIgnoreCase).ToList();

                foreach (var color in Color_History)
                {
                   
                    Guna2CircleButton circleButton = new Guna2CircleButton();
                    circleButton.Name = "BTN_" + new Random().Next();
                    circleButton.Size = new Size(25, 25);
                    circleButton.FillColor = Color.FromArgb(int.Parse(color.Split(',')[0]), int.Parse(color.Split(',')[1]), int.Parse(color.Split(',')[2]));
                    circleButton.Text = "";
                    circleButton.Click += BTN_Color_Click;
                    Panel_History_Colors.Controls.Add(circleButton);
                }

            }

            CkeckSettings();
        }
        void Refresh_Color()
        {
            this.BackColor = Color.FromArgb(RC.Value, GC.Value, BC.Value);
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
        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = this.BackColor;
            Settings.Default.Color_History += this.BackColor.R +"," + this.BackColor.G + "," + this.BackColor.B + "\n";
            if (!string.IsNullOrEmpty(Settings.Default.Color_History))
            {
                IList<string> Color_History = new List<string> { };
                string[] Colors = Settings.Default.Color_History.Split('\n');

                for (int i = 0; i < Colors.Length - 1; i++)
                {
                    Color_History.Add(Colors[i]);
                }
                Color_History = Color_History.Distinct(StringComparer.InvariantCultureIgnoreCase).ToList();
                Settings.Default.Color_History = "";
                foreach (var item in Color_History)
                {
                    Settings.Default.Color_History += item + "\n";
                }
            }
            Settings.Default.Save();
            this.Close();
        }
        /*--------- Set Color ---------*/
        private void RC_Scroll(object sender, ScrollEventArgs e)
        {
            Refresh_Color();
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

        private void BTN_Color_Click(object sender, EventArgs e)
        {
            Guna2CircleButton ColorBTN = (Guna2CircleButton)sender;
            RC.Value = ColorBTN.FillColor.R;
            GC.Value = ColorBTN.FillColor.G;
            BC.Value = ColorBTN.FillColor.B;
            Refresh_Color();
        }
    }
}
