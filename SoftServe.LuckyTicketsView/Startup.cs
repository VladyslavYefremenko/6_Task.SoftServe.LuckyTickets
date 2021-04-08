using System.Collections.Generic;

using SoftServe.LuckyTickets;

namespace SoftServe.LuckyTicketsView
{
    class Startup
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
