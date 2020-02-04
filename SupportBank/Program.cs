using System;

namespace SupportBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new TransactionReader();
            Console.WriteLine(reader.readTransactions());
        }
    }
}