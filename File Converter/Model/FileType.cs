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
	}
}