//---------------------------------------------
// <copyright file="IntHelper.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace HappyTickets
{
    public static class IntHelper
    {

        public static int[] ConvertToArray(this int number, int lengthOfArray)
        {            
            int[] digits = new int[lengthOfArray];
            var quotient = number / 10;
            digits[lengthOfArray - 1] = number % 10;
            int index = lengthOfArray - 2;
            while ((quotient != 0) && (index >= 0))
            {
                digits[index] = quotient % 10;
                quotient /= 10;
                index--;
            }

            return digits;
        }
    }
}
