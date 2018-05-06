//---------------------------------------------
// <copyright file="FibonacciNumber.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FibonacciSeriesforRange
{
    using System.Collections.Generic;

    /// <summary>
    /// Contains basic logic of Fibonacci number.
    /// </summary>
    public class FibonacciNumber 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FibonacciNumber"/> class.
        /// </summary>
        /// <param name="firstNumber">Number Fibonacci isn't greater then lower bound.</param>
        /// <param name="secondNumber">Number Fibonacci isn't less then lower bound.</param>
        public FibonacciNumber(int firstNumber, int secondNumber)
        {
            this.FirstNumber = firstNumber;
            this.SecondNumber = secondNumber;
        }

        /// <summary>
        /// Gets or sets number Fibonacci for processing
        /// </summary>
        public int FirstNumber { get; set; }

        /// <summary>
        /// Gets or sets number Fibonacci for processing
        /// </summary>
        public int SecondNumber { get; set; }

       /// <summary>
       /// Skip Fibonacci number that less then lower bound.
       /// </summary>
       /// <param name="border">Lower bound.</param>
        public void SkipFibonacciNumbers(int border)
        {
            int sum = this.FirstNumber;
            while (sum < border)
            {
                sum = this.FirstNumber + this.SecondNumber;
                this.FirstNumber = this.SecondNumber;
                this.SecondNumber = sum;
            }
        }

        /// <summary>
        /// Gets Fibonacci number that not greater upper bound.
        /// </summary>
        /// <param name="border">Upper bound.</param>
        /// <returns>Gets list of Fibonacci number.</returns>
        public List<int> GetFibonacciNumbers(int border)
        {
            List<int> list = new List<int>();
            int sum = this.FirstNumber;
            if (this.FirstNumber == 0)
            {
                list.Add(sum);
            }

            if (border >= this.SecondNumber)
            {
                while (sum <= border)
                {
                    list.Add(this.SecondNumber);
                    sum = this.FirstNumber + this.SecondNumber;
                    this.FirstNumber = this.SecondNumber;
                    this.SecondNumber = sum;               
                }
            }
            
            return list;
        }       
    }
}
