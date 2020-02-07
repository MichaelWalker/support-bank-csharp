using System;
using System.Collections.Generic;
using System.Linq;
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

        public double TotalOwedToOthers()
        {
            return Math.Round(IncommingTransactions.Sum(transaction => transaction.Amount), 2);
        }

        public double TotalOwedToThem()
        {
            return Math.Round(OutgoingTransactions.Sum(transaction => transaction.Amount), 2);
        }
    }
}