using System;
using System.IO;
using System.Drawing;
using File_Converter.Model;
using System.Drawing.Imaging;

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
				result = WebpToGif(path);
			}

			OnFileConverted(path, result);
		}

		private string WebpToGif(string path)
		{
			string tempPath = GetTempPath();

			return tempPath;
		}
	}
}