namespace BankCell
{
    internal class BankAccount
    {
        public long Balance { get; set; }
        public BalanceType AccountType { get; set; }
        public long AccountNumber { get; set; }
        public static long AccountNumberGlobal = 207025200;

        public BankAccount()
        {
            this.AccountNumber = GenerateAccountNumber();
        }
        public BankAccount(BalanceType accountType)
        {
            this.AccountType = accountType;
            this.AccountNumber = GenerateAccountNumber();
        }
        public BankAccount(int balance, BalanceType typescoretype)
        {
            this.Balance = balance;
            this.AccountType = typescoretype;
            this.AccountNumber = GenerateAccountNumber();
        }           
        public bool Credit(long amount)
        {
            if(Balance>=amount)
            {
                Balance -= amount;
                return true;
            }   
            return false;
        }        
        public void Debit(long amount)
        {
            Balance+=amount;
        }

        public override string? ToString()
        {
            return 
                $"Balance: {Balance}\n" +
                $"AccountType: {AccountType}\n" +
                $"AccountNumber: {AccountNumber}";
        }
        private long GenerateAccountNumber()
        {
            return AccountNumberGlobal++;
        }
    }
}
