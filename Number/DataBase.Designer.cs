
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
            this.addName = new System.Windows.Forms.Label();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.AddText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.lenTB = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lenDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.infBox = new System.Windows.Forms.CheckBox();
            this.AddBTN = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.NameTB = new System.Windows.Forms.TextBox();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.DeleteBTN = new Guna.UI2.WinForms.Guna2Button();
            this.EditeBTN = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.Timer(this.components);
            this.Animation = new Guna.UI2.WinForms.Guna2Transition();
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
            this.AddTitle.Size = new System.Drawing.Size(580, 32);
            this.AddTitle.TabIndex = 3;
            this.AddTitle.Text = "اضافه کردن شمارنده";
            this.AddTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NumberForm_MouseMove);
            // 
            // addName
            // 
            this.addName.AutoSize = true;
            this.Animation.SetDecoration(this.addName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.addName.ForeColor = System.Drawing.Color.White;
            this.addName.Location = new System.Drawing.Point(530, 46);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(36, 26);
            this.addName.TabIndex = 8;
            this.addName.Text = "نام:";
            // 
            // TextTB
            // 
            this.TextTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation.SetDecoration(this.TextTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.TextTB.Location = new System.Drawing.Point(154, 85);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(192, 33);
            this.TextTB.TabIndex = 2;
            // 
            // AddText
            // 
            this.AddText.AutoSize = true;
            this.Animation.SetDecoration(this.AddText, Guna.UI2.AnimatorNS.DecorationType.None);
            this.AddText.ForeColor = System.Drawing.Color.White;
            this.AddText.Location = new System.Drawing.Point(308, 46);
            this.AddText.Name = "AddText";
            this.AddText.Size = new System.Drawing.Size(43, 26);
            this.AddText.TabIndex = 8;
            this.AddText.Text = "متن:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.Animation.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "تعداد:";
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
            this.lenTB.Location = new System.Drawing.Point(12, 85);
            this.lenTB.Maximum = new decimal(new int[] {
            100000000,
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
            this.lenDB.Name = "lenDB";
            this.lenDB.ReadOnly = true;
            this.lenDB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lenDB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lenDB.Width = 135;
            // 
            // TextDB
            // 
            this.TextDB.HeaderText = "متن";
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
            // infBox
            // 
            this.infBox.AutoSize = true;
            this.Animation.SetDecoration(this.infBox, Guna.UI2.AnimatorNS.DecorationType.None);
            this.infBox.ForeColor = System.Drawing.Color.White;
            this.infBox.Location = new System.Drawing.Point(4, 124);
            this.infBox.Name = "infBox";
            this.infBox.Size = new System.Drawing.Size(128, 30);
            this.infBox.TabIndex = 4;
            this.infBox.Text = "بدون محدودیت";
            this.infBox.UseVisualStyleBackColor = true;
            this.infBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
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
            this.AddBTN.Location = new System.Drawing.Point(449, 142);
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
            // NameTB
            // 
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Animation.SetDecoration(this.NameTB, Guna.UI2.AnimatorNS.DecorationType.None);
            this.NameTB.Location = new System.Drawing.Point(369, 85);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(192, 33);
            this.NameTB.TabIndex = 2;
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
            this.DeleteBTN.Location = new System.Drawing.Point(12, 186);
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
            this.EditeBTN.Location = new System.Drawing.Point(137, 186);
            this.EditeBTN.Name = "EditeBTN";
            this.EditeBTN.ShadowDecoration.Parent = this.EditeBTN;
            this.EditeBTN.Size = new System.Drawing.Size(119, 47);
            this.EditeBTN.TabIndex = 5;
            this.EditeBTN.Text = "ویرایش";
            this.EditeBTN.Visible = false;
            this.EditeBTN.Click += new System.EventHandler(this.EditeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.Animation.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Vazir", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "لیست شمارنده های شما:";
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
            // DataBase
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(580, 519);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.EditeBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.AddBTN);
            this.Controls.Add(this.infBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lenTB);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddText);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.TextTB);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label addName;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Label AddText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.NumericUpDown lenTB;
        private System.Windows.Forms.CheckBox infBox;
        private Guna.UI2.WinForms.Guna2Button AddBTN;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.TextBox NameTB;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button DeleteBTN;
        private Guna.UI2.WinForms.Guna2Button EditeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Transition Animation;
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn lenDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueDB;
    }
}