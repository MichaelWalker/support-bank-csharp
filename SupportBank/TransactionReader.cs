using System.IO;

namespace SupportBank
{
    public class TransactionReader
    {
        private const string FilePath = "Data/Transactions2014.csv";
        
        public string readTransactions()
        {
            return File.ReadAllText(FilePath);
        }
    }
}