using System.Collections.Generic;
using System.IO;
using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace File_Converter.Controller
{
	public class TextFileConverter : FileConverter
	{
		public byte[] PdfToText(Stream stream, string path)
		{
			OnFileStartConverting(path);

			MemoryStream resultStream = new MemoryStream();
			StreamWriter writer = new StreamWriter(resultStream);

			PdfDocument pdf = new PdfDocument(new PdfReader(stream));
			FilteredEventListener listener = new FilteredEventListener();
			LocationTextExtractionStrategy extractionStrategy = 
				listener.AttachEventListener(new LocationTextExtractionStrategy());
			PdfCanvasProcessor parser = new PdfCanvasProcessor(listener);
			int numberOfPages = pdf.GetNumberOfPages();

			for (int i = 1; i <= numberOfPages; i++)
			{
				parser.ProcessPageContent(pdf.GetPage(i));
				writer.WriteLine(extractionStrategy.GetResultantText());
				int percent = i * 100 / numberOfPages;
				OnFileConverting(path, percent, i);
			}

			pdf.Close();
			writer.Flush();
			resultStream.Seek(0, SeekOrigin.Begin);
			OnFileConverted(path);

			return resultStream.ToArray();
		}
	}
}