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

    /// <summary>
    /// Contains basic logic for tickets.
    /// </summary>
    public class HappyTickets
    {
        /// <summary>
        /// Max number of ticket.
        /// </summary>
        private const int MaxNumber = 999999;

        /// <summary>
        /// Gets count of digits in ticket.
        /// </summary>
        private const int CountOfDigits = 6;

        /// <summary>
        /// Checks if ticket is happy.
        /// </summary>
        private Func<int[], bool> isHappyTicket;

        /// <summary>
        ///  Initializes a new instance of the <see cref="HappyTickets"/> class.
        /// </summary>
        /// <param name="algorithm">Algorithm for count happy tickets.</param>
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

        /// <summary>
        /// Returns "true", if ticket is happy in one town.
        /// </summary>
        /// <param name="digits">Digits in ticket.</param>
        /// <returns>Ticket is happy</returns>
        public bool IsHappyMoskow(int[] digits)
        {
            int sumOfFirstDigits = digits.Take(digits.Length / 2).Sum();
            int sumOfLastDigits = digits.Skip(digits.Length / 2).Sum();
            return sumOfFirstDigits == sumOfLastDigits;
        }

        /// <summary>
        ///  Returns "true", if ticket is happy in another town.
        /// </summary>
        /// <param name="digits">Digits in ticket.</param>
        /// <returns>>Ticket is happy</returns>
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

        /// <summary>
        /// Count happy tickets.
        /// </summary>
        /// <returns>number of happy tickets.</returns>
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