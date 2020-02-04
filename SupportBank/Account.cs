using System.Collections.Generic;
using SupportBank.Data;

namespace SupportBank
{
    public class Account
    {
        public string Name { get; }
        public List<Transaction> IncommingTransactions { get; }
        public List<Transaction> OutgoingTransactions { get; }

        public Account(string name)
        {
            Name = name;
            IncommingTransactions = new List<Transaction>();
            OutgoingTransactions = new List<Transaction>();
        }
    }
}