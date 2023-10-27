using Microsoft.WindowsAPICodePack.Taskbar;
using Number.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;

/*------------------------------ Number Aplication ------------------------------
 *                                                                              *
 *       __ __            __ __                         __            __        *
 *      |  |\ \          / /|  |                       |  |          |  |       *
 *      |  | \ \        / / |  |                       |  |          |  |       *
 *      |  |  \ \      / /  |  |                       |  |__________|  |       *
 *      |  |   \ \    / /   |  |                       |  |          |  |       *
 *      |  |    \ \  / /    |  |                       |  |――――――――――|  |       *
 *      |  |     \ \/ /     |  |                       |  |          |  |       *
 *      |  |      \  /      |  |                       |  |          |  |       *
 *      |__|       \/       |__|                       |__|          |__|       *
 *                                                                              *
 *             ________________________________________________                 *
 *            |                                                |                *
 *            |                                                |                *
 *            |     Designer & Programmer: MjavadH             |                *
 *            |     GitHub: https://github.com/MjavadH/Number  |                *
 *            |                                                |                *
 *            |                                                |                *
 *            |________________________________________________|                *
 *                                                                              *
 *                                                                              *
 *                                                                              *
 *                                                                              *
 *        ███╗░░░███╗░░░░░██╗░█████╗░██╗░░░██╗░█████╗░██████╗░██╗░░██╗          *
 *        ████╗░████║░░░░░██║██╔══██╗██║░░░██║██╔══██╗██╔══██╗██║░░██║          *
 *        ██╔████╔██║░░░░░██║███████║╚██╗░██╔╝███████║██║░░██║███████║          *
 *        ██║╚██╔╝██║██╗░░██║██╔══██║░╚████╔╝░██╔══██║██║░░██║██╔══██║          *
 *        ██║░╚═╝░██║╚█████╔╝██║░░██║░░╚██╔╝░░██║░░██║██████╔╝██║░░██║          *
 *        ╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝          *     
 *                                                                              *
 * -----------------------------------------------------------------------------*/

namespace Number
{
    public partial class NumberForm : Form
    {
        /*--------- Create var XmlDoc ---------*/
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
                TextBox.ForeColor = Color.Empty;
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                Add();
            }
        }
        private void setting_check()
        {
            if (Settings.Default.DefaultColor == false)
            {
                this.BackColor = Settings.Default.Theme;
            }
            else this.BackColor = Color.FromArgb(11, 10, 27);
            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                MenuBTN.Image = Resources.menu_black;
                add.Image = Resources.add_list_black;
                Clear.Image = Resources.erase_black;
                Help.Image = Resources.question_mark_black;
                Setting.Image = Resources.settings_black;
                Compressbtn.Image = Resources.compress_black;
                counter.Image = Resources.counter_black;
                Show_Text_BTN.Image = Resources.expand_arrow_black;
                Show_Text_BTN.ForeColor = Color.Black;
                min.Image = Resources.subtract_black;
                exit.Image = Resources.delete_black;
            }
            else
            {
                this.ForeColor = Color.White;
                MenuBTN.Image = Resources.menu;
                add.Image = Resources.add_list;
                Clear.Image = Resources.erase;
                Help.Image = Resources.question_mark;
                Setting.Image = Resources.settings;
                Compressbtn.Image = Resources.compress;
                counter.Image = Resources.counter;
                Show_Text_BTN.Image = Resources.expand_arrow;
                Show_Text_BTN.ForeColor = Color.White;
                min.Image = Resources.subtract;
                exit.Image = Resources.delete;
            }
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            counter_Timer.Interval = Convert.ToInt32(Settings.Default.Counter + "000");
            if (NumberT.Dock != DockStyle.Fill)
            {
                NumberT.Font = new Font(Settings.Default.AppFont.Name, 35);
            }
        }
        /*--------- Add one to the selected number ---------*/
        private void Add()
        {
            if (File.Exists("Data.xml"))
            {
                try
                {
                    DataXML.Load("Data.xml");
                    using (var NumberNodes = DataXML.SelectNodes("//Numbers/Number"))
                    {
                        foreach (XmlNode NumberNode in NumberNodes)
                        {
                            if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                            {
                                NumberNode.InnerText = (int.Parse(NumberNode.InnerText) + 1).ToString(); // Add one

                                NumberLeftP.Maximum = int.Parse(NumberNode.Attributes["Len"].Value) + 1;
                                NumberLeftP.Value = int.Parse(NumberNode.InnerText);
                                TaskbarManager.Instance.SetProgressValue(NumberLeftP.Value, NumberLeftP.Maximum);

                                int Leftnum = int.Parse(NumberNode.Attributes["Len"].Value) - int.Parse(NumberNode.InnerText);
                                this.Text = "باقیمانده: " + Leftnum.ToString() + " | شمارنده";
                                DataXML.Save("Data.xml");
                                NumberT.Text = NumberNode.InnerText;
                                /*---- if Complete ----*/
                                if (int.Parse(NumberT.Text) > int.Parse(NumberNode.Attributes["Len"].Value))
                                {
                                    NumberNode.InnerText = "0";
                                    DataXML.Save("Data.xml");
                                    NumberT.Text = NumberNode.InnerText;
                                    this.Alert("شمارش " + DropDown.Text + " " + "به پایان رسید");
                                }
                                break;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    try
                    {
                        DataXML.Load("Data.xml");
                        using (var NumberUNodes = DataXML.SelectNodes("//Numbers/Number"))
                        {
                            foreach (XmlNode NumberNode in NumberUNodes)
                            {
                                if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                                {
                                    NumberLeftP.Value = 0;
                                    NumberNode.InnerText = (ulong.Parse(NumberNode.InnerText) + 1).ToString();
                                    this.Text = "باقی مانده: بدون محدودیت | شمارنده";
                                    DataXML.Save("Data.xml");
                                    NumberT.Text = NumberNode.InnerText;
                                    break;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (counter_Timer.Enabled)
                        {
                            counter_Timer.Stop();
                        }
                        new ResetBox().ShowDialog();
                    }
                }
            }
            else
            {
                if (counter_Timer.Enabled)
                {
                    counter_Timer.Stop();
                }
                new ResetBox().ShowDialog();
            }
        }
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }
        private void Change_Size()
        {
            this.Size = new Size(NumberT.Size.Width, NumberT.Size.Height + Show_Text_BTN.Height);
        }
        private void Fill_Number_combo()
        {
            DropDown.Items.Clear();
            try
            {
                DataXML.Load("Data.xml");
                using (var NumberNodes = DataXML.SelectNodes("//Numbers/Number"))
                {
                    foreach (XmlNode NumberNode in NumberNodes)
                    {
                        string Name = NumberNode.Attributes["Name"].Value;
                        DropDown.Items.Add(Name);
                    }
                }
            }
            catch (Exception) { new ResetBox().ShowDialog(); }
        }
        /*------------------ func End ------------------*/
        private void Form1_Load(object sender, EventArgs e)
        {
            setting_check();
            Cdata.CreateNew();
            Fill_Number_combo();
            if (!string.IsNullOrEmpty(Settings.Default.DefaultNumber))
            {
                DropDown.Text = Settings.Default.DefaultNumber;
            }
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
        /*--------- Exit app ---------*/
        private void exit_Click(object sender, EventArgs e)
        { this.Close(); }
        /*--------- Menu Show&Hide ---------*/
        private void Menu_Click(object sender, EventArgs e)
        {
            if (MenuBar.Visible == false)
            {
                AnimationMenu.Show(MenuBar);
            }
            else
            {
                AnimationMenu.Hide(MenuBar);
            }
        }
        /*--------- Minimize app ---------*/
        private void min_Click(object sender, EventArgs e)
        { this.WindowState = FormWindowState.Minimized; }
        /*--------- Clear Number ---------*/
        private void Clear_Click(object sender, EventArgs e)
        {
            Check_DropDown();
            NumberT.Text = Cdata.Clear(DropDown.Text);
        }
        /*--------- Show Pages Start ---------*/
        private void add_Click(object sender, EventArgs e)
        { new DataBase().ShowDialog(); }
        private void Help_Click(object sender, EventArgs e)
        { new HelpPage().ShowDialog(); }
        private void Setting_Click(object sender, EventArgs e)
        { new SettingPage().ShowDialog(); }
        /*--------- Show Pages End ---------*/
        /*--------- Compress Start ---------*/
        private void Compressbtn_Click(object sender, EventArgs e)
        {
            if (NumberT.Dock != DockStyle.Fill)
            {
                Show_Text_BTN.Visible = true;
                Show_Text_BTN.Dock = DockStyle.Bottom;
                Show_Text_BTN.SendToBack();
                Show_Text_BTN.Select();
                NumberT.AutoSize = true;
                NumberT.Dock = DockStyle.Fill;
                NumberT.Font = new Font(Settings.Default.AppFont.Name, 25);
                DropDown.Visible = false;
                TextBox.Visible = false;
                MenuBar.Visible = false;
                MenuBTN.Visible = false;
                min.Visible = false;
                exit.Visible = false;
                TextLen.Visible = false;
                Compressbtn.Visible = false;
                ToolTips.SetToolTip(NumberT, string.Format("برای بزرگ نمایی از کلید میانبر ({0}) استفاده کنید", Settings.Default.ShortKey_Compress));
                Change_Size();
            }
            else NumberT_DoubleClick(NumberT, EventArgs.Empty);
        }
        /*----- Decompress -----*/
        private void NumberT_DoubleClick(object sender, EventArgs e)
        {

            Show_Text_BTN.Visible = false;
            Show_Text_BTN.Checked = false;
            if (Settings.Default.LightColor) Show_Text_BTN.Image = Resources.expand_arrow_black;
            else Show_Text_BTN.Image = Resources.expand_arrow;
            Show_Text_BTN.Text = "";
            Show_Text_BTN.Height = 20;
            Show_Text_BTN.Dock = DockStyle.None;

            NumberT.Select();
            NumberT.AutoSize = false;
            NumberT.Dock = DockStyle.Bottom;
            NumberT.Font = new Font(Settings.Default.AppFont.Name, 35);
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
            if (NumberT.Dock == DockStyle.Fill) Change_Size();
        }
        /*----- Show text box text btn -----*/
        private void Show_Text_BTN_Click(object sender, EventArgs e)
        {
            if (DropDown.Text == "")
            {
                Alert("شمارنده ای انتخاب نشده!");
            }
            else
            {
                if (Show_Text_BTN.Checked)
                {
                    if (Settings.Default.LightColor)
                    {
                        Show_Text_BTN.Image = Resources.collapse_arrow_black;
                    }
                    else
                    {
                        Show_Text_BTN.Image = Resources.collapse_arrow;
                    }
                    Show_Text_BTN.Text = TextBox.Text;
                    Show_Text_BTN.Height = 55;
                    this.Size = new Size(Show_Text_BTN.Text.Length * 4 + 25, NumberT.Size.Height + Show_Text_BTN.Height);
                }
                else
                {
                    if (Settings.Default.LightColor)
                    {
                        Show_Text_BTN.Image = Resources.expand_arrow_black;
                    }
                    else
                    {
                        Show_Text_BTN.Image = Resources.expand_arrow;
                    }
                    Show_Text_BTN.Text = "";
                    Show_Text_BTN.Height = 20;
                    Change_Size();
                }
            }
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
                using (var NumberNodes = DataXML.SelectNodes("//Numbers/Number"))
                {
                    foreach (XmlNode NumberNode in NumberNodes)
                    {
                        if (NumberNode.Attributes["Name"].Value == DropDown.Text)
                        {
                            string XMLText = (string)NumberNode.Attributes["Text"].Value;
                            string XMLLen = (string)NumberNode.Attributes["Len"].Value;
                            TextBox.Text = XMLText;
                            TextLen.Text = "تعداد: " + XMLLen;
                            NumberT.Text = NumberNode.InnerText;
                            break;
                        }
                    }
                }
            }
            catch (Exception) { new ResetBox().ShowDialog(); }
        }
        private void DropDown_Click(object sender, EventArgs e)
        {
            string lastD = DropDown.Text;
            Fill_Number_combo();
            DropDown.Text = lastD;
        }
        /*------------------ DropDown End ------------------*/
        /*------------------ Short Key Start ------------------*/
        private void ShortKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Settings.Default.ShortKey_Clear)
            {
                NumberT.Text = Cdata.Clear(DropDown.Text);
            }
            else if (e.KeyData == Settings.Default.ShortKey_SaveData)
            {
                new DataBase().SaveData_Click("Save", EventArgs.Empty);
            }
            else if (e.KeyData == Settings.Default.ShortKey_LoadData)
            {
                new DataBase().ReturnBTN_Click(sender, EventArgs.Empty);
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
        private void NumberForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Settings.Default.ShortKey_Add)
            {
                Check_DropDown();
            }
        }
        /*------------------ Short Key End ------------------*/

    }
}
