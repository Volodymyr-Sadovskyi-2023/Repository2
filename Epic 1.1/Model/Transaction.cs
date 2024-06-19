using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_task.Model
{
    public class Transaction
    {
        public string TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Timestamp { get; set; }

        public Transaction(string transactionId, decimal amount)
        {
            TransactionId = transactionId;
            Amount = amount;
            Timestamp = DateTime.Now;
        }

        public void RecordTransaction()
        {
            Console.WriteLine($"Transaction {TransactionId} recorded at {Timestamp}");
        }

        public string GetTransactionDetails()
        {
            return $"Transaction ID: {TransactionId}, Amount: {Amount}, Timestamp: {Timestamp}";
        }
    }
}
