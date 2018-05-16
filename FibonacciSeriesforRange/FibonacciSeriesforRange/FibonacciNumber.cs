//---------------------------------------------
// <copyright file="FibonacciNumber.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace FibonacciSeriesforRange
{
    using System.Collections.Generic;

    public class FibonacciNumber 
    {
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
