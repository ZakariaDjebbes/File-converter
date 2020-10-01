namespace File_Converter.Logging
{
	internal enum LogStatus
	{
		DONE = 0,
		ERROR = 1,
		EMPTY = 2,
		STARTED = 3,
		ONGOING = 4,
		ENDED = 5,
		UNKNOWN = 6,
		NONE = 7,
		NOT_IMPLEMENTED = 8,
		BUSY = 9,
		SAVED = 10
	}

	internal class Log
	{
		public string Message { get; set; }
		public LogStatus Log_Status { get; set; }
		public object Caller { get; set; }

		public Log(string message, LogStatus log_Status = LogStatus.EMPTY, object caller = null)
		{
			Message = message;
			Log_Status = log_Status;
			Caller = caller;
		}

		public Log(string message)
		{
			Message = message;
			Log_Status = LogStatus.EMPTY;
			Caller = null;
		}

		public override string ToString()
		{
			return $"{nameof(Message)}:{Message}, {nameof(Log_Status)}:{Log_Status}, {nameof(Caller)};{Caller}";
		}
	}
}