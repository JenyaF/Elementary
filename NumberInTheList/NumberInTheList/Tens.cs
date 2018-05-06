//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    using System.Linq;

    /// <summary>
    /// Contains main logic for tens.
    /// </summary>
    public class Tens : Digits
    {
        /// <summary>
        /// Contains names from 10 to 19.
        /// </summary>
        private static string[] twenty = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };

        /// <summary>
        /// Contains names of tens.
        /// </summary>
        private static string[] tens = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

        /// <summary>
        /// Gets string representation of digit.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string GetName()
        {
            if (Digit == 1)
            {
                string unit = StackStringDigits.Pop();
                string root = (unit != string.Empty) ? unit.Substring(0, 2) : "деc";
                if (StackStringDigits.Count != 0)
                {
                    string additionalWord = unit.Split(' ')[1];
                    return twenty.FirstOrDefault(str => str.Contains(root)) + " " + additionalWord;
                }

                return twenty.FirstOrDefault(str => str.Contains(root)) + " ";
            }

            return tens[Digit];
        }

        /// <summary>
        /// Extract string representation and go to hundreds.
        /// </summary>
        public override string Extract()
        {
            return ExtractStringDigit(new Hundreds());
        }
    }
}
