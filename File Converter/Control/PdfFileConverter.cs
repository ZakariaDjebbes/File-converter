using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace File_Converter.Control
{
	public class PdfFileConverter : FileConverter
	{
		public void TextToPdf(Stream stream, string path)
		{
			OnFileStartConverting();

			using (StreamReader streamReader = new StreamReader(stream))
			{
				int lineCount = GetNumberOfLines(streamReader);
				PdfDocument pdf = new PdfDocument(new PdfWriter(path));
				Document document = new Document(pdf);

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
			}

			OnFileConverted();
		}
	}
}