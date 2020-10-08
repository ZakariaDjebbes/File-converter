using System;
using System.IO;
using File_Converter.Model;

namespace File_Converter.Controller.ImageConversion
{
	internal class WebPFileConverter : FileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			ImageFileType current = ImageFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(ImageFileType.Jpg.Extension))
			{
				throw new NotImplementedException();
			}
			else if (current.Extension.Equals(ImageFileType.Png.Extension))
			{
				throw new NotImplementedException();
			}
			else if (current.Extension.Equals(ImageFileType.Gif.Extension))
			{
				throw new NotImplementedException();
			}

			OnFileConverted(path, result);
		}
	}
}