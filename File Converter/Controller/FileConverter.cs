using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using File_Converter.Debug;
using File_Converter.Model;

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

		public static void SaveMemoryStreamToDisk(string path, byte[] bytes)
		{
			File.WriteAllBytes(path, bytes);
			Logger.Instance.Enqueue(new Log($"file saved at [{path}]", Log_Status.SAVED));
		}

		public static void SaveMemoryStreamsToZip(string path, IEnumerable<KeyValuePair<string, byte[]>> byteArrays, FileType fileType)
		{
			using (var fileStream = new FileStream(path, FileMode.Create))
			{
				using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create, true))
				{
					foreach (var item in byteArrays)
					{
						var pdfBytes = item.Value;
						var fileName = Path.GetFileNameWithoutExtension(item.Key) + fileType.Extension;
						var zipArchiveEntry = archive.CreateEntry(fileName, CompressionLevel.Fastest);
						using (var zipStream = zipArchiveEntry.Open())
							zipStream.Write(pdfBytes, 0, pdfBytes.Length);

						Logger.Instance.Enqueue(new Log($"file [{fileName}] saved in zip file at [{path}]", Log_Status.SAVED));
					}
				}
			}
		}
	}
}