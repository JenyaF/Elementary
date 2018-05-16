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
    using static System.Math;
    public class FibonacciSeries
    {
        private readonly int lowerBound;
        private readonly int upperBound;

        public FibonacciSeries(int lowerBound, int upperBound)
        {
            this.lowerBound = Min(Abs(lowerBound), Abs(upperBound));
            this.upperBound = Max(Abs(lowerBound), Abs(upperBound));        
        }

        public string GetStringSeries()
        {
            var fibonacciNumber = new FibonacciNumber(0, 1);
            fibonacciNumber.SkipFibonacciNumbers(this.lowerBound);
            List<int> list = fibonacciNumber.GetFibonacciNumbers(this.upperBound);

            /*string result = string.Empty;
            foreach (var number in list)
            {
                result += number + ", ";
            }

            if (result != string.Empty)
            {
                return result.Remove(result.Length - 2);
            }*/

            return string.Join(",", list);
        }
    }
}
