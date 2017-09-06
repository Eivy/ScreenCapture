using System;
using System.Linq;
using System.Windows.Forms;

namespace ScreenCapture {
	/// <summary>設定画面クラス</summary>
	public partial class FormConfig : Form {

		public FormConfig(Config c) {
			InitializeComponent();
			dir.Text = c.Dir;
			fileName.Text = c.FileName;
			switch(c.Type) {
				case "bmp":
					bmp.Checked = true;
					break;
				case "gif":
					gif.Checked = true;
					break;
				default:
					jpg.Checked = true;
					break;
			}
			triggers.Items.Clear();
			foreach(uint i in c.Keys) {
				triggers.Items.Add(i);
			}
			displayNum.Items.AddRange(Screen.AllScreens.Length == 1 ? new[] { "All" } : new[] { "All" }.Union(Enumerable.Range(1, Screen.AllScreens.Length).Select(o => o.ToString())).ToArray());
			displayNum.SelectedIndex = c.DisplayNum;
		}

		/// <summary>フォルダ選択ダイアログ表示</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void folderDialogButton_Click(object sender, EventArgs e) {
			folderBrowserDialog1.SelectedPath = dir.Text;
			if(folderBrowserDialog1.ShowDialog() != DialogResult.OK) {
				return;
			}
			dir.Text = folderBrowserDialog1.SelectedPath;
		}

		/// <summary>Removeボタン押下</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <remarks>リストからアイテムを消す</remarks>
		private void triggerRemove_Click(object sender, EventArgs e) {
			foreach(int i in triggers.SelectedIndices.Cast<int>().Reverse()) {
				triggers.Items.RemoveAt(i);
			}
		}

		/// <summary>Addボタン押下</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <remarks>ダイアログを表示する</remarks>
		private void triggerAdd_Click_1(object sender, EventArgs e) {
			var k = (uint)new GetKey().ShowDialog();
			if(!triggers.Items.Contains(k)) {
				triggers.Items.Add(k);
			}
		}

		/// <summary>Saveボタン押下</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <remarks>Configを保存して閉じる</remarks>
		private void save_Click(object sender, EventArgs e) {
			Config.Write(new Config {
				Dir = dir.Text,
				FileName = fileName.Text,
				Keys = triggers.Items.Cast<uint>().ToArray(),
				DisplayNum = displayNum.SelectedIndex,
				Type = groupType.Controls.OfType<RadioButton>().Single(o => o.Checked).Name,
			});
			DialogResult = DialogResult.OK;
		}

	}
}
