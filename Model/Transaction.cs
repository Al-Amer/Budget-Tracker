namespace BudgetLogger.Models
{
    public enum TransactionType { Income, Expense }

    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTimeOffset Timestamp { get; set; }
        public TransactionType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        
        // Helper property for date formatting
        public DateTime Date => Timestamp.Date;

        // Custom formatting logic for the transaction part of the log
        public string GetTransactionLogPart()
        {
            // Determine sign and use currency formatting
            string sign = Type == TransactionType.Income ? "+" : "-";
            
            // Format: [2025-11-26] Expense: out (id ): -$10.00
            // Note: The 'id' placeholder is kept simple as per your request format.
            return $"[{Date:yyyy-MM-dd}] {Type}: {Description} (id): {sign}{Amount:C}";
        }
    }
}