using System.Windows.Forms;

namespace ScreenCapture {
	static class MainClass {

		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			SetIcon();
			Capture();
			Application.Run();
		}

		static void Capture() {
			var c = Config.Read();
			Hook.Register(o => {
				try {
					if(c.Keys.Contains(o.vkCode)) {
						var bmp = Display.Image(c.DisplayNum);
						bmp.Save(c.ImagePath, c.ImageFormat);
						bmp.Dispose();
					}
				}
				catch {
					MessageBox.Show("Error!!", Application.ProductName);
				}
			});
		}

		static void SetIcon() {
			var icon = new NotifyIcon();
			icon.Icon = Properties.Resources.camera;
			icon.Visible = true;
			Application.ApplicationExit += (o, e) => icon.Dispose();
			var version = new ToolStripMenuItem {
				Text = "Ver. " + Application.ProductVersion,
				Enabled = false,
			};
			var exit = new ToolStripMenuItem { Text = "Exit" };
			exit.Click += (o, e) => Application.Exit();
			icon.ContextMenuStrip = new ContextMenuStrip();
			icon.ContextMenuStrip.Items.Add(version);
			icon.ContextMenuStrip.Items.Add(exit);
		}

	}
}
