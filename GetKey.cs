using System.Windows.Forms;

namespace ScreenCapture {
	public partial class GetKey : Form {

		public Keys Key { get; private set; }

		public GetKey() {
			InitializeComponent();
		}

		public new Keys ShowDialog() {
			base.ShowDialog();
			return Key;
		}

		private void GetKey_KeyUp(object sender, KeyEventArgs e) {
			Key = e.KeyData;
			DialogResult = DialogResult.OK;
		}

	}
}
