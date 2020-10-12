using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Imazen.WebP;

namespace File_Converter.Controller.ImageConversion
{
	internal abstract class ImageFileConverter : FileConverter
	{
		protected string ToImageFormat(string path, ImageFormat format)
		{
			string tempPath = GetTempPath();
			using Image img = Image.FromFile(path);
			OnFileConverting(path, new Random().Next(15, 69));
			img.Save(tempPath, format);
			OnFileConverting(path, 100);

			return tempPath;
		}

		protected string WebpToFileFormat(string path, ImageFormat format)
		{
			string tempPath = GetTempPath();

			using FileStream fileStream = File.OpenRead(path);
			using MemoryStream stream = new MemoryStream();
			fileStream.CopyTo(stream);

			SimpleDecoder decoder = new SimpleDecoder();
			Bitmap result = decoder.DecodeFromBytes(stream.ToArray(), stream.Length);
			result.Save(tempPath, format);

			return tempPath;
		}
	}
}