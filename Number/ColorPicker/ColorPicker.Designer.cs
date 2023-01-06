
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
            this.Timer_color = new System.Windows.Forms.Timer(this.components);
            this.TableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.Color_preview = new Guna.UI2.WinForms.Guna2Panel();
            this.Color_Hex = new System.Windows.Forms.Label();
            this.TableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // border_radius
            // 
            this.border_radius.BorderRadius = 8;
            this.border_radius.TargetControl = this;
            // 
            // Timer_color
            // 
            this.Timer_color.Enabled = true;
            this.Timer_color.Interval = 1;
            this.Timer_color.Tick += new System.EventHandler(this.Timer_color_Tick);
            // 
            // TableLayout
            // 
            this.TableLayout.ColumnCount = 2;
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.TableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Controls.Add(this.Color_preview, 0, 0);
            this.TableLayout.Controls.Add(this.Color_Hex, 1, 0);
            this.TableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayout.Location = new System.Drawing.Point(0, 0);
            this.TableLayout.Name = "TableLayout";
            this.TableLayout.RowCount = 1;
            this.TableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayout.Size = new System.Drawing.Size(150, 50);
            this.TableLayout.TabIndex = 2;
            // 
            // Color_preview
            // 
            this.Color_preview.BorderRadius = 5;
            this.Color_preview.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Color_preview.Location = new System.Drawing.Point(3, 3);
            this.Color_preview.Name = "Color_preview";
            this.Color_preview.ShadowDecoration.Parent = this.Color_preview;
            this.Color_preview.Size = new System.Drawing.Size(44, 44);
            this.Color_preview.TabIndex = 0;
            // 
            // Color_Hex
            // 
            this.Color_Hex.AutoSize = true;
            this.Color_Hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Color_Hex.Font = new System.Drawing.Font("Vazir", 9.25F, System.Drawing.FontStyle.Bold);
            this.Color_Hex.Location = new System.Drawing.Point(53, 0);
            this.Color_Hex.Name = "Color_Hex";
            this.Color_Hex.Size = new System.Drawing.Size(94, 50);
            this.Color_Hex.TabIndex = 1;
            this.Color_Hex.Text = "#000000";
            this.Color_Hex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorPicker
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(150, 50);
            this.Controls.Add(this.TableLayout);
            this.Font = new System.Drawing.Font("Vazir", 9.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ColorPicker";
            this.ShowInTaskbar = false;
            this.Text = "ColorPicker";
            this.TopMost = true;
            this.TableLayout.ResumeLayout(false);
            this.TableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse border_radius;
        private System.Windows.Forms.Timer Timer_color;
        private System.Windows.Forms.TableLayoutPanel TableLayout;
        private Guna.UI2.WinForms.Guna2Panel Color_preview;
        private System.Windows.Forms.Label Color_Hex;
    }
}