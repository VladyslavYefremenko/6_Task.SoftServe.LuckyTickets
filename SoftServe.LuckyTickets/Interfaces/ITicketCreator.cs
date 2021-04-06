using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    interface ITicketCreator
    {
        List<Ticket> Create(int numOfTickets);
    }
}
