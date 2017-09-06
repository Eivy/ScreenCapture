using System.Windows.Forms;

namespace ScreenCapture {
	static class MainClass {
		[System.STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var c = new Capture();
			Application.Run();
		}

	}
}
