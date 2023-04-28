
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
            this.defult_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.panel_down = new System.Windows.Forms.Panel();
            this.borderTop_panel = new System.Windows.Forms.Panel();
            this.exit_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.borderLeft_panel = new System.Windows.Forms.Panel();
            this.borderRight_panel = new System.Windows.Forms.Panel();
            this.borderBottom_panel = new System.Windows.Forms.Panel();
            this.borderRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel_down.SuspendLayout();
            this.borderTop_panel.SuspendLayout();
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
            // defult_BTN
            // 
            this.defult_BTN.BorderColor = System.Drawing.Color.White;
            this.defult_BTN.BorderRadius = 7;
            this.defult_BTN.BorderThickness = 1;
            this.defult_BTN.CheckedState.Parent = this.defult_BTN;
            this.defult_BTN.CustomImages.Parent = this.defult_BTN;
            this.defult_BTN.Dock = System.Windows.Forms.DockStyle.Left;
            this.defult_BTN.FillColor = System.Drawing.Color.Transparent;
            this.defult_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.defult_BTN.ForeColor = System.Drawing.Color.White;
            this.defult_BTN.HoverState.Parent = this.defult_BTN;
            this.defult_BTN.Image = global::Number.Properties.Resources._return;
            this.defult_BTN.Location = new System.Drawing.Point(5, 5);
            this.defult_BTN.Name = "defult_BTN";
            this.defult_BTN.ShadowDecoration.Parent = this.defult_BTN;
            this.defult_BTN.Size = new System.Drawing.Size(210, 40);
            this.defult_BTN.TabIndex = 0;
            this.defult_BTN.Text = "بازنشانی به حالت پیشفرض";
            this.defult_BTN.Click += new System.EventHandler(this.BTN_DefultN_Click);
            // 
            // save_BTN
            // 
            this.save_BTN.BorderColor = System.Drawing.Color.White;
            this.save_BTN.BorderRadius = 7;
            this.save_BTN.BorderThickness = 1;
            this.save_BTN.CheckedState.Parent = this.save_BTN;
            this.save_BTN.CustomImages.Parent = this.save_BTN;
            this.save_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_BTN.FillColor = System.Drawing.Color.Transparent;
            this.save_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.save_BTN.ForeColor = System.Drawing.Color.White;
            this.save_BTN.HoverState.Parent = this.save_BTN;
            this.save_BTN.Image = global::Number.Properties.Resources.save;
            this.save_BTN.Location = new System.Drawing.Point(237, 5);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.ShadowDecoration.Parent = this.save_BTN;
            this.save_BTN.Size = new System.Drawing.Size(210, 40);
            this.save_BTN.TabIndex = 1;
            this.save_BTN.Text = "بازنشانی شمارنده های ذخیره شده";
            this.save_BTN.Click += new System.EventHandler(this.BTN_SaveN_Click);
            // 
            // panel_down
            // 
            this.panel_down.Controls.Add(this.defult_BTN);
            this.panel_down.Controls.Add(this.save_BTN);
            this.panel_down.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_down.Location = new System.Drawing.Point(3, 125);
            this.panel_down.Name = "panel_down";
            this.panel_down.Padding = new System.Windows.Forms.Padding(5);
            this.panel_down.Size = new System.Drawing.Size(452, 50);
            this.panel_down.TabIndex = 3;
            // 
            // borderTop_panel
            // 
            this.borderTop_panel.Controls.Add(this.exit_BTN);
            this.borderTop_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.borderTop_panel.Location = new System.Drawing.Point(0, 0);
            this.borderTop_panel.Name = "borderTop_panel";
            this.borderTop_panel.Size = new System.Drawing.Size(458, 25);
            this.borderTop_panel.TabIndex = 4;
            this.borderTop_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // exit_BTN
            // 
            this.exit_BTN.CheckedState.Parent = this.exit_BTN;
            this.exit_BTN.CustomImages.Parent = this.exit_BTN;
            this.exit_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.exit_BTN.FillColor = System.Drawing.Color.Transparent;
            this.exit_BTN.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_BTN.ForeColor = System.Drawing.Color.White;
            this.exit_BTN.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.exit_BTN.HoverState.Parent = this.exit_BTN;
            this.exit_BTN.Image = global::Number.Properties.Resources.delete;
            this.exit_BTN.Location = new System.Drawing.Point(422, 0);
            this.exit_BTN.Name = "exit_BTN";
            this.exit_BTN.ShadowDecoration.Parent = this.exit_BTN;
            this.exit_BTN.Size = new System.Drawing.Size(36, 25);
            this.exit_BTN.TabIndex = 0;
            this.exit_BTN.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // borderLeft_panel
            // 
            this.borderLeft_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.borderLeft_panel.Location = new System.Drawing.Point(0, 25);
            this.borderLeft_panel.Name = "borderLeft_panel";
            this.borderLeft_panel.Size = new System.Drawing.Size(3, 150);
            this.borderLeft_panel.TabIndex = 5;
            // 
            // borderRight_panel
            // 
            this.borderRight_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.borderRight_panel.Location = new System.Drawing.Point(455, 25);
            this.borderRight_panel.Name = "borderRight_panel";
            this.borderRight_panel.Size = new System.Drawing.Size(3, 150);
            this.borderRight_panel.TabIndex = 6;
            // 
            // borderBottom_panel
            // 
            this.borderBottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.borderBottom_panel.Location = new System.Drawing.Point(0, 175);
            this.borderBottom_panel.Name = "borderBottom_panel";
            this.borderBottom_panel.Size = new System.Drawing.Size(458, 3);
            this.borderBottom_panel.TabIndex = 7;
            // 
            // borderRadius
            // 
            this.borderRadius.TargetControl = this;
            // 
            // ResetBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(458, 178);
            this.Controls.Add(this.label_Alert);
            this.Controls.Add(this.panel_down);
            this.Controls.Add(this.borderLeft_panel);
            this.Controls.Add(this.borderRight_panel);
            this.Controls.Add(this.borderBottom_panel);
            this.Controls.Add(this.borderTop_panel);
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
            this.borderTop_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Alert;
        private Guna.UI2.WinForms.Guna2Button defult_BTN;
        private Guna.UI2.WinForms.Guna2Button save_BTN;
        private System.Windows.Forms.Panel panel_down;
        private System.Windows.Forms.Panel borderTop_panel;
        private Guna.UI2.WinForms.Guna2Button exit_BTN;
        private System.Windows.Forms.Panel borderLeft_panel;
        private System.Windows.Forms.Panel borderRight_panel;
        private System.Windows.Forms.Panel borderBottom_panel;
        private Guna.UI2.WinForms.Guna2Elipse borderRadius;
    }
}