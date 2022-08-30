namespace BankCell
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1,BalanceType.Credit);
            Console.WriteLine(account);
            BankAccount.AccountNumberGlobal = 5;
        }
    }
}
