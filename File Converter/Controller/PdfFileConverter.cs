using System.IO;
using File_Converter.Debug;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace File_Converter.Controller
{
	public class PdfFileConverter : FileConverter
	{
		public byte[] TextToPdf(Stream stream, string path)
		{
			OnFileStartConverting(path);
			MemoryStream resultStream = new MemoryStream();
			StreamReader streamReader = new StreamReader(stream);
			int lineCount = GetNumberOfLines(streamReader);
			PdfDocument pdf = new PdfDocument(new PdfWriter(resultStream));
			Document document = new Document(pdf);

			int lineNumber = 1;
			while (!streamReader.EndOfStream)
			{
				string line = streamReader.ReadLine();
				Paragraph paragraph = new Paragraph(line);
				document.Add(paragraph);
				int percent = lineNumber * 100 / lineCount;
				OnFileConverting(path, percent, lineNumber);
				lineNumber++;
			}

			document.Close();

			OnFileConverted(path);
			return resultStream.ToArray();
		}
	}
}