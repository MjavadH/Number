
namespace Number
{
    partial class ShortKey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortKey));
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Title_ShortKey = new System.Windows.Forms.Label();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Progress_Panel = new System.Windows.Forms.Panel();
            this.Cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Default_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.Save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.AddPage_Key = new Guna.UI2.WinForms.Guna2Button();
            this.LoadData_Text = new System.Windows.Forms.Label();
            this.SettingPage_Key = new Guna.UI2.WinForms.Guna2Button();
            this.SaveData_Text = new System.Windows.Forms.Label();
            this.AutoCounter_Key = new Guna.UI2.WinForms.Guna2Button();
            this.AutoCounter_Text = new System.Windows.Forms.Label();
            this.Compress_Key = new Guna.UI2.WinForms.Guna2Button();
            this.Compress_Text = new System.Windows.Forms.Label();
            this.Clear_Key = new Guna.UI2.WinForms.Guna2Button();
            this.Clear_Text = new System.Windows.Forms.Label();
            this.Add_Text = new System.Windows.Forms.Label();
            this.Add_Key = new Guna.UI2.WinForms.Guna2Button();
            this.Progress_Panel.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 20;
            this.Elipse.TargetControl = this;
            // 
            // Title_ShortKey
            // 
            this.Title_ShortKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_ShortKey.Font = new System.Drawing.Font("Vazir", 20F);
            this.Title_ShortKey.Location = new System.Drawing.Point(0, 0);
            this.Title_ShortKey.Name = "Title_ShortKey";
            this.Title_ShortKey.Size = new System.Drawing.Size(525, 53);
            this.Title_ShortKey.TabIndex = 1;
            this.Title_ShortKey.Text = "صفحه میانبر ها";
            this.Title_ShortKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title_ShortKey.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // Progress_Panel
            // 
            this.Progress_Panel.Controls.Add(this.Cancel_BTN);
            this.Progress_Panel.Controls.Add(this.Default_BTN);
            this.Progress_Panel.Controls.Add(this.Save_BTN);
            this.Progress_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress_Panel.Location = new System.Drawing.Point(0, 342);
            this.Progress_Panel.Name = "Progress_Panel";
            this.Progress_Panel.Size = new System.Drawing.Size(525, 83);
            this.Progress_Panel.TabIndex = 4;
            // 
            // Cancel_BTN
            // 
            this.Cancel_BTN.CheckedState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.CustomImages.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Cancel_BTN.FillColor = System.Drawing.Color.Empty;
            this.Cancel_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.Cancel_BTN.HoverState.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Image = global::Number.Properties.Resources.cancel;
            this.Cancel_BTN.Location = new System.Drawing.Point(2, 0);
            this.Cancel_BTN.Name = "Cancel_BTN";
            this.Cancel_BTN.ShadowDecoration.Parent = this.Cancel_BTN;
            this.Cancel_BTN.Size = new System.Drawing.Size(177, 83);
            this.Cancel_BTN.TabIndex = 5;
            this.Cancel_BTN.Text = "انصراف";
            this.Cancel_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            this.Cancel_BTN.MouseEnter += new System.EventHandler(this.Cancel_BTN_MouseEnter);
            this.Cancel_BTN.MouseLeave += new System.EventHandler(this.Cancel_BTN_MouseLeave);
            // 
            // Default_BTN
            // 
            this.Default_BTN.CheckedState.Parent = this.Default_BTN;
            this.Default_BTN.CustomImages.Parent = this.Default_BTN;
            this.Default_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Default_BTN.FillColor = System.Drawing.Color.Empty;
            this.Default_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Default_BTN.ForeColor = System.Drawing.Color.White;
            this.Default_BTN.HoverState.Parent = this.Default_BTN;
            this.Default_BTN.Image = global::Number.Properties.Resources.undo;
            this.Default_BTN.Location = new System.Drawing.Point(179, 0);
            this.Default_BTN.Name = "Default_BTN";
            this.Default_BTN.ShadowDecoration.Parent = this.Default_BTN;
            this.Default_BTN.Size = new System.Drawing.Size(183, 83);
            this.Default_BTN.TabIndex = 4;
            this.Default_BTN.Text = "حالت پیش فرض";
            this.Default_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Default_BTN.Click += new System.EventHandler(this.Defult_BTN_Click);
            // 
            // Save_BTN
            // 
            this.Save_BTN.CheckedState.Parent = this.Save_BTN;
            this.Save_BTN.CustomImages.Parent = this.Save_BTN;
            this.Save_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Save_BTN.FillColor = System.Drawing.Color.Empty;
            this.Save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.Save_BTN.ForeColor = System.Drawing.Color.White;
            this.Save_BTN.HoverState.Parent = this.Save_BTN;
            this.Save_BTN.Image = global::Number.Properties.Resources.save;
            this.Save_BTN.Location = new System.Drawing.Point(362, 0);
            this.Save_BTN.Name = "Save_BTN";
            this.Save_BTN.ShadowDecoration.Parent = this.Save_BTN;
            this.Save_BTN.Size = new System.Drawing.Size(163, 83);
            this.Save_BTN.TabIndex = 3;
            this.Save_BTN.Text = "ذخیره";
            this.Save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // table
            // 
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.table.Controls.Add(this.AddPage_Key, 1, 5);
            this.table.Controls.Add(this.LoadData_Text, 0, 5);
            this.table.Controls.Add(this.SettingPage_Key, 1, 4);
            this.table.Controls.Add(this.SaveData_Text, 0, 4);
            this.table.Controls.Add(this.AutoCounter_Key, 1, 3);
            this.table.Controls.Add(this.AutoCounter_Text, 0, 3);
            this.table.Controls.Add(this.Compress_Key, 1, 2);
            this.table.Controls.Add(this.Compress_Text, 0, 2);
            this.table.Controls.Add(this.Clear_Key, 1, 1);
            this.table.Controls.Add(this.Clear_Text, 0, 1);
            this.table.Controls.Add(this.Add_Text, 0, 0);
            this.table.Controls.Add(this.Add_Key, 1, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 53);
            this.table.Name = "table";
            this.table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.table.RowCount = 6;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.table.Size = new System.Drawing.Size(525, 289);
            this.table.TabIndex = 5;
            this.table.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // AddPage_Key
            // 
            this.AddPage_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AddPage_Key.CheckedState.Parent = this.AddPage_Key;
            this.AddPage_Key.CustomImages.Parent = this.AddPage_Key;
            this.AddPage_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddPage_Key.FillColor = System.Drawing.Color.Empty;
            this.AddPage_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.AddPage_Key.HoverState.Parent = this.AddPage_Key;
            this.AddPage_Key.Location = new System.Drawing.Point(4, 239);
            this.AddPage_Key.Name = "AddPage_Key";
            this.AddPage_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddPage_Key.ShadowDecoration.Parent = this.AddPage_Key;
            this.AddPage_Key.Size = new System.Drawing.Size(360, 46);
            this.AddPage_Key.TabIndex = 11;
            this.AddPage_Key.Text = "Ctrl,O";
            this.AddPage_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // LoadData_Text
            // 
            this.LoadData_Text.AutoSize = true;
            this.LoadData_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadData_Text.Location = new System.Drawing.Point(371, 236);
            this.LoadData_Text.Name = "LoadData_Text";
            this.LoadData_Text.Size = new System.Drawing.Size(150, 52);
            this.LoadData_Text.TabIndex = 10;
            this.LoadData_Text.Text = "برگرداندن شمارنده ها:";
            this.LoadData_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingPage_Key
            // 
            this.SettingPage_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.SettingPage_Key.CheckedState.Parent = this.SettingPage_Key;
            this.SettingPage_Key.CustomImages.Parent = this.SettingPage_Key;
            this.SettingPage_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingPage_Key.FillColor = System.Drawing.Color.Empty;
            this.SettingPage_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.SettingPage_Key.HoverState.Parent = this.SettingPage_Key;
            this.SettingPage_Key.Location = new System.Drawing.Point(4, 192);
            this.SettingPage_Key.Name = "SettingPage_Key";
            this.SettingPage_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SettingPage_Key.ShadowDecoration.Parent = this.SettingPage_Key;
            this.SettingPage_Key.Size = new System.Drawing.Size(360, 40);
            this.SettingPage_Key.TabIndex = 9;
            this.SettingPage_Key.Text = "ctrl,S";
            this.SettingPage_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // SaveData_Text
            // 
            this.SaveData_Text.AutoSize = true;
            this.SaveData_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaveData_Text.Location = new System.Drawing.Point(371, 189);
            this.SaveData_Text.Name = "SaveData_Text";
            this.SaveData_Text.Size = new System.Drawing.Size(150, 46);
            this.SaveData_Text.TabIndex = 8;
            this.SaveData_Text.Text = "ذخیره شمارنده ها:";
            this.SaveData_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoCounter_Key
            // 
            this.AutoCounter_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.AutoCounter_Key.CheckedState.Parent = this.AutoCounter_Key;
            this.AutoCounter_Key.CustomImages.Parent = this.AutoCounter_Key;
            this.AutoCounter_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCounter_Key.FillColor = System.Drawing.Color.Empty;
            this.AutoCounter_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.AutoCounter_Key.HoverState.Parent = this.AutoCounter_Key;
            this.AutoCounter_Key.Location = new System.Drawing.Point(4, 145);
            this.AutoCounter_Key.Name = "AutoCounter_Key";
            this.AutoCounter_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AutoCounter_Key.ShadowDecoration.Parent = this.AutoCounter_Key;
            this.AutoCounter_Key.Size = new System.Drawing.Size(360, 40);
            this.AutoCounter_Key.TabIndex = 7;
            this.AutoCounter_Key.Text = "Shift,T";
            this.AutoCounter_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // AutoCounter_Text
            // 
            this.AutoCounter_Text.AutoSize = true;
            this.AutoCounter_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoCounter_Text.Location = new System.Drawing.Point(371, 142);
            this.AutoCounter_Text.Name = "AutoCounter_Text";
            this.AutoCounter_Text.Size = new System.Drawing.Size(150, 46);
            this.AutoCounter_Text.TabIndex = 6;
            this.AutoCounter_Text.Text = "شمارش خودکار:";
            this.AutoCounter_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compress_Key
            // 
            this.Compress_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Compress_Key.CheckedState.Parent = this.Compress_Key;
            this.Compress_Key.CustomImages.Parent = this.Compress_Key;
            this.Compress_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compress_Key.FillColor = System.Drawing.Color.Empty;
            this.Compress_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.Compress_Key.HoverState.Parent = this.Compress_Key;
            this.Compress_Key.Location = new System.Drawing.Point(4, 98);
            this.Compress_Key.Name = "Compress_Key";
            this.Compress_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Compress_Key.ShadowDecoration.Parent = this.Compress_Key;
            this.Compress_Key.Size = new System.Drawing.Size(360, 40);
            this.Compress_Key.TabIndex = 5;
            this.Compress_Key.Text = "Shift,C";
            this.Compress_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // Compress_Text
            // 
            this.Compress_Text.AutoSize = true;
            this.Compress_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Compress_Text.Location = new System.Drawing.Point(371, 95);
            this.Compress_Text.Name = "Compress_Text";
            this.Compress_Text.Size = new System.Drawing.Size(150, 46);
            this.Compress_Text.TabIndex = 4;
            this.Compress_Text.Text = "فشرده سازی:";
            this.Compress_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Clear_Key
            // 
            this.Clear_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Clear_Key.CheckedState.Parent = this.Clear_Key;
            this.Clear_Key.CustomImages.Parent = this.Clear_Key;
            this.Clear_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear_Key.FillColor = System.Drawing.Color.Empty;
            this.Clear_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.Clear_Key.HoverState.Parent = this.Clear_Key;
            this.Clear_Key.Location = new System.Drawing.Point(4, 51);
            this.Clear_Key.Name = "Clear_Key";
            this.Clear_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Clear_Key.ShadowDecoration.Parent = this.Clear_Key;
            this.Clear_Key.Size = new System.Drawing.Size(360, 40);
            this.Clear_Key.TabIndex = 3;
            this.Clear_Key.Text = "Alt,C";
            this.Clear_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // Clear_Text
            // 
            this.Clear_Text.AutoSize = true;
            this.Clear_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Clear_Text.Location = new System.Drawing.Point(371, 48);
            this.Clear_Text.Name = "Clear_Text";
            this.Clear_Text.Size = new System.Drawing.Size(150, 46);
            this.Clear_Text.TabIndex = 2;
            this.Clear_Text.Text = "پاک کردن:";
            this.Clear_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Text
            // 
            this.Add_Text.AutoSize = true;
            this.Add_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Text.Location = new System.Drawing.Point(371, 1);
            this.Add_Text.Name = "Add_Text";
            this.Add_Text.Size = new System.Drawing.Size(150, 46);
            this.Add_Text.TabIndex = 0;
            this.Add_Text.Text = "افزودن:";
            this.Add_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Add_Key
            // 
            this.Add_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Add_Key.CheckedState.Parent = this.Add_Key;
            this.Add_Key.CustomImages.Parent = this.Add_Key;
            this.Add_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Key.FillColor = System.Drawing.Color.Empty;
            this.Add_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.Add_Key.HoverState.Parent = this.Add_Key;
            this.Add_Key.Location = new System.Drawing.Point(4, 4);
            this.Add_Key.Name = "Add_Key";
            this.Add_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Add_Key.ShadowDecoration.Parent = this.Add_Key;
            this.Add_Key.Size = new System.Drawing.Size(360, 40);
            this.Add_Key.TabIndex = 1;
            this.Add_Key.Text = "Add";
            this.Add_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // ShortKey
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(525, 425);
            this.Controls.Add(this.table);
            this.Controls.Add(this.Progress_Panel);
            this.Controls.Add(this.Title_ShortKey);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShortKey";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "میانبر ها";
            this.Load += new System.EventHandler(this.ShortKey_Load);
            this.Progress_Panel.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private System.Windows.Forms.Label Title_ShortKey;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private System.Windows.Forms.Panel Progress_Panel;
        private Guna.UI2.WinForms.Guna2Button Cancel_BTN;
        private Guna.UI2.WinForms.Guna2Button Default_BTN;
        private Guna.UI2.WinForms.Guna2Button Save_BTN;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label AutoCounter_Text;
        private System.Windows.Forms.Label Compress_Text;
        private System.Windows.Forms.Label Clear_Text;
        private System.Windows.Forms.Label Add_Text;
        private System.Windows.Forms.Label SaveData_Text;
        private System.Windows.Forms.Label LoadData_Text;
        private Guna.UI2.WinForms.Guna2Button AddPage_Key;
        private Guna.UI2.WinForms.Guna2Button SettingPage_Key;
        private Guna.UI2.WinForms.Guna2Button AutoCounter_Key;
        private Guna.UI2.WinForms.Guna2Button Compress_Key;
        private Guna.UI2.WinForms.Guna2Button Clear_Key;
        private Guna.UI2.WinForms.Guna2Button Add_Key;
    }
}