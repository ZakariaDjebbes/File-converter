namespace File_Converter.View
{
	partial class DebugLogWindow
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
			this.logsListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.refreshButton = new System.Windows.Forms.Button();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.refreshBar = new System.Windows.Forms.ProgressBar();
			this.saveButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// logsListView
			// 
			this.logsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.logsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.logsListView.HideSelection = false;
			this.logsListView.Location = new System.Drawing.Point(1, 81);
			this.logsListView.Name = "logsListView";
			this.logsListView.Size = new System.Drawing.Size(1115, 295);
			this.logsListView.TabIndex = 0;
			this.logsListView.UseCompatibleStateImageBehavior = false;
			this.logsListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Message";
			this.columnHeader1.Width = 606;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Status";
			this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader2.Width = 100;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Caller";
			this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.columnHeader3.Width = 100;
			// 
			// refreshButton
			// 
			this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshButton.Location = new System.Drawing.Point(802, 12);
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(300, 40);
			this.refreshButton.TabIndex = 1;
			this.refreshButton.Text = "Show / Refresh";
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			// 
			// refreshBar
			// 
			this.refreshBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.refreshBar.Location = new System.Drawing.Point(13, 58);
			this.refreshBar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
			this.refreshBar.Name = "refreshBar";
			this.refreshBar.Size = new System.Drawing.Size(1089, 14);
			this.refreshBar.Step = 1;
			this.refreshBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.refreshBar.TabIndex = 2;
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(13, 12);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(300, 40);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save logs";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.refreshButton);
			this.panel1.Controls.Add(this.saveButton);
			this.panel1.Controls.Add(this.refreshBar);
			this.panel1.Controls.Add(this.logsListView);
			this.panel1.Location = new System.Drawing.Point(-1, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1118, 379);
			this.panel1.TabIndex = 4;
			// 
			// DebugLogWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(1115, 450);
			this.Controls.Add(this.panel1);
			this.Name = "DebugLogWindow";
			this.Text = "DebugLogWindow";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebugLogWindow_FormClosing);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView logsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.Button refreshButton;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.ProgressBar refreshBar;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Panel panel1;
	}
}