namespace BankCell
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            
            BankAccount account = new BankAccount(1,BalanceType.Credit);
            Console.WriteLine(account);
            BankAccount.AccountNumberGlobal = 5;
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Reverse rev= new Reverse();
            str = rev.reverse(str);
            Console.WriteLine(str);
        }
    }
}
