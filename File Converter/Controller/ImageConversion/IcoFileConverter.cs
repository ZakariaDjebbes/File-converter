using System;
using System.Drawing.Imaging;
using System.IO;
using File_Converter.Model;

namespace File_Converter.Controller.ImageConversion
{
	internal class IcoFileConverter : ImageFileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			ImageFileType current = ImageFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(ImageFileType.Jpg.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Icon);
			}
			else if (current.Extension.Equals(ImageFileType.Gif.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Icon);
			}
			else if (current.Extension.Equals(ImageFileType.Webp.Extension))
			{
				result = WebpToFileFormat(path, ImageFormat.Icon);
			}
			else if (current.Extension.Equals(ImageFileType.Png.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Icon);
			}
			else if (current.Extension.Equals(ImageFileType.Tiff.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Icon);
			}
			else if (current.Extension.Equals(ImageFileType.Bmp.Extension))
			{
				result = ToImageFormat(path, ImageFormat.Icon);
			}

			OnFileConverted(path, result);
		}
	}
}