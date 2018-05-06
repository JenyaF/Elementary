//---------------------------------------------
// <copyright file="Ticket.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
    using System.Linq;

    /// <summary>
    /// Contains basic logit for ticket.
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ticket"/> class.
        /// </summary>
        /// <param name="digits">Given number of ticket.</param>
        public Ticket(int[] digits)
        {
            this.Digits = new int[digits.Length];
            digits.CopyTo(this.Digits, 0);
        }

        /// <summary>
        /// Gets count of digits in ticket.
        /// </summary>
        public static int CountOfDigits { get; } = 6;

        /// <summary>
        /// Gets or sets number of ticket.
        /// </summary>
        public int[] Digits { get; set; }

        /// <summary>
        /// Returns "true", if ticket is happy in one town.
        /// </summary>
        /// <returns>Ticket is happy</returns>
        public bool IsHappyMoskow()
        {
            int sumOfFirstDigits = this.Digits.Take(this.Digits.Length / 2).Sum();
            int sumOfLastDigits = this.Digits.Skip(this.Digits.Length / 2).Sum();
            return sumOfFirstDigits == sumOfLastDigits;
        }

        /// <summary>
        /// Returns "true", if ticket is happy in another town.
        /// </summary>
        /// <returns>Ticket is happy</returns>
        public bool IsHappyPiter()
        {
            int sumOfEvenDigits = 0;
            int sumOfOddDigits = 0;
            for (var i = 0; i < this.Digits.Length; i += 2)
            {
                sumOfOddDigits += this.Digits[i];
                sumOfEvenDigits += this.Digits[i + 1];
            }

            return sumOfEvenDigits == sumOfOddDigits;
        }
    }
}
