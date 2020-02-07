using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SupportBank.Data;

namespace SupportBank
{
    public class TransactionReader
    {
        private const string FilePath = "Data/Transactions2014.csv";
        
        public static List<Transaction> ReadTransactions()
        {
            var transactions = new List<Transaction>();
            foreach (var line in ReadAllLinesFromFile())
            {
                var parts = line.Split(",");
                
                var date = TryParseDate(parts[0]);
                var from = parts[1];
                var to = parts[2];
                var narrative = parts[3];
                var amount = TryParseNumber(parts[4]);
                
                transactions.Add(new Transaction(date, from, to, narrative, amount));
            }

            return transactions;
        }

        private static DateTime TryParseDate(string input)
        {
            try
            {
                return DateTime.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to convert the string {input} to a date");
                throw;
            }
        }

        private static double TryParseNumber(string input)
        {
            try
            {
                return double.Parse(input);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed to convert the string {input} to a double");
                throw;
            }
        } 

        private static IEnumerable<string> ReadAllLinesFromFile()
        {
            var allLines = File.ReadAllLines(FilePath).ToList();
            allLines.RemoveAt(0);
            return allLines;
        }
    }
}