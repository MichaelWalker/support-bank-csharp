using System;
using System.Collections.Generic;
using System.Linq;

namespace SupportBank
{
    public class AccountPrinter
    {
        private static int COLUMN_WIDTH = 20;
        
        public static void PrintAllAccounts(IEnumerable<Account> accounts)
        {
            Console.WriteLine("SUMMARY OF ALL ACCOUNTS");
            Console.WriteLine("==========================================================");
            WriteTableRow("Name", "Owed To Others", "Owed To Them");
            Console.WriteLine("----------------------------------------------------------");

            foreach (var account in accounts)
            {
                WriteTableRow(account.Name, account.TotalOwedToOthers(), account.TotalOwedToThem());
            }
        }

        private static void WriteTableRow(params object[] rowContents)
        {
            Console.WriteLine(TableRow(rowContents));
        }

        private static string TableRow(IEnumerable<object> rowContents)
        {
            var cells = rowContents.Select(cellContents => TableCell(cellContents));
            return string.Join(" | ", cells);
        }

        private static string TableCell(object contents)
        {
            return contents.ToString().PadRight(COLUMN_WIDTH);
        }
    }
}