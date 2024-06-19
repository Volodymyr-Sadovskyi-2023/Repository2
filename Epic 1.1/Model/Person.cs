using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_task.Model
{
    public class Person : Client
    {
        public string PersonId { get; set; }
        public string Address { get; set; }

        public Person(string clientId, string name, string accountNumber, decimal initialBalance, string personId, string address)
            : base(clientId, name, accountNumber, initialBalance)
        {
            PersonId = personId;
            Address = address;
        }
    }
}
