//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumericalSequence
{
    using System;

    public class SeriesOutput
    {
        private NaturalNumberSeries naturalNumberSeries;

        public SeriesOutput(int n)
        {
            naturalNumberSeries = new NaturalNumberSeries(n);
        }

        public void Print()
        {
            bool isFinish;
            Console.WriteLine(naturalNumberSeries.FoundSquaresNumberLessThenN(out isFinish));
            if (!isFinish)
            {
                Console.WriteLine("Too large number!");
                Console.WriteLine("Enter \"y\" or \"yes\" if you want to continue the output.");
                var unswer = Console.ReadLine().ToLower();
                if (unswer == "yes" || unswer == "y")
                {
                    Print();
                }
            }
        }
    }
}
