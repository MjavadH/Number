
namespace Number
{
    partial class SettingPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.OnTopBTN = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.DarkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ColorCh = new Guna.UI2.WinForms.Guna2Button();
            this.FontBTN = new Guna.UI2.WinForms.Guna2Button();
            this.FontCBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panelReset = new System.Windows.Forms.Panel();
            this.CancelBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Counter_Value = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ShortKeyBTN = new Guna.UI2.WinForms.Guna2Button();
            this.ResetBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Reset_YN_Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Yes_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.No_Reset = new Guna.UI2.WinForms.Guna2Button();
            this.ResetNAni = new Guna.UI2.WinForms.Guna2Transition();
            this.label8 = new System.Windows.Forms.Label();
            this.SoundPlay = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SoundSetting_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.panelSound = new System.Windows.Forms.Panel();
            this.Sound5 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Sound1 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Sound2 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Sound4 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.Sound3 = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ComboBox_DefaultNum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Counter_Value)).BeginInit();
            this.Reset_YN_Panel.SuspendLayout();
            this.panelSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.ResetNAni.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Vazir", 20F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "صفحه تنظیمات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(437, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "همیشه بالا بودن";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Location = new System.Drawing.Point(409, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "پس زمینه پیش فرض";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fontDialog1
            // 
            this.fontDialog1.AllowVerticalFonts = false;
            this.fontDialog1.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontDialog1.MaxSize = 14;
            this.fontDialog1.MinSize = 6;
            this.fontDialog1.ShowApply = true;
            this.fontDialog1.ShowEffects = false;
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResetNAni.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 81);
            this.label4.TabIndex = 8;
            this.label4.Text = "متن نمونه تست فونت\r\n123456789";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OnTopBTN
            // 
            this.OnTopBTN.Animated = true;
            this.OnTopBTN.AutoRoundedCorners = true;
            this.OnTopBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.OnTopBTN.CheckedState.BorderRadius = 12;
            this.OnTopBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.OnTopBTN.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.OnTopBTN.CheckedState.InnerBorderRadius = 8;
            this.OnTopBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.OnTopBTN.CheckedState.Parent = this.OnTopBTN;
            this.ResetNAni.SetDecoration(this.OnTopBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.OnTopBTN.Location = new System.Drawing.Point(378, 55);
            this.OnTopBTN.Name = "OnTopBTN";
            this.OnTopBTN.ShadowDecoration.Parent = this.OnTopBTN;
            this.OnTopBTN.Size = new System.Drawing.Size(57, 26);
            this.OnTopBTN.TabIndex = 10;
            this.OnTopBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OnTopBTN.UncheckedState.BorderRadius = 12;
            this.OnTopBTN.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.OnTopBTN.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.OnTopBTN.UncheckedState.InnerBorderRadius = 8;
            this.OnTopBTN.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.OnTopBTN.UncheckedState.Parent = this.OnTopBTN;
            // 
            // DarkMode
            // 
            this.DarkMode.Animated = true;
            this.DarkMode.AutoRoundedCorners = true;
            this.DarkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.DarkMode.CheckedState.BorderRadius = 12;
            this.DarkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.DarkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DarkMode.CheckedState.InnerBorderRadius = 8;
            this.DarkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkMode.CheckedState.Parent = this.DarkMode;
            this.ResetNAni.SetDecoration(this.DarkMode, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DarkMode.Location = new System.Drawing.Point(346, 105);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.ShadowDecoration.Parent = this.DarkMode;
            this.DarkMode.Size = new System.Drawing.Size(57, 26);
            this.DarkMode.TabIndex = 10;
            this.DarkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkMode.UncheckedState.BorderRadius = 12;
            this.DarkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.DarkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.DarkMode.UncheckedState.InnerBorderRadius = 8;
            this.DarkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.DarkMode.UncheckedState.Parent = this.DarkMode;
            this.DarkMode.CheckedChanged += new System.EventHandler(this.BackgroundMode_CheckedChanged);
            // 
            // ColorCh
            // 
            this.ColorCh.AutoRoundedCorners = true;
            this.ColorCh.BackColor = System.Drawing.Color.Transparent;
            this.ColorCh.BorderColor = System.Drawing.Color.White;
            this.ColorCh.BorderRadius = 19;
            this.ColorCh.BorderThickness = 1;
            this.ColorCh.CheckedState.Parent = this.ColorCh;
            this.ColorCh.CustomImages.Parent = this.ColorCh;
            this.ResetNAni.SetDecoration(this.ColorCh, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ColorCh.FillColor = System.Drawing.Color.Empty;
            this.ColorCh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ColorCh.ForeColor = System.Drawing.Color.White;
            this.ColorCh.HoverState.Parent = this.ColorCh;
            this.ColorCh.Image = global::Number.Properties.Resources.paint_palette;
            this.ColorCh.Location = new System.Drawing.Point(222, 100);
            this.ColorCh.Name = "ColorCh";
            this.ColorCh.ShadowDecoration.Parent = this.ColorCh;
            this.ColorCh.Size = new System.Drawing.Size(118, 41);
            this.ColorCh.TabIndex = 11;
            this.ColorCh.Text = "تنظیم رنگ";
            this.ColorCh.Click += new System.EventHandler(this.ColorCh_Click);
            // 
            // FontBTN
            // 
            this.FontBTN.AutoRoundedCorners = true;
            this.FontBTN.BackColor = System.Drawing.Color.Transparent;
            this.FontBTN.BorderColor = System.Drawing.Color.White;
            this.FontBTN.BorderRadius = 19;
            this.FontBTN.BorderThickness = 1;
            this.FontBTN.CheckedState.Parent = this.FontBTN;
            this.FontBTN.CustomImages.Parent = this.FontBTN;
            this.ResetNAni.SetDecoration(this.FontBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FontBTN.FillColor = System.Drawing.Color.Empty;
            this.FontBTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FontBTN.ForeColor = System.Drawing.Color.White;
            this.FontBTN.HoverState.Parent = this.FontBTN;
            this.FontBTN.Image = global::Number.Properties.Resources.font_style_formatting;
            this.FontBTN.Location = new System.Drawing.Point(12, 205);
            this.FontBTN.Name = "FontBTN";
            this.FontBTN.ShadowDecoration.Parent = this.FontBTN;
            this.FontBTN.Size = new System.Drawing.Size(169, 41);
            this.FontBTN.TabIndex = 11;
            this.FontBTN.Text = "تغییر فونت";
            this.FontBTN.Click += new System.EventHandler(this.FontBTN_Click);
            // 
            // FontCBTN
            // 
            this.FontCBTN.AutoRoundedCorners = true;
            this.FontCBTN.BackColor = System.Drawing.Color.Transparent;
            this.FontCBTN.BorderColor = System.Drawing.Color.White;
            this.FontCBTN.BorderRadius = 19;
            this.FontCBTN.BorderThickness = 1;
            this.FontCBTN.CheckedState.Parent = this.FontCBTN;
            this.FontCBTN.CustomImages.Parent = this.FontCBTN;
            this.ResetNAni.SetDecoration(this.FontCBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FontCBTN.FillColor = System.Drawing.Color.Empty;
            this.FontCBTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FontCBTN.ForeColor = System.Drawing.Color.White;
            this.FontCBTN.HoverState.Parent = this.FontCBTN;
            this.FontCBTN.Image = global::Number.Properties.Resources.clear_formatting;
            this.FontCBTN.Location = new System.Drawing.Point(12, 155);
            this.FontCBTN.Name = "FontCBTN";
            this.FontCBTN.ShadowDecoration.Parent = this.FontCBTN;
            this.FontCBTN.Size = new System.Drawing.Size(169, 41);
            this.FontCBTN.TabIndex = 11;
            this.FontCBTN.Text = "حذف تغییرات فونت";
            this.FontCBTN.Click += new System.EventHandler(this.FontCBTN_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(425, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "شمارش خودکار هر";
            // 
            // panelReset
            // 
            this.panelReset.Controls.Add(this.CancelBTN);
            this.panelReset.Controls.Add(this.Save_BTN);
            this.ResetNAni.SetDecoration(this.panelReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReset.Location = new System.Drawing.Point(0, 368);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(564, 76);
            this.panelReset.TabIndex = 13;
            // 
            // CancelBTN
            // 
            this.CancelBTN.BackColor = System.Drawing.Color.Transparent;
            this.CancelBTN.CheckedState.Parent = this.CancelBTN;
            this.CancelBTN.CustomImages.Parent = this.CancelBTN;
            this.ResetNAni.SetDecoration(this.CancelBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.CancelBTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelBTN.FillColor = System.Drawing.Color.Empty;
            this.CancelBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.CancelBTN.HoverState.Parent = this.CancelBTN;
            this.CancelBTN.Image = global::Number.Properties.Resources.cancel;
            this.CancelBTN.Location = new System.Drawing.Point(-1, 0);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.ShadowDecoration.Parent = this.CancelBTN;
            this.CancelBTN.Size = new System.Drawing.Size(287, 76);
            this.CancelBTN.TabIndex = 8;
            this.CancelBTN.Text = "انصراف";
            this.CancelBTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.CancelBTN.UseTransparentBackground = true;
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Save_BTN.CheckedState.Parent = this.Save_BTN;
            this.Save_BTN.CustomImages.Parent = this.Save_BTN;
            this.ResetNAni.SetDecoration(this.Save_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Save_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Save_BTN.FillColor = System.Drawing.Color.Empty;
            this.Save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Save_BTN.ForeColor = System.Drawing.Color.White;
            this.Save_BTN.HoverState.Parent = this.Save_BTN;
            this.Save_BTN.Image = global::Number.Properties.Resources.save;
            this.Save_BTN.Location = new System.Drawing.Point(286, 0);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.ShadowDecoration.Parent = this.Save_BTN;
            this.Save_BTN.Size = new System.Drawing.Size(278, 76);
            this.Save_BTN.TabIndex = 7;
            this.Save_BTN.Text = "ذخیره تغییرات";
            this.Save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Save_BTN.UseTransparentBackground = true;
            this.Save_BTN.Click += new System.EventHandler(this.Save_Click);
            // 
            // Counter_Value
            // 
            this.Counter_Value.AutoRoundedCorners = true;
            this.Counter_Value.BackColor = System.Drawing.Color.Transparent;
            this.Counter_Value.BorderRadius = 14;
            this.Counter_Value.BorderThickness = 0;
            this.Counter_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ResetNAni.SetDecoration(this.Counter_Value, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Counter_Value.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Counter_Value.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Counter_Value.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Counter_Value.DisabledState.Parent = this.Counter_Value;
            this.Counter_Value.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.Counter_Value.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Counter_Value.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Counter_Value.FocusedState.Parent = this.Counter_Value;
            this.Counter_Value.Font = new System.Drawing.Font("Vazir", 12F);
            this.Counter_Value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Counter_Value.Location = new System.Drawing.Point(343, 205);
            this.Counter_Value.Margin = new System.Windows.Forms.Padding(0);
            this.Counter_Value.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.Counter_Value.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Counter_Value.Name = "Counter_Value";
            this.Counter_Value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Counter_Value.ShadowDecoration.Parent = this.Counter_Value;
            this.Counter_Value.Size = new System.Drawing.Size(79, 30);
            this.Counter_Value.TabIndex = 14;
            this.Counter_Value.TextOffset = new System.Drawing.Point(2, 1);
            this.Counter_Value.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(226, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "ثانیه انجام شود.";
            // 
            // ShortKeyBTN
            // 
            this.ShortKeyBTN.AutoRoundedCorners = true;
            this.ShortKeyBTN.BackColor = System.Drawing.Color.Transparent;
            this.ShortKeyBTN.BorderColor = System.Drawing.Color.White;
            this.ShortKeyBTN.BorderRadius = 19;
            this.ShortKeyBTN.BorderThickness = 1;
            this.ShortKeyBTN.CheckedState.Parent = this.ShortKeyBTN;
            this.ShortKeyBTN.CustomImages.Parent = this.ShortKeyBTN;
            this.ResetNAni.SetDecoration(this.ShortKeyBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ShortKeyBTN.FillColor = System.Drawing.Color.Empty;
            this.ShortKeyBTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ShortKeyBTN.ForeColor = System.Drawing.Color.White;
            this.ShortKeyBTN.HoverState.Parent = this.ShortKeyBTN;
            this.ShortKeyBTN.Image = global::Number.Properties.Resources.keyboard;
            this.ShortKeyBTN.Location = new System.Drawing.Point(12, 55);
            this.ShortKeyBTN.Name = "ShortKeyBTN";
            this.ShortKeyBTN.ShadowDecoration.Parent = this.ShortKeyBTN;
            this.ShortKeyBTN.Size = new System.Drawing.Size(169, 41);
            this.ShortKeyBTN.TabIndex = 16;
            this.ShortKeyBTN.Text = "دکمه های میانبر";
            this.ShortKeyBTN.Click += new System.EventHandler(this.ShortKeyBTN_Click);
            // 
            // ResetBTN
            // 
            this.ResetBTN.AutoRoundedCorners = true;
            this.ResetBTN.BackColor = System.Drawing.Color.Transparent;
            this.ResetBTN.BorderColor = System.Drawing.Color.Red;
            this.ResetBTN.BorderRadius = 19;
            this.ResetBTN.BorderThickness = 1;
            this.ResetBTN.CheckedState.Parent = this.ResetBTN;
            this.ResetBTN.CustomImages.Parent = this.ResetBTN;
            this.ResetNAni.SetDecoration(this.ResetBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ResetBTN.FillColor = System.Drawing.Color.Empty;
            this.ResetBTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ResetBTN.ForeColor = System.Drawing.Color.White;
            this.ResetBTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ResetBTN.HoverState.Parent = this.ResetBTN;
            this.ResetBTN.Image = global::Number.Properties.Resources.reset;
            this.ResetBTN.Location = new System.Drawing.Point(12, 105);
            this.ResetBTN.Name = "ResetBTN";
            this.ResetBTN.ShadowDecoration.Parent = this.ResetBTN;
            this.ResetBTN.Size = new System.Drawing.Size(169, 41);
            this.ResetBTN.TabIndex = 16;
            this.ResetBTN.Text = "بازنشانی شمارنده ها";
            this.ResetBTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // Reset_YN_Panel
            // 
            this.Reset_YN_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Reset_YN_Panel.Controls.Add(this.label5);
            this.Reset_YN_Panel.Controls.Add(this.Yes_Reset);
            this.Reset_YN_Panel.Controls.Add(this.No_Reset);
            this.ResetNAni.SetDecoration(this.Reset_YN_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Reset_YN_Panel.Location = new System.Drawing.Point(1, 287);
            this.Reset_YN_Panel.Name = "Reset_YN_Panel";
            this.Reset_YN_Panel.Size = new System.Drawing.Size(563, 81);
            this.Reset_YN_Panel.TabIndex = 17;
            this.Reset_YN_Panel.Visible = false;
            // 
            // label5
            // 
            this.ResetNAni.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(277, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 79);
            this.label5.TabIndex = 0;
            this.label5.Text = "آیا از کار خود اطمینان دارید؟";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Yes_Reset
            // 
            this.Yes_Reset.AutoRoundedCorners = true;
            this.Yes_Reset.BackColor = System.Drawing.Color.Transparent;
            this.Yes_Reset.BorderColor = System.Drawing.Color.Red;
            this.Yes_Reset.BorderRadius = 19;
            this.Yes_Reset.BorderThickness = 1;
            this.Yes_Reset.CheckedState.Parent = this.Yes_Reset;
            this.Yes_Reset.CustomImages.Parent = this.Yes_Reset;
            this.ResetNAni.SetDecoration(this.Yes_Reset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Yes_Reset.FillColor = System.Drawing.Color.Empty;
            this.Yes_Reset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Yes_Reset.ForeColor = System.Drawing.Color.White;
            this.Yes_Reset.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Yes_Reset.HoverState.Parent = this.Yes_Reset;
            this.Yes_Reset.Image = global::Number.Properties.Resources.checkmark;
            this.Yes_Reset.Location = new System.Drawing.Point(6, 22);
            this.Yes_Reset.Name = "Yes_Reset";
            this.Yes_Reset.ShadowDecoration.Parent = this.Yes_Reset;
            this.Yes_Reset.Size = new System.Drawing.Size(114, 41);
            this.Yes_Reset.TabIndex = 16;
            this.Yes_Reset.Text = "بله";
            this.Yes_Reset.Click += new System.EventHandler(this.Yes_Reset_Click);
            // 
            // No_Reset
            // 
            this.No_Reset.AutoRoundedCorners = true;
            this.No_Reset.BackColor = System.Drawing.Color.Transparent;
            this.No_Reset.BorderColor = System.Drawing.Color.White;
            this.No_Reset.BorderRadius = 19;
            this.No_Reset.BorderThickness = 1;
            this.No_Reset.CheckedState.Parent = this.No_Reset;
            this.No_Reset.CustomImages.Parent = this.No_Reset;
            this.ResetNAni.SetDecoration(this.No_Reset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.No_Reset.FillColor = System.Drawing.Color.Empty;
            this.No_Reset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.No_Reset.ForeColor = System.Drawing.Color.White;
            this.No_Reset.HoverState.Parent = this.No_Reset;
            this.No_Reset.Image = global::Number.Properties.Resources.delete;
            this.No_Reset.Location = new System.Drawing.Point(153, 22);
            this.No_Reset.Name = "No_Reset";
            this.No_Reset.ShadowDecoration.Parent = this.No_Reset;
            this.No_Reset.Size = new System.Drawing.Size(118, 41);
            this.No_Reset.TabIndex = 11;
            this.No_Reset.Text = "خیر";
            this.No_Reset.Click += new System.EventHandler(this.No_Reset_Click);
            // 
            // ResetNAni
            // 
            this.ResetNAni.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.ResetNAni.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 1F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.ResetNAni.DefaultAnimation = animation1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(401, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "پخش جلوه های صوتی";
            // 
            // SoundPlay
            // 
            this.SoundPlay.Animated = true;
            this.SoundPlay.AutoRoundedCorners = true;
            this.SoundPlay.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.SoundPlay.CheckedState.BorderRadius = 12;
            this.SoundPlay.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.SoundPlay.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SoundPlay.CheckedState.InnerBorderRadius = 8;
            this.SoundPlay.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SoundPlay.CheckedState.Parent = this.SoundPlay;
            this.ResetNAni.SetDecoration(this.SoundPlay, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SoundPlay.Location = new System.Drawing.Point(344, 155);
            this.SoundPlay.Name = "SoundPlay";
            this.SoundPlay.ShadowDecoration.Parent = this.SoundPlay;
            this.SoundPlay.Size = new System.Drawing.Size(57, 26);
            this.SoundPlay.TabIndex = 10;
            this.SoundPlay.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SoundPlay.UncheckedState.BorderRadius = 12;
            this.SoundPlay.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SoundPlay.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SoundPlay.UncheckedState.InnerBorderRadius = 8;
            this.SoundPlay.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SoundPlay.UncheckedState.Parent = this.SoundPlay;
            this.SoundPlay.CheckedChanged += new System.EventHandler(this.SoundPlay_CheckedChanged);
            // 
            // SoundSetting_BTN
            // 
            this.SoundSetting_BTN.AutoRoundedCorners = true;
            this.SoundSetting_BTN.BackColor = System.Drawing.Color.Transparent;
            this.SoundSetting_BTN.BorderColor = System.Drawing.Color.White;
            this.SoundSetting_BTN.BorderRadius = 19;
            this.SoundSetting_BTN.BorderThickness = 1;
            this.SoundSetting_BTN.CheckedState.Parent = this.SoundSetting_BTN;
            this.SoundSetting_BTN.CustomImages.Parent = this.SoundSetting_BTN;
            this.ResetNAni.SetDecoration(this.SoundSetting_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SoundSetting_BTN.FillColor = System.Drawing.Color.Empty;
            this.SoundSetting_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SoundSetting_BTN.ForeColor = System.Drawing.Color.White;
            this.SoundSetting_BTN.HoverState.Parent = this.SoundSetting_BTN;
            this.SoundSetting_BTN.Image = global::Number.Properties.Resources.music;
            this.SoundSetting_BTN.Location = new System.Drawing.Point(221, 150);
            this.SoundSetting_BTN.Name = "SoundSetting_BTN";
            this.SoundSetting_BTN.ShadowDecoration.Parent = this.SoundSetting_BTN;
            this.SoundSetting_BTN.Size = new System.Drawing.Size(118, 41);
            this.SoundSetting_BTN.TabIndex = 11;
            this.SoundSetting_BTN.Text = "انتخاب صدا";
            this.SoundSetting_BTN.Visible = false;
            this.SoundSetting_BTN.Click += new System.EventHandler(this.SoundSetting_BTN_Click);
            // 
            // panelSound
            // 
            this.panelSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSound.Controls.Add(this.Sound5);
            this.panelSound.Controls.Add(this.Sound1);
            this.panelSound.Controls.Add(this.Sound2);
            this.panelSound.Controls.Add(this.Sound4);
            this.panelSound.Controls.Add(this.Sound3);
            this.panelSound.Controls.Add(this.label9);
            this.ResetNAni.SetDecoration(this.panelSound, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelSound.Location = new System.Drawing.Point(1, 286);
            this.panelSound.Name = "panelSound";
            this.panelSound.Size = new System.Drawing.Size(563, 81);
            this.panelSound.TabIndex = 18;
            this.panelSound.Visible = false;
            // 
            // Sound5
            // 
            this.Sound5.Animated = true;
            this.Sound5.AutoSize = true;
            this.Sound5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sound5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound5.CheckedState.BorderThickness = 0;
            this.Sound5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound5.CheckedState.InnerOffset = -4;
            this.ResetNAni.SetDecoration(this.Sound5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound5.Location = new System.Drawing.Point(40, 43);
            this.Sound5.Name = "Sound5";
            this.Sound5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sound5.Size = new System.Drawing.Size(80, 30);
            this.Sound5.TabIndex = 4;
            this.Sound5.Text = "صدای 5";
            this.Sound5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound5.UncheckedState.BorderThickness = 2;
            this.Sound5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Sound5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Sound5.Click += new System.EventHandler(this.Sounds);
            // 
            // Sound1
            // 
            this.Sound1.Animated = true;
            this.Sound1.AutoSize = true;
            this.Sound1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sound1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound1.CheckedState.BorderThickness = 0;
            this.Sound1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound1.CheckedState.InnerOffset = -4;
            this.ResetNAni.SetDecoration(this.Sound1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound1.Location = new System.Drawing.Point(440, 43);
            this.Sound1.Name = "Sound1";
            this.Sound1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sound1.Size = new System.Drawing.Size(80, 30);
            this.Sound1.TabIndex = 3;
            this.Sound1.Text = "صدای 1";
            this.Sound1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound1.UncheckedState.BorderThickness = 2;
            this.Sound1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Sound1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Sound1.Click += new System.EventHandler(this.Sounds);
            // 
            // Sound2
            // 
            this.Sound2.Animated = true;
            this.Sound2.AutoSize = true;
            this.Sound2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sound2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound2.CheckedState.BorderThickness = 0;
            this.Sound2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound2.CheckedState.InnerOffset = -4;
            this.ResetNAni.SetDecoration(this.Sound2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound2.Location = new System.Drawing.Point(340, 43);
            this.Sound2.Name = "Sound2";
            this.Sound2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sound2.Size = new System.Drawing.Size(80, 30);
            this.Sound2.TabIndex = 3;
            this.Sound2.Text = "صدای 2";
            this.Sound2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound2.UncheckedState.BorderThickness = 2;
            this.Sound2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Sound2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Sound2.Click += new System.EventHandler(this.Sounds);
            // 
            // Sound4
            // 
            this.Sound4.Animated = true;
            this.Sound4.AutoSize = true;
            this.Sound4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sound4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound4.CheckedState.BorderThickness = 0;
            this.Sound4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound4.CheckedState.InnerOffset = -4;
            this.ResetNAni.SetDecoration(this.Sound4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound4.Location = new System.Drawing.Point(140, 43);
            this.Sound4.Name = "Sound4";
            this.Sound4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sound4.Size = new System.Drawing.Size(80, 30);
            this.Sound4.TabIndex = 3;
            this.Sound4.Text = "صدای 4";
            this.Sound4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound4.UncheckedState.BorderThickness = 2;
            this.Sound4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Sound4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Sound4.Click += new System.EventHandler(this.Sounds);
            // 
            // Sound3
            // 
            this.Sound3.Animated = true;
            this.Sound3.AutoSize = true;
            this.Sound3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sound3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound3.CheckedState.BorderThickness = 0;
            this.Sound3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sound3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.Sound3.CheckedState.InnerOffset = -4;
            this.ResetNAni.SetDecoration(this.Sound3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Sound3.Location = new System.Drawing.Point(240, 43);
            this.Sound3.Name = "Sound3";
            this.Sound3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Sound3.Size = new System.Drawing.Size(80, 30);
            this.Sound3.TabIndex = 3;
            this.Sound3.Text = "صدای 3";
            this.Sound3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Sound3.UncheckedState.BorderThickness = 2;
            this.Sound3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.Sound3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.Sound3.Click += new System.EventHandler(this.Sounds);
            // 
            // label9
            // 
            this.ResetNAni.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(561, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "انتخاب جلوه های صوتی";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.ResetNAni.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Location = new System.Drawing.Point(430, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "شمارنده پیشفرض";
            // 
            // ComboBox_DefaultNum
            // 
            this.ComboBox_DefaultNum.Animated = true;
            this.ComboBox_DefaultNum.AutoRoundedCorners = true;
            this.ComboBox_DefaultNum.BackColor = System.Drawing.Color.Transparent;
            this.ComboBox_DefaultNum.BorderRadius = 17;
            this.ResetNAni.SetDecoration(this.ComboBox_DefaultNum, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ComboBox_DefaultNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboBox_DefaultNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_DefaultNum.FocusedColor = System.Drawing.Color.Empty;
            this.ComboBox_DefaultNum.FocusedState.Parent = this.ComboBox_DefaultNum;
            this.ComboBox_DefaultNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox_DefaultNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboBox_DefaultNum.FormattingEnabled = true;
            this.ComboBox_DefaultNum.HoverState.Parent = this.ComboBox_DefaultNum;
            this.ComboBox_DefaultNum.ItemHeight = 30;
            this.ComboBox_DefaultNum.ItemsAppearance.Parent = this.ComboBox_DefaultNum;
            this.ComboBox_DefaultNum.Location = new System.Drawing.Point(286, 248);
            this.ComboBox_DefaultNum.Name = "ComboBox_DefaultNum";
            this.ComboBox_DefaultNum.ShadowDecoration.Parent = this.ComboBox_DefaultNum;
            this.ComboBox_DefaultNum.Size = new System.Drawing.Size(140, 36);
            this.ComboBox_DefaultNum.TabIndex = 19;
            // 
            // SettingPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(565, 444);
            this.Controls.Add(this.ComboBox_DefaultNum);
            this.Controls.Add(this.panelSound);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FontCBTN);
            this.Controls.Add(this.FontBTN);
            this.Controls.Add(this.ResetBTN);
            this.Controls.Add(this.ShortKeyBTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Counter_Value);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SoundSetting_BTN);
            this.Controls.Add(this.ColorCh);
            this.Controls.Add(this.SoundPlay);
            this.Controls.Add(this.DarkMode);
            this.Controls.Add(this.OnTopBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Reset_YN_Panel);
            this.ResetNAni.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SettingPage";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "تنظیمات";
            this.Load += new System.EventHandler(this.SettingPage_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            this.panelReset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Counter_Value)).EndInit();
            this.Reset_YN_Panel.ResumeLayout(false);
            this.panelSound.ResumeLayout(false);
            this.panelSound.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ToggleSwitch OnTopBTN;
        private Guna.UI2.WinForms.Guna2ToggleSwitch DarkMode;
        private Guna.UI2.WinForms.Guna2Button FontCBTN;
        private Guna.UI2.WinForms.Guna2Button FontBTN;
        private Guna.UI2.WinForms.Guna2Button ColorCh;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2NumericUpDown Counter_Value;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button ShortKeyBTN;
        private Guna.UI2.WinForms.Guna2Button Save_BTN;
        private Guna.UI2.WinForms.Guna2Button CancelBTN;
        private Guna.UI2.WinForms.Guna2Button ResetBTN;
        private Guna.UI2.WinForms.Guna2Transition ResetNAni;
        private System.Windows.Forms.Panel Reset_YN_Panel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button Yes_Reset;
        private Guna.UI2.WinForms.Guna2Button No_Reset;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SoundPlay;
        private Guna.UI2.WinForms.Guna2Button SoundSetting_BTN;
        private System.Windows.Forms.Panel panelSound;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2RadioButton Sound3;
        private Guna.UI2.WinForms.Guna2RadioButton Sound1;
        private Guna.UI2.WinForms.Guna2RadioButton Sound2;
        private Guna.UI2.WinForms.Guna2RadioButton Sound4;
        private Guna.UI2.WinForms.Guna2RadioButton Sound5;
        private Guna.UI2.WinForms.Guna2ComboBox ComboBox_DefaultNum;
        private System.Windows.Forms.Label label10;
    }
}