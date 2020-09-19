namespace PDF_Generator.Model
{
	internal class FileType
	{
		public string Value { get; set; }
		public string Extension { get; set; }

		public string GetFilter()
		{
			return $"{Value}|*{Extension}";
		}
	}
}