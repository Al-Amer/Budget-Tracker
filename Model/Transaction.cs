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
        
        public DateTime Date => Timestamp.Date;

        public string GetTransactionLogPart()
        {
            string sign = Type == TransactionType.Income ? "+" : "-";
            return $"[{Date:yyyy-MM-dd}] {Type}: {Description} (id): {sign}{Amount:C}";
        }
    }
}