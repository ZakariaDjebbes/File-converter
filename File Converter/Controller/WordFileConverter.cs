using System.IO;
using File_Converter.Model;
using SautinSoft;
using Word = Microsoft.Office.Interop.Word;

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
			else if (current.Extension.Equals(TextFileType.Pdf.Extension))
			{
				result = PdfToWord(path);
			}

			OnFileConverted(path, result);
		}

		private string TextToWord(string path)
		{
			string tempPath = GetTempPath();

			Word.Application app = new Word.Application();
			Word.Document document = app.Documents.Add();

			object start = 0;
			object end = 0;

			using (StreamReader streamReader = new StreamReader(path))
			{
				int lineCount = GetNumberOfLines(streamReader);
				int lineNumber = 1;

				while (!streamReader.EndOfStream)
				{
					string line = streamReader.ReadLine();
					Word.Range rng = document.Range(ref start, ref end);
					rng.Text += line + "\n";
					int percent = lineNumber * 100 / lineCount;
					OnFileConverting(path, percent);
					lineNumber++;
				}
			}

			document.SaveAs2(tempPath);
			document.Close();
			app.Quit();

			return tempPath;
		}

		private string PdfToWord(string path)
		{
			string tempPath = GetTempPath();
			PdfFocus pdf = new PdfFocus();
			pdf.OpenPdf(path);

			if(pdf.PageCount > 0)
			{
				pdf.WordOptions.Format = PdfFocus.CWordOptions.eWordDocument.Docx;
				pdf.NotifyPageProgress += (current, total) => {
					int percent = current * 100 / total;
					OnFileConverting(path, percent);
				};
				pdf.ToWord(tempPath);
			}

			return tempPath;
		}
	}
}