using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class PiterAlgorithm : IAlgorithm
    {
        public bool isLucky(int[] numbers)
        {
            int ticketLeft = 0;
            int ticketRight = 0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    ticketLeft += num;
                }
                else
                {
                    ticketRight += num;
                }
            }

            return ticketLeft == ticketRight;
        }
    }
}
