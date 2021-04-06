using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class MoscowAlgorithm : IAlgorithm
    {
        public bool isLucky(int[] number)
        {
            int ticketLeft = number[0] + number[1] + number[2];
            int ticketRight = number[3] + number[4] + number[5];

            return ticketLeft == ticketRight;
        }
    }
}
