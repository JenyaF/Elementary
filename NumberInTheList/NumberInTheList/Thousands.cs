//---------------------------------------------
// <copyright file="Thousands.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace NumberInTheList
{
    public class Thousands : Digits
    {
        /// <summary>
        /// Component of million.
        /// </summary>
        private Units units = new Units();

        public static bool IsUsed { get; set; }

        public override string GetName()
        {           
            string name = units.GetName(Digit, true);
            switch (Digit)
            {
                case 1:
                    {
                        name += " тысяча";
                        break;
                    }

                case 2:
                case 3:
                case 4:
                    {
                        name += " тысячи";
                        break;
                    }

                default:
                    {
                        name += " тысяч";
                        break;
                    }
            }
           
            return name;          
        }

        /// <summary>
        /// Extract part string representation and go to tens.
        /// </summary>
        /// <returns>String representation of digit.</returns>
        public override string Extract()
        {
            IsUsed = true;
           return ExtractStringDigit(new Tens());            
        }
    }
}
