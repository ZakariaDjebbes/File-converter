﻿using System;
using System.Collections.Generic;
using PDF_Generator.Model;

namespace FileConverter.Model
{
	internal class TextFileType : FileType
	{
		private readonly static Dictionary<string, TextFileType> valuePairs;

		public static readonly TextFileType Txt = new TextFileType("Text file (*.txt)", ".txt");
		public static readonly TextFileType Pdf = new TextFileType("Portable Document Format (*.pdf)", ".pdf");
		public static readonly TextFileType Word = new TextFileType("Word file (*.docx)", ".docx");

		static TextFileType()
		{
			valuePairs = new Dictionary<string, TextFileType>
			{
				{ Txt.Extension, Txt },
				{ Pdf.Extension, Pdf },
				{ Word.Extension, Word }
			};
		}

		private TextFileType(string value, string extension)
		{
			Value = value;
			Extension = extension;
		}

		public static TextFileType Parse(string extension)
		{
			Exception exception = new Exception($"Cannot find any text file type for extension {extension} in {nameof(TextFileType)}");
			
			if(string.IsNullOrEmpty(extension))
			{
				throw exception;
			}

			if(!valuePairs.ContainsKey(extension))
			{
				throw exception;
			}

			return valuePairs[extension];
		}

		public static List<TextFileType> AsList(List<string> exclude = null)
		{
			List<TextFileType> textFiles = new List<TextFileType>();

			foreach (var fileType in valuePairs.Values)
			{
				if (exclude.Contains(fileType.Extension))
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