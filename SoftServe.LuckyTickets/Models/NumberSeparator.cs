using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class NumberSeparator
    {
        public static int[] Separate(int number)
        {
            int[] digits = new int[6];

            digits[0] = number / 100000;
            digits[1] = (number % 100000) / 10000;
            digits[2] = (number % 10000) / 1000;
            digits[3] = (number % 1000) / 100;
            digits[4] = (number % 100) / 10;
            digits[5] = number % 10;

            return digits;
        }
    }
}
