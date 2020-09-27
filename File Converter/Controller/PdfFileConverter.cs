using System;
using System.IO;
using File_Converter.Debug;
using File_Converter.Model;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace File_Converter.Controller
{
	public class PdfFileConverter : FileConverter
	{
		public override byte[] ConvertFile(Stream stream, string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			MemoryStream resultStream = new MemoryStream();

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				resultStream = TextToPdf(stream, path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path);
			return resultStream.ToArray();
		}

		private MemoryStream TextToPdf(Stream stream, string path)
		{
			MemoryStream resultStream = new MemoryStream();
			StreamReader streamReader = new StreamReader(stream);
			int lineCount = GetNumberOfLines(streamReader);
			PdfWriter writer = new PdfWriter(resultStream);
			PdfDocument pdf = new PdfDocument(writer);
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
			return resultStream;
		}
	}
}