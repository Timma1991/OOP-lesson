using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCell
{
    internal class Reverse
    {
        public  string reverse(String stringa)
        {
            char[] reverse = stringa.ToCharArray();

            Array.Reverse(reverse);

            return new string(reverse);

        }

    }
}
