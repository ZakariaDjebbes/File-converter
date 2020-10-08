using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace File_Converter.Logging
{
	public class LogArgs : EventArgs
	{
		public int percent { get; set; }
	}

	internal sealed class Logger
	{
		private static Logger instance = null;
		private static readonly object padlock = new object();

		//public EventHandler StartLogging;
		//public EventHandler<LogArgs> Logging;
		//public EventHandler EndLogging;

		private Logger()
		{
		}

		public static Logger Instance
		{
			get
			{
				lock (padlock)
				{
					if (instance == null)
					{
						instance = new Logger();
					}

					return instance;
				}
			}
		}

		private Queue<Log> Logs { get; set; } = new Queue<Log>();

		//private void OnStartLogging() => StartLogging?.Invoke(this, EventArgs.Empty);

		//private void OnLogging(int percent) => Logging?.Invoke(this, new LogArgs() { percent = percent });

		//private void OnEndLogging() => EndLogging?.Invoke(this, EventArgs.Empty);

		public void PrintToListView(ListView listView)
		{
			//OnStartLogging();
			listView.Invoke((Action)(() =>
			{
				int percent = 0;
				int total = Logs.Count;

				while (Logs.Count != 0)
				{
					Log log = Logs.Dequeue();
					string[] row = { log.Message, log.Log_Status.ToString(), log.Caller == null ? "Unknown" : log.Caller.ToString() };
					ListViewItem item = new ListViewItem(row);
					listView.Items.Add(item);
					//OnLogging(percent);
					percent = (total - Logs.Count) * 100 / total;
				}

				if (total != 0)
				{
					percent = (total - Logs.Count) * 100 / total;
				}
				//OnLogging(percent);
			}));
			//OnEndLogging();
		}

		public void Enqueue(IEnumerable<Log> logs)
		{
			foreach (var log in logs)
			{
				Logs.Enqueue(log);
			}
		}

		public void Enqueue(Log log)
		{
			Logs.Enqueue(log);
		}

		public void Enqueue(string message)
		{
			Logs.Enqueue(new Log(message));
		}

		public bool HasLogsToPrint()
		{
			return Logs.Count > 0;
		}
	}
}