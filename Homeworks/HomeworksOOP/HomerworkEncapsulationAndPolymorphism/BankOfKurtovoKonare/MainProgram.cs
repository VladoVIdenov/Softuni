using BankOfKurtovoKonare.Accounts;
using System;
using System.Collections.Generic;

namespace BankOfKurtovoKonare
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Mortgage firstMortgage = new Mortgage(Customer.Company, 100, 0.06m);
            Deposit firstDeposit = new Deposit(Customer.Company, 2000, 0.7m);
            Loan firstLoan = new Loan(Customer.Company, 30000, 1m);

            Mortgage secondMortgage = new Mortgage(Customer.Individual, 500, 4m);
            Deposit secondDeposit = new Deposit(Customer.Individual, 2000, 0.05m);
            secondDeposit.DepositMoney(205);
            //Console.WriteLine(secondDeposit.CalculateInterest(10));
            secondDeposit.WithdrawMoney(403);
            //Console.WriteLine(secondDeposit.CalculateInterest(10));
            //Console.WriteLine(secondMortgage.CalculateInterest(4)); 
            Loan secondLoan = new Loan(Customer.Individual, 999, 4000m);
            IEnumerable<Account> accounts = new List<Account>()
            {
               firstMortgage,firstDeposit, firstLoan, secondMortgage, secondDeposit, secondLoan
            };
            foreach (var acc in accounts)
            {
                Console.WriteLine("{0} - Balance: {1} -   interest rate: {2}" , acc.GetType().Name , acc.Balance, acc.CalculateInterest(1));
            }
        }
    }
}
