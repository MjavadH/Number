
namespace Number
{
    partial class DataBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBase));
            this.AddTitle = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.lenTB = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBTN = new Guna.UI2.WinForms.Guna2Button();
            this.EditeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Animation = new Guna.UI2.WinForms.Guna2Transition();
            this.SaveNumbers = new Guna.UI2.WinForms.Guna2Button();
            this.NameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.TextTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.infBox = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ReturnBTN = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.lenTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddTitle
            // 
            this.Animation.SetDecoration(this.AddTitle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddTitle.Font = new System.Drawing.Font("Vazir", 15F);
            this.AddTitle.ForeColor = System.Drawing.Color.White;
            this.AddTitle.Location = new System.Drawing.Point(0, 0);
            this.AddTitle.Name = "AddTitle";
            this.AddTitle.Size = new System.Drawing.Size(580, 44);
            this.AddTitle.TabIndex = 3;
            this.AddTitle.Text = "اضافه کردن شمارنده";
            this.AddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // ErrorText
            // 
            this.Animation.SetDecoration(this.ErrorText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ErrorText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(0, 444);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(302, 75);
            this.ErrorText.TabIndex = 10;
            this.ErrorText.Visible = false;
            this.ErrorText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // lenTB
            // 
            this.Animation.SetDecoration(this.lenTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lenTB.Location = new System.Drawing.Point(17, 47);
            this.lenTB.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.lenTB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lenTB.Name = "lenTB";
            this.lenTB.Size = new System.Drawing.Size(120, 33);
            this.lenTB.TabIndex = 3;
            this.lenTB.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameDB,
            this.lenDB,
            this.TextDB,
            this.ValueDB});
            this.Animation.SetDecoration(this.dataGridView1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 239);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 34;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(581, 202);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValidated);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // NameDB
            // 
            this.NameDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.NameDB.HeaderText = "نام";
            this.NameDB.Name = "NameDB";
            this.NameDB.ReadOnly = true;
            this.NameDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.NameDB.Width = 135;
            // 
            // lenDB
            // 
            this.lenDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lenDB.HeaderText = "تعداد";
            this.lenDB.MinimumWidth = 95;
            this.lenDB.Name = "lenDB";
            this.lenDB.ReadOnly = true;
            this.lenDB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lenDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lenDB.Width = 95;
            // 
            // TextDB
            // 
            this.TextDB.HeaderText = "متن";
            this.TextDB.MinimumWidth = 210;
            this.TextDB.Name = "TextDB";
            this.TextDB.ReadOnly = true;
            this.TextDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ValueDB
            // 
            this.ValueDB.HeaderText = "مقدار";
            this.ValueDB.Name = "ValueDB";
            this.ValueDB.ReadOnly = true;
            this.ValueDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddBTN
            // 
            this.AddBTN.AutoRoundedCorners = true;
            this.AddBTN.BackColor = System.Drawing.Color.Transparent;
            this.AddBTN.BorderColor = System.Drawing.Color.White;
            this.AddBTN.BorderRadius = 22;
            this.AddBTN.BorderThickness = 2;
            this.AddBTN.CheckedState.Parent = this.AddBTN;
            this.AddBTN.CustomImages.Parent = this.AddBTN;
            this.Animation.SetDecoration(this.AddBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddBTN.FillColor = System.Drawing.Color.Empty;
            this.AddBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.AddBTN.ForeColor = System.Drawing.Color.White;
            this.AddBTN.HoverState.Parent = this.AddBTN;
            this.AddBTN.Image = global::Number.Properties.Resources.insert_row;
            this.AddBTN.Location = new System.Drawing.Point(455, 96);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.ShadowDecoration.Parent = this.AddBTN;
            this.AddBTN.Size = new System.Drawing.Size(119, 47);
            this.AddBTN.TabIndex = 5;
            this.AddBTN.Text = "افزودن";
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 18;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Save
            // 
            this.Save.CheckedState.Parent = this.Save;
            this.Save.CustomImages.Parent = this.Save;
            this.Animation.SetDecoration(this.Save, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Save.FillColor = System.Drawing.Color.Empty;
            this.Save.Font = new System.Drawing.Font("Vazir", 12F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.HoverState.Parent = this.Save;
            this.Save.Image = global::Number.Properties.Resources.save;
            this.Save.Location = new System.Drawing.Point(448, 441);
            this.Save.Name = "Save";
            this.Save.ShadowDecoration.Parent = this.Save;
            this.Save.Size = new System.Drawing.Size(133, 78);
            this.Save.TabIndex = 13;
            this.Save.Text = "ذخیره";
            this.Save.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.CheckedState.Parent = this.Cancel;
            this.Cancel.CustomImages.Parent = this.Cancel;
            this.Animation.SetDecoration(this.Cancel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Cancel.FillColor = System.Drawing.Color.Empty;
            this.Cancel.Font = new System.Drawing.Font("Vazir", 12F);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.HoverState.Parent = this.Cancel;
            this.Cancel.Image = global::Number.Properties.Resources.cancel;
            this.Cancel.Location = new System.Drawing.Point(309, 441);
            this.Cancel.Name = "Cancel";
            this.Cancel.ShadowDecoration.Parent = this.Cancel;
            this.Cancel.Size = new System.Drawing.Size(133, 78);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "انصراف";
            this.Cancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            this.Cancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.Cancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.AutoRoundedCorners = true;
            this.DeleteBTN.BackColor = System.Drawing.Color.Transparent;
            this.DeleteBTN.BorderColor = System.Drawing.Color.White;
            this.DeleteBTN.BorderRadius = 22;
            this.DeleteBTN.BorderThickness = 2;
            this.DeleteBTN.CheckedState.Parent = this.DeleteBTN;
            this.DeleteBTN.CustomImages.Parent = this.DeleteBTN;
            this.Animation.SetDecoration(this.DeleteBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DeleteBTN.FillColor = System.Drawing.Color.Empty;
            this.DeleteBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.DeleteBTN.ForeColor = System.Drawing.Color.White;
            this.DeleteBTN.HoverState.Parent = this.DeleteBTN;
            this.DeleteBTN.Image = global::Number.Properties.Resources.delete_row;
            this.DeleteBTN.Location = new System.Drawing.Point(9, 133);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.ShadowDecoration.Parent = this.DeleteBTN;
            this.DeleteBTN.Size = new System.Drawing.Size(119, 47);
            this.DeleteBTN.TabIndex = 5;
            this.DeleteBTN.Text = "حذف";
            this.DeleteBTN.Visible = false;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // EditeBTN
            // 
            this.EditeBTN.AutoRoundedCorners = true;
            this.EditeBTN.BackColor = System.Drawing.Color.Transparent;
            this.EditeBTN.BorderColor = System.Drawing.Color.White;
            this.EditeBTN.BorderRadius = 22;
            this.EditeBTN.BorderThickness = 2;
            this.EditeBTN.CheckedState.Parent = this.EditeBTN;
            this.EditeBTN.CustomImages.Parent = this.EditeBTN;
            this.Animation.SetDecoration(this.EditeBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.EditeBTN.FillColor = System.Drawing.Color.Empty;
            this.EditeBTN.Font = new System.Drawing.Font("Vazir", 12F);
            this.EditeBTN.ForeColor = System.Drawing.Color.White;
            this.EditeBTN.HoverState.Parent = this.EditeBTN;
            this.EditeBTN.Image = global::Number.Properties.Resources.edit;
            this.EditeBTN.Location = new System.Drawing.Point(9, 186);
            this.EditeBTN.Name = "EditeBTN";
            this.EditeBTN.ShadowDecoration.Parent = this.EditeBTN;
            this.EditeBTN.Size = new System.Drawing.Size(119, 47);
            this.EditeBTN.TabIndex = 5;
            this.EditeBTN.Text = "ویرایش";
            this.EditeBTN.Visible = false;
            this.EditeBTN.Click += new System.EventHandler(this.EditeBTN_Click);
            // 
            // Time
            // 
            this.Time.Interval = 5000;
            this.Time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // Animation
            // 
            this.Animation.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.Animation.Cursor = null;
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
            animation1.TransparencyCoeff = 1F;
            this.Animation.DefaultAnimation = animation1;
            // 
            // SaveNumbers
            // 
            this.SaveNumbers.AutoRoundedCorners = true;
            this.SaveNumbers.BackColor = System.Drawing.Color.Transparent;
            this.SaveNumbers.BorderColor = System.Drawing.Color.White;
            this.SaveNumbers.BorderRadius = 22;
            this.SaveNumbers.BorderThickness = 2;
            this.SaveNumbers.CheckedState.Parent = this.SaveNumbers;
            this.SaveNumbers.CustomImages.Parent = this.SaveNumbers;
            this.Animation.SetDecoration(this.SaveNumbers, Guna.UI2.AnimatorNS.DecorationType.None);
            this.SaveNumbers.FillColor = System.Drawing.Color.Empty;
            this.SaveNumbers.Font = new System.Drawing.Font("Vazir", 11F);
            this.SaveNumbers.ForeColor = System.Drawing.Color.White;
            this.SaveNumbers.HoverState.Parent = this.SaveNumbers;
            this.SaveNumbers.Image = global::Number.Properties.Resources.save_as;
            this.SaveNumbers.Location = new System.Drawing.Point(412, 186);
            this.SaveNumbers.Name = "SaveNumbers";
            this.SaveNumbers.ShadowDecoration.Parent = this.SaveNumbers;
            this.SaveNumbers.Size = new System.Drawing.Size(162, 47);
            this.SaveNumbers.TabIndex = 5;
            this.SaveNumbers.Text = "ذخیره شمارنده ها";
            this.SaveNumbers.Click += new System.EventHandler(this.SaveData_Click);
            // 
            // NameTB
            // 
            this.NameTB.AutoSize = true;
            this.NameTB.BorderColor = System.Drawing.Color.White;
            this.NameTB.BorderRadius = 3;
            this.NameTB.BorderThickness = 2;
            this.NameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animation.SetDecoration(this.NameTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NameTB.DefaultText = "";
            this.NameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTB.DisabledState.Parent = this.NameTB;
            this.NameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTB.FocusedState.Parent = this.NameTB;
            this.NameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.NameTB.HoverState.Parent = this.NameTB;
            this.NameTB.Location = new System.Drawing.Point(372, 48);
            this.NameTB.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NameTB.Name = "NameTB";
            this.NameTB.PasswordChar = '\0';
            this.NameTB.PlaceholderText = "نام شمارنده";
            this.NameTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NameTB.SelectedText = "";
            this.NameTB.ShadowDecoration.Parent = this.NameTB;
            this.NameTB.Size = new System.Drawing.Size(389, 38);
            this.NameTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NameTB.TabIndex = 14;
            this.NameTB.TextChanged += new System.EventHandler(this.NameTB_TextChanged);
            // 
            // TextTB
            // 
            this.TextTB.AutoSize = true;
            this.TextTB.BorderColor = System.Drawing.Color.White;
            this.TextTB.BorderRadius = 3;
            this.TextTB.BorderThickness = 2;
            this.TextTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Animation.SetDecoration(this.TextTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextTB.DefaultText = "";
            this.TextTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTB.DisabledState.Parent = this.TextTB;
            this.TextTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextTB.FocusedState.Parent = this.TextTB;
            this.TextTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.TextTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.TextTB.HoverState.Parent = this.TextTB;
            this.TextTB.Location = new System.Drawing.Point(158, 48);
            this.TextTB.Margin = new System.Windows.Forms.Padding(6, 12, 6, 12);
            this.TextTB.Name = "TextTB";
            this.TextTB.PasswordChar = '\0';
            this.TextTB.PlaceholderText = "متن شمارنده";
            this.TextTB.SelectedText = "";
            this.TextTB.ShadowDecoration.Parent = this.TextTB;
            this.TextTB.Size = new System.Drawing.Size(389, 38);
            this.TextTB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TextTB.TabIndex = 14;
            // 
            // infBox
            // 
            this.infBox.Animated = true;
            this.infBox.AutoSize = true;
            this.infBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.infBox.CheckedState.BorderRadius = 0;
            this.infBox.CheckedState.BorderThickness = 0;
            this.infBox.CheckedState.FillColor = System.Drawing.Color.White;
            this.infBox.CheckMarkColor = System.Drawing.Color.Black;
            this.Animation.SetDecoration(this.infBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.infBox.ForeColor = System.Drawing.Color.White;
            this.infBox.Location = new System.Drawing.Point(9, 86);
            this.infBox.Name = "infBox";
            this.infBox.Size = new System.Drawing.Size(128, 30);
            this.infBox.TabIndex = 15;
            this.infBox.Text = "بدون محدودیت";
            this.infBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.infBox.UncheckedState.BorderRadius = 0;
            this.infBox.UncheckedState.BorderThickness = 0;
            this.infBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.infBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ReturnBTN
            // 
            this.ReturnBTN.AutoRoundedCorners = true;
            this.ReturnBTN.BackColor = System.Drawing.Color.Transparent;
            this.ReturnBTN.BorderColor = System.Drawing.Color.White;
            this.ReturnBTN.BorderRadius = 22;
            this.ReturnBTN.BorderThickness = 2;
            this.ReturnBTN.CheckedState.Parent = this.ReturnBTN;
            this.ReturnBTN.CustomImages.Parent = this.ReturnBTN;
            this.Animation.SetDecoration(this.ReturnBTN, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ReturnBTN.FillColor = System.Drawing.Color.Empty;
            this.ReturnBTN.Font = new System.Drawing.Font("Vazir", 11F);
            this.ReturnBTN.ForeColor = System.Drawing.Color.White;
            this.ReturnBTN.HoverState.Parent = this.ReturnBTN;
            this.ReturnBTN.Image = global::Number.Properties.Resources._return;
            this.ReturnBTN.Location = new System.Drawing.Point(244, 186);
            this.ReturnBTN.Name = "ReturnBTN";
            this.ReturnBTN.ShadowDecoration.Parent = this.ReturnBTN;
            this.ReturnBTN.Size = new System.Drawing.Size(162, 47);
            this.ReturnBTN.TabIndex = 17;
            this.ReturnBTN.Text = "برگرداندن شمارنده ها";
            this.ReturnBTN.Click += new System.EventHandler(this.ReturnBTN_Click);
            // 
            // DataBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(580, 519);
            this.Controls.Add(this.ReturnBTN);
            this.Controls.Add(this.infBox);
            this.Controls.Add(this.TextTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EditeBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.SaveNumbers);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lenTB);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.AddTitle);
            this.Animation.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Vazir", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "DataBase";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "افزودن شمارنده";
            this.Load += new System.EventHandler(this.DataBase_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.lenTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AddTitle;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.NumericUpDown lenTB;
        private Guna.UI2.WinForms.Guna2Button AddBTN;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button DeleteBTN;
        private Guna.UI2.WinForms.Guna2Button EditeBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Transition Animation;
        private System.Windows.Forms.Timer Time;
        private Guna.UI2.WinForms.Guna2Button SaveNumbers;
        private Guna.UI2.WinForms.Guna2TextBox TextTB;
        private Guna.UI2.WinForms.Guna2TextBox NameTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDB;
        private Guna.UI2.WinForms.Guna2CheckBox infBox;
        private Guna.UI2.WinForms.Guna2Button ReturnBTN;
    }
}