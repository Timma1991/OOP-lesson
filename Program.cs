using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
