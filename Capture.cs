using System.Windows.Forms;

namespace ScreenCapture {
	class Capture {
		Config config;
		public Capture() {
			config = Config.Read();
			Hook.Register(Process);
		}

		void Process(Hook.KBDLLHOOKSTRUCT o) {
			try {
				if(config.Keys.Contains(o.vkCode)) {
					var bmp = Display.Image(config.DisplayNum);
					bmp.Save(config.ImagePath, config.ImageFormat);
					bmp.Dispose();
				}
			}
			catch {
				MessageBox.Show("Error!!", Application.ProductName);
			}
		}

		void SetIcon() {
			var icon = new NotifyIcon {
				Icon = Properties.Resources.camera,
				Visible = true,
			};
			Application.ApplicationExit += (o, e) => icon.Dispose();

			var version = new ToolStripMenuItem {
				Text = "Ver. " + Application.ProductVersion,
				Enabled = false,
			};
			var exit = new ToolStripMenuItem { Text = "Exit" };
			exit.Click += (o, e) => Application.Exit();
			icon.ContextMenuStrip = new ContextMenuStrip();
			icon.ContextMenuStrip.Items.AddRange(new[] { version, exit });
		}

	}
}
