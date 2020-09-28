using System;
using System.IO;
using File_Converter.Model;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace File_Converter.Controller
{
	public class TextFileConverter : FileConverter
	{
		public override void ConvertFile(Stream stream, string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Pdf.Extension))
			{
				result = PdfToText(stream, path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path, result);
		}

		private string PdfToText(Stream stream, string path)
		{
			string tempPath = Path.GetTempFileName();

			using (stream)
			{
				using PdfReader reader = new PdfReader(stream);
				using PdfDocument pdf = new PdfDocument(reader);

				int numberOfPages = pdf.GetNumberOfPages();

				using (StreamWriter writer = new StreamWriter(tempPath))
				{
					for (int i = 1; i <= numberOfPages; i++)
					{
						FilteredEventListener listener = new FilteredEventListener();
						LocationTextExtractionStrategy extractionStrategy =
							listener.AttachEventListener(new LocationTextExtractionStrategy());
						PdfCanvasProcessor parser = new PdfCanvasProcessor(listener);
						parser.ProcessPageContent(pdf.GetPage(i));

						writer.WriteLine(extractionStrategy.GetResultantText());
						int percent = i * 100 / numberOfPages;
						OnFileConverting(path, percent, i);
					}
				}
			}
			return tempPath;
		}
	}
}