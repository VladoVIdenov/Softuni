using BankOfKurtovoKonare.Accounts;

namespace BankOfKurtovoKonare.Interfaces
{
    interface IAccount
    {
        Customer Customer { get; set; }
        decimal Balance { get; set; }
        decimal InterestRate { get; set; }

        decimal CalculateInterest(int months);
        void DepositMoney(decimal money);
    }
}
