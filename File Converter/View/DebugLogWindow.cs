using System;
using System.IO;
using System.Windows.Forms;
using File_Converter.Debug;

namespace File_Converter.View
{
	public partial class DebugLogWindow : Form
	{
		public DebugLogWindow()
		{
			InitializeComponent();

			Logger.Instance.StartLogging += OnStartLogging;
			Logger.Instance.Logging += OnLogging;
			Logger.Instance.EndLogging += OnEndLogging;
		}

		private void OnStartLogging(object sender, EventArgs e)
		{
			refreshBar.Invoke((Action)(() =>
			{
				refreshBar.Value = 0;
				refreshBar.Visible = true;
			}));


		}

		private void OnLogging(object sender, LogArgs e)
		{
			refreshBar.Invoke((Action)(() =>
			{
				refreshBar.Value = e.percent;
			}));


		}

		private void OnEndLogging(object sender, EventArgs e)
		{
			refreshBar.Invoke((Action)(() =>
			{
				refreshBar.Value = 0;
				refreshBar.Visible = false;
			}));


		}

		private void DebugLogWindow_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				e.Cancel = true;
				Hide();
			}
		}

		private void refreshButton_Click(object sender, System.EventArgs e)
		{
			if (backgroundWorker.IsBusy)
			{
				MessageBox.Show($"Logs are beign printed",
								"Worker currently busy",
								MessageBoxButtons.OK,
								MessageBoxIcon.Information);
			}
			{
				backgroundWorker.RunWorkerAsync();
			}
		}

		private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Logger.Instance.PrintToListView(logsListView);
		}

		private void saveButton_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(Application.StartupPath, "logs.txt");
			
			using (var tw = new StreamWriter(path))
			{
				foreach (ListViewItem item in logsListView.Items)
				{
					tw.WriteLine(item.Text);
				}
			}

			MessageBox.Show($"Logs saved to {path}", "Logs saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}