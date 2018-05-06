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
            int lowerBound = Convert.ToInt32(args[0]);
            int upperBound = Convert.ToInt32(args[1]);
            FibonacciSeries fibonacciSeries = new FibonacciSeries(lowerBound, upperBound);
            Console.WriteLine(fibonacciSeries.GetStringSeries());
        }
    }
}
