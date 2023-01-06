using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number
{
    public partial class ColorPickerBox : Form
    {
        public ColorPickerBox()
        {
            InitializeComponent();
        }
        private void ColorPickerBox_Load(object sender, EventArgs e)
        {
            if (!ColorPicker.ColorPicker.Instans.Visible)
            {

                new ColorPicker.ColorPicker().Show();
            }
            else ColorPicker.ColorPicker.Instans.Visible = true;
        }

        private void ColorPickerBox_Click(object sender, EventArgs e)
        {
            ColorPick.Instans.Visible = true;
            this.Close();
        }
    }
}
