using Guna.UI2.WinForms;
using Number.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Number
{
    public partial class ColorPick : Form
    {
        /*------------------ Variable Start ------------------*/
        private string wallpaper = "";
        private string path_wallpaper = "";
        private string Favorite_File = "FavoriteColor.txt";
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

        private void CkeckSettings()
        {

            if (red_Bar.Value >= 180 && green_Bar.Value >= 180 && blue_Bar.Value >= 180) Settings.Default.LightColor = true;
            else Settings.Default.LightColor = false;

            if (Settings.Default.LightColor)
            {
                this.ForeColor = Color.Black;
                save_BTN.ForeColor = Color.Black;
                save_BTN.Image = Resources.exit_black;
                cancel_BTN.ForeColor = Color.Black;
                cancel_BTN.Image = Resources.cancel_black;
                colorpicker_BTN.Image = Resources.color_dropper_black;
                automatic_BTN.Image = Resources.wallpaper_black;
                random_BTN.Image = Resources.dice_black;
                if (flp_ColorFavorite.Visible)
                {
                    favorite_BTN.Image = Resources.delete_black;
                }
                else
                {
                    favorite_BTN.Image = Resources.favorite_black;
                }
                colorWheel_BTN.Image = Resources.color_wheel_black;
                hex_TextBox.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.White;
                save_BTN.ForeColor = Color.White;
                save_BTN.Image = Resources.exit;
                cancel_BTN.ForeColor = Color.White;
                cancel_BTN.Image = Resources.cancel;
                colorpicker_BTN.Image = Resources.color_dropper;
                automatic_BTN.Image = Resources.wallpaper;
                random_BTN.Image = Resources.dice;
                if (flp_ColorFavorite.Visible)
                {
                    favorite_BTN.Image = Resources.delete;
                }
                else
                {
                    favorite_BTN.Image = Resources.favorite;
                }
                colorWheel_BTN.Image = Resources.color_wheel;
                hex_TextBox.ForeColor = Color.White;
            }
        }

        private Guna2Button CreateColorBTN(Color color, bool border = false)
        {

            Guna2Button ColorButton = new Guna2Button();
            ColorButton.Name = "BTN_" + random.Next();
            ColorButton.Size = new Size(25, 25);
            ColorButton.FillColor = color;
            ColorButton.BorderRadius = 3;
            if (border)
            {
                ColorButton.BorderThickness = 1;
                if (Settings.Default.LightColor)
                {
                    ColorButton.BorderColor = Color.Black;
                }
                else ColorButton.BorderColor = Color.White;
            }

            ColorButton.ContextMenuStrip = contextMenu_ColorBTNs;
            if (ColorButton.ContextMenuStrip.Visible)
            {
                ColorButton.ContextMenuStrip.Items[0].Enabled = false;
            }
            ColorButton.Click += BTN_Color_Click;

            return ColorButton;
        }
        private void CreateFavoriteColor()
        {
            if (File.Exists(Favorite_File))
            {
                flp_ColorFavorite.Controls.Clear();
                foreach (var text in File.ReadAllLines(Favorite_File))
                {
                    try
                    {
                        Color cl = Color.FromArgb(int.Parse(text.Split(',')[0]), int.Parse(text.Split(',')[1]), int.Parse(text.Split(',')[2]));
                        flp_ColorFavorite.Controls.Add(CreateColorBTN(cl, true));
                    }
                    catch (Exception) { }
                }
            }
            else
            {
                File.Create(Favorite_File);
            }
        }
        private void ColorPick_Load(object sender, EventArgs e)
        {
            Refresh_Color(Settings.Default.Theme);
            this.TopMost = Settings.Default.AlwaysOT;
            this.Font = Settings.Default.AppFont;
            hex_TextBox.Focus();

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
                    panel_History_Colors.Controls.Add(CreateColorBTN(Color.FromArgb(int.Parse(Color_History[i].Split(',')[0]), int.Parse(Color_History[i].Split(',')[1]), int.Parse(Color_History[i].Split(',')[2]))));
                }
            }

            CkeckSettings();
            CreateFavoriteColor();
        }
        private void Refresh_Color(Color color)
        {
            if (color == Color.Empty)
            {
                this.BackColor = Color.FromArgb(red_Bar.Value, green_Bar.Value, blue_Bar.Value);
            }
            else
            {
                this.BackColor = color;
                red_Bar.Value = color.R;
                green_Bar.Value = color.G;
                blue_Bar.Value = color.B;
            }
            red_Text.Text = "مقدار رنگ قرمز: " + red_Bar.Value;
            green_Text.Text = "مقدار رنگ سبز: " + green_Bar.Value;
            blue_Text.Text = "مقدار رنگ آبی: " + blue_Bar.Value;
            hex_TextBox.FillColor = this.BackColor;
            hex_TextBox.Text = string.Format("{0:X2}{1:X2}{2:X2}", red_Bar.Value, green_Bar.Value, blue_Bar.Value);
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
            if (red_Bar.Value >= 180 && green_Bar.Value >= 180 && blue_Bar.Value >= 180)
            {
                Settings.Default.LightColor = true;
                CkeckSettings();
            }
            else if (red_Bar.Value == 160 && green_Bar.Value == 113 && blue_Bar.Value == 255)
            {
                red_Bar.ThumbColor = Color.FromArgb(112, 79, 178);
                green_Bar.ThumbColor = Color.FromArgb(112, 79, 178);
                blue_Bar.ThumbColor = Color.FromArgb(112, 79, 178);
            }
            else if (red_Bar.Value == 112 && green_Bar.Value == 79 && blue_Bar.Value == 178)
            {
                red_Bar.ThumbColor = Color.FromArgb(160, 113, 255);
                green_Bar.ThumbColor = Color.FromArgb(160, 113, 255);
                blue_Bar.ThumbColor = Color.FromArgb(160, 113, 255);
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
                if (hex_TextBox.Text.Length == 2)
                {
                    r = Convert.ToInt32(hex_TextBox.Text.Substring(0, 2), 16);
                    g = 0;
                    b = 0;
                }
                else if (hex_TextBox.Text.Length == 3)
                {
                    string c1, c2, c3;
                    c1 = hex_TextBox.Text.Substring(0, 1);
                    c2 = hex_TextBox.Text.Substring(1, 1);
                    c3 = hex_TextBox.Text.Substring(2, 1);
                    r = Convert.ToInt32(c1 + c1, 16);
                    g = Convert.ToInt32(c2 + c2, 16);
                    b = Convert.ToInt32(c3 + c3, 16);

                }
                else if (hex_TextBox.Text.Length == 4)
                {
                    r = Convert.ToInt32(hex_TextBox.Text.Substring(0, 2), 16);
                    g = Convert.ToInt32(hex_TextBox.Text.Substring(2, 2), 16);
                    b = 0;

                }
                else if (hex_TextBox.Text.Length == 6 || hex_TextBox.Text.Length == 8)
                {
                    r = Convert.ToInt32(hex_TextBox.Text.Substring(0, 2), 16);
                    g = Convert.ToInt32(hex_TextBox.Text.Substring(2, 2), 16);
                    b = Convert.ToInt32(hex_TextBox.Text.Substring(4, 2), 16);
                }
                else
                {
                    r = 0;
                    g = 0;
                    b = 0;
                }
                red_Bar.Value = r;
                green_Bar.Value = g;
                blue_Bar.Value = b;
                Refresh_Color(Color.Empty);
                CkeckSettings();
            }
            catch (Exception)
            {
                Alert("ساختار وارد شده صحیح نمیباشد"); hex_TextBox.Select();
            }

        }

        private void Enter_Hex_ChengeColor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { Hex_ChengeColor(hex_TextBox, EventArgs.Empty); }
        }
        /*------------------ Hex Color End ------------------*/
        /*------------------ Option BTNs Start ------------------*/
        /*------ ColorWheel ------*/
        private void colorWheel_BTN_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                Refresh_Color(cd.Color);
            }
        }
        /*------ ColorPicker ------*/
        private void BTN_ColorPicker_Click(object sender, EventArgs e)
        {
            Alert("در دست ساخت!");
        }
        /*------ Automatic with Wallpaper ------*/
        private void Automatic_BTN_Click(object sender, EventArgs e)
        {
            panel_ColorBox.Enabled = false;
            panel_Options.Enabled = false;
            panel_History_Colors.Enabled = false;
            panel_Exit.Enabled = false;
            try
            {
                using (var regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false))
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
                else if (File.Exists(path_wallpaper))
                {
                    using (var image = new Bitmap(path_wallpaper))
                    {
                        var dict = new Dictionary<Color, int>() { };
                        for (int i = 0; i < image.Width; i++)
                        {
                            for (int j = 0; j < image.Height; j++)
                            {
                                Color color = image.GetPixel(i, j);
                                dict.TryGetValue(color, out int count);
                                dict[color] = count++;
                            }
                        }
                        dict = dict.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                        SlectedBackColor = dict.Last().Key;
                        Refresh_Color(SlectedBackColor);
                        dict.Clear();
                        image.Dispose();
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
            panel_Options.Enabled = true;
            panel_History_Colors.Enabled = true;
            panel_Exit.Enabled = true;
        }
        /*------ RandomColor ------*/
        private void random_BTN_Click(object sender, EventArgs e)
        {
            Refresh_Color(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)));
        }
        /*------ FavoriteColor ------*/
        private void favorite_BTN_Click(object sender, EventArgs e)
        {
            if (flp_ColorFavorite.Visible)
            {
                flp_ColorFavorite.Visible = false;
                if (Settings.Default.LightColor)
                {
                    favorite_BTN.Image = Resources.favorite_black;
                }
                else favorite_BTN.Image = Resources.favorite;
            }
            else
            {
                flp_ColorFavorite.Visible = true;
                if (Settings.Default.LightColor)
                {
                    favorite_BTN.Image = Resources.delete_black;
                }
                else favorite_BTN.Image = Resources.delete;
            }
        }
        /*------------------ Option BTNs End ------------------*/
        /*------------------ ContextMenu Start ------------------*/
        private void contextMenu_ColorBTNs_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Guna2Button btn = contextMenu_ColorBTNs.SourceControl as Guna2Button;
            if (File.Exists(Favorite_File))
            {
                foreach (var text in File.ReadAllLines(Favorite_File))
                {
                    try
                    {
                        Color cl = Color.FromArgb(int.Parse(text.Split(',')[0]), int.Parse(text.Split(',')[1]), int.Parse(text.Split(',')[2]));
                        if (btn.FillColor == cl)
                        {
                            contextMenu_ColorBTNs.Items[0].Text = "حذف از مورد علاقه‌ها";
                            contextMenu_ColorBTNs.Items[0].Tag = "DelF";
                            break;
                        }
                        else
                        {
                            contextMenu_ColorBTNs.Items[0].Text = "افزودن به مورد علاقه ها";
                            contextMenu_ColorBTNs.Items[0].Tag = "AddF";
                        }
                    }
                    catch (Exception) { }
                }
            }
        }
        private void tsmi_AddToFavorite_Click(object sender, EventArgs e)
        {
            Guna2Button btn = contextMenu_ColorBTNs.SourceControl as Guna2Button;
            Color btn_color = btn.FillColor;
            string fileText = btn_color.R + "," + btn_color.G + "," + btn_color.B;
            if (contextMenu_ColorBTNs.Items[0].Tag.ToString() == "AddF")
            {
                File.AppendAllText(Favorite_File, "\n" + fileText);
            }
            else
            {
                string[] old_txtColor = File.ReadAllLines(Favorite_File);
                List<string> new_txtColor = new List<string> { };
                for (int i = 0; i < old_txtColor.Length; i++)
                {
                    if (!string.IsNullOrEmpty(old_txtColor[i]))
                    {
                        if (old_txtColor[i] != fileText)
                        {
                            new_txtColor.Add(old_txtColor[i]);
                        }
                    }

                }
                File.WriteAllLines(Favorite_File, new_txtColor);

            }
            CreateFavoriteColor();
        }
        /*------------------ ContextMenu End ------------------*/
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
