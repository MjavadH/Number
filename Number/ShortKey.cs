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
            add_Key.Text = Settings.Default.ShortKey_Add.ToString();
            clear_Key.Text = Settings.Default.ShortKey_Clear.ToString();
            compress_Key.Text = Settings.Default.ShortKey_Compress.ToString();
            autoCounter_Key.Text = Settings.Default.ShortKey_Counter.ToString();
            loadData_Key.Text = Settings.Default.ShortKey_LoadData.ToString();
            saveData_Key.Text = Settings.Default.ShortKey_SaveData.ToString();
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
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                cancel_BTN.ForeColor = Color.Black;
                cancel_BTN.Image = Resources.cancel_black;
                default_BTN.ForeColor = Color.Black;
                default_BTN.Image = Resources.undo_black;
                save_BTN.ForeColor = Color.Black;
                save_BTN.Image = Resources.save_black;

                add_Key.ForeColor = Color.Black;
                clear_Key.ForeColor = Color.Black;
                compress_Key.ForeColor = Color.Black;
                autoCounter_Key.ForeColor = Color.Black;
                saveData_Key.ForeColor = Color.Black;
                loadData_Key.ForeColor = Color.Black;
            }
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
        /*--------- Cancel ---------*/
        private void Cancel_BTN_MouseEnter(object sender, EventArgs e)
        { cancel_BTN.FillColor = Color.FromArgb(249, 75, 66); }

        private void Cancel_BTN_MouseLeave(object sender, EventArgs e)
        { cancel_BTN.FillColor = Color.Empty; }
        private void Cancel_BTN_Click(object sender, EventArgs e)
        {this.Close();}
        /*--------- Defult ---------*/
        private void Defult_BTN_Click(object sender, EventArgs e)
        {Default();}
        /*--------- Save ---------*/
        private void Save_BTN_Click(object sender, EventArgs e)
        {
            IList<string> list = new List<string> {add_Key.Text, clear_Key.Text, compress_Key.Text,
                autoCounter_Key.Text,saveData_Key.Text, loadData_Key.Text };
            list = list.Distinct(StringComparer.InvariantCultureIgnoreCase).ToList();
            if (list.Count != 6)
            {
                Alert("خطا: میانبر ها نباید یکسان باشند");
            }
            else
            {
                Settings.Default.ShortKey_Add = (Keys)Enum.Parse(typeof(Keys), add_Key.Text);
                Settings.Default.ShortKey_Clear = (Keys)Enum.Parse(typeof(Keys), clear_Key.Text);
                Settings.Default.ShortKey_Compress = (Keys)Enum.Parse(typeof(Keys), compress_Key.Text);
                Settings.Default.ShortKey_Counter = (Keys)Enum.Parse(typeof(Keys), autoCounter_Key.Text);
                Settings.Default.ShortKey_SaveData = (Keys)Enum.Parse(typeof(Keys), saveData_Key.Text);
                Settings.Default.ShortKey_LoadData = (Keys)Enum.Parse(typeof(Keys), loadData_Key.Text);
                Settings.Default.Save();
                this.Close();
            }
        }
        /*------------------ Button End ------------------*/
    }
}
