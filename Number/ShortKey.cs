using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using Number.Properties;
using Guna.UI2.WinForms;

namespace Number
{
    public partial class ShortKey : Form
    {
        public ShortKey()
        {
            InitializeComponent();
        }
        /*------------------ func Start ------------------*/
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        /*--------- back to Default Keys ---------*/

        private void Default()
        {
            Settings.Default.ShortKey_Add = Keys.Add;
            Settings.Default.ShortKey_Clear = (Keys)Enum.Parse(typeof(Keys), "Alt,C");
            Settings.Default.ShortKey_Compress = (Keys)Enum.Parse(typeof(Keys), "Shift,C");
            Settings.Default.ShortKey_Counter = (Keys)Enum.Parse(typeof(Keys), "Shift,T");
            Settings.Default.ShortKey_SaveData = (Keys)Enum.Parse(typeof(Keys), "Control,S");
            Settings.Default.ShortKey_LoadData = (Keys)Enum.Parse(typeof(Keys), "Control,O");
            Settings.Default.Save();
            Short_key_set();
        }

        /*--------- Change Keys ---------*/
        private void Short_key_set()
        {
            Add_Key.Text = Settings.Default.ShortKey_Add.ToString();
            Clear_Key.Text = Settings.Default.ShortKey_Clear.ToString();
            Compress_Key.Text = Settings.Default.ShortKey_Compress.ToString();
            AutoCounter_Key.Text = Settings.Default.ShortKey_Counter.ToString();
            AddPage_Key.Text = Settings.Default.ShortKey_LoadData.ToString();
            SettingPage_Key.Text = Settings.Default.ShortKey_SaveData.ToString();
        }
        /*------------------ func End ------------------*/
        /*------------------ Move Form Start ------------------*/
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        /*------------------ Move Form End ------------------*/

        private void ShortKey_Load(object sender, EventArgs e)
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            Short_key_set();
        }
        /*------------------ Set Key ------------------*/
        private void Short_KeyDown(object sender, KeyEventArgs e)
        {
            Guna2Button key = (Guna2Button)sender;
            key.Text = e.KeyData.ToString();

        }
        /*------------------ Button Start ------------------*/
        private void Cancel_BTN_MouseEnter(object sender, EventArgs e)
        { Cancel_BTN.FillColor = Color.FromArgb(249, 75, 66); }

        private void Cancel_BTN_MouseLeave(object sender, EventArgs e)
        { Cancel_BTN.FillColor = Color.Empty; }
        private void Cancel_BTN_Click(object sender, EventArgs e)
        {this.Close();}

        private void Defult_BTN_Click(object sender, EventArgs e)
        {Default();}

        private void Save_BTN_Click(object sender, EventArgs e)
        {
            IList<string> list = new List<string> {Add_Key.Text, Clear_Key.Text, Compress_Key.Text,
                AutoCounter_Key.Text,SettingPage_Key.Text, AddPage_Key.Text };
            list = list.Distinct(StringComparer.InvariantCultureIgnoreCase).ToList();
            if (list.Count != 6)
            {
                Alert("خطا: میانبر ها نباید یکسان باشند");
            }
            else
            {
                Settings.Default.ShortKey_Add = (Keys)Enum.Parse(typeof(Keys), Add_Key.Text);
                Settings.Default.ShortKey_Clear = (Keys)Enum.Parse(typeof(Keys), Clear_Key.Text);
                Settings.Default.ShortKey_Compress = (Keys)Enum.Parse(typeof(Keys), Compress_Key.Text);
                Settings.Default.ShortKey_Counter = (Keys)Enum.Parse(typeof(Keys), AutoCounter_Key.Text);
                Settings.Default.ShortKey_SaveData = (Keys)Enum.Parse(typeof(Keys), SettingPage_Key.Text);
                Settings.Default.ShortKey_LoadData = (Keys)Enum.Parse(typeof(Keys), AddPage_Key.Text);
                Settings.Default.Save();
                this.Close();
            }
        }
        /*------------------ Button End ------------------*/
    }
}
