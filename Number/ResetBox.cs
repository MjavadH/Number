using Number.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class ResetBox : Form
    {
        public ResetBox()
        {
            InitializeComponent();
        }
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        /*------------------ func Start ------------------*/
        private void SettingCheck()
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                BTN_DefultN.ForeColor = Color.Black;
                BTN_DefultN.BorderColor = Color.Black;
                BTN_DefultN.Image = Resources.save_black;
                BTN_SaveN.ForeColor = Color.Black;
                BTN_SaveN.BorderColor = Color.Black;
                BTN_SaveN.Image = Resources.reset_black;
                BTN_exit.Image = Resources.delete_black;
                panel_top.BackColor = Color.FromArgb(BackColor.R - 10, BackColor.G - 10, BackColor.B - 10);
                panel_right.BackColor = Color.FromArgb(BackColor.R - 10, BackColor.G - 10, BackColor.B - 10);
                panel_left.BackColor = Color.FromArgb(BackColor.R - 10, BackColor.G - 10, BackColor.B - 10);
                panel_bottom.BackColor = Color.FromArgb(BackColor.R - 10, BackColor.G - 10, BackColor.B - 10);
            }
            else
            {
                panel_top.BackColor = Color.FromArgb(BackColor.R + 10, BackColor.G + 10, BackColor.B + 10);
                panel_right.BackColor = Color.FromArgb(BackColor.R + 10, BackColor.G + 10, BackColor.B + 10);
                panel_left.BackColor = Color.FromArgb(BackColor.R + 10, BackColor.G + 10, BackColor.B + 10);
                panel_bottom.BackColor = Color.FromArgb(BackColor.R + 10, BackColor.G + 10, BackColor.B + 10);
            }
            this.Font = Settings.Default.AppFont;
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
        private void ResetBox_Load(object sender, EventArgs e)
        {
            SettingCheck();
        }

        /*------------------ ‌BTN Start ------------------*/
        /*--------- Save ---------*/
        private void BTN_SaveN_Click(object sender, EventArgs e)
        {
            string result = Cdata.LoadData();
            switch (result)
            {
                case "Suscess":
                    Alert("عملیات با موفقیت انجام شد");
                    this.Close();
                    break;
                case "Data Empty":
                    Alert("چیزی ذخیره نشده که بازگردانی شود");
                    break;
            }
        }
        /*--------- Defult ---------*/
        private void BTN_DefultN_Click(object sender, EventArgs e)
        {
            Cdata.CreateNew();
            this.Close();
        }
        /*--------- exit ---------*/
        private void BTN_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*------------------ ‌BTN End ------------------*/
    }
}
