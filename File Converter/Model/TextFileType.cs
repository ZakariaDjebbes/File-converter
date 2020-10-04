using System;
using System.Collections.Generic;
using System.Reflection;

namespace File_Converter.Model
{
	internal class TextFileType : FileType
	{
		private readonly static Dictionary<string, TextFileType> valuePairs;

		public static readonly TextFileType Txt = new TextFileType("Text file (*.txt)", ".txt");
		public static readonly TextFileType Pdf = new TextFileType("Portable Document Format (*.pdf)", ".pdf");
		public static readonly TextFileType Word = new TextFileType("Word file (*.docx)", ".docx");
		//public static readonly TextFileType Html = new TextFileType("Hypertext Markup Language (*.html)", ".html");
		
		static TextFileType()
		{
			valuePairs = new Dictionary<string, TextFileType>
			{
				{ Txt.Extension, Txt },
				{ Pdf.Extension, Pdf },
				{ Word.Extension, Word },
				//{ Html.Extension, Html}
			};
		}

		private TextFileType(string value, string extension)
		{
			Value = value;
			Extension = extension;
		}

		public static TextFileType Parse(string extension)
		{
			if (string.IsNullOrEmpty(extension) && !valuePairs.ContainsKey(extension))
			{
				Exception exception = new Exception($"Cannot find any {MethodBase.GetCurrentMethod().DeclaringType} for extension {extension} in {nameof(TextFileType)}");

				throw exception;
			}

			return valuePairs[extension];
		}

		public static List<TextFileType> AsList(List<string> exclude = null)
		{
			List<TextFileType> textFiles = new List<TextFileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude != null && exclude.Contains(fileType.Extension))
				{
					continue;
				}

				textFiles.Add(fileType);
			}

			return textFiles;
		}

		public static List<FileType> AsGenericList(List<string> exclude = null)
		{
			List<FileType> textFiles = new List<FileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude != null && exclude.Contains(fileType.Extension))
				{
					continue;
				}

				textFiles.Add(fileType);
			}

			return textFiles;
		}


		public static bool Exists(string extension)
		{
			return valuePairs.ContainsKey(extension);
		}
	}
}