using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;

namespace File_Converter.Control
{
	public class TextFileConverter : FileConverter
	{
		public void PdfToText(Stream stream, string path)
		{
			OnFileStartConverting();
			
			List<string> pdfContent= new List<string>();

			PdfDocument pdf = new PdfDocument(new PdfReader(stream));
			FilteredEventListener listener = new FilteredEventListener();
			LocationTextExtractionStrategy extractionStrategy = 
				listener.AttachEventListener(new LocationTextExtractionStrategy());
			PdfCanvasProcessor parser = new PdfCanvasProcessor(listener);
			int numberOfPages = pdf.GetNumberOfPages();

			for (int i = 1; i <= numberOfPages; i++)
			{
				parser.ProcessPageContent(pdf.GetPage(i));
				pdfContent.Add(extractionStrategy.GetResultantText());
				int percent = i * 100 / numberOfPages;
				OnFileConverting(percent, i);
			}

			pdf.Close();
			File.WriteAllLines(path, pdfContent, Encoding.UTF8);
			OnFileConverted();
		}
	}
}