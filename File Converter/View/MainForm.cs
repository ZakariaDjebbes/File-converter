using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using File_Converter.Controller;
using File_Converter.Debug;
using File_Converter.Model;
using File_Converter.View;
using MaterialSkin;
using MaterialSkin.Controls;

namespace File_Converter
{
	public partial class MainForm : MaterialForm
	{
		private SemaphoreSlim semaphore;
		private readonly MaterialSkinManager materialSkinManager;
		private DebugLogWindow logWindow = null;
		private FileType currentTarget;
		private Dictionary<string, MaterialProgressBar> generatedProgressBars = new Dictionary<string, MaterialProgressBar>();
		private Dictionary<string, MaterialButton> generatedSaveButtons = new Dictionary<string, MaterialButton>();
		private Dictionary<string, byte[]> convertedFiles = new Dictionary<string, byte[]>();
		private Dictionary<string, MemoryStream> convertedStreams = new Dictionary<string, MemoryStream>();
		private string[] filePaths;

		private MaterialButton saveAllButton = new MaterialButton()
		{
			Anchor = AnchorStyles.None,
			Margin = new Padding(0, 5, 0, 5),
			Text = $"Save all files ({ArchiveFileType.Zip.Extension})",
			Enabled = false
		};

		public MainForm()
		{
			InitializeComponent();
			//material skin theme
			materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			//Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE
			materialSkinManager.ColorScheme = new ColorScheme(
				Color.FromArgb(40, 53, 147),
				Color.FromArgb(00, 16, 100),
				Color.FromArgb(95, 95, 196),
				Color.FromArgb(140, 158, 255),
				TextShade.WHITE);
			//saveall button event
			saveAllButton.Click += SaveAllButton_Click;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			convertTextFilesButton.Enabled = false;
			//avoid horizonal scrollbar
			textFilesConversionTableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
		}

		private void SaveAllButton_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = FileType.GetFilter(ArchiveFileType.Zip);
			saveFileDialog.FileName = "Converted files";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Logger.Instance.Enqueue(new Log($"Started saving {convertedFiles.Count} files to {saveFileDialog.FileName}",
					LogStatus.STARTED));
				FileConverter.SaveByteArrayToZip(saveFileDialog.FileName, convertedFiles, currentTarget);
			}
		}

		private void ShowLogsButton_Click(object sender, EventArgs e)
		{
			if (logWindow == null)
			{
				logWindow = new DebugLogWindow();
				logWindow.Show();
			}
			else
			{
				logWindow.Show();
			}
		}

		private void TextFileOpenDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			filePaths = textFileOpenDialog.FileNames;

			//empty previously generated progressbars & save buttons
			generatedProgressBars = new Dictionary<string, MaterialProgressBar>();
			generatedSaveButtons = new Dictionary<string, MaterialButton>();

			//since all files should be of the same extension (.txt, .pdf, .docx...) we can use the first file to reprenst all files
			//get file extension
			string ext = Path.GetExtension(textFileOpenDialog.FileName);

			//textfile combobox items
			List<TextFileType> textFiles = TextFileType.AsList(exclude: new List<string>() { ext });
			BindingSource binding = new BindingSource();
			binding.DataSource = textFiles;
			textFileConvertToComboBox.DataSource = binding.DataSource;
			textFileConvertToComboBox.DisplayMember = "Value";
			textFileConvertToComboBox.ValueMember = "Extension";
			textFileConvertToComboBox.SelectedIndex = 0;
			textFileConvertToComboBox.Enabled = true;

			textFilesConversionTableLayoutPanel.SuspendLayout();

			textFilesConversionTableLayoutPanel.Controls.Clear();
			textFilesConversionTableLayoutPanel.RowStyles.Clear();
			//foreach fileName setup the table
			foreach (string filePath in filePaths)
			{
				string fileName = Path.GetFileName(filePath);

				//add label filename
				MaterialLabel fileNameLabel = new MaterialLabel()
				{
					Text = $"File: {fileName}",
					Anchor = AnchorStyles.Left,
					Margin = new Padding(0, 5, 0, 5),
					TextAlign = ContentAlignment.MiddleCenter,
					AutoSize = true
				};
				textFilesConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				textFilesConversionTableLayoutPanel.Controls.Add(fileNameLabel, 0, textFilesConversionTableLayoutPanel.RowCount - 1);
				textFilesConversionTableLayoutPanel.RowCount++;

				//add progressbar
				MaterialProgressBar progressBar = new MaterialProgressBar()
				{
					Anchor = (AnchorStyles.Left | AnchorStyles.Right),
					Margin = new Padding(0, 5, 0, 5),
					Value = 0,
					Minimum = 0,
					Maximum = 100,
					Step = 1
				};

				textFilesConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				textFilesConversionTableLayoutPanel.Controls.Add(progressBar, 0, textFilesConversionTableLayoutPanel.RowCount - 1);
				textFilesConversionTableLayoutPanel.RowCount++;

				//add buttons
				MaterialButton saveFileButton = new MaterialButton()
				{
					Anchor = AnchorStyles.None,
					Margin = new Padding(0, 5, 0, 5),
					Text = "Save file",
					Enabled = false,
				};

				saveFileButton.Click += (sender, EventArgs) => { SaveFileButton_Click(sender, EventArgs, filePath); };
				textFilesConversionTableLayoutPanel.Controls.Add(saveFileButton, 1, textFilesConversionTableLayoutPanel.RowCount - 3);
				textFilesConversionTableLayoutPanel.SetRowSpan(saveFileButton, 2);

				generatedProgressBars.Add(filePath, progressBar);
				generatedSaveButtons.Add(filePath, saveFileButton);
			}

			textFilesConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			textFilesConversionTableLayoutPanel.SetColumnSpan(saveAllButton, 2);
			textFilesConversionTableLayoutPanel.Controls.Add(saveAllButton, 1, textFilesConversionTableLayoutPanel.RowCount - 1);
			textFilesConversionTableLayoutPanel.RowCount++;

			//add a last auto size row to fill up blank spaces
			textFilesConversionTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			textFilesConversionTableLayoutPanel.RowCount++;

			textFilesConversionTableLayoutPanel.ResumeLayout();

			//enable conver button because new files!
			convertTextFilesButton.Enabled = true;
			saveAllButton.Enabled = false;
		}

		private void SaveFileButton_Click(object sender, EventArgs e, string filePath)
		{
			saveFileDialog.Filter = currentTarget.GetFilter();
			saveFileDialog.FileName = Path.GetFileNameWithoutExtension(filePath);

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				byte[] bytes = convertedFiles[filePath];
				string saveTo = saveFileDialog.FileName;
				Logger.Instance.Enqueue(new Log($"Started saving file {Path.GetFileName(filePath)} to {saveTo}",
					LogStatus.STARTED));
				FileConverter.SaveByteArrayToDisk(saveTo, bytes);
			}
		}

		private void ChooseTextFileButton_Click(object sender, System.EventArgs e)
		{
			textFileOpenDialog.ShowDialog();
		}

		private void TextFileConvertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			convertTextFilesButton.Enabled = true;
		}

		private void ConvertTextFileButton_Click(object sender, EventArgs e)
		{
			//erase previous data
			convertedFiles = new Dictionary<string, byte[]>();
			string convertToExtension = textFileConvertToComboBox.SelectedValue as string;

			currentTarget = TextFileType.Parse(convertToExtension);

			//start background worker
			if (!textFileConversionBackgroundWorker.IsBusy)
			{
				convertTextFilesButton.Enabled = false;
				textFileConversionBackgroundWorker.RunWorkerAsync();
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Trying to convert text files while {nameof(textFileConversionBackgroundWorker)} is busy",
					LogStatus.BUSY));
				MessageBox.Show($"You are currently converting files, you cannot start a new conversion until the ongoing one finishes or you cancel it.",
				"Worker currently busy",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}
		}

		private void OnFileStartConverting(object sender, ConvertionArgs e)
		{
			Logger.Instance.Enqueue(new Log($"Thread effectivly [{Thread.CurrentThread.ManagedThreadId}] started converting file to {currentTarget.Extension}",
					LogStatus.STARTED));
		}

		private void OnFileConverting(object sender, ConvertingArgs e)
		{
			MaterialProgressBar bar = generatedProgressBars[e.Path];

			bar.Invoke((Action)(() =>
			{
				bar.Value = e.ConversionPercent;
			}));

			//Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] converting > {nameof(e.CurrentLine)} : {e.CurrentLine} | {nameof(e.ConversionPercent)} : {e.ConversionPercent}",
			//		Log_Status.ONGOING));
		}

		private void OnFileConverted(object sender, ConvertionArgs e)
		{
			MaterialButton saveButton = generatedSaveButtons[e.Path];

			saveButton.Invoke((Action)(() =>
			{
				saveButton.Enabled = true;
			}));

			Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] finished converting file to {currentTarget.Extension}",
					LogStatus.DONE));
		}

		private void TextFileConversionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Logger.Instance.Enqueue(new Log($"Text conversion background worker [{Thread.CurrentThread.ManagedThreadId}] started > {nameof(filePaths)} : {filePaths.Length} files to convert",
				LogStatus.STARTED));

			if ((generatedProgressBars.Count == generatedSaveButtons.Count) &&
				(generatedSaveButtons.Count == filePaths.Length))
			{
				semaphore = new SemaphoreSlim(0);

				foreach (string path in filePaths)
				{
					Logger.Instance.Enqueue(new Log($"Queued user work on threadpool for file at [{path}] to {currentTarget.Extension}",
					LogStatus.NONE));
					ThreadPool.QueueUserWorkItem(ProcessTextFileConversion, path);
				}

				for (int i = 0; i < filePaths.Length; i++)
				{
					semaphore.Wait();
				}

				saveAllButton.Invoke((Action)(() =>
				{
					saveAllButton.Enabled = true;
				}));
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Text conversion background worker [{Thread.CurrentThread.ManagedThreadId}] component number mismatch " +
					$" > {nameof(generatedProgressBars.Count)} : {generatedProgressBars.Count} " +
					$" > {nameof(generatedSaveButtons.Count)} : {generatedSaveButtons.Count}" +
					$" > {nameof(filePaths.Length)} : {filePaths.Length}",
				LogStatus.ERROR));

				MessageBox.Show($"A problem with selected files occured, did you delete a selected file from your disk?",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}
		}

		private void ProcessTextFileConversion(object param)
		{
			Stream stream;
			string filePath = param as string;
			lock (textFileOpenDialog)
			{
				textFileOpenDialog.FileName = filePath;
				stream = textFileOpenDialog.OpenFile();
			};

			if (stream != null)
			{
				if (currentTarget.Extension.Equals(TextFileType.Pdf.Extension))
				{
					PdfFileConverter pdfFileConverter = new PdfFileConverter();
					pdfFileConverter.FileStartConverting += OnFileStartConverting;
					pdfFileConverter.FileConverting += OnFileConverting;
					pdfFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] launched conversion of file [{filePath}]",
						LogStatus.NONE, pdfFileConverter));
					convertedFiles.Add(filePath, pdfFileConverter.ConvertFile(stream, filePath));
				}
				else if (currentTarget.Extension.Equals(TextFileType.Word.Extension))
				{
					NotYetImplementedMessageBox();
				}
				else if (currentTarget.Extension.Equals(TextFileType.Txt.Extension))
				{
					TextFileConverter textFileConverter = new TextFileConverter();
					textFileConverter.FileStartConverting += OnFileStartConverting;
					textFileConverter.FileConverting += OnFileConverting;
					textFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.NONE, textFileConverter));
					convertedFiles.Add(filePath, textFileConverter.ConvertFile(stream, filePath));
				}
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Selected file at [{filePath}] was not found on disk",
				LogStatus.ERROR));
				MessageBox.Show($"The selected file was not found on disk, did you delete the file after selecting it?",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}

			semaphore.Release();
			return;
		}

		private void NotYetImplementedMessageBox()
		{
			Logger.Instance.Enqueue(new Log($"Selected target feature isn't implemented",
				LogStatus.NOT_IMPLEMENTED));
			MessageBox.Show($"The selected file target is not yet implemented",
				"Not yet implemented",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}

		private void DarkModeSwitch_CheckedChanged(object sender, EventArgs e)
		{
			materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
			Invalidate();
		}
	}
}