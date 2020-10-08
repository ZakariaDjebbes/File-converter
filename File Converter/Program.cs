using System;
using System.Threading;
using System.Windows.Forms;
using File_Converter.Logging;

namespace File_Converter
{
	internal static class Program
	{
		public static MainForm MainForm { get; private set; }

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			Application.ThreadException += Application_ThreadException;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			MainForm = new MainForm();
			Application.Run(MainForm);
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			Logger.Instance.Enqueue(new Log($"Exception occured: {e.Exception} of type {e.Exception.GetType()} | " +
				$"Message: {e.Exception.Message} | " +
				$"Source: {e.Exception.Source} | " +
				$"StackTrace: {e.Exception.StackTrace}", 
				LogStatus.ERROR));

			MessageBox.Show($"And unhandeled exception occured" +
				$"\r\nType: {e.Exception.GetType()}" +
				$"\r\nMessage: {e.Exception.Message}" +
				$"\r\nSource: {e.Exception.Source}",
				"An error occured",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error);
		}
	}
}