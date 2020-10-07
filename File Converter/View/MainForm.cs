using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using File_Converter.Controller;
using File_Converter.Controller.ImageConversion;
using File_Converter.Controller.TextConversion;
using File_Converter.Logging;
using File_Converter.Model;
using File_Converter.View;
using MaterialSkin;
using MaterialSkin.Controls;

namespace File_Converter
{
	public partial class MainForm : MaterialForm
	{
		private readonly MaterialSkinManager materialSkinManager;
		private DebugLogWindow logWindow = null;
		private FileType currentTarget;
		private Dictionary<string, MaterialProgressBar> generatedProgressBars = new Dictionary<string, MaterialProgressBar>();
		private Dictionary<string, MaterialButton> generatedSaveButtons = new Dictionary<string, MaterialButton>();
		private Dictionary<string, Task> generatedTasks = new Dictionary<string, Task>();
		private List<Control> generatedControls = new List<Control>();
		private string[] filePaths;

		private MaterialButton saveAllButton;

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
			DrawerHighlightWithAccent = true;
			DrawerBackgroundWithAccent = true;
			DrawerUseColors = true;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			convertTextFilesButton.Enabled = false;
			//avoid horizonal scrollbar
			textFilesConversionTableLayoutPanel.Padding = new Padding(20, 0, 20, 0);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			FileConverter.ClearGeneratedFiles();
		}

		#region SETTINGS

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

		private void DarkModeSwitch_CheckedChanged(object sender, EventArgs e)
		{
			materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
			Invalidate();
		}

		#endregion SETTINGS

		#region GENERAL METHODS

		private void SetFileDialogFilters(Type fileType, FileDialog dialog)
		{
			if (fileType is null)
			{
				throw new ArgumentNullException(nameof(fileType));
			}

			if (dialog is null)
			{
				throw new ArgumentNullException(nameof(dialog));
			}

			if (!fileType.IsSubclassOf(typeof(FileType)))
			{
				throw new TypeAccessException($"Cannot set {nameof(fileOpenDialog)} using {fileType} " +
					$"because it doesn't inherit from {typeof(FileType)}");
			}

			SetFilters(dialog, FileType.GetTypeAsGenericList(fileType));
		}

		private void SetFilters(FileDialog dialog, List<FileType> types)
		{
			if (dialog is null)
			{
				throw new ArgumentNullException(nameof(dialog));
			}

			if (types is null)
			{
				throw new ArgumentNullException(nameof(types));
			}

			bool first = true;
			dialog.Filter = string.Empty;

			foreach (var type in types)
			{
				if (first)
				{
					dialog.Filter = type.GetFilter();
					first = false;
				}
				else
				{
					dialog.Filter += "|" + type.GetFilter();
				}
			}
		}

		private void SetLayout(Type fileType,
					string extension,
					TableLayoutPanel tableLayoutPanel,
					ComboBox comboBox,
					Button conversionButton)
		{
			#region NULL_CHECKS

			if (fileType is null)
			{
				throw new ArgumentNullException(nameof(fileType));
			}

			if (string.IsNullOrEmpty(extension))
			{
				throw new ArgumentException($"'{nameof(extension)}' cannot be null or empty", nameof(extension));
			}

			if (tableLayoutPanel is null)
			{
				throw new ArgumentNullException(nameof(tableLayoutPanel));
			}

			if (comboBox is null)
			{
				throw new ArgumentNullException(nameof(comboBox));
			}

			if (conversionButton is null)
			{
				throw new ArgumentNullException(nameof(conversionButton));
			}

			#endregion NULL_CHECKS

			//textfile combobox items
			List<FileType> types = FileType.GetTypeAsGenericList(fileType, exclude: new List<string>() { extension });
			BindingSource binding = new BindingSource();
			binding.DataSource = types;
			comboBox.DataSource = binding.DataSource;
			comboBox.DisplayMember = "Value";
			comboBox.ValueMember = "Extension";
			comboBox.SelectedIndex = 0;
			comboBox.Enabled = true;

			tableLayoutPanel.SuspendLayout();
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
				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				tableLayoutPanel.Controls.Add(fileNameLabel, 0, tableLayoutPanel.RowCount - 1);
				tableLayoutPanel.RowCount++;
				generatedControls.Add(fileNameLabel);
				//add progressbar
				MaterialProgressBar progressBar = new MaterialProgressBar()
				{
					Anchor = (AnchorStyles.Left | AnchorStyles.Right),
					Margin = new Padding(0, 5, 0, 5),
					Value = 0,
					Minimum = 0,
					Maximum = 100,
					Step = 1,
					Style = ProgressBarStyle.Continuous
				};

				tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				tableLayoutPanel.Controls.Add(progressBar, 0, tableLayoutPanel.RowCount - 1);
				tableLayoutPanel.RowCount++;

				//add buttons
				MaterialButton saveFileButton = new MaterialButton()
				{
					Anchor = AnchorStyles.None,
					Margin = new Padding(0, 5, 0, 5),
					Text = "Save file",
					Enabled = false,
				};

				saveAllButton = new MaterialButton()
				{
					Anchor = AnchorStyles.None,
					Margin = new Padding(0, 5, 0, 5),
					Text = $"Save all files ({ArchiveFileType.Zip.Extension})",
					Enabled = false
				};
				saveAllButton.Click += SaveAllButton_Click;

				saveFileButton.Click += (sender, EventArgs) => { SaveFileButton_Click(sender, EventArgs, filePath); };
				tableLayoutPanel.Controls.Add(saveFileButton, 1, tableLayoutPanel.RowCount - 3);
				tableLayoutPanel.SetRowSpan(saveFileButton, 2);

				generatedProgressBars.Add(filePath, progressBar);
				generatedSaveButtons.Add(filePath, saveFileButton);
			}

			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.SetColumnSpan(saveAllButton, 2);
			tableLayoutPanel.Controls.Add(saveAllButton, 1, tableLayoutPanel.RowCount - 1);
			tableLayoutPanel.RowCount++;

			//add a last auto size row to fill up blank spaces
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
			tableLayoutPanel.RowCount++;

			tableLayoutPanel.ResumeLayout();

			//enable conver button because new files!
			conversionButton.Enabled = true;
		}

		private string ResetAndGetExtensionOfFileOpenDialog(TableLayoutPanel panel)
		{
			filePaths = fileOpenDialog.FileNames;
			FileConverter.ClearGeneratedFiles();
			ClearTableLayoutPanel(panel);

			//empty previously generated progressbars & save buttons
			generatedProgressBars = new Dictionary<string, MaterialProgressBar>();
			generatedSaveButtons = new Dictionary<string, MaterialButton>();
			generatedTasks = new Dictionary<string, Task>();

			//since all files should be of the same extension (.txt, .pdf, .docx...) we can use the first file to reprenst all files
			//get file extension
			string ext = Path.GetExtension(fileOpenDialog.FileName);
			return ext;
		}

		private void CancelOrClear(TableLayoutPanel table)
		{
			if (generatedSaveButtons.Count == 0)
			{
				MessageBox.Show($"Nothing to clear or cancel for now",
					"Nothing to clear for the moment",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);
				return;
			}

			FileConverter.ClearGeneratedFiles();

			SuspendLayout();
			ClearTableLayoutPanel(table);

			generatedProgressBars.Clear();
			generatedSaveButtons.Clear();
			generatedTasks.Clear();
			generatedControls.Clear();
			filePaths = null;

			convertTextFilesButton.Enabled = false;
			saveAllButton.Visible = false;
			ResumeLayout();
		}

		private void SaveFileButton_Click(object sender, EventArgs e, string filePath)
		{
			saveFileDialog.Filter = currentTarget.GetFilter();
			saveFileDialog.FileName = Path.GetFileNameWithoutExtension(filePath);

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string saveTo = saveFileDialog.FileName;

				try
				{
					Logger.Instance.Enqueue(new Log($"Started saving file {Path.GetFileName(filePath)} to {saveTo}",
						LogStatus.STARTED));
					FileConverter.SaveConvertedFilesKeyValueToDisk(filePath, saveTo);
				}
				catch (FileNotFoundException exception)
				{
					Logger.Instance.Enqueue(new Log($"{exception.Message} | File with key {filePath} has no paired value in convertedFiles dictionary",
						LogStatus.ERROR));
					MessageBox.Show($"Temporary file {exception.FileName} doesn't exist, please convert files again, if the error persists try cleaning your temporary files",
						"File not found !",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				catch (IOException exception)
				{
					Logger.Instance.Enqueue(new Log($"Error at {exception.Source} | {exception.Message} | File with key {filePath} is used by another process",
						LogStatus.ERROR));
					MessageBox.Show($"File path selected at {saveTo} is used by another process, please make sure to close it before saving",
						"Selected file used by another process",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
			}
		}

		private void ClearTableLayoutPanel(TableLayoutPanel table)
		{
			table.SuspendLayout();
			if (table.Controls.Count > 0)
			{
				table.Controls.Clear();
				table.RowStyles.Clear();
				table.RowCount = 0;
				table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
				table.RowCount++;

				foreach (TableLayoutControlCollection item in table.Controls)
				{
					for (int i = item.Count - 1; i >= 0; --i)
						item[i].Dispose();
				}
			}
			table.ResumeLayout();
			Logger.Instance.Enqueue($"Table layout panel {table.Name} cleared | number of rows {table.RowCount} | number of columns {table.ColumnCount} | number of controls {table.Controls.Count}");
		}

		private bool IsFileLocked(FileInfo file)
		{
			try
			{
				using (FileStream stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None))
				{
					stream.Close();
				}
			}
			catch (IOException)
			{
				return true;
			}

			return false;
		}

		private bool CheckFiles(MaterialButton convertButton)
		{
			foreach (string path in filePaths)
			{
				if (!File.Exists(path) || IsFileLocked(new FileInfo(path)))
				{
					convertButton.Invoke((Action)(() =>
					{
						convertButton.Enabled = true;
					}));

					if (!File.Exists(path))
					{
						Logger.Instance.Enqueue(new Log($"A selected file at {path} doesn't exist",
						LogStatus.ERROR));

						MessageBox.Show($"Cannot find a selected file on disk, did you delete a file you selected?" +
							$"\r\n\r\nFile path: {path}",
						"File not found",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
						return false;
					}

					if (IsFileLocked(new FileInfo(path)))
					{
						Logger.Instance.Enqueue(new Log($"A selected file at {path} is used by another process",
						LogStatus.ERROR));

						MessageBox.Show($"A selected file is used by another process, please close it before converting." +
							$"\r\n\r\nFile path: {path}",
						"File used by another process",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
						return false;
					}
				}
			}

			return true;
		}

		private async void BeginConvertFiles(Action<string> action)
		{
			generatedTasks.Clear();

			foreach (string path in filePaths)
			{
				Logger.Instance.Enqueue(new Log($"Queued user work on threadpool for file at [{path}] to {currentTarget.Extension}",
				LogStatus.NONE));
				generatedTasks.Add(path, Task.Factory.StartNew(() => action(path)));
			}

			Logger.Instance.Enqueue(new Log($"Queued user work on threadpool for file at to {currentTarget.Extension}",
				LogStatus.NONE));

			await Task.WhenAll(generatedTasks.Values);

			saveAllButton.Invoke((Action)(() =>
			{
				saveAllButton.Enabled = true;
			}));
		}

		private bool CheckMicrosoftWordExists()
		{
			Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();

			if (app == null)
			{
				return false;
			}

			return true;
		}

		#endregion GENERAL METHODS

		#region TEXT FILE CONVERSION

		private void ChooseTextFileButton_Click(object sender, EventArgs e)
		{
			SetFileDialogFilters(typeof(TextFileType), fileOpenDialog);

			if (fileOpenDialog.ShowDialog() == DialogResult.OK)
			{
				string ext = ResetAndGetExtensionOfFileOpenDialog(textFilesConversionTableLayoutPanel);
				SetLayout(typeof(TextFileType), ext, textFilesConversionTableLayoutPanel, textFileConvertToComboBox, convertTextFilesButton);
			}
		}

		private void TextFileConvertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			convertTextFilesButton.Enabled = true;
		}

		private void ConvertTextFilesButton_Click(object sender, EventArgs e)
		{
			string convertToExtension = textFileConvertToComboBox.SelectedValue as string;

			currentTarget = TextFileType.Parse(convertToExtension);
			TextFileType currentFileType = TextFileType.Parse(Path.GetExtension(filePaths[0]));

			//start background worker
			if (!textFileConversionBackgroundWorker.IsBusy)
			{
				if ((currentTarget.Extension.Equals(TextFileType.Word.Extension)
					|| currentFileType.Extension.Equals(TextFileType.Word.Extension))
					&& !CheckMicrosoftWordExists())
				{
					Logger.Instance.Enqueue(new Log($"Microsoft word isn't intalled. Cannot convert file from or to {TextFileType.Word.GetFilter()} format.",
					LogStatus.ERROR));
					MessageBox.Show($"You cannot use this feature because Microsoft Word is not installed on your computer",
						"Microsoft word isn't installed",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

					return;
				}

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

		private void TextFileConversionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Logger.Instance.Enqueue(new Log($"Text conversion background worker [{Thread.CurrentThread.ManagedThreadId}] started > {nameof(filePaths)} : {filePaths.Length} files to convert",
				LogStatus.STARTED));

			if ((generatedProgressBars.Count == generatedSaveButtons.Count) &&
				(generatedSaveButtons.Count == filePaths.Length))
			{
				if (CheckFiles(convertTextFilesButton))
				{
					BeginConvertFiles(ProcessTextFileConversion);
				}
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Text conversion background worker [{Thread.CurrentThread.ManagedThreadId}] component number mismatch " +
					$" > {nameof(generatedProgressBars)} : {generatedProgressBars.Count} " +
					$" > {nameof(generatedSaveButtons)} : {generatedSaveButtons.Count}" +
					$" > {nameof(filePaths)} : {filePaths.Length}",
				LogStatus.ERROR));

				MessageBox.Show($"An internal problem with selected files occured, please try again",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}
		}

		private void ProcessTextFileConversion(string filePath)
		{
			try
			{
				if (currentTarget.Extension.Equals(TextFileType.Pdf.Extension))
				{
					PdfFileConverter pdfFileConverter = new PdfFileConverter();
					pdfFileConverter.FileStartConverting += OnFileStartConverting;
					pdfFileConverter.FileConverting += OnFileConverting;
					pdfFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] launched conversion of file [{filePath}]",
						LogStatus.NONE, pdfFileConverter));
					pdfFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(TextFileType.Word.Extension))
				{
					WordFileConverter wordFileConverter = new WordFileConverter();
					wordFileConverter.FileStartConverting += OnFileStartConverting;
					wordFileConverter.FileConverting += OnFileConverting;
					wordFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] launched conversion of file [{filePath}]",
						LogStatus.NONE, wordFileConverter));

					wordFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(TextFileType.Txt.Extension))
				{
					TextFileConverter textFileConverter = new TextFileConverter();
					textFileConverter.FileStartConverting += OnFileStartConverting;
					textFileConverter.FileConverting += OnFileConverting;
					textFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, textFileConverter));
					textFileConverter.ConvertFile(filePath);
				}
			}
			catch (IOException exception)
			{
				Logger.Instance.Enqueue(new Log($"Selected file at [{exception.Message}] was not found on disk",
				LogStatus.ERROR));
				MessageBox.Show($"Conversion of file [{Path.GetFileName(filePath)}] has been aborted" +
					$"\r\nFile was not found on disk at {filePath}, did you delete the file after selecting it?",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}
			catch (ApplicationException exception)
			{
				Logger.Instance.Enqueue(new Log($"Error : [{exception.Message}] | Source: {exception.Source}| word was not found on disk?",
				LogStatus.ERROR));
				MessageBox.Show($"Conversion of file [{Path.GetFileName(filePath)}] has been aborted" +
					$"\r\nMS word cannot be found in local machine",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}

			return;
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

		private void TextFileConversionCancelButton_Click(object sender, EventArgs e)
		{
			CancelOrClear(textFilesConversionTableLayoutPanel);
		}
		private void SaveAllButton_Click(object sender, EventArgs e)
		{
			saveFileDialog.Filter = FileType.GetFilter(ArchiveFileType.Zip);
			saveFileDialog.FileName = "Converted files";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				Logger.Instance.Enqueue(new Log($"Started saving {FileConverter.ConvertedFilesCount()} files to {saveFileDialog.FileName}",
					LogStatus.STARTED));
				FileConverter.SaveConvertedFilesByteArraysToZip(saveFileDialog.FileName, currentTarget);
			}
		}

		#endregion TEXT FILE CONVERSION

		private void SelectImageFilesButton_Click(object sender, EventArgs e)
		{
			SetFileDialogFilters(typeof(ImageFileType), fileOpenDialog);

			if (fileOpenDialog.ShowDialog() == DialogResult.OK)
			{
				string ext = ResetAndGetExtensionOfFileOpenDialog(imageFileConversionTableLayoutPanel);
				SetLayout(typeof(ImageFileType),
					ext,
					imageFileConversionTableLayoutPanel,
					imageFileConvertToComboBox,
					convertImageFilesButton);
			}
		}

		private void ImageFileConvertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			convertImageFilesButton.Enabled = true;
		}

		private void ConvertImageFilesButton_Click(object sender, EventArgs e)
		{
			string convertToExtension = imageFileConvertToComboBox.SelectedValue as string;

			currentTarget = ImageFileType.Parse(convertToExtension);

			//start background worker
			if (!imageFileConversionBackgroundWorker.IsBusy)
			{
				convertImageFilesButton.Enabled = false;
				imageFileConversionBackgroundWorker.RunWorkerAsync();
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Trying to convert image files while {nameof(imageFileConversionBackgroundWorker)} is busy",
					LogStatus.BUSY));
				MessageBox.Show($"You are currently converting files, you cannot start a new conversion until the ongoing one finishes or you cancel it.",
				"Worker currently busy",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
			}
		}

		private void ImageFileConversionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Logger.Instance.Enqueue(new Log($"Image conversion background worker [{Thread.CurrentThread.ManagedThreadId}] started > {nameof(filePaths)} : {filePaths.Length} files to convert",
				LogStatus.STARTED));

			if ((generatedProgressBars.Count == generatedSaveButtons.Count) &&
				(generatedSaveButtons.Count == filePaths.Length))
			{
				if (CheckFiles(convertTextFilesButton))
				{
					BeginConvertFiles(ProcessImageFileConversion);
				}
			}
			else
			{
				Logger.Instance.Enqueue(new Log($"Image conversion background worker [{Thread.CurrentThread.ManagedThreadId}] component number mismatch " +
					$" > {nameof(generatedProgressBars)} : {generatedProgressBars.Count} " +
					$" > {nameof(generatedSaveButtons)} : {generatedSaveButtons.Count}" +
					$" > {nameof(filePaths)} : {filePaths.Length}",
				LogStatus.ERROR));

				MessageBox.Show($"An internal problem with selected files occured, please try again",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}
		}

		private void ProcessImageFileConversion(string filePath)
		{
			try
			{
				if (currentTarget.Extension.Equals(ImageFileType.Jpg.Extension))
				{
					JpgFileConverter jpgFileConverter = new JpgFileConverter();
					jpgFileConverter.FileStartConverting += OnFileStartConverting;
					jpgFileConverter.FileConverting += OnFileConverting;
					jpgFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, jpgFileConverter));
					jpgFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(ImageFileType.Png.Extension))
				{
					PngFileConverter pngFileConverter = new PngFileConverter();
					pngFileConverter.FileStartConverting += OnFileStartConverting;
					pngFileConverter.FileConverting += OnFileConverting;
					pngFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, pngFileConverter));
					pngFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(ImageFileType.Gif.Extension))
				{
					GifFileConverter gifFileConverter = new GifFileConverter();
					gifFileConverter.FileStartConverting += OnFileStartConverting;
					gifFileConverter.FileConverting += OnFileConverting;
					gifFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, gifFileConverter));
					gifFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(ImageFileType.Webp.Extension))
				{
					WebPFileConverter webpFileConverter = new WebPFileConverter();
					webpFileConverter.FileStartConverting += OnFileStartConverting;
					webpFileConverter.FileConverting += OnFileConverting;
					webpFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, webpFileConverter));
					webpFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(ImageFileType.Bmp.Extension))
				{
					BmpFileConverter bmpFileConverter = new BmpFileConverter();
					bmpFileConverter.FileStartConverting += OnFileStartConverting;
					bmpFileConverter.FileConverting += OnFileConverting;
					bmpFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, bmpFileConverter));
					bmpFileConverter.ConvertFile(filePath);
				}
				else if (currentTarget.Extension.Equals(ImageFileType.Webp.Extension))
				{
					TiffFileConverter tiffFileConverter = new TiffFileConverter();
					tiffFileConverter.FileStartConverting += OnFileStartConverting;
					tiffFileConverter.FileConverting += OnFileConverting;
					tiffFileConverter.FileConverted += OnFileConverted;

					Logger.Instance.Enqueue(new Log($"Thread [{Thread.CurrentThread.ManagedThreadId}] started conversion of file [{filePath}]",
						LogStatus.STARTED, tiffFileConverter));
					tiffFileConverter.ConvertFile(filePath);
				}
			}
			catch (IOException exception)
			{
				Logger.Instance.Enqueue(new Log($"Selected file at [{exception.Message}] was not found on disk",
				LogStatus.ERROR));
				MessageBox.Show($"Conversion of file [{Path.GetFileName(filePath)}] has been aborted" +
					$"\r\nFile was not found on disk at {filePath}, did you delete the file after selecting it?",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}

			return;
		}
	}
}

//TODO Handle file sizes !
//double totalLenght = 0;
//foreach (string path in filePaths)
//{
//	long lenght = new FileInfo(path).Length;
//	if(lenght.ToMegabytes() > FileConverter.MAX_FILE_SIZE)
//	{
//		MessageBox.Show($"The size of the file at {path} exceeds {FileConverter.MAX_FILE_SIZE} MB",
//			"Selected file is too large",
//			MessageBoxButtons.OK,
//			MessageBoxIcon.Error);

//		Logger.Instance.Enqueue(new Log($"Size of selected file as {path} exceeds {FileConverter.MAX_FILE_SIZE} MB", LogStatus.ERROR));
//		return;
//	}
//	totalLenght += lenght.ToMegabytes();
//	Logger.Instance.Enqueue($"Size of selected file at {path} : {lenght.ToFileLengthRepresentation()}");
//}

//Logger.Instance.Enqueue($"Size of selected files ({filePaths.Length} file/s) : {Convert.ToInt64(totalLenght).ToFileLengthRepresentation()}");
//if (totalLenght > FileConverter.TOTAL_MAX_FILE_SIZE)
//{
//	MessageBox.Show($"The size of the selected files exceeds {FileConverter.TOTAL_MAX_FILE_SIZE} MB",
//		"Selected file is too large",
//		MessageBoxButtons.OK,
//		MessageBoxIcon.Error);
//	Logger.Instance.Enqueue(new Log($"Size of selected files exceeds {FileConverter.TOTAL_MAX_FILE_SIZE} MB", LogStatus.ERROR));
//	return;
//}