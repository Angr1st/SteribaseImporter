using System;
using System.Collections.Generic;
using System.Text;
using Serilog;

namespace SteribaseImporter
{
    class Logger
    {
        private static Serilog.Core.Logger GetLogger = new LoggerConfiguration()
        .WriteTo.File("log.txt")
        .CreateLogger();

        public static void LogException(string logText, Exception exception)
        {
            GetLogger.Error(exception, logText);
        }
    }
}
