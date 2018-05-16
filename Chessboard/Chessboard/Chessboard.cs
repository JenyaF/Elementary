//---------------------------------------------
// <copyright file="Chessboard.cs" company="SoftServe">
//     Copyright (c) SoftServe. All rights reserved.
// </copyright>
// <author>Jenya</author>
//----------------------------------------------

namespace Chessboard
{
    using System;

    public class Chessboard
    {      
        private int height;
        private int width;

        public Chessboard(int height, int width)
        {
            this.height = Math.Abs(height);
            this.width = Math.Abs(width);
            this.height = (this.height < Console.WindowHeight) ? this.height : Console.WindowHeight;
            this.width = (this.width < Console.WindowWidth) ? this.width : Console.WindowWidth;
        }

         public string GetField()
        {
            if ((this.width == 0) || (this.height == 0))
            {
                return string.Empty;
            }

            string oddRow = $"{this.ConcatString("*", " ", this.width)}\n";
            string evenRow = $"{this.ConcatString(" ", "*", this.width)}\n";
            return this.ConcatString(oddRow, evenRow, this.height);
        }

        /// <summary>
        /// Concatenates odd and even value specified number of times (length).
        /// For example: ConcatString("a","b",3) returns "aba"
        /// </summary>
        private string ConcatString(string oddValue, string evenValue, int length)
        {
            string representation = string.Empty;
            for (var i = 0; i < length - 1; i += 2)
            {
                representation += $"{oddValue}{evenValue}";
            }

            representation += (length % 2 == 0) ? string.Empty : $"{oddValue}";
            return representation;
        }
    }
}
