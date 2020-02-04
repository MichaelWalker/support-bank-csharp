using System.Collections.Generic;
using System.Linq;
using SupportBank.Data;

namespace SupportBank
{
    public class Bank
    {
        public IEnumerable<Account> ProcessTransactions(IEnumerable<Transaction> transactions)
        {
            var transactionList = transactions.ToList();
            var accounts = CreateAccounts(transactionList);
            
            foreach (var transaction in transactionList)
            {
                var fromAccount = FindAccount(accounts, transaction.From);
                var toAccount = FindAccount(accounts, transaction.To);
                
                fromAccount.OutgoingTransactions.Add(transaction);
                toAccount.IncommingTransactions.Add(transaction);
            }

            return accounts;
        }

        private static Account FindAccount(List<Account> accounts, string name)
        {
            return accounts.Find(account => account.Name == name);
        }

        private static List<Account> CreateAccounts(IEnumerable<Transaction> transactions)
        {
            return FindUniqueNames(transactions)
                .Select(name => new Account(name))
                .ToList();
        }

        private static IEnumerable<string> FindUniqueNames(IEnumerable<Transaction> transactions)
        {
            var uniqueNames = new HashSet<string>();

            foreach (var transaction in transactions)
            {
                uniqueNames.Add(transaction.To);
                uniqueNames.Add(transaction.From);
            }
            
            return uniqueNames;
        }
    }
}