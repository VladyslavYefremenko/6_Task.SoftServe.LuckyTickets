using System;

using SoftServe.LuckyTickets;

namespace SoftServe.LuckyTicketsView
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
                Startup.Start(algorithm);
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
