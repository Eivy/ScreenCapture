using System.Windows.Forms;
using System.Linq;

namespace ScreenCapture {
	class Capture {
		Config config;
		public Capture() {
			config = Config.Read();
			SetIcon();
			Hook.Register(Process);
		}

		void Process(uint msg, Hook.KBDLLHOOKSTRUCT o) {
			try {
				if(msg != (uint)Stroke.KEY_UP) {
					return;
				}
				if(config.Keys.ToList().Contains(o.vkCode)) {
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
			var settings = new ToolStripMenuItem { Text = "Settings..." };
			settings.Click += (o, e) => {
				if(new FormConfig(config).ShowDialog() == DialogResult.OK) {
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
