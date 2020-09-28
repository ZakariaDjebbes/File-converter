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

	public class ConvertedArgs : ConvertionArgs
	{
		public string TempPath { get; set; }
	}

	public abstract class FileConverter
	{
		protected static Dictionary<string, string> convertedFiles = new Dictionary<string, string>();

		public EventHandler<ConvertionArgs> FileStartConverting;
		public EventHandler<ConvertingArgs> FileConverting;
		public EventHandler<ConvertedArgs> FileConverted;

		public static int ConvertedFilesCount() => convertedFiles.Count;

		public static byte[] GetByteArrayOfTempFile(string tempPath)
		{
			if(!convertedFiles.ContainsValue(tempPath))
			{
				throw new FileNotFoundException($"Temporary file at {tempPath} does not exist.");
			}

			return File.ReadAllBytes(tempPath);
		}

		public static byte[] GetByteArrayOfPath(string path)
		{
			if (!convertedFiles.ContainsKey(path))
			{
				throw new FileNotFoundException($"Temporary file at {convertedFiles[path]} for key {path} does not exist.");
			}

			return File.ReadAllBytes(convertedFiles[path]);
		}

		private static void DeleteTmpFile(string tempFile)
		{
			try
			{
				if (File.Exists(tempFile))
				{
					File.Delete(tempFile);
				}
			}
			catch (Exception ex)
			{
				Logger.Instance.Enqueue(new Log($"Could not delete file at {tempFile}, {ex.Message}", LogStatus.ERROR));
			}
		}

		public abstract void ConvertFile(Stream stream, string path);

		protected virtual void OnFileStartConverting(string path)
			=> FileStartConverting?.Invoke(this, new ConvertionArgs() { Path = path });

		protected virtual void OnFileConverting(string path, int percent, int line)
			=> FileConverting?.Invoke(this, new ConvertingArgs()
			{
				Path = path,
				ConversionPercent = percent,
				CurrentLine = line
			});

		protected virtual void OnFileConverted(string path, string tempPath)
		{
			if(convertedFiles.ContainsKey(path))
			{
				string oldTempPath = convertedFiles[path];
				DeleteTmpFile(oldTempPath);
				convertedFiles.Remove(path);
			}

			convertedFiles.Add(path, tempPath);

			FileConverted?.Invoke(this, new ConvertedArgs()
			{
				Path = path,
				TempPath = tempPath
			});
		}

		public static void ClearGeneratedFiles()
		{
			foreach (var item in convertedFiles)
			{
				string tempPath = item.Value;
				DeleteTmpFile(tempPath);
			}

			convertedFiles.Clear();
		}

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

		public static void SaveByteArrayToDisk(string path, string saveTo)
		{
			File.WriteAllBytes(saveTo, GetByteArrayOfPath(path));
			Logger.Instance.Enqueue(new Log($"file saved at [{path}]", LogStatus.SAVED));
		}

		public static void SaveByteArrayToZip(string path, FileType fileType)
		{
			using (var fileStream = new FileStream(path, FileMode.Create))
			{
				using (var archive = new ZipArchive(fileStream, ZipArchiveMode.Create, true))
				{
					foreach (var item in convertedFiles)
					{
						var bytes = GetByteArrayOfTempFile(item.Value);
						var fileName = Path.GetFileNameWithoutExtension(item.Key) + fileType.Extension;
						var zipArchiveEntry = archive.CreateEntry(fileName, CompressionLevel.Fastest);
						using (var zipStream = zipArchiveEntry.Open())
							zipStream.Write(bytes, 0, bytes.Length);

						Logger.Instance.Enqueue(new Log($"file [{fileName}] saved in zip file at [{path}]", LogStatus.SAVED));
					}
				}
			}
		}
	}
}