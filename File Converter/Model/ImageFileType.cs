﻿using System;
using System.Collections.Generic;
using System.Reflection;

namespace File_Converter.Model
{
	public class ImageFileType : FileType
	{
		private readonly static Dictionary<string, ImageFileType> valuePairs;

		public static readonly ImageFileType Jpg = new ImageFileType("Joint Photographic Experts Group (*.jpg)", ".jpg");
		public static readonly ImageFileType Png = new ImageFileType("Portable Network Graphics (*.png)", ".png");
		public static readonly ImageFileType Gif = new ImageFileType("Graphics Interchange Format (*.gif)", ".gif");
		public static readonly ImageFileType Webp = new ImageFileType("WebP (*.webp)", ".webp");

		static ImageFileType()
		{
			valuePairs = new Dictionary<string, ImageFileType>
			{
				{Jpg.Extension, Jpg},
				{Png.Extension, Png},
				{Gif.Extension, Gif},
				{Webp.Extension, Webp},
			};
		}

		private ImageFileType(string value, string extension)
		{
			Value = value;
			Extension = extension;
		}

		public static ImageFileType Parse(string extension)
		{
			if (string.IsNullOrEmpty(extension) && !valuePairs.ContainsKey(extension))
			{
				Exception exception = new Exception($"Cannot find any {MethodBase.GetCurrentMethod().DeclaringType} for extension {extension} in {nameof(TextFileType)}");

				throw exception;
			}

			return valuePairs[extension];
		}

		public static List<ImageFileType> AsList(List<string> exclude = null)
		{
			List<ImageFileType> imageFiles = new List<ImageFileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude != null && exclude.Contains(fileType.Extension))
				{
					continue;
				}

				imageFiles.Add(fileType);
			}

			return imageFiles;
		}

		public static List<FileType> AsGenericList(List<string> exclude = null)
		{
			List<FileType> imageFiles = new List<FileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude != null && exclude.Contains(fileType.Extension))
				{
					continue;
				}

				imageFiles.Add(fileType);
			}

			return imageFiles;
		}

		public static bool Exists(string extension)
		{
			return valuePairs.ContainsKey(extension);
		}
	}
}