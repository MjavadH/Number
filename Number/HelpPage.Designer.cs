
namespace Number
{
    partial class HelpPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpPage));
            this.HelpPageTitle = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ExitBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.HelpText = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpPageTitle
            // 
            this.HelpPageTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpPageTitle.Font = new System.Drawing.Font("Vazir Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpPageTitle.Location = new System.Drawing.Point(0, 0);
            this.HelpPageTitle.Name = "HelpPageTitle";
            this.HelpPageTitle.Size = new System.Drawing.Size(498, 35);
            this.HelpPageTitle.TabIndex = 0;
            this.HelpPageTitle.Text = "راهنما";
            this.HelpPageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ExitBTN
            // 
            this.ExitBTN.CheckedState.Parent = this.ExitBTN;
            this.ExitBTN.CustomImages.Parent = this.ExitBTN;
            this.ExitBTN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ExitBTN.FillColor = System.Drawing.Color.Empty;
            this.ExitBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.ExitBTN.ForeColor = System.Drawing.Color.White;
            this.ExitBTN.HoverState.Parent = this.ExitBTN;
            this.ExitBTN.Image = global::Number.Properties.Resources.exit;
            this.ExitBTN.Location = new System.Drawing.Point(0, 427);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.ShadowDecoration.Parent = this.ExitBTN;
            this.ExitBTN.Size = new System.Drawing.Size(498, 73);
            this.ExitBTN.TabIndex = 13;
            this.ExitBTN.Text = "خروج";
            this.ExitBTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.ExitBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.HelpText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(498, 392);
            this.panel1.TabIndex = 14;
            // 
            // HelpText
            // 
            this.HelpText.AvoidGeometryAntialias = true;
            this.HelpText.BackColor = System.Drawing.Color.Transparent;
            this.HelpText.Dock = System.Windows.Forms.DockStyle.Top;
            this.HelpText.ForeColor = System.Drawing.Color.White;
            this.HelpText.IsContextMenuEnabled = false;
            this.HelpText.IsSelectionEnabled = false;
            this.HelpText.Location = new System.Drawing.Point(0, 0);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(483, 284);
            this.HelpText.TabIndex = 15;
            this.HelpText.Text = resources.GetString("HelpText.Text");
            this.HelpText.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.HelpText.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            // 
            // HelpPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(498, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HelpPageTitle);
            this.Controls.Add(this.ExitBTN);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "HelpPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.HelpPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelpPageTitle;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button ExitBTN;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel HelpText;
    }
}