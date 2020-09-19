using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FileConverter.Control;
using FileConverter.Model;
using MaterialSkin;
using MaterialSkin.Controls;
using PDF_Generator.Model;

namespace FileConverter
{
	public partial class MainForm : MaterialForm
	{
		private FileType current_target = new FileType();

		public MainForm()
		{
			InitializeComponent();
			//material skin theme
			var materialSkinManager = MaterialSkinManager.Instance;
			materialSkinManager.AddFormToManage(this);
			materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
			//setting up the pdfFileConverter
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//textfile combobox
		}

		private void TextFileOpenDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
		{
			//set file name label
			fileChosenNameLabel.Text = textFileOpenDialog.SafeFileName;

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
		}

		private void ChooseTextFileButton_Click(object sender, System.EventArgs e)
		{
			textFileOpenDialog.ShowDialog();
		}

		private void TextFileConvertToComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			convertTextFileButton.Enabled = true;
		}

		private void ConvertTextFileButton_Click(object sender, EventArgs e)
		{
			//clear logs
			textFileConversionLog.Text = string.Empty;

			//convert
			string currentFileExtension = Path.GetExtension(textFileOpenDialog.FileName);
			string convertToExtension = textFileConvertToComboBox.SelectedValue as string;

			current_target = TextFileType.Parse(convertToExtension);

			if (TextFileType.Exists(convertToExtension) && TextFileType.Exists(currentFileExtension))
			{
				if (!textFileConversionBackgroundWorker.IsBusy)
				{
					if (current_target == null)
					{
						MessageBox.Show($"Target file type is empty, please try again.",
							"An error has occured",
							MessageBoxButtons.OK,
							MessageBoxIcon.Error);
					}

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						string fullPath = string.IsNullOrEmpty(Path.GetExtension(saveFileDialog.FileName)) ?
							saveFileDialog.FileName + current_target.Extension : saveFileDialog.FileName;

						textFileConversionBackgroundWorker.RunWorkerAsync(argument: fullPath);
					}
				}
				else
				{
					MessageBox.Show($"A file is currently beign converted, please wait or cancel the conversion",
						"An error has occured",
						MessageBoxButtons.OKCancel,
						MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show($"An error with file extensions has occured, please reselect your file",
					"An error has occured",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);

				fileChosenNameLabel.Text = "No file chosen...";
				convertTextFileButton.Enabled = false;
				textFileConvertToComboBox.Enabled = false;
			}
		}

		private void OnFileStartConverting(object sender, EventArgs e)
		{
			textFileConvertProgressBar.Invoke((Action)(() =>
			{
				textFileConvertProgressBar.Value = 0;
			}));

			textFileConversionLog.Invoke((Action)(() =>
			{
				textFileConversionLog.AppendText($"Conversion of file {textFileOpenDialog.SafeFileName} starting");
			}));
		}

		private void OnFileConverting(object sender, ConvertLogArgs e)
		{
			textFileConversionLog.Invoke((Action)(() =>
			{
				textFileConversionLog.AppendText($"\r\n{e.ConversionPercent}% : Conversion of line " +
				$"{e.CurrentLine}");
			}));

			textFileConvertProgressBar.Invoke((Action)(() =>
			{
				textFileConvertProgressBar.Value = e.ConversionPercent;
			}));
		}

		private void OnFileConverted(object sender, EventArgs e)
		{
			textFileConversionLog.Invoke((Action)(() =>
			{
				textFileConversionLog.AppendText("\r\n ----------------------------------------------" +
					"\r\n File converted and saved with success");
			}));
		}

		private void TextFileConversionBackgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Stream stream;

			if ((stream = textFileOpenDialog.OpenFile()) != null)
			{
				if (current_target.Extension.Equals(TextFileType.Pdf.Extension))
				{
					PdfFileConverter pdfFileConverter = new PdfFileConverter();
					pdfFileConverter.FileStartConverting += OnFileStartConverting;
					pdfFileConverter.FileConverting += OnFileConverting;
					pdfFileConverter.FileConverted += OnFileConverted;

					pdfFileConverter.TextToPdf(stream, (string) e.Argument);
				}
				else if (current_target.Extension.Equals(TextFileType.Word.Extension))
				{
					NotYetImplementedMessageBox();
				}
				else if (current_target.Extension.Equals(TextFileType.Txt.Extension))
				{
					NotYetImplementedMessageBox();
				}
			}
			else
			{
				MessageBox.Show($"The selected file was not found on disk, did you delete the file after selecting it?",
				"An error has occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
			}
		}

		private void NotYetImplementedMessageBox()
		{
			MessageBox.Show($"The selected conversion target is not yet implemented",
				"Not yet implemented",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
		}
	}
}