
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
            this.borderRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.title_ShortKey = new System.Windows.Forms.Label();
            this.progress_Panel = new System.Windows.Forms.Panel();
            this.cancel_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.default_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.save_BTN = new Guna.UI2.WinForms.Guna2Button();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.loadData_Key = new Guna.UI2.WinForms.Guna2Button();
            this.loadData_Text = new System.Windows.Forms.Label();
            this.saveData_Key = new Guna.UI2.WinForms.Guna2Button();
            this.saveData_Text = new System.Windows.Forms.Label();
            this.autoCounter_Key = new Guna.UI2.WinForms.Guna2Button();
            this.autoCounter_Text = new System.Windows.Forms.Label();
            this.compress_Key = new Guna.UI2.WinForms.Guna2Button();
            this.compress_Text = new System.Windows.Forms.Label();
            this.clear_Key = new Guna.UI2.WinForms.Guna2Button();
            this.clear_Text = new System.Windows.Forms.Label();
            this.add_Text = new System.Windows.Forms.Label();
            this.add_Key = new Guna.UI2.WinForms.Guna2Button();
            this.progress_Panel.SuspendLayout();
            this.table.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderRadius
            // 
            this.borderRadius.BorderRadius = 12;
            this.borderRadius.TargetControl = this;
            // 
            // title_ShortKey
            // 
            this.title_ShortKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_ShortKey.Font = new System.Drawing.Font("Vazir", 20F);
            this.title_ShortKey.Location = new System.Drawing.Point(0, 0);
            this.title_ShortKey.Name = "title_ShortKey";
            this.title_ShortKey.Size = new System.Drawing.Size(525, 53);
            this.title_ShortKey.TabIndex = 1;
            this.title_ShortKey.Text = "صفحه میانبر ها";
            this.title_ShortKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_ShortKey.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // progress_Panel
            // 
            this.progress_Panel.Controls.Add(this.cancel_BTN);
            this.progress_Panel.Controls.Add(this.default_BTN);
            this.progress_Panel.Controls.Add(this.save_BTN);
            this.progress_Panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progress_Panel.Location = new System.Drawing.Point(0, 342);
            this.progress_Panel.Name = "progress_Panel";
            this.progress_Panel.Size = new System.Drawing.Size(525, 83);
            this.progress_Panel.TabIndex = 4;
            // 
            // cancel_BTN
            // 
            this.cancel_BTN.CheckedState.Parent = this.cancel_BTN;
            this.cancel_BTN.CustomImages.Parent = this.cancel_BTN;
            this.cancel_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.cancel_BTN.FillColor = System.Drawing.Color.Empty;
            this.cancel_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.cancel_BTN.ForeColor = System.Drawing.Color.White;
            this.cancel_BTN.HoverState.Parent = this.cancel_BTN;
            this.cancel_BTN.Image = global::Number.Properties.Resources.cancel;
            this.cancel_BTN.Location = new System.Drawing.Point(2, 0);
            this.cancel_BTN.Name = "cancel_BTN";
            this.cancel_BTN.ShadowDecoration.Parent = this.cancel_BTN;
            this.cancel_BTN.Size = new System.Drawing.Size(177, 83);
            this.cancel_BTN.TabIndex = 5;
            this.cancel_BTN.Text = "انصراف";
            this.cancel_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.cancel_BTN.Click += new System.EventHandler(this.Cancel_BTN_Click);
            this.cancel_BTN.MouseEnter += new System.EventHandler(this.Cancel_BTN_MouseEnter);
            this.cancel_BTN.MouseLeave += new System.EventHandler(this.Cancel_BTN_MouseLeave);
            // 
            // default_BTN
            // 
            this.default_BTN.CheckedState.Parent = this.default_BTN;
            this.default_BTN.CustomImages.Parent = this.default_BTN;
            this.default_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.default_BTN.FillColor = System.Drawing.Color.Empty;
            this.default_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.default_BTN.ForeColor = System.Drawing.Color.White;
            this.default_BTN.HoverState.Parent = this.default_BTN;
            this.default_BTN.Image = global::Number.Properties.Resources.undo;
            this.default_BTN.Location = new System.Drawing.Point(179, 0);
            this.default_BTN.Name = "default_BTN";
            this.default_BTN.ShadowDecoration.Parent = this.default_BTN;
            this.default_BTN.Size = new System.Drawing.Size(183, 83);
            this.default_BTN.TabIndex = 4;
            this.default_BTN.Text = "حالت پیش فرض";
            this.default_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.default_BTN.Click += new System.EventHandler(this.Defult_BTN_Click);
            // 
            // save_BTN
            // 
            this.save_BTN.CheckedState.Parent = this.save_BTN;
            this.save_BTN.CustomImages.Parent = this.save_BTN;
            this.save_BTN.Dock = System.Windows.Forms.DockStyle.Right;
            this.save_BTN.FillColor = System.Drawing.Color.Empty;
            this.save_BTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.save_BTN.ForeColor = System.Drawing.Color.White;
            this.save_BTN.HoverState.Parent = this.save_BTN;
            this.save_BTN.Image = global::Number.Properties.Resources.save;
            this.save_BTN.Location = new System.Drawing.Point(362, 0);
            this.save_BTN.Name = "save_BTN";
            this.save_BTN.ShadowDecoration.Parent = this.save_BTN;
            this.save_BTN.Size = new System.Drawing.Size(163, 83);
            this.save_BTN.TabIndex = 3;
            this.save_BTN.Text = "ذخیره";
            this.save_BTN.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.save_BTN.Click += new System.EventHandler(this.Save_BTN_Click);
            // 
            // table
            // 
            this.table.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.table.ColumnCount = 2;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.table.Controls.Add(this.loadData_Key, 1, 5);
            this.table.Controls.Add(this.loadData_Text, 0, 5);
            this.table.Controls.Add(this.saveData_Key, 1, 4);
            this.table.Controls.Add(this.saveData_Text, 0, 4);
            this.table.Controls.Add(this.autoCounter_Key, 1, 3);
            this.table.Controls.Add(this.autoCounter_Text, 0, 3);
            this.table.Controls.Add(this.compress_Key, 1, 2);
            this.table.Controls.Add(this.compress_Text, 0, 2);
            this.table.Controls.Add(this.clear_Key, 1, 1);
            this.table.Controls.Add(this.clear_Text, 0, 1);
            this.table.Controls.Add(this.add_Text, 0, 0);
            this.table.Controls.Add(this.add_Key, 1, 0);
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
            // loadData_Key
            // 
            this.loadData_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.loadData_Key.CheckedState.Parent = this.loadData_Key;
            this.loadData_Key.CustomImages.Parent = this.loadData_Key;
            this.loadData_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadData_Key.FillColor = System.Drawing.Color.Empty;
            this.loadData_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.loadData_Key.ForeColor = System.Drawing.Color.White;
            this.loadData_Key.HoverState.Parent = this.loadData_Key;
            this.loadData_Key.Location = new System.Drawing.Point(4, 239);
            this.loadData_Key.Name = "loadData_Key";
            this.loadData_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loadData_Key.ShadowDecoration.Parent = this.loadData_Key;
            this.loadData_Key.Size = new System.Drawing.Size(360, 46);
            this.loadData_Key.TabIndex = 11;
            this.loadData_Key.Text = "Ctrl,O";
            this.loadData_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // loadData_Text
            // 
            this.loadData_Text.AutoSize = true;
            this.loadData_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadData_Text.Location = new System.Drawing.Point(371, 236);
            this.loadData_Text.Name = "loadData_Text";
            this.loadData_Text.Size = new System.Drawing.Size(150, 52);
            this.loadData_Text.TabIndex = 10;
            this.loadData_Text.Text = "برگرداندن شمارنده ها:";
            this.loadData_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveData_Key
            // 
            this.saveData_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.saveData_Key.CheckedState.Parent = this.saveData_Key;
            this.saveData_Key.CustomImages.Parent = this.saveData_Key;
            this.saveData_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveData_Key.FillColor = System.Drawing.Color.Empty;
            this.saveData_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.saveData_Key.ForeColor = System.Drawing.Color.White;
            this.saveData_Key.HoverState.Parent = this.saveData_Key;
            this.saveData_Key.Location = new System.Drawing.Point(4, 192);
            this.saveData_Key.Name = "saveData_Key";
            this.saveData_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveData_Key.ShadowDecoration.Parent = this.saveData_Key;
            this.saveData_Key.Size = new System.Drawing.Size(360, 40);
            this.saveData_Key.TabIndex = 9;
            this.saveData_Key.Text = "ctrl,S";
            this.saveData_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // saveData_Text
            // 
            this.saveData_Text.AutoSize = true;
            this.saveData_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveData_Text.Location = new System.Drawing.Point(371, 189);
            this.saveData_Text.Name = "saveData_Text";
            this.saveData_Text.Size = new System.Drawing.Size(150, 46);
            this.saveData_Text.TabIndex = 8;
            this.saveData_Text.Text = "ذخیره شمارنده ها:";
            this.saveData_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // autoCounter_Key
            // 
            this.autoCounter_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.autoCounter_Key.CheckedState.Parent = this.autoCounter_Key;
            this.autoCounter_Key.CustomImages.Parent = this.autoCounter_Key;
            this.autoCounter_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCounter_Key.FillColor = System.Drawing.Color.Empty;
            this.autoCounter_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.autoCounter_Key.ForeColor = System.Drawing.Color.White;
            this.autoCounter_Key.HoverState.Parent = this.autoCounter_Key;
            this.autoCounter_Key.Location = new System.Drawing.Point(4, 145);
            this.autoCounter_Key.Name = "autoCounter_Key";
            this.autoCounter_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.autoCounter_Key.ShadowDecoration.Parent = this.autoCounter_Key;
            this.autoCounter_Key.Size = new System.Drawing.Size(360, 40);
            this.autoCounter_Key.TabIndex = 7;
            this.autoCounter_Key.Text = "Shift,T";
            this.autoCounter_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // autoCounter_Text
            // 
            this.autoCounter_Text.AutoSize = true;
            this.autoCounter_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoCounter_Text.Location = new System.Drawing.Point(371, 142);
            this.autoCounter_Text.Name = "autoCounter_Text";
            this.autoCounter_Text.Size = new System.Drawing.Size(150, 46);
            this.autoCounter_Text.TabIndex = 6;
            this.autoCounter_Text.Text = "شمارش خودکار:";
            this.autoCounter_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // compress_Key
            // 
            this.compress_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.compress_Key.CheckedState.Parent = this.compress_Key;
            this.compress_Key.CustomImages.Parent = this.compress_Key;
            this.compress_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compress_Key.FillColor = System.Drawing.Color.Empty;
            this.compress_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.compress_Key.ForeColor = System.Drawing.Color.White;
            this.compress_Key.HoverState.Parent = this.compress_Key;
            this.compress_Key.Location = new System.Drawing.Point(4, 98);
            this.compress_Key.Name = "compress_Key";
            this.compress_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.compress_Key.ShadowDecoration.Parent = this.compress_Key;
            this.compress_Key.Size = new System.Drawing.Size(360, 40);
            this.compress_Key.TabIndex = 5;
            this.compress_Key.Text = "Shift,C";
            this.compress_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // compress_Text
            // 
            this.compress_Text.AutoSize = true;
            this.compress_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.compress_Text.Location = new System.Drawing.Point(371, 95);
            this.compress_Text.Name = "compress_Text";
            this.compress_Text.Size = new System.Drawing.Size(150, 46);
            this.compress_Text.TabIndex = 4;
            this.compress_Text.Text = "فشرده سازی:";
            this.compress_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_Key
            // 
            this.clear_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.clear_Key.CheckedState.Parent = this.clear_Key;
            this.clear_Key.CustomImages.Parent = this.clear_Key;
            this.clear_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_Key.FillColor = System.Drawing.Color.Empty;
            this.clear_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.clear_Key.ForeColor = System.Drawing.Color.White;
            this.clear_Key.HoverState.Parent = this.clear_Key;
            this.clear_Key.Location = new System.Drawing.Point(4, 51);
            this.clear_Key.Name = "clear_Key";
            this.clear_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clear_Key.ShadowDecoration.Parent = this.clear_Key;
            this.clear_Key.Size = new System.Drawing.Size(360, 40);
            this.clear_Key.TabIndex = 3;
            this.clear_Key.Text = "Alt,C";
            this.clear_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // clear_Text
            // 
            this.clear_Text.AutoSize = true;
            this.clear_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_Text.Location = new System.Drawing.Point(371, 48);
            this.clear_Text.Name = "clear_Text";
            this.clear_Text.Size = new System.Drawing.Size(150, 46);
            this.clear_Text.TabIndex = 2;
            this.clear_Text.Text = "پاک کردن:";
            this.clear_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_Text
            // 
            this.add_Text.AutoSize = true;
            this.add_Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Text.Location = new System.Drawing.Point(371, 1);
            this.add_Text.Name = "add_Text";
            this.add_Text.Size = new System.Drawing.Size(150, 46);
            this.add_Text.TabIndex = 0;
            this.add_Text.Text = "افزودن:";
            this.add_Text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_Key
            // 
            this.add_Key.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.add_Key.CheckedState.Parent = this.add_Key;
            this.add_Key.CustomImages.Parent = this.add_Key;
            this.add_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.add_Key.FillColor = System.Drawing.Color.Empty;
            this.add_Key.Font = new System.Drawing.Font("Vazir", 11F);
            this.add_Key.ForeColor = System.Drawing.Color.White;
            this.add_Key.HoverState.Parent = this.add_Key;
            this.add_Key.Location = new System.Drawing.Point(4, 4);
            this.add_Key.Name = "add_Key";
            this.add_Key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_Key.ShadowDecoration.Parent = this.add_Key;
            this.add_Key.Size = new System.Drawing.Size(360, 40);
            this.add_Key.TabIndex = 1;
            this.add_Key.Text = "Add";
            this.add_Key.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Short_KeyDown);
            // 
            // ShortKey
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(525, 425);
            this.Controls.Add(this.table);
            this.Controls.Add(this.progress_Panel);
            this.Controls.Add(this.title_ShortKey);
            this.Font = new System.Drawing.Font("Vazir", 12F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ShortKey";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "میانبر ها";
            this.Load += new System.EventHandler(this.ShortKey_Load);
            this.progress_Panel.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.table.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse borderRadius;
        private System.Windows.Forms.Label title_ShortKey;
        private System.Windows.Forms.Panel progress_Panel;
        private Guna.UI2.WinForms.Guna2Button cancel_BTN;
        private Guna.UI2.WinForms.Guna2Button default_BTN;
        private Guna.UI2.WinForms.Guna2Button save_BTN;
        private System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.Label autoCounter_Text;
        private System.Windows.Forms.Label compress_Text;
        private System.Windows.Forms.Label clear_Text;
        private System.Windows.Forms.Label add_Text;
        private System.Windows.Forms.Label saveData_Text;
        private System.Windows.Forms.Label loadData_Text;
        private Guna.UI2.WinForms.Guna2Button loadData_Key;
        private Guna.UI2.WinForms.Guna2Button saveData_Key;
        private Guna.UI2.WinForms.Guna2Button autoCounter_Key;
        private Guna.UI2.WinForms.Guna2Button compress_Key;
        private Guna.UI2.WinForms.Guna2Button clear_Key;
        private Guna.UI2.WinForms.Guna2Button add_Key;
    }
}