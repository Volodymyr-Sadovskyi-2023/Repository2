using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_task.Model
{
    public class Client
    {
        public string ClientId { get; set; }
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public Balance ClientBalance { get; set; }

        public Client(string clientId, string name, string accountNumber, decimal initialBalance)
        {
            ClientId = clientId;
            Name = name;
            AccountNumber = accountNumber;
            ClientBalance = new Balance(clientId, clientId, initialBalance);
        }

        public void Deposit(decimal amount)
        {
            ClientBalance.UpdateBalance(amount);
            var transaction = new Transaction(Guid.NewGuid().ToString(), amount);
            transaction.RecordTransaction();
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= ClientBalance.GetBalance())
            {
                ClientBalance.UpdateBalance(-amount);
                var transaction = new Transaction(Guid.NewGuid().ToString(), -amount);
                transaction.RecordTransaction();
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public decimal GetBalance()
        {
            return ClientBalance.GetBalance();
        }
    }
}
