
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
            this.label1 = new System.Windows.Forms.Label();
            this.RT = new System.Windows.Forms.Label();
            this.GT = new System.Windows.Forms.Label();
            this.BT = new System.Windows.Forms.Label();
            this.RC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.GC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.BC = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CancelBTN = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = " رنگی که دوست دارید بسازید!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // RT
            // 
            this.RT.Location = new System.Drawing.Point(12, -1);
            this.RT.Name = "RT";
            this.RT.Size = new System.Drawing.Size(364, 42);
            this.RT.TabIndex = 14;
            this.RT.Text = "مقدار رنگ قرمز:";
            this.RT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // GT
            // 
            this.GT.Location = new System.Drawing.Point(0, 85);
            this.GT.Name = "GT";
            this.GT.Size = new System.Drawing.Size(388, 26);
            this.GT.TabIndex = 14;
            this.GT.Text = "مقدار رنگ سبز:";
            this.GT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // BT
            // 
            this.BT.Location = new System.Drawing.Point(0, 162);
            this.BT.Name = "BT";
            this.BT.Size = new System.Drawing.Size(388, 23);
            this.BT.TabIndex = 14;
            this.BT.Text = "مقدار رنگ آبی:";
            this.BT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // RC
            // 
            this.RC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RC.HoverState.Parent = this.RC;
            this.RC.IndicateFocus = false;
            this.RC.Location = new System.Drawing.Point(23, 44);
            this.RC.Maximum = 165;
            this.RC.Minimum = 1;
            this.RC.Name = "RC";
            this.RC.Size = new System.Drawing.Size(341, 23);
            this.RC.TabIndex = 15;
            this.RC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.RC.Value = 83;
            this.RC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // GC
            // 
            this.GC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.GC.HoverState.Parent = this.GC;
            this.GC.IndicateFocus = false;
            this.GC.Location = new System.Drawing.Point(23, 124);
            this.GC.Maximum = 165;
            this.GC.Minimum = 1;
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(341, 23);
            this.GC.TabIndex = 15;
            this.GC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.GC.Value = 83;
            this.GC.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RC_Scroll);
            // 
            // BC
            // 
            this.BC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.BC.HoverState.Parent = this.BC;
            this.BC.IndicateFocus = false;
            this.BC.Location = new System.Drawing.Point(23, 199);
            this.BC.Maximum = 165;
            this.BC.Minimum = 1;
            this.BC.Name = "BC";
            this.BC.Size = new System.Drawing.Size(341, 23);
            this.BC.TabIndex = 15;
            this.BC.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.BC.Value = 83;
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
            this.CancelBTN.Click += new System.EventHandler(this.CancelBTN_Click);
            // 
            // ColorPick
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(388, 333);
            this.Controls.Add(this.BC);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.RC);
            this.Controls.Add(this.BT);
            this.Controls.Add(this.GT);
            this.Controls.Add(this.RT);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BT;
        private System.Windows.Forms.Label GT;
        private System.Windows.Forms.Label RT;
        private Guna.UI2.WinForms.Guna2TrackBar RC;
        private Guna.UI2.WinForms.Guna2TrackBar BC;
        private Guna.UI2.WinForms.Guna2TrackBar GC;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button CancelBTN;
    }
}