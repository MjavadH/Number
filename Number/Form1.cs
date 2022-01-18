using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using Number.Properties;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using static Number.Cdata;

namespace Number
{
    public partial class NumberForm : Form
    {
        XmlDocument DataXML = new XmlDocument();
        public NumberForm()
        {
            InitializeComponent();
        }
        /*------------------ func Start ------------------*/
        private void Check_DropDown()
        {
            if (DropDown.Text == "")
            {
                TextBox.Text = "شمارنده ای انتخاب نشده!";
                TextLen.Text = "تعداد:مشخص نشده!";
                TextBox.ForeColor = Color.Red;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
            }
            else
            {
                TextBox.ForeColor = Color.White;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                AddT();
            }
        }
        private void setting_check()
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.LightTheme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            counter_Timer.Interval = Convert.ToInt32(Settings.Default.Counter + "000");
            NumberT.Font = new Font(Settings.Default.AppFont.Name, 35);
            if (Settings.Default.UpdateData)
            {
                Settings.Default.UpdateData = false;
                Settings.Default.Save();
                Alert("به علت خطای غیر منتظره شمارنده ها به حالت اولیه برگشتند");
            }
        }
        private void AddT() 
        {
            try
            {
                DataXML.Load("Data.xml");
                XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                foreach (XmlNode NumberNode in NumberNodes)
                {
                    if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                    {
                        NumberNode.InnerText = (int.Parse(NumberNode.InnerText) + 1).ToString();

                        NumberLeftP.Maximum = int.Parse(NumberNode.Attributes["Len"].Value) + 1;
                        NumberLeftP.Value = int.Parse(NumberNode.InnerText);
                        TaskbarManager.Instance.SetProgressValue(NumberLeftP.Value, NumberLeftP.Maximum);

                        int Leftnum = int.Parse(NumberNode.Attributes["Len"].Value) - int.Parse(NumberNode.InnerText);
                        this.Text = "باقیمانده: " + Leftnum.ToString() + " | شمارنده";
                        DataXML.Save("Data.xml");
                        NumberT.Text = NumberNode.InnerText;
                        if (int.Parse(NumberT.Text) > int.Parse(NumberNode.Attributes["Len"].Value))
                        {
                            NumberNode.InnerText = "0";
                            DataXML.Save("Data.xml");
                            NumberT.Text = NumberNode.InnerText;
                            this.Alert("شمارش " + DropDown.Text + " " + "به پایان رسید");
                        }
                    }
                }
            }
            catch (Exception)
            {
                try
                {
                    DataXML.Load("Data.xml");
                    XmlNodeList NumberUNodes = DataXML.SelectNodes("//Numbers/Number");
                    foreach (XmlNode NumberNode in NumberUNodes)
                    {
                        if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                        {
                            NumberNode.InnerText = (int.Parse(NumberNode.InnerText) + 1).ToString();
                            this.Text = "باقی مانده: بدون محدودیت | شمارنده";
                            DataXML.Save("Data.xml");
                            NumberT.Text = NumberNode.InnerText;
                        }
                    }
                }
                catch (Exception)
                {
                    Alert("خطا:امکان شمارش وجود ندارد لطفا برنامه را بسته و مجدد باز نمایید");
                    if (counter_Timer.Enabled)
                    {
                        counter_Timer.Stop();
                    }
                    try
                    {
                        File.Delete("Data.xml");
                        Settings.Default.UpdateData = true;
                        Settings.Default.Save();
                    }
                    catch (Exception)
                    {}
                }
            }
        }
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        private void CH_Size()
        {
            this.Size = NumberT.Size;
        }
        /*------------------ func End ------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            setting_check();
            Cdata.CreateNew();
        }
        private void NumberForm_Activated(object sender, EventArgs e)
        {
            setting_check();
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
        /*------------------ Add Text Start ------------------*/
        private void AddT_Click(object sender, EventArgs e)
        {
            Check_DropDown();
        }
        /*------------------ Add Text End ------------------*/
        /*------------------ Button Start ------------------*/
        private void exit_Click(object sender, EventArgs e)
        {this.Close();}
        private void Menu_Click(object sender, EventArgs e)
        {
            if (MenuBar.Visible == false)
            {
                AnimationMenu.AddToQueue(MenuBar, Guna.UI2.AnimatorNS.AnimateMode.Show);
            }
            else
            {
                AnimationMenu.AddToQueue(MenuBar, Guna.UI2.AnimatorNS.AnimateMode.Hide);
            }
        }
        private void min_Click(object sender, EventArgs e)
        {this.WindowState = FormWindowState.Minimized;}
        private void Clear_Click(object sender, EventArgs e)
        {
            Check_DropDown();
            NumberT.Text = Cdata.Clear(DropDown.Text);
        }
        private void add_Click(object sender, EventArgs e)
        {new DataBase().ShowDialog();}
        private void Help_Click(object sender, EventArgs e)
        {new HelpPage().ShowDialog();}
        private void Setting_Click(object sender, EventArgs e)
        {new SettingPage().ShowDialog();}

        /*--------- Compress Start ---------*/
        private void Compressbtn_Click(object sender, EventArgs e)
        {
            if (NumberT.Dock != DockStyle.Fill)
            {
                NumberT.AutoSize = true;
                NumberT.Dock = DockStyle.Fill;
                DropDown.Visible = false;
                TextBox.Visible = false;
                MenuBar.Visible = false;
                MenuBTN.Visible = false;
                min.Visible = false;
                exit.Visible = false;
                TextLen.Visible = false;
                Compressbtn.Visible = false;
                this.Size = NumberT.Size;
                ToolTips.SetToolTip(NumberT, "برای بزرگ نمایی از کلید میانبر" + " ( " + Settings.Default.ShortKey_Compress.ToString() + " ) " + "استفاده کنید");
                CH_Size();
            }
            else NumberT_DoubleClick(NumberT, EventArgs.Empty);
        }
        /*----- Decompress -----*/
        private void NumberT_DoubleClick(object sender, EventArgs e)
        {
            NumberT.AutoSize = false;
            NumberT.Dock = DockStyle.Bottom;
            DropDown.Visible = true;
            TextBox.Visible = true;
            MenuBTN.Visible = true;
            min.Visible = true;
            exit.Visible = true;
            TextLen.Visible = true;
            Compressbtn.Visible = true;
            ToolTips.SetToolTip(NumberT, "");
            this.Width = 409;
            this.Height = 339;
        }
        /*----- Fix Size -----*/
        private void NumberT_SizeChanged(object sender, EventArgs e)
        {
            if (NumberT.Dock == DockStyle.Fill) CH_Size();
        }
        /*--------- Compress End ---------*/
        /*--------- Counter Start ---------*/
        string counterT;
        private void counter_Click(object sender, EventArgs e)
        {
            if (counter_Timer.Enabled)
            {
                counter_Timer.Stop();
                counter_Status.ForeColor = Color.Red;
            }
            else
            {
                counter_Status.ForeColor = Color.Chartreuse;
                counterT = DropDown.Text;
                counter_Timer.Start();
            }
        }
        private void counter_Timer_Tick(object sender, EventArgs e)
        {
            if (counterT == DropDown.Text)
            {
                Check_DropDown();
            }
            else
            {
                counter_Status.ForeColor = Color.Red;
                counter_Timer.Stop();
            }
        }
        /*--------- Counter End ---------*/
        /*------------------ Button End ------------------*/
        /*------------------ DropDown Start ------------------*/
        private void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataXML.Load("Data.xml");
                XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                foreach (XmlNode NumberNode in NumberNodes)
                {
                    if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                    {
                        string XMLText = (string)NumberNode.Attributes["Text"].Value;
                        string XMLLen = (string)NumberNode.Attributes["Len"].Value;
                        TextBox.Text = XMLText;
                        TextLen.Text = "تعداد: " + XMLLen;
                        NumberT.Text = NumberNode.InnerText;
                    }
                }
            }
            catch (Exception){ Alert("خطا:لطفا برنامه را بسته و مجدد باز نمایید!"); }
        }
        private void DropDown_Click(object sender, EventArgs e)
        {
            string lastD = DropDown.Text;
            DropDown.Items.Clear();
            try
            {
                DataXML.Load("Data.xml");
                XmlNodeList NumberNodes = DataXML.SelectNodes("//Numbers/Number");
                foreach (XmlNode NumberNode in NumberNodes)
                {
                    string Name = NumberNode.Attributes["Name"].Value;
                    DropDown.Items.Add(Name);
                }
            }
            catch (Exception){ Alert("خطا:لطفا برنامه را بسته و مجدد باز نمایید!"); }
            DropDown.Text = lastD;
        }
        /*------------------ DropDown End ------------------*/
        /*------------------ Short Key Start ------------------*/
        private void ShortKey_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyData == Settings.Default.ShortKey_Add)
            {
                Check_DropDown();
            }
            else if (e.KeyData == Settings.Default.ShortKey_Clear)
            {
                NumberT.Text = Cdata.Clear(DropDown.Text);
            }
            else if (e.KeyData == Settings.Default.ShortKey_Setting)
            {
                Setting_Click(Setting, EventArgs.Empty);
            }
            else if (e.KeyData == Settings.Default.ShortKey_AddN)
            {
                add_Click(add, EventArgs.Empty);
            }
            else if (e.KeyData == Settings.Default.ShortKey_Compress)
            {
                Compressbtn_Click(Compressbtn, EventArgs.Empty);
            }
            else if (e.KeyData == Settings.Default.ShortKey_Counter)
            {
                counter_Click(counter, EventArgs.Empty);
            }
        }
        /*------------------ Short End ------------------*/

    }
}
