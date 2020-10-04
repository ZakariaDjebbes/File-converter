namespace File_Converter.Extensions
{
	public static class ExtensionMethods
	{
		public static string ToFileLengthRepresentation(this long fileLength)
		{
			if (fileLength >= 1 << 30)
				return $"{fileLength >> 30}GB";

			if (fileLength >= 1 << 20)
				return $"{fileLength >> 20}MB";

			if (fileLength >= 1 << 10)
				return $"{fileLength >> 10}KB";

			return $"{fileLength}B";
		}

		public static double ToMegabytes(this long fileLength)
		{
			return fileLength / 1024f / 1024f;
		}

		public static string GetLine(this string text, int line)
		{
			string[] lines = text.Replace("\r", "").Split('\n');
			return lines.Length >= line ? lines[line - 1] : null;
		}
	}
}