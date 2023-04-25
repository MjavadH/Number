
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
            this.border_radius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_History_Colors = new System.Windows.Forms.FlowLayoutPanel();
            this.colorpicker_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.hex_TextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label_Sharp = new System.Windows.Forms.Label();
            this.panel_Exit = new System.Windows.Forms.Panel();
            this.save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.panel_ColorBox = new System.Windows.Forms.Panel();
            this.red_Text = new System.Windows.Forms.Label();
            this.green_Text = new System.Windows.Forms.Label();
            this.blue_Text = new System.Windows.Forms.Label();
            this.red_Bar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.green_Bar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.blue_Bar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.panel_Options = new System.Windows.Forms.Panel();
            this.automatic_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.favorite_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.random_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.colorWheel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.optionBTN_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenu_ColorBTNs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_AddToFavorite = new System.Windows.Forms.ToolStripMenuItem();
            this.flp_ColorFavorite = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_Exit.SuspendLayout();
            this.panel_ColorBox.SuspendLayout();
            this.panel_Options.SuspendLayout();
            this.contextMenu_ColorBTNs.SuspendLayout();
            this.SuspendLayout();
            // 
            // border_radius
            // 
            this.border_radius.BorderRadius = 20;
            this.border_radius.TargetControl = this;
            // 
            // panel_History_Colors
            // 
            this.panel_History_Colors.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_History_Colors.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel_History_Colors.Location = new System.Drawing.Point(0, 0);
            this.panel_History_Colors.Name = "panel_History_Colors";
            this.panel_History_Colors.Size = new System.Drawing.Size(50, 298);
            this.panel_History_Colors.TabIndex = 18;
            this.panel_History_Colors.WrapContents = false;
            // 
            // colorpicker_BTN
            // 
            this.colorpicker_BTN.CheckedState.Parent = this.colorpicker_BTN;
            this.colorpicker_BTN.CustomImages.Parent = this.colorpicker_BTN;
            this.colorpicker_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorpicker_BTN.FillColor = System.Drawing.Color.Empty;
            this.colorpicker_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorpicker_BTN.ForeColor = System.Drawing.Color.White;
            this.colorpicker_BTN.HoverState.Parent = this.colorpicker_BTN;
            this.colorpicker_BTN.Image = global::Number.Properties.Resources.color_dropper;
            this.colorpicker_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.colorpicker_BTN.Location = new System.Drawing.Point(116, 0);
            this.colorpicker_BTN.Name = "colorpicker_BTN";
            this.colorpicker_BTN.ShadowDecoration.Parent = this.colorpicker_BTN;
            this.colorpicker_BTN.Size = new System.Drawing.Size(48, 48);
            this.colorpicker_BTN.TabIndex = 19;
            this.optionBTN_tooltip.SetToolTip(this.colorpicker_BTN, "انتخاب از صفحه");
            this.colorpicker_BTN.Click += new System.EventHandler(this.BTN_ColorPicker_Click);
            // 
            // hex_TextBox
            // 
            this.hex_TextBox.BorderRadius = 5;
            this.hex_TextBox.BorderThickness = 0;
            this.hex_TextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.hex_TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hex_TextBox.DefaultText = "";
            this.hex_TextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.hex_TextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.hex_TextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hex_TextBox.DisabledState.Parent = this.hex_TextBox;
            this.hex_TextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.hex_TextBox.FillColor = System.Drawing.Color.Empty;
            this.hex_TextBox.FocusedState.Parent = this.hex_TextBox;
            this.hex_TextBox.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.hex_TextBox.ForeColor = System.Drawing.Color.White;
            this.hex_TextBox.HoverState.Parent = this.hex_TextBox;
            this.hex_TextBox.Location = new System.Drawing.Point(27, 204);
            this.hex_TextBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.hex_TextBox.Name = "hex_TextBox";
            this.hex_TextBox.PasswordChar = '\0';
            this.hex_TextBox.PlaceholderText = "";
            this.hex_TextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.hex_TextBox.SelectedText = "";
            this.hex_TextBox.ShadowDecoration.Parent = this.hex_TextBox;
            this.hex_TextBox.Size = new System.Drawing.Size(200, 36);
            this.hex_TextBox.TabIndex = 22;
            this.hex_TextBox.TextOffset = new System.Drawing.Point(0, -4);
            this.hex_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Hex_ChengeColor);
            this.hex_TextBox.Leave += new System.EventHandler(this.Hex_ChengeColor);
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
            // panel_Exit
            // 
            this.panel_Exit.Controls.Add(this.save_BTN);
            this.panel_Exit.Controls.Add(this.cancel_BTN);
            this.panel_Exit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Exit.Location = new System.Drawing.Point(0, 298);
            this.panel_Exit.Name = "panel_Exit";
            this.panel_Exit.Size = new System.Drawing.Size(406, 55);
            this.panel_Exit.TabIndex = 24;
            // 
            // save_BTN
            // 
            this.save_BTN.CheckedState.Parent = this.save_BTN;
            this.save_BTN.CustomImages.Parent = this.save_BTN;
            this.save_BTN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.save_BTN.FillColor = System.Drawing.Color.Empty;
            this.save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.save_BTN.ForeColor = System.Drawing.Color.White;
            this.save_BTN.HoverState.Parent = this.save_BTN;
            this.save_BTN.Image = global::Number.Properties.Resources.exit;
            this.save_BTN.Location = new System.Drawing.Point(151, 0);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.ShadowDecoration.Parent = this.save_BTN;
            this.save_BTN.Size = new System.Drawing.Size(255, 55);
            this.save_BTN.TabIndex = 17;
            this.save_BTN.Text = "ذخیره و خروج";
            this.save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.BackColor = System.Drawing.Color.Transparent;
            this.cancel_BTN.CheckedState.Parent = this.cancel_BTN;
            this.cancel_BTN.CustomImages.Parent = this.cancel_BTN;
            this.cancel_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.cancel_BTN.FillColor = System.Drawing.Color.Empty;
            this.cancel_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.cancel_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.cancel_BTN.HoverState.Parent = this.cancel_BTN;
            this.cancel_BTN.Image = global::Number.Properties.Resources.cancel;
            this.cancel_BTN.Location = new System.Drawing.Point(0, 0);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.ShadowDecoration.Parent = this.cancel_BTN;
            this.cancel_BTN.Size = new System.Drawing.Size(151, 55);
            this.cancel_BTN.TabIndex = 9;
            this.cancel_BTN.Text = "انصراف";
            this.cancel_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.cancel_BTN.UseTransparentBackground = true;
            this.cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            // 
            // panel_ColorBox
            // 
            this.panel_ColorBox.Controls.Add(this.red_Text);
            this.panel_ColorBox.Controls.Add(this.hex_TextBox);
            this.panel_ColorBox.Controls.Add(this.label_Sharp);
            this.panel_ColorBox.Controls.Add(this.green_Text);
            this.panel_ColorBox.Controls.Add(this.blue_Text);
            this.panel_ColorBox.Controls.Add(this.red_Bar);
            this.panel_ColorBox.Controls.Add(this.green_Bar);
            this.panel_ColorBox.Controls.Add(this.blue_Bar);
            this.panel_ColorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ColorBox.Location = new System.Drawing.Point(50, 0);
            this.panel_ColorBox.Name = "panel_ColorBox";
            this.panel_ColorBox.Size = new System.Drawing.Size(356, 250);
            this.panel_ColorBox.TabIndex = 25;
            this.panel_ColorBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // red_Text
            // 
            this.red_Text.Location = new System.Drawing.Point(27, 9);
            this.red_Text.Name = "red_Text";
            this.red_Text.Size = new System.Drawing.Size(300, 23);
            this.red_Text.TabIndex = 14;
            this.red_Text.Text = "مقدار رنگ قرمز:";
            this.red_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.red_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // green_Text
            // 
            this.green_Text.Location = new System.Drawing.Point(27, 71);
            this.green_Text.Name = "green_Text";
            this.green_Text.Size = new System.Drawing.Size(300, 23);
            this.green_Text.TabIndex = 14;
            this.green_Text.Text = "مقدار رنگ سبز:";
            this.green_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.green_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // blue_Text
            // 
            this.blue_Text.Location = new System.Drawing.Point(27, 133);
            this.blue_Text.Name = "blue_Text";
            this.blue_Text.Size = new System.Drawing.Size(300, 23);
            this.blue_Text.TabIndex = 14;
            this.blue_Text.Text = "مقدار رنگ آبی:";
            this.blue_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.blue_Text.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // red_Bar
            // 
            this.red_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.red_Bar.HoverState.Parent = this.red_Bar;
            this.red_Bar.Location = new System.Drawing.Point(27, 40);
            this.red_Bar.Maximum = 255;
            this.red_Bar.Name = "red_Bar";
            this.red_Bar.Size = new System.Drawing.Size(300, 23);
            this.red_Bar.TabIndex = 15;
            this.red_Bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.red_Bar.Value = 127;
            this.red_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // green_Bar
            // 
            this.green_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.green_Bar.HoverState.Parent = this.green_Bar;
            this.green_Bar.Location = new System.Drawing.Point(27, 102);
            this.green_Bar.Maximum = 255;
            this.green_Bar.Name = "green_Bar";
            this.green_Bar.Size = new System.Drawing.Size(300, 23);
            this.green_Bar.TabIndex = 15;
            this.green_Bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.green_Bar.Value = 127;
            this.green_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // blue_Bar
            // 
            this.blue_Bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.blue_Bar.HoverState.Parent = this.blue_Bar;
            this.blue_Bar.Location = new System.Drawing.Point(27, 164);
            this.blue_Bar.Maximum = 255;
            this.blue_Bar.Name = "blue_Bar";
            this.blue_Bar.Size = new System.Drawing.Size(300, 23);
            this.blue_Bar.TabIndex = 15;
            this.blue_Bar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.blue_Bar.Value = 127;
            this.blue_Bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // panel_Options
            // 
            this.panel_Options.Controls.Add(this.colorpicker_BTN);
            this.panel_Options.Controls.Add(this.automatic_BTN);
            this.panel_Options.Controls.Add(this.favorite_BTN);
            this.panel_Options.Controls.Add(this.random_BTN);
            this.panel_Options.Controls.Add(this.colorWheel_BTN);
            this.panel_Options.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Options.Location = new System.Drawing.Point(50, 250);
            this.panel_Options.Name = "panel_Options";
            this.panel_Options.Size = new System.Drawing.Size(356, 48);
            this.panel_Options.TabIndex = 26;
            // 
            // automatic_BTN
            // 
            this.automatic_BTN.CheckedState.Parent = this.automatic_BTN;
            this.automatic_BTN.CustomImages.Parent = this.automatic_BTN;
            this.automatic_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.automatic_BTN.FillColor = System.Drawing.Color.Empty;
            this.automatic_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.automatic_BTN.ForeColor = System.Drawing.Color.White;
            this.automatic_BTN.HoverState.Parent = this.automatic_BTN;
            this.automatic_BTN.Image = global::Number.Properties.Resources.wallpaper;
            this.automatic_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.automatic_BTN.Location = new System.Drawing.Point(164, 0);
            this.automatic_BTN.Name = "automatic_BTN";
            this.automatic_BTN.ShadowDecoration.Parent = this.automatic_BTN;
            this.automatic_BTN.Size = new System.Drawing.Size(48, 48);
            this.automatic_BTN.TabIndex = 20;
            this.optionBTN_tooltip.SetToolTip(this.automatic_BTN, "انتخاب به صورت خودکار از پس زمینه");
            this.automatic_BTN.Click += new System.EventHandler(this.Automatic_BTN_Click);
            // 
            // favorite_BTN
            // 
            this.favorite_BTN.CheckedState.Parent = this.favorite_BTN;
            this.favorite_BTN.CustomImages.Parent = this.favorite_BTN;
            this.favorite_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.favorite_BTN.FillColor = System.Drawing.Color.Empty;
            this.favorite_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.favorite_BTN.ForeColor = System.Drawing.Color.White;
            this.favorite_BTN.HoverState.Parent = this.favorite_BTN;
            this.favorite_BTN.Image = global::Number.Properties.Resources.favorite;
            this.favorite_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.favorite_BTN.Location = new System.Drawing.Point(212, 0);
            this.favorite_BTN.Name = "favorite_BTN";
            this.favorite_BTN.ShadowDecoration.Parent = this.favorite_BTN;
            this.favorite_BTN.Size = new System.Drawing.Size(48, 48);
            this.favorite_BTN.TabIndex = 22;
            this.optionBTN_tooltip.SetToolTip(this.favorite_BTN, "لیست مورد علاقه ها");
            this.favorite_BTN.Click += new System.EventHandler(this.favorite_BTN_Click);
            // 
            // random_BTN
            // 
            this.random_BTN.CheckedState.Parent = this.random_BTN;
            this.random_BTN.CustomImages.Parent = this.random_BTN;
            this.random_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.random_BTN.FillColor = System.Drawing.Color.Empty;
            this.random_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.random_BTN.ForeColor = System.Drawing.Color.White;
            this.random_BTN.HoverState.Parent = this.random_BTN;
            this.random_BTN.Image = global::Number.Properties.Resources.dice;
            this.random_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.random_BTN.Location = new System.Drawing.Point(260, 0);
            this.random_BTN.Name = "random_BTN";
            this.random_BTN.ShadowDecoration.Parent = this.random_BTN;
            this.random_BTN.Size = new System.Drawing.Size(48, 48);
            this.random_BTN.TabIndex = 21;
            this.optionBTN_tooltip.SetToolTip(this.random_BTN, "رنگ تصادفی");
            this.random_BTN.Click += new System.EventHandler(this.random_BTN_Click);
            // 
            // colorWheel_BTN
            // 
            this.colorWheel_BTN.CheckedState.Parent = this.colorWheel_BTN;
            this.colorWheel_BTN.CustomImages.Parent = this.colorWheel_BTN;
            this.colorWheel_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorWheel_BTN.FillColor = System.Drawing.Color.Empty;
            this.colorWheel_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.colorWheel_BTN.ForeColor = System.Drawing.Color.White;
            this.colorWheel_BTN.HoverState.Parent = this.colorWheel_BTN;
            this.colorWheel_BTN.Image = global::Number.Properties.Resources.color_wheel;
            this.colorWheel_BTN.ImageSize = new System.Drawing.Size(32, 32);
            this.colorWheel_BTN.Location = new System.Drawing.Point(308, 0);
            this.colorWheel_BTN.Name = "colorWheel_BTN";
            this.colorWheel_BTN.ShadowDecoration.Parent = this.colorWheel_BTN;
            this.colorWheel_BTN.Size = new System.Drawing.Size(48, 48);
            this.colorWheel_BTN.TabIndex = 23;
            this.optionBTN_tooltip.SetToolTip(this.colorWheel_BTN, "چرخه رنگ");
            this.colorWheel_BTN.Click += new System.EventHandler(this.colorWheel_BTN_Click);
            // 
            // contextMenu_ColorBTNs
            // 
            this.contextMenu_ColorBTNs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddToFavorite});
            this.contextMenu_ColorBTNs.Name = "contextMenu_ColorBTNs";
            this.contextMenu_ColorBTNs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenu_ColorBTNs.Size = new System.Drawing.Size(185, 50);
            this.contextMenu_ColorBTNs.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_ColorBTNs_Opening);
            // 
            // tsmi_AddToFavorite
            // 
            this.tsmi_AddToFavorite.Font = new System.Drawing.Font("Vazir", 9F);
            this.tsmi_AddToFavorite.Image = global::Number.Properties.Resources.favorite_black;
            this.tsmi_AddToFavorite.Name = "tsmi_AddToFavorite";
            this.tsmi_AddToFavorite.Size = new System.Drawing.Size(184, 24);
            this.tsmi_AddToFavorite.Tag = "AddF";
            this.tsmi_AddToFavorite.Text = "افزودن به مورد علاقه ها";
            this.tsmi_AddToFavorite.Click += new System.EventHandler(this.tsmi_AddToFavorite_Click);
            // 
            // flp_ColorFavorite
            // 
            this.flp_ColorFavorite.AutoScroll = true;
            this.flp_ColorFavorite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_ColorFavorite.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flp_ColorFavorite.Location = new System.Drawing.Point(50, 0);
            this.flp_ColorFavorite.Name = "flp_ColorFavorite";
            this.flp_ColorFavorite.Padding = new System.Windows.Forms.Padding(5);
            this.flp_ColorFavorite.Size = new System.Drawing.Size(356, 250);
            this.flp_ColorFavorite.TabIndex = 28;
            this.flp_ColorFavorite.Visible = false;
            this.flp_ColorFavorite.WrapContents = false;
            // 
            // ColorPick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(406, 353);
            this.Controls.Add(this.flp_ColorFavorite);
            this.Controls.Add(this.panel_ColorBox);
            this.Controls.Add(this.panel_Options);
            this.Controls.Add(this.panel_History_Colors);
            this.Controls.Add(this.panel_Exit);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ColorPick";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = " انتخاب رنگ";
            this.Load += new System.EventHandler(this.ColorPick_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            this.panel_Exit.ResumeLayout(false);
            this.panel_ColorBox.ResumeLayout(false);
            this.panel_ColorBox.PerformLayout();
            this.panel_Options.ResumeLayout(false);
            this.contextMenu_ColorBTNs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse border_radius;
        private System.Windows.Forms.FlowLayoutPanel panel_History_Colors;
        private Guna.UI2.WinForms.Guna2Button colorpicker_BTN;
        private System.Windows.Forms.Label label_Sharp;
        private Guna.UI2.WinForms.Guna2TextBox hex_TextBox;
        private System.Windows.Forms.Panel panel_Exit;
        private Guna.UI2.WinForms.Guna2Button save_BTN;
        private Guna.UI2.WinForms.Guna2Button cancel_BTN;
        private System.Windows.Forms.Panel panel_ColorBox;
        private System.Windows.Forms.Label red_Text;
        private System.Windows.Forms.Label green_Text;
        private System.Windows.Forms.Label blue_Text;
        private Guna.UI2.WinForms.Guna2TrackBar red_Bar;
        private Guna.UI2.WinForms.Guna2TrackBar green_Bar;
        private Guna.UI2.WinForms.Guna2TrackBar blue_Bar;
        private System.Windows.Forms.Panel panel_Options;
        private Guna.UI2.WinForms.Guna2Button automatic_BTN;
        private System.Windows.Forms.ToolTip optionBTN_tooltip;
        private Guna.UI2.WinForms.Guna2Button random_BTN;
        private Guna.UI2.WinForms.Guna2Button favorite_BTN;
        private Guna.UI2.WinForms.Guna2Button colorWheel_BTN;
        private System.Windows.Forms.ContextMenuStrip contextMenu_ColorBTNs;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddToFavorite;
        private System.Windows.Forms.FlowLayoutPanel flp_ColorFavorite;
    }
}