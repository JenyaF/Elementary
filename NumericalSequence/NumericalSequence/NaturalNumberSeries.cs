//---------------------------------------------
// <copyright file="NaturalNumberSeries.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumericalSequence
{
    using System;
    using System.Text;

    public class NaturalNumberSeries
    {
        private const int allowableLengthOfOutput = 1000;
        /// <summary>
        /// Given upper bounder.
        /// </summary>
        private readonly int n;
       
        /// <param name="n">Upper bounder.</param>
        public NaturalNumberSeries(int n)
        {
            this.n = Math.Abs(n);
        }

        public int Number { get; set; } = 1;

        /// <summary>
        /// Founds all  natural numbers,
        /// the square of which is less than the given number n.
        /// </summary>
        /// <param name="isFinish">if it outputs all numbers.</param>
        /// <returns>Numbers separated by a comma.</returns>
        public StringBuilder FoundSquaresNumberLessThenN(out bool isFinish)
        {
            var builder = new StringBuilder();
            
            for (; Number * Number < this.n; Number++)
            {
                if (builder.Length < allowableLengthOfOutput)
                {
                    builder.Append($"{Number}, ");
                }
                else
                {
                    isFinish = false;
                    return builder;
                }            
            }

            if (builder.Length != 0)
            {
                builder.Remove(builder.Length - 2, 1);
            }

            isFinish = true;
            return builder;
        }
    }
}
