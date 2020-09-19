using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace FileConverter.Control
{
	internal class PdfFileConverter : FileConverter
	{
		protected virtual void OnFileConverted(bool isSuccess) => FileConverted?.Invoke(
			this, EventArgs.Empty);

		public void TextToPdf(Stream stream, string path)
		{
			OnFileStartConverting();

			using (StreamReader streamReader = new StreamReader(stream))
			{
				int lineCount = GetNumberOfLines(streamReader);
				var pdf = new PdfDocument(new PdfWriter(path));
				var document = new Document(pdf);

				int lineNumber = 1;
				int percent = 0;

				while (!streamReader.EndOfStream)
				{
					string line = streamReader.ReadLine();
					Paragraph paragraph = new Paragraph(line);
					document.Add(paragraph);
					percent = lineNumber * 100 / lineCount;
					OnFileConverting(percent, lineNumber);
					lineNumber++;
				}
				document.Close();
				OnFileConverted(true);
			}
		}
	}
}