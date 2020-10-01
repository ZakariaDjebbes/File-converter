﻿using System;
using System.IO;
using File_Converter.Model;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace File_Converter.Controller
{
	public class PdfFileConverter : FileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				result = TextToPdf(path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path, result);
		}

		private string TextToPdf(string path)
		{
			string tempPath = GetTempPath();

			using PdfWriter writer = new PdfWriter(tempPath);
			using PdfDocument pdf = new PdfDocument(writer);
			using Document document = new Document(pdf);

			using (StreamReader streamReader = new StreamReader(path))
			{
				int lineCount = GetNumberOfLines(streamReader);
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
			}

			return tempPath;
		}

		private string WordToPdf(string path)
		{
			return null;
		}
	}
}