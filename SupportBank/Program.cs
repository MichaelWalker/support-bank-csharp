using System;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var transactions = TransactionReader.ReadTransactions();
            var accounts = Bank.ProcessTransactions(transactions);

            AccountPrinter.PrintAllAccounts(accounts);
        }
    }
}