namespace ScreenCapture {
	partial class FormConfig {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.groupType = new System.Windows.Forms.GroupBox();
			this.gif = new System.Windows.Forms.RadioButton();
			this.bmp = new System.Windows.Forms.RadioButton();
			this.jpg = new System.Windows.Forms.RadioButton();
			this.fileName = new System.Windows.Forms.TextBox();
			this.lblFileName = new System.Windows.Forms.Label();
			this.lblDir = new System.Windows.Forms.Label();
			this.dir = new System.Windows.Forms.TextBox();
			this.displayNum = new System.Windows.Forms.ComboBox();
			this.lblDisplayNum = new System.Windows.Forms.Label();
			this.save = new System.Windows.Forms.Button();
			this.folderDialogButton = new System.Windows.Forms.Button();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.triggers = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.triggerRemove = new System.Windows.Forms.Button();
			this.triggerAdd = new System.Windows.Forms.Button();
			this.groupType.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupType
			// 
			this.groupType.Controls.Add(this.gif);
			this.groupType.Controls.Add(this.bmp);
			this.groupType.Controls.Add(this.jpg);
			this.groupType.Location = new System.Drawing.Point(12, 194);
			this.groupType.Name = "groupType";
			this.groupType.Size = new System.Drawing.Size(289, 78);
			this.groupType.TabIndex = 0;
			this.groupType.TabStop = false;
			this.groupType.Text = "Type";
			// 
			// gif
			// 
			this.gif.AutoSize = true;
			this.gif.Location = new System.Drawing.Point(6, 56);
			this.gif.Name = "gif";
			this.gif.Size = new System.Drawing.Size(41, 16);
			this.gif.TabIndex = 2;
			this.gif.Text = "GIF";
			this.gif.UseVisualStyleBackColor = true;
			// 
			// bmp
			// 
			this.bmp.AutoSize = true;
			this.bmp.Location = new System.Drawing.Point(6, 37);
			this.bmp.Name = "bmp";
			this.bmp.Size = new System.Drawing.Size(47, 16);
			this.bmp.TabIndex = 1;
			this.bmp.Text = "BMP";
			this.bmp.UseVisualStyleBackColor = true;
			// 
			// jpg
			// 
			this.jpg.AutoSize = true;
			this.jpg.Checked = true;
			this.jpg.Location = new System.Drawing.Point(6, 18);
			this.jpg.Name = "jpg";
			this.jpg.Size = new System.Drawing.Size(52, 16);
			this.jpg.TabIndex = 0;
			this.jpg.TabStop = true;
			this.jpg.Text = "JPEG";
			this.jpg.UseVisualStyleBackColor = true;
			// 
			// fileName
			// 
			this.fileName.Location = new System.Drawing.Point(94, 37);
			this.fileName.Name = "fileName";
			this.fileName.Size = new System.Drawing.Size(177, 19);
			this.fileName.TabIndex = 2;
			// 
			// lblFileName
			// 
			this.lblFileName.AutoSize = true;
			this.lblFileName.Location = new System.Drawing.Point(35, 40);
			this.lblFileName.Name = "lblFileName";
			this.lblFileName.Size = new System.Drawing.Size(53, 12);
			this.lblFileName.TabIndex = 3;
			this.lblFileName.Text = "FileName";
			// 
			// lblDir
			// 
			this.lblDir.AutoSize = true;
			this.lblDir.Location = new System.Drawing.Point(36, 15);
			this.lblDir.Name = "lblDir";
			this.lblDir.Size = new System.Drawing.Size(52, 12);
			this.lblDir.TabIndex = 5;
			this.lblDir.Text = "Directory";
			// 
			// dir
			// 
			this.dir.Location = new System.Drawing.Point(94, 12);
			this.dir.Name = "dir";
			this.dir.Size = new System.Drawing.Size(177, 19);
			this.dir.TabIndex = 4;
			// 
			// displayNum
			// 
			this.displayNum.FormattingEnabled = true;
			this.displayNum.Location = new System.Drawing.Point(94, 62);
			this.displayNum.Name = "displayNum";
			this.displayNum.Size = new System.Drawing.Size(66, 20);
			this.displayNum.TabIndex = 6;
			// 
			// lblDisplayNum
			// 
			this.lblDisplayNum.AutoSize = true;
			this.lblDisplayNum.Location = new System.Drawing.Point(12, 65);
			this.lblDisplayNum.Name = "lblDisplayNum";
			this.lblDisplayNum.Size = new System.Drawing.Size(76, 12);
			this.lblDisplayNum.TabIndex = 7;
			this.lblDisplayNum.Text = "TargetDisplay";
			// 
			// save
			// 
			this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.save.Location = new System.Drawing.Point(234, 282);
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(67, 24);
			this.save.TabIndex = 8;
			this.save.Text = "Save";
			this.save.UseVisualStyleBackColor = true;
			this.save.Click += new System.EventHandler(this.save_Click);
			// 
			// folderDialogButton
			// 
			this.folderDialogButton.Location = new System.Drawing.Point(277, 12);
			this.folderDialogButton.Name = "folderDialogButton";
			this.folderDialogButton.Size = new System.Drawing.Size(22, 19);
			this.folderDialogButton.TabIndex = 9;
			this.folderDialogButton.Text = "...";
			this.folderDialogButton.UseVisualStyleBackColor = true;
			this.folderDialogButton.Click += new System.EventHandler(this.folderDialogButton_Click);
			// 
			// triggers
			// 
			this.triggers.FormattingEnabled = true;
			this.triggers.ItemHeight = 12;
			this.triggers.Location = new System.Drawing.Point(6, 18);
			this.triggers.Name = "triggers";
			this.triggers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.triggers.Size = new System.Drawing.Size(196, 76);
			this.triggers.TabIndex = 10;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.triggerRemove);
			this.groupBox2.Controls.Add(this.triggerAdd);
			this.groupBox2.Controls.Add(this.triggers);
			this.groupBox2.Location = new System.Drawing.Point(12, 88);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(289, 100);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Triggers";
			// 
			// triggerRemove
			// 
			this.triggerRemove.Location = new System.Drawing.Point(208, 59);
			this.triggerRemove.Name = "triggerRemove";
			this.triggerRemove.Size = new System.Drawing.Size(75, 23);
			this.triggerRemove.TabIndex = 12;
			this.triggerRemove.Text = "Remove";
			this.triggerRemove.UseVisualStyleBackColor = true;
			this.triggerRemove.Click += new System.EventHandler(this.triggerRemove_Click);
			// 
			// triggerAdd
			// 
			this.triggerAdd.Location = new System.Drawing.Point(208, 30);
			this.triggerAdd.Name = "triggerAdd";
			this.triggerAdd.Size = new System.Drawing.Size(75, 23);
			this.triggerAdd.TabIndex = 11;
			this.triggerAdd.Text = "Add";
			this.triggerAdd.UseVisualStyleBackColor = true;
			this.triggerAdd.Click += new System.EventHandler(this.triggerAdd_Click_1);
			// 
			// FormConfig
			// 
			this.AcceptButton = this.save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(313, 318);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.folderDialogButton);
			this.Controls.Add(this.save);
			this.Controls.Add(this.lblDisplayNum);
			this.Controls.Add(this.displayNum);
			this.Controls.Add(this.lblDir);
			this.Controls.Add(this.dir);
			this.Controls.Add(this.lblFileName);
			this.Controls.Add(this.fileName);
			this.Controls.Add(this.groupType);
			this.Icon = global::ScreenCapture.Properties.Resources.camera;
			this.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormConfig";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ScreenCapture Settings";
			this.groupType.ResumeLayout(false);
			this.groupType.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupType;
		private System.Windows.Forms.RadioButton gif;
		private System.Windows.Forms.RadioButton bmp;
		private System.Windows.Forms.RadioButton jpg;
		private System.Windows.Forms.TextBox fileName;
		private System.Windows.Forms.Label lblFileName;
		private System.Windows.Forms.Label lblDir;
		private System.Windows.Forms.TextBox dir;
		private System.Windows.Forms.ComboBox displayNum;
		private System.Windows.Forms.Label lblDisplayNum;
		private System.Windows.Forms.Button save;
		private System.Windows.Forms.Button folderDialogButton;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.ListBox triggers;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button triggerRemove;
		private System.Windows.Forms.Button triggerAdd;
	}
}
