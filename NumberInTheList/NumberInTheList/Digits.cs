//---------------------------------------------
// <copyright file="Digits.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------
namespace NumberInTheList
{
    using System;
    using System.Collections.Generic;

   /// <summary>
   /// Contains basic logic for string representation of digit.
   /// </summary>
    public abstract class Digits
    {
        /// <summary>
        /// Gets or sets queue of digits.
        /// </summary>
        public Queue<int> QueueDigits { get; set; }

        /// <summary>
        /// Gets or sets stack of string representaion of digits.
        /// </summary>
        public Stack<string> StackStringDigits { get; set; }

        /// <summary>
        /// Current proceed digit.
        /// </summary>
        protected int Digit { get; set; }

        /// <summary>
        /// Gets name of current digit.
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();

        /// <summary>
        /// Extract string representation of digit.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public abstract string Extract();

        /// <summary>
        /// Extract string representation of number.
        /// </summary>
        /// <param name="digits">Next proceed rank of digit.</param>
        /// <returns>string representation of number.</returns>
        protected string ExtractStringDigit(Digits digits)
        {            
            Digit = QueueDigits.Dequeue();
            StackStringDigits.Push(GetName());
            if (QueueDigits.Count != 0)
            {
                digits.QueueDigits = QueueDigits;
                digits.StackStringDigits = StackStringDigits;               
                return digits.Extract();               
            }
            else
            {
                return GetStringRepresentation();
            }
        }

        /// <summary>
        /// Convert stack of representation of digit to string
        /// </summary>
        /// <returns>String representation of number.</returns>
        protected string GetStringRepresentation()
        {
            string numberToString = "";
            foreach (var digit in StackStringDigits)
            {
                numberToString += digit + " ";
            }

            return numberToString;
        }
    }
}
