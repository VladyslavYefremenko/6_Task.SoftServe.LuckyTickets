﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftServe.LuckyTickets
{
    public class ArgsValidation
    {
        public static bool isArgsValid(string[] args, out string algorithmFilePath)
        {
            bool isValid = false;
            algorithmFilePath = string.Empty;

            if (!string.IsNullOrEmpty(args[0]))
            {
                isValid = true;
                algorithmFilePath = args[0];
            }

            return isValid;
        }

        public static bool isAlgorithmValid(string filePath, out string algorithm)
        {
            bool isValid = false;
            algorithm = AlgorithmReader.Read(filePath);

            if (algorithm == DefaultSettings.MOSCOW_ALGORITHM || algorithm == DefaultSettings.PITER_ALGORITHM)
            {
                isValid = true;
            }

            return isValid;
        }
    }
}
