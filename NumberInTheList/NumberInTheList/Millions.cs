//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    /// <summary>
    /// Contains main logic for million.
    /// </summary>
    public class Millions : Digits
    {
        /// <summary>
        /// Component of million.
        /// </summary>
        private Units units = new Units();

        /// <summary>
        /// "true", if miilion already used.
        /// </summary>
        public static bool IsUsed { get; set; }

        /// <summary>
        /// Gets string representation of digit.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string GetName()
        {
            string name = units.GetName(Digit, false);
            switch (Digit)
            {
                case 1:
                    {
                        name += " миллион";
                        break;
                    }

                case 2:
                case 3:
                case 4:
                    {
                        name += " миллиона";
                        break;
                    }

                default:
                    {
                        name += " миллионов";
                        break;
                    }
            }

            return name;
        }

        /// <summary>
        /// Extract string representation and go to tens.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string Extract()
        {
            IsUsed = true;
           return ExtractStringDigit(new Tens());
        }
    }
}
