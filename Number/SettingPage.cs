using System;
using System.Drawing;
using System.Windows.Forms;
using Number.Properties;
using static Number.Cdata;


namespace Number
{
    public partial class SettingPage : Form
    {
        public SettingPage()
        {InitializeComponent();}
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
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
        /*------------------ BTN Start ------------------*/
        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Default.AlwaysOT = OnTopBTN.Checked;
            Settings.Default.DefaultColor = DarkMode.Checked;
            Settings.Default.AppFont = fontDialog1.Font;
            Settings.Default.Counter = Counter_Value.Value.ToString();
            Settings.Default.Save();
            this.Close();
        }
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
        private void DarkMode_CheckedChanged(object sender, EventArgs e)
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

        private void ShortKeyBTN_Click(object sender, EventArgs e)
        {
            new ShortKey().ShowDialog();
        }

        public void ReturnBTN_Click(object sender, EventArgs e)
        {
            string result = Cdata.LoadData();
            switch (result)
            {
                case "Suscess":
                    Alert("عملیات با موفقیت انجام شد");
                    break;
                case "Data Empty":
                    Alert("چیزی ذخیره نشده که بازگردانی شود");
                    break;
                case "Error":
                    Alert("مشکلی پیش آمد مجدد تلاش کنید");
                    break;
            }
        }
        /*--------- Reset Start ---------*/
        private void ResetBTN_Click(object sender, EventArgs e)
        {
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
        /*------------------ BTN End ------------------*/
    }
}
