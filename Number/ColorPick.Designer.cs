
namespace Number
{
    partial class ColorPick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPick));
            this.Border_radius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Panel_History_Colors = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_ColorPicker = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox_ColorHex = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Sharp = new System.Windows.Forms.Label();
            this.Panel_Exit = new System.Windows.Forms.Panel();
            this.Save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.panel_ColorBox = new System.Windows.Forms.Panel();
            this.RT = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.Label();
            this.RC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.GC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.BC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.Panel_Options = new System.Windows.Forms.Panel();
            this.Automatic_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Optionbtn_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.Panel_Exit.SuspendLayout();
            this.panel_ColorBox.SuspendLayout();
            this.Panel_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border_radius
            // 
            this.Border_radius.BorderRadius = 20;
            this.Border_radius.TargetControl = this;
            // 
            // Panel_History_Colors
            // 
            this.Panel_History_Colors.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_History_Colors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Panel_History_Colors.Location = new System.Drawing.Point(0, 0);
            this.Panel_History_Colors.Name = "Panel_History_Colors";
            this.Panel_History_Colors.Size = new System.Drawing.Size(51, 298);
            this.Panel_History_Colors.TabIndex = 18;
            this.Panel_History_Colors.WrapContents = false;
            // 
            // BTN_ColorPicker
            // 
            this.BTN_ColorPicker.CheckedState.Parent = this.BTN_ColorPicker;
            this.BTN_ColorPicker.CustomImages.Parent = this.BTN_ColorPicker;
            this.BTN_ColorPicker.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_ColorPicker.FillColor = System.Drawing.Color.Empty;
            this.BTN_ColorPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_ColorPicker.ForeColor = System.Drawing.Color.White;
            this.BTN_ColorPicker.HoverState.Parent = this.BTN_ColorPicker;
            this.BTN_ColorPicker.Image = global::Number.Properties.Resources.color_dropper;
            this.BTN_ColorPicker.ImageSize = new System.Drawing.Size(32, 32);
            this.BTN_ColorPicker.Location = new System.Drawing.Point(307, 0);
            this.BTN_ColorPicker.Name = "BTN_ColorPicker";
            this.BTN_ColorPicker.ShadowDecoration.Parent = this.BTN_ColorPicker;
            this.BTN_ColorPicker.Size = new System.Drawing.Size(48, 48);
            this.BTN_ColorPicker.TabIndex = 19;
            this.Optionbtn_toolTip.SetToolTip(this.BTN_ColorPicker, "انتخاب از صفحه");
            this.BTN_ColorPicker.Click += new System.EventHandler(this.BTN_ColorPicker_Click);
            // 
            // TextBox_ColorHex
            // 
            this.TextBox_ColorHex.BorderRadius = 5;
            this.TextBox_ColorHex.BorderThickness = 0;
            this.TextBox_ColorHex.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBox_ColorHex.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ColorHex.DefaultText = "";
            this.TextBox_ColorHex.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextBox_ColorHex.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextBox_ColorHex.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ColorHex.DisabledState.Parent = this.TextBox_ColorHex;
            this.TextBox_ColorHex.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextBox_ColorHex.FillColor = System.Drawing.Color.Empty;
            this.TextBox_ColorHex.FocusedState.Parent = this.TextBox_ColorHex;
            this.TextBox_ColorHex.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_ColorHex.ForeColor = System.Drawing.Color.White;
            this.TextBox_ColorHex.HoverState.Parent = this.TextBox_ColorHex;
            this.TextBox_ColorHex.Location = new System.Drawing.Point(27, 204);
            this.TextBox_ColorHex.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TextBox_ColorHex.Name = "TextBox_ColorHex";
            this.TextBox_ColorHex.PasswordChar = '\0';
            this.TextBox_ColorHex.PlaceholderText = "";
            this.TextBox_ColorHex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextBox_ColorHex.SelectedText = "";
            this.TextBox_ColorHex.ShadowDecoration.Parent = this.TextBox_ColorHex;
            this.TextBox_ColorHex.Size = new System.Drawing.Size(200, 36);
            this.TextBox_ColorHex.TabIndex = 22;
            this.TextBox_ColorHex.TextOffset = new System.Drawing.Point(0, -4);
            this.TextBox_ColorHex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Hex_ChengeColor);
            this.TextBox_ColorHex.Leave += new System.EventHandler(this.Hex_ChengeColor);
            // 
            // label_Sharp
            // 
            this.label_Sharp.AutoSize = true;
            this.label_Sharp.Font = new System.Drawing.Font("Vazir", 18F);
            this.label_Sharp.Location = new System.Drawing.Point(4, 203);
            this.label_Sharp.Name = "label_Sharp";
            this.label_Sharp.Size = new System.Drawing.Size(32, 39);
            this.label_Sharp.TabIndex = 23;
            this.label_Sharp.Text = "#";
            // 
            // Panel_Exit
            // 
            this.Panel_Exit.Controls.Add(this.Save_BTN);
            this.Panel_Exit.Controls.Add(this.Cancel_BTN);
            this.Panel_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Exit.Location = new System.Drawing.Point(0, 298);
            this.Panel_Exit.Name = "Panel_Exit";
            this.Panel_Exit.Size = new System.Drawing.Size(406, 55);
            this.Panel_Exit.TabIndex = 24;
            // 
            // Save_BTN
            // 
            this.Save_BTN.CheckedState.Parent = this.Save_BTN;
            this.Save_BTN.CustomImages.Parent = this.Save_BTN;
            this.Save_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Save_BTN.FillColor = System.Drawing.Color.Empty;
            this.Save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Save_BTN.ForeColor = System.Drawing.Color.White;
            this.Save_BTN.HoverState.Parent = this.Save_BTN;
            this.Save_BTN.Image = global::Number.Properties.Resources.exit;
            this.Save_BTN.Location = new System.Drawing.Point(151, 0);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.ShadowDecoration.Parent = this.Save_BTN;
            this.Save_BTN.Size = new System.Drawing.Size(255, 55);
            this.Save_BTN.TabIndex = 17;
            this.Save_BTN.Text = "ذخیره و خروج";
            this.Save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_BTN.CheckedState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.CustomImages.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.Cancel_BTN.FillColor = System.Drawing.Color.Empty;
            this.Cancel_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.Cancel_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.Cancel_BTN.HoverState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Image = global::Number.Properties.Resources.cancel;
            this.Cancel_BTN.Location = new System.Drawing.Point(0, 0);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.ShadowDecoration.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Size = new System.Drawing.Size(151, 55);
            this.Cancel_BTN.TabIndex = 9;
            this.Cancel_BTN.Text = "انصراف";
            this.Cancel_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Cancel_BTN.UseTransparentBackground = true;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // panel_ColorBox
            // 
            this.panel_ColorBox.Controls.Add(this.RT);
            this.panel_ColorBox.Controls.Add(this.TextBox_ColorHex);
            this.panel_ColorBox.Controls.Add(this.label_Sharp);
            this.panel_ColorBox.Controls.Add(this.GT);
            this.panel_ColorBox.Controls.Add(this.BT);
            this.panel_ColorBox.Controls.Add(this.RC);
            this.panel_ColorBox.Controls.Add(this.GC);
            this.panel_ColorBox.Controls.Add(this.BC);
            this.panel_ColorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ColorBox.Location = new System.Drawing.Point(51, 0);
            this.panel_ColorBox.Name = "panel_ColorBox";
            this.panel_ColorBox.Size = new System.Drawing.Size(355, 250);
            this.panel_ColorBox.TabIndex = 25;
            this.panel_ColorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // RT
            // 
            this.RT.Location = new System.Drawing.Point(27, 9);
            this.RT.Name = "RT";
            this.RT.Size = new System.Drawing.Size(300, 23);
            this.RT.TabIndex = 14;
            this.RT.Text = "مقدار رنگ قرمز:";
            this.RT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // GT
            // 
            this.GT.Location = new System.Drawing.Point(27, 71);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(300, 23);
            this.GT.TabIndex = 14;
            this.GT.Text = "مقدار رنگ سبز:";
            this.GT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(27, 133);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(300, 23);
            this.BT.TabIndex = 14;
            this.BT.Text = "مقدار رنگ آبی:";
            this.BT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // RC
            // 
            this.RC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RC.HoverState.Parent = this.RC;
            this.RC.Location = new System.Drawing.Point(27, 40);
            this.RC.Maximum = 255;
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(300, 23);
            this.RC.TabIndex = 15;
            this.RC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RC.Value = 127;
            this.RC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // GC
            // 
            this.GC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.GC.HoverState.Parent = this.GC;
            this.GC.Location = new System.Drawing.Point(27, 102);
            this.GC.Maximum = 255;
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(300, 23);
            this.GC.TabIndex = 15;
            this.GC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.GC.Value = 127;
            this.GC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // BC
            // 
            this.BC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.BC.HoverState.Parent = this.BC;
            this.BC.Location = new System.Drawing.Point(27, 164);
            this.BC.Maximum = 255;
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(300, 23);
            this.BC.TabIndex = 15;
            this.BC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BC.Value = 127;
            this.BC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // Panel_Options
            // 
            this.Panel_Options.Controls.Add(this.Automatic_BTN);
            this.Panel_Options.Controls.Add(this.BTN_ColorPicker);
            this.Panel_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Options.Location = new System.Drawing.Point(51, 250);
            this.Panel_Options.Name = "Panel_Options";
            this.Panel_Options.Size = new System.Drawing.Size(355, 48);
            this.Panel_Options.TabIndex = 26;
            // 
            // Automatic_BTN
            // 
            this.Automatic_BTN.CheckedState.Parent = this.Automatic_BTN;
            this.Automatic_BTN.CustomImages.Parent = this.Automatic_BTN;
            this.Automatic_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Automatic_BTN.FillColor = System.Drawing.Color.Empty;
            this.Automatic_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Automatic_BTN.ForeColor = System.Drawing.Color.White;
            this.Automatic_BTN.HoverState.Parent = this.Automatic_BTN;
            this.Automatic_BTN.Image = global::Number.Properties.Resources.wallpaper;
            this.Automatic_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.Automatic_BTN.Location = new System.Drawing.Point(259, 0);
            this.Automatic_BTN.Name = "Automatic_BTN";
            this.Automatic_BTN.ShadowDecoration.Parent = this.Automatic_BTN;
            this.Automatic_BTN.Size = new System.Drawing.Size(48, 48);
            this.Automatic_BTN.TabIndex = 20;
            this.Optionbtn_toolTip.SetToolTip(this.Automatic_BTN, "انتخاب به صورت خودکار از پس زمینه");
            this.Automatic_BTN.Click += new System.EventHandler(this.Automatic_BTN_Click);
            // 
            // ColorPick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.panel_ColorBox);
            this.Controls.Add(this.Panel_Options);
            this.Controls.Add(this.Panel_History_Colors);
            this.Controls.Add(this.Panel_Exit);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ColorPick";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ColorPick_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            this.Panel_Exit.ResumeLayout(false);
            this.panel_ColorBox.ResumeLayout(false);
            this.panel_ColorBox.PerformLayout();
            this.Panel_Options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse Border_radius;
        private System.Windows.Forms.FlowLayoutPanel Panel_History_Colors;
        private Guna.UI2.WinForms.Guna2Button BTN_ColorPicker;
        private System.Windows.Forms.Label label_Sharp;
        private Guna.UI2.WinForms.Guna2TextBox TextBox_ColorHex;
        private System.Windows.Forms.Panel Panel_Exit;
        private Guna.UI2.WinForms.Guna2Button Save_BTN;
        private Guna.UI2.WinForms.Guna2Button Cancel_BTN;
        private System.Windows.Forms.Panel panel_ColorBox;
        private System.Windows.Forms.Label RT;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label BT;
        private Guna.UI2.WinForms.Guna2TrackBar RC;
        private Guna.UI2.WinForms.Guna2TrackBar GC;
        private Guna.UI2.WinForms.Guna2TrackBar BC;
        private System.Windows.Forms.Panel Panel_Options;
        private Guna.UI2.WinForms.Guna2Button Automatic_BTN;
        private System.Windows.Forms.ToolTip Optionbtn_toolTip;
    }
}