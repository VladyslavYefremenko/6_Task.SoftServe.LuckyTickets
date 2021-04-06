using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class BusTicketCreator : ITicketCreator
    {
        public List<Ticket> Create(int numOfTickets)
        {
            Random random = new Random();

            List<Ticket> tickets = new List<Ticket>();

            for (int i = 0; i < numOfTickets; i++)
            {
                tickets.Add(new BusTicket(random.Next(100000, 999999)));
            }

            return tickets; 
        }
    }
}
