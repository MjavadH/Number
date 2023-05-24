using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Number.Properties;

namespace Number.ColorPicker
{
    public partial class ColorPicker : Form
    {
        private static ColorPicker _CP;
        private static Color mousePosition;
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
            private set => _CP = value;
        }
        [DllImport("gdi32.dll")]
        private static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);
        [DllImport("user32.dll")]
        private static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);
        private delegate IntPtr MouseHookDelegate(int code, IntPtr wParam, IntPtr lParam);
        private const int WH_MOUSE_LL = 14;
        private const int WM_LBUTTONDOWN = 0x0201;
        private static IntPtr _hookHandle = IntPtr.Zero;
        private static MouseHookDelegate _hookDelegate;
        [DllImport("user32.dll")]
        private static extern IntPtr SetWindowsHookEx(int idHook, MouseHookDelegate lpfn, IntPtr hMod, uint dwThreadId);
        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetProcessWorkingSetSize(IntPtr process,
            UIntPtr minimumWorkingSetSize, UIntPtr maximumWorkingSetSize);
        public ColorPicker()
        {
            InitializeComponent();
            Instans = this;
            _hookDelegate = MouseHookCallback;
            _hookHandle = SetWindowsHookEx(WH_MOUSE_LL, _hookDelegate, IntPtr.Zero, 0);
        }
        private static void minimizeMemory()
        {
            GC.Collect(GC.MaxGeneration);
            GC.WaitForPendingFinalizers();
            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle,
                (UIntPtr)0xFFFFFFFF, (UIntPtr)0xFFFFFFFF);
        }
        public void CaptureFromScreen() // گرفتن عکس از صفحه نمایش
        {
            IntPtr desktopHandle = GetDesktopWindow();
            IntPtr desktopDC = GetDC(desktopHandle);
            Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            IntPtr graphicsDC = graphics.GetHdc();
            BitBlt(graphicsDC, 0, 0, bitmap.Width, bitmap.Height, desktopDC, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt);

            graphics.ReleaseHdc(graphicsDC);
            ReleaseDC(desktopHandle, desktopDC);

            this.Invoke(new Action(() => GetPixel(bitmap))); // ارسال تصویر گرفته شده به تابع GetPixel

            graphics.Dispose();
        }

        private void GetPixel(Bitmap map)
        {
            mousePosition = map.GetPixel(MousePosition.X, MousePosition.Y); //گرفتن پیکسلی که ماوس روی آن است
            map.Dispose();
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
            new Thread(CaptureFromScreen).Start(); // گرفتن رنگ موقعیت ماوس
            color_preview.FillColor = mousePosition;
            hexColor_Text.Text = string.Format("#{0:X2}{1:X2}{2:X2}", mousePosition.R, mousePosition.G, mousePosition.B);
        }

        private static IntPtr MouseHookCallback(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code >= 0 && (int)wParam == WM_LBUTTONDOWN && Instans.color_Timer.Enabled)
            {
                ColorPick.Instans.SelectedColorPicker = mousePosition;
                Instans.Visible = false;
                Instans.color_Timer.Stop();
                UnhookWindowsHookEx(_hookHandle);
                _hookHandle = IntPtr.Zero;
                _hookDelegate = null;
            }
            return CallNextHookEx(_hookHandle, code, wParam, lParam);
        }
        public void ReLoad()
        {
            Instans = this;
            if (_hookHandle == IntPtr.Zero)
            {
                _hookDelegate = MouseHookCallback;
                _hookHandle = SetWindowsHookEx(WH_MOUSE_LL, _hookDelegate, IntPtr.Zero, 0);
            }
            Instans.color_Timer.Start();
            Instans.Visible = true;
        }
    }
}
