//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    /// <summary>
    /// Contains main logic for units.
    /// </summary>
    public class Units : Digits
    {  
        /// <summary>
        /// Contains name of units.
        /// </summary>
        private static string[] names = { "", "один", "два", "три", "четыри", "пять", "шесть", "семь", "восемь", "девять" };

        /// <summary>
        /// Extract string representation and go to tens.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string Extract()
        {
           return ExtractStringDigit(new Tens());
        }

        /// <summary>
        /// Gets string representation of digit.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string GetName()
        {
            return names[Digit];
        }

        /// <summary>
        /// Gets string representation of digit after smth (hundreds, million, ets).
        /// </summary>
        /// <param name="digit">Given digit.</param>
        /// <param name="isFemale">"true" if string representation has femenine gender ("тысяча")</param>
        /// <returns></returns>
        public string GetName(int digit, bool isFemale)
        {
            Digit = digit;
            if (isFemale)
            {
                if (Digit == 1)
                {
                    return "одна";
                }

                if (Digit == 2)
                {
                    return "две";
                }
            } 
            
            return GetName();
        }
    }
}
