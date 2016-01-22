namespace BankOfKurtovoKonare.Accounts
{
    class Deposit : Account
    {
        private const decimal MinValueForInterest = 1000;

        public Deposit(Customer customer, decimal balance, decimal interestRate)
            :base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Balance < MinValueForInterest && this.Balance >= 0)
            {
                return base.InterestRate; ;
            }
            else
            {
                return base.CalculateInterest(months);
            }
           
        }

        public void WithdrawMoney(decimal money)
        {
            this.Balance -= money;
        }
        public override void DepositMoney(decimal money)
        {
            this.Balance += money;
        }

    }
}
