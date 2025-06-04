using Logger.ConsoleLogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Decorator
{
    public class FileLoggerDecorator : IConsoleLogger
    {
        private readonly IConsoleLogger _innerLogger;
        private readonly string _filePath;

        public FileLoggerDecorator(IConsoleLogger innerLogger)
        {
            _innerLogger = innerLogger;
            _filePath = $"log_{DateTime.Now:yyyy-MM-dd_HH-mm-ss}.txt";
        }

        public void LogInfo(string message)
        {
            _innerLogger.LogInfo(message);
            WriteToFile("INFO", message);
        }

        public void LogWarning(string message)
        {
            _innerLogger.LogWarning(message);
            WriteToFile("WARNING", message);
        }

        public void LogError(string message)
        {
            _innerLogger.LogError(message);
            WriteToFile("ERROR", message);
        }

        public void LogDebug(string message)
        {
            _innerLogger.LogDebug(message);
            WriteToFile("DEBUG", message);
        }

        private void WriteToFile(string level, string message)
        {
            string logMessage = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}{Environment.NewLine}";
            File.AppendAllText(_filePath, logMessage);
        }
    }
}
