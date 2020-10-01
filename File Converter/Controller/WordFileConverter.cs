using System;
using System.IO;
using File_Converter.Model;
using Syncfusion.DocIO;
using Syncfusion.DocIO.DLS;

namespace File_Converter.Controller
{
	public class WordFileConverter : FileConverter
	{
		public object DocToPDFConverter { get; private set; }

		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				result = TextToWord(path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path, result);
		}

		private string TextToWord(string path)
		{
			string tempPath = GetTempPath();

			using (WordDocument document = new WordDocument())
			{
				using (StreamReader streamReader = new StreamReader(path))
				{
					int lineCount = GetNumberOfLines(streamReader);
					int lineNumber = 1;
					IWSection section = document.AddSection();
					IWParagraph paragraph = section.AddParagraph();
					int pItemsCap = 500;

					while (!streamReader.EndOfStream)
					{
						if (paragraph.Items.Count > pItemsCap)
						{
							paragraph = section.AddParagraph();
						}

						string line = streamReader.ReadLine();
						paragraph.AppendText(line);
						paragraph.AppendBreak(BreakType.LineBreak);
						int percent = lineNumber * 100 / lineCount;
						OnFileConverting(path, percent, lineNumber);
						lineNumber++;
					}
				}

				document.Save(tempPath, FormatType.Docx);
			}
			return tempPath;
		}

		private string PdfToWord(Stream stream, string path)
		{
			return null;
		}
	}
}