using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts
{
    class SavingAccount : Account, ITransaction
    {
        public static double COST_PER_TRANSACTION = 0.05;
        public static double INTEREST_RATE = 0.015;

        public SavingAccount(double balance = 0)
            : base("SV-", balance)
        {
        }

        public new void Deposit(double amount, Person person)
        {
            base.OnTransactionOccur(person, new TransactionEventArgs(person.Name, amount, true));
            base.Deposit(amount, person);
        }

        public void Withdraw(double amount, Person person)
        {
            if (!this.users.Contains(person))
            {
                base.OnTransactionOccur(person, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionEnum.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            
            else if (!person.IsAuthenticated)
            {
                base.OnTransactionOccur(person, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionEnum.USER_NOT_LOGGED_IN);
            }
            else if (amount > this.Balance)
            {
                base.OnTransactionOccur(person, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionEnum.NO_OVERDRAFT);
            }
            else
            {
                base.OnTransactionOccur(person, new TransactionEventArgs(person.Name, amount, true));
                base.Deposit(-amount, person);
            }
        }

        public override void PrepareMonthlyReport()
        {
            double service_charge = transactions.Count * COST_PER_TRANSACTION;
            double intrest = (this.LowestBalance * INTEREST_RATE) / 12;
            this.Balance = (this.Balance + intrest) - service_charge;
            this.transactions.Clear();
        }
    }
}
