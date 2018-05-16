//---------------------------------------------
// <copyright file="HappyTickets.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
    using System;
    using System.Linq;

    public class HappyTickets
    {
        private const int MaxNumber = 999999;
        private const int CountOfDigits = 6;

        private Func<int[], bool> isHappyTicket;

        public HappyTickets(Algorithm algorithm)
        {
            if (algorithm == Algorithm.Moskow)
            {
                 this.isHappyTicket = this.IsHappyMoskow;
            }
            else
            {
                this.isHappyTicket = this.IsHappyPiter;
            }          
        }

        public bool IsHappyMoskow(int[] digits)
        {
            int sumOfFirstDigits = digits.Take(digits.Length / 2).Sum();
            int sumOfLastDigits = digits.Skip(digits.Length / 2).Sum();
            return sumOfFirstDigits == sumOfLastDigits;
        }


        public bool IsHappyPiter(int[] digits)
        {
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;
            for (var i = 0; i < digits.Length; i += 2)
            {
                sumOfOddDigits += digits[i];
                sumOfEvenDigits += digits[i + 1];
            }

            return sumOfEvenDigits == sumOfOddDigits;
        }

        public int CountOfHappyTicket()
        {
            var countOfHappyTicket = 0;
            for (var i = 0; i <= MaxNumber; i++)
            {
                if (this.isHappyTicket(i.ConvertToArray(CountOfDigits)))
                {
                    countOfHappyTicket++;
                }
            }
        
            return countOfHappyTicket;
        }      
    }
}