namespace BankOfKurtovoKonare.Accounts
{
    class Loan : Account
    {
        public Loan(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (Customer == Customer.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterest(months - 3);
                }
            }
            else if (Customer == Customer.Company)
            {
                if (months <= 2)
                {
                    return 0;
                }
                else
                {
                    return base.CalculateInterest(months - 2);
                }
            }
            return base.CalculateInterest(months);
        }

        public override void DepositMoney(decimal money)
        {
            this.Balance += money;
        }
    }
}
