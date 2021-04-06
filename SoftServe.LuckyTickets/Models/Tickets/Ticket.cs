using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    abstract class Ticket
    {
        protected int number;

        protected bool isLuckyMoscow = false;

        protected bool isLuckyPiter = false;

        public int Number { get => number; }

        public bool IsLuckyMoscow { get => isLuckyMoscow; }

        public bool IsLuckyPiter { get => isLuckyPiter; }
    }
}
