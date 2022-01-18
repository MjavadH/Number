
namespace Number
{
    partial class SplashScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RText = new System.Windows.Forms.Label();
            this.EText = new System.Windows.Forms.Label();
            this.BText = new System.Windows.Forms.Label();
            this.MText = new System.Windows.Forms.Label();
            this.UText = new System.Windows.Forms.Label();
            this.NText = new System.Windows.Forms.Label();
            this.Main = new System.Windows.Forms.Timer(this.components);
            this.TextTimer = new System.Windows.Forms.Timer(this.components);
            this.StartApp = new System.Windows.Forms.Timer(this.components);
            this.fakeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2PictureBox1.Image = global::Number.Properties.Resources.numbers;
            this.guna2PictureBox1.InitialImage = null;
            this.guna2PictureBox1.Location = new System.Drawing.Point(70, 18);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(256, 194);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RText);
            this.panel1.Controls.Add(this.EText);
            this.panel1.Controls.Add(this.BText);
            this.panel1.Controls.Add(this.MText);
            this.panel1.Controls.Add(this.UText);
            this.panel1.Controls.Add(this.NText);
            this.panel1.Location = new System.Drawing.Point(45, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 56);
            this.panel1.TabIndex = 1;
            // 
            // RText
            // 
            this.RText.AutoSize = true;
            this.RText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RText.Location = new System.Drawing.Point(218, 49);
            this.RText.Name = "RText";
            this.RText.Size = new System.Drawing.Size(34, 36);
            this.RText.TabIndex = 7;
            this.RText.Text = "R";
            // 
            // EText
            // 
            this.EText.AutoSize = true;
            this.EText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EText.Location = new System.Drawing.Point(192, 49);
            this.EText.Name = "EText";
            this.EText.Size = new System.Drawing.Size(30, 36);
            this.EText.TabIndex = 6;
            this.EText.Text = "E";
            // 
            // BText
            // 
            this.BText.AutoSize = true;
            this.BText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BText.Location = new System.Drawing.Point(164, 49);
            this.BText.Name = "BText";
            this.BText.Size = new System.Drawing.Size(33, 36);
            this.BText.TabIndex = 5;
            this.BText.Text = "B";
            // 
            // MText
            // 
            this.MText.AutoSize = true;
            this.MText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MText.Location = new System.Drawing.Point(126, 49);
            this.MText.Name = "MText";
            this.MText.Size = new System.Drawing.Size(41, 36);
            this.MText.TabIndex = 4;
            this.MText.Text = "M";
            // 
            // UText
            // 
            this.UText.AutoSize = true;
            this.UText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UText.Location = new System.Drawing.Point(96, 49);
            this.UText.Name = "UText";
            this.UText.Size = new System.Drawing.Size(34, 36);
            this.UText.TabIndex = 3;
            this.UText.Text = "U";
            // 
            // NText
            // 
            this.NText.AutoSize = true;
            this.NText.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NText.Location = new System.Drawing.Point(64, 49);
            this.NText.Name = "NText";
            this.NText.Size = new System.Drawing.Size(34, 36);
            this.NText.TabIndex = 2;
            this.NText.Text = "N";
            // 
            // Main
            // 
            this.Main.Enabled = true;
            this.Main.Interval = 1;
            this.Main.Tick += new System.EventHandler(this.Main_Tick);
            // 
            // TextTimer
            // 
            this.TextTimer.Interval = 1;
            this.TextTimer.Tick += new System.EventHandler(this.Text_Tick);
            // 
            // StartApp
            // 
            this.StartApp.Interval = 1200;
            this.StartApp.Tick += new System.EventHandler(this.StartApp_Tick);
            // 
            // fakeText
            // 
            this.fakeText.AutoSize = true;
            this.fakeText.Location = new System.Drawing.Point(14, 301);
            this.fakeText.Name = "fakeText";
            this.fakeText.Size = new System.Drawing.Size(0, 13);
            this.fakeText.TabIndex = 3;
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.fakeText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2PictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SplashScreen";
            this.Size = new System.Drawing.Size(409, 339);
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label RText;
        private System.Windows.Forms.Label EText;
        private System.Windows.Forms.Label BText;
        private System.Windows.Forms.Label MText;
        private System.Windows.Forms.Label UText;
        private System.Windows.Forms.Timer Main;
        private System.Windows.Forms.Timer TextTimer;
        private System.Windows.Forms.Label NText;
        private System.Windows.Forms.Timer StartApp;
        private System.Windows.Forms.Label fakeText;
    }
}
