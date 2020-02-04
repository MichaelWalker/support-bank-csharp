using System;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new TransactionReader();
            var bank = new Bank();

            var transactions = reader.ReadTransactions();
            var accounts = bank.ProcessTransactions(transactions);

            Console.WriteLine(accounts);
        }
    }
}