using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScreenCapture {
	/// <summary>画面クラス</summary>
	static class Display {

		/// <summary>画面のサイズを取得します</summary>
		/// <returns>すべての画面が配置された状態ですべて収まるサイズ</returns>
		static Size WholeSize() {
			var size = new Size();
			foreach (var s in Screen.AllScreens) {
				var w = s.Bounds.Left + s.Bounds.Width;
				var h = s.Bounds.Top + s.Bounds.Height;
				size.Width = size.Width > w ? size.Width : w;
				size.Height = size.Height > h ? size.Height : h;
			}
			return size;
		}

		/// <summary>
		/// 画面をキャプチャした画像を取得します
		/// </summary>
		/// <returns>ディスプレイ設定で設定している配置での画面のキャプチャ画像</returns>
		public static Bitmap AllImage() {
			var size = WholeSize();
			var bmp = new Bitmap(size.Width, size.Height);
			var g = Graphics.FromImage(bmp);
			g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
			g.Dispose();
			return bmp;
		}

		/// <summary>
		/// 画面をキャプチャした画像を取得します
		/// </summary>
		/// <returns>プライマリ画面のキャプチャ画像</returns>
		public static Bitmap Image() {
			var size = Screen.PrimaryScreen.Bounds.Size;
			var bmp = new Bitmap(size.Width, size.Height);
			var g = Graphics.FromImage(bmp);
			g.CopyFromScreen(new Point(0, 0), new Point(0, 0), bmp.Size);
			g.Dispose();
			return bmp;
		}

		/// <summary>
		/// 画面をキャプチャした画像を取得します
		/// </summary>
		/// <param name="i">ディスプレイ設定での番号 0なら全画面</param>
		/// <returns>ディスプレイ設定で設定している番号の画面のキャプチャ画像</returns>
		public static Bitmap Image(int i) {
			if(i < 0 || Screen.AllScreens.Length < i - 1) {
				throw new ArgumentOutOfRangeException();
			}
			else if (i == 0) { // 0なら全画面
				return AllImage();
			}
			var screen = Screen.AllScreens[i - 1];
			var size = screen.Bounds.Size;
			var bmp = new Bitmap(size.Width, size.Height);
			var point = new Point(screen.Bounds.Left, screen.Bounds.Top);
			var g = Graphics.FromImage(bmp);
			g.CopyFromScreen(point, new Point(0, 0), bmp.Size);
			g.Dispose();
			return bmp;
		}

	}
}
