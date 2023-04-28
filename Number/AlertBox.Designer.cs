
namespace Number
{
    partial class AlertBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertBox));
            this.alertText = new System.Windows.Forms.Label();
            this.close_BTN = new System.Windows.Forms.Button();
            this.show_Timer = new System.Windows.Forms.Timer(this.components);
            this.borderRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SuspendLayout();
            // 
            // alertText
            // 
            this.alertText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertText.Location = new System.Drawing.Point(0, 0);
            this.alertText.Name = "alertText";
            this.alertText.Size = new System.Drawing.Size(386, 98);
            this.alertText.TabIndex = 0;
            this.alertText.Text = "شمارنده $ به پایان رسید";
            this.alertText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // close_BTN
            // 
            this.close_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_BTN.FlatAppearance.BorderSize = 0;
            this.close_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_BTN.Image = global::Number.Properties.Resources.delete;
            this.close_BTN.Location = new System.Drawing.Point(351, 0);
            this.close_BTN.Name = "close_BTN";
            this.close_BTN.Size = new System.Drawing.Size(33, 35);
            this.close_BTN.TabIndex = 1;
            this.close_BTN.UseVisualStyleBackColor = false;
            this.close_BTN.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // show_Timer
            // 
            this.show_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // borderRadius
            // 
            this.borderRadius.TargetControl = this;
            // 
            // AlertBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(386, 98);
            this.Controls.Add(this.close_BTN);
            this.Controls.Add(this.alertText);
            this.Font = new System.Drawing.Font("Vazir", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "AlertBox";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "AlertBox";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AlertBox_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label alertText;
        private System.Windows.Forms.Button close_BTN;
        private System.Windows.Forms.Timer show_Timer;
        private Guna.UI2.WinForms.Guna2Elipse borderRadius;
    }
}