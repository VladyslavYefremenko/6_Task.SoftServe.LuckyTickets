using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class AlgorithmReader
    {
        public static string Read(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}
