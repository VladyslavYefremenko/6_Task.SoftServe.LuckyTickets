using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class BusTicket : Ticket
    {
        public BusTicket(int number)
        {
            this.number = number;

            MoscowAlgorithm moscowAlgorithm = new MoscowAlgorithm();
            isLuckyMoscow = moscowAlgorithm.isLucky(NumberSeparator.Separate(number));

            PiterAlgorithm peterAlgorithm = new PiterAlgorithm();
            isLuckyPiter = peterAlgorithm.isLucky(NumberSeparator.Separate(number));
        }
    }
}
