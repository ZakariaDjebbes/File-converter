using System;
using System.Collections.Generic;
using System.Reflection;

namespace File_Converter.Model
{
	public class ArchiveFileType : FileType
	{
		private readonly static Dictionary<string, ArchiveFileType> valuePairs;

		public static readonly ArchiveFileType Zip = new ArchiveFileType("Zip file (*.zip)", ".zip");
		public static readonly ArchiveFileType Rar = new ArchiveFileType("Rar file (*.rar)", ".rar");


		static ArchiveFileType()
		{
			valuePairs = new Dictionary<string, ArchiveFileType>
			{
				{ Zip.Extension, Zip},
				{ Rar.Extension, Rar },
		
			};
		}

		private ArchiveFileType(string value, string extension) 
		{
			Value = value;
			Extension = extension;
		}

		public static ArchiveFileType Parse(string extension)
		{
			if (string.IsNullOrEmpty(extension) && !valuePairs.ContainsKey(extension))
			{
				Exception exception = new Exception($"Cannot find any {MethodBase.GetCurrentMethod().DeclaringType} for extension {extension} in {nameof(TextFileType)}");

				throw exception;
			}

			return valuePairs[extension];
		}

		public static List<ArchiveFileType> AsList(List<string> exclude = null)
		{
			List<ArchiveFileType> archiveFiles = new List<ArchiveFileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude.Contains(fileType.Extension))
				{
					continue;
				}

				archiveFiles.Add(fileType);
			}

			return archiveFiles;
		}

		public static bool Exists(string extension)
		{
			return valuePairs.ContainsKey(extension);
		}
	}
}