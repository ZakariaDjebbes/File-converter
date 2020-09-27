using System;
using System.IO;
using File_Converter.Model;

namespace File_Converter.Controller
{
	public class WordFileConverter : FileConverter
	{
		public override byte[] ConvertFile(Stream stream, string path)
		{
			OnFileStartConverting(path);

			string ext = Path.GetExtension(path);
			TextFileType current = TextFileType.Parse(ext);
			MemoryStream resultStream = new MemoryStream();

			if (current.Extension.Equals(TextFileType.Txt.Extension))
			{
				
			}
			else if (current.Extension.Equals(TextFileType.Pdf.Extension))
			{
				throw new NotImplementedException();
			}

			resultStream.Seek(0, SeekOrigin.Begin);
			OnFileConverted(path);

			return resultStream.ToArray();
		}

		private MemoryStream TexTtoWord(Stream stream, string path)
		{
			MemoryStream resultStream = new MemoryStream();
			StreamWriter writer = new StreamWriter(resultStream);

			

			return resultStream;
		}
	}
}