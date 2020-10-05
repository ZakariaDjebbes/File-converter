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
			this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
			this.textFileConversionCancelButton = new MaterialSkin.Controls.MaterialButton();
			this.chooseTextFileButton = new MaterialSkin.Controls.MaterialButton();
			this.textFileConvertToComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.convertTextFilesButton = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.convertTextFilesTitleLabel = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.imageFileConversionTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
			this.clearOrCancelImageFileConversion = new MaterialSkin.Controls.MaterialButton();
			this.selectImageFilesButton = new MaterialSkin.Controls.MaterialButton();
			this.imageFileConvertToComboBox = new MaterialSkin.Controls.MaterialComboBox();
			this.convertImageFilesButton = new MaterialSkin.Controls.MaterialButton();
			this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.safeConversionSwitch = new MaterialSkin.Controls.MaterialSwitch();
			this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
			this.darkModeSwitch = new MaterialSkin.Controls.MaterialSwitch();
			this.showLogsButton = new MaterialSkin.Controls.MaterialButton();
			this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
			this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
			this.drawerImageList = new System.Windows.Forms.ImageList(this.components);
			this.fileOpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.textFileConversionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.settingsToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.imageFileConversionBackgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.materialTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// materialTabControl1
			// 
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Controls.Add(this.tabPage3);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.materialTabControl1.ImageList = this.drawerImageList;
			this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
			this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
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
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.materialLabel8, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.textFileConversionCancelButton, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.chooseTextFileButton, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.textFileConvertToComboBox, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.convertTextFilesButton, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.materialLabel7, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(39, 105);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.52427F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67961F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.15534F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.61165F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1154, 212);
			this.tableLayoutPanel2.TabIndex = 8;
			// 
			// materialLabel8
			// 
			this.materialLabel8.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel8.AutoSize = true;
			this.materialLabel8.Depth = 0;
			this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel8.Location = new System.Drawing.Point(936, 69);
			this.materialLabel8.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
			this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel8.Name = "materialLabel8";
			this.materialLabel8.Size = new System.Drawing.Size(168, 19);
			this.materialLabel8.TabIndex = 7;
			this.materialLabel8.Text = "Total size limit : 200MB";
			this.materialLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.materialLabel8.Visible = false;
			// 
			// textFileConversionCancelButton
			// 
			this.textFileConversionCancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textFileConversionCancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.textFileConversionCancelButton.Depth = 0;
			this.textFileConversionCancelButton.DrawShadows = true;
			this.textFileConversionCancelButton.HighEmphasis = true;
			this.textFileConversionCancelButton.Icon = null;
			this.textFileConversionCancelButton.Location = new System.Drawing.Point(220, 168);
			this.textFileConversionCancelButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
			this.textFileConversionCancelButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.textFileConversionCancelButton.Name = "textFileConversionCancelButton";
			this.textFileConversionCancelButton.Size = new System.Drawing.Size(136, 36);
			this.textFileConversionCancelButton.TabIndex = 5;
			this.textFileConversionCancelButton.Text = "Cancel / Clear";
			this.textFileConversionCancelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.textFileConversionCancelButton.UseAccentColor = false;
			this.textFileConversionCancelButton.UseVisualStyleBackColor = true;
			this.textFileConversionCancelButton.Click += new System.EventHandler(this.TextFileConversionCancelButton_Click);
			// 
			// chooseTextFileButton
			// 
			this.chooseTextFileButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.chooseTextFileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.SetColumnSpan(this.chooseTextFileButton, 2);
			this.chooseTextFileButton.Depth = 0;
			this.chooseTextFileButton.DrawShadows = true;
			this.chooseTextFileButton.HighEmphasis = true;
			this.chooseTextFileButton.Icon = null;
			this.chooseTextFileButton.Location = new System.Drawing.Point(519, 11);
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
			this.tableLayoutPanel2.SetColumnSpan(this.textFileConvertToComboBox, 2);
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
			this.textFileConvertToComboBox.Location = new System.Drawing.Point(50, 93);
			this.textFileConvertToComboBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
			this.textFileConvertToComboBox.MaxDropDownItems = 4;
			this.textFileConvertToComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.textFileConvertToComboBox.Name = "textFileConvertToComboBox";
			this.textFileConvertToComboBox.Size = new System.Drawing.Size(1054, 49);
			this.textFileConvertToComboBox.TabIndex = 3;
			this.textFileConvertToComboBox.UseAccent = false;
			this.textFileConvertToComboBox.SelectedIndexChanged += new System.EventHandler(this.TextFileConvertToComboBox_SelectedIndexChanged);
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
			this.convertTextFilesButton.Location = new System.Drawing.Point(781, 168);
			this.convertTextFilesButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
			this.convertTextFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.convertTextFilesButton.Name = "convertTextFilesButton";
			this.convertTextFilesButton.Size = new System.Drawing.Size(168, 36);
			this.convertTextFilesButton.TabIndex = 4;
			this.convertTextFilesButton.Text = "Convert text files";
			this.convertTextFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.convertTextFilesButton.UseAccentColor = false;
			this.convertTextFilesButton.UseVisualStyleBackColor = true;
			this.convertTextFilesButton.Click += new System.EventHandler(this.ConvertTextFilesButton_Click);
			// 
			// materialLabel7
			// 
			this.materialLabel7.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel7.Location = new System.Drawing.Point(50, 69);
			this.materialLabel7.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
			this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new System.Drawing.Size(172, 19);
			this.materialLabel7.TabIndex = 6;
			this.materialLabel7.Text = "Size limit per file : 20MB";
			this.materialLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.materialLabel7.Visible = false;
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
			this.convertTextFilesTitleLabel.HighEmphasis = true;
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
			this.materialLabel2.Enabled = false;
			this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.materialLabel2.Location = new System.Drawing.Point(389, 55);
			this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new System.Drawing.Size(375, 17);
			this.materialLabel2.TabIndex = 1;
			this.materialLabel2.Text = "Choose some files and convert them to another text format";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.imageFileConversionTableLayoutPanel);
			this.tabPage2.Controls.Add(this.tableLayoutPanel5);
			this.tabPage2.Controls.Add(this.tableLayoutPanel6);
			this.tabPage2.ImageKey = "image_icon";
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1272, 691);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Image Files";
			// 
			// imageFileConversionTableLayoutPanel
			// 
			this.imageFileConversionTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imageFileConversionTableLayoutPanel.AutoScroll = true;
			this.imageFileConversionTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.imageFileConversionTableLayoutPanel.ColumnCount = 2;
			this.imageFileConversionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.43187F));
			this.imageFileConversionTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.56813F));
			this.imageFileConversionTableLayoutPanel.Location = new System.Drawing.Point(39, 350);
			this.imageFileConversionTableLayoutPanel.Name = "imageFileConversionTableLayoutPanel";
			this.imageFileConversionTableLayoutPanel.RowCount = 1;
			this.imageFileConversionTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.imageFileConversionTableLayoutPanel.Size = new System.Drawing.Size(1154, 323);
			this.imageFileConversionTableLayoutPanel.TabIndex = 11;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.materialLabel10, 1, 1);
			this.tableLayoutPanel5.Controls.Add(this.clearOrCancelImageFileConversion, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.selectImageFilesButton, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.imageFileConvertToComboBox, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.convertImageFilesButton, 1, 3);
			this.tableLayoutPanel5.Controls.Add(this.materialLabel11, 0, 1);
			this.tableLayoutPanel5.Location = new System.Drawing.Point(39, 105);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 4;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.52427F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.67961F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.15534F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.61165F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(1154, 212);
			this.tableLayoutPanel5.TabIndex = 10;
			// 
			// materialLabel10
			// 
			this.materialLabel10.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.materialLabel10.AutoSize = true;
			this.materialLabel10.Depth = 0;
			this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel10.Location = new System.Drawing.Point(936, 69);
			this.materialLabel10.Margin = new System.Windows.Forms.Padding(0, 0, 50, 0);
			this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel10.Name = "materialLabel10";
			this.materialLabel10.Size = new System.Drawing.Size(168, 19);
			this.materialLabel10.TabIndex = 7;
			this.materialLabel10.Text = "Total size limit : 200MB";
			this.materialLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.materialLabel10.Visible = false;
			// 
			// clearOrCancelImageFileConversion
			// 
			this.clearOrCancelImageFileConversion.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.clearOrCancelImageFileConversion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.clearOrCancelImageFileConversion.Depth = 0;
			this.clearOrCancelImageFileConversion.DrawShadows = true;
			this.clearOrCancelImageFileConversion.HighEmphasis = true;
			this.clearOrCancelImageFileConversion.Icon = null;
			this.clearOrCancelImageFileConversion.Location = new System.Drawing.Point(220, 168);
			this.clearOrCancelImageFileConversion.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
			this.clearOrCancelImageFileConversion.MouseState = MaterialSkin.MouseState.HOVER;
			this.clearOrCancelImageFileConversion.Name = "clearOrCancelImageFileConversion";
			this.clearOrCancelImageFileConversion.Size = new System.Drawing.Size(136, 36);
			this.clearOrCancelImageFileConversion.TabIndex = 5;
			this.clearOrCancelImageFileConversion.Text = "Cancel / Clear";
			this.clearOrCancelImageFileConversion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.clearOrCancelImageFileConversion.UseAccentColor = false;
			this.clearOrCancelImageFileConversion.UseVisualStyleBackColor = true;
			// 
			// selectImageFilesButton
			// 
			this.selectImageFilesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.selectImageFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel5.SetColumnSpan(this.selectImageFilesButton, 2);
			this.selectImageFilesButton.Depth = 0;
			this.selectImageFilesButton.DrawShadows = true;
			this.selectImageFilesButton.HighEmphasis = true;
			this.selectImageFilesButton.Icon = null;
			this.selectImageFilesButton.Location = new System.Drawing.Point(519, 11);
			this.selectImageFilesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 15);
			this.selectImageFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.selectImageFilesButton.Name = "selectImageFilesButton";
			this.selectImageFilesButton.Size = new System.Drawing.Size(115, 36);
			this.selectImageFilesButton.TabIndex = 1;
			this.selectImageFilesButton.Text = "Select Files";
			this.selectImageFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.selectImageFilesButton.UseAccentColor = false;
			this.selectImageFilesButton.UseVisualStyleBackColor = true;
			this.selectImageFilesButton.Click += new System.EventHandler(this.SelectImageFilesButton_Click);
			// 
			// imageFileConvertToComboBox
			// 
			this.imageFileConvertToComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.imageFileConvertToComboBox.AutoResize = false;
			this.imageFileConvertToComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.tableLayoutPanel5.SetColumnSpan(this.imageFileConvertToComboBox, 2);
			this.imageFileConvertToComboBox.Depth = 0;
			this.imageFileConvertToComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.imageFileConvertToComboBox.DropDownHeight = 174;
			this.imageFileConvertToComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.imageFileConvertToComboBox.DropDownWidth = 121;
			this.imageFileConvertToComboBox.Enabled = false;
			this.imageFileConvertToComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.imageFileConvertToComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.imageFileConvertToComboBox.FormattingEnabled = true;
			this.imageFileConvertToComboBox.Hint = "Convert to";
			this.imageFileConvertToComboBox.IntegralHeight = false;
			this.imageFileConvertToComboBox.ItemHeight = 43;
			this.imageFileConvertToComboBox.Location = new System.Drawing.Point(50, 93);
			this.imageFileConvertToComboBox.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
			this.imageFileConvertToComboBox.MaxDropDownItems = 4;
			this.imageFileConvertToComboBox.MouseState = MaterialSkin.MouseState.OUT;
			this.imageFileConvertToComboBox.Name = "imageFileConvertToComboBox";
			this.imageFileConvertToComboBox.Size = new System.Drawing.Size(1054, 49);
			this.imageFileConvertToComboBox.TabIndex = 3;
			this.imageFileConvertToComboBox.UseAccent = false;
			this.imageFileConvertToComboBox.SelectedIndexChanged += new System.EventHandler(this.ImageFileConvertToComboBox_SelectedIndexChanged);
			// 
			// convertImageFilesButton
			// 
			this.convertImageFilesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.convertImageFilesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.convertImageFilesButton.Depth = 0;
			this.convertImageFilesButton.DrawShadows = true;
			this.convertImageFilesButton.Enabled = false;
			this.convertImageFilesButton.HighEmphasis = true;
			this.convertImageFilesButton.Icon = null;
			this.convertImageFilesButton.Location = new System.Drawing.Point(776, 168);
			this.convertImageFilesButton.Margin = new System.Windows.Forms.Padding(4, 15, 4, 4);
			this.convertImageFilesButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.convertImageFilesButton.Name = "convertImageFilesButton";
			this.convertImageFilesButton.Size = new System.Drawing.Size(178, 36);
			this.convertImageFilesButton.TabIndex = 4;
			this.convertImageFilesButton.Text = "Convert image files";
			this.convertImageFilesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.convertImageFilesButton.UseAccentColor = false;
			this.convertImageFilesButton.UseVisualStyleBackColor = true;
			this.convertImageFilesButton.Click += new System.EventHandler(this.ConvertImageFilesButton_Click);
			// 
			// materialLabel11
			// 
			this.materialLabel11.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel11.AutoSize = true;
			this.materialLabel11.Depth = 0;
			this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel11.Location = new System.Drawing.Point(50, 69);
			this.materialLabel11.Margin = new System.Windows.Forms.Padding(50, 0, 3, 0);
			this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel11.Name = "materialLabel11";
			this.materialLabel11.Size = new System.Drawing.Size(172, 19);
			this.materialLabel11.TabIndex = 6;
			this.materialLabel11.Text = "Size limit per file : 20MB";
			this.materialLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.materialLabel11.Visible = false;
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel6.ColumnCount = 1;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Controls.Add(this.materialLabel12, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.materialLabel13, 0, 1);
			this.tableLayoutPanel6.Location = new System.Drawing.Point(39, 6);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.26087F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.73913F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(1154, 93);
			this.tableLayoutPanel6.TabIndex = 9;
			// 
			// materialLabel12
			// 
			this.materialLabel12.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel12.AutoSize = true;
			this.materialLabel12.Depth = 0;
			this.materialLabel12.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			this.materialLabel12.HighEmphasis = true;
			this.materialLabel12.Location = new System.Drawing.Point(473, 3);
			this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel12.Name = "materialLabel12";
			this.materialLabel12.Size = new System.Drawing.Size(208, 29);
			this.materialLabel12.TabIndex = 0;
			this.materialLabel12.Text = "Convert image files";
			this.materialLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialLabel13
			// 
			this.materialLabel13.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel13.AutoSize = true;
			this.materialLabel13.Depth = 0;
			this.materialLabel13.Enabled = false;
			this.materialLabel13.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.materialLabel13.Location = new System.Drawing.Point(382, 55);
			this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel13.Name = "materialLabel13";
			this.materialLabel13.Size = new System.Drawing.Size(390, 17);
			this.materialLabel13.TabIndex = 1;
			this.materialLabel13.Text = "Choose some files and convert them to another image format";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.tableLayoutPanel3);
			this.tabPage3.Controls.Add(this.tableLayoutPanel4);
			this.tabPage3.ImageKey = "settings_icon";
			this.tabPage3.Location = new System.Drawing.Point(4, 25);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1272, 691);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Settings";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Controls.Add(this.safeConversionSwitch, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.materialLabel9, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.materialLabel6, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.materialLabel5, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.materialLabel4, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.darkModeSwitch, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.showLogsButton, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.materialComboBox1, 1, 2);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(58, 170);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 4;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.21531F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72302F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.94033F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.12134F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(1154, 276);
			this.tableLayoutPanel3.TabIndex = 9;
			// 
			// safeConversionSwitch
			// 
			this.safeConversionSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.safeConversionSwitch.AutoSize = true;
			this.safeConversionSwitch.Checked = true;
			this.safeConversionSwitch.CheckState = System.Windows.Forms.CheckState.Checked;
			this.safeConversionSwitch.Depth = 0;
			this.safeConversionSwitch.Location = new System.Drawing.Point(619, 223);
			this.safeConversionSwitch.Margin = new System.Windows.Forms.Padding(0);
			this.safeConversionSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
			this.safeConversionSwitch.MouseState = MaterialSkin.MouseState.HOVER;
			this.safeConversionSwitch.Name = "safeConversionSwitch";
			this.safeConversionSwitch.Ripple = true;
			this.safeConversionSwitch.Size = new System.Drawing.Size(58, 37);
			this.safeConversionSwitch.TabIndex = 7;
			this.settingsToolTip.SetToolTip(this.safeConversionSwitch, "Toggle safe conversion.\r\nif you disable safe conversion the software might crash " +
        "due to an out of memory exception.\r\n\r\n");
			this.safeConversionSwitch.UseVisualStyleBackColor = true;
			// 
			// materialLabel9
			// 
			this.materialLabel9.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel9.AutoSize = true;
			this.materialLabel9.Depth = 0;
			this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel9.Location = new System.Drawing.Point(10, 232);
			this.materialLabel9.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel9.Name = "materialLabel9";
			this.materialLabel9.Size = new System.Drawing.Size(103, 19);
			this.materialLabel9.TabIndex = 6;
			this.materialLabel9.Text = "Limit file sizes";
			this.settingsToolTip.SetToolTip(this.materialLabel9, "Toggle safe conversion.\r\nif you disable safe conversion the software might crash " +
        "due to an out of memory exception.\r\n");
			// 
			// materialLabel6
			// 
			this.materialLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel6.Location = new System.Drawing.Point(10, 165);
			this.materialLabel6.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new System.Drawing.Size(72, 19);
			this.materialLabel6.TabIndex = 4;
			this.materialLabel6.Text = "Language";
			this.settingsToolTip.SetToolTip(this.materialLabel6, "Select the language of the app, supported laguages are:\r\nFrench (FR)\r\nEnglish (EN" +
        ")\r\nDeutsh (DE)\r\nArabic (DZ)");
			// 
			// materialLabel5
			// 
			this.materialLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel5.Location = new System.Drawing.Point(10, 101);
			this.materialLabel5.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new System.Drawing.Size(69, 19);
			this.materialLabel5.TabIndex = 2;
			this.materialLabel5.Text = "View logs";
			this.settingsToolTip.SetToolTip(this.materialLabel5, "Shows runtime logs for debugging. You can save the log\r\nfile to the startup folde" +
        "r.");
			// 
			// materialLabel4
			// 
			this.materialLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.Location = new System.Drawing.Point(10, 30);
			this.materialLabel4.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
			this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new System.Drawing.Size(129, 19);
			this.materialLabel4.TabIndex = 0;
			this.materialLabel4.Text = "Toggle dark mode";
			this.settingsToolTip.SetToolTip(this.materialLabel4, "Toggle dark mode.\r\n");
			// 
			// darkModeSwitch
			// 
			this.darkModeSwitch.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.darkModeSwitch.AutoSize = true;
			this.darkModeSwitch.Depth = 0;
			this.darkModeSwitch.Location = new System.Drawing.Point(619, 21);
			this.darkModeSwitch.Margin = new System.Windows.Forms.Padding(0);
			this.darkModeSwitch.MouseLocation = new System.Drawing.Point(-1, -1);
			this.darkModeSwitch.MouseState = MaterialSkin.MouseState.HOVER;
			this.darkModeSwitch.Name = "darkModeSwitch";
			this.darkModeSwitch.Ripple = true;
			this.darkModeSwitch.Size = new System.Drawing.Size(58, 37);
			this.darkModeSwitch.TabIndex = 1;
			this.settingsToolTip.SetToolTip(this.darkModeSwitch, "Toggle dark mode.\r\n");
			this.darkModeSwitch.UseVisualStyleBackColor = true;
			this.darkModeSwitch.CheckedChanged += new System.EventHandler(this.DarkModeSwitch_CheckedChanged);
			// 
			// showLogsButton
			// 
			this.showLogsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.showLogsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.showLogsButton.Depth = 0;
			this.showLogsButton.DrawShadows = true;
			this.showLogsButton.HighEmphasis = true;
			this.showLogsButton.Icon = null;
			this.showLogsButton.Location = new System.Drawing.Point(588, 93);
			this.showLogsButton.Margin = new System.Windows.Forms.Padding(50, 6, 4, 6);
			this.showLogsButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.showLogsButton.Name = "showLogsButton";
			this.showLogsButton.Size = new System.Drawing.Size(165, 36);
			this.showLogsButton.TabIndex = 3;
			this.showLogsButton.Text = "View runtime logs";
			this.settingsToolTip.SetToolTip(this.showLogsButton, "Shows runtime logs for debugging. You can save the log\r\nfile to the startup folde" +
        "r.\r\n");
			this.showLogsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.showLogsButton.UseAccentColor = false;
			this.showLogsButton.UseVisualStyleBackColor = true;
			this.showLogsButton.Click += new System.EventHandler(this.ShowLogsButton_Click);
			// 
			// materialComboBox1
			// 
			this.materialComboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialComboBox1.AutoResize = true;
			this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.materialComboBox1.Depth = 0;
			this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.materialComboBox1.DropDownHeight = 174;
			this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.materialComboBox1.DropDownWidth = 135;
			this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.materialComboBox1.FormattingEnabled = true;
			this.materialComboBox1.IntegralHeight = false;
			this.materialComboBox1.ItemHeight = 43;
			this.materialComboBox1.Items.AddRange(new object[] {
            "French (FR)",
            "English (EN)",
            "Deutsch (DE)"});
			this.materialComboBox1.Location = new System.Drawing.Point(580, 150);
			this.materialComboBox1.MaxDropDownItems = 4;
			this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
			this.materialComboBox1.Name = "materialComboBox1";
			this.materialComboBox1.Size = new System.Drawing.Size(135, 49);
			this.materialComboBox1.TabIndex = 5;
			this.settingsToolTip.SetToolTip(this.materialComboBox1, "Select the language of the app, supported laguages are:\r\nFrench (FR)\r\nEnglish (EN" +
        ")\r\nDeutsh (DE)\r\nArabic (DZ)");
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel4.ColumnCount = 1;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Controls.Add(this.materialLabel1, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.materialLabel3, 0, 1);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(58, 18);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.26087F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.73913F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(1154, 93);
			this.tableLayoutPanel4.TabIndex = 8;
			// 
			// materialLabel1
			// 
			this.materialLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
			this.materialLabel1.Location = new System.Drawing.Point(533, 3);
			this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new System.Drawing.Size(88, 29);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Settings";
			this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// materialLabel3
			// 
			this.materialLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.materialLabel3.AutoSize = true;
			this.materialLabel3.Depth = 0;
			this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
			this.materialLabel3.Location = new System.Drawing.Point(467, 55);
			this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
			this.materialLabel3.Name = "materialLabel3";
			this.materialLabel3.Size = new System.Drawing.Size(220, 17);
			this.materialLabel3.TabIndex = 1;
			this.materialLabel3.Text = "Change settings of the application";
			// 
			// drawerImageList
			// 
			this.drawerImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drawerImageList.ImageStream")));
			this.drawerImageList.TransparentColor = System.Drawing.Color.Transparent;
			this.drawerImageList.Images.SetKeyName(0, "text_icon");
			this.drawerImageList.Images.SetKeyName(1, "video_icon");
			this.drawerImageList.Images.SetKeyName(2, "settings_icon");
			this.drawerImageList.Images.SetKeyName(3, "image_icon");
			// 
			// fileOpenDialog
			// 
			this.fileOpenDialog.Multiselect = true;
			this.fileOpenDialog.Title = "Choose a file";
			// 
			// textFileConversionBackgroundWorker
			// 
			this.textFileConversionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.TextFileConversionBackgroundWorker_DoWork);
			// 
			// settingsToolTip
			// 
			this.settingsToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
			this.settingsToolTip.ToolTipTitle = "Informations";
			// 
			// imageFileConversionBackgroundWorker
			// 
			this.imageFileConversionBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ImageFileConversionBackgroundWorker_DoWork);
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
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel4.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ImageList drawerImageList;
		private System.Windows.Forms.OpenFileDialog fileOpenDialog;
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
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private MaterialSkin.Controls.MaterialLabel materialLabel5;
		private MaterialSkin.Controls.MaterialLabel materialLabel4;
		private MaterialSkin.Controls.MaterialSwitch darkModeSwitch;
		private MaterialSkin.Controls.MaterialLabel materialLabel1;
		private MaterialSkin.Controls.MaterialLabel materialLabel3;
		private MaterialSkin.Controls.MaterialButton showLogsButton;
		private MaterialSkin.Controls.MaterialButton textFileConversionCancelButton;
		private MaterialSkin.Controls.MaterialLabel materialLabel6;
		private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
		private MaterialSkin.Controls.MaterialLabel materialLabel8;
		private MaterialSkin.Controls.MaterialLabel materialLabel7;
		private MaterialSkin.Controls.MaterialLabel materialLabel9;
		private System.Windows.Forms.ToolTip settingsToolTip;
		private MaterialSkin.Controls.MaterialSwitch safeConversionSwitch;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private MaterialSkin.Controls.MaterialLabel materialLabel10;
		private MaterialSkin.Controls.MaterialButton clearOrCancelImageFileConversion;
		private MaterialSkin.Controls.MaterialButton selectImageFilesButton;
		private MaterialSkin.Controls.MaterialComboBox imageFileConvertToComboBox;
		private MaterialSkin.Controls.MaterialButton convertImageFilesButton;
		private MaterialSkin.Controls.MaterialLabel materialLabel11;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private MaterialSkin.Controls.MaterialLabel materialLabel12;
		private MaterialSkin.Controls.MaterialLabel materialLabel13;
		private System.Windows.Forms.TableLayoutPanel imageFileConversionTableLayoutPanel;
		private System.ComponentModel.BackgroundWorker imageFileConversionBackgroundWorker;
	}
}

