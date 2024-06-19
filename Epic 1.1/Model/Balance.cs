using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_task.Model
{
    public class Balance
    {
        public string BalanceId { get; set; }
        public string ClientId { get; set; }
        public decimal BalanceAmount { get; set; }

        public Balance(string balanceId, string clientId, decimal initialAmount)
        {
            BalanceId = balanceId;
            ClientId = clientId;
            BalanceAmount = initialAmount;
        }

        public decimal GetBalance()
        {
            return BalanceAmount;
        }

        public void UpdateBalance(decimal amount)
        {
            BalanceAmount += amount;
        }
    }
}
