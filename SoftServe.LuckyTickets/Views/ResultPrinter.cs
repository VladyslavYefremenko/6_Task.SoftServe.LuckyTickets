using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class ResultPrinter
    {
        public static void Print(LuckyTicketCounter luckyTicketCounter)
        {
            Console.WriteLine($"Algorithm - {luckyTicketCounter.NameOfAlgorithm}");
            Console.WriteLine($"Number of lucky tickets - {luckyTicketCounter.NumLuckyTickets}");
            Console.WriteLine();
            Console.WriteLine("List of lucky tickets:");

            foreach (var ticket in luckyTicketCounter.LuckyTickets)
            {
                Console.WriteLine($"{ticket.Number}");
            }
        }
    }
}
