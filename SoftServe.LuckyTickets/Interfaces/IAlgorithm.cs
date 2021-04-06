using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    interface IAlgorithm
    {
        bool isLucky(int[] number);
    }
}
