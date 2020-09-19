using System;
using System.IO;

namespace File_Converter.Control
{
	public class ConvertLogArgs : EventArgs
	{
		public int ConversionPercent { get; set; }
		public int CurrentLine { get; set; }
	}

	public abstract class FileConverter
	{
		public EventHandler FileStartConverting;
		public EventHandler<ConvertLogArgs> FileConverting;
		public EventHandler FileConverted;

		protected virtual void OnFileStartConverting()
			=> FileStartConverting?.Invoke(this, EventArgs.Empty);

		protected virtual void OnFileConverting(int percent, int line)
			=> FileConverting?.Invoke(this, new ConvertLogArgs()
			{
				ConversionPercent = percent,
				CurrentLine = line
			});

		protected virtual void OnFileConverted() 
			=> FileConverted?.Invoke(this, EventArgs.Empty);

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