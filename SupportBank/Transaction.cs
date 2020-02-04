using System;

namespace SupportBank.Data
{
    public class Transaction
    {
        public DateTime Date { get; }
        public string From { get; }
        public string To { get; }
        public string Narrative { get; }
        public double Amount { get; }

        public Transaction(DateTime date, string from, string to, string narrative, double amount)
        {
            Date = date;
            From = from;
            To = to;
            Narrative = narrative;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Date: {Date}, From: {From}, To: {To}, Narrative: {Narrative} Amount: {Amount}";
        } 
    }
}