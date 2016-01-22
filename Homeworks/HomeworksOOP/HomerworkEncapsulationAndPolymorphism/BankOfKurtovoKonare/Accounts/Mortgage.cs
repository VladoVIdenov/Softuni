namespace BankOfKurtovoKonare.Accounts
{
    class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months >= 6)
                {
                    return base.CalculateInterest(months - 6);
                }
                else
                {
                    return 0;
                }
            }
            else if (this.Customer == Customer.Company)
            {
                if (months <= 12)
                {
                    return base.CalculateInterest(months) / 2;
                }
                else
                {
                    return (base.CalculateInterest((12) / 2) + base.CalculateInterest(months - 12));
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
