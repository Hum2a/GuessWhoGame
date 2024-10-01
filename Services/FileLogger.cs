using System;
using System.IO;
using System.Threading.Tasks;

namespace GuessWhoGame.Services
{
    public class FileLogger
    {
        private readonly string logFilePath;

        public FileLogger(string customPath = null, string fileName = "app_log.txt")
        {
            // If a custom path is provided, use it; otherwise, default to LocalApplicationData
            if (!string.IsNullOrEmpty(customPath))
            {
                logFilePath = Path.Combine(customPath, fileName);
            }
            else
            {
                var logDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Logs");
                if (!Directory.Exists(logDirectory))
                {
                    Directory.CreateDirectory(logDirectory);
                }
                logFilePath = Path.Combine(logDirectory, fileName);
            }
        }

        public async Task LogAsync(string message)
        {
            var logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            await File.AppendAllTextAsync(logFilePath, logMessage);
        }

        public void Log(string message)
        {
            var logMessage = $"{DateTime.Now}: {message}{Environment.NewLine}";
            File.AppendAllText(logFilePath, logMessage);
        }
    }
}
