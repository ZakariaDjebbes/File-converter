using System;
using System.IO;
using System.Text;
using File_Converter.Model;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using Microsoft.Office.Interop.Word;

namespace File_Converter.Controller.TextConversion
{
	public class TextFileConverter : FileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Pdf.Extension))
			{
				result = PdfToText(path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				result = WordToText(path);
			}

			OnFileConverted(path, result);
		}

		private string PdfToText(string path)
		{
			string tempPath = GetTempPath();

			using PdfReader reader = new PdfReader(path);
			using PdfDocument pdf = new PdfDocument(reader);

			int numberOfPages = pdf.GetNumberOfPages();

			using (StreamWriter writer = new StreamWriter(tempPath, false, Encoding.UTF8))
			{
				for (int i = 1; i <= numberOfPages; i++)
				{
					FilteredEventListener listener = new FilteredEventListener();
					LocationTextExtractionStrategy extractionStrategy =
						listener.AttachEventListener(new LocationTextExtractionStrategy());
					PdfCanvasProcessor parser = new PdfCanvasProcessor(listener);
					PdfPage page = pdf.GetPage(i);
					parser.ProcessPageContent(page);

					writer.WriteLine(extractionStrategy.GetResultantText());
					int percent = i * 100 / numberOfPages;
					OnFileConverting(path, percent);
				}
			}
			return tempPath;
		}

		private string WordToText(string path)
		{
			string tempPath = GetTempPath();

			Application app = new Application();

			if (app == null)
			{
				throw new ApplicationException("Microsoft Word isn't installed on this computer");
			}

			Document doc = app.Documents.Open(path);
			string allWords = doc.Content.Text;
			string[] lines = allWords.Split(
				new[] { "\r\n", "\r", "\n" },
				StringSplitOptions.None
			);
			doc.Close();
			app.Quit();

			int numberOfLines = lines.Length;

			using (StreamWriter writer = new StreamWriter(tempPath, false, Encoding.UTF8))
			{
				for (int i = 0; i < numberOfLines; i++)
				{
					writer.WriteLine(lines[i]);
					int percent = (i + 1) * 100 / numberOfLines;
					OnFileConverting(path, percent);
				}
			}

			return tempPath;
		}
	}
}