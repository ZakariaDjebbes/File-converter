namespace FileConverter
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.textFileConversionLog = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.textFileConvertProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.chooseTextFileButton = new MaterialSkin.Controls.MaterialButton();
			this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
			this.fileChosenNameLabel = new MaterialSkin.Controls.MaterialLabel();
			this.textFileConvertToComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.convertTextFileButton = new MaterialSkin.Controls.MaterialButton();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.convertTextFilesTitleLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.drawerImageList = new System.Windows.Forms.ImageList(this.components);
			this.textFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.textFileConversionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.materialTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.materialCard1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialTabControl1.ImageList = this.drawerImageList;
			this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new System.Drawing.Size(1029, 681);
			this.materialTabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.tableLayoutPanel4);
			this.tabPage1.Controls.Add(this.tableLayoutPanel3);
			this.tabPage1.Controls.Add(this.tableLayoutPanel2);
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.ImageKey = "text_icon";
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1021, 652);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Text Files";
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.AutoSize = true;
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.materialLabel3, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.textFileConversionLog, 0, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(36, 417);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.89007F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.10993F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(954, 227);
			this.tableLayoutPanel4.TabIndex = 10;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.Location = new System.Drawing.Point(3, 15);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(106, 19);
			this.materialLabel3.TabIndex = 0;
			this.materialLabel3.Text = "Conversion log";
			this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textFileConversionLog
			// 
			this.textFileConversionLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textFileConversionLog.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.textFileConversionLog.Location = new System.Drawing.Point(3, 52);
			this.textFileConversionLog.MaxLength = 0;
			this.textFileConversionLog.Multiline = true;
			this.textFileConversionLog.Name = "textFileConversionLog";
			this.textFileConversionLog.ReadOnly = true;
			this.textFileConversionLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textFileConversionLog.Size = new System.Drawing.Size(948, 172);
			this.textFileConversionLog.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.Controls.Add(this.materialLabel1, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.textFileConvertProgressBar, 0, 1);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(36, 312);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.12329F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.87671F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(954, 73);
			this.tableLayoutPanel3.TabIndex = 9;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new System.Drawing.Point(10, 10);
			this.materialLabel1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(145, 19);
			this.materialLabel1.TabIndex = 5;
			this.materialLabel1.Text = "Conversion progress";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textFileConvertProgressBar
			// 
			this.textFileConvertProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.textFileConvertProgressBar.Depth = 0;
			this.textFileConvertProgressBar.Location = new System.Drawing.Point(10, 58);
			this.textFileConvertProgressBar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
			this.textFileConvertProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
			this.textFileConvertProgressBar.Name = "textFileConvertProgressBar";
			this.textFileConvertProgressBar.Size = new System.Drawing.Size(934, 5);
			this.textFileConvertProgressBar.TabIndex = 6;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34591F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.65409F));
			this.tableLayoutPanel2.Controls.Add(this.chooseTextFileButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.materialCard1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.textFileConvertToComboBox, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.convertTextFileButton, 1, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 126);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.08072F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.91928F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(954, 180);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// chooseTextFileButton
			// 
			this.chooseTextFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chooseTextFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.chooseTextFileButton.Depth = 0;
			this.chooseTextFileButton.DrawShadows = true;
			this.chooseTextFileButton.HighEmphasis = true;
			this.chooseTextFileButton.Icon = null;
			this.chooseTextFileButton.Location = new System.Drawing.Point(201, 8);
			this.chooseTextFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 15);
			this.chooseTextFileButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.chooseTextFileButton.Name = "chooseTextFileButton";
			this.chooseTextFileButton.Size = new System.Drawing.Size(125, 36);
			this.chooseTextFileButton.TabIndex = 1;
			this.chooseTextFileButton.Text = "Choose a file";
			this.chooseTextFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.chooseTextFileButton.UseAccentColor = false;
			this.chooseTextFileButton.UseVisualStyleBackColor = true;
			this.chooseTextFileButton.Click += new System.EventHandler(this.ChooseTextFileButton_Click);
			// 
			// materialCard1
			// 
			this.materialCard1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialCard1.Controls.Add(this.fileChosenNameLabel);
			this.materialCard1.Depth = 0;
			this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialCard1.Location = new System.Drawing.Point(14, 75);
			this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
			this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialCard1.Name = "materialCard1";
			this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
			this.materialCard1.Size = new System.Drawing.Size(499, 84);
			this.materialCard1.TabIndex = 2;
			// 
			// fileChosenNameLabel
			// 
			this.fileChosenNameLabel.AutoSize = true;
			this.fileChosenNameLabel.Depth = 0;
			this.fileChosenNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fileChosenNameLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.fileChosenNameLabel.Location = new System.Drawing.Point(14, 14);
			this.fileChosenNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.fileChosenNameLabel.Name = "fileChosenNameLabel";
			this.fileChosenNameLabel.Size = new System.Drawing.Size(119, 19);
			this.fileChosenNameLabel.TabIndex = 2;
			this.fileChosenNameLabel.Text = "No File Chosen...";
			// 
			// textFileConvertToComboBox
			// 
			this.textFileConvertToComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textFileConvertToComboBox.AutoResize = false;
			this.textFileConvertToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.textFileConvertToComboBox.Depth = 0;
			this.textFileConvertToComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.textFileConvertToComboBox.DropDownHeight = 174;
			this.textFileConvertToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.textFileConvertToComboBox.DropDownWidth = 121;
			this.textFileConvertToComboBox.Enabled = false;
			this.textFileConvertToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.textFileConvertToComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.textFileConvertToComboBox.FormattingEnabled = true;
			this.textFileConvertToComboBox.Hint = "Convert to";
			this.textFileConvertToComboBox.IntegralHeight = false;
			this.textFileConvertToComboBox.ItemHeight = 43;
			this.textFileConvertToComboBox.Location = new System.Drawing.Point(577, 3);
			this.textFileConvertToComboBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
			this.textFileConvertToComboBox.MaxDropDownItems = 4;
			this.textFileConvertToComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.textFileConvertToComboBox.Name = "textFileConvertToComboBox";
			this.textFileConvertToComboBox.Size = new System.Drawing.Size(327, 49);
			this.textFileConvertToComboBox.TabIndex = 3;
			this.textFileConvertToComboBox.UseAccent = false;
			this.textFileConvertToComboBox.SelectedIndexChanged += new System.EventHandler(this.TextFileConvertToComboBox_SelectedIndexChanged);
			// 
			// convertTextFileButton
			// 
			this.convertTextFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.convertTextFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.convertTextFileButton.Depth = 0;
			this.convertTextFileButton.DrawShadows = true;
			this.convertTextFileButton.Enabled = false;
			this.convertTextFileButton.HighEmphasis = true;
			this.convertTextFileButton.Icon = null;
			this.convertTextFileButton.Location = new System.Drawing.Point(627, 80);
			this.convertTextFileButton.Margin = new System.Windows.Forms.Padding(100, 6, 100, 50);
			this.convertTextFileButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.convertTextFileButton.Name = "convertTextFileButton";
			this.convertTextFileButton.Size = new System.Drawing.Size(227, 36);
			this.convertTextFileButton.TabIndex = 4;
			this.convertTextFileButton.Text = "Convert file";
			this.convertTextFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.convertTextFileButton.UseAccentColor = false;
			this.convertTextFileButton.UseVisualStyleBackColor = true;
			this.convertTextFileButton.Click += new System.EventHandler(this.ConvertTextFileButton_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.convertTextFilesTitleLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.materialLabel2, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(39, 6);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.26087F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.73913F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 93);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// convertTextFilesTitleLabel
			// 
			this.convertTextFilesTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.convertTextFilesTitleLabel.AutoSize = true;
			this.convertTextFilesTitleLabel.Depth = 0;
			this.convertTextFilesTitleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.convertTextFilesTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			this.convertTextFilesTitleLabel.Location = new System.Drawing.Point(385, 3);
			this.convertTextFilesTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
			this.convertTextFilesTitleLabel.Name = "convertTextFilesTitleLabel";
			this.convertTextFilesTitleLabel.Size = new System.Drawing.Size(183, 29);
			this.convertTextFilesTitleLabel.TabIndex = 0;
			this.convertTextFilesTitleLabel.Text = "Convert text files";
			this.convertTextFilesTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialLabel2
			// 
			this.materialLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.materialLabel2.Location = new System.Drawing.Point(317, 55);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(320, 17);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Choose a text file (.txt, .pdf or .docx) and convert it";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.ImageKey = "video_icon";
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1021, 652);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Video Files";
			// 
			// drawerImageList
			// 
			this.drawerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drawerImageList.ImageStream")));
			this.drawerImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.drawerImageList.Images.SetKeyName(0, "text_icon");
			this.drawerImageList.Images.SetKeyName(1, "video_icon");
			// 
			// textFileOpenDialog
			// 
			this.textFileOpenDialog.FileName = "openFileDialog1";
			this.textFileOpenDialog.Filter = "\"Text file\"|*.txt";
			this.textFileOpenDialog.Title = "Choose a file";
			this.textFileOpenDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.TextFileOpenDialog_FileOk);
			// 
			// textFileConversionBackgroundWorker
			// 
			this.textFileConversionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TextFileConversionBackgroundWorker_DoWork);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1029, 681);
			this.Controls.Add(this.materialTabControl1);
			this.DrawerHighlightWithAccent = false;
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.materialTabControl1;
			this.Name = "MainForm";
			this.Text = "File Converter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.materialCard1.ResumeLayout(false);
			this.materialCard1.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ImageList drawerImageList;
		private System.Windows.Forms.OpenFileDialog textFileOpenDialog;
		private MaterialSkin.Controls.MaterialLabel convertTextFilesTitleLabel;
		private MaterialSkin.Controls.MaterialButton chooseTextFileButton;
		private MaterialSkin.Controls.MaterialCard materialCard1;
		private MaterialSkin.Controls.MaterialLabel fileChosenNameLabel;
		private MaterialSkin.Controls.MaterialComboBox textFileConvertToComboBox;
		private MaterialSkin.Controls.MaterialButton convertTextFileButton;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialProgressBar textFileConvertProgressBar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private System.Windows.Forms.TextBox textFileConversionLog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.ComponentModel.BackgroundWorker textFileConversionBackgroundWorker;
	}
}

