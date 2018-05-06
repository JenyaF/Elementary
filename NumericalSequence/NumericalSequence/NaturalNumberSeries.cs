//---------------------------------------------
// <copyright file="NaturalNumberSeries.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumericalSequence
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Contains the basic logic for the representation of series of natural numbers,
    /// the square of which is less than the given number n.
    /// </summary>
    public class NaturalNumberSeries
    {
        /// <summary>
        /// Given upper bounder.
        /// </summary>
        private int n;

        /// <summary>
        /// Initializes a new instance of the <see cref="NaturalNumberSeries"/> class.
        /// </summary>
        /// <param name="n">Upper bounder.</param>
        public NaturalNumberSeries(int n)
        {
            this.n = Math.Abs(n);
        }    

        /// <summary>
        /// Get list of of natural numbers separated by a comma,
        /// the square of which is less than the given number n.
        /// </summary>
        /// <returns>Series of natural number.</returns>
        public string StringSquaresNumberLessThenN()
        {
            string result = string.Empty;
            List<int> list = this.SquaresNumberLessThenN();
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

        /// <summary>
        /// Found all  natural numbers,
        /// the square of which is less than the given number n.
        /// </summary>
        /// <returns>List of natural numbers, the square of which is less than the given number n.</returns>
        private List<int> SquaresNumberLessThenN()
        {
            List<int> list = new List<int>();
            int number = 1;
            for (var i = 1; number < this.n; i++, number = i * i)
            {
                list.Add(number);
            }

            return list;
        }
    }
}
