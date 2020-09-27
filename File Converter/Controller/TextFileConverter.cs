using System;
using System.IO;
using File_Converter.Debug;
using File_Converter.Model;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace File_Converter.Controller
{
	public class TextFileConverter : FileConverter
	{
		public override byte[] ConvertFile(Stream stream, string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			MemoryStream resultStream = new MemoryStream();

			if (current.Extension.Equals(TextFileType.Pdf.Extension))
			{
				resultStream = PdfToText(stream, path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			resultStream.Seek(0, SeekOrigin.Begin);
			resultStream.Close();
			OnFileConverted(path);

			return resultStream.ToArray();
		}

		private MemoryStream PdfToText(Stream stream, string path)
		{
			MemoryStream resultStream = new MemoryStream();

			PdfReader reader = new PdfReader(stream);
			PdfDocument pdf = new PdfDocument(reader);
			FilteredEventListener listener = new FilteredEventListener();
			LocationTextExtractionStrategy extractionStrategy =
				listener.AttachEventListener(new LocationTextExtractionStrategy());
			PdfCanvasProcessor parser = new PdfCanvasProcessor(listener);
			int numberOfPages = pdf.GetNumberOfPages();

			using (StreamWriter writer = new StreamWriter(resultStream))
			{
				for (int i = 1; i <= numberOfPages; i++)
				{
					parser.ProcessPageContent(pdf.GetPage(i));
					writer.WriteLine(extractionStrategy.GetResultantText());
					int percent = i * 100 / numberOfPages;
					OnFileConverting(path, percent, i);
				}
			}
			
			pdf.Close();
			
			return resultStream;
		}
	}
}