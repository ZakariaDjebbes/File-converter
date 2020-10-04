using System;
using System.IO;
using System.Windows.Forms;
using File_Converter.Logging;
using MaterialSkin;
using MaterialSkin.Controls;

namespace File_Converter.View
{
	public partial class DebugLogWindow : MaterialForm
	{
		private readonly Logger logger = Logger.Instance;

		public DebugLogWindow()
		{
			InitializeComponent();
			logger.Enqueue($"Theme {MaterialSkinManager.Instance.Theme}");
			logger.StartLogging += OnStartLogging;
			logger.Logging += OnLogging;
			logger.EndLogging += OnEndLogging;
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
				SaveLogsToDisk();
			}
		}

		private void RefreshButton_Click(object sender, System.EventArgs e)
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

		private void BackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			logger.PrintToListView(logsListView);
		}

		private void SaveLogsToDisk()
		{
			Directory.CreateDirectory(Path.Combine(Application.StartupPath, "logs"));

			string path = Path.Combine(Application.StartupPath,
				"logs",
				$"LOGS_{DateTime.Now:hh_mm_ss_tt}.txt");

			using (var tw = new StreamWriter(path))
			{
				foreach (ListViewItem item in logsListView.Items)
				{
					tw.WriteLine(item.Text);
				}
			}
		}
	}
}