using System;
using System.Drawing.Imaging;
using System.IO;
using File_Converter.Model;

namespace File_Converter.Controller.ImageConversion
{
	internal class JpgFileConverter : FileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			ImageFileType current = ImageFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(ImageFileType.Png.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Jpeg);
			}
			else if (current.Extension.Equals(ImageFileType.Gif.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Jpeg);
			}
			else if (current.Extension.Equals(ImageFileType.Webp.Extension))
			{
				throw new NotImplementedException();
			}
			else if (current.Extension.Equals(ImageFileType.Bmp.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Jpeg);
			}
			else if (current.Extension.Equals(ImageFileType.Tiff.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Jpeg);
			}
			else if (current.Extension.Equals(ImageFileType.Ico.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Jpeg);
			}

			OnFileConverted(path, result);
		}
	}
}