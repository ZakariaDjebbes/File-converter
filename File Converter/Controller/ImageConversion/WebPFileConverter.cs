using System;
using System.Drawing;
using System.IO;
using File_Converter.Model;
using Imazen.WebP;

namespace File_Converter.Controller.ImageConversion
{
	internal class WebPFileConverter : ImageFileConverter
	{
		public override void ConvertFile(string path)
		{
			OnFileStartConverting(path);
			string ext = Path.GetExtension(path);
			ImageFileType current = ImageFileType.Parse(ext);
			string result = string.Empty;

			if (current.Extension.Equals(ImageFileType.Jpg.Extension))
			{
				result = ImageFormatToWebp(path);
			}
			else if (current.Extension.Equals(ImageFileType.Gif.Extension))
			{
				result = ImageFormatToWebp(path);
			}
			else if (current.Extension.Equals(ImageFileType.Tiff.Extension))
			{
				result = ImageFormatToWebp(path);
			}
			else if (current.Extension.Equals(ImageFileType.Bmp.Extension))
			{
				result = ImageFormatToWebp(path);
			}
			else if (current.Extension.Equals(ImageFileType.Png.Extension))
			{
				result = ImageFormatToWebp(path);
			}
			else if (current.Extension.Equals(ImageFileType.Ico.Extension))
			{
				result = ImageFormatToWebp(path);
			}

			OnFileConverted(path, result);
		}

		//TODO Animations lost with .gif
		private string ImageFormatToWebp(string path)
		{
			string tempPath = GetTempPath();

			OnFileConverting(path, new Random().Next(10, 20));

			using (Bitmap orignalImage = new Bitmap(path))
			{
				using (var saveImageStream = File.Open(tempPath, FileMode.Create))
				{
					OnFileConverting(path, new Random().Next(50, 75));
					var encoder = new SimpleEncoder();
					encoder.Encode(orignalImage, saveImageStream, 100);
				}
			}

			OnFileConverting(path, 100);

			return tempPath;
		}
	}
}