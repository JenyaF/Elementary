//---------------------------------------------
// <copyright file="Units.cs" company="SoftServe">
//  Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{

    public class Millions : Digits
    {
        /// <summary>
        /// Component of million.
        /// </summary>
        private Units units = new Units();

        public static bool IsUsed { get; set; }

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
        /// Extract part string representation and go to tens.
        /// </summary>
        public override string Extract()
        {
            IsUsed = true;
           return ExtractStringDigit(new Tens());
        }
    }
}
