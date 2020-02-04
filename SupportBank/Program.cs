using System;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new TransactionReader();

            foreach (var transaction in reader.ReadTransactions())
            {
                Console.WriteLine(transaction);
            }
        }
    }
}