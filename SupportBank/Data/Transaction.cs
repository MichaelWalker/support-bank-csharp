using System;

namespace SupportBank.Data
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public double Amount { get; set; }
    }
}