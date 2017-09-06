using System.Windows.Forms;

namespace ScreenCapture {
	static class MainClass {

		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var c = new Capture();
			Application.Run();
		}

	}
}
