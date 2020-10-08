using MaterialSkin.Controls;

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
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.refreshButton = new MaterialSkin.Controls.MaterialButton();
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
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.refreshButton);
			this.panel1.Controls.Add(this.logsListView);
			this.panel1.Location = new System.Drawing.Point(-1, 74);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1118, 379);
			this.panel1.TabIndex = 4;
			// 
			// refreshButton
			// 
			this.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.refreshButton.Depth = 0;
			this.refreshButton.DrawShadows = true;
			this.refreshButton.HighEmphasis = true;
			this.refreshButton.Icon = null;
			this.refreshButton.Location = new System.Drawing.Point(23, 13);
			this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 60);
			this.refreshButton.MouseState = MaterialSkin.MouseState.HOVER;
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(140, 36);
			this.refreshButton.TabIndex = 1;
			this.refreshButton.Text = "Show / Refresh";
			this.refreshButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.refreshButton.UseAccentColor = false;
			this.refreshButton.UseVisualStyleBackColor = true;
			this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
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
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView logsListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Panel panel1;
		private MaterialButton refreshButton;
	}
}