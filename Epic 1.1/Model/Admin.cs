using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_task.Model
{
    public class Admin : Person
    {
        public string AdminId { get; set; }
        public string Role { get; set; }

        private List<Client> clients = new List<Client>();
        private List<Transaction> transactions = new List<Transaction>();

        public Admin(string clientId, string name, string accountNumber, decimal initialBalance, string personId, string address, string adminId, string role)
            : base(clientId, name, accountNumber, initialBalance, personId, address)
        {
            AdminId = adminId;
            Role = role;
        }

        public void AddClient(Client client)
        {
            clients.Add(client);
            Console.WriteLine($"Client {client.Name} added.");
        }

        public void RemoveClient(Client client)
        {
            clients.Remove(client);
            Console.WriteLine($"Client {client.Name} removed.");
        }

        public void ViewTransactions()
        {
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction.GetTransactionDetails());
            }
        }

        public void GenerateReport()
        {
            Console.WriteLine("Transaction Report:");
            ViewTransactions();
        }

        public new void Deposit(decimal amount)
        {
            base.Deposit(amount);
            transactions.Add(new Transaction(Guid.NewGuid().ToString(), amount));
        }

        public new void Withdraw(decimal amount)
        {
            base.Withdraw(amount);
            transactions.Add(new Transaction(Guid.NewGuid().ToString(), -amount));
        }
    }
}
