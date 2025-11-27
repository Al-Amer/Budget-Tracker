using BudgetLogger.Models;
using System.Globalization;

namespace BudgetLogger.Core
{
    // This class handles the creation, formatting, and writing of the log file.
    public static class LogGenerator
    {
        // private const string LogsDirectory = "logs";
        // private const string LogFilePath = "Data/logs/info.log";
        private const string LogsDirectory = "Data/logs";
        private const string LogFilePath = "Data/logs/info.log";

        public static void WriteInfoLog(string userName, TransactionType type, decimal amount, string description)
        {
            // 1. Create Transaction Object with GUID and Time (as required)
            var transaction = new Transaction
            {
                Id = Guid.NewGuid(),
                Timestamp = DateTimeOffset.Now, // Automatically captures current time and system offset
                Type = type,
                Description = description,
                Amount = amount
            };
            
            // 2. Format Components
            
            // Format: user.name 2025-11-26 22:24:21 +01:00
            // We use 'yyyy-MM-dd HH:mm:ss zzz' to get the full timestamp with offset
            string logTimestamp = transaction.Timestamp.ToString("yyyy-MM-dd HH:mm:ss zzz"); 
            
            // Format: - LOGGED: [2025-11-26] Expense: out (id ): -$10.00
            string transactionPart = transaction.GetTransactionLogPart();

            // 3. Assemble the complete log entry
            string logEntry = $"{userName} {logTimestamp} - LOGGED: {transactionPart}";

            // 4. File I/O
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