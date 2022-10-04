
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
            this.RT = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.Label();
            this.RC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.GC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.BC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CancelBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_color = new System.Windows.Forms.Panel();
            this.label_SColor = new System.Windows.Forms.Label();
            this.BTN_Color_2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Panel_History_Colors = new System.Windows.Forms.FlowLayoutPanel();
            this.BTN_Color_3 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_4 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_5 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_6 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_7 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.BTN_Color_8 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Panel_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // RT
            // 
            this.RT.Location = new System.Drawing.Point(76, 22);
            this.RT.Name = "RT";
            this.RT.Size = new System.Drawing.Size(300, 23);
            this.RT.TabIndex = 14;
            this.RT.Text = "مقدار رنگ قرمز:";
            this.RT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // GT
            // 
            this.GT.Location = new System.Drawing.Point(76, 84);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(300, 23);
            this.GT.TabIndex = 14;
            this.GT.Text = "مقدار رنگ سبز:";
            this.GT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(76, 146);
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
            this.RC.Location = new System.Drawing.Point(76, 53);
            this.RC.Maximum = 255;
            this.RC.Minimum = 1;
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
            this.GC.Location = new System.Drawing.Point(76, 115);
            this.GC.Maximum = 255;
            this.GC.Minimum = 1;
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
            this.BC.Location = new System.Drawing.Point(76, 177);
            this.BC.Maximum = 255;
            this.BC.Minimum = 1;
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(300, 23);
            this.BC.TabIndex = 15;
            this.BC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BC.Value = 127;
            this.BC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // CancelBTN
            // 
            this.CancelBTN.CheckedState.Parent = this.CancelBTN;
            this.CancelBTN.CustomImages.Parent = this.CancelBTN;
            this.CancelBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CancelBTN.FillColor = System.Drawing.Color.Empty;
            this.CancelBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.CancelBTN.ForeColor = System.Drawing.Color.White;
            this.CancelBTN.HoverState.Parent = this.CancelBTN;
            this.CancelBTN.Image = global::Number.Properties.Resources.exit;
            this.CancelBTN.Location = new System.Drawing.Point(0, 274);
            this.CancelBTN.Name = "CancelBTN";
            this.CancelBTN.ShadowDecoration.Parent = this.CancelBTN;
            this.CancelBTN.Size = new System.Drawing.Size(388, 59);
            this.CancelBTN.TabIndex = 16;
            this.CancelBTN.Text = "خروج";
            this.CancelBTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.CancelBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // Panel_color
            // 
            this.Panel_color.Controls.Add(this.label_SColor);
            this.Panel_color.Controls.Add(this.BTN_Color_8);
            this.Panel_color.Controls.Add(this.BTN_Color_7);
            this.Panel_color.Controls.Add(this.BTN_Color_6);
            this.Panel_color.Controls.Add(this.BTN_Color_5);
            this.Panel_color.Controls.Add(this.BTN_Color_4);
            this.Panel_color.Controls.Add(this.BTN_Color_3);
            this.Panel_color.Controls.Add(this.BTN_Color_2);
            this.Panel_color.Controls.Add(this.BTN_Color_1);
            this.Panel_color.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_color.Location = new System.Drawing.Point(0, 234);
            this.Panel_color.Name = "Panel_color";
            this.Panel_color.Size = new System.Drawing.Size(388, 40);
            this.Panel_color.TabIndex = 17;
            // 
            // label_SColor
            // 
            this.label_SColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.label_SColor.Font = new System.Drawing.Font("Vazir", 10F);
            this.label_SColor.Location = new System.Drawing.Point(268, 0);
            this.label_SColor.Name = "label_SColor";
            this.label_SColor.Size = new System.Drawing.Size(120, 40);
            this.label_SColor.TabIndex = 1;
            this.label_SColor.Text = "رنگ های پیشنهادی:";
            this.label_SColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_Color_2
            // 
            this.BTN_Color_2.BorderThickness = 1;
            this.BTN_Color_2.CheckedState.Parent = this.BTN_Color_2;
            this.BTN_Color_2.CustomImages.Parent = this.BTN_Color_2;
            this.BTN_Color_2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.BTN_Color_2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_2.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_2.HoverState.Parent = this.BTN_Color_2;
            this.BTN_Color_2.Location = new System.Drawing.Point(206, 8);
            this.BTN_Color_2.Name = "BTN_Color_2";
            this.BTN_Color_2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_2.ShadowDecoration.Parent = this.BTN_Color_2;
            this.BTN_Color_2.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_2.TabIndex = 0;
            this.BTN_Color_2.Tile = false;
            this.BTN_Color_2.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_1
            // 
            this.BTN_Color_1.BorderThickness = 1;
            this.BTN_Color_1.CheckedState.Parent = this.BTN_Color_1;
            this.BTN_Color_1.CustomImages.Parent = this.BTN_Color_1;
            this.BTN_Color_1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(196)))), ((int)(((byte)(236)))));
            this.BTN_Color_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_1.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_1.HoverState.Parent = this.BTN_Color_1;
            this.BTN_Color_1.Location = new System.Drawing.Point(239, 8);
            this.BTN_Color_1.Name = "BTN_Color_1";
            this.BTN_Color_1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_1.ShadowDecoration.Parent = this.BTN_Color_1;
            this.BTN_Color_1.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_1.TabIndex = 0;
            this.BTN_Color_1.Tile = false;
            this.BTN_Color_1.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // Panel_History_Colors
            // 
            this.Panel_History_Colors.AutoScroll = true;
            this.Panel_History_Colors.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_History_Colors.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.Panel_History_Colors.Location = new System.Drawing.Point(0, 0);
            this.Panel_History_Colors.Name = "Panel_History_Colors";
            this.Panel_History_Colors.Size = new System.Drawing.Size(51, 234);
            this.Panel_History_Colors.TabIndex = 18;
            this.Panel_History_Colors.WrapContents = false;
            // 
            // BTN_Color_3
            // 
            this.BTN_Color_3.BorderThickness = 1;
            this.BTN_Color_3.CheckedState.Parent = this.BTN_Color_3;
            this.BTN_Color_3.CustomImages.Parent = this.BTN_Color_3;
            this.BTN_Color_3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(142)))), ((int)(((byte)(71)))));
            this.BTN_Color_3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_3.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_3.HoverState.Parent = this.BTN_Color_3;
            this.BTN_Color_3.Location = new System.Drawing.Point(173, 8);
            this.BTN_Color_3.Name = "BTN_Color_3";
            this.BTN_Color_3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_3.ShadowDecoration.Parent = this.BTN_Color_3;
            this.BTN_Color_3.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_3.TabIndex = 0;
            this.BTN_Color_3.Tile = false;
            this.BTN_Color_3.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_4
            // 
            this.BTN_Color_4.BorderThickness = 1;
            this.BTN_Color_4.CheckedState.Parent = this.BTN_Color_4;
            this.BTN_Color_4.CustomImages.Parent = this.BTN_Color_4;
            this.BTN_Color_4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(82)))), ((int)(((byte)(202)))));
            this.BTN_Color_4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_4.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_4.HoverState.Parent = this.BTN_Color_4;
            this.BTN_Color_4.Location = new System.Drawing.Point(140, 8);
            this.BTN_Color_4.Name = "BTN_Color_4";
            this.BTN_Color_4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_4.ShadowDecoration.Parent = this.BTN_Color_4;
            this.BTN_Color_4.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_4.TabIndex = 0;
            this.BTN_Color_4.Tile = false;
            this.BTN_Color_4.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_5
            // 
            this.BTN_Color_5.BorderThickness = 1;
            this.BTN_Color_5.CheckedState.Parent = this.BTN_Color_5;
            this.BTN_Color_5.CustomImages.Parent = this.BTN_Color_5;
            this.BTN_Color_5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(62)))), ((int)(((byte)(18)))));
            this.BTN_Color_5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_5.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_5.HoverState.Parent = this.BTN_Color_5;
            this.BTN_Color_5.Location = new System.Drawing.Point(107, 8);
            this.BTN_Color_5.Name = "BTN_Color_5";
            this.BTN_Color_5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_5.ShadowDecoration.Parent = this.BTN_Color_5;
            this.BTN_Color_5.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_5.TabIndex = 0;
            this.BTN_Color_5.Tile = false;
            this.BTN_Color_5.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_6
            // 
            this.BTN_Color_6.BorderThickness = 1;
            this.BTN_Color_6.CheckedState.Parent = this.BTN_Color_6;
            this.BTN_Color_6.CustomImages.Parent = this.BTN_Color_6;
            this.BTN_Color_6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(212)))), ((int)(((byte)(113)))));
            this.BTN_Color_6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_6.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_6.HoverState.Parent = this.BTN_Color_6;
            this.BTN_Color_6.Location = new System.Drawing.Point(74, 8);
            this.BTN_Color_6.Name = "BTN_Color_6";
            this.BTN_Color_6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_6.ShadowDecoration.Parent = this.BTN_Color_6;
            this.BTN_Color_6.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_6.TabIndex = 0;
            this.BTN_Color_6.Tile = false;
            this.BTN_Color_6.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_7
            // 
            this.BTN_Color_7.BorderThickness = 1;
            this.BTN_Color_7.CheckedState.Parent = this.BTN_Color_7;
            this.BTN_Color_7.CustomImages.Parent = this.BTN_Color_7;
            this.BTN_Color_7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(138)))), ((int)(((byte)(129)))));
            this.BTN_Color_7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_7.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_7.HoverState.Parent = this.BTN_Color_7;
            this.BTN_Color_7.Location = new System.Drawing.Point(41, 8);
            this.BTN_Color_7.Name = "BTN_Color_7";
            this.BTN_Color_7.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_7.ShadowDecoration.Parent = this.BTN_Color_7;
            this.BTN_Color_7.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_7.TabIndex = 0;
            this.BTN_Color_7.Tile = false;
            this.BTN_Color_7.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // BTN_Color_8
            // 
            this.BTN_Color_8.BorderThickness = 1;
            this.BTN_Color_8.CheckedState.Parent = this.BTN_Color_8;
            this.BTN_Color_8.CustomImages.Parent = this.BTN_Color_8;
            this.BTN_Color_8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.BTN_Color_8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_Color_8.ForeColor = System.Drawing.Color.White;
            this.BTN_Color_8.HoverState.Parent = this.BTN_Color_8;
            this.BTN_Color_8.Location = new System.Drawing.Point(8, 8);
            this.BTN_Color_8.Name = "BTN_Color_8";
            this.BTN_Color_8.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BTN_Color_8.ShadowDecoration.Parent = this.BTN_Color_8;
            this.BTN_Color_8.Size = new System.Drawing.Size(25, 25);
            this.BTN_Color_8.TabIndex = 0;
            this.BTN_Color_8.Tile = false;
            this.BTN_Color_8.Click += new System.EventHandler(this.BTN_Color_Click);
            // 
            // ColorPick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(388, 333);
            this.Controls.Add(this.Panel_History_Colors);
            this.Controls.Add(this.Panel_color);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.RT);
            this.Controls.Add(this.CancelBTN);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ColorPick";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "انتخاب رنگ";
            this.Load += new System.EventHandler(this.ColorPick_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            this.Panel_color.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label BT;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label RT;
        private Guna.UI2.WinForms.Guna2TrackBar RC;
        private Guna.UI2.WinForms.Guna2TrackBar BC;
        private Guna.UI2.WinForms.Guna2TrackBar GC;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button CancelBTN;
        private System.Windows.Forms.Panel Panel_color;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_2;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_1;
        private System.Windows.Forms.Label label_SColor;
        private System.Windows.Forms.FlowLayoutPanel Panel_History_Colors;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_8;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_7;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_6;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_5;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_4;
        private Guna.UI2.WinForms.Guna2CircleButton BTN_Color_3;
    }
}