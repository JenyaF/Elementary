﻿//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    using System;

    public class Hundreds : Digits
    {
        private static string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };

        public override string GetName()
        {
            return hundreds[Digit];
        }

        /// <summary>
        /// Extract part string representation and go to next rank which wasn't used.
        /// </summary>
        public override string Extract()
        {
            string digitString;
            if (!Thousands.IsUsed)
            {
                digitString = ExtractStringDigit(new Thousands());  
            }
            else if (!Millions.IsUsed)
            {
               digitString = ExtractStringDigit(new Millions());
            }
            else if (QueueDigits.Count == 1)
            {
                digitString = string.Join(" ", StackStringDigits);
            }
            else
            {
                throw new Exception("Too large number!");
            }

            Thousands.IsUsed = false;
            Millions.IsUsed = false;
            return digitString;
        }
    }
}
