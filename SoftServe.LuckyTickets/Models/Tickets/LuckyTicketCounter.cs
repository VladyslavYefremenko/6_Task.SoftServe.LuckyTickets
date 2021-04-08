using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    public class LuckyTicketCounter
    {
        private int numLuckyTickets = 0;
        private List<Ticket> luckyTickets = new List<Ticket>();
        private string nameOfAlgorithm;

        public int NumLuckyTickets { get => numLuckyTickets; }

        public List<Ticket> LuckyTickets { get => luckyTickets; }

        public string NameOfAlgorithm { get => nameOfAlgorithm; }

        public LuckyTicketCounter(string algorithm, List<Ticket> tickets)
        {
            Cout(algorithm, tickets);
        }

        private void Cout(string algorithm, List<Ticket> tickets)
        {
            foreach (var ticket in tickets)
            {
                if (algorithm == DefaultSettings.MOSCOW_ALGORITHM)
                {
                    if (ticket.IsLuckyMoscow)
                    {
                        numLuckyTickets++;
                        luckyTickets.Add(ticket);
                        nameOfAlgorithm = DefaultSettings.MOSCOW_ALGORITHM;
                    }
                }
                else
                {
                    if (ticket.IsLuckyPiter)
                    {
                        numLuckyTickets++;
                        luckyTickets.Add(ticket);
                        nameOfAlgorithm = DefaultSettings.PITER_ALGORITHM;
                    }
                }
            }
        }
    }
}
