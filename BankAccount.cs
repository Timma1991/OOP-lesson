namespace BankCell
{
    internal class BankAccount
    {
        private int balance = 0;
        private BalanceType accountType;
        private long accountNumber = 0;
        public static long AccountNumberGlobal = 207025200;

        public BankAccount()
        {
            this.accountNumber = GenerateAccountNumber();
        }

        public BankAccount(BalanceType accountType)
        {
            this.accountType = accountType;
            this.accountNumber = GenerateAccountNumber();
        }

        public BankAccount(int balance, BalanceType typescoretype)
        {
            this.balance = balance;
            this.accountType = typescoretype;
            this.accountNumber = GenerateAccountNumber();
        }

        public long GetAccountNumber()
        {
            return accountNumber;
        }

        public int GetBalance()
        {
            return balance;
        }

        public BalanceType GetAccountType()
        {
            return accountType;
        }

        public override string? ToString()
        {
            return 
                $"Balance: {GetBalance()}\n" +
                $"AccountType: {GetAccountType()}\n" +
                $"AccountNumber: {GetAccountNumber()}";
        }

        private long GenerateAccountNumber()
        {
            return AccountNumberGlobal++;
        }
    }
}
