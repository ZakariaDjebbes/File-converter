namespace File_Converter
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
			this.textFilesConversionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.convertTextFilesButton = new MaterialSkin.Controls.MaterialButton();
			this.chooseTextFileButton = new MaterialSkin.Controls.MaterialButton();
			this.textFileConvertToComboBox = new MaterialSkin.Controls.MaterialComboBox();
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
			this.tableLayoutPanel2.SuspendLayout();
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
			this.materialTabControl1.Size = new System.Drawing.Size(1280, 720);
			this.materialTabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.textFilesConversionTableLayoutPanel);
			this.tabPage1.Controls.Add(this.tableLayoutPanel2);
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.ImageKey = "text_icon";
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1272, 691);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Text Files";
			// 
			// textFilesConversionTableLayoutPanel
			// 
			this.textFilesConversionTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textFilesConversionTableLayoutPanel.AutoScroll = true;
			this.textFilesConversionTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.textFilesConversionTableLayoutPanel.ColumnCount = 2;
			this.textFilesConversionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.43187F));
			this.textFilesConversionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.56813F));
			this.textFilesConversionTableLayoutPanel.Location = new System.Drawing.Point(39, 350);
			this.textFilesConversionTableLayoutPanel.Name = "textFilesConversionTableLayoutPanel";
			this.textFilesConversionTableLayoutPanel.RowCount = 1;
			this.textFilesConversionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.textFilesConversionTableLayoutPanel.Size = new System.Drawing.Size(1154, 323);
			this.textFilesConversionTableLayoutPanel.TabIndex = 9;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.34591F));
			this.tableLayoutPanel2.Controls.Add(this.convertTextFilesButton, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.chooseTextFileButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textFileConvertToComboBox, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 126);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.55556F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.66667F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1154, 180);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// convertTextFilesButton
			// 
			this.convertTextFilesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.convertTextFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.convertTextFilesButton.Depth = 0;
			this.convertTextFilesButton.DrawShadows = true;
			this.convertTextFilesButton.Enabled = false;
			this.convertTextFilesButton.HighEmphasis = true;
			this.convertTextFilesButton.Icon = null;
			this.convertTextFilesButton.Location = new System.Drawing.Point(512, 138);
			this.convertTextFilesButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
			this.convertTextFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.convertTextFilesButton.Name = "convertTextFilesButton";
			this.convertTextFilesButton.Size = new System.Drawing.Size(129, 36);
			this.convertTextFilesButton.TabIndex = 4;
			this.convertTextFilesButton.Text = "Convert files";
			this.convertTextFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.convertTextFilesButton.UseAccentColor = false;
			this.convertTextFilesButton.UseVisualStyleBackColor = true;
			this.convertTextFilesButton.Click += new System.EventHandler(this.ConvertTextFileButton_Click);
			// 
			// chooseTextFileButton
			// 
			this.chooseTextFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chooseTextFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.chooseTextFileButton.Depth = 0;
			this.chooseTextFileButton.DrawShadows = true;
			this.chooseTextFileButton.HighEmphasis = true;
			this.chooseTextFileButton.Icon = null;
			this.chooseTextFileButton.Location = new System.Drawing.Point(519, 7);
			this.chooseTextFileButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 15);
			this.chooseTextFileButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.chooseTextFileButton.Name = "chooseTextFileButton";
			this.chooseTextFileButton.Size = new System.Drawing.Size(115, 36);
			this.chooseTextFileButton.TabIndex = 1;
			this.chooseTextFileButton.Text = "Select Files";
			this.chooseTextFileButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.chooseTextFileButton.UseAccentColor = false;
			this.chooseTextFileButton.UseVisualStyleBackColor = true;
			this.chooseTextFileButton.Click += new System.EventHandler(this.ChooseTextFileButton_Click);
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
			this.textFileConvertToComboBox.Location = new System.Drawing.Point(50, 62);
			this.textFileConvertToComboBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
			this.textFileConvertToComboBox.MaxDropDownItems = 4;
			this.textFileConvertToComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.textFileConvertToComboBox.Name = "textFileConvertToComboBox";
			this.textFileConvertToComboBox.Size = new System.Drawing.Size(1054, 49);
			this.textFileConvertToComboBox.TabIndex = 3;
			this.textFileConvertToComboBox.UseAccent = false;
			this.textFileConvertToComboBox.SelectedIndexChanged += new System.EventHandler(this.TextFileConvertToComboBox_SelectedIndexChanged);
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
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 93);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// convertTextFilesTitleLabel
			// 
			this.convertTextFilesTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.convertTextFilesTitleLabel.AutoSize = true;
			this.convertTextFilesTitleLabel.Depth = 0;
			this.convertTextFilesTitleLabel.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.convertTextFilesTitleLabel.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			this.convertTextFilesTitleLabel.Location = new System.Drawing.Point(485, 3);
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
			this.materialLabel2.Location = new System.Drawing.Point(417, 55);
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
			this.tabPage2.Size = new System.Drawing.Size(1272, 691);
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
			this.textFileOpenDialog.Filter = "Text file|*.txt|PDF file|*.pdf|Word files|*.docx";
			this.textFileOpenDialog.Multiselect = true;
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
			this.ClientSize = new System.Drawing.Size(1280, 720);
			this.Controls.Add(this.materialTabControl1);
			this.DrawerHighlightWithAccent = false;
			this.DrawerShowIconsWhenHidden = true;
			this.DrawerTabControl = this.materialTabControl1;
			this.MinimumSize = new System.Drawing.Size(1080, 680);
			this.Name = "MainForm";
			this.Text = "File Converter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private MaterialSkin.Controls.MaterialComboBox textFileConvertToComboBox;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private MaterialSkin.Controls.MaterialLabel materialLabel2;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.TableLayoutPanel textFilesConversionTableLayoutPanel;
		private MaterialSkin.Controls.MaterialButton convertTextFilesButton;
		private System.ComponentModel.BackgroundWorker textFileConversionBackgroundWorker;
	}
}

