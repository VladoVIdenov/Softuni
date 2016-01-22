using BankOfKurtovoKonare.Interfaces;
using System;

namespace BankOfKurtovoKonare.Accounts
{
    abstract class Account : IAccount
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.InterestRate = interestRate;
            this.Balance = balance;
        }

        public Customer Customer { get; set; }

        public decimal Balance
        {
            get { return this.balance; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Balance cannot be negative");
                }
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Bank interest rate cannot be negative");
                }
                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int months)
        {
            return (this.Balance * (1 + this.InterestRate * months) / 100) ;
        }

        public abstract void DepositMoney(decimal money);

    }
}
