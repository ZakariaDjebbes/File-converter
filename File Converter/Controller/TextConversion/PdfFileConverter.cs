using System;
using System.IO;
using File_Converter.Model;
using iText.Kernel.Pdf;
using Microsoft.Office.Core;
using Microsoft.Office.Interop.Word;

namespace File_Converter.Controller.TextConversion
{
	public class PdfFileConverter : FileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				result = TextToPdf(path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				result = WordToPdf(path);
			}

			OnFileConverted(path, result);
		}

		private string TextToPdf(string path)
		{
			string tempPath = GetTempPath();

			using PdfWriter writer = new PdfWriter(tempPath);
			using PdfDocument pdf = new PdfDocument(writer);
			using iText.Layout.Document document = new iText.Layout.Document(pdf);

			using (StreamReader streamReader = new StreamReader(path))
			{
				int lineCount = GetNumberOfLines(streamReader);
				int lineNumber = 1;

				while (!streamReader.EndOfStream)
				{
					string line = streamReader.ReadLine();
					iText.Layout.Element.Paragraph paragraph = new iText.Layout.Element.Paragraph(line);
					document.Add(paragraph);
					int percent = lineNumber * 100 / lineCount;
					OnFileConverting(path, percent);
					lineNumber++;
				}
			}

			return tempPath;
		}

		private string WordToPdf(string path)
		{
			string tempPath = GetTempPath();

			Application app = new Application();

			if (app == null)
			{
				throw new ApplicationException("Microsoft Word isn't installed on this computer");
			}

			app.DisplayAlerts = WdAlertLevel.wdAlertsNone;

			var objPresSet = app.Documents;
			var objPres = objPresSet.Open(path, MsoTriState.msoTrue, MsoTriState.msoTrue, MsoTriState.msoFalse);

			try
			{
				OnFileConverting(path, new Random().Next(0, 41));

				objPres.ExportAsFixedFormat(
					tempPath,
					WdExportFormat.wdExportFormatPDF,
					false,
					WdExportOptimizeFor.wdExportOptimizeForPrint,
					WdExportRange.wdExportAllDocument
				);

				OnFileConverting(path, new Random().Next(41, 81));
			}
			catch
			{
				tempPath = null;
			}
			finally
			{
				objPres.Close();
			}

			OnFileConverting(path, new Random().Next(81, 96));

			app.Quit();

			OnFileConverting(path, 100);

			return tempPath;
		}
	}
}