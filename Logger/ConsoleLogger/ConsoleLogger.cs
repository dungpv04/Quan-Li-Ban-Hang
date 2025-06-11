namespace Logger.ConsoleLogger
{
    public class ConsoleLogger : IConsoleLogger
    {
        private static readonly Lazy<ConsoleLogger> _instance = new(() => new ConsoleLogger());
        public static ConsoleLogger Instance => _instance.Value;

        private ConsoleLogger() { }

        public void LogInfo(string message) => Log("INFO", message);
        public void LogWarning(string message) => Log("WARNING", message);
        public void LogError(string message) => Log("ERROR", message);
        public void LogDebug(string message) => Log("DEBUG", message);

        private void Log(string level, string message)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}] {message}");
        }
    }
}
