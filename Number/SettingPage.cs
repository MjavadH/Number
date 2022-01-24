using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;
using static Number.Cdata;


namespace Number
{
    public partial class SettingPage : Form
    {
        /*------------------ Func Start ------------------*/
        public SettingPage()
        {InitializeComponent();}
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        int SN;
        void Soundplay(int numberS)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            switch (numberS)
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
            SN = numberS;
            Settings.Default.Sound_Num = SN;
            Settings.Default.Save();
            player.Play();
        }
        /*------------------ Func End ------------------*/
        private void SettingPage_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
                ColorCh.Visible = true;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            Counter_Value.Value = Convert.ToDecimal(Settings.Default.Counter);
            OnTopBTN.Checked = Settings.Default.AlwaysOT;
            DarkMode.Checked = Settings.Default.DefaultColor;
            fontDialog1.Font = Settings.Default.AppFont;
            SoundPlay.Checked = Settings.Default.Sound_EFX;
            if (Settings.Default.Sound_EFX)
            {
                SoundSetting_BTN.Visible = true;
            }
            switch (Settings.Default.Sound_Num)
            {
                case 1:
                    Sound1.Checked = true;
                    break;
                case 2:
                    Sound2.Checked = true;
                    break;
                case 3:
                    Sound3.Checked = true;
                    break;
            }
            if (this.Font == Settings.Default.DFont)
            {
                FontCBTN.Visible = false;
            }
            else FontCBTN.Visible = true;
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
        /*------------------ BTN Start ------------------*/
        /*--------- Font Start ---------*/
        private void FontBTN_Click(object sender, EventArgs e)
        {fontDialog1.ShowDialog();}
        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            label4.Font = fontDialog1.Font;
        }
        private void FontCBTN_Click(object sender, EventArgs e)
        {
            label4.Font = Settings.Default.DFont;
            fontDialog1.Font = Settings.Default.DFont;
        }
        /*--------- Font End ---------*/
        /*--------- SaveBTN ---------*/
        private void Save_Click(object sender, EventArgs e)
        {
            Settings.Default.AlwaysOT = OnTopBTN.Checked;
            Settings.Default.DefaultColor = DarkMode.Checked;
            Settings.Default.AppFont = fontDialog1.Font;
            Settings.Default.Counter = Counter_Value.Value.ToString();
            Settings.Default.Sound_EFX = SoundPlay.Checked;
            Settings.Default.Save();
            this.Close();
        }
        /*--------- CancelBTN ---------*/
        private void CancelBTN_Click(object sender, EventArgs e)
        {this.Close();}
        private void CancelBTN_MouseEnter(object sender, EventArgs e)
        {
            CancelBTN.FillColor = Color.FromArgb(249, 75, 66);
        }
        private void CancelBTN_MouseLeave(object sender, EventArgs e)
        {
            CancelBTN.FillColor = Color.Empty;
        }
        /*--------- Background ---------*/
        private void BackgroundMode_CheckedChanged(object sender, EventArgs e)
        {
            if (DarkMode.Checked == false)
            {
                ColorCh.Visible = true;
            }
            else ColorCh.Visible = false;
        }
        private void ColorCh_Click(object sender, EventArgs e)
        {
            new ColorPick().ShowDialog();
        }
        /*--------- Short key ---------*/
        private void ShortKeyBTN_Click(object sender, EventArgs e)
        {
            new ShortKey().ShowDialog();
        }
        /*--------- Reset Start ---------*/
        private void ResetBTN_Click(object sender, EventArgs e)
        {
            Reset_YN_Panel.BringToFront();
            ResetNAni.AddToQueue(Reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Show);
            
        }

        private void Yes_Reset_Click(object sender, EventArgs e)
        {
            Cdata.Delete();
            Alert("شمارنده ها بازنشانی شدند");
            ResetNAni.AddToQueue(Reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Hide);
        }
        private void No_Reset_Click(object sender, EventArgs e)
        {
            ResetNAni.AddToQueue(Reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Hide);
        }
        /*--------- Reset End ---------*/
        /*--------- Sound Start ---------*/
        private void SoundPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (SoundPlay.Checked)
            {
                SoundSetting_BTN.Visible = true;
            }
            else SoundSetting_BTN.Visible = false;
        }
        private void SoundSetting_BTN_Click(object sender, EventArgs e)
        {
            Reset_YN_Panel.BringToFront();
            ResetNAni.AddToQueue(panelSound, Guna.UI2.AnimatorNS.AnimateMode.Show);
        }

        private void Sounds(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2RadioButton SR = (Guna.UI2.WinForms.Guna2RadioButton)sender;
            Soundplay(int.Parse(SR.Text.Substring(SR.Text.Length - 1)));
        }
        /*--------- Sound End ---------*/
        /*------------------ BTN End ------------------*/
    }
}
