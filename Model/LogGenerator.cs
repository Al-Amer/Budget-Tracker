using BudgetLogger.Models;
using System.Globalization;

namespace BudgetLogger.Core
{
    public static class LogGenerator
    {
        // private const string LogsDirectory = "logs";
        // private const string LogFilePath = "Data/logs/info.log";
        private const string LogsDirectory = "Data/logs";
        private const string LogFilePath = "Data/logs/info.log";

        public static void WriteInfoLog(string userName, TransactionType type, decimal amount, string description)
        {
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTimeOffset.Now,
                Type = type,
                Description = description,
                Amount = amount
            };
            
            string logTimestamp = transaction.Timestamp.ToString("yyyy-MM-dd HH:mm:ss zzz"); 
            string transactionPart = transaction.GetTransactionLogPart();
            string logEntry = $"{userName} {logTimestamp} - LOGGED: {transactionPart}";

            try
            {
                // Ensure the logs directory exists (FR009 requirement adapted)
                Directory.CreateDirectory(LogsDirectory);
                
                // Append the log entry to the file
                File.AppendAllText(LogFilePath, logEntry + Environment.NewLine);
                Console.WriteLine("\n--- Log Entry Created ---");
                Console.WriteLine(logEntry);
                Console.WriteLine("Successfully logged entry to info.log.");
                Console.WriteLine($"Generated ID: {transaction.Id}");
            }
            catch (IOException ex)
            {
                // Simple error handling
                Console.WriteLine($"[ERROR] Failed to write to log file: {ex.Message}");
            }
        }
    }
}