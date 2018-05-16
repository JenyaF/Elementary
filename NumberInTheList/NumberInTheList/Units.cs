//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{

    public class Units : Digits
    {  
        private static string[] names = { "", "один", "два", "три", "четыри", "пять", "шесть", "семь", "восемь", "девять" };

        /// <summary>
        /// Extract part string representation of number and go to tens.
        /// </summary>
        public override string Extract()
        {
           return ExtractStringDigit(new Tens());
        }

        public override string GetName()
        {
            return names[Digit];
        }

        /// <summary>
        /// Gets name of digit after smth (hundreds, million, ets).
        /// </summary>
        /// <param name="isFemale">"true" if string representation has femenine gender ("тысяча")</param>
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
