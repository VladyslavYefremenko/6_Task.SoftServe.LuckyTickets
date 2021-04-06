using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {

            //ToDo: add instraction
            //ToDO: add XML

            string algorithmFilePath = string.Empty;
            string algorithm = string.Empty;

            if (ArgsValidation.isArgsValid(args, out algorithmFilePath) && ArgsValidation.isAlgorithmValid(algorithmFilePath, out algorithm))
            {
                AppController.Start(algorithm);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Instraction");
                Console.ReadKey();
            }
        }
    }
}
