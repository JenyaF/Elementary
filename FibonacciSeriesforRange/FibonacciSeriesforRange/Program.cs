//---------------------------------------------
// <copyright file="Program.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FibonacciSeriesforRange
{
    using System;

    /// <summary>
    /// Class for starting program
    /// </summary>
    public class Program
    {       
        /// <summary>
        /// Starts program.
        /// </summary>
        /// <param name="args">Arguments that are passed at startup.</param>
        public static void Main(string[] args)
        {
            int lowerBound, upperBound;
            if (int.TryParse(args[0], out lowerBound) && (int.TryParse(args[1], out upperBound)))
            {
                var fibonacciSeries = new FibonacciSeries(lowerBound, upperBound);
                Console.WriteLine(fibonacciSeries.GetStringSeries());
            }
            else
            {
                Console.WriteLine("Incorrect data!");
            }

        }
    }
}
