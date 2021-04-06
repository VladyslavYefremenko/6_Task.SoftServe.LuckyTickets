using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class AppController
    {
        public static void Start(string algorithm)
        {
            int numOfTickets = 100;

            BusTicketCreator busTicketCreator = new BusTicketCreator();

            List<Ticket> tickets = busTicketCreator.Create(numOfTickets);

            LuckyTicketCounter luckyTicketCounter = new LuckyTicketCounter(algorithm, tickets);

            ResultPrinter.Print(luckyTicketCounter);
        }
    }
}
