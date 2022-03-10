
namespace Number
{
    partial class NumberForm
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
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumberForm));
            this.NumberT = new System.Windows.Forms.Label();
            this.MenuBar = new System.Windows.Forms.Panel();
            this.counter = new Guna.UI2.WinForms.Guna2Button();
            this.Compressbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Setting = new Guna.UI2.WinForms.Guna2Button();
            this.Help = new Guna.UI2.WinForms.Guna2Button();
            this.Clear = new Guna.UI2.WinForms.Guna2Button();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.counter_Status = new System.Windows.Forms.Label();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.MenuBTN = new Guna.UI2.WinForms.Guna2Button();
            this.min = new Guna.UI2.WinForms.Guna2Button();
            this.exit = new Guna.UI2.WinForms.Guna2Button();
            this.TextBox = new System.Windows.Forms.Label();
            this.TextLen = new System.Windows.Forms.Label();
            this.NumberLeftP = new System.Windows.Forms.ProgressBar();
            this.MenuListP = new System.Windows.Forms.Panel();
            this.DropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.counter_Timer = new System.Windows.Forms.Timer(this.components);
            this.AnimationMenu = new Guna.UI2.WinForms.Guna2Transition();
            this.splashScreen1 = new Number.SplashScreen();
            this.MenuBar.SuspendLayout();
            this.MenuListP.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberT
            // 
            this.NumberT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AnimationMenu.SetDecoration(this.NumberT, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.NumberT, "NumberT");
            this.NumberT.Name = "NumberT";
            this.NumberT.SizeChanged += new System.EventHandler(this.NumberT_SizeChanged);
            this.NumberT.Click += new System.EventHandler(this.AddT_Click);
            this.NumberT.DoubleClick += new System.EventHandler(this.NumberT_DoubleClick);
            this.NumberT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // MenuBar
            // 
            this.MenuBar.Controls.Add(this.counter);
            this.MenuBar.Controls.Add(this.Compressbtn);
            this.MenuBar.Controls.Add(this.Setting);
            this.MenuBar.Controls.Add(this.Help);
            this.MenuBar.Controls.Add(this.Clear);
            this.MenuBar.Controls.Add(this.add);
            this.MenuBar.Controls.Add(this.counter_Status);
            this.AnimationMenu.SetDecoration(this.MenuBar, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.MenuBar, "MenuBar");
            this.MenuBar.Name = "MenuBar";
            // 
            // counter
            // 
            this.counter.CheckedState.Parent = this.counter;
            this.counter.CustomImages.Parent = this.counter;
            this.AnimationMenu.SetDecoration(this.counter, Guna.UI2.AnimatorNS.DecorationType.None);
            this.counter.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.counter, "counter");
            this.counter.ForeColor = System.Drawing.Color.White;
            this.counter.HoverState.Parent = this.counter;
            this.counter.Image = global::Number.Properties.Resources.counter;
            this.counter.ImageSize = new System.Drawing.Size(44, 44);
            this.counter.Name = "counter";
            this.counter.ShadowDecoration.Parent = this.counter;
            this.ToolTips.SetToolTip(this.counter, resources.GetString("counter.ToolTip"));
            this.counter.Click += new System.EventHandler(this.counter_Click);
            // 
            // Compressbtn
            // 
            this.Compressbtn.CheckedState.Parent = this.Compressbtn;
            this.Compressbtn.CustomImages.Parent = this.Compressbtn;
            this.AnimationMenu.SetDecoration(this.Compressbtn, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Compressbtn.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.Compressbtn, "Compressbtn");
            this.Compressbtn.ForeColor = System.Drawing.Color.White;
            this.Compressbtn.HoverState.Parent = this.Compressbtn;
            this.Compressbtn.Image = global::Number.Properties.Resources.compress;
            this.Compressbtn.ImageSize = new System.Drawing.Size(44, 44);
            this.Compressbtn.Name = "Compressbtn";
            this.Compressbtn.ShadowDecoration.Parent = this.Compressbtn;
            this.ToolTips.SetToolTip(this.Compressbtn, resources.GetString("Compressbtn.ToolTip"));
            this.Compressbtn.Click += new System.EventHandler(this.Compressbtn_Click);
            // 
            // Setting
            // 
            this.Setting.CheckedState.Parent = this.Setting;
            this.Setting.CustomImages.Parent = this.Setting;
            this.AnimationMenu.SetDecoration(this.Setting, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Setting.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.Setting, "Setting");
            this.Setting.ForeColor = System.Drawing.Color.White;
            this.Setting.HoverState.Parent = this.Setting;
            this.Setting.Image = global::Number.Properties.Resources.settings;
            this.Setting.ImageSize = new System.Drawing.Size(44, 44);
            this.Setting.Name = "Setting";
            this.Setting.ShadowDecoration.Parent = this.Setting;
            this.ToolTips.SetToolTip(this.Setting, resources.GetString("Setting.ToolTip"));
            this.Setting.Click += new System.EventHandler(this.Setting_Click);
            // 
            // Help
            // 
            this.Help.CheckedState.Parent = this.Help;
            this.Help.CustomImages.Parent = this.Help;
            this.AnimationMenu.SetDecoration(this.Help, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Help.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.Help, "Help");
            this.Help.ForeColor = System.Drawing.Color.White;
            this.Help.HoverState.Parent = this.Help;
            this.Help.Image = global::Number.Properties.Resources.question_mark;
            this.Help.ImageSize = new System.Drawing.Size(44, 44);
            this.Help.Name = "Help";
            this.Help.ShadowDecoration.Parent = this.Help;
            this.ToolTips.SetToolTip(this.Help, resources.GetString("Help.ToolTip"));
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Clear
            // 
            this.Clear.CheckedState.Parent = this.Clear;
            this.Clear.CustomImages.Parent = this.Clear;
            this.AnimationMenu.SetDecoration(this.Clear, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Clear.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.Clear, "Clear");
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.HoverState.Parent = this.Clear;
            this.Clear.Image = global::Number.Properties.Resources.erase;
            this.Clear.ImageSize = new System.Drawing.Size(44, 44);
            this.Clear.Name = "Clear";
            this.Clear.ShadowDecoration.Parent = this.Clear;
            this.ToolTips.SetToolTip(this.Clear, resources.GetString("Clear.ToolTip"));
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // add
            // 
            this.add.CheckedState.Parent = this.add;
            this.add.CustomImages.Parent = this.add;
            this.AnimationMenu.SetDecoration(this.add, Guna.UI2.AnimatorNS.DecorationType.None);
            this.add.FillColor = System.Drawing.Color.Empty;
            resources.ApplyResources(this.add, "add");
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Image = global::Number.Properties.Resources.add_list;
            this.add.ImageSize = new System.Drawing.Size(44, 44);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.ToolTips.SetToolTip(this.add, resources.GetString("add.ToolTip"));
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // counter_Status
            // 
            resources.ApplyResources(this.counter_Status, "counter_Status");
            this.AnimationMenu.SetDecoration(this.counter_Status, Guna.UI2.AnimatorNS.DecorationType.None);
            this.counter_Status.ForeColor = System.Drawing.Color.Red;
            this.counter_Status.Name = "counter_Status";
            // 
            // ToolTips
            // 
            this.ToolTips.AutoPopDelay = 5000;
            this.ToolTips.InitialDelay = 500;
            this.ToolTips.ReshowDelay = 200;
            // 
            // MenuBTN
            // 
            this.MenuBTN.CheckedState.Parent = this.MenuBTN;
            this.MenuBTN.CustomImages.Parent = this.MenuBTN;
            this.AnimationMenu.SetDecoration(this.MenuBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.MenuBTN, "MenuBTN");
            this.MenuBTN.FillColor = System.Drawing.Color.Empty;
            this.MenuBTN.ForeColor = System.Drawing.Color.White;
            this.MenuBTN.HoverState.Parent = this.MenuBTN;
            this.MenuBTN.Image = global::Number.Properties.Resources.menu;
            this.MenuBTN.ImageSize = new System.Drawing.Size(44, 44);
            this.MenuBTN.Name = "MenuBTN";
            this.MenuBTN.ShadowDecoration.Parent = this.MenuBTN;
            this.ToolTips.SetToolTip(this.MenuBTN, resources.GetString("MenuBTN.ToolTip"));
            this.MenuBTN.Click += new System.EventHandler(this.Menu_Click);
            // 
            // min
            // 
            this.min.CheckedState.Parent = this.min;
            this.min.CustomImages.Parent = this.min;
            this.AnimationMenu.SetDecoration(this.min, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.min, "min");
            this.min.FillColor = System.Drawing.Color.Empty;
            this.min.ForeColor = System.Drawing.Color.White;
            this.min.HoverState.Parent = this.min;
            this.min.Image = global::Number.Properties.Resources.subtract;
            this.min.ImageSize = new System.Drawing.Size(44, 44);
            this.min.Name = "min";
            this.min.ShadowDecoration.Parent = this.min;
            this.ToolTips.SetToolTip(this.min, resources.GetString("min.ToolTip"));
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // exit
            // 
            this.exit.CheckedState.Parent = this.exit;
            this.exit.CustomImages.Parent = this.exit;
            this.AnimationMenu.SetDecoration(this.exit, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.exit, "exit");
            this.exit.FillColor = System.Drawing.Color.Empty;
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(75)))), ((int)(((byte)(66)))));
            this.exit.HoverState.Parent = this.exit;
            this.exit.Image = global::Number.Properties.Resources.delete;
            this.exit.ImageSize = new System.Drawing.Size(44, 44);
            this.exit.Name = "exit";
            this.exit.ShadowDecoration.Parent = this.exit;
            this.ToolTips.SetToolTip(this.exit, resources.GetString("exit.ToolTip"));
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // TextBox
            // 
            this.AnimationMenu.SetDecoration(this.TextBox, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.TextBox, "TextBox");
            this.TextBox.Name = "TextBox";
            this.TextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // TextLen
            // 
            this.AnimationMenu.SetDecoration(this.TextLen, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.TextLen, "TextLen");
            this.TextLen.Name = "TextLen";
            this.TextLen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // NumberLeftP
            // 
            this.NumberLeftP.AccessibleRole = System.Windows.Forms.AccessibleRole.ProgressBar;
            this.AnimationMenu.SetDecoration(this.NumberLeftP, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.NumberLeftP, "NumberLeftP");
            this.NumberLeftP.Name = "NumberLeftP";
            // 
            // MenuListP
            // 
            this.MenuListP.Controls.Add(this.MenuBar);
            this.MenuListP.Controls.Add(this.min);
            this.MenuListP.Controls.Add(this.MenuBTN);
            this.MenuListP.Controls.Add(this.exit);
            this.AnimationMenu.SetDecoration(this.MenuListP, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.MenuListP, "MenuListP");
            this.MenuListP.Name = "MenuListP";
            // 
            // DropDown
            // 
            this.DropDown.Animated = true;
            this.DropDown.BackColor = System.Drawing.Color.Transparent;
            this.AnimationMenu.SetDecoration(this.DropDown, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.DropDown, "DropDown");
            this.DropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DropDown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DropDown.FocusedState.Parent = this.DropDown;
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DropDown.HoverState.Parent = this.DropDown;
            this.DropDown.ItemsAppearance.Parent = this.DropDown;
            this.DropDown.Name = "DropDown";
            this.DropDown.ShadowDecoration.Color = System.Drawing.Color.White;
            this.DropDown.ShadowDecoration.Parent = this.DropDown;
            this.DropDown.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.DropDown.SelectedIndexChanged += new System.EventHandler(this.DropDown_SelectedIndexChanged);
            this.DropDown.Click += new System.EventHandler(this.DropDown_Click);
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // counter_Timer
            // 
            this.counter_Timer.Interval = 3000;
            this.counter_Timer.Tick += new System.EventHandler(this.counter_Timer_Tick);
            // 
            // AnimationMenu
            // 
            this.AnimationMenu.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.AnimationMenu.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimationMenu.DefaultAnimation = animation1;
            this.AnimationMenu.MaxAnimationTime = 1000;
            // 
            // splashScreen1
            // 
            this.splashScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.AnimationMenu.SetDecoration(this.splashScreen1, Guna.UI2.AnimatorNS.DecorationType.None);
            resources.ApplyResources(this.splashScreen1, "splashScreen1");
            this.splashScreen1.ForeColor = System.Drawing.Color.White;
            this.splashScreen1.Name = "splashScreen1";
            this.splashScreen1.DoubleClick += new System.EventHandler(this.NumberT_DoubleClick);
            // 
            // NumberForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ControlBox = false;
            this.Controls.Add(this.splashScreen1);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.TextLen);
            this.Controls.Add(this.NumberT);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.MenuListP);
            this.Controls.Add(this.NumberLeftP);
            this.AnimationMenu.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "NumberForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Activated += new System.EventHandler(this.NumberForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.NumberT_DoubleClick);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortKey_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.NumberForm_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.MenuListP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumberT;
        private System.Windows.Forms.Panel MenuBar;
        private System.Windows.Forms.ToolTip ToolTips;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Label TextLen;
        private System.Windows.Forms.ProgressBar NumberLeftP;
        private System.Windows.Forms.Panel MenuListP;
        private Guna.UI2.WinForms.Guna2ComboBox DropDown;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.Timer counter_Timer;
        private System.Windows.Forms.Label counter_Status;
        private Guna.UI2.WinForms.Guna2Button MenuBTN;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button counter;
        private Guna.UI2.WinForms.Guna2Button Compressbtn;
        private Guna.UI2.WinForms.Guna2Button Setting;
        private Guna.UI2.WinForms.Guna2Button Help;
        private Guna.UI2.WinForms.Guna2Button Clear;
        private Guna.UI2.WinForms.Guna2Button min;
        private Guna.UI2.WinForms.Guna2Button exit;
        private SplashScreen splashScreen1;
        private Guna.UI2.WinForms.Guna2Transition AnimationMenu;
    }
}

