using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Number.Properties;
using static Number.Cdata;


namespace Number
{
    public partial class SettingPage : Form
    {
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
            using (var player = new System.Media.SoundPlayer())
            {
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

        }

        void Fill_ComboBox()
        {
            defaultNum_ComboBox.Items.Clear();
            try
            {
                DataXML.Load("Data.xml");
                using (var NumberNodes = DataXML.SelectNodes("//Numbers/Number"))
                {
                    foreach (XmlNode NumberNode in NumberNodes)
                    {
                        string Name = NumberNode.Attributes["Name"].Value;
                        defaultNum_ComboBox.Items.Add(Name);
                    }
                }
            }
            catch (Exception) { Alert("خطا:فایل شمارنده ها حذف شده است!"); }
        }
        /*------------------ Func End ------------------*/
        private void SettingPage_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.Theme;
                colorPicker_BTN.Visible = true;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                cancel_BTN.ForeColor = Color.Black;
                cancel_BTN.Image = Resources.cancel_black;
                save_BTN.ForeColor = Color.Black;
                save_BTN.Image = Resources.save_black;
                colorPicker_BTN.ForeColor = Color.Black;
                colorPicker_BTN.BorderColor = Color.Black;
                colorPicker_BTN.Image = Resources.paint_palette_black;
                soundSetting_BTN.ForeColor = Color.Black;
                soundSetting_BTN.BorderColor = Color.Black;
                soundSetting_BTN.Image = Resources.music_black;
                shortKey_BTN.ForeColor = Color.Black;
                shortKey_BTN.BorderColor = Color.Black;
                shortKey_BTN.Image = Resources.keyboard_black;
                fontClear_BTN.ForeColor = Color.Black;
                fontClear_BTN.BorderColor = Color.Black;
                fontClear_BTN.Image = Resources.clear_formatting_black;
                font_BTN.ForeColor = Color.Black;
                font_BTN.BorderColor = Color.Black;
                font_BTN.Image = Resources.font_style_formatting_black;
                noReset_BTN.ForeColor = Color.Black;
                noReset_BTN.BorderColor = Color.Black;
                noReset_BTN.Image = Resources.delete_black;
                reset_BTN.ForeColor = Color.Black;
                reset_BTN.Image = Resources.reset_black;
                yesReset_BTN.ForeColor = Color.Black;
                yesReset_BTN.Image = Resources.checkmark_black;
            }
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            Counter_Value.Value = Convert.ToDecimal(Settings.Default.Counter);
            onTop_Toggle.Checked = Settings.Default.AlwaysOT;
            theme_Toggle.Checked = Settings.Default.DefaultColor;
            fontDialog1.Font = Settings.Default.AppFont;
            soundPlay_Toggle.Checked = Settings.Default.Sound_EFX;
            Fill_ComboBox();
            defaultNum_ComboBox.Text = Settings.Default.DefaultNumber;
            if (Settings.Default.Sound_EFX)
            {
                soundSetting_BTN.Visible = true;
            }
            switch (Settings.Default.Sound_Num)
            {
                case 1:
                    sound1_RBTN.Checked = true;
                    break;
                case 2:
                    sound2_RBTN.Checked = true;
                    break;
                case 3:
                    sound3_RBTN.Checked = true;
                    break;
                case 4:
                    sound4_RBTN.Checked = true;
                    break;
                case 5:
                    sound5_RBTN.Checked = true;
                    break;
            }
            if (Settings.Default.AppFont == Settings.Default.DFont)
            {
                fontClear_BTN.Visible = false;
            }
            else fontClear_BTN.Visible = true;
        }
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
            Settings.Default.AlwaysOT = onTop_Toggle.Checked;
            Settings.Default.DefaultColor = theme_Toggle.Checked;
            Settings.Default.AppFont = fontDialog1.Font;
            Settings.Default.Counter = Counter_Value.Value.ToString();
            Settings.Default.Sound_EFX = soundPlay_Toggle.Checked;
            Settings.Default.DefaultNumber = defaultNum_ComboBox.Text;
            Settings.Default.Save();
            this.Close();
        }
        /*--------- CancelBTN ---------*/
        private void CancelBTN_Click(object sender, EventArgs e)
        { this.Close();}
        /*--------- Background ---------*/
        private void BackgroundMode_CheckedChanged(object sender, EventArgs e)
        {
            if (theme_Toggle.Checked == false)
            {
                colorPicker_BTN.Visible = true;
                if (Settings.Default.Theme.R >= 180 && Settings.Default.Theme.G >= 180 && Settings.Default.Theme.B >= 180)
                {
                    Settings.Default.LightColor = true;
                }
                else Settings.Default.LightColor = false;
            }
            else 
            { 
                colorPicker_BTN.Visible = false;
                Settings.Default.LightColor = false;
            }
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
            reset_YN_Panel.BringToFront();
            resetPanel_Animation.AddToQueue(reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Show);
            
        }
        /*----- Yes Reset -----*/
        private void Yes_Reset_Click(object sender, EventArgs e)
        {
            Cdata.Delete();
            Alert("شمارنده ها بازنشانی شدند");
            resetPanel_Animation.AddToQueue(reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Hide);
        }
        /*----- Np Reset -----*/
        private void No_Reset_Click(object sender, EventArgs e)
        {
            resetPanel_Animation.AddToQueue(reset_YN_Panel, Guna.UI2.AnimatorNS.AnimateMode.Hide);
        }
        /*--------- Reset End ---------*/
        /*--------- Sound Start ---------*/
        private void SoundPlay_CheckedChanged(object sender, EventArgs e)
        {
            if (soundPlay_Toggle.Checked)
            {
                soundSetting_BTN.Visible = true;
            }
            else soundSetting_BTN.Visible = false;
        }
        private void SoundSetting_BTN_Click(object sender, EventArgs e)
        {
            reset_YN_Panel.BringToFront();
            resetPanel_Animation.AddToQueue(panelSound, Guna.UI2.AnimatorNS.AnimateMode.Show);
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
