
namespace Number
{
    partial class ResetBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResetBox));
            this.label_Alert = new System.Windows.Forms.Label();
            this.BTN_DefultN = new Guna.UI2.WinForms.Guna2Button();
            this.BTN_SaveN = new Guna.UI2.WinForms.Guna2Button();
            this.panel_down = new System.Windows.Forms.Panel();
            this.panel_top = new System.Windows.Forms.Panel();
            this.BTN_exit = new Guna.UI2.WinForms.Guna2Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel_right = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_down.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Alert
            // 
            this.label_Alert.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Alert.Location = new System.Drawing.Point(3, 25);
            this.label_Alert.Name = "label_Alert";
            this.label_Alert.Padding = new System.Windows.Forms.Padding(5);
            this.label_Alert.Size = new System.Drawing.Size(452, 100);
            this.label_Alert.TabIndex = 2;
            this.label_Alert.Text = "به دلیل مشکلاتی که برای فایل شمارنده ها پیش آمده امکان بارگذاری وجود ندارد آیا ما" +
    "یلید شمارنده ها بازنشانی شوند؟";
            // 
            // BTN_DefultN
            // 
            this.BTN_DefultN.AutoRoundedCorners = true;
            this.BTN_DefultN.BorderColor = System.Drawing.Color.White;
            this.BTN_DefultN.BorderRadius = 19;
            this.BTN_DefultN.BorderThickness = 1;
            this.BTN_DefultN.CheckedState.Parent = this.BTN_DefultN;
            this.BTN_DefultN.CustomImages.Parent = this.BTN_DefultN;
            this.BTN_DefultN.Dock = System.Windows.Forms.DockStyle.Left;
            this.BTN_DefultN.FillColor = System.Drawing.Color.Transparent;
            this.BTN_DefultN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_DefultN.ForeColor = System.Drawing.Color.White;
            this.BTN_DefultN.HoverState.Parent = this.BTN_DefultN;
            this.BTN_DefultN.Image = global::Number.Properties.Resources._return;
            this.BTN_DefultN.Location = new System.Drawing.Point(5, 5);
            this.BTN_DefultN.Name = "BTN_DefultN";
            this.BTN_DefultN.ShadowDecoration.Parent = this.BTN_DefultN;
            this.BTN_DefultN.Size = new System.Drawing.Size(210, 40);
            this.BTN_DefultN.TabIndex = 0;
            this.BTN_DefultN.Text = "بازنشانی به حالت پیشفرض";
            this.BTN_DefultN.Click += new System.EventHandler(this.BTN_DefultN_Click);
            // 
            // BTN_SaveN
            // 
            this.BTN_SaveN.AutoRoundedCorners = true;
            this.BTN_SaveN.BorderColor = System.Drawing.Color.White;
            this.BTN_SaveN.BorderRadius = 19;
            this.BTN_SaveN.BorderThickness = 1;
            this.BTN_SaveN.CheckedState.Parent = this.BTN_SaveN;
            this.BTN_SaveN.CustomImages.Parent = this.BTN_SaveN;
            this.BTN_SaveN.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_SaveN.FillColor = System.Drawing.Color.Transparent;
            this.BTN_SaveN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_SaveN.ForeColor = System.Drawing.Color.White;
            this.BTN_SaveN.HoverState.Parent = this.BTN_SaveN;
            this.BTN_SaveN.Image = global::Number.Properties.Resources.save;
            this.BTN_SaveN.Location = new System.Drawing.Point(237, 5);
            this.BTN_SaveN.Name = "BTN_SaveN";
            this.BTN_SaveN.ShadowDecoration.Parent = this.BTN_SaveN;
            this.BTN_SaveN.Size = new System.Drawing.Size(210, 40);
            this.BTN_SaveN.TabIndex = 1;
            this.BTN_SaveN.Text = "بازنشانی شمارنده های ذخیره شده";
            this.BTN_SaveN.Click += new System.EventHandler(this.BTN_SaveN_Click);
            // 
            // panel_down
            // 
            this.panel_down.Controls.Add(this.BTN_DefultN);
            this.panel_down.Controls.Add(this.BTN_SaveN);
            this.panel_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_down.Location = new System.Drawing.Point(3, 125);
            this.panel_down.Name = "panel_down";
            this.panel_down.Padding = new System.Windows.Forms.Padding(5);
            this.panel_down.Size = new System.Drawing.Size(452, 50);
            this.panel_down.TabIndex = 3;
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.BTN_exit);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(458, 25);
            this.panel_top.TabIndex = 4;
            this.panel_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // BTN_exit
            // 
            this.BTN_exit.CheckedState.Parent = this.BTN_exit;
            this.BTN_exit.CustomImages.Parent = this.BTN_exit;
            this.BTN_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_exit.FillColor = System.Drawing.Color.Transparent;
            this.BTN_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_exit.ForeColor = System.Drawing.Color.White;
            this.BTN_exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.BTN_exit.HoverState.Parent = this.BTN_exit;
            this.BTN_exit.Image = global::Number.Properties.Resources.delete;
            this.BTN_exit.Location = new System.Drawing.Point(422, 0);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.ShadowDecoration.Parent = this.BTN_exit;
            this.BTN_exit.Size = new System.Drawing.Size(36, 25);
            this.BTN_exit.TabIndex = 0;
            this.BTN_exit.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // panel_left
            // 
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 25);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(3, 150);
            this.panel_left.TabIndex = 5;
            // 
            // panel_right
            // 
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_right.Location = new System.Drawing.Point(455, 25);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(3, 150);
            this.panel_right.TabIndex = 6;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 175);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(458, 3);
            this.panel_bottom.TabIndex = 7;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ResetBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(458, 178);
            this.Controls.Add(this.label_Alert);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_bottom);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ResetBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بازنشانی شمارنده ها";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ResetBox_Load);
            this.panel_down.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Alert;
        private Guna.UI2.WinForms.Guna2Button BTN_DefultN;
        private Guna.UI2.WinForms.Guna2Button BTN_SaveN;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Panel panel_top;
        private Guna.UI2.WinForms.Guna2Button BTN_exit;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.Panel panel_bottom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}