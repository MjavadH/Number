
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
            this.borderRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.logo_Image = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.r_Text = new System.Windows.Forms.Label();
            this.e_Text = new System.Windows.Forms.Label();
            this.b_Text = new System.Windows.Forms.Label();
            this.m_Text = new System.Windows.Forms.Label();
            this.u_Text = new System.Windows.Forms.Label();
            this.n_Text = new System.Windows.Forms.Label();
            this.main_Timer = new System.Windows.Forms.Timer(this.components);
            this.text_Timer = new System.Windows.Forms.Timer(this.components);
            this.startApp_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo_Image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderRadius
            // 
            this.borderRadius.BorderRadius = 20;
            this.borderRadius.TargetControl = this;
            // 
            // logo_Image
            // 
            this.logo_Image.Cursor = System.Windows.Forms.Cursors.Default;
            this.logo_Image.Image = global::Number.Properties.Resources.numbers;
            this.logo_Image.InitialImage = null;
            this.logo_Image.Location = new System.Drawing.Point(70, 18);
            this.logo_Image.Name = "logo_Image";
            this.logo_Image.ShadowDecoration.Parent = this.logo_Image;
            this.logo_Image.Size = new System.Drawing.Size(256, 194);
            this.logo_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_Image.TabIndex = 0;
            this.logo_Image.TabStop = false;
            this.logo_Image.WaitOnLoad = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.r_Text);
            this.panel1.Controls.Add(this.e_Text);
            this.panel1.Controls.Add(this.b_Text);
            this.panel1.Controls.Add(this.m_Text);
            this.panel1.Controls.Add(this.u_Text);
            this.panel1.Controls.Add(this.n_Text);
            this.panel1.Location = new System.Drawing.Point(45, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 56);
            this.panel1.TabIndex = 1;
            // 
            // r_Text
            // 
            this.r_Text.AutoSize = true;
            this.r_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r_Text.Location = new System.Drawing.Point(218, 49);
            this.r_Text.Name = "r_Text";
            this.r_Text.Size = new System.Drawing.Size(34, 36);
            this.r_Text.TabIndex = 7;
            this.r_Text.Text = "R";
            // 
            // e_Text
            // 
            this.e_Text.AutoSize = true;
            this.e_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e_Text.Location = new System.Drawing.Point(192, 49);
            this.e_Text.Name = "e_Text";
            this.e_Text.Size = new System.Drawing.Size(30, 36);
            this.e_Text.TabIndex = 6;
            this.e_Text.Text = "E";
            // 
            // b_Text
            // 
            this.b_Text.AutoSize = true;
            this.b_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Text.Location = new System.Drawing.Point(164, 49);
            this.b_Text.Name = "b_Text";
            this.b_Text.Size = new System.Drawing.Size(33, 36);
            this.b_Text.TabIndex = 5;
            this.b_Text.Text = "B";
            // 
            // m_Text
            // 
            this.m_Text.AutoSize = true;
            this.m_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Text.Location = new System.Drawing.Point(126, 49);
            this.m_Text.Name = "m_Text";
            this.m_Text.Size = new System.Drawing.Size(41, 36);
            this.m_Text.TabIndex = 4;
            this.m_Text.Text = "M";
            // 
            // u_Text
            // 
            this.u_Text.AutoSize = true;
            this.u_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.u_Text.Location = new System.Drawing.Point(96, 49);
            this.u_Text.Name = "u_Text";
            this.u_Text.Size = new System.Drawing.Size(34, 36);
            this.u_Text.TabIndex = 3;
            this.u_Text.Text = "U";
            // 
            // n_Text
            // 
            this.n_Text.AutoSize = true;
            this.n_Text.Font = new System.Drawing.Font("Bauhaus 93", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_Text.Location = new System.Drawing.Point(64, 49);
            this.n_Text.Name = "n_Text";
            this.n_Text.Size = new System.Drawing.Size(34, 36);
            this.n_Text.TabIndex = 2;
            this.n_Text.Text = "N";
            // 
            // main_Timer
            // 
            this.main_Timer.Enabled = true;
            this.main_Timer.Interval = 1;
            this.main_Timer.Tick += new System.EventHandler(this.Main_Tick);
            // 
            // text_Timer
            // 
            this.text_Timer.Interval = 1;
            this.text_Timer.Tick += new System.EventHandler(this.Text_Tick);
            // 
            // startApp_Timer
            // 
            this.startApp_Timer.Interval = 1200;
            this.startApp_Timer.Tick += new System.EventHandler(this.StartApp_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.logo_Image);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "SplashScreen";
            this.Size = new System.Drawing.Size(409, 339);
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo_Image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse borderRadius;
        private Guna.UI2.WinForms.Guna2PictureBox logo_Image;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label r_Text;
        private System.Windows.Forms.Label e_Text;
        private System.Windows.Forms.Label b_Text;
        private System.Windows.Forms.Label m_Text;
        private System.Windows.Forms.Label u_Text;
        private System.Windows.Forms.Timer main_Timer;
        private System.Windows.Forms.Timer text_Timer;
        private System.Windows.Forms.Label n_Text;
        private System.Windows.Forms.Timer startApp_Timer;
    }
}
