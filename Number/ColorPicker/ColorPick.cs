using Guna.UI2.WinForms;
using Number.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Number
{
    public partial class ColorPick : Form
    {
        /*------------------ Variable Start ------------------*/
        private string wallpaper = "";
        private string path_wallpaper = "";
        private bool Repetitious = false;
        private Color SlectedBackColor = Color.FromArgb(11, 10, 27);
        private Random random = new Random();
        /*------------------ Variable Start ------------------*/
        public ColorPick()
        { InitializeComponent(); }
        public void Alert(string msg)
        {
            AlertBox frm = new AlertBox();
            frm.showAlert(msg);
        }

        static ColorPick _CP;
        public static ColorPick Instans
        {
            get
            {
                if (_CP == null)
                {
                    _CP = new ColorPick();
                }
                return _CP;
            }
        }

        void CkeckSettings()
        {

            if (RC.Value >= 180 && GC.Value >= 180 && BC.Value >= 180) Settings.Default.LightColor = true;
            else Settings.Default.LightColor = false;

            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                Save_BTN.ForeColor = Color.Black;
                Save_BTN.Image = Resources.exit_black;
                Cancel_BTN.ForeColor = Color.Black;
                Cancel_BTN.Image = Resources.cancel_black;
                BTN_ColorPicker.Image = Resources.color_dropper_black;
                Automatic_BTN.Image = Resources.wallpaper_black;
                random_BTN.Image = Resources.dice_black;
                favorite_BTN.Image = Resources.favorite_black;
                colorWheel_BTN.Image = Resources.color_wheel_black;
                TextBox_ColorHex.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.White;
                Save_BTN.ForeColor = Color.White;
                Save_BTN.Image = Resources.exit;
                Cancel_BTN.ForeColor = Color.White;
                Cancel_BTN.Image = Resources.cancel;
                BTN_ColorPicker.Image = Resources.color_dropper;
                Automatic_BTN.Image = Resources.wallpaper;
                random_BTN.Image = Resources.dice;
                favorite_BTN.Image = Resources.favorite;
                colorWheel_BTN.Image = Resources.color_wheel;
                TextBox_ColorHex.ForeColor = Color.White;
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
            TextBox_ColorHex.Text = string.Format("{0:X2}{1:X2}{2:X2}", RC.Value, GC.Value, BC.Value);
            TextBox_ColorHex.FillColor = this.BackColor;
            TextBox_ColorHex.Focus();

            if (!string.IsNullOrEmpty(Settings.Default.Color_History))
            {
                IList<string> Color_History = new List<string> { };
                string[] Colors = Settings.Default.Color_History.Split('\n');

                for (int i = 0; i < Colors.Length - 1; i++)
                {
                    Color_History.Add(Colors[i]);
                }

                Color_History = Color_History.Distinct(StringComparer.InvariantCultureIgnoreCase).Reverse().ToList();
                
                for (int i = 0; i < 9; i++)
                {
                    try
                    {
                        Guna2Button ColorButton = new Guna2Button();
                        ColorButton.Name = "BTN_" + random.Next();
                        ColorButton.Size = new Size(25, 25);
                        ColorButton.FillColor = Color.FromArgb(int.Parse(Color_History[i].Split(',')[0]), int.Parse(Color_History[i].Split(',')[1]), int.Parse(Color_History[i].Split(',')[2]));
                        ColorButton.Text = "";
                        ColorButton.BorderRadius = 3;
                        ColorButton.Click += BTN_Color_Click;
                        Panel_History_Colors.Controls.Add(ColorButton);
                    }
                    catch (Exception) { }

                }
            }

            CkeckSettings();
        }
        private void Refresh_Color(Color color)
        {
            if (color == Color.Empty)
            {
                this.BackColor = Color.FromArgb(RC.Value, GC.Value, BC.Value);
            }
            else
            {
                this.BackColor = color;
                RC.Value = color.R;
                GC.Value = color.G;
                BC.Value = color.B;
            }
            RT.Text = "مقدار رنگ قرمز: " + RC.Value;
            GT.Text = "مقدار رنگ سبز: " + GC.Value;
            BT.Text = "مقدار رنگ آبی: " + BC.Value;
            TextBox_ColorHex.FillColor = this.BackColor;
            TextBox_ColorHex.Text = string.Format("{0:X2}{1:X2}{2:X2}", RC.Value, GC.Value, BC.Value);
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
        /*--------- Set Color ---------*/
        private void RC_Scroll(object sender, ScrollEventArgs e)
        {
            Refresh_Color(Color.Empty);
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
            Guna2Button ColorBTN = (Guna2Button)sender;
            Refresh_Color(ColorBTN.FillColor);
        }
        /*------------------ Hex Color Start ------------------*/
        private void Hex_ChengeColor(object sender, EventArgs e)
        {
            try
            {
                int r, g, b;
                if (TextBox_ColorHex.Text.Length == 2)
                {
                    r = Convert.ToInt32(TextBox_ColorHex.Text.Substring(0, 2), 16);
                    g = 0;
                    b = 0;
                }
                else if (TextBox_ColorHex.Text.Length == 4)
                {
                    r = Convert.ToInt32(TextBox_ColorHex.Text.Substring(0, 2), 16);
                    g = Convert.ToInt32(TextBox_ColorHex.Text.Substring(2, 2), 16);
                    b = 0;

                }
                else if (TextBox_ColorHex.Text.Length == 6 || TextBox_ColorHex.Text.Length == 8)
                {
                    r = Convert.ToInt32(TextBox_ColorHex.Text.Substring(0, 2), 16);
                    b = Convert.ToInt32(TextBox_ColorHex.Text.Substring(4, 2), 16);
                    g = Convert.ToInt32(TextBox_ColorHex.Text.Substring(2, 2), 16);
                }
                else
                {
                    r = 0;
                    g = 0;
                    b = 0;
                }
                RC.Value = r;
                GC.Value = g;
                BC.Value = b;
                Refresh_Color(Color.Empty);
                CkeckSettings();
            }
            catch (Exception)
            {
                Alert("ساختار وارد شده صحیح نمیباشد"); TextBox_ColorHex.Select();
            }
            
        }

        private void Enter_Hex_ChengeColor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Hex_ChengeColor(TextBox_ColorHex, EventArgs.Empty); }
        }
        /*------------------ Hex Color End ------------------*/
        /*------------------ Option BTNs Start ------------------*/
        private void colorWheel_BTN_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Refresh_Color(cd.Color);
            }
        }
        private void BTN_ColorPicker_Click(object sender, EventArgs e)
        {
            Alert("در دست ساخت!");
        }
        private void Automatic_BTN_Click(object sender, EventArgs e)
        {
            panel_ColorBox.Enabled = false;
            Panel_Options.Enabled = false;
            Panel_History_Colors.Enabled = false;
            Panel_Exit.Enabled = false;
            try
            {
                using (var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop",false))
                {
                    if (regKey != null)
                    {
                        path_wallpaper = regKey.GetValue("WallPaper").ToString();
                        Repetitious = wallpaper == path_wallpaper;
                        wallpaper = path_wallpaper;
                        regKey.Close();
                    }
                }
                if (Repetitious)
                {
                    Refresh_Color(SlectedBackColor);
                }
                else if (System.IO.File.Exists(path_wallpaper))
                {
                    using (var image = new Bitmap(path_wallpaper))
                    {
                        var dict = new Dictionary<Color, int>();
                        for (int i = 0; i < image.Width; i++)
                        {
                            for (int j = 0; j < image.Height; j++)
                            {
                                Color color = image.GetPixel(i, j);
                                dict.TryGetValue(color, out int count);
                                dict[color] = count + 1;
                            }
                        }
                        image.Dispose();
                        dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        SlectedBackColor = dict.Last().Key;
                        dict.Clear();
                        Refresh_Color(SlectedBackColor);
                    }
                }
                else
                {
                    Alert("!امکان انتخاب رنگ از پس زمینه برای شما وجود ندارد");
                }
            }
            catch (Exception ex)
            {
                Alert(ex.Message);
            }
            panel_ColorBox.Enabled = true;
            Panel_Options.Enabled = true;
            Panel_History_Colors.Enabled = true;
            Panel_Exit.Enabled = true;
        }

        private void random_BTN_Click(object sender, EventArgs e)
        {
            Refresh_Color(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
        }
        /*------------------ Option BTNs End ------------------*/
        /*--------- Exit Start ---------*/
        private void Save_BTN_Click(object sender, EventArgs e)
        {
            Settings.Default.Theme = this.BackColor;
            Settings.Default.Color_History += this.BackColor.R + "," + this.BackColor.G + "," + this.BackColor.B + "\n";
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
        private void Cancel_BTN_Click(object sender, EventArgs e)
        { this.Close(); }


        /*--------- Exit End ---------*/
    }
}
