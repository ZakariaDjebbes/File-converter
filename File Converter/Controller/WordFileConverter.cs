using System;
using System.IO;
using File_Converter.Model;

namespace File_Converter.Controller
{
	public class WordFileConverter : FileConverter
	{
		public override void ConvertFile(Stream stream, string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				result = TextToWord(stream, path);
			}
			else if (current.Extension.Equals(TextFileType.Word.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path, result);


			//OnFileConverted(path);
		}

		private string TextToWord(Stream stream, string path)
		{
			string tempPath = Path.GetTempFileName();

			return tempPath;
		}
	}
}