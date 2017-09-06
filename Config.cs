using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.Environment;

namespace ScreenCapture {

	/// <summary>
	/// 設定ファイルクラス
	/// </summary>
	public class Config {

		/// <summary>画像のファイル名 実際のファイル名は"ファイル名yyyyMMdd_hhmmssff"形式になります</summary>
		public string FileName { get; set; } = "";

		/// <summary>画像出力先ディレクトリ</summary>
		public string Dir { get; set; } = GetFolderPath(SpecialFolder.Desktop);

		/// <summary>画像フォーマット(拡張子)</summary>
		public string Type { get; set; } = "jpg";

		/// <summary>キャプチャするディスプレイ番号 0なら全画面</summary>
		public int DisplayNum { get; set; }

		/// <summary>キャプチャのトリガーキー</summary>
		public List<uint> Keys { get; set; } = new List<uint> { 55 };


		static readonly string ConfigPath = GetParent(Application.ExecutablePath) + @"\" + Application.ProductName + ".config";
		/// <summary>画像ファイルのパスを取得します</summary>
		public string ImagePath {
			get {
				return Dir + @"\" + FileName + DateTime.Now.ToString("yyyyMMdd_HHmmssff") + "." + Type;
			}
		}

		/// <summary>画像のフォーマットを取得します</summary>
		public ImageFormat ImageFormat {
			get {
				switch(Type) {
					case "bmp":
						return ImageFormat.Bmp;
					case "gif":
						return ImageFormat.Gif;
					default:
						return ImageFormat.Jpeg;
				}
			}
		}

		/// <summary>設定を読み込みます</summary>
		/// <returns>読み込んだ設定</returns>
		public static Config Read() {
			if(!File.Exists(ConfigPath)) {
				return new Config();
			}

			Config c;
			var sz = new XmlSerializer(typeof(Config));
			using(var sr = new StreamReader(ConfigPath, new UTF8Encoding(false))) {
				c = (Config)sz.Deserialize(sr);
			}
			return c;
		}

		/// <summary>設定をファイルに書き出します</summary>
		/// <param name="c">書き出す設定</param>
		public static void Write(Config c) {
			var sz = new XmlSerializer(typeof(Config));
			using(var sw = new StreamWriter(ConfigPath, false, new UTF8Encoding(false))) {
				sz.Serialize(sw, c);
			}
		}

	}
}
