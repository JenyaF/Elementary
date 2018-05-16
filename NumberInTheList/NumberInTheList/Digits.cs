//---------------------------------------------
// <copyright file="Digits.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    using System.Collections.Generic;

    public abstract class Digits
    {

        public Queue<int> QueueDigits { get; set; }
        public Stack<string> StackStringDigits { get; set; }

        /// <summary>
        /// Current proceed digit.
        /// </summary>
        protected int Digit { get; set; }

        public abstract string GetName();

        /// <summary>
        /// Extract part string representation of number.
        /// </summary>
        public abstract string Extract();

        /// <summary>
        /// Extract string representation of number.
        /// </summary>
        /// <param name="digits">Next proceed rank of digit.</param>
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
                return string.Join(" ", StackStringDigits);
            }
        }
    }
}
