using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    static class Logger
    {
        private static List<string> loginEvents = new List<string>();
        private static List<string> transactionEvents = new List<string>();
        public static void LoginHandler(object sender, EventArgs  args )
        {
            var obj = args as LoginEventArgs;
            string data = $"{obj.PersonName} logged in {obj.Success} on {DateTime.Now}";
            loginEvents.Add(data);
        }
        public static void TransactionHandler(object sender, EventArgs args)
        {
            var obj = args as TransactionEventArgs;
            string data = $"{obj.PersonName} deposit ${obj.Amount}  {obj.Success} on {DateTime.Now}";
            transactionEvents.Add(data);
        }
        public static void ShowLoginEvents()
        {
            Console.WriteLine(DateTime.Now);
            foreach(var i in loginEvents)
            {
                Console.WriteLine(i);
            }
        }
        public static void ShowTransactionEvents()
        {
            Console.WriteLine(DateTime.Now);
            foreach (var i in transactionEvents)
            {
                Console.WriteLine(i);
            }
        }
    }
}
