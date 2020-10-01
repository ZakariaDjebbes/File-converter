using System;
using System.IO;
using System.Text;
using File_Converter.Model;
using iText.IO.Source;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using Syncfusion.Pdf.Graphics;

namespace File_Converter.Controller
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
				throw new NotImplementedException();
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
					OnFileConverting(path, percent, i);
				}
			}
			return tempPath;
		}

		private string WordToText(string path)
		{
			return null;
		}
	}
}