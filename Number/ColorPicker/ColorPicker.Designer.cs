
namespace Number.ColorPicker
{
    partial class ColorPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorPicker));
            this.border_radius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.color_Timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.color_preview = new Guna.UI2.WinForms.Guna2Panel();
            this.hexColor_Text = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // border_radius
            // 
            this.border_radius.BorderRadius = 8;
            this.border_radius.TargetControl = this;
            // 
            // color_Timer
            // 
            this.color_Timer.Enabled = true;
            this.color_Timer.Interval = 50;
            this.color_Timer.Tick += new System.EventHandler(this.Timer_color_Tick);
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.color_preview, 0, 0);
            this.tableLayout.Controls.Add(this.hexColor_Text, 1, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 1;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(150, 50);
            this.tableLayout.TabIndex = 2;
            // 
            // color_preview
            // 
            this.color_preview.BorderRadius = 5;
            this.color_preview.FillColor = System.Drawing.Color.DarkSlateGray;
            this.color_preview.Location = new System.Drawing.Point(3, 3);
            this.color_preview.Name = "color_preview";
            this.color_preview.ShadowDecoration.Parent = this.color_preview;
            this.color_preview.Size = new System.Drawing.Size(44, 44);
            this.color_preview.TabIndex = 0;
            // 
            // hexColor_Text
            // 
            this.hexColor_Text.AutoSize = true;
            this.hexColor_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexColor_Text.Font = new System.Drawing.Font("Vazir", 9.25F, System.Drawing.FontStyle.Bold);
            this.hexColor_Text.Location = new System.Drawing.Point(53, 0);
            this.hexColor_Text.Name = "hexColor_Text";
            this.hexColor_Text.Size = new System.Drawing.Size(94, 50);
            this.hexColor_Text.TabIndex = 1;
            this.hexColor_Text.Text = "#000000";
            this.hexColor_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(150, 50);
            this.Controls.Add(this.tableLayout);
            this.Font = new System.Drawing.Font("Vazir", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPicker";
            this.ShowInTaskbar = false;
            this.Text = "ColorPicker";
            this.TopMost = true;
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse border_radius;
        private System.Windows.Forms.Timer color_Timer;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private Guna.UI2.WinForms.Guna2Panel color_preview;
        private System.Windows.Forms.Label hexColor_Text;
    }
}