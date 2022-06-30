using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    abstract class Account
    {
        public readonly List<Person> users;

        public readonly List<Transaction> transactions;

        private static int LAST_NUMBER = 100000;
        
        public virtual event EventHandler OnTransaction;

        public string Number { get; protected set; }
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            Number = type + LAST_NUMBER.ToString();
            LAST_NUMBER++;
            Balance = balance;
            LowestBalance = balance;
            this.transactions = new List<Transaction>();
            this.users = new List<Person>();
        }

        public void Deposit(double amount, Person person)
        {
            if (Balance > (Balance + amount))
            {
                LowestBalance = Balance + amount;
            }
            else
            {
                LowestBalance = Balance;
            }
            Balance = Balance + amount;
            transactions.Add(new Transaction(Number, amount, person, DateTime.Now));
            Logger.TransactionHandler(this, new TransactionEventArgs(person.Name, amount, true));
        }

        public void AddUser(Person person)
        {
            users.Add(person);
        }

        public bool IsUser(string name)
        {
            foreach (Person p in users)
            {
                if (p.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public abstract void PrepareMonthlyReport();
        public virtual void OnTransactionOccur(object sender, EventArgs args)
        {
            this.OnTransaction?.Invoke(sender, args);
        }

        public override string ToString()
        {
            return $"[{Number}, {Number} {string.Join(", ", users)}, ${Balance:F2}] \nTransactions:\n\t{string.Join("\n\n\t", transactions)}\n\n";
        }
    }
}
