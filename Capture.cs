using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace ScreenCapture
{
	class Capture
	{

		[StructLayout(LayoutKind.Sequential)]
		private struct Rect
		{
			public int left;
			public int top;
			public int right;
			public int bottom;
		}
		[DllImport("user32.dll")]
		private static extern bool SetProcessDPIAware();
		[DllImport("user32.dll")]
		static extern IntPtr GetForegroundWindow();


		[DllImport("user32.dll")]
		static extern IntPtr GetWindowRect(IntPtr hWnd, out Rect rect);

		[DllImport("dwmapi.dll")]
		extern static int DwmGetWindowAttribute(IntPtr hWnd, int dwAttribute, out Rect rect, int cbAttribute);

		[DllImport("user32.dll")]
		static extern IntPtr GetWindowDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hdc);

		[DllImport("gdi32.dll")]
		static extern int BitBlt(IntPtr hDestDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

		Config config;
		bool alt = false;
		public Capture()
		{
			config = Config.Read();
			SetIcon();
			Hook.Register(Process);
		}

		void Process(uint msg, Hook.KBDLLHOOKSTRUCT o)
		{
			try
			{

				if(o.vkCode == 164) // Alt
				{
					if(msg == (uint)Stroke.SYSKEY_DOWN)
					{
						alt = true;
					}
					else
					{
						alt = false;
					}
					return;
				}

				if(msg != (uint)Stroke.KEY_UP && msg != (uint)Stroke.SYSKEY_UP)
				{
					return;
				}
				if(config.Keys.ToList().Contains(o.vkCode))
				{
					var bmp = Display.Image(config.DisplayNum);
					if(alt)
					{
						SetProcessDPIAware();
						Rect bounds, rect;
						// アクティブウィンドウを取得
						IntPtr hWnd = GetForegroundWindow();
						IntPtr winDC = GetWindowDC(hWnd);
						DwmGetWindowAttribute(hWnd, 9, out bounds, Marshal.SizeOf(typeof(Rect)));
						GetWindowRect(hWnd, out rect);


						var offsetX = bounds.left - rect.left;
						var offsetY = bounds.top - rect.top;


						Bitmap bitmap = new Bitmap(bounds.right - bounds.left, bounds.bottom - bounds.top);
						Graphics graphics = Graphics.FromImage(bitmap);
						IntPtr hDC = graphics.GetHdc();


						BitBlt(hDC, 0, 0, bitmap.Width, bitmap.Height, winDC, offsetX, offsetY, 13369376);
						graphics.ReleaseHdc(hDC);
						graphics.Dispose();
						ReleaseDC(hWnd, winDC);
						bitmap.Save(config.ImagePath, config.ImageFormat);
					}
					else
					{

						bmp.Save(config.ImagePath, config.ImageFormat);
					}
					bmp.Dispose();
				}
			}
			catch
			{
				MessageBox.Show("Error!!", Application.ProductName);
			}
		}

		void SetIcon()
		{
			var icon = new NotifyIcon
			{
				Icon = Properties.Resources.camera,
				Visible = true,
			};
			Application.ApplicationExit += (o, e) => icon.Dispose();

			var version = new ToolStripMenuItem
			{
				Text = "Ver. " + Application.ProductVersion,
				Enabled = false,
			};
			var settings = new ToolStripMenuItem { Text = "Settings..." };
			settings.Click += (o, e) =>
			{
				if(new FormConfig(config).ShowDialog() == DialogResult.OK)
				{
					config = Config.Read();
				}
			};
			var exit = new ToolStripMenuItem { Text = "Exit" };
			exit.Click += (o, e) => Application.Exit();
			icon.ContextMenuStrip = new ContextMenuStrip();
			icon.ContextMenuStrip.Items.AddRange(new[] { version, settings, exit });
		}

	}
}
