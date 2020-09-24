using System;
using System.IO;

namespace File_Converter.Controller
{
	public class ConvertionArgs : EventArgs
	{
		public string Path { get; set; }
	}

	public class ConvertingArgs : ConvertionArgs
	{
		public int ConversionPercent { get; set; }
		public int CurrentLine { get; set; }
	}

	public abstract class FileConverter
	{
		public EventHandler<ConvertionArgs> FileStartConverting;
		public EventHandler<ConvertingArgs> FileConverting;
		public EventHandler<ConvertionArgs> FileConverted;

		protected virtual void OnFileStartConverting(string path)
			=> FileStartConverting?.Invoke(this, new ConvertionArgs() { Path = path });

		protected virtual void OnFileConverting(string path, int percent, int line)
			=> FileConverting?.Invoke(this, new ConvertingArgs()
			{
				Path = path,
				ConversionPercent = percent,
				CurrentLine = line
			});

		protected virtual void OnFileConverted(string path)
			=> FileConverted?.Invoke(this, new ConvertionArgs() { Path = path });

		protected static int GetNumberOfLines(StreamReader streamReader, bool reset = true)
		{
			int lineCount = 0;

			while (streamReader.ReadLine() != null)
			{
				lineCount++;
			}

			if (reset)
			{
				streamReader.DiscardBufferedData();
				streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
			}

			return lineCount;
		}
	}
}