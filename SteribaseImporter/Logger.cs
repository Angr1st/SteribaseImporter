using Serilog;
using System;

namespace SteribaseImporter
{
    class Logger
    {
        private static readonly Serilog.Core.Logger GetLogger = new LoggerConfiguration()
        .WriteTo.File("log.txt")
        .CreateLogger();

        public static void LogException(string logText, Exception exception)
        {
            GetLogger.Error(exception, logText);
        }

        public static void LogInformation(string logText)
        {
            GetLogger.Information(logText);
        }
    }
}
