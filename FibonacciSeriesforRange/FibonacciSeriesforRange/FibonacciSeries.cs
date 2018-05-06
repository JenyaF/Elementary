//---------------------------------------------
// <copyright file="FibonacciSeries.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FibonacciSeriesforRange
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains basic logic for Fibonacci series.
    /// </summary>
    public class FibonacciSeries
    {
        /// <summary>
        /// Lower bound.
        /// </summary>
        private int lowerBound;

        /// <summary>
        /// Upper bound.
        /// </summary>
        private int upperBound;

        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciSeries"/> class.
        /// </summary>
        /// <param name="lowerBound">Lower bound.</param>
        /// <param name="upperBound">Upper bound.</param>
        public FibonacciSeries(int lowerBound, int upperBound)
        {
            lowerBound = Math.Abs(lowerBound);
            upperBound = Math.Abs(upperBound);
            if (lowerBound < upperBound)
            {
                this.lowerBound = lowerBound;
                this.upperBound = upperBound;
            }
            else
            {
                this.lowerBound = upperBound;
                this.upperBound = lowerBound;
            }          
        }

        /// <summary>
        /// Converts series of Fibonacci numbers in string representation.
        /// </summary>
        /// <returns>Series of Fibonacci numbers in string representation</returns>
        public string GetStringSeries()
        {
            FibonacciNumber fibonacciNumber = new FibonacciNumber(0, 1);
            fibonacciNumber.SkipFibonacciNumbers(this.lowerBound);
            List<int> list = fibonacciNumber.GetFibonacciNumbers(this.upperBound);
            string result = string.Empty;
            foreach (var number in list)
            {
                result += number + ", ";
            }

            if (result != string.Empty)
            {
                return result.Remove(result.Length - 2);
            }

            return result;
        }
    }
}
