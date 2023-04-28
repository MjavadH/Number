using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number.ColorPicker
{
    public partial class ColorPicker : Form
    {
        public ColorPicker()
        {
            InitializeComponent();
        }
        static ColorPicker _CP;
        public static ColorPicker Instans
        {
            get
            {
                if (_CP == null)
                {
                    _CP = new ColorPicker();
                }
                return _CP;
            }
        }

        private void Timer_color_Tick(object sender, EventArgs e)
        {
            if (MousePosition.X > 1220 && (MousePosition.Y > 720))
            {
                this.Location = new Point(MousePosition.X - 150, MousePosition.Y - 50);
            }
            else if (MousePosition.Y > 720)
            {
                this.Location = new Point(MousePosition.X + 10, MousePosition.Y - 50);
            }
            else if (MousePosition.X > 1220)
            {
                this.Location = new Point(MousePosition.X - 150, MousePosition.Y + 20);
            }
            else
            {
                this.Location = new Point(MousePosition.X + 10, MousePosition.Y + 20);
            }
            hexColor_Text.Text = MousePosition.X + "," + MousePosition.Y;
        }

    }
}
