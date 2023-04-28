
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
            this.onTop_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.theme_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.colorPicker_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.font_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.fontClear_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.borderRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.panelReset = new System.Windows.Forms.Panel();
            this.cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Counter_Value = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.shortKey_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.reset_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.reset_YN_Panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.yesReset_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.noReset_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.resetPanel_Animation = new Guna.UI2.WinForms.Guna2Transition();
            this.label8 = new System.Windows.Forms.Label();
            this.soundPlay_Toggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.soundSetting_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.panelSound = new System.Windows.Forms.Panel();
            this.sound5_RBTN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.sound1_RBTN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.sound2_RBTN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.sound4_RBTN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.sound3_RBTN = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.defaultNum_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelReset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Counter_Value)).BeginInit();
            this.reset_YN_Panel.SuspendLayout();
            this.panelSound.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.resetPanel_Animation.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.resetPanel_Animation.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Location = new System.Drawing.Point(437, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "همیشه بالا بودن";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.resetPanel_Animation.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.resetPanel_Animation.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(564, 81);
            this.label4.TabIndex = 8;
            this.label4.Text = "متن نمونه تست فونت\r\n123456789";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onTop_Toggle
            // 
            this.onTop_Toggle.Animated = true;
            this.onTop_Toggle.AutoRoundedCorners = true;
            this.onTop_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.onTop_Toggle.CheckedState.BorderRadius = 12;
            this.onTop_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.onTop_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.onTop_Toggle.CheckedState.InnerBorderRadius = 8;
            this.onTop_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.onTop_Toggle.CheckedState.Parent = this.onTop_Toggle;
            this.resetPanel_Animation.SetDecoration(this.onTop_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.onTop_Toggle.Location = new System.Drawing.Point(378, 55);
            this.onTop_Toggle.Name = "onTop_Toggle";
            this.onTop_Toggle.ShadowDecoration.Parent = this.onTop_Toggle;
            this.onTop_Toggle.Size = new System.Drawing.Size(57, 26);
            this.onTop_Toggle.TabIndex = 10;
            this.onTop_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.onTop_Toggle.UncheckedState.BorderRadius = 12;
            this.onTop_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.onTop_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.onTop_Toggle.UncheckedState.InnerBorderRadius = 8;
            this.onTop_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.onTop_Toggle.UncheckedState.Parent = this.onTop_Toggle;
            // 
            // theme_Toggle
            // 
            this.theme_Toggle.Animated = true;
            this.theme_Toggle.AutoRoundedCorners = true;
            this.theme_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.theme_Toggle.CheckedState.BorderRadius = 12;
            this.theme_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.theme_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.theme_Toggle.CheckedState.InnerBorderRadius = 8;
            this.theme_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.theme_Toggle.CheckedState.Parent = this.theme_Toggle;
            this.resetPanel_Animation.SetDecoration(this.theme_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.theme_Toggle.Location = new System.Drawing.Point(346, 105);
            this.theme_Toggle.Name = "theme_Toggle";
            this.theme_Toggle.ShadowDecoration.Parent = this.theme_Toggle;
            this.theme_Toggle.Size = new System.Drawing.Size(57, 26);
            this.theme_Toggle.TabIndex = 10;
            this.theme_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.theme_Toggle.UncheckedState.BorderRadius = 12;
            this.theme_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.theme_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.theme_Toggle.UncheckedState.InnerBorderRadius = 8;
            this.theme_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.theme_Toggle.UncheckedState.Parent = this.theme_Toggle;
            this.theme_Toggle.CheckedChanged += new System.EventHandler(this.BackgroundMode_CheckedChanged);
            // 
            // colorPicker_BTN
            // 
            this.colorPicker_BTN.AutoRoundedCorners = true;
            this.colorPicker_BTN.BackColor = System.Drawing.Color.Transparent;
            this.colorPicker_BTN.BorderColor = System.Drawing.Color.White;
            this.colorPicker_BTN.BorderRadius = 19;
            this.colorPicker_BTN.BorderThickness = 1;
            this.colorPicker_BTN.CheckedState.Parent = this.colorPicker_BTN;
            this.colorPicker_BTN.CustomImages.Parent = this.colorPicker_BTN;
            this.resetPanel_Animation.SetDecoration(this.colorPicker_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.colorPicker_BTN.FillColor = System.Drawing.Color.Empty;
            this.colorPicker_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.colorPicker_BTN.ForeColor = System.Drawing.Color.White;
            this.colorPicker_BTN.HoverState.Parent = this.colorPicker_BTN;
            this.colorPicker_BTN.Image = global::Number.Properties.Resources.paint_palette;
            this.colorPicker_BTN.Location = new System.Drawing.Point(222, 100);
            this.colorPicker_BTN.Name = "colorPicker_BTN";
            this.colorPicker_BTN.ShadowDecoration.Parent = this.colorPicker_BTN;
            this.colorPicker_BTN.Size = new System.Drawing.Size(118, 41);
            this.colorPicker_BTN.TabIndex = 11;
            this.colorPicker_BTN.Text = "تنظیم رنگ";
            this.colorPicker_BTN.Click += new System.EventHandler(this.ColorCh_Click);
            // 
            // font_BTN
            // 
            this.font_BTN.AutoRoundedCorners = true;
            this.font_BTN.BackColor = System.Drawing.Color.Transparent;
            this.font_BTN.BorderColor = System.Drawing.Color.White;
            this.font_BTN.BorderRadius = 19;
            this.font_BTN.BorderThickness = 1;
            this.font_BTN.CheckedState.Parent = this.font_BTN;
            this.font_BTN.CustomImages.Parent = this.font_BTN;
            this.resetPanel_Animation.SetDecoration(this.font_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.font_BTN.FillColor = System.Drawing.Color.Empty;
            this.font_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.font_BTN.ForeColor = System.Drawing.Color.White;
            this.font_BTN.HoverState.Parent = this.font_BTN;
            this.font_BTN.Image = global::Number.Properties.Resources.font_style_formatting;
            this.font_BTN.Location = new System.Drawing.Point(12, 205);
            this.font_BTN.Name = "font_BTN";
            this.font_BTN.ShadowDecoration.Parent = this.font_BTN;
            this.font_BTN.Size = new System.Drawing.Size(169, 41);
            this.font_BTN.TabIndex = 11;
            this.font_BTN.Text = "تغییر فونت";
            this.font_BTN.Click += new System.EventHandler(this.FontBTN_Click);
            // 
            // fontClear_BTN
            // 
            this.fontClear_BTN.AutoRoundedCorners = true;
            this.fontClear_BTN.BackColor = System.Drawing.Color.Transparent;
            this.fontClear_BTN.BorderColor = System.Drawing.Color.White;
            this.fontClear_BTN.BorderRadius = 19;
            this.fontClear_BTN.BorderThickness = 1;
            this.fontClear_BTN.CheckedState.Parent = this.fontClear_BTN;
            this.fontClear_BTN.CustomImages.Parent = this.fontClear_BTN;
            this.resetPanel_Animation.SetDecoration(this.fontClear_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.fontClear_BTN.FillColor = System.Drawing.Color.Empty;
            this.fontClear_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fontClear_BTN.ForeColor = System.Drawing.Color.White;
            this.fontClear_BTN.HoverState.Parent = this.fontClear_BTN;
            this.fontClear_BTN.Image = global::Number.Properties.Resources.clear_formatting;
            this.fontClear_BTN.Location = new System.Drawing.Point(12, 155);
            this.fontClear_BTN.Name = "fontClear_BTN";
            this.fontClear_BTN.ShadowDecoration.Parent = this.fontClear_BTN;
            this.fontClear_BTN.Size = new System.Drawing.Size(169, 41);
            this.fontClear_BTN.TabIndex = 11;
            this.fontClear_BTN.Text = "حذف تغییرات فونت";
            this.fontClear_BTN.Click += new System.EventHandler(this.FontCBTN_Click);
            // 
            // borderRadius
            // 
            this.borderRadius.BorderRadius = 12;
            this.borderRadius.TargetControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.resetPanel_Animation.SetDecoration(this.label6, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label6.Location = new System.Drawing.Point(425, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "شمارش خودکار هر";
            // 
            // panelReset
            // 
            this.panelReset.Controls.Add(this.cancel_BTN);
            this.panelReset.Controls.Add(this.save_BTN);
            this.resetPanel_Animation.SetDecoration(this.panelReset, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelReset.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelReset.Location = new System.Drawing.Point(0, 368);
            this.panelReset.Name = "panelReset";
            this.panelReset.Size = new System.Drawing.Size(564, 76);
            this.panelReset.TabIndex = 13;
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.BackColor = System.Drawing.Color.Transparent;
            this.cancel_BTN.CheckedState.Parent = this.cancel_BTN;
            this.cancel_BTN.CustomImages.Parent = this.cancel_BTN;
            this.resetPanel_Animation.SetDecoration(this.cancel_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.cancel_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_BTN.FillColor = System.Drawing.Color.Empty;
            this.cancel_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.cancel_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.cancel_BTN.HoverState.Parent = this.cancel_BTN;
            this.cancel_BTN.Image = global::Number.Properties.Resources.cancel;
            this.cancel_BTN.Location = new System.Drawing.Point(-1, 0);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.ShadowDecoration.Parent = this.cancel_BTN;
            this.cancel_BTN.Size = new System.Drawing.Size(287, 76);
            this.cancel_BTN.TabIndex = 8;
            this.cancel_BTN.Text = "انصراف";
            this.cancel_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.cancel_BTN.UseTransparentBackground = true;
            this.cancel_BTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // save_BTN
            // 
            this.save_BTN.BackColor = System.Drawing.Color.Transparent;
            this.save_BTN.CheckedState.Parent = this.save_BTN;
            this.save_BTN.CustomImages.Parent = this.save_BTN;
            this.resetPanel_Animation.SetDecoration(this.save_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.save_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_BTN.FillColor = System.Drawing.Color.Empty;
            this.save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.save_BTN.ForeColor = System.Drawing.Color.White;
            this.save_BTN.HoverState.Parent = this.save_BTN;
            this.save_BTN.Image = global::Number.Properties.Resources.save;
            this.save_BTN.Location = new System.Drawing.Point(286, 0);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.ShadowDecoration.Parent = this.save_BTN;
            this.save_BTN.Size = new System.Drawing.Size(278, 76);
            this.save_BTN.TabIndex = 7;
            this.save_BTN.Text = "ذخیره تغییرات";
            this.save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.save_BTN.UseTransparentBackground = true;
            this.save_BTN.Click += new System.EventHandler(this.Save_Click);
            // 
            // Counter_Value
            // 
            this.Counter_Value.AutoRoundedCorners = true;
            this.Counter_Value.BackColor = System.Drawing.Color.Transparent;
            this.Counter_Value.BorderRadius = 14;
            this.Counter_Value.BorderThickness = 0;
            this.Counter_Value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resetPanel_Animation.SetDecoration(this.Counter_Value, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.resetPanel_Animation.SetDecoration(this.label7, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label7.Location = new System.Drawing.Point(226, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "ثانیه انجام شود.";
            // 
            // shortKey_BTN
            // 
            this.shortKey_BTN.AutoRoundedCorners = true;
            this.shortKey_BTN.BackColor = System.Drawing.Color.Transparent;
            this.shortKey_BTN.BorderColor = System.Drawing.Color.White;
            this.shortKey_BTN.BorderRadius = 19;
            this.shortKey_BTN.BorderThickness = 1;
            this.shortKey_BTN.CheckedState.Parent = this.shortKey_BTN;
            this.shortKey_BTN.CustomImages.Parent = this.shortKey_BTN;
            this.resetPanel_Animation.SetDecoration(this.shortKey_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.shortKey_BTN.FillColor = System.Drawing.Color.Empty;
            this.shortKey_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.shortKey_BTN.ForeColor = System.Drawing.Color.White;
            this.shortKey_BTN.HoverState.Parent = this.shortKey_BTN;
            this.shortKey_BTN.Image = global::Number.Properties.Resources.keyboard;
            this.shortKey_BTN.Location = new System.Drawing.Point(12, 55);
            this.shortKey_BTN.Name = "shortKey_BTN";
            this.shortKey_BTN.ShadowDecoration.Parent = this.shortKey_BTN;
            this.shortKey_BTN.Size = new System.Drawing.Size(169, 41);
            this.shortKey_BTN.TabIndex = 16;
            this.shortKey_BTN.Text = "دکمه های میانبر";
            this.shortKey_BTN.Click += new System.EventHandler(this.ShortKeyBTN_Click);
            // 
            // reset_BTN
            // 
            this.reset_BTN.AutoRoundedCorners = true;
            this.reset_BTN.BackColor = System.Drawing.Color.Transparent;
            this.reset_BTN.BorderColor = System.Drawing.Color.Red;
            this.reset_BTN.BorderRadius = 19;
            this.reset_BTN.BorderThickness = 1;
            this.reset_BTN.CheckedState.Parent = this.reset_BTN;
            this.reset_BTN.CustomImages.Parent = this.reset_BTN;
            this.resetPanel_Animation.SetDecoration(this.reset_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.reset_BTN.FillColor = System.Drawing.Color.Empty;
            this.reset_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.reset_BTN.ForeColor = System.Drawing.Color.White;
            this.reset_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.reset_BTN.HoverState.Parent = this.reset_BTN;
            this.reset_BTN.Image = global::Number.Properties.Resources.reset;
            this.reset_BTN.Location = new System.Drawing.Point(12, 105);
            this.reset_BTN.Name = "reset_BTN";
            this.reset_BTN.ShadowDecoration.Parent = this.reset_BTN;
            this.reset_BTN.Size = new System.Drawing.Size(169, 41);
            this.reset_BTN.TabIndex = 16;
            this.reset_BTN.Text = "بازنشانی شمارنده ها";
            this.reset_BTN.Click += new System.EventHandler(this.ResetBTN_Click);
            // 
            // reset_YN_Panel
            // 
            this.reset_YN_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reset_YN_Panel.Controls.Add(this.label5);
            this.reset_YN_Panel.Controls.Add(this.yesReset_BTN);
            this.reset_YN_Panel.Controls.Add(this.noReset_BTN);
            this.resetPanel_Animation.SetDecoration(this.reset_YN_Panel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.reset_YN_Panel.Location = new System.Drawing.Point(1, 287);
            this.reset_YN_Panel.Name = "reset_YN_Panel";
            this.reset_YN_Panel.Size = new System.Drawing.Size(563, 81);
            this.reset_YN_Panel.TabIndex = 17;
            this.reset_YN_Panel.Visible = false;
            // 
            // label5
            // 
            this.resetPanel_Animation.SetDecoration(this.label5, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(277, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 79);
            this.label5.TabIndex = 0;
            this.label5.Text = "آیا از کار خود اطمینان دارید؟";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesReset_BTN
            // 
            this.yesReset_BTN.AutoRoundedCorners = true;
            this.yesReset_BTN.BackColor = System.Drawing.Color.Transparent;
            this.yesReset_BTN.BorderColor = System.Drawing.Color.Red;
            this.yesReset_BTN.BorderRadius = 19;
            this.yesReset_BTN.BorderThickness = 1;
            this.yesReset_BTN.CheckedState.Parent = this.yesReset_BTN;
            this.yesReset_BTN.CustomImages.Parent = this.yesReset_BTN;
            this.resetPanel_Animation.SetDecoration(this.yesReset_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.yesReset_BTN.FillColor = System.Drawing.Color.Empty;
            this.yesReset_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yesReset_BTN.ForeColor = System.Drawing.Color.White;
            this.yesReset_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.yesReset_BTN.HoverState.Parent = this.yesReset_BTN;
            this.yesReset_BTN.Image = global::Number.Properties.Resources.checkmark;
            this.yesReset_BTN.Location = new System.Drawing.Point(6, 22);
            this.yesReset_BTN.Name = "yesReset_BTN";
            this.yesReset_BTN.ShadowDecoration.Parent = this.yesReset_BTN;
            this.yesReset_BTN.Size = new System.Drawing.Size(114, 41);
            this.yesReset_BTN.TabIndex = 16;
            this.yesReset_BTN.Text = "بله";
            this.yesReset_BTN.Click += new System.EventHandler(this.Yes_Reset_Click);
            // 
            // noReset_BTN
            // 
            this.noReset_BTN.AutoRoundedCorners = true;
            this.noReset_BTN.BackColor = System.Drawing.Color.Transparent;
            this.noReset_BTN.BorderColor = System.Drawing.Color.White;
            this.noReset_BTN.BorderRadius = 19;
            this.noReset_BTN.BorderThickness = 1;
            this.noReset_BTN.CheckedState.Parent = this.noReset_BTN;
            this.noReset_BTN.CustomImages.Parent = this.noReset_BTN;
            this.resetPanel_Animation.SetDecoration(this.noReset_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.noReset_BTN.FillColor = System.Drawing.Color.Empty;
            this.noReset_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.noReset_BTN.ForeColor = System.Drawing.Color.White;
            this.noReset_BTN.HoverState.Parent = this.noReset_BTN;
            this.noReset_BTN.Image = global::Number.Properties.Resources.delete;
            this.noReset_BTN.Location = new System.Drawing.Point(153, 22);
            this.noReset_BTN.Name = "noReset_BTN";
            this.noReset_BTN.ShadowDecoration.Parent = this.noReset_BTN;
            this.noReset_BTN.Size = new System.Drawing.Size(118, 41);
            this.noReset_BTN.TabIndex = 11;
            this.noReset_BTN.Text = "خیر";
            this.noReset_BTN.Click += new System.EventHandler(this.No_Reset_Click);
            // 
            // resetPanel_Animation
            // 
            this.resetPanel_Animation.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Leaf;
            this.resetPanel_Animation.Cursor = null;
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
            this.resetPanel_Animation.DefaultAnimation = animation1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.resetPanel_Animation.SetDecoration(this.label8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label8.Location = new System.Drawing.Point(401, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 26);
            this.label8.TabIndex = 18;
            this.label8.Text = "پخش جلوه های صوتی";
            // 
            // soundPlay_Toggle
            // 
            this.soundPlay_Toggle.Animated = true;
            this.soundPlay_Toggle.AutoRoundedCorners = true;
            this.soundPlay_Toggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.soundPlay_Toggle.CheckedState.BorderRadius = 12;
            this.soundPlay_Toggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(205)))), ((int)(((byte)(83)))));
            this.soundPlay_Toggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.soundPlay_Toggle.CheckedState.InnerBorderRadius = 8;
            this.soundPlay_Toggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.soundPlay_Toggle.CheckedState.Parent = this.soundPlay_Toggle;
            this.resetPanel_Animation.SetDecoration(this.soundPlay_Toggle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.soundPlay_Toggle.Location = new System.Drawing.Point(344, 155);
            this.soundPlay_Toggle.Name = "soundPlay_Toggle";
            this.soundPlay_Toggle.ShadowDecoration.Parent = this.soundPlay_Toggle;
            this.soundPlay_Toggle.Size = new System.Drawing.Size(57, 26);
            this.soundPlay_Toggle.TabIndex = 10;
            this.soundPlay_Toggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.soundPlay_Toggle.UncheckedState.BorderRadius = 12;
            this.soundPlay_Toggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.soundPlay_Toggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.soundPlay_Toggle.UncheckedState.InnerBorderRadius = 8;
            this.soundPlay_Toggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.soundPlay_Toggle.UncheckedState.Parent = this.soundPlay_Toggle;
            this.soundPlay_Toggle.CheckedChanged += new System.EventHandler(this.SoundPlay_CheckedChanged);
            // 
            // soundSetting_BTN
            // 
            this.soundSetting_BTN.AutoRoundedCorners = true;
            this.soundSetting_BTN.BackColor = System.Drawing.Color.Transparent;
            this.soundSetting_BTN.BorderColor = System.Drawing.Color.White;
            this.soundSetting_BTN.BorderRadius = 19;
            this.soundSetting_BTN.BorderThickness = 1;
            this.soundSetting_BTN.CheckedState.Parent = this.soundSetting_BTN;
            this.soundSetting_BTN.CustomImages.Parent = this.soundSetting_BTN;
            this.resetPanel_Animation.SetDecoration(this.soundSetting_BTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.soundSetting_BTN.FillColor = System.Drawing.Color.Empty;
            this.soundSetting_BTN.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.soundSetting_BTN.ForeColor = System.Drawing.Color.White;
            this.soundSetting_BTN.HoverState.Parent = this.soundSetting_BTN;
            this.soundSetting_BTN.Image = global::Number.Properties.Resources.music;
            this.soundSetting_BTN.Location = new System.Drawing.Point(221, 150);
            this.soundSetting_BTN.Name = "soundSetting_BTN";
            this.soundSetting_BTN.ShadowDecoration.Parent = this.soundSetting_BTN;
            this.soundSetting_BTN.Size = new System.Drawing.Size(118, 41);
            this.soundSetting_BTN.TabIndex = 11;
            this.soundSetting_BTN.Text = "انتخاب صدا";
            this.soundSetting_BTN.Visible = false;
            this.soundSetting_BTN.Click += new System.EventHandler(this.SoundSetting_BTN_Click);
            // 
            // panelSound
            // 
            this.panelSound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSound.Controls.Add(this.sound5_RBTN);
            this.panelSound.Controls.Add(this.sound1_RBTN);
            this.panelSound.Controls.Add(this.sound2_RBTN);
            this.panelSound.Controls.Add(this.sound4_RBTN);
            this.panelSound.Controls.Add(this.sound3_RBTN);
            this.panelSound.Controls.Add(this.label9);
            this.resetPanel_Animation.SetDecoration(this.panelSound, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelSound.Location = new System.Drawing.Point(1, 286);
            this.panelSound.Name = "panelSound";
            this.panelSound.Size = new System.Drawing.Size(563, 81);
            this.panelSound.TabIndex = 18;
            this.panelSound.Visible = false;
            // 
            // sound5_RBTN
            // 
            this.sound5_RBTN.Animated = true;
            this.sound5_RBTN.AutoSize = true;
            this.sound5_RBTN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound5_RBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound5_RBTN.CheckedState.BorderThickness = 0;
            this.sound5_RBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound5_RBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sound5_RBTN.CheckedState.InnerOffset = -4;
            this.resetPanel_Animation.SetDecoration(this.sound5_RBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sound5_RBTN.Location = new System.Drawing.Point(40, 43);
            this.sound5_RBTN.Name = "sound5_RBTN";
            this.sound5_RBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sound5_RBTN.Size = new System.Drawing.Size(80, 30);
            this.sound5_RBTN.TabIndex = 4;
            this.sound5_RBTN.Text = "صدای 5";
            this.sound5_RBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sound5_RBTN.UncheckedState.BorderThickness = 2;
            this.sound5_RBTN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.sound5_RBTN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.sound5_RBTN.Click += new System.EventHandler(this.Sounds);
            // 
            // sound1_RBTN
            // 
            this.sound1_RBTN.Animated = true;
            this.sound1_RBTN.AutoSize = true;
            this.sound1_RBTN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound1_RBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound1_RBTN.CheckedState.BorderThickness = 0;
            this.sound1_RBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound1_RBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sound1_RBTN.CheckedState.InnerOffset = -4;
            this.resetPanel_Animation.SetDecoration(this.sound1_RBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sound1_RBTN.Location = new System.Drawing.Point(440, 43);
            this.sound1_RBTN.Name = "sound1_RBTN";
            this.sound1_RBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sound1_RBTN.Size = new System.Drawing.Size(80, 30);
            this.sound1_RBTN.TabIndex = 3;
            this.sound1_RBTN.Text = "صدای 1";
            this.sound1_RBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sound1_RBTN.UncheckedState.BorderThickness = 2;
            this.sound1_RBTN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.sound1_RBTN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.sound1_RBTN.Click += new System.EventHandler(this.Sounds);
            // 
            // sound2_RBTN
            // 
            this.sound2_RBTN.Animated = true;
            this.sound2_RBTN.AutoSize = true;
            this.sound2_RBTN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound2_RBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound2_RBTN.CheckedState.BorderThickness = 0;
            this.sound2_RBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound2_RBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sound2_RBTN.CheckedState.InnerOffset = -4;
            this.resetPanel_Animation.SetDecoration(this.sound2_RBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sound2_RBTN.Location = new System.Drawing.Point(340, 43);
            this.sound2_RBTN.Name = "sound2_RBTN";
            this.sound2_RBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sound2_RBTN.Size = new System.Drawing.Size(80, 30);
            this.sound2_RBTN.TabIndex = 3;
            this.sound2_RBTN.Text = "صدای 2";
            this.sound2_RBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sound2_RBTN.UncheckedState.BorderThickness = 2;
            this.sound2_RBTN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.sound2_RBTN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.sound2_RBTN.Click += new System.EventHandler(this.Sounds);
            // 
            // sound4_RBTN
            // 
            this.sound4_RBTN.Animated = true;
            this.sound4_RBTN.AutoSize = true;
            this.sound4_RBTN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound4_RBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound4_RBTN.CheckedState.BorderThickness = 0;
            this.sound4_RBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound4_RBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sound4_RBTN.CheckedState.InnerOffset = -4;
            this.resetPanel_Animation.SetDecoration(this.sound4_RBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sound4_RBTN.Location = new System.Drawing.Point(140, 43);
            this.sound4_RBTN.Name = "sound4_RBTN";
            this.sound4_RBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sound4_RBTN.Size = new System.Drawing.Size(80, 30);
            this.sound4_RBTN.TabIndex = 3;
            this.sound4_RBTN.Text = "صدای 4";
            this.sound4_RBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sound4_RBTN.UncheckedState.BorderThickness = 2;
            this.sound4_RBTN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.sound4_RBTN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.sound4_RBTN.Click += new System.EventHandler(this.Sounds);
            // 
            // sound3_RBTN
            // 
            this.sound3_RBTN.Animated = true;
            this.sound3_RBTN.AutoSize = true;
            this.sound3_RBTN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sound3_RBTN.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound3_RBTN.CheckedState.BorderThickness = 0;
            this.sound3_RBTN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sound3_RBTN.CheckedState.InnerColor = System.Drawing.Color.White;
            this.sound3_RBTN.CheckedState.InnerOffset = -4;
            this.resetPanel_Animation.SetDecoration(this.sound3_RBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.sound3_RBTN.Location = new System.Drawing.Point(240, 43);
            this.sound3_RBTN.Name = "sound3_RBTN";
            this.sound3_RBTN.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sound3_RBTN.Size = new System.Drawing.Size(80, 30);
            this.sound3_RBTN.TabIndex = 3;
            this.sound3_RBTN.Text = "صدای 3";
            this.sound3_RBTN.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.sound3_RBTN.UncheckedState.BorderThickness = 2;
            this.sound3_RBTN.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.sound3_RBTN.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.sound3_RBTN.Click += new System.EventHandler(this.Sounds);
            // 
            // label9
            // 
            this.resetPanel_Animation.SetDecoration(this.label9, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.resetPanel_Animation.SetDecoration(this.label10, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label10.Location = new System.Drawing.Point(430, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "شمارنده پیشفرض";
            // 
            // defaultNum_ComboBox
            // 
            this.defaultNum_ComboBox.Animated = true;
            this.defaultNum_ComboBox.AutoRoundedCorners = true;
            this.defaultNum_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.defaultNum_ComboBox.BorderRadius = 17;
            this.resetPanel_Animation.SetDecoration(this.defaultNum_ComboBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.defaultNum_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.defaultNum_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultNum_ComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.defaultNum_ComboBox.FocusedState.Parent = this.defaultNum_ComboBox;
            this.defaultNum_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.defaultNum_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.defaultNum_ComboBox.FormattingEnabled = true;
            this.defaultNum_ComboBox.HoverState.Parent = this.defaultNum_ComboBox;
            this.defaultNum_ComboBox.ItemHeight = 30;
            this.defaultNum_ComboBox.ItemsAppearance.Parent = this.defaultNum_ComboBox;
            this.defaultNum_ComboBox.Location = new System.Drawing.Point(286, 248);
            this.defaultNum_ComboBox.Name = "defaultNum_ComboBox";
            this.defaultNum_ComboBox.ShadowDecoration.Parent = this.defaultNum_ComboBox;
            this.defaultNum_ComboBox.Size = new System.Drawing.Size(140, 36);
            this.defaultNum_ComboBox.TabIndex = 19;
            // 
            // SettingPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(565, 444);
            this.Controls.Add(this.defaultNum_ComboBox);
            this.Controls.Add(this.panelSound);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fontClear_BTN);
            this.Controls.Add(this.font_BTN);
            this.Controls.Add(this.reset_BTN);
            this.Controls.Add(this.shortKey_BTN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Counter_Value);
            this.Controls.Add(this.panelReset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.soundSetting_BTN);
            this.Controls.Add(this.colorPicker_BTN);
            this.Controls.Add(this.soundPlay_Toggle);
            this.Controls.Add(this.theme_Toggle);
            this.Controls.Add(this.onTop_Toggle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reset_YN_Panel);
            this.resetPanel_Animation.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
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
            this.reset_YN_Panel.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2ToggleSwitch onTop_Toggle;
        private Guna.UI2.WinForms.Guna2ToggleSwitch theme_Toggle;
        private Guna.UI2.WinForms.Guna2Button fontClear_BTN;
        private Guna.UI2.WinForms.Guna2Button font_BTN;
        private Guna.UI2.WinForms.Guna2Button colorPicker_BTN;
        private Guna.UI2.WinForms.Guna2Elipse borderRadius;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2NumericUpDown Counter_Value;
        private System.Windows.Forms.Panel panelReset;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button shortKey_BTN;
        private Guna.UI2.WinForms.Guna2Button save_BTN;
        private Guna.UI2.WinForms.Guna2Button cancel_BTN;
        private Guna.UI2.WinForms.Guna2Button reset_BTN;
        private Guna.UI2.WinForms.Guna2Transition resetPanel_Animation;
        private System.Windows.Forms.Panel reset_YN_Panel;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button yesReset_BTN;
        private Guna.UI2.WinForms.Guna2Button noReset_BTN;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ToggleSwitch soundPlay_Toggle;
        private Guna.UI2.WinForms.Guna2Button soundSetting_BTN;
        private System.Windows.Forms.Panel panelSound;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2RadioButton sound3_RBTN;
        private Guna.UI2.WinForms.Guna2RadioButton sound1_RBTN;
        private Guna.UI2.WinForms.Guna2RadioButton sound2_RBTN;
        private Guna.UI2.WinForms.Guna2RadioButton sound4_RBTN;
        private Guna.UI2.WinForms.Guna2RadioButton sound5_RBTN;
        private Guna.UI2.WinForms.Guna2ComboBox defaultNum_ComboBox;
        private System.Windows.Forms.Label label10;
    }
}