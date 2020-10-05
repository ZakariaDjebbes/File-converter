using System;
using System.Collections.Generic;

namespace File_Converter.Model
{
	public class FileType
	{
		public string Value { get; set; }

		public string Extension { get; set; }

		public string GetFilter()
		{
			return $"{Value}|*{Extension}";
		}

		public static string GetFilter(FileType fileType)
		{
			return $"{fileType.Value}|*{fileType.Extension}";
		}

		public static List<FileType> GetTypeAsGenericList(Type type, List<string> exclude = null)
		{
			if (type is null)
			{
				throw new ArgumentNullException(nameof(type));
			}

			if (!type.IsSubclassOf(typeof(FileType)))
			{
				throw new TypeAccessException($"Cannot return a list of file types using {type} " +
					$"because it doesn't inherit from {typeof(FileType)}");
			}

			if (type.Equals(typeof(TextFileType)))
			{
				return TextFileType.AsGenericList(exclude);
			}
			else if (type.Equals(typeof(ArchiveFileType)))
			{
				return ArchiveFileType.AsGenericList(exclude);
			}
			else if (type.Equals(typeof(ImageFileType)))
			{
				return ImageFileType.AsGenericList(exclude);
			}
			else
			{
				throw new NotImplementedException($"Cannot return a list of file types using {type} because its not yet implemented");
			}
		}
	}
}